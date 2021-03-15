
namespace ViauslDB.Forms
{
    partial class InsertForm
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
            this.field1 = new System.Windows.Forms.TextBox();
            this.field5 = new System.Windows.Forms.TextBox();
            this.field2 = new System.Windows.Forms.TextBox();
            this.field3 = new System.Windows.Forms.TextBox();
            this.field4 = new System.Windows.Forms.TextBox();
            this.insertButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // field1
            // 
            this.field1.Location = new System.Drawing.Point(12, 93);
            this.field1.Name = "field1";
            this.field1.Size = new System.Drawing.Size(100, 20);
            this.field1.TabIndex = 0;
            // 
            // field5
            // 
            this.field5.Location = new System.Drawing.Point(442, 93);
            this.field5.Name = "field5";
            this.field5.Size = new System.Drawing.Size(100, 20);
            this.field5.TabIndex = 1;
            // 
            // field2
            // 
            this.field2.Location = new System.Drawing.Point(124, 93);
            this.field2.Name = "field2";
            this.field2.Size = new System.Drawing.Size(100, 20);
            this.field2.TabIndex = 2;
            // 
            // field3
            // 
            this.field3.Location = new System.Drawing.Point(230, 93);
            this.field3.Name = "field3";
            this.field3.Size = new System.Drawing.Size(100, 20);
            this.field3.TabIndex = 3;
            // 
            // field4
            // 
            this.field4.Location = new System.Drawing.Point(336, 93);
            this.field4.Name = "field4";
            this.field4.Size = new System.Drawing.Size(100, 20);
            this.field4.TabIndex = 4;
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(467, 149);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 23);
            this.insertButton.TabIndex = 5;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Row";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Table name";
            // 
            // tableName
            // 
            this.tableName.Location = new System.Drawing.Point(12, 34);
            this.tableName.Name = "tableName";
            this.tableName.Size = new System.Drawing.Size(100, 20);
            this.tableName.TabIndex = 7;
            // 
            // InsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 258);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.field4);
            this.Controls.Add(this.field3);
            this.Controls.Add(this.field2);
            this.Controls.Add(this.field5);
            this.Controls.Add(this.field1);
            this.Name = "InsertForm";
            this.Text = "InsertForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox field1;
        private System.Windows.Forms.TextBox field5;
        private System.Windows.Forms.TextBox field2;
        private System.Windows.Forms.TextBox field3;
        private System.Windows.Forms.TextBox field4;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tableName;
    }
}