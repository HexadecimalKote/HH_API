namespace HeadHunterApi
{
    partial class FormHH_API
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHH_API));
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmployerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSalaryFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSalaryTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescription = new System.Windows.Forms.DataGridViewLinkColumn();
            this.labelInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBtn
            // 
            this.SearchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SearchBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchBtn.Location = new System.Drawing.Point(417, 290);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(97, 33);
            this.SearchBtn.TabIndex = 1;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTextBox.Location = new System.Drawing.Point(11, 290);
            this.SearchTextBox.Multiline = true;
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(400, 33);
            this.SearchTextBox.TabIndex = 2;
            this.SearchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnName,
            this.ColumnEmployerName,
            this.ColumnAddress,
            this.ColumnSalaryFrom,
            this.ColumnSalaryTo,
            this.ColumnDescription});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(743, 270);
            this.dataGridView.TabIndex = 7;
            this.dataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentDoubleClick);
            // 
            // ColumnID
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.Width = 70;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Должность";
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnEmployerName
            // 
            this.ColumnEmployerName.HeaderText = "Работодатель";
            this.ColumnEmployerName.Name = "ColumnEmployerName";
            // 
            // ColumnAddress
            // 
            this.ColumnAddress.HeaderText = "Адрес";
            this.ColumnAddress.Name = "ColumnAddress";
            // 
            // ColumnSalaryFrom
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnSalaryFrom.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnSalaryFrom.HeaderText = "Зарплата от";
            this.ColumnSalaryFrom.Name = "ColumnSalaryFrom";
            // 
            // ColumnSalaryTo
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnSalaryTo.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnSalaryTo.HeaderText = "Зарплата до";
            this.ColumnSalaryTo.Name = "ColumnSalaryTo";
            // 
            // ColumnDescription
            // 
            this.ColumnDescription.HeaderText = "Описание";
            this.ColumnDescription.Name = "ColumnDescription";
            this.ColumnDescription.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // labelInfo
            // 
            this.labelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.Location = new System.Drawing.Point(532, 282);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(199, 51);
            this.labelInfo.TabIndex = 8;
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormHH_API
            // 
            this.AcceptButton = this.SearchBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 342);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHH_API";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HeadHunter API";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmployerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalaryFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalaryTo;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnDescription;
        private System.Windows.Forms.Label labelInfo;
    }
}

