namespace Ferver_app
{
    partial class Form1
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtboxUserTemp = new System.Windows.Forms.TextBox();
            this.lblTempDisplay = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(48, 46);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(165, 15);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Please enter your temperature";
            // 
            // txtboxUserTemp
            // 
            this.txtboxUserTemp.Location = new System.Drawing.Point(75, 79);
            this.txtboxUserTemp.Name = "txtboxUserTemp";
            this.txtboxUserTemp.Size = new System.Drawing.Size(100, 23);
            this.txtboxUserTemp.TabIndex = 1;
            // 
            // lblTempDisplay
            // 
            this.lblTempDisplay.AutoSize = true;
            this.lblTempDisplay.Location = new System.Drawing.Point(61, 189);
            this.lblTempDisplay.Name = "lblTempDisplay";
            this.lblTempDisplay.Size = new System.Drawing.Size(126, 15);
            this.lblTempDisplay.TabIndex = 2;
            this.lblTempDisplay.Text = "Your temperature is __.";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(83, 131);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(180, 434);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 469);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblTempDisplay);
            this.Controls.Add(this.txtboxUserTemp);
            this.Controls.Add(this.lblQuestion);
            this.Name = "Form1";
            this.Text = "Fever App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtboxUserTemp;
        private System.Windows.Forms.Label lblTempDisplay;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnExit;
    }
}
