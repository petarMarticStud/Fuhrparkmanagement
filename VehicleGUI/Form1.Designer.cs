namespace VehicleGUI
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxMark = new System.Windows.Forms.TextBox();
            this.tbxBrand = new System.Windows.Forms.TextBox();
            this.tbxType = new System.Windows.Forms.TextBox();
            this.tbxChassisNumber = new System.Windows.Forms.TextBox();
            this.tbxNumberSeats = new System.Windows.Forms.TextBox();
            this.tbxPayload = new System.Windows.Forms.TextBox();
            this.lblMark = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblChassisNumber = new System.Windows.Forms.Label();
            this.lblNumberSeats = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPayload = new System.Windows.Forms.Label();
            this.cbxCar = new System.Windows.Forms.CheckBox();
            this.cbxTruck = new System.Windows.Forms.CheckBox();
            this.lbxVehicles = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.tbxFilename = new System.Windows.Forms.TextBox();
            this.btnAll = new System.Windows.Forms.Button();
            this.lblFilename = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxMark
            // 
            this.tbxMark.Location = new System.Drawing.Point(98, 45);
            this.tbxMark.Name = "tbxMark";
            this.tbxMark.Size = new System.Drawing.Size(100, 20);
            this.tbxMark.TabIndex = 2;
            this.tbxMark.Visible = false;
            // 
            // tbxBrand
            // 
            this.tbxBrand.Location = new System.Drawing.Point(98, 84);
            this.tbxBrand.Name = "tbxBrand";
            this.tbxBrand.Size = new System.Drawing.Size(100, 20);
            this.tbxBrand.TabIndex = 3;
            this.tbxBrand.Visible = false;
            // 
            // tbxType
            // 
            this.tbxType.Location = new System.Drawing.Point(98, 123);
            this.tbxType.Name = "tbxType";
            this.tbxType.Size = new System.Drawing.Size(100, 20);
            this.tbxType.TabIndex = 4;
            this.tbxType.Visible = false;
            // 
            // tbxChassisNumber
            // 
            this.tbxChassisNumber.Location = new System.Drawing.Point(98, 160);
            this.tbxChassisNumber.Name = "tbxChassisNumber";
            this.tbxChassisNumber.Size = new System.Drawing.Size(100, 20);
            this.tbxChassisNumber.TabIndex = 5;
            this.tbxChassisNumber.Visible = false;
            // 
            // tbxNumberSeats
            // 
            this.tbxNumberSeats.Location = new System.Drawing.Point(121, 198);
            this.tbxNumberSeats.Name = "tbxNumberSeats";
            this.tbxNumberSeats.Size = new System.Drawing.Size(77, 20);
            this.tbxNumberSeats.TabIndex = 6;
            this.tbxNumberSeats.Visible = false;
            // 
            // tbxPayload
            // 
            this.tbxPayload.Location = new System.Drawing.Point(98, 236);
            this.tbxPayload.Name = "tbxPayload";
            this.tbxPayload.Size = new System.Drawing.Size(100, 20);
            this.tbxPayload.TabIndex = 7;
            this.tbxPayload.Visible = false;
            // 
            // lblMark
            // 
            this.lblMark.AutoSize = true;
            this.lblMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMark.Location = new System.Drawing.Point(8, 49);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(84, 16);
            this.lblMark.TabIndex = 8;
            this.lblMark.Text = "Kennzeichen";
            this.lblMark.Visible = false;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(46, 88);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(46, 16);
            this.lblBrand.TabIndex = 9;
            this.lblBrand.Text = "Marke";
            this.lblBrand.Visible = false;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(60, 127);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(32, 16);
            this.lblType.TabIndex = 10;
            this.lblType.Text = "Typ";
            this.lblType.Visible = false;
            // 
            // lblChassisNumber
            // 
            this.lblChassisNumber.AutoSize = true;
            this.lblChassisNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChassisNumber.Location = new System.Drawing.Point(6, 164);
            this.lblChassisNumber.Name = "lblChassisNumber";
            this.lblChassisNumber.Size = new System.Drawing.Size(86, 16);
            this.lblChassisNumber.TabIndex = 11;
            this.lblChassisNumber.Text = "Fahrgestellnr";
            this.lblChassisNumber.Visible = false;
            // 
            // lblNumberSeats
            // 
            this.lblNumberSeats.AutoSize = true;
            this.lblNumberSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberSeats.Location = new System.Drawing.Point(8, 202);
            this.lblNumberSeats.Name = "lblNumberSeats";
            this.lblNumberSeats.Size = new System.Drawing.Size(107, 16);
            this.lblNumberSeats.TabIndex = 12;
            this.lblNumberSeats.Text = "Anz. d. Sitzplätze";
            this.lblNumberSeats.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 13;
            // 
            // lblPayload
            // 
            this.lblPayload.AutoSize = true;
            this.lblPayload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblPayload.Location = new System.Drawing.Point(33, 239);
            this.lblPayload.Name = "lblPayload";
            this.lblPayload.Size = new System.Drawing.Size(59, 17);
            this.lblPayload.TabIndex = 14;
            this.lblPayload.Text = "Nutzlast";
            this.lblPayload.Visible = false;
            // 
            // cbxCar
            // 
            this.cbxCar.AutoSize = true;
            this.cbxCar.Location = new System.Drawing.Point(89, 12);
            this.cbxCar.Name = "cbxCar";
            this.cbxCar.Size = new System.Drawing.Size(51, 17);
            this.cbxCar.TabIndex = 15;
            this.cbxCar.Text = "PKW";
            this.cbxCar.UseVisualStyleBackColor = true;
            this.cbxCar.CheckedChanged += new System.EventHandler(this.cbxCar_CheckedChanged);
            // 
            // cbxTruck
            // 
            this.cbxTruck.AutoSize = true;
            this.cbxTruck.Location = new System.Drawing.Point(164, 12);
            this.cbxTruck.Name = "cbxTruck";
            this.cbxTruck.Size = new System.Drawing.Size(50, 17);
            this.cbxTruck.TabIndex = 16;
            this.cbxTruck.Text = "LKW";
            this.cbxTruck.UseVisualStyleBackColor = true;
            this.cbxTruck.CheckedChanged += new System.EventHandler(this.cbxTruck_CheckedChanged);
            // 
            // lbxVehicles
            // 
            this.lbxVehicles.FormattingEnabled = true;
            this.lbxVehicles.Location = new System.Drawing.Point(321, 12);
            this.lbxVehicles.Name = "lbxVehicles";
            this.lbxVehicles.Size = new System.Drawing.Size(275, 355);
            this.lbxVehicles.TabIndex = 17;
            this.lbxVehicles.Tag = "";
            this.lbxVehicles.SelectedIndexChanged += new System.EventHandler(this.lbxVehicles_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(98, 272);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 26);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Hinzufügen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(184, 357);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 20);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(321, 373);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(117, 23);
            this.btnSort.TabIndex = 20;
            this.btnSort.Text = "Sortieren";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Visible = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(184, 397);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 20);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(484, 373);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(112, 23);
            this.btnImport.TabIndex = 22;
            this.btnImport.Text = "Importieren";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Visible = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(60, 357);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(118, 20);
            this.tbxSearch.TabIndex = 23;
            this.tbxSearch.Visible = false;
            // 
            // tbxFilename
            // 
            this.tbxFilename.Location = new System.Drawing.Point(60, 397);
            this.tbxFilename.Name = "tbxFilename";
            this.tbxFilename.Size = new System.Drawing.Size(118, 20);
            this.tbxFilename.TabIndex = 24;
            this.tbxFilename.Visible = false;
            // 
            // btnAll
            // 
            this.btnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.Location = new System.Drawing.Point(409, 402);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(100, 26);
            this.btnAll.TabIndex = 25;
            this.btnAll.Text = "Alle ";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Visible = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblFilename.Location = new System.Drawing.Point(86, 420);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(76, 17);
            this.lblFilename.TabIndex = 26;
            this.lblFilename.Text = "Dateiname";
            this.lblFilename.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFilename);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.tbxFilename);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbxVehicles);
            this.Controls.Add(this.cbxTruck);
            this.Controls.Add(this.cbxCar);
            this.Controls.Add(this.lblPayload);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNumberSeats);
            this.Controls.Add(this.lblChassisNumber);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblMark);
            this.Controls.Add(this.tbxPayload);
            this.Controls.Add(this.tbxNumberSeats);
            this.Controls.Add(this.tbxChassisNumber);
            this.Controls.Add(this.tbxType);
            this.Controls.Add(this.tbxBrand);
            this.Controls.Add(this.tbxMark);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxMark;
        private System.Windows.Forms.TextBox tbxBrand;
        private System.Windows.Forms.TextBox tbxType;
        private System.Windows.Forms.TextBox tbxChassisNumber;
        private System.Windows.Forms.TextBox tbxNumberSeats;
        private System.Windows.Forms.TextBox tbxPayload;
        private System.Windows.Forms.Label lblMark;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblChassisNumber;
        private System.Windows.Forms.Label lblNumberSeats;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPayload;
        private System.Windows.Forms.CheckBox cbxCar;
        private System.Windows.Forms.CheckBox cbxTruck;
        private System.Windows.Forms.ListBox lbxVehicles;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.TextBox tbxFilename;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Label lblFilename;
    }
}

