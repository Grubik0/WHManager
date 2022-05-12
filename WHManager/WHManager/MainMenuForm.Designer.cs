namespace WHManager
{
    partial class MainMenuForm
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
            this.dgvMainView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddEmployer = new System.Windows.Forms.Button();
            this.btnOpenMonth = new System.Windows.Forms.Button();
            this.btnAddHours = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.cbEmployer = new System.Windows.Forms.ComboBox();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMainView
            // 
            this.dgvMainView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainView.Location = new System.Drawing.Point(12, 12);
            this.dgvMainView.Name = "dgvMainView";
            this.dgvMainView.RowTemplate.Height = 25;
            this.dgvMainView.Size = new System.Drawing.Size(578, 285);
            this.dgvMainView.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbMonth);
            this.groupBox1.Controls.Add(this.cbYear);
            this.groupBox1.Controls.Add(this.cbEmployer);
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(596, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 165);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(103, 106);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(126, 40);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "SHOW";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Month:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Year:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employer:";
            // 
            // btnAddEmployer
            // 
            this.btnAddEmployer.Location = new System.Drawing.Point(12, 303);
            this.btnAddEmployer.Name = "btnAddEmployer";
            this.btnAddEmployer.Size = new System.Drawing.Size(140, 37);
            this.btnAddEmployer.TabIndex = 2;
            this.btnAddEmployer.Text = "EMPLOYERS";
            this.btnAddEmployer.UseVisualStyleBackColor = true;
            this.btnAddEmployer.Click += new System.EventHandler(this.btnAddEmployer_Click);
            // 
            // btnOpenMonth
            // 
            this.btnOpenMonth.Location = new System.Drawing.Point(158, 303);
            this.btnOpenMonth.Name = "btnOpenMonth";
            this.btnOpenMonth.Size = new System.Drawing.Size(140, 37);
            this.btnOpenMonth.TabIndex = 3;
            this.btnOpenMonth.Text = "OPEN MONTH";
            this.btnOpenMonth.UseVisualStyleBackColor = true;
            this.btnOpenMonth.Click += new System.EventHandler(this.btnOpenMonth_Click);
            // 
            // btnAddHours
            // 
            this.btnAddHours.Location = new System.Drawing.Point(304, 303);
            this.btnAddHours.Name = "btnAddHours";
            this.btnAddHours.Size = new System.Drawing.Size(140, 37);
            this.btnAddHours.TabIndex = 4;
            this.btnAddHours.Text = "ADD HOURS";
            this.btnAddHours.UseVisualStyleBackColor = true;
            this.btnAddHours.Click += new System.EventHandler(this.btnAddHours_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(450, 303);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(140, 37);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // cbEmployer
            // 
            this.cbEmployer.FormattingEnabled = true;
            this.cbEmployer.Location = new System.Drawing.Point(82, 19);
            this.cbEmployer.Name = "cbEmployer";
            this.cbEmployer.Size = new System.Drawing.Size(147, 23);
            this.cbEmployer.TabIndex = 7;
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(82, 48);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(147, 23);
            this.cbYear.TabIndex = 8;
            // 
            // cbMonth
            // 
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Location = new System.Drawing.Point(82, 77);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(147, 23);
            this.cbMonth.TabIndex = 9;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 358);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnAddHours);
            this.Controls.Add(this.btnOpenMonth);
            this.Controls.Add(this.btnAddEmployer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvMainView);
            this.Name = "MainMenuForm";
            this.Text = "WHManager - Main";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvMainView;
        private GroupBox groupBox1;
        private Button btnShow;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAddEmployer;
        private Button btnOpenMonth;
        private Button btnAddHours;
        private Button btnPrint;
        private ComboBox cbMonth;
        private ComboBox cbYear;
        private ComboBox cbEmployer;
    }
}