namespace OOP_Lab_3
{
    partial class ProcessorEditor
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.tbCoresNum = new System.Windows.Forms.TextBox();
            this.tbCompany = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFrequency = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbProcessTechnology = new System.Windows.Forms.TextBox();
            this.tbCacheSize = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbThermalDesignPower = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(363, 21);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 0;
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(363, 140);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(100, 20);
            this.tbAmount.TabIndex = 1;
            this.tbAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress_IsDigit);
            // 
            // tbCoresNum
            // 
            this.tbCoresNum.Location = new System.Drawing.Point(363, 182);
            this.tbCoresNum.Name = "tbCoresNum";
            this.tbCoresNum.Size = new System.Drawing.Size(100, 20);
            this.tbCoresNum.TabIndex = 2;
            // 
            // tbCompany
            // 
            this.tbCompany.Location = new System.Drawing.Point(363, 99);
            this.tbCompany.Name = "tbCompany";
            this.tbCompany.Size = new System.Drawing.Size(100, 20);
            this.tbCompany.TabIndex = 3;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(363, 59);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 20);
            this.tbPrice.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Company Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Number of cores";
            // 
            // tbFrequency
            // 
            this.tbFrequency.Location = new System.Drawing.Point(363, 228);
            this.tbFrequency.Name = "tbFrequency";
            this.tbFrequency.Size = new System.Drawing.Size(100, 20);
            this.tbFrequency.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Frequency";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(257, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Process technology";
            // 
            // tbProcessTechnology
            // 
            this.tbProcessTechnology.Location = new System.Drawing.Point(363, 269);
            this.tbProcessTechnology.Name = "tbProcessTechnology";
            this.tbProcessTechnology.Size = new System.Drawing.Size(100, 20);
            this.tbProcessTechnology.TabIndex = 13;
            // 
            // tbCacheSize
            // 
            this.tbCacheSize.Location = new System.Drawing.Point(363, 311);
            this.tbCacheSize.Name = "tbCacheSize";
            this.tbCacheSize.Size = new System.Drawing.Size(100, 20);
            this.tbCacheSize.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cache size";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(276, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Thermal packet";
            // 
            // tbThermalDesignPower
            // 
            this.tbThermalDesignPower.Location = new System.Drawing.Point(363, 350);
            this.tbThermalDesignPower.Name = "tbThermalDesignPower";
            this.tbThermalDesignPower.Size = new System.Drawing.Size(100, 20);
            this.tbThermalDesignPower.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(376, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ProcessorWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbThermalDesignPower);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbCacheSize);
            this.Controls.Add(this.tbProcessTechnology);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbFrequency);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbCompany);
            this.Controls.Add(this.tbCoresNum);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.tbName);
            this.Name = "ProcessorWindowForm";
            this.Text = "ProcessorWindowForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.TextBox tbCoresNum;
        private System.Windows.Forms.TextBox tbCompany;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFrequency;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbProcessTechnology;
        private System.Windows.Forms.TextBox tbCacheSize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbThermalDesignPower;
        private System.Windows.Forms.Button btnSave;
    }
}