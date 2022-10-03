namespace Autus {
    partial class OfferForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OfferForm));
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnAddOffer = new System.Windows.Forms.Button();
            this.btnOffers = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.offers = new System.Windows.Forms.Panel();
            this.pictures = new System.Windows.Forms.PictureBox();
            this.lblPics = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCar = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnBuy = new System.Windows.Forms.Button();
            this.lblMileage = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblProd = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblFuel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.offers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictures)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAccount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAccount.Location = new System.Drawing.Point(916, 47);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(438, 49);
            this.btnAccount.TabIndex = 17;
            this.btnAccount.Text = "Moje konto";
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnAddOffer
            // 
            this.btnAddOffer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnAddOffer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOffer.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddOffer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddOffer.Location = new System.Drawing.Point(481, 47);
            this.btnAddOffer.Name = "btnAddOffer";
            this.btnAddOffer.Size = new System.Drawing.Size(438, 49);
            this.btnAddOffer.TabIndex = 16;
            this.btnAddOffer.Text = "Dodaj ofertę";
            this.btnAddOffer.UseVisualStyleBackColor = false;
            this.btnAddOffer.Click += new System.EventHandler(this.btnAddOffer_Click);
            // 
            // btnOffers
            // 
            this.btnOffers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnOffers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOffers.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOffers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOffers.Location = new System.Drawing.Point(46, 47);
            this.btnOffers.Name = "btnOffers";
            this.btnOffers.Size = new System.Drawing.Size(438, 49);
            this.btnOffers.TabIndex = 15;
            this.btnOffers.Text = "Oferty";
            this.btnOffers.UseVisualStyleBackColor = false;
            this.btnOffers.Click += new System.EventHandler(this.btnOffers_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Ubuntu", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(333, 121);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(319, 39);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Oferta użytkownika: ";
            // 
            // offers
            // 
            this.offers.AutoScroll = true;
            this.offers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.offers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.offers.Controls.Add(this.lblDesc);
            this.offers.Controls.Add(this.label1);
            this.offers.Controls.Add(this.pictures);
            this.offers.Controls.Add(this.lblPics);
            this.offers.Location = new System.Drawing.Point(333, 191);
            this.offers.Name = "offers";
            this.offers.Size = new System.Drawing.Size(1021, 531);
            this.offers.TabIndex = 19;
            // 
            // pictures
            // 
            this.pictures.Location = new System.Drawing.Point(19, 97);
            this.pictures.Name = "pictures";
            this.pictures.Size = new System.Drawing.Size(657, 387);
            this.pictures.TabIndex = 20;
            this.pictures.TabStop = false;
            // 
            // lblPics
            // 
            this.lblPics.AutoSize = true;
            this.lblPics.Font = new System.Drawing.Font("Ubuntu", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPics.ForeColor = System.Drawing.Color.White;
            this.lblPics.Location = new System.Drawing.Point(19, 34);
            this.lblPics.Name = "lblPics";
            this.lblPics.Size = new System.Drawing.Size(312, 39);
            this.lblPics.TabIndex = 19;
            this.lblPics.Text = "Zdjęcia samochodu: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblFuel);
            this.panel1.Controls.Add(this.lblState);
            this.panel1.Controls.Add(this.lblProd);
            this.panel1.Controls.Add(this.lblType);
            this.panel1.Controls.Add(this.lblMileage);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblCar);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.btnBuy);
            this.panel1.Location = new System.Drawing.Point(46, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 601);
            this.panel1.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(73, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 26);
            this.label3.TabIndex = 21;
            this.label3.Text = "Szczegóły";
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCar.ForeColor = System.Drawing.Color.White;
            this.lblCar.Location = new System.Drawing.Point(21, 68);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(48, 17);
            this.lblCar.TabIndex = 20;
            this.lblCar.Text = "Marka:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(21, 386);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(42, 17);
            this.lblPrice.TabIndex = 19;
            this.lblPrice.Text = "Cena:";
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(115)))), ((int)(((byte)(3)))));
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuy.ForeColor = System.Drawing.Color.White;
            this.btnBuy.Location = new System.Drawing.Point(63, 522);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(140, 49);
            this.btnBuy.TabIndex = 1;
            this.btnBuy.Text = "Kup";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // lblMileage
            // 
            this.lblMileage.AutoSize = true;
            this.lblMileage.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMileage.ForeColor = System.Drawing.Color.White;
            this.lblMileage.Location = new System.Drawing.Point(21, 104);
            this.lblMileage.Name = "lblMileage";
            this.lblMileage.Size = new System.Drawing.Size(65, 17);
            this.lblMileage.TabIndex = 22;
            this.lblMileage.Text = "Przebieg:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblType.ForeColor = System.Drawing.Color.White;
            this.lblType.Location = new System.Drawing.Point(21, 138);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(106, 17);
            this.lblType.TabIndex = 23;
            this.lblType.Text = "Typ samochodu:";
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProd.ForeColor = System.Drawing.Color.White;
            this.lblProd.Location = new System.Drawing.Point(21, 177);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(93, 17);
            this.lblProd.TabIndex = 24;
            this.lblProd.Text = "Rok produkcji:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblState.ForeColor = System.Drawing.Color.White;
            this.lblState.Location = new System.Drawing.Point(21, 217);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(38, 17);
            this.lblState.TabIndex = 25;
            this.lblState.Text = "Stan:";
            // 
            // lblFuel
            // 
            this.lblFuel.AutoSize = true;
            this.lblFuel.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFuel.ForeColor = System.Drawing.Color.White;
            this.lblFuel.Location = new System.Drawing.Point(21, 251);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(92, 17);
            this.lblFuel.TabIndex = 26;
            this.lblFuel.Text = "Rodzaj paliwa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ubuntu", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(682, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Opis";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDesc.ForeColor = System.Drawing.Color.White;
            this.lblDesc.Location = new System.Drawing.Point(691, 97);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(35, 17);
            this.lblDesc.TabIndex = 22;
            this.lblDesc.Text = "Opis";
            // 
            // OfferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1384, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.offers);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.btnAddOffer);
            this.Controls.Add(this.btnOffers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1400, 788);
            this.MinimumSize = new System.Drawing.Size(1400, 788);
            this.Name = "OfferForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autus : Oferta";
            this.Load += new System.EventHandler(this.OfferForm_Load);
            this.offers.ResumeLayout(false);
            this.offers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictures)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAccount;
        private Button btnAddOffer;
        private Button btnOffers;
        private Label lblTitle;
        private Panel offers;
        private Panel panel1;
        private Button btnBuy;
        private Label lblPics;
        private PictureBox pictures;
        private Label lblPrice;
        private Label label3;
        private Label lblCar;
        private Label lblMileage;
        private Label lblType;
        private Label label1;
        private Label lblFuel;
        private Label lblState;
        private Label lblProd;
        private Label lblDesc;
    }
}