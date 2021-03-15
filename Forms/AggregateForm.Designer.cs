namespace ViauslDB.Forms
{
    partial class AggregateForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.funSelect = new System.Windows.Forms.ComboBox();
            this.columnSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Result: ";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(163, 30);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 20);
            this.result.TabIndex = 7;
            // 
            // funSelect
            // 
            this.funSelect.FormattingEnabled = true;
            this.funSelect.Location = new System.Drawing.Point(12, 83);
            this.funSelect.Name = "funSelect";
            this.funSelect.Size = new System.Drawing.Size(121, 21);
            this.funSelect.TabIndex = 5;
            this.funSelect.SelectedIndexChanged += new System.EventHandler(this.funSelect_SelectedIndexChanged);
            // 
            // columnSelect
            // 
            this.columnSelect.FormattingEnabled = true;
            this.columnSelect.Location = new System.Drawing.Point(12, 29);
            this.columnSelect.Name = "columnSelect";
            this.columnSelect.Size = new System.Drawing.Size(121, 21);
            this.columnSelect.TabIndex = 6;
            this.columnSelect.SelectedIndexChanged += new System.EventHandler(this.columnSelect_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Column";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Function";
            // 
            // AggregateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 121);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.result);
            this.Controls.Add(this.funSelect);
            this.Controls.Add(this.columnSelect);
            this.Name = "AggregateForm";
            this.Text = "Aggregate";
            this.Load += new System.EventHandler(this.AggregateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.ComboBox funSelect;
        private System.Windows.Forms.ComboBox columnSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}