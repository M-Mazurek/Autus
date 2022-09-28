﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autus
{
    [Flags]
    public enum STATE
    {
        NEW = 1,
        USED = 2
    }
    [Flags]
    public enum BODY_TYPE
    {
        HATCHBACK = 1,
        SUV = 2,
        SEDAN = 4
    }
    [Flags]
    public enum FUEL_TYPE
    {
        PETROL = 1,
        DIESEL = 2
    }

    public static class Global
    {
        readonly static SqlConnection _conn;

        public record Offer(string Author, string Title, string Desc, float Price, int ProdYear, float Mileage, string Brand, STATE State, BODY_TYPE BodyType, FUEL_TYPE FuelType);

        public static string User { get; private set; } = "user1";

        public static int AddOffer(string title, string desc, float price, int prodYear, float mileage, string brand, STATE state, BODY_TYPE bodyType, FUEL_TYPE fuelType)
        {
            string cmdTxt = "INSERT INTO offers (author, title, [desc], price, prod_year, mileage, brand, state, body_type, fuel_type) VALUES (@author, @title, @desc, @price, @prod_year, @mileage, @brand, @state, @body_type, @fuel_type)";
            SqlCommand cmd = new(cmdTxt, _conn);

            cmd.Parameters.Add("@author", System.Data.SqlDbType.VarChar, 20);
            cmd.Parameters.Add("@title", System.Data.SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@desc", System.Data.SqlDbType.VarChar, 256);
            cmd.Parameters.Add("@price", System.Data.SqlDbType.Float);
            cmd.Parameters.Add("@prod_year", System.Data.SqlDbType.SmallInt);
            cmd.Parameters.Add("@mileage", System.Data.SqlDbType.Float);
            cmd.Parameters.Add("@brand", System.Data.SqlDbType.VarChar, 20);
            cmd.Parameters.Add("@state", System.Data.SqlDbType.TinyInt);
            cmd.Parameters.Add("@body_type", System.Data.SqlDbType.TinyInt);
            cmd.Parameters.Add("@fuel_type", System.Data.SqlDbType.TinyInt);

            cmd.Parameters["@author"].Value = User;
            cmd.Parameters["@title"].Value = title;
            cmd.Parameters["@desc"].Value = desc;
            cmd.Parameters["@price"].Value = price;
            cmd.Parameters["@prod_year"].Value = prodYear;
            cmd.Parameters["@mileage"].Value = mileage;
            cmd.Parameters["@brand"].Value = brand;
            cmd.Parameters["@state"].Value = state;
            cmd.Parameters["@body_type"].Value = bodyType;
            cmd.Parameters["@fuel_type"].Value = fuelType;

            return cmd.ExecuteNonQuery();
        }

        public static Offer[] GetOffers()
        {
            return GetOffers(GetDefaultPriceRange(), GetDefaultProdYearRange(), GetDefaultMileageRange(), GetBrands(), GetDefaultStateFilter(), GetDefaultBodyTypeFilter(), 2);
        }

        public static Offer[] GetOffers((float, float) price, (int, int) prodYear, (float, float) mileage, string[] brands, int state, int bodyType, int fuelType)
        {
            List<Offer> offers = new();
            string brandsArg = brands.Length == 0 ? "" : new Func<string>(() => 
            {
                string res = " AND ";
                for (int i = 0; i < brands.Length; i++)
                {
                    res += $"brand = @brand{i} OR ";
                }
                return res.Remove(res.Length - 4);
            })();
            string cmdTxt = "SELECT * FROM offers WHERE price BETWEEN @price AND @_price" + 
                            " AND prod_year BETWEEN @prod_year AND @_prod_year" + 
                            " AND mileage BETWEEN @mileage AND @_mileage" + 
                            brandsArg +
                            " AND @state & state > 0" +
                            " AND @body_type & body_type > 0" + 
                            " AND @fuel_type & fuel_type > 0";
            SqlCommand cmd = new(cmdTxt, _conn);

            cmd.Parameters.Add("@price", System.Data.SqlDbType.Float);
            cmd.Parameters.Add("@_price", System.Data.SqlDbType.Float);
            cmd.Parameters.Add("@prod_year", System.Data.SqlDbType.SmallInt);
            cmd.Parameters.Add("@_prod_year", System.Data.SqlDbType.SmallInt);
            cmd.Parameters.Add("@mileage", System.Data.SqlDbType.Float);
            cmd.Parameters.Add("@_mileage", System.Data.SqlDbType.Float);
            cmd.Parameters.Add("@state", System.Data.SqlDbType.TinyInt);
            cmd.Parameters.Add("@body_type", System.Data.SqlDbType.TinyInt);
            cmd.Parameters.Add("@fuel_type", System.Data.SqlDbType.TinyInt);

            cmd.Parameters["@price"].Value = price.Item1;
            cmd.Parameters["@_price"].Value = price.Item2;
            cmd.Parameters["@prod_year"].Value = prodYear.Item1;
            cmd.Parameters["@_prod_year"].Value = prodYear.Item2;
            cmd.Parameters["@mileage"].Value = mileage.Item1;
            cmd.Parameters["@_mileage"].Value = mileage.Item2;
            cmd.Parameters["@state"].Value = state;
            cmd.Parameters["@body_type"].Value = bodyType;
            cmd.Parameters["@fuel_type"].Value = fuelType;

            for (int i = 0; i < brands.Length; i++)
            {
                cmd.Parameters.Add($"@brand{i}", System.Data.SqlDbType.VarChar, 20);
                cmd.Parameters[$"@brand{i}"].Value = brands[i];
            }

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                offers.Add(new(reader["author"].ToString()!, 
                                    reader["title"].ToString()!,
                                    reader["desc"].ToString()!, 
                                    (float)Convert.ToDouble(reader["price"]),
                                    Convert.ToInt32(reader["prod_year"]),
                                    (float)Convert.ToDouble(reader["mileage"]),
                                    reader["brand"].ToString()!,
                                    (STATE)Convert.ToInt32(reader["state"]),
                                    (BODY_TYPE)Convert.ToInt32(reader["body_type"]),
                                    (FUEL_TYPE)Convert.ToInt32(reader["fuel_type"])));
            }
            reader.Close();
            return offers.ToArray();
        }

        public static void AddUser(string login, string pass)
        {
            string cmdTxt = "INSERT INTO users VALUES (@login, @pass)";
            SqlCommand cmd = new(cmdTxt, _conn);

            cmd.Parameters.Add("@login", System.Data.SqlDbType.VarChar, 20);
            cmd.Parameters.Add("@pass", System.Data.SqlDbType.VarChar, 20);

            cmd.Parameters["@login"].Value = login;
            cmd.Parameters["@pass"].Value = pass;

            cmd.ExecuteNonQuery();
        }

        public static bool HasUser(string login)
        {
            string cmdTxt = "SELECT COUNT(login) FROM users WHERE login = @login";
            SqlCommand cmd = new(cmdTxt, _conn);

            cmd.Parameters.Add("@login", System.Data.SqlDbType.VarChar, 20);

            cmd.Parameters["@login"].Value = login;

            return Convert.ToInt32(cmd.ExecuteScalar()) == 1;
        }

        #region defaults
        public static (float, float) GetDefaultPriceRange()
        {
            (float, float) res = default;

            string cmdTxt = "SELECT MIN(price), MAX(price) FROM offers";
            SqlCommand cmd = new(cmdTxt, _conn);

            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();
            try
            {
                res = ((float)Convert.ToDouble(reader[0]), (float)Convert.ToDouble(reader[1]));
            }
            catch { }
            reader.Close();

            return res;
        }

        public static (int, int) GetDefaultProdYearRange()
        {
            (int, int) res = default;

            string cmdTxt = "SELECT MIN(prod_year), MAX(prod_year) FROM offers";
            SqlCommand cmd = new(cmdTxt, _conn);

            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            try
            {
                res = (Convert.ToInt32(reader[0]), Convert.ToInt32(reader[1]));
            }
            catch { }
            reader.Close();

            return res;
        }

        public static (float, float) GetDefaultMileageRange()
        {
            (float, float) res = default;

            string cmdTxt = "SELECT MIN(mileage), MAX(mileage) FROM offers";
            SqlCommand cmd = new(cmdTxt, _conn);

            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            try
            {
                res = ((float)Convert.ToDouble(reader[0]), (float)Convert.ToDouble(reader[1]));
            }
            catch { }
            reader.Close();

            return res;
        }

        public static string[] GetBrands()
        {
            List<string> res = new();

            string cmdTxt = "SELECT DISTINCT(brand) FROM offers";
            SqlCommand cmd = new(cmdTxt, _conn);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                res.Add(reader[0].ToString()!);
            }
            reader.Close();

            return res.ToArray();
        }

        public static int GetDefaultStateFilter() => Enum.GetValues(typeof(STATE)).Cast<int>().Last() * 2 - 1;
        public static int GetDefaultBodyTypeFilter() => Enum.GetValues(typeof(BODY_TYPE)).Cast<int>().Last() * 2 - 1;
        public static int GetDefaultFuelTypeFilter() => Enum.GetValues(typeof(FUEL_TYPE)).Cast<int>().Last() * 2 - 1;
        #endregion
        static Global()
        {
            string dbPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory())!.Parent!.Parent!.FullName, "Database.mdf");
            string connStr = @$"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={dbPath};Integrated Security=True";

            _conn = new(connStr);
            _conn.Open();
        }
    }
}