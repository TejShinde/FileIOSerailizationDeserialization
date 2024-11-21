namespace FileIOAssignment
{
    partial class SerializeDeserializeProduct
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
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnBinaryWrite = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnXmlWrite = new System.Windows.Forms.Button();
            this.btnBinaryRead = new System.Windows.Forms.Button();
            this.btnXmlRead = new System.Windows.Forms.Button();
            this.btnSoapRead = new System.Windows.Forms.Button();
            this.btnSoapWrite = new System.Windows.Forms.Button();
            this.btnJsonRead = new System.Windows.Forms.Button();
            this.btnJsonWrite = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(322, 45);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(322, 97);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(322, 154);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 2;
            // 
            // btnBinaryWrite
            // 
            this.btnBinaryWrite.Location = new System.Drawing.Point(223, 227);
            this.btnBinaryWrite.Name = "btnBinaryWrite";
            this.btnBinaryWrite.Size = new System.Drawing.Size(75, 23);
            this.btnBinaryWrite.TabIndex = 3;
            this.btnBinaryWrite.Text = "Binary Write";
            this.btnBinaryWrite.UseVisualStyleBackColor = true;
            this.btnBinaryWrite.Click += new System.EventHandler(this.btnBinaryWrite_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(235, 48);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(58, 13);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "Product ID\r\n";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(235, 104);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Product Name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(235, 161);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(71, 13);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Product Price";
            // 
            // btnXmlWrite
            // 
            this.btnXmlWrite.Location = new System.Drawing.Point(223, 268);
            this.btnXmlWrite.Name = "btnXmlWrite";
            this.btnXmlWrite.Size = new System.Drawing.Size(75, 23);
            this.btnXmlWrite.TabIndex = 7;
            this.btnXmlWrite.Text = "XML Write";
            this.btnXmlWrite.UseVisualStyleBackColor = true;
            this.btnXmlWrite.Click += new System.EventHandler(this.btnXmlWrite_Click);
            // 
            // btnBinaryRead
            // 
            this.btnBinaryRead.Location = new System.Drawing.Point(382, 227);
            this.btnBinaryRead.Name = "btnBinaryRead";
            this.btnBinaryRead.Size = new System.Drawing.Size(75, 23);
            this.btnBinaryRead.TabIndex = 8;
            this.btnBinaryRead.Text = "Binary Read";
            this.btnBinaryRead.UseVisualStyleBackColor = true;
            this.btnBinaryRead.Click += new System.EventHandler(this.btnBinaryRead_Click);
            // 
            // btnXmlRead
            // 
            this.btnXmlRead.Location = new System.Drawing.Point(382, 268);
            this.btnXmlRead.Name = "btnXmlRead";
            this.btnXmlRead.Size = new System.Drawing.Size(75, 23);
            this.btnXmlRead.TabIndex = 9;
            this.btnXmlRead.Text = "XML Read";
            this.btnXmlRead.UseVisualStyleBackColor = true;
            this.btnXmlRead.Click += new System.EventHandler(this.btnXmlRead_Click);
            // 
            // btnSoapRead
            // 
            this.btnSoapRead.Location = new System.Drawing.Point(382, 311);
            this.btnSoapRead.Name = "btnSoapRead";
            this.btnSoapRead.Size = new System.Drawing.Size(75, 23);
            this.btnSoapRead.TabIndex = 10;
            this.btnSoapRead.Text = "SOAP Read";
            this.btnSoapRead.UseVisualStyleBackColor = true;
            this.btnSoapRead.Click += new System.EventHandler(this.btnSoapRead_Click);
            // 
            // btnSoapWrite
            // 
            this.btnSoapWrite.Location = new System.Drawing.Point(223, 311);
            this.btnSoapWrite.Name = "btnSoapWrite";
            this.btnSoapWrite.Size = new System.Drawing.Size(75, 23);
            this.btnSoapWrite.TabIndex = 11;
            this.btnSoapWrite.Text = "SOAP Write";
            this.btnSoapWrite.UseVisualStyleBackColor = true;
            this.btnSoapWrite.Click += new System.EventHandler(this.btnSoapWrite_Click);
            // 
            // btnJsonRead
            // 
            this.btnJsonRead.Location = new System.Drawing.Point(382, 349);
            this.btnJsonRead.Name = "btnJsonRead";
            this.btnJsonRead.Size = new System.Drawing.Size(75, 23);
            this.btnJsonRead.TabIndex = 12;
            this.btnJsonRead.Text = "JSON Read";
            this.btnJsonRead.UseVisualStyleBackColor = true;
            this.btnJsonRead.Click += new System.EventHandler(this.btnJsonRead_Click);
            // 
            // btnJsonWrite
            // 
            this.btnJsonWrite.Location = new System.Drawing.Point(223, 349);
            this.btnJsonWrite.Name = "btnJsonWrite";
            this.btnJsonWrite.Size = new System.Drawing.Size(75, 23);
            this.btnJsonWrite.TabIndex = 13;
            this.btnJsonWrite.Text = "JSON Write";
            this.btnJsonWrite.UseVisualStyleBackColor = true;
            this.btnJsonWrite.Click += new System.EventHandler(this.btnJsonWrite_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(549, 47);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnJsonWrite);
            this.Controls.Add(this.btnJsonRead);
            this.Controls.Add(this.btnSoapWrite);
            this.Controls.Add(this.btnSoapRead);
            this.Controls.Add(this.btnXmlRead);
            this.Controls.Add(this.btnBinaryRead);
            this.Controls.Add(this.btnXmlWrite);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnBinaryWrite);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnBinaryWrite;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnXmlWrite;
        private System.Windows.Forms.Button btnBinaryRead;
        private System.Windows.Forms.Button btnXmlRead;
        private System.Windows.Forms.Button btnSoapRead;
        private System.Windows.Forms.Button btnSoapWrite;
        private System.Windows.Forms.Button btnJsonRead;
        private System.Windows.Forms.Button btnJsonWrite;
        private System.Windows.Forms.Button btnClear;
    }
}

