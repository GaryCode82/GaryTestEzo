namespace CalculatorEzoGary
{
    partial class FormCalcul
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
            this.btnCalcul = new System.Windows.Forms.Button();
            this.helloWorldLabel = new System.Windows.Forms.Label();
            this.txtInputCalcul = new System.Windows.Forms.TextBox();
            this.lblErrorLog = new System.Windows.Forms.Label();
            this.rttResultsDisplay = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnCalcul
            // 
            this.btnCalcul.Location = new System.Drawing.Point(415, 161);
            this.btnCalcul.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalcul.Name = "btnCalcul";
            this.btnCalcul.Size = new System.Drawing.Size(130, 34);
            this.btnCalcul.TabIndex = 2;
            this.btnCalcul.Text = "Calculate";
            this.btnCalcul.UseVisualStyleBackColor = true;
            this.btnCalcul.Click += new System.EventHandler(this.btnCalcul_Click);
            // 
            // helloWorldLabel
            // 
            this.helloWorldLabel.AutoSize = true;
            this.helloWorldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloWorldLabel.Location = new System.Drawing.Point(233, 24);
            this.helloWorldLabel.Name = "helloWorldLabel";
            this.helloWorldLabel.Size = new System.Drawing.Size(258, 31);
            this.helloWorldLabel.TabIndex = 3;
            this.helloWorldLabel.Text = "Entrez votre formule";
            this.helloWorldLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtInputCalcul
            // 
            this.txtInputCalcul.Location = new System.Drawing.Point(195, 121);
            this.txtInputCalcul.Name = "txtInputCalcul";
            this.txtInputCalcul.Size = new System.Drawing.Size(350, 22);
            this.txtInputCalcul.TabIndex = 4;
            // 
            // lblErrorLog
            // 
            this.lblErrorLog.AutoSize = true;
            this.lblErrorLog.ForeColor = System.Drawing.Color.Red;
            this.lblErrorLog.Location = new System.Drawing.Point(41, 468);
            this.lblErrorLog.Name = "lblErrorLog";
            this.lblErrorLog.Size = new System.Drawing.Size(0, 17);
            this.lblErrorLog.TabIndex = 5;
            // 
            // rttResultsDisplay
            // 
            this.rttResultsDisplay.Location = new System.Drawing.Point(161, 276);
            this.rttResultsDisplay.Name = "rttResultsDisplay";
            this.rttResultsDisplay.Size = new System.Drawing.Size(431, 139);
            this.rttResultsDisplay.TabIndex = 6;
            this.rttResultsDisplay.Text = "";
            // 
            // FormCalcul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 497);
            this.Controls.Add(this.rttResultsDisplay);
            this.Controls.Add(this.lblErrorLog);
            this.Controls.Add(this.txtInputCalcul);
            this.Controls.Add(this.helloWorldLabel);
            this.Controls.Add(this.btnCalcul);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCalcul";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCalcul;
        private System.Windows.Forms.Label helloWorldLabel;
        private System.Windows.Forms.TextBox txtInputCalcul;
        private System.Windows.Forms.Label lblErrorLog;
        private System.Windows.Forms.RichTextBox rttResultsDisplay;
    }
}

