namespace Hugos_Bank
{
    partial class LogIn
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
            this.openAccount1 = new Hugos_Bank.OpenAccount();
            this.userControl11 = new Hugos_Bank.UserControl1();
            this.dashboard1 = new Hugos_Bank.Dashboard("");
            this.SuspendLayout();
            // 
            // openAccount1
            // 
            this.openAccount1.Location = new System.Drawing.Point(118, 118);
            this.openAccount1.Name = "openAccount1";
            this.openAccount1.Size = new System.Drawing.Size(681, 482);
            this.openAccount1.TabIndex = 1;
            this.openAccount1.Visible = false;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(49, 31);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(782, 643);
            this.userControl11.TabIndex = 0;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(49, 118);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(774, 508);
            this.dashboard1.TabIndex = 2;
            this.dashboard1.Visible = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 708);
            this.Controls.Add(this.dashboard1);
            this.Controls.Add(this.openAccount1);
            this.Controls.Add(this.userControl11);
            this.Name = "LogIn";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl1 userControl11;
        private OpenAccount openAccount1;
        private Dashboard dashboard1;
    }
}

