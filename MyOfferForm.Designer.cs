namespace Autus {
    partial class MyOfferForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyOfferForm));
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnAddOffer = new System.Windows.Forms.Button();
            this.btnOffers = new System.Windows.Forms.Button();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.offerByPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDesc = new System.Windows.Forms.Label();
            this.pictures = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFuel = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblProd = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblMileage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCar = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRet = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.offerByPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictures)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.btnAddOffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.btnOffers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOffers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOffers.Location = new System.Drawing.Point(46, 47);
            this.btnOffers.Name = "btnOffers";
            this.btnOffers.Size = new System.Drawing.Size(438, 49);
            this.btnOffers.TabIndex = 15;
            this.btnOffers.Text = "Oferty";
            this.btnOffers.UseVisualStyleBackColor = false;
            this.btnOffers.Click += new System.EventHandler(this.btnOffers_Click);
            // 
            // lblAuthor
            // 
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAuthor.ForeColor = System.Drawing.Color.White;
            this.lblAuthor.Location = new System.Drawing.Point(16, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(329, 271);
            this.lblAuthor.TabIndex = 18;
            this.lblAuthor.Text = "Oferta użytkownika:";
            this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // offerByPanel
            // 
            this.offerByPanel.AutoScroll = true;
            this.offerByPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.offerByPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.offerByPanel.Controls.Add(this.panel2);
            this.offerByPanel.Controls.Add(this.lblAuthor);
            this.offerByPanel.Controls.Add(this.pictures);
            this.offerByPanel.Location = new System.Drawing.Point(492, 191);
            this.offerByPanel.Name = "offerByPanel";
            this.offerByPanel.Size = new System.Drawing.Size(862, 531);
            this.offerByPanel.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblDesc);
            this.panel2.Location = new System.Drawing.Point(3, 279);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(851, 245);
            this.panel2.TabIndex = 23;
            // 
            // lblDesc
            // 
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDesc.ForeColor = System.Drawing.Color.White;
            this.lblDesc.Location = new System.Drawing.Point(13, 12);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(831, 222);
            this.lblDesc.TabIndex = 22;
            this.lblDesc.Text = "Opis";
            // 
            // pictures
            // 
            this.pictures.Location = new System.Drawing.Point(351, 3);
            this.pictures.Name = "pictures";
            this.pictures.Size = new System.Drawing.Size(503, 270);
            this.pictures.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictures.TabIndex = 20;
            this.pictures.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(46, 121);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1308, 54);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "Tytuł";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.panel1.Location = new System.Drawing.Point(46, 191);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 406);
            this.panel1.TabIndex = 20;
            // 
            // lblFuel
            // 
            this.lblFuel.AutoSize = true;
            this.lblFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFuel.ForeColor = System.Drawing.Color.White;
            this.lblFuel.Location = new System.Drawing.Point(21, 277);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(111, 20);
            this.lblFuel.TabIndex = 26;
            this.lblFuel.Text = "Rodzaj paliwa:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblState.ForeColor = System.Drawing.Color.White;
            this.lblState.Location = new System.Drawing.Point(21, 243);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(47, 20);
            this.lblState.TabIndex = 25;
            this.lblState.Text = "Stan:";
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProd.ForeColor = System.Drawing.Color.White;
            this.lblProd.Location = new System.Drawing.Point(21, 203);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(109, 20);
            this.lblProd.TabIndex = 24;
            this.lblProd.Text = "Rok produkcji:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblType.ForeColor = System.Drawing.Color.White;
            this.lblType.Location = new System.Drawing.Point(21, 164);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(125, 20);
            this.lblType.TabIndex = 23;
            this.lblType.Text = "Typ samochodu:";
            // 
            // lblMileage
            // 
            this.lblMileage.AutoSize = true;
            this.lblMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMileage.ForeColor = System.Drawing.Color.White;
            this.lblMileage.Location = new System.Drawing.Point(21, 130);
            this.lblMileage.Name = "lblMileage";
            this.lblMileage.Size = new System.Drawing.Size(75, 20);
            this.lblMileage.TabIndex = 22;
            this.lblMileage.Text = "Przebieg:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(419, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Szczegóły";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCar.ForeColor = System.Drawing.Color.White;
            this.lblCar.Location = new System.Drawing.Point(21, 94);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(57, 20);
            this.lblCar.TabIndex = 20;
            this.lblCar.Text = "Marka:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(21, 347);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(76, 29);
            this.lblPrice.TabIndex = 19;
            this.lblPrice.Text = "Cena:";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(115)))), ((int)(((byte)(3)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(46, 647);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(137, 49);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edytuj ofertę";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRet
            // 
            this.btnRet.BackColor = System.Drawing.Color.Gray;
            this.btnRet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRet.ForeColor = System.Drawing.Color.White;
            this.btnRet.Location = new System.Drawing.Point(335, 647);
            this.btnRet.Name = "btnRet";
            this.btnRet.Size = new System.Drawing.Size(140, 49);
            this.btnRet.TabIndex = 21;
            this.btnRet.Text = "Powrót";
            this.btnRet.UseVisualStyleBackColor = false;
            this.btnRet.Click += new System.EventHandler(this.btnRet_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(189, 647);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(140, 49);
            this.btnRemove.TabIndex = 22;
            this.btnRemove.Text = "Usuń ofertę";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // MyOfferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1384, 749);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRet);
            this.Controls.Add(this.offerByPanel);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddOffer);
            this.Controls.Add(this.btnOffers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1400, 788);
            this.MinimumSize = new System.Drawing.Size(1400, 788);
            this.Name = "MyOfferForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autus : Oferta";
            this.Load += new System.EventHandler(this.MyOfferForm_Load);
            this.offerByPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictures)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAccount;
        private Button btnAddOffer;
        private Button btnOffers;
        private Label lblAuthor;
        private Panel offerByPanel;
        private Panel panel1;
        private Button btnEdit;
        private Label lblTitle;
        private PictureBox pictures;
        private Label lblPrice;
        private Label label3;
        private Label lblCar;
        private Label lblMileage;
        private Label lblType;
        private Label lblFuel;
        private Label lblState;
        private Label lblProd;
        private Label lblDesc;
        private Button btnRet;
        private Panel panel2;
        private Button btnRemove;
    }
}