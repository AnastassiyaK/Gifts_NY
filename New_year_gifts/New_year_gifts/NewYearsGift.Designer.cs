namespace New_year_gifts
{
    partial class NewYearsGift
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
            this.LoadData = new System.Windows.Forms.TabPage();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.dataGridViewLoad = new System.Windows.Forms.DataGridView();
            this.SweetNameGift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SweetWeightGift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SweetManufacturerGift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SweetCategoryGift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabforSweets = new System.Windows.Forms.TabControl();
            this.GatherGift = new System.Windows.Forms.TabPage();
            this.radioButtonWeight = new System.Windows.Forms.RadioButton();
            this.labelGram = new System.Windows.Forms.Label();
            this.labeltotalWeight = new System.Windows.Forms.Label();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.radioButtonType = new System.Windows.Forms.RadioButton();
            this.radioButtonManufacturer = new System.Windows.Forms.RadioButton();
            this.dataGridViewGift = new System.Windows.Forms.DataGridView();
            this.SweetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SweetWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SweetManufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SweetCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.Type = new System.Windows.Forms.Label();
            this.labelManufacturer = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxManufacturer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxWeightFrom = new System.Windows.Forms.TextBox();
            this.textBoxWeightTo = new System.Windows.Forms.TextBox();
            this.labelWeightFrom = new System.Windows.Forms.Label();
            this.labelWeightTo = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.LoadData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoad)).BeginInit();
            this.TabforSweets.SuspendLayout();
            this.GatherGift.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGift)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadData
            // 
            this.LoadData.BackColor = System.Drawing.Color.LightCyan;
            this.LoadData.Controls.Add(this.textBoxInfo);
            this.LoadData.Controls.Add(this.buttonAdd);
            this.LoadData.Controls.Add(this.buttonLoad);
            this.LoadData.Controls.Add(this.dataGridViewLoad);
            this.LoadData.Location = new System.Drawing.Point(4, 22);
            this.LoadData.Name = "LoadData";
            this.LoadData.Padding = new System.Windows.Forms.Padding(3);
            this.LoadData.Size = new System.Drawing.Size(850, 342);
            this.LoadData.TabIndex = 0;
            this.LoadData.Text = "Load Data";
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(13, 67);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.ReadOnly = true;
            this.textBoxInfo.Size = new System.Drawing.Size(100, 74);
            this.textBoxInfo.TabIndex = 9;
            this.textBoxInfo.Text = "Choose a row from the table and press the button \"Add to Gift\"";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(13, 147);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(284, 23);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Add to Gift";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(13, 6);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(89, 38);
            this.buttonLoad.TabIndex = 7;
            this.buttonLoad.Text = "Load data";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // dataGridViewLoad
            // 
            this.dataGridViewLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewLoad.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewLoad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SweetNameGift,
            this.SweetWeightGift,
            this.SweetManufacturerGift,
            this.SweetCategoryGift});
            this.dataGridViewLoad.Location = new System.Drawing.Point(303, 6);
            this.dataGridViewLoad.Name = "dataGridViewLoad";
            this.dataGridViewLoad.Size = new System.Drawing.Size(534, 321);
            this.dataGridViewLoad.TabIndex = 6;
            // 
            // SweetNameGift
            // 
            this.SweetNameGift.HeaderText = "Name";
            this.SweetNameGift.Name = "SweetNameGift";
            this.SweetNameGift.ReadOnly = true;
            // 
            // SweetWeightGift
            // 
            this.SweetWeightGift.HeaderText = "Weight";
            this.SweetWeightGift.Name = "SweetWeightGift";
            this.SweetWeightGift.ReadOnly = true;
            // 
            // SweetManufacturerGift
            // 
            this.SweetManufacturerGift.HeaderText = "Manufacturer";
            this.SweetManufacturerGift.Name = "SweetManufacturerGift";
            this.SweetManufacturerGift.ReadOnly = true;
            // 
            // SweetCategoryGift
            // 
            this.SweetCategoryGift.HeaderText = "Category";
            this.SweetCategoryGift.Name = "SweetCategoryGift";
            this.SweetCategoryGift.ReadOnly = true;
            // 
            // TabforSweets
            // 
            this.TabforSweets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabforSweets.Controls.Add(this.LoadData);
            this.TabforSweets.Controls.Add(this.GatherGift);
            this.TabforSweets.Location = new System.Drawing.Point(-5, 0);
            this.TabforSweets.Name = "TabforSweets";
            this.TabforSweets.SelectedIndex = 0;
            this.TabforSweets.Size = new System.Drawing.Size(858, 368);
            this.TabforSweets.TabIndex = 0;
            // 
            // GatherGift
            // 
            this.GatherGift.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GatherGift.Controls.Add(this.buttonReset);
            this.GatherGift.Controls.Add(this.labelWeightTo);
            this.GatherGift.Controls.Add(this.labelWeightFrom);
            this.GatherGift.Controls.Add(this.textBoxWeightTo);
            this.GatherGift.Controls.Add(this.textBoxWeightFrom);
            this.GatherGift.Controls.Add(this.label1);
            this.GatherGift.Controls.Add(this.radioButtonWeight);
            this.GatherGift.Controls.Add(this.labelGram);
            this.GatherGift.Controls.Add(this.labeltotalWeight);
            this.GatherGift.Controls.Add(this.buttonExport);
            this.GatherGift.Controls.Add(this.buttonSort);
            this.GatherGift.Controls.Add(this.radioButtonType);
            this.GatherGift.Controls.Add(this.radioButtonManufacturer);
            this.GatherGift.Controls.Add(this.dataGridViewGift);
            this.GatherGift.Controls.Add(this.buttonSearch);
            this.GatherGift.Controls.Add(this.Type);
            this.GatherGift.Controls.Add(this.labelManufacturer);
            this.GatherGift.Controls.Add(this.comboBoxType);
            this.GatherGift.Controls.Add(this.comboBoxManufacturer);
            this.GatherGift.Location = new System.Drawing.Point(4, 22);
            this.GatherGift.Name = "GatherGift";
            this.GatherGift.Padding = new System.Windows.Forms.Padding(3);
            this.GatherGift.Size = new System.Drawing.Size(850, 342);
            this.GatherGift.TabIndex = 1;
            this.GatherGift.Text = "Gather a Gift";
            // 
            // radioButtonWeight
            // 
            this.radioButtonWeight.AutoSize = true;
            this.radioButtonWeight.Location = new System.Drawing.Point(13, 55);
            this.radioButtonWeight.Name = "radioButtonWeight";
            this.radioButtonWeight.Size = new System.Drawing.Size(74, 17);
            this.radioButtonWeight.TabIndex = 14;
            this.radioButtonWeight.TabStop = true;
            this.radioButtonWeight.Text = "By Weight";
            this.radioButtonWeight.UseVisualStyleBackColor = true;
            // 
            // labelGram
            // 
            this.labelGram.AutoSize = true;
            this.labelGram.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGram.Location = new System.Drawing.Point(209, 99);
            this.labelGram.Name = "labelGram";
            this.labelGram.Size = new System.Drawing.Size(18, 13);
            this.labelGram.TabIndex = 12;
            this.labelGram.Text = "g.";
            // 
            // labeltotalWeight
            // 
            this.labeltotalWeight.AutoSize = true;
            this.labeltotalWeight.Location = new System.Drawing.Point(138, 99);
            this.labeltotalWeight.Name = "labeltotalWeight";
            this.labeltotalWeight.Size = new System.Drawing.Size(65, 13);
            this.labeltotalWeight.TabIndex = 11;
            this.labeltotalWeight.Text = "TotalWeight";
            this.labeltotalWeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(148, 304);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(97, 23);
            this.buttonExport.TabIndex = 10;
            this.buttonExport.Text = "Export to JSON";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(13, 89);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(75, 23);
            this.buttonSort.TabIndex = 9;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // radioButtonType
            // 
            this.radioButtonType.AutoSize = true;
            this.radioButtonType.Location = new System.Drawing.Point(13, 31);
            this.radioButtonType.Name = "radioButtonType";
            this.radioButtonType.Size = new System.Drawing.Size(64, 17);
            this.radioButtonType.TabIndex = 8;
            this.radioButtonType.TabStop = true;
            this.radioButtonType.Text = "By Type";
            this.radioButtonType.UseVisualStyleBackColor = true;
            // 
            // radioButtonManufacturer
            // 
            this.radioButtonManufacturer.AutoSize = true;
            this.radioButtonManufacturer.Location = new System.Drawing.Point(13, 8);
            this.radioButtonManufacturer.Name = "radioButtonManufacturer";
            this.radioButtonManufacturer.Size = new System.Drawing.Size(103, 17);
            this.radioButtonManufacturer.TabIndex = 7;
            this.radioButtonManufacturer.TabStop = true;
            this.radioButtonManufacturer.Text = "By Manufacturer";
            this.radioButtonManufacturer.UseVisualStyleBackColor = true;
            // 
            // dataGridViewGift
            // 
            this.dataGridViewGift.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGift.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SweetName,
            this.SweetWeight,
            this.SweetManufacturer,
            this.SweetCategory});
            this.dataGridViewGift.Location = new System.Drawing.Point(257, 14);
            this.dataGridViewGift.Name = "dataGridViewGift";
            this.dataGridViewGift.Size = new System.Drawing.Size(587, 313);
            this.dataGridViewGift.TabIndex = 6;
            // 
            // SweetName
            // 
            this.SweetName.HeaderText = "Name";
            this.SweetName.Name = "SweetName";
            this.SweetName.ReadOnly = true;
            // 
            // SweetWeight
            // 
            this.SweetWeight.HeaderText = "Weight";
            this.SweetWeight.Name = "SweetWeight";
            this.SweetWeight.ReadOnly = true;
            // 
            // SweetManufacturer
            // 
            this.SweetManufacturer.HeaderText = "Manufacturer";
            this.SweetManufacturer.Name = "SweetManufacturer";
            this.SweetManufacturer.ReadOnly = true;
            // 
            // SweetCategory
            // 
            this.SweetCategory.HeaderText = "Category";
            this.SweetCategory.Name = "SweetCategory";
            this.SweetCategory.ReadOnly = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(170, 266);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(51, 205);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(31, 13);
            this.Type.TabIndex = 4;
            this.Type.Text = "Type";
            // 
            // labelManufacturer
            // 
            this.labelManufacturer.AutoSize = true;
            this.labelManufacturer.Location = new System.Drawing.Point(48, 171);
            this.labelManufacturer.Name = "labelManufacturer";
            this.labelManufacturer.Size = new System.Drawing.Size(70, 13);
            this.labelManufacturer.TabIndex = 3;
            this.labelManufacturer.Text = "Manufacturer";
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(124, 205);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxType.TabIndex = 2;
            // 
            // comboBoxManufacturer
            // 
            this.comboBoxManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxManufacturer.FormattingEnabled = true;
            this.comboBoxManufacturer.Location = new System.Drawing.Point(124, 168);
            this.comboBoxManufacturer.Name = "comboBoxManufacturer";
            this.comboBoxManufacturer.Size = new System.Drawing.Size(121, 21);
            this.comboBoxManufacturer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Weight";
            // 
            // textBoxWeightFrom
            // 
            this.textBoxWeightFrom.Location = new System.Drawing.Point(141, 239);
            this.textBoxWeightFrom.Name = "textBoxWeightFrom";
            this.textBoxWeightFrom.Size = new System.Drawing.Size(32, 20);
            this.textBoxWeightFrom.TabIndex = 16;
            // 
            // textBoxWeightTo
            // 
            this.textBoxWeightTo.Location = new System.Drawing.Point(212, 239);
            this.textBoxWeightTo.Name = "textBoxWeightTo";
            this.textBoxWeightTo.Size = new System.Drawing.Size(33, 20);
            this.textBoxWeightTo.TabIndex = 17;
            // 
            // labelWeightFrom
            // 
            this.labelWeightFrom.AutoSize = true;
            this.labelWeightFrom.Location = new System.Drawing.Point(108, 239);
            this.labelWeightFrom.Name = "labelWeightFrom";
            this.labelWeightFrom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelWeightFrom.Size = new System.Drawing.Size(27, 13);
            this.labelWeightFrom.TabIndex = 18;
            this.labelWeightFrom.Text = "from";
            // 
            // labelWeightTo
            // 
            this.labelWeightTo.AutoSize = true;
            this.labelWeightTo.Location = new System.Drawing.Point(187, 239);
            this.labelWeightTo.Name = "labelWeightTo";
            this.labelWeightTo.Size = new System.Drawing.Size(16, 13);
            this.labelWeightTo.TabIndex = 19;
            this.labelWeightTo.Text = "to";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(89, 266);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 20;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // NewYearsGift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(848, 361);
            this.Controls.Add(this.TabforSweets);
            this.Name = "NewYearsGift";
            this.Text = "NewYearsGift";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LoadData.ResumeLayout(false);
            this.LoadData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoad)).EndInit();
            this.TabforSweets.ResumeLayout(false);
            this.GatherGift.ResumeLayout(false);
            this.GatherGift.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGift)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage LoadData;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.DataGridView dataGridViewLoad;
        private System.Windows.Forms.TabControl TabforSweets;
        private System.Windows.Forms.TabPage GatherGift;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label labelManufacturer;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboBoxManufacturer;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridViewGift;
        private System.Windows.Forms.DataGridViewTextBoxColumn SweetNameGift;
        private System.Windows.Forms.DataGridViewTextBoxColumn SweetWeightGift;
        private System.Windows.Forms.DataGridViewTextBoxColumn SweetManufacturerGift;
        private System.Windows.Forms.DataGridViewTextBoxColumn SweetCategoryGift;
        private System.Windows.Forms.DataGridViewTextBoxColumn SweetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SweetWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn SweetManufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn SweetCategory;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.RadioButton radioButtonType;
        private System.Windows.Forms.RadioButton radioButtonManufacturer;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Label labelGram;
        private System.Windows.Forms.Label labeltotalWeight;
        private System.Windows.Forms.RadioButton radioButtonWeight;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelWeightTo;
        private System.Windows.Forms.Label labelWeightFrom;
        private System.Windows.Forms.TextBox textBoxWeightTo;
        private System.Windows.Forms.TextBox textBoxWeightFrom;
        private System.Windows.Forms.Label label1;
    }
}

