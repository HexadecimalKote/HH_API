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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHH_API));
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.GetVacancyBtn = new System.Windows.Forms.Button();
            this.VacancyIDTextBox = new System.Windows.Forms.TextBox();
            this.GetSomeDataBtn = new System.Windows.Forms.Button();
            this.GetWorkListBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(12, 12);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultTextBox.Size = new System.Drawing.Size(433, 259);
            this.ResultTextBox.TabIndex = 0;
            // 
            // GetVacancyBtn
            // 
            this.GetVacancyBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetVacancyBtn.Location = new System.Drawing.Point(348, 285);
            this.GetVacancyBtn.Name = "GetVacancyBtn";
            this.GetVacancyBtn.Size = new System.Drawing.Size(97, 33);
            this.GetVacancyBtn.TabIndex = 1;
            this.GetVacancyBtn.Text = "Get Vacancy";
            this.GetVacancyBtn.UseVisualStyleBackColor = true;
            this.GetVacancyBtn.Click += new System.EventHandler(this.GetVacancyBtn_Click);
            // 
            // VacancyIDTextBox
            // 
            this.VacancyIDTextBox.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VacancyIDTextBox.Location = new System.Drawing.Point(12, 285);
            this.VacancyIDTextBox.Multiline = true;
            this.VacancyIDTextBox.Name = "VacancyIDTextBox";
            this.VacancyIDTextBox.Size = new System.Drawing.Size(330, 33);
            this.VacancyIDTextBox.TabIndex = 2;
            this.VacancyIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GetSomeDataBtn
            // 
            this.GetSomeDataBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetSomeDataBtn.Location = new System.Drawing.Point(451, 12);
            this.GetSomeDataBtn.Name = "GetSomeDataBtn";
            this.GetSomeDataBtn.Size = new System.Drawing.Size(112, 37);
            this.GetSomeDataBtn.TabIndex = 3;
            this.GetSomeDataBtn.Text = "Get some data";
            this.GetSomeDataBtn.UseVisualStyleBackColor = true;
            this.GetSomeDataBtn.Click += new System.EventHandler(this.GetSomeDataBtn_Click);
            // 
            // GetWorkListBtn
            // 
            this.GetWorkListBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetWorkListBtn.Location = new System.Drawing.Point(451, 55);
            this.GetWorkListBtn.Name = "GetWorkListBtn";
            this.GetWorkListBtn.Size = new System.Drawing.Size(112, 37);
            this.GetWorkListBtn.TabIndex = 4;
            this.GetWorkListBtn.Text = "Get work list";
            this.GetWorkListBtn.UseVisualStyleBackColor = true;
            this.GetWorkListBtn.Click += new System.EventHandler(this.GetWorkListBtn_Click);
            // 
            // FormHH_API
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 330);
            this.Controls.Add(this.GetWorkListBtn);
            this.Controls.Add(this.GetSomeDataBtn);
            this.Controls.Add(this.VacancyIDTextBox);
            this.Controls.Add(this.GetVacancyBtn);
            this.Controls.Add(this.ResultTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHH_API";
            this.Text = "HeadHunter API";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Button GetVacancyBtn;
        private System.Windows.Forms.TextBox VacancyIDTextBox;
        private System.Windows.Forms.Button GetSomeDataBtn;
        private System.Windows.Forms.Button GetWorkListBtn;
    }
}

