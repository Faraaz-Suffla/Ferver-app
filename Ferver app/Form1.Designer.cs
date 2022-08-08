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
            this.btnRedirectLink = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(55, 61);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(208, 20);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Please enter your temperature";
            // 
            // txtboxUserTemp
            // 
            this.txtboxUserTemp.Location = new System.Drawing.Point(86, 105);
            this.txtboxUserTemp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtboxUserTemp.Name = "txtboxUserTemp";
            this.txtboxUserTemp.Size = new System.Drawing.Size(114, 27);
            this.txtboxUserTemp.TabIndex = 1;
            // 
            // lblTempDisplay
            // 
            this.lblTempDisplay.AutoSize = true;
            this.lblTempDisplay.Location = new System.Drawing.Point(70, 252);
            this.lblTempDisplay.Name = "lblTempDisplay";
            this.lblTempDisplay.Size = new System.Drawing.Size(157, 20);
            this.lblTempDisplay.TabIndex = 2;
            this.lblTempDisplay.Text = "Your temperature is __.";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(95, 175);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(86, 31);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(206, 579);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 31);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRedirectLink
            // 
            this.btnRedirectLink.Location = new System.Drawing.Point(12, 579);
            this.btnRedirectLink.Name = "btnRedirectLink";
            this.btnRedirectLink.Size = new System.Drawing.Size(132, 29);
            this.btnRedirectLink.TabIndex = 5;
            this.btnRedirectLink.Text = "CoronaVirusLink";
            this.btnRedirectLink.UseVisualStyleBackColor = true;
            this.btnRedirectLink.Click += new System.EventHandler(this.btnRedirectLink_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 625);
            this.Controls.Add(this.btnRedirectLink);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblTempDisplay);
            this.Controls.Add(this.txtboxUserTemp);
            this.Controls.Add(this.lblQuestion);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Button btnRedirectLink;
    }
}
