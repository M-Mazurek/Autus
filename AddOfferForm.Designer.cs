namespace Autus {
    partial class AddOfferForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOfferForm));
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnAddOffer = new System.Windows.Forms.Button();
            this.btnOffers = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCar = new System.Windows.Forms.TextBox();
            this.txtMileage = new System.Windows.Forms.TextBox();
            this.txtProd = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.cbBody = new System.Windows.Forms.ComboBox();
            this.cbFuel = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnAttach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAccount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAccount.Location = new System.Drawing.Point(905, 44);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(438, 49);
            this.btnAccount.TabIndex = 11;
            this.btnAccount.Text = "Moje konto";
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnAddOffer
            // 
            this.btnAddOffer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnAddOffer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddOffer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddOffer.Location = new System.Drawing.Point(470, 44);
            this.btnAddOffer.Name = "btnAddOffer";
            this.btnAddOffer.Size = new System.Drawing.Size(438, 49);
            this.btnAddOffer.TabIndex = 10;
            this.btnAddOffer.Text = "Dodaj ofertę";
            this.btnAddOffer.UseVisualStyleBackColor = false;
            // 
            // btnOffers
            // 
            this.btnOffers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnOffers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOffers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOffers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOffers.Location = new System.Drawing.Point(35, 44);
            this.btnOffers.Name = "btnOffers";
            this.btnOffers.Size = new System.Drawing.Size(438, 49);
            this.btnOffers.TabIndex = 9;
            this.btnOffers.Text = "Oferty";
            this.btnOffers.UseVisualStyleBackColor = false;
            this.btnOffers.Click += new System.EventHandler(this.btnOffers_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(35, 116);
            this.txtName.MaxLength = 80;
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "Nazwa oferty";
            this.txtName.Size = new System.Drawing.Size(1308, 49);
            this.txtName.TabIndex = 12;
            this.txtName.WordWrap = false;
            // 
            // txtCar
            // 
            this.txtCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCar.ForeColor = System.Drawing.Color.White;
            this.txtCar.Location = new System.Drawing.Point(709, 218);
            this.txtCar.MaxLength = 80;
            this.txtCar.Multiline = true;
            this.txtCar.Name = "txtCar";
            this.txtCar.PlaceholderText = "Marka samochodu";
            this.txtCar.Size = new System.Drawing.Size(301, 49);
            this.txtCar.TabIndex = 13;
            this.txtCar.WordWrap = false;
            // 
            // txtMileage
            // 
            this.txtMileage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMileage.ForeColor = System.Drawing.Color.White;
            this.txtMileage.Location = new System.Drawing.Point(709, 313);
            this.txtMileage.MaxLength = 80;
            this.txtMileage.Multiline = true;
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.PlaceholderText = "Przebieg";
            this.txtMileage.Size = new System.Drawing.Size(301, 49);
            this.txtMileage.TabIndex = 16;
            this.txtMileage.WordWrap = false;
            // 
            // txtProd
            // 
            this.txtProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProd.ForeColor = System.Drawing.Color.White;
            this.txtProd.Location = new System.Drawing.Point(709, 414);
            this.txtProd.MaxLength = 80;
            this.txtProd.Multiline = true;
            this.txtProd.Name = "txtProd";
            this.txtProd.PlaceholderText = "Rok produkcji";
            this.txtProd.Size = new System.Drawing.Size(301, 49);
            this.txtProd.TabIndex = 17;
            this.txtProd.WordWrap = false;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrice.ForeColor = System.Drawing.Color.White;
            this.txtPrice.Location = new System.Drawing.Point(1042, 506);
            this.txtPrice.MaxLength = 80;
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PlaceholderText = "Cena";
            this.txtPrice.Size = new System.Drawing.Size(301, 49);
            this.txtPrice.TabIndex = 20;
            this.txtPrice.WordWrap = false;
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDesc.ForeColor = System.Drawing.Color.White;
            this.txtDesc.Location = new System.Drawing.Point(35, 218);
            this.txtDesc.MaxLength = 256;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.PlaceholderText = "Opis";
            this.txtDesc.Size = new System.Drawing.Size(647, 337);
            this.txtDesc.TabIndex = 21;
            this.txtDesc.WordWrap = false;
            // 
            // cbState
            // 
            this.cbState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.cbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbState.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbState.ForeColor = System.Drawing.Color.Gray;
            this.cbState.FormattingEnabled = true;
            this.cbState.IntegralHeight = false;
            this.cbState.ItemHeight = 29;
            this.cbState.Items.AddRange(new object[] {
            "Nowy",
            "Używany"});
            this.cbState.Location = new System.Drawing.Point(1042, 218);
            this.cbState.MaxDropDownItems = 40;
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(301, 37);
            this.cbState.TabIndex = 22;
            // 
            // cbBody
            // 
            this.cbBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.cbBody.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbBody.ForeColor = System.Drawing.Color.Gray;
            this.cbBody.FormattingEnabled = true;
            this.cbBody.IntegralHeight = false;
            this.cbBody.ItemHeight = 29;
            this.cbBody.Items.AddRange(new object[] {
            "Hatchback",
            "SUV",
            "Sedan"});
            this.cbBody.Location = new System.Drawing.Point(1042, 313);
            this.cbBody.MaxDropDownItems = 40;
            this.cbBody.Name = "cbBody";
            this.cbBody.Size = new System.Drawing.Size(301, 37);
            this.cbBody.TabIndex = 23;
            // 
            // cbFuel
            // 
            this.cbFuel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.cbFuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbFuel.ForeColor = System.Drawing.Color.Gray;
            this.cbFuel.FormattingEnabled = true;
            this.cbFuel.IntegralHeight = false;
            this.cbFuel.ItemHeight = 29;
            this.cbFuel.Items.AddRange(new object[] {
            "Benzyna",
            "Diesel"});
            this.cbFuel.Location = new System.Drawing.Point(1042, 414);
            this.cbFuel.MaxDropDownItems = 40;
            this.cbFuel.Name = "cbFuel";
            this.cbFuel.Size = new System.Drawing.Size(301, 37);
            this.cbFuel.TabIndex = 24;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(41)))), ((int)(((byte)(170)))));
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(1203, 659);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(140, 49);
            this.btnConfirm.TabIndex = 25;
            this.btnConfirm.Text = "Potwierdź";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnAttach
            // 
            this.btnAttach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(41)))), ((int)(((byte)(170)))));
            this.btnAttach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttach.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAttach.ForeColor = System.Drawing.Color.White;
            this.btnAttach.Location = new System.Drawing.Point(35, 659);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(323, 49);
            this.btnAttach.TabIndex = 26;
            this.btnAttach.Text = "Załącz zdjęcia";
            this.btnAttach.UseVisualStyleBackColor = false;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // AddOfferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1384, 749);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.cbFuel);
            this.Controls.Add(this.cbBody);
            this.Controls.Add(this.cbState);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtProd);
            this.Controls.Add(this.txtMileage);
            this.Controls.Add(this.txtCar);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.btnAddOffer);
            this.Controls.Add(this.btnOffers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1400, 788);
            this.MinimumSize = new System.Drawing.Size(1400, 788);
            this.Name = "AddOfferForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autus : Dodaj ofertę";
            this.Load += new System.EventHandler(this.AddOfferForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAccount;
        private Button btnAddOffer;
        private Button btnOffers;
        private TextBox txtName;
        private TextBox txtCar;
        private TextBox txtMileage;
        private TextBox txtProd;
        private TextBox txtPrice;
        private TextBox txtDesc;
        private ComboBox cbState;
        private ComboBox cbBody;
        private ComboBox cbFuel;
        private Button btnConfirm;
        private Button btnAttach;
    }
}