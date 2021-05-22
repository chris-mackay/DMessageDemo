namespace DMessageDemo
{
    partial class MainForm
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
            this.showMessage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showMessage
            // 
            this.showMessage.Location = new System.Drawing.Point(87, 164);
            this.showMessage.Name = "showMessage";
            this.showMessage.Size = new System.Drawing.Size(175, 23);
            this.showMessage.TabIndex = 0;
            this.showMessage.Text = "ShowMessage";
            this.showMessage.UseVisualStyleBackColor = true;
            this.showMessage.Click += new System.EventHandler(this.showMessage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 104);
            this.label1.TabIndex = 1;
            this.label1.Text = "DialogMessage.dll has already been added to references.\r\n\r\nTo run:\r\n\r\nClick F5 (d" +
    "ebug)\r\nClick Ctrl+F5 (release)\r\n\r\nClick ShowMessage button";
            // 
            // MainForm
            // 
            this.AcceptButton = this.showMessage;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 199);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DMessage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showMessage;
        private System.Windows.Forms.Label label1;
    }
}

