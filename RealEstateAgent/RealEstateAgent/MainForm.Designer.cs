
namespace RealEstateAgent
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbRegister = new System.Windows.Forms.GroupBox();
            this.panelRegister = new System.Windows.Forms.Panel();
            this.tbFee = new System.Windows.Forms.TextBox();
            this.tbRooms = new System.Windows.Forms.TextBox();
            this.labelFee = new System.Windows.Forms.Label();
            this.rbRental = new System.Windows.Forms.RadioButton();
            this.tbPlotSize = new System.Windows.Forms.TextBox();
            this.rbCondominium = new System.Windows.Forms.RadioButton();
            this.labelPlotSize = new System.Windows.Forms.Label();
            this.rbOwnership = new System.Windows.Forms.RadioButton();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.labelNrOfRooms = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelLivingArea = new System.Windows.Forms.Label();
            this.tbLivingArea = new System.Windows.Forms.TextBox();
            this.cbTypes = new System.Windows.Forms.ComboBox();
            this.labelEstate = new System.Windows.Forms.Label();
            this.gbAdress = new System.Windows.Forms.GroupBox();
            this.panelAdress = new System.Windows.Forms.Panel();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.labelCountry = new System.Windows.Forms.Label();
            this.buttonAddPic = new System.Windows.Forms.Button();
            this.tbZipCode = new System.Windows.Forms.TextBox();
            this.tbFloorOrName = new System.Windows.Forms.TextBox();
            this.labelStreet = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.labelZipCode = new System.Windows.Forms.Label();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.labelFloorOrName = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.lbEstates = new System.Windows.Forms.ListBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.gbEstateInfo = new System.Windows.Forms.GroupBox();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.pbEstate = new System.Windows.Forms.PictureBox();
            this.gbRegister.SuspendLayout();
            this.panelRegister.SuspendLayout();
            this.gbAdress.SuspendLayout();
            this.panelAdress.SuspendLayout();
            this.gbEstateInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstate)).BeginInit();
            this.SuspendLayout();
            // 
            // gbRegister
            // 
            this.gbRegister.Controls.Add(this.panelRegister);
            this.gbRegister.Controls.Add(this.cbTypes);
            this.gbRegister.Controls.Add(this.labelEstate);
            this.gbRegister.Location = new System.Drawing.Point(12, 12);
            this.gbRegister.Name = "gbRegister";
            this.gbRegister.Size = new System.Drawing.Size(275, 243);
            this.gbRegister.TabIndex = 0;
            this.gbRegister.TabStop = false;
            this.gbRegister.Text = "Register Estate";
            // 
            // panelRegister
            // 
            this.panelRegister.Controls.Add(this.tbFee);
            this.panelRegister.Controls.Add(this.tbRooms);
            this.panelRegister.Controls.Add(this.labelFee);
            this.panelRegister.Controls.Add(this.rbRental);
            this.panelRegister.Controls.Add(this.tbPlotSize);
            this.panelRegister.Controls.Add(this.rbCondominium);
            this.panelRegister.Controls.Add(this.labelPlotSize);
            this.panelRegister.Controls.Add(this.rbOwnership);
            this.panelRegister.Controls.Add(this.tbPrice);
            this.panelRegister.Controls.Add(this.labelNrOfRooms);
            this.panelRegister.Controls.Add(this.labelPrice);
            this.panelRegister.Controls.Add(this.labelLivingArea);
            this.panelRegister.Controls.Add(this.tbLivingArea);
            this.panelRegister.Location = new System.Drawing.Point(6, 49);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(269, 192);
            this.panelRegister.TabIndex = 1;
            // 
            // tbFee
            // 
            this.tbFee.Location = new System.Drawing.Point(164, 161);
            this.tbFee.Name = "tbFee";
            this.tbFee.Size = new System.Drawing.Size(95, 23);
            this.tbFee.TabIndex = 16;
            // 
            // tbRooms
            // 
            this.tbRooms.Location = new System.Drawing.Point(164, 45);
            this.tbRooms.Name = "tbRooms";
            this.tbRooms.Size = new System.Drawing.Size(95, 23);
            this.tbRooms.TabIndex = 8;
            // 
            // labelFee
            // 
            this.labelFee.AutoSize = true;
            this.labelFee.Location = new System.Drawing.Point(3, 164);
            this.labelFee.Name = "labelFee";
            this.labelFee.Size = new System.Drawing.Size(25, 15);
            this.labelFee.TabIndex = 15;
            this.labelFee.Text = "Fee";
            // 
            // rbRental
            // 
            this.rbRental.AutoSize = true;
            this.rbRental.Location = new System.Drawing.Point(3, 6);
            this.rbRental.Name = "rbRental";
            this.rbRental.Size = new System.Drawing.Size(58, 19);
            this.rbRental.TabIndex = 3;
            this.rbRental.TabStop = true;
            this.rbRental.Text = "Rental";
            this.rbRental.UseVisualStyleBackColor = true;
            this.rbRental.CheckedChanged += new System.EventHandler(this.rbRental_CheckedChanged);
            // 
            // tbPlotSize
            // 
            this.tbPlotSize.Location = new System.Drawing.Point(164, 103);
            this.tbPlotSize.Name = "tbPlotSize";
            this.tbPlotSize.Size = new System.Drawing.Size(95, 23);
            this.tbPlotSize.TabIndex = 14;
            // 
            // rbCondominium
            // 
            this.rbCondominium.AutoSize = true;
            this.rbCondominium.Location = new System.Drawing.Point(67, 7);
            this.rbCondominium.Name = "rbCondominium";
            this.rbCondominium.Size = new System.Drawing.Size(103, 19);
            this.rbCondominium.TabIndex = 4;
            this.rbCondominium.TabStop = true;
            this.rbCondominium.Text = "Condominium";
            this.rbCondominium.UseVisualStyleBackColor = true;
            this.rbCondominium.CheckedChanged += new System.EventHandler(this.rbCondominium_CheckedChanged);
            // 
            // labelPlotSize
            // 
            this.labelPlotSize.AutoSize = true;
            this.labelPlotSize.Location = new System.Drawing.Point(3, 106);
            this.labelPlotSize.Name = "labelPlotSize";
            this.labelPlotSize.Size = new System.Drawing.Size(87, 15);
            this.labelPlotSize.TabIndex = 13;
            this.labelPlotSize.Text = "Plot Size (m^2)";
            // 
            // rbOwnership
            // 
            this.rbOwnership.AutoSize = true;
            this.rbOwnership.Location = new System.Drawing.Point(176, 7);
            this.rbOwnership.Name = "rbOwnership";
            this.rbOwnership.Size = new System.Drawing.Size(82, 19);
            this.rbOwnership.TabIndex = 5;
            this.rbOwnership.TabStop = true;
            this.rbOwnership.Text = "Ownership";
            this.rbOwnership.UseVisualStyleBackColor = true;
            this.rbOwnership.CheckedChanged += new System.EventHandler(this.rbOwnership_CheckedChanged);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(164, 132);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(95, 23);
            this.tbPrice.TabIndex = 12;
            // 
            // labelNrOfRooms
            // 
            this.labelNrOfRooms.AutoSize = true;
            this.labelNrOfRooms.Location = new System.Drawing.Point(3, 48);
            this.labelNrOfRooms.Name = "labelNrOfRooms";
            this.labelNrOfRooms.Size = new System.Drawing.Size(105, 15);
            this.labelNrOfRooms.TabIndex = 8;
            this.labelNrOfRooms.Text = "Number of Rooms";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(3, 135);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(33, 15);
            this.labelPrice.TabIndex = 11;
            this.labelPrice.Text = "Price";
            // 
            // labelLivingArea
            // 
            this.labelLivingArea.AutoSize = true;
            this.labelLivingArea.Location = new System.Drawing.Point(3, 77);
            this.labelLivingArea.Name = "labelLivingArea";
            this.labelLivingArea.Size = new System.Drawing.Size(102, 15);
            this.labelLivingArea.TabIndex = 9;
            this.labelLivingArea.Text = "Living Area (m^2)";
            // 
            // tbLivingArea
            // 
            this.tbLivingArea.Location = new System.Drawing.Point(164, 74);
            this.tbLivingArea.Name = "tbLivingArea";
            this.tbLivingArea.Size = new System.Drawing.Size(95, 23);
            this.tbLivingArea.TabIndex = 10;
            // 
            // cbTypes
            // 
            this.cbTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypes.FormattingEnabled = true;
            this.cbTypes.Location = new System.Drawing.Point(92, 20);
            this.cbTypes.Name = "cbTypes";
            this.cbTypes.Size = new System.Drawing.Size(171, 23);
            this.cbTypes.TabIndex = 1;
            this.cbTypes.SelectedIndexChanged += new System.EventHandler(this.cbTypes_SelectedIndexChanged);
            // 
            // labelEstate
            // 
            this.labelEstate.AutoSize = true;
            this.labelEstate.Location = new System.Drawing.Point(7, 23);
            this.labelEstate.Name = "labelEstate";
            this.labelEstate.Size = new System.Drawing.Size(79, 15);
            this.labelEstate.TabIndex = 0;
            this.labelEstate.Text = "Type of Estate";
            // 
            // gbAdress
            // 
            this.gbAdress.Controls.Add(this.panelAdress);
            this.gbAdress.Location = new System.Drawing.Point(293, 12);
            this.gbAdress.Name = "gbAdress";
            this.gbAdress.Size = new System.Drawing.Size(314, 243);
            this.gbAdress.TabIndex = 1;
            this.gbAdress.TabStop = false;
            this.gbAdress.Text = "Adress";
            // 
            // panelAdress
            // 
            this.panelAdress.Controls.Add(this.cbCountry);
            this.panelAdress.Controls.Add(this.labelCountry);
            this.panelAdress.Controls.Add(this.buttonAddPic);
            this.panelAdress.Controls.Add(this.tbZipCode);
            this.panelAdress.Controls.Add(this.tbFloorOrName);
            this.panelAdress.Controls.Add(this.labelStreet);
            this.panelAdress.Controls.Add(this.labelCity);
            this.panelAdress.Controls.Add(this.tbCity);
            this.panelAdress.Controls.Add(this.labelZipCode);
            this.panelAdress.Controls.Add(this.tbStreet);
            this.panelAdress.Controls.Add(this.labelFloorOrName);
            this.panelAdress.Location = new System.Drawing.Point(6, 16);
            this.panelAdress.Name = "panelAdress";
            this.panelAdress.Size = new System.Drawing.Size(302, 225);
            this.panelAdress.TabIndex = 8;
            // 
            // cbCountry
            // 
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(93, 87);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(121, 23);
            this.cbCountry.TabIndex = 9;
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(0, 90);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(50, 15);
            this.labelCountry.TabIndex = 8;
            this.labelCountry.Text = "Country";
            // 
            // buttonAddPic
            // 
            this.buttonAddPic.Location = new System.Drawing.Point(93, 194);
            this.buttonAddPic.Name = "buttonAddPic";
            this.buttonAddPic.Size = new System.Drawing.Size(94, 23);
            this.buttonAddPic.TabIndex = 7;
            this.buttonAddPic.Text = "Add Picture";
            this.buttonAddPic.UseVisualStyleBackColor = true;
            // 
            // tbZipCode
            // 
            this.tbZipCode.Location = new System.Drawing.Point(93, 29);
            this.tbZipCode.Name = "tbZipCode";
            this.tbZipCode.Size = new System.Drawing.Size(109, 23);
            this.tbZipCode.TabIndex = 6;
            // 
            // tbFloorOrName
            // 
            this.tbFloorOrName.Location = new System.Drawing.Point(93, 116);
            this.tbFloorOrName.Name = "tbFloorOrName";
            this.tbFloorOrName.Size = new System.Drawing.Size(202, 23);
            this.tbFloorOrName.TabIndex = 7;
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(0, 3);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(37, 15);
            this.labelStreet.TabIndex = 0;
            this.labelStreet.Text = "Street";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(0, 62);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(28, 15);
            this.labelCity.TabIndex = 1;
            this.labelCity.Text = "City";
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(93, 58);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(202, 23);
            this.tbCity.TabIndex = 5;
            // 
            // labelZipCode
            // 
            this.labelZipCode.AutoSize = true;
            this.labelZipCode.Location = new System.Drawing.Point(0, 32);
            this.labelZipCode.Name = "labelZipCode";
            this.labelZipCode.Size = new System.Drawing.Size(55, 15);
            this.labelZipCode.TabIndex = 2;
            this.labelZipCode.Text = "Zip Code";
            // 
            // tbStreet
            // 
            this.tbStreet.Location = new System.Drawing.Point(93, 0);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(202, 23);
            this.tbStreet.TabIndex = 4;
            // 
            // labelFloorOrName
            // 
            this.labelFloorOrName.AutoSize = true;
            this.labelFloorOrName.Location = new System.Drawing.Point(0, 119);
            this.labelFloorOrName.Name = "labelFloorOrName";
            this.labelFloorOrName.Size = new System.Drawing.Size(34, 15);
            this.labelFloorOrName.TabIndex = 3;
            this.labelFloorOrName.Text = "Floor";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(230, 261);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(155, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // lbEstates
            // 
            this.lbEstates.FormattingEnabled = true;
            this.lbEstates.ItemHeight = 15;
            this.lbEstates.Location = new System.Drawing.Point(19, 290);
            this.lbEstates.Name = "lbEstates";
            this.lbEstates.Size = new System.Drawing.Size(588, 274);
            this.lbEstates.TabIndex = 3;
            this.lbEstates.SelectedIndexChanged += new System.EventHandler(this.lbEstates_SelectedIndexChanged);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(104, 570);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(155, 23);
            this.buttonChange.TabIndex = 4;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(392, 570);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(155, 23);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // gbEstateInfo
            // 
            this.gbEstateInfo.Controls.Add(this.rtbInfo);
            this.gbEstateInfo.Controls.Add(this.tbInfo);
            this.gbEstateInfo.Controls.Add(this.pbEstate);
            this.gbEstateInfo.Location = new System.Drawing.Point(613, 12);
            this.gbEstateInfo.Name = "gbEstateInfo";
            this.gbEstateInfo.Size = new System.Drawing.Size(355, 552);
            this.gbEstateInfo.TabIndex = 6;
            this.gbEstateInfo.TabStop = false;
            this.gbEstateInfo.Text = "Estate Info";
            // 
            // rtbInfo
            // 
            this.rtbInfo.Location = new System.Drawing.Point(7, 225);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.ReadOnly = true;
            this.rtbInfo.Size = new System.Drawing.Size(342, 321);
            this.rtbInfo.TabIndex = 2;
            this.rtbInfo.Text = "";
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(6, 16);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ReadOnly = true;
            this.tbInfo.Size = new System.Drawing.Size(284, 125);
            this.tbInfo.TabIndex = 1;
            // 
            // pbEstate
            // 
            this.pbEstate.Location = new System.Drawing.Point(7, 20);
            this.pbEstate.Name = "pbEstate";
            this.pbEstate.Size = new System.Drawing.Size(342, 195);
            this.pbEstate.TabIndex = 0;
            this.pbEstate.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 601);
            this.Controls.Add(this.gbEstateInfo);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.lbEstates);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.gbAdress);
            this.Controls.Add(this.gbRegister);
            this.Name = "MainForm";
            this.Text = "Real Estate Agent";
            this.gbRegister.ResumeLayout(false);
            this.gbRegister.PerformLayout();
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            this.gbAdress.ResumeLayout(false);
            this.panelAdress.ResumeLayout(false);
            this.panelAdress.PerformLayout();
            this.gbEstateInfo.ResumeLayout(false);
            this.gbEstateInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRegister;
        private System.Windows.Forms.RadioButton rbOwnership;
        private System.Windows.Forms.RadioButton rbCondominium;
        private System.Windows.Forms.RadioButton rbRental;
        private System.Windows.Forms.ComboBox cbTypes;
        private System.Windows.Forms.Label labelEstate;
        private System.Windows.Forms.GroupBox gbAdress;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.Label labelFloorOrName;
        private System.Windows.Forms.Label labelZipCode;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.TextBox tbFloorOrName;
        private System.Windows.Forms.TextBox tbZipCode;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox lbEstates;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox gbEstateInfo;
        private System.Windows.Forms.TextBox tbPlotSize;
        private System.Windows.Forms.Label labelPlotSize;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox tbLivingArea;
        private System.Windows.Forms.Label labelLivingArea;
        private System.Windows.Forms.TextBox tbRooms;
        private System.Windows.Forms.Label labelNrOfRooms;
        private System.Windows.Forms.Button buttonAddPic;
        private System.Windows.Forms.PictureBox pbEstate;
        private System.Windows.Forms.TextBox tbFee;
        private System.Windows.Forms.Label labelFee;
        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.Panel panelAdress;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.RichTextBox rtbInfo;
    }
}

