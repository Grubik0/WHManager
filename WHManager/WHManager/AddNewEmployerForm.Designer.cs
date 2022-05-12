namespace WHManager
{
    partial class AddNewEmployerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEmpID = new System.Windows.Forms.TextBox();
            this.tpEmpName = new System.Windows.Forms.TextBox();
            this.tpEmpOIB = new System.Windows.Forms.TextBox();
            this.tpEmpFullName = new System.Windows.Forms.TextBox();
            this.tpEmpHR = new System.Windows.Forms.TextBox();
            this.tpEmpAdr = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employer ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employer name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Employer full name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "OIB:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hourly rate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address:";
            // 
            // tbEmpID
            // 
            this.tbEmpID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbEmpID.Location = new System.Drawing.Point(164, 26);
            this.tbEmpID.MaxLength = 3;
            this.tbEmpID.Name = "tbEmpID";
            this.tbEmpID.Size = new System.Drawing.Size(180, 23);
            this.tbEmpID.TabIndex = 6;
            // 
            // tpEmpName
            // 
            this.tpEmpName.Location = new System.Drawing.Point(164, 55);
            this.tpEmpName.Name = "tpEmpName";
            this.tpEmpName.Size = new System.Drawing.Size(180, 23);
            this.tpEmpName.TabIndex = 7;
            // 
            // tpEmpOIB
            // 
            this.tpEmpOIB.Location = new System.Drawing.Point(164, 113);
            this.tpEmpOIB.MaxLength = 11;
            this.tpEmpOIB.Name = "tpEmpOIB";
            this.tpEmpOIB.Size = new System.Drawing.Size(180, 23);
            this.tpEmpOIB.TabIndex = 9;
            // 
            // tpEmpFullName
            // 
            this.tpEmpFullName.Location = new System.Drawing.Point(164, 84);
            this.tpEmpFullName.Name = "tpEmpFullName";
            this.tpEmpFullName.Size = new System.Drawing.Size(180, 23);
            this.tpEmpFullName.TabIndex = 8;
            // 
            // tpEmpHR
            // 
            this.tpEmpHR.Location = new System.Drawing.Point(164, 171);
            this.tpEmpHR.Name = "tpEmpHR";
            this.tpEmpHR.Size = new System.Drawing.Size(180, 23);
            this.tpEmpHR.TabIndex = 11;
            // 
            // tpEmpAdr
            // 
            this.tpEmpAdr.Location = new System.Drawing.Point(164, 142);
            this.tpEmpAdr.Name = "tpEmpAdr";
            this.tpEmpAdr.Size = new System.Drawing.Size(180, 23);
            this.tpEmpAdr.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(222, 215);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 41);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(94, 215);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 41);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddNewEmployerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 284);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tpEmpHR);
            this.Controls.Add(this.tpEmpAdr);
            this.Controls.Add(this.tpEmpOIB);
            this.Controls.Add(this.tpEmpFullName);
            this.Controls.Add(this.tpEmpName);
            this.Controls.Add(this.tbEmpID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNewEmployerForm";
            this.Text = "WHManager - Add new employer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbEmpID;
        private TextBox tpEmpName;
        private TextBox tpEmpOIB;
        private TextBox tpEmpFullName;
        private TextBox tpEmpHR;
        private TextBox tpEmpAdr;
        private Button btnSave;
        private Button btnCancel;
    }
}