namespace C_to_F_convert
{
    partial class Form1
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
            this.lblCelsiusInput = new System.Windows.Forms.Label();
            this.lblFarenheitOutput = new System.Windows.Forms.Label();
            this.lblFarenheitInput = new System.Windows.Forms.Label();
            this.lblCelsiusOutput = new System.Windows.Forms.Label();
            this.txtCelsiusInput = new System.Windows.Forms.TextBox();
            this.txtFarenheitOutput = new System.Windows.Forms.TextBox();
            this.txtFarenheitInput = new System.Windows.Forms.TextBox();
            this.txtCelsiusOutput = new System.Windows.Forms.TextBox();
            this.btnCtF = new System.Windows.Forms.Button();
            this.btnFtC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCelsiusInput
            // 
            this.lblCelsiusInput.AutoSize = true;
            this.lblCelsiusInput.Location = new System.Drawing.Point(12, 31);
            this.lblCelsiusInput.Name = "lblCelsiusInput";
            this.lblCelsiusInput.Size = new System.Drawing.Size(40, 13);
            this.lblCelsiusInput.TabIndex = 0;
            this.lblCelsiusInput.Text = "Celsius";
            // 
            // lblFarenheitOutput
            // 
            this.lblFarenheitOutput.AutoSize = true;
            this.lblFarenheitOutput.Location = new System.Drawing.Point(12, 72);
            this.lblFarenheitOutput.Name = "lblFarenheitOutput";
            this.lblFarenheitOutput.Size = new System.Drawing.Size(51, 13);
            this.lblFarenheitOutput.TabIndex = 1;
            this.lblFarenheitOutput.Text = "Farenheit";
            // 
            // lblFarenheitInput
            // 
            this.lblFarenheitInput.AutoSize = true;
            this.lblFarenheitInput.Location = new System.Drawing.Point(12, 160);
            this.lblFarenheitInput.Name = "lblFarenheitInput";
            this.lblFarenheitInput.Size = new System.Drawing.Size(51, 13);
            this.lblFarenheitInput.TabIndex = 2;
            this.lblFarenheitInput.Text = "Farenheit";
            // 
            // lblCelsiusOutput
            // 
            this.lblCelsiusOutput.AutoSize = true;
            this.lblCelsiusOutput.Location = new System.Drawing.Point(12, 196);
            this.lblCelsiusOutput.Name = "lblCelsiusOutput";
            this.lblCelsiusOutput.Size = new System.Drawing.Size(40, 13);
            this.lblCelsiusOutput.TabIndex = 3;
            this.lblCelsiusOutput.Text = "Celsius";
            // 
            // txtCelsiusInput
            // 
            this.txtCelsiusInput.Location = new System.Drawing.Point(69, 24);
            this.txtCelsiusInput.Name = "txtCelsiusInput";
            this.txtCelsiusInput.Size = new System.Drawing.Size(100, 20);
            this.txtCelsiusInput.TabIndex = 4;
            // 
            // txtFarenheitOutput
            // 
            this.txtFarenheitOutput.Location = new System.Drawing.Point(69, 65);
            this.txtFarenheitOutput.Name = "txtFarenheitOutput";
            this.txtFarenheitOutput.ReadOnly = true;
            this.txtFarenheitOutput.Size = new System.Drawing.Size(100, 20);
            this.txtFarenheitOutput.TabIndex = 5;
            // 
            // txtFarenheitInput
            // 
            this.txtFarenheitInput.Location = new System.Drawing.Point(69, 153);
            this.txtFarenheitInput.Name = "txtFarenheitInput";
            this.txtFarenheitInput.Size = new System.Drawing.Size(100, 20);
            this.txtFarenheitInput.TabIndex = 6;
            // 
            // txtCelsiusOutput
            // 
            this.txtCelsiusOutput.Location = new System.Drawing.Point(69, 189);
            this.txtCelsiusOutput.Name = "txtCelsiusOutput";
            this.txtCelsiusOutput.ReadOnly = true;
            this.txtCelsiusOutput.Size = new System.Drawing.Size(100, 20);
            this.txtCelsiusOutput.TabIndex = 7;
            // 
            // btnCtF
            // 
            this.btnCtF.Location = new System.Drawing.Point(77, 108);
            this.btnCtF.Name = "btnCtF";
            this.btnCtF.Size = new System.Drawing.Size(92, 23);
            this.btnCtF.TabIndex = 8;
            this.btnCtF.Text = "Convert C to F";
            this.btnCtF.UseVisualStyleBackColor = true;
            this.btnCtF.Click += new System.EventHandler(this.btnCtF_Click);
            // 
            // btnFtC
            // 
            this.btnFtC.Location = new System.Drawing.Point(77, 226);
            this.btnFtC.Name = "btnFtC";
            this.btnFtC.Size = new System.Drawing.Size(92, 23);
            this.btnFtC.TabIndex = 9;
            this.btnFtC.Text = "Convert F to C";
            this.btnFtC.UseVisualStyleBackColor = true;
            this.btnFtC.Click += new System.EventHandler(this.btnFtC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 261);
            this.Controls.Add(this.btnFtC);
            this.Controls.Add(this.btnCtF);
            this.Controls.Add(this.txtCelsiusOutput);
            this.Controls.Add(this.txtFarenheitInput);
            this.Controls.Add(this.txtFarenheitOutput);
            this.Controls.Add(this.txtCelsiusInput);
            this.Controls.Add(this.lblCelsiusOutput);
            this.Controls.Add(this.lblFarenheitInput);
            this.Controls.Add(this.lblFarenheitOutput);
            this.Controls.Add(this.lblCelsiusInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCelsiusInput;
        private System.Windows.Forms.Label lblFarenheitOutput;
        private System.Windows.Forms.Label lblFarenheitInput;
        private System.Windows.Forms.Label lblCelsiusOutput;
        private System.Windows.Forms.TextBox txtCelsiusInput;
        private System.Windows.Forms.TextBox txtFarenheitOutput;
        private System.Windows.Forms.TextBox txtFarenheitInput;
        private System.Windows.Forms.TextBox txtCelsiusOutput;
        private System.Windows.Forms.Button btnCtF;
        private System.Windows.Forms.Button btnFtC;
    }
}

