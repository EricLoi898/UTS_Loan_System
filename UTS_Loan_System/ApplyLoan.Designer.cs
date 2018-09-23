namespace UTS_Loan_System
{
    partial class ApplyLoan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbApplicantfirstname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbLoantype = new System.Windows.Forms.ComboBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lbApplicantID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbApplicantlastname = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbApplicantlastname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbApplicantfirstname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbbLoantype);
            this.groupBox1.Controls.Add(this.tbAmount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.lbApplicantID);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 537);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please enter the following details";
            // 
            // lbApplicantfirstname
            // 
            this.lbApplicantfirstname.AutoSize = true;
            this.lbApplicantfirstname.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicantfirstname.ForeColor = System.Drawing.Color.Navy;
            this.lbApplicantfirstname.Location = new System.Drawing.Point(275, 134);
            this.lbApplicantfirstname.Name = "lbApplicantfirstname";
            this.lbApplicantfirstname.Size = new System.Drawing.Size(271, 31);
            this.lbApplicantfirstname.TabIndex = 11;
            this.lbApplicantfirstname.Text = "Applicant First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(-4, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Applicant First Name:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.ForeColor = System.Drawing.Color.Blue;
            this.btnSubmit.Location = new System.Drawing.Point(307, 481);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 50);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(155, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(127, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Loan Type:";
            // 
            // cbbLoantype
            // 
            this.cbbLoantype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoantype.FormattingEnabled = true;
            this.cbbLoantype.Items.AddRange(new object[] {
            "Transport",
            "Tuition Fee"});
            this.cbbLoantype.Location = new System.Drawing.Point(281, 231);
            this.cbbLoantype.Name = "cbbLoantype";
            this.cbbLoantype.Size = new System.Drawing.Size(344, 39);
            this.cbbLoantype.TabIndex = 7;
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(281, 276);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(344, 38);
            this.tbAmount.TabIndex = 6;
            this.tbAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAmount_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(100, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Applicant ID:";
            // 
            // btnBack
            // 
            this.btnBack.ForeColor = System.Drawing.Color.Blue;
            this.btnBack.Location = new System.Drawing.Point(610, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 50);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbApplicantID
            // 
            this.lbApplicantID.AutoSize = true;
            this.lbApplicantID.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicantID.ForeColor = System.Drawing.Color.Navy;
            this.lbApplicantID.Location = new System.Drawing.Point(275, 89);
            this.lbApplicantID.Name = "lbApplicantID";
            this.lbApplicantID.Size = new System.Drawing.Size(104, 31);
            this.lbApplicantID.TabIndex = 0;
            this.lbApplicantID.Text = "UTS ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(-6, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(274, 31);
            this.label5.TabIndex = 12;
            this.label5.Text = "Applicant Last Name:";
            // 
            // lbApplicantlastname
            // 
            this.lbApplicantlastname.AutoSize = true;
            this.lbApplicantlastname.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicantlastname.ForeColor = System.Drawing.Color.Navy;
            this.lbApplicantlastname.Location = new System.Drawing.Point(275, 177);
            this.lbApplicantlastname.Name = "lbApplicantlastname";
            this.lbApplicantlastname.Size = new System.Drawing.Size(266, 31);
            this.lbApplicantlastname.TabIndex = 13;
            this.lbApplicantlastname.Text = "Applicant Last Name";
            // 
            // ApplyLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox1);
            this.Name = "ApplyLoan";
            this.Text = "ApplyLoan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lbApplicantID;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbLoantype;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbApplicantfirstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbApplicantlastname;
        private System.Windows.Forms.Label label5;
    }
}