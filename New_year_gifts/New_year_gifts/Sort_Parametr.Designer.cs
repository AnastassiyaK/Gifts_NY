namespace New_year_gifts
{
    partial class Sort_Parametr
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.radioButtonSweet = new System.Windows.Forms.RadioButton();
            this.radioButtonWeight = new System.Windows.Forms.RadioButton();
            this.radioButtonManufacturer = new System.Windows.Forms.RadioButton();
            this.radioButtonCategory = new System.Windows.Forms.RadioButton();
            this.panelSort = new System.Windows.Forms.Panel();
            this.listBoxSortSweets = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelSearchSweet = new System.Windows.Forms.Label();
            this.textBoxSearchSweet = new System.Windows.Forms.TextBox();
            this.labelSearchWeight = new System.Windows.Forms.Label();
            this.textBoxSearchWeight = new System.Windows.Forms.TextBox();
            this.labelSearchManufacturer = new System.Windows.Forms.Label();
            this.textBoxSearchManufacturer = new System.Windows.Forms.TextBox();
            this.labelSearchG = new System.Windows.Forms.Label();
            this.labelSearchCategory = new System.Windows.Forms.Label();
            this.comboBoxSearchCategory = new System.Windows.Forms.ComboBox();
            this.listBoxSearchSweets = new System.Windows.Forms.ListBox();
            this.buttonSortXML = new System.Windows.Forms.Button();
            this.buttonSortJSON = new System.Windows.Forms.Button();
            this.buttonSearchXML = new System.Windows.Forms.Button();
            this.buttonSearchJSON = new System.Windows.Forms.Button();
            this.panelSort.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(234, 221);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(234, 100);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(75, 23);
            this.buttonSort.TabIndex = 2;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            // 
            // radioButtonSweet
            // 
            this.radioButtonSweet.AutoSize = true;
            this.radioButtonSweet.Location = new System.Drawing.Point(3, 8);
            this.radioButtonSweet.Name = "radioButtonSweet";
            this.radioButtonSweet.Size = new System.Drawing.Size(66, 17);
            this.radioButtonSweet.TabIndex = 3;
            this.radioButtonSweet.TabStop = true;
            this.radioButtonSweet.Text = "By name";
            this.radioButtonSweet.UseVisualStyleBackColor = true;
            // 
            // radioButtonWeight
            // 
            this.radioButtonWeight.AutoSize = true;
            this.radioButtonWeight.Location = new System.Drawing.Point(3, 31);
            this.radioButtonWeight.Name = "radioButtonWeight";
            this.radioButtonWeight.Size = new System.Drawing.Size(74, 17);
            this.radioButtonWeight.TabIndex = 4;
            this.radioButtonWeight.TabStop = true;
            this.radioButtonWeight.Text = "By Weight";
            this.radioButtonWeight.UseVisualStyleBackColor = true;
            // 
            // radioButtonManufacturer
            // 
            this.radioButtonManufacturer.AutoSize = true;
            this.radioButtonManufacturer.Location = new System.Drawing.Point(3, 54);
            this.radioButtonManufacturer.Name = "radioButtonManufacturer";
            this.radioButtonManufacturer.Size = new System.Drawing.Size(103, 17);
            this.radioButtonManufacturer.TabIndex = 5;
            this.radioButtonManufacturer.TabStop = true;
            this.radioButtonManufacturer.Text = "By Manufactorer";
            this.radioButtonManufacturer.UseVisualStyleBackColor = true;
            // 
            // radioButtonCategory
            // 
            this.radioButtonCategory.AutoSize = true;
            this.radioButtonCategory.Location = new System.Drawing.Point(3, 77);
            this.radioButtonCategory.Name = "radioButtonCategory";
            this.radioButtonCategory.Size = new System.Drawing.Size(82, 17);
            this.radioButtonCategory.TabIndex = 6;
            this.radioButtonCategory.TabStop = true;
            this.radioButtonCategory.Text = "By Category";
            this.radioButtonCategory.UseVisualStyleBackColor = true;
            // 
            // panelSort
            // 
            this.panelSort.Controls.Add(this.radioButtonCategory);
            this.panelSort.Controls.Add(this.radioButtonSweet);
            this.panelSort.Controls.Add(this.radioButtonWeight);
            this.panelSort.Controls.Add(this.radioButtonManufacturer);
            this.panelSort.Location = new System.Drawing.Point(9, 23);
            this.panelSort.Name = "panelSort";
            this.panelSort.Size = new System.Drawing.Size(219, 152);
            this.panelSort.TabIndex = 7;
            // 
            // listBoxSortSweets
            // 
            this.listBoxSortSweets.FormattingEnabled = true;
            this.listBoxSortSweets.Location = new System.Drawing.Point(315, 23);
            this.listBoxSortSweets.Name = "listBoxSortSweets";
            this.listBoxSortSweets.Size = new System.Drawing.Size(240, 147);
            this.listBoxSortSweets.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBoxSearchCategory);
            this.panel2.Controls.Add(this.labelSearchCategory);
            this.panel2.Controls.Add(this.labelSearchG);
            this.panel2.Controls.Add(this.textBoxSearchManufacturer);
            this.panel2.Controls.Add(this.labelSearchManufacturer);
            this.panel2.Controls.Add(this.textBoxSearchWeight);
            this.panel2.Controls.Add(this.labelSearchWeight);
            this.panel2.Controls.Add(this.textBoxSearchSweet);
            this.panel2.Controls.Add(this.labelSearchSweet);
            this.panel2.Location = new System.Drawing.Point(13, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 171);
            this.panel2.TabIndex = 9;
            // 
            // labelSearchSweet
            // 
            this.labelSearchSweet.AutoSize = true;
            this.labelSearchSweet.Location = new System.Drawing.Point(4, 4);
            this.labelSearchSweet.Name = "labelSearchSweet";
            this.labelSearchSweet.Size = new System.Drawing.Size(35, 13);
            this.labelSearchSweet.TabIndex = 0;
            this.labelSearchSweet.Text = "Name";
            // 
            // textBoxSearchSweet
            // 
            this.textBoxSearchSweet.Location = new System.Drawing.Point(86, 1);
            this.textBoxSearchSweet.Name = "textBoxSearchSweet";
            this.textBoxSearchSweet.Size = new System.Drawing.Size(117, 20);
            this.textBoxSearchSweet.TabIndex = 1;
            // 
            // labelSearchWeight
            // 
            this.labelSearchWeight.AutoSize = true;
            this.labelSearchWeight.Location = new System.Drawing.Point(4, 34);
            this.labelSearchWeight.Name = "labelSearchWeight";
            this.labelSearchWeight.Size = new System.Drawing.Size(41, 13);
            this.labelSearchWeight.TabIndex = 2;
            this.labelSearchWeight.Text = "Weight";
            // 
            // textBoxSearchWeight
            // 
            this.textBoxSearchWeight.Location = new System.Drawing.Point(86, 34);
            this.textBoxSearchWeight.Name = "textBoxSearchWeight";
            this.textBoxSearchWeight.Size = new System.Drawing.Size(102, 20);
            this.textBoxSearchWeight.TabIndex = 3;
            // 
            // labelSearchManufacturer
            // 
            this.labelSearchManufacturer.AutoSize = true;
            this.labelSearchManufacturer.Location = new System.Drawing.Point(4, 69);
            this.labelSearchManufacturer.Name = "labelSearchManufacturer";
            this.labelSearchManufacturer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSearchManufacturer.Size = new System.Drawing.Size(70, 13);
            this.labelSearchManufacturer.TabIndex = 4;
            this.labelSearchManufacturer.Text = "Manufacturer";
            // 
            // textBoxSearchManufacturer
            // 
            this.textBoxSearchManufacturer.Location = new System.Drawing.Point(86, 69);
            this.textBoxSearchManufacturer.Name = "textBoxSearchManufacturer";
            this.textBoxSearchManufacturer.Size = new System.Drawing.Size(117, 20);
            this.textBoxSearchManufacturer.TabIndex = 5;
            // 
            // labelSearchG
            // 
            this.labelSearchG.AutoSize = true;
            this.labelSearchG.Location = new System.Drawing.Point(195, 40);
            this.labelSearchG.Name = "labelSearchG";
            this.labelSearchG.Size = new System.Drawing.Size(13, 13);
            this.labelSearchG.TabIndex = 6;
            this.labelSearchG.Text = "g";
            // 
            // labelSearchCategory
            // 
            this.labelSearchCategory.AutoSize = true;
            this.labelSearchCategory.Location = new System.Drawing.Point(7, 105);
            this.labelSearchCategory.Name = "labelSearchCategory";
            this.labelSearchCategory.Size = new System.Drawing.Size(49, 13);
            this.labelSearchCategory.TabIndex = 7;
            this.labelSearchCategory.Text = "Category";
            // 
            // comboBoxSearchCategory
            // 
            this.comboBoxSearchCategory.FormattingEnabled = true;
            this.comboBoxSearchCategory.Location = new System.Drawing.Point(86, 96);
            this.comboBoxSearchCategory.Name = "comboBoxSearchCategory";
            this.comboBoxSearchCategory.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSearchCategory.TabIndex = 8;
            // 
            // listBoxSearchSweets
            // 
            this.listBoxSearchSweets.FormattingEnabled = true;
            this.listBoxSearchSweets.Location = new System.Drawing.Point(315, 181);
            this.listBoxSearchSweets.Name = "listBoxSearchSweets";
            this.listBoxSearchSweets.Size = new System.Drawing.Size(240, 173);
            this.listBoxSearchSweets.TabIndex = 10;
            // 
            // buttonSortXML
            // 
            this.buttonSortXML.Location = new System.Drawing.Point(571, 54);
            this.buttonSortXML.Name = "buttonSortXML";
            this.buttonSortXML.Size = new System.Drawing.Size(75, 23);
            this.buttonSortXML.TabIndex = 11;
            this.buttonSortXML.Text = "To XML";
            this.buttonSortXML.UseVisualStyleBackColor = true;
            // 
            // buttonSortJSON
            // 
            this.buttonSortJSON.Location = new System.Drawing.Point(571, 84);
            this.buttonSortJSON.Name = "buttonSortJSON";
            this.buttonSortJSON.Size = new System.Drawing.Size(75, 23);
            this.buttonSortJSON.TabIndex = 12;
            this.buttonSortJSON.Text = "To JSON";
            this.buttonSortJSON.UseVisualStyleBackColor = true;
            // 
            // buttonSearchXML
            // 
            this.buttonSearchXML.Location = new System.Drawing.Point(571, 213);
            this.buttonSearchXML.Name = "buttonSearchXML";
            this.buttonSearchXML.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchXML.TabIndex = 13;
            this.buttonSearchXML.Text = "To XML";
            this.buttonSearchXML.UseVisualStyleBackColor = true;
            this.buttonSearchXML.Click += new System.EventHandler(this.btnSearchXML_Click);
            // 
            // buttonSearchJSON
            // 
            this.buttonSearchJSON.Location = new System.Drawing.Point(571, 250);
            this.buttonSearchJSON.Name = "buttonSearchJSON";
            this.buttonSearchJSON.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchJSON.TabIndex = 14;
            this.buttonSearchJSON.Text = "To JSON";
            this.buttonSearchJSON.UseVisualStyleBackColor = true;
            // 
            // Sort_Parametr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(687, 365);
            this.Controls.Add(this.buttonSearchJSON);
            this.Controls.Add(this.buttonSearchXML);
            this.Controls.Add(this.buttonSortJSON);
            this.Controls.Add(this.buttonSortXML);
            this.Controls.Add(this.listBoxSearchSweets);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listBoxSortSweets);
            this.Controls.Add(this.panelSort);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonSearch);
            this.Name = "Sort_Parametr";
            this.Text = "Sort_Parametr";
            this.panelSort.ResumeLayout(false);
            this.panelSort.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.RadioButton radioButtonSweet;
        private System.Windows.Forms.RadioButton radioButtonWeight;
        private System.Windows.Forms.RadioButton radioButtonManufacturer;
        private System.Windows.Forms.RadioButton radioButtonCategory;
        private System.Windows.Forms.Panel panelSort;
        private System.Windows.Forms.ListBox listBoxSortSweets;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelSearchManufacturer;
        private System.Windows.Forms.TextBox textBoxSearchWeight;
        private System.Windows.Forms.Label labelSearchWeight;
        private System.Windows.Forms.TextBox textBoxSearchSweet;
        private System.Windows.Forms.Label labelSearchSweet;
        private System.Windows.Forms.Label labelSearchG;
        private System.Windows.Forms.TextBox textBoxSearchManufacturer;
        private System.Windows.Forms.ComboBox comboBoxSearchCategory;
        private System.Windows.Forms.Label labelSearchCategory;
        private System.Windows.Forms.ListBox listBoxSearchSweets;
        private System.Windows.Forms.Button buttonSortXML;
        private System.Windows.Forms.Button buttonSortJSON;
        private System.Windows.Forms.Button buttonSearchXML;
        private System.Windows.Forms.Button buttonSearchJSON;
    }
}