namespace WHManager
{
    partial class EmployerForm
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
            this.dgvEmployers = new System.Windows.Forms.DataGridView();
            this.btnEditEmployer = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployers
            // 
            this.dgvEmployers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployers.Location = new System.Drawing.Point(27, 26);
            this.dgvEmployers.Name = "dgvEmployers";
            this.dgvEmployers.RowTemplate.Height = 25;
            this.dgvEmployers.Size = new System.Drawing.Size(769, 193);
            this.dgvEmployers.TabIndex = 0;
            // 
            // btnEditEmployer
            // 
            this.btnEditEmployer.Location = new System.Drawing.Point(812, 26);
            this.btnEditEmployer.Name = "btnEditEmployer";
            this.btnEditEmployer.Size = new System.Drawing.Size(122, 40);
            this.btnEditEmployer.TabIndex = 1;
            this.btnEditEmployer.Text = "EDIT";
            this.btnEditEmployer.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(812, 72);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(122, 40);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Text = "ADD NEW";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // EmployerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 248);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnEditEmployer);
            this.Controls.Add(this.dgvEmployers);
            this.Name = "EmployerForm";
            this.Text = "WHManager - Employers";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvEmployers;
        private Button btnEditEmployer;
        private Button btnAddNew;
    }
}