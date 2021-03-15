
namespace ViauslDB.Forms
{
    partial class LogsForm
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
            this.logs = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // logs
            // 
            this.logs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logs.Location = new System.Drawing.Point(0, 0);
            this.logs.Name = "logs";
            this.logs.ReadOnly = true;
            this.logs.Size = new System.Drawing.Size(800, 450);
            this.logs.TabIndex = 0;
            this.logs.Text = "";
            this.logs.WordWrap = false;
            // 
            // LogsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logs);
            this.Name = "LogsForm";
            this.Text = "Logs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox logs;
    }
}