namespace FileIOAssignment
{
    partial class Employee
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBasic = new System.Windows.Forms.TextBox();
            this.txtHRA = new System.Windows.Forms.TextBox();
            this.txtDA = new System.Windows.Forms.TextBox();
            this.txtTA = new System.Windows.Forms.TextBox();
            this.txtPF = new System.Windows.Forms.TextBox();
            this.txtPT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGross = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(241, 34);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(102, 20);
            this.txtId.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(241, 81);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtBasic
            // 
            this.txtBasic.Location = new System.Drawing.Point(241, 125);
            this.txtBasic.Name = "txtBasic";
            this.txtBasic.Size = new System.Drawing.Size(100, 20);
            this.txtBasic.TabIndex = 5;
            // 
            // txtHRA
            // 
            this.txtHRA.Location = new System.Drawing.Point(243, 189);
            this.txtHRA.Name = "txtHRA";
            this.txtHRA.ReadOnly = true;
            this.txtHRA.Size = new System.Drawing.Size(100, 20);
            this.txtHRA.TabIndex = 6;
            // 
            // txtDA
            // 
            this.txtDA.Location = new System.Drawing.Point(243, 240);
            this.txtDA.Name = "txtDA";
            this.txtDA.ReadOnly = true;
            this.txtDA.Size = new System.Drawing.Size(100, 20);
            this.txtDA.TabIndex = 7;
            this.txtDA.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // txtTA
            // 
            this.txtTA.Location = new System.Drawing.Point(243, 284);
            this.txtTA.Name = "txtTA";
            this.txtTA.ReadOnly = true;
            this.txtTA.Size = new System.Drawing.Size(100, 20);
            this.txtTA.TabIndex = 8;
            // 
            // txtPF
            // 
            this.txtPF.Location = new System.Drawing.Point(243, 338);
            this.txtPF.Name = "txtPF";
            this.txtPF.ReadOnly = true;
            this.txtPF.Size = new System.Drawing.Size(100, 20);
            this.txtPF.TabIndex = 9;
            // 
            // txtPT
            // 
            this.txtPT.Location = new System.Drawing.Point(243, 393);
            this.txtPT.Name = "txtPT";
            this.txtPT.ReadOnly = true;
            this.txtPT.Size = new System.Drawing.Size(100, 20);
            this.txtPT.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Employee Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Basic Salary";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "HRA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "DA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "TA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(145, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "PT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(145, 345);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "PF";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(384, 123);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 23;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(145, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Gross Salary";
            // 
            // txtGross
            // 
            this.txtGross.Location = new System.Drawing.Point(243, 436);
            this.txtGross.Name = "txtGross";
            this.txtGross.ReadOnly = true;
            this.txtGross.Size = new System.Drawing.Size(100, 20);
            this.txtGross.TabIndex = 25;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.txtGross);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPT);
            this.Controls.Add(this.txtPF);
            this.Controls.Add(this.txtTA);
            this.Controls.Add(this.txtDA);
            this.Controls.Add(this.txtHRA);
            this.Controls.Add(this.txtBasic);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Name = "Employee";
            this.Text = "Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtBasic;
        private System.Windows.Forms.TextBox txtHRA;
        private System.Windows.Forms.TextBox txtDA;
        private System.Windows.Forms.TextBox txtTA;
        private System.Windows.Forms.TextBox txtPF;
        private System.Windows.Forms.TextBox txtPT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGross;
    }
}