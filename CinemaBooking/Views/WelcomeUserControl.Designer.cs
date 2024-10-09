namespace CinemaBooking.Views {
    partial class WelcomeUserControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            lblSessions = new Label();
            SuspendLayout();
            // 
            // lblSessions
            // 
            lblSessions.Anchor = AnchorStyles.Top;
            lblSessions.AutoSize = true;
            lblSessions.Font = new Font("Microsoft New Tai Lue", 16F, FontStyle.Bold);
            lblSessions.Location = new Point(431, 229);
            lblSessions.Name = "lblSessions";
            lblSessions.Size = new Size(153, 43);
            lblSessions.TabIndex = 2;
            lblSessions.Text = "Merhaba";
            // 
            // WelcomeUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblSessions);
            Name = "WelcomeUserControl";
            Size = new Size(1002, 549);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSessions;
    }
}
