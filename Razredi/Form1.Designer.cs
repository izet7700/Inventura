namespace Razredi
{
    partial class Form1
    {
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
            this.itemIDTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.DeleteTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.readButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.readOneTextBox = new System.Windows.Forms.TextBox();
            this.allButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.labelIzb = new System.Windows.Forms.Label();
            this.serialLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.licenceTextBox = new System.Windows.Forms.TextBox();
            this.licenceLabel = new System.Windows.Forms.Label();
            this.sizeMbTextBox = new System.Windows.Forms.TextBox();
            this.sizeMbLabel = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.weightLabel = new System.Windows.Forms.Label();
            this.noOfCoresTextBox = new System.Windows.Forms.TextBox();
            this.noOfCoresLabel = new System.Windows.Forms.Label();
            this.ramTextBox = new System.Windows.Forms.TextBox();
            this.ramLabel = new System.Windows.Forms.Label();
            this.hddTextBox = new System.Windows.Forms.TextBox();
            this.hddLabel = new System.Windows.Forms.Label();
            this.resolutionTextBox = new System.Windows.Forms.TextBox();
            this.resolutionLabel = new System.Windows.Forms.Label();
            this.monTypeTextBox = new System.Windows.Forms.TextBox();
            this.monTypeLabel = new System.Windows.Forms.Label();
            this.izbButton = new System.Windows.Forms.Button();
            this.deleteListButton = new System.Windows.Forms.Button();
            this.forUpdateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemIDTextBox
            // 
            this.itemIDTextBox.Location = new System.Drawing.Point(82, 37);
            this.itemIDTextBox.Name = "itemIDTextBox";
            this.itemIDTextBox.Size = new System.Drawing.Size(112, 20);
            this.itemIDTextBox.TabIndex = 0;
            this.itemIDTextBox.TextChanged += new System.EventHandler(this.itemIDTextBox_TextChanged);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(82, 89);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(112, 20);
            this.priceTextBox.TabIndex = 1;
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Location = new System.Drawing.Point(82, 63);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(112, 20);
            this.itemNameTextBox.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 169);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // DeleteTextBox
            // 
            this.DeleteTextBox.Location = new System.Drawing.Point(329, 198);
            this.DeleteTextBox.Name = "DeleteTextBox";
            this.DeleteTextBox.Size = new System.Drawing.Size(110, 20);
            this.DeleteTextBox.TabIndex = 10;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(247, 196);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(119, 196);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(75, 23);
            this.readButton.TabIndex = 14;
            this.readButton.Text = "Read";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(119, 169);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 15;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // readOneTextBox
            // 
            this.readOneTextBox.Location = new System.Drawing.Point(12, 199);
            this.readOneTextBox.Name = "readOneTextBox";
            this.readOneTextBox.Size = new System.Drawing.Size(94, 20);
            this.readOneTextBox.TabIndex = 7;
            // 
            // allButton
            // 
            this.allButton.Location = new System.Drawing.Point(119, 224);
            this.allButton.Name = "allButton";
            this.allButton.Size = new System.Drawing.Size(75, 23);
            this.allButton.TabIndex = 16;
            this.allButton.Text = "Read(ALL)";
            this.allButton.UseVisualStyleBackColor = true;
            this.allButton.Click += new System.EventHandler(this.allButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 254);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(427, 186);
            this.listBox1.TabIndex = 17;
            this.listBox1.Visible = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // itemComboBox
            // 
            this.itemComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Items.AddRange(new object[] {
            "Item",
            "Software",
            "Hardware",
            "Computer",
            "Monitor"});
            this.itemComboBox.Location = new System.Drawing.Point(67, 10);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(127, 21);
            this.itemComboBox.TabIndex = 18;
            // 
            // labelIzb
            // 
            this.labelIzb.AutoSize = true;
            this.labelIzb.Location = new System.Drawing.Point(12, 13);
            this.labelIzb.Name = "labelIzb";
            this.labelIzb.Size = new System.Drawing.Size(49, 13);
            this.labelIzb.TabIndex = 19;
            this.labelIzb.Text = "Izberi tip:";
            // 
            // serialLabel
            // 
            this.serialLabel.AutoSize = true;
            this.serialLabel.Location = new System.Drawing.Point(12, 41);
            this.serialLabel.Name = "serialLabel";
            this.serialLabel.Size = new System.Drawing.Size(64, 13);
            this.serialLabel.TabIndex = 20;
            this.serialLabel.Text = "Serial Num.:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(38, 66);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 21;
            this.nameLabel.Text = "Name:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(42, 92);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(34, 13);
            this.priceLabel.TabIndex = 22;
            this.priceLabel.Text = "Price:";
            // 
            // licenceTextBox
            // 
            this.licenceTextBox.Location = new System.Drawing.Point(82, 116);
            this.licenceTextBox.Name = "licenceTextBox";
            this.licenceTextBox.Size = new System.Drawing.Size(112, 20);
            this.licenceTextBox.TabIndex = 23;
            this.licenceTextBox.Visible = false;
            // 
            // licenceLabel
            // 
            this.licenceLabel.AutoSize = true;
            this.licenceLabel.Location = new System.Drawing.Point(10, 119);
            this.licenceLabel.Name = "licenceLabel";
            this.licenceLabel.Size = new System.Drawing.Size(66, 13);
            this.licenceLabel.TabIndex = 24;
            this.licenceLabel.Text = "LicenceKey:";
            this.licenceLabel.Visible = false;
            // 
            // sizeMbTextBox
            // 
            this.sizeMbTextBox.Location = new System.Drawing.Point(82, 142);
            this.sizeMbTextBox.Name = "sizeMbTextBox";
            this.sizeMbTextBox.Size = new System.Drawing.Size(112, 20);
            this.sizeMbTextBox.TabIndex = 25;
            this.sizeMbTextBox.Visible = false;
            // 
            // sizeMbLabel
            // 
            this.sizeMbLabel.AutoSize = true;
            this.sizeMbLabel.Location = new System.Drawing.Point(24, 145);
            this.sizeMbLabel.Name = "sizeMbLabel";
            this.sizeMbLabel.Size = new System.Drawing.Size(52, 13);
            this.sizeMbLabel.TabIndex = 26;
            this.sizeMbLabel.Text = "Size(MB):";
            this.sizeMbLabel.Visible = false;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(329, 38);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(110, 20);
            this.weightTextBox.TabIndex = 27;
            this.weightTextBox.Visible = false;
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(279, 40);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(44, 13);
            this.weightLabel.TabIndex = 28;
            this.weightLabel.Text = "Weight:";
            this.weightLabel.Visible = false;
            // 
            // noOfCoresTextBox
            // 
            this.noOfCoresTextBox.Location = new System.Drawing.Point(329, 63);
            this.noOfCoresTextBox.Name = "noOfCoresTextBox";
            this.noOfCoresTextBox.Size = new System.Drawing.Size(110, 20);
            this.noOfCoresTextBox.TabIndex = 29;
            this.noOfCoresTextBox.Visible = false;
            // 
            // noOfCoresLabel
            // 
            this.noOfCoresLabel.AutoSize = true;
            this.noOfCoresLabel.Location = new System.Drawing.Point(279, 66);
            this.noOfCoresLabel.Name = "noOfCoresLabel";
            this.noOfCoresLabel.Size = new System.Drawing.Size(43, 13);
            this.noOfCoresLabel.TabIndex = 30;
            this.noOfCoresLabel.Text = "Core(s):";
            this.noOfCoresLabel.Visible = false;
            this.noOfCoresLabel.Click += new System.EventHandler(this.noOfCoresLabel_Click);
            // 
            // ramTextBox
            // 
            this.ramTextBox.Location = new System.Drawing.Point(329, 89);
            this.ramTextBox.Name = "ramTextBox";
            this.ramTextBox.Size = new System.Drawing.Size(110, 20);
            this.ramTextBox.TabIndex = 31;
            this.ramTextBox.Visible = false;
            // 
            // ramLabel
            // 
            this.ramLabel.AutoSize = true;
            this.ramLabel.Location = new System.Drawing.Point(288, 92);
            this.ramLabel.Name = "ramLabel";
            this.ramLabel.Size = new System.Drawing.Size(34, 13);
            this.ramLabel.TabIndex = 32;
            this.ramLabel.Text = "RAM:";
            this.ramLabel.Visible = false;
            // 
            // hddTextBox
            // 
            this.hddTextBox.Location = new System.Drawing.Point(329, 116);
            this.hddTextBox.Name = "hddTextBox";
            this.hddTextBox.Size = new System.Drawing.Size(110, 20);
            this.hddTextBox.TabIndex = 33;
            this.hddTextBox.Visible = false;
            // 
            // hddLabel
            // 
            this.hddLabel.AutoSize = true;
            this.hddLabel.Location = new System.Drawing.Point(268, 119);
            this.hddLabel.Name = "hddLabel";
            this.hddLabel.Size = new System.Drawing.Size(55, 13);
            this.hddLabel.TabIndex = 34;
            this.hddLabel.Text = "HDD(GB):";
            this.hddLabel.Visible = false;
            // 
            // resolutionTextBox
            // 
            this.resolutionTextBox.Location = new System.Drawing.Point(329, 142);
            this.resolutionTextBox.Name = "resolutionTextBox";
            this.resolutionTextBox.Size = new System.Drawing.Size(110, 20);
            this.resolutionTextBox.TabIndex = 35;
            this.resolutionTextBox.Visible = false;
            // 
            // resolutionLabel
            // 
            this.resolutionLabel.AutoSize = true;
            this.resolutionLabel.Location = new System.Drawing.Point(263, 145);
            this.resolutionLabel.Name = "resolutionLabel";
            this.resolutionLabel.Size = new System.Drawing.Size(60, 13);
            this.resolutionLabel.TabIndex = 36;
            this.resolutionLabel.Text = "Resolution:";
            this.resolutionLabel.Visible = false;
            // 
            // monTypeTextBox
            // 
            this.monTypeTextBox.Location = new System.Drawing.Point(329, 169);
            this.monTypeTextBox.Name = "monTypeTextBox";
            this.monTypeTextBox.Size = new System.Drawing.Size(110, 20);
            this.monTypeTextBox.TabIndex = 37;
            this.monTypeTextBox.Visible = false;
            // 
            // monTypeLabel
            // 
            this.monTypeLabel.AutoSize = true;
            this.monTypeLabel.Location = new System.Drawing.Point(254, 172);
            this.monTypeLabel.Name = "monTypeLabel";
            this.monTypeLabel.Size = new System.Drawing.Size(68, 13);
            this.monTypeLabel.TabIndex = 38;
            this.monTypeLabel.Text = "Monitor type:";
            this.monTypeLabel.Visible = false;
            // 
            // izbButton
            // 
            this.izbButton.Location = new System.Drawing.Point(200, 8);
            this.izbButton.Name = "izbButton";
            this.izbButton.Size = new System.Drawing.Size(75, 23);
            this.izbButton.TabIndex = 39;
            this.izbButton.Text = "OK";
            this.izbButton.UseVisualStyleBackColor = true;
            this.izbButton.Click += new System.EventHandler(this.izbButton_Click);
            // 
            // deleteListButton
            // 
            this.deleteListButton.Location = new System.Drawing.Point(12, 224);
            this.deleteListButton.Name = "deleteListButton";
            this.deleteListButton.Size = new System.Drawing.Size(75, 23);
            this.deleteListButton.TabIndex = 40;
            this.deleteListButton.Text = "Delete";
            this.deleteListButton.UseVisualStyleBackColor = true;
            this.deleteListButton.Visible = false;
            this.deleteListButton.Click += new System.EventHandler(this.deleteListButton_Click);
            // 
            // forUpdateLabel
            // 
            this.forUpdateLabel.AutoSize = true;
            this.forUpdateLabel.Location = new System.Drawing.Point(258, 229);
            this.forUpdateLabel.Name = "forUpdateLabel";
            this.forUpdateLabel.Size = new System.Drawing.Size(181, 13);
            this.forUpdateLabel.TabIndex = 41;
            this.forUpdateLabel.Text = "*For update item, select item from list.";
            this.forUpdateLabel.Visible = false;
            this.forUpdateLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 453);
            this.Controls.Add(this.forUpdateLabel);
            this.Controls.Add(this.deleteListButton);
            this.Controls.Add(this.izbButton);
            this.Controls.Add(this.monTypeLabel);
            this.Controls.Add(this.monTypeTextBox);
            this.Controls.Add(this.resolutionLabel);
            this.Controls.Add(this.resolutionTextBox);
            this.Controls.Add(this.hddLabel);
            this.Controls.Add(this.hddTextBox);
            this.Controls.Add(this.ramLabel);
            this.Controls.Add(this.ramTextBox);
            this.Controls.Add(this.noOfCoresLabel);
            this.Controls.Add(this.noOfCoresTextBox);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.sizeMbLabel);
            this.Controls.Add(this.sizeMbTextBox);
            this.Controls.Add(this.licenceLabel);
            this.Controls.Add(this.licenceTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.serialLabel);
            this.Controls.Add(this.labelIzb);
            this.Controls.Add(this.itemComboBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.allButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.DeleteTextBox);
            this.Controls.Add(this.readOneTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.itemNameTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.itemIDTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox itemIDTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox DeleteTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox readOneTextBox;
        private System.Windows.Forms.Button allButton;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox itemComboBox;
        private System.Windows.Forms.Label labelIzb;
        private System.Windows.Forms.Label serialLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox licenceTextBox;
        private System.Windows.Forms.Label licenceLabel;
        private System.Windows.Forms.TextBox sizeMbTextBox;
        private System.Windows.Forms.Label sizeMbLabel;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.TextBox noOfCoresTextBox;
        private System.Windows.Forms.Label noOfCoresLabel;
        private System.Windows.Forms.TextBox ramTextBox;
        private System.Windows.Forms.Label ramLabel;
        private System.Windows.Forms.TextBox hddTextBox;
        private System.Windows.Forms.Label hddLabel;
        private System.Windows.Forms.TextBox resolutionTextBox;
        private System.Windows.Forms.Label resolutionLabel;
        private System.Windows.Forms.TextBox monTypeTextBox;
        private System.Windows.Forms.Label monTypeLabel;
        private System.Windows.Forms.Button izbButton;
        private System.Windows.Forms.Button deleteListButton;
        private System.Windows.Forms.Label forUpdateLabel;
    }
}

