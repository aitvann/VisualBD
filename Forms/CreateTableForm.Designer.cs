
namespace ViauslDB.Forms
{
    partial class CreateTableForm
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
            this.name1 = new System.Windows.Forms.TextBox();
            this.name2 = new System.Windows.Forms.TextBox();
            this.name4 = new System.Windows.Forms.TextBox();
            this.name3 = new System.Windows.Forms.TextBox();
            this.name5 = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.type5 = new System.Windows.Forms.TextBox();
            this.type3 = new System.Windows.Forms.TextBox();
            this.type4 = new System.Windows.Forms.TextBox();
            this.type2 = new System.Windows.Forms.TextBox();
            this.type1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // name1
            // 
            this.name1.Location = new System.Drawing.Point(147, 37);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(100, 20);
            this.name1.TabIndex = 0;
            this.name1.TextChanged += new System.EventHandler(this.columnTextChanged);
            // 
            // name2
            // 
            this.name2.Location = new System.Drawing.Point(147, 79);
            this.name2.Name = "name2";
            this.name2.Size = new System.Drawing.Size(100, 20);
            this.name2.TabIndex = 1;
            this.name2.TextChanged += new System.EventHandler(this.columnTextChanged);
            // 
            // name4
            // 
            this.name4.Location = new System.Drawing.Point(147, 163);
            this.name4.Name = "name4";
            this.name4.Size = new System.Drawing.Size(100, 20);
            this.name4.TabIndex = 2;
            this.name4.TextChanged += new System.EventHandler(this.columnTextChanged);
            // 
            // name3
            // 
            this.name3.Location = new System.Drawing.Point(147, 119);
            this.name3.Name = "name3";
            this.name3.Size = new System.Drawing.Size(100, 20);
            this.name3.TabIndex = 7;
            this.name3.TextChanged += new System.EventHandler(this.columnTextChanged);
            // 
            // name5
            // 
            this.name5.Location = new System.Drawing.Point(147, 208);
            this.name5.Name = "name5";
            this.name5.Size = new System.Drawing.Size(100, 20);
            this.name5.TabIndex = 8;
            this.name5.TextChanged += new System.EventHandler(this.columnTextChanged);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(428, 206);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 9;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // type5
            // 
            this.type5.Location = new System.Drawing.Point(283, 208);
            this.type5.Name = "type5";
            this.type5.Size = new System.Drawing.Size(100, 20);
            this.type5.TabIndex = 14;
            this.type5.TextChanged += new System.EventHandler(this.columnTextChanged);
            // 
            // type3
            // 
            this.type3.Location = new System.Drawing.Point(283, 119);
            this.type3.Name = "type3";
            this.type3.Size = new System.Drawing.Size(100, 20);
            this.type3.TabIndex = 13;
            this.type3.TextChanged += new System.EventHandler(this.columnTextChanged);
            // 
            // type4
            // 
            this.type4.Location = new System.Drawing.Point(283, 163);
            this.type4.Name = "type4";
            this.type4.Size = new System.Drawing.Size(100, 20);
            this.type4.TabIndex = 12;
            this.type4.TextChanged += new System.EventHandler(this.columnTextChanged);
            // 
            // type2
            // 
            this.type2.Location = new System.Drawing.Point(283, 79);
            this.type2.Name = "type2";
            this.type2.Size = new System.Drawing.Size(100, 20);
            this.type2.TabIndex = 11;
            this.type2.TextChanged += new System.EventHandler(this.columnTextChanged);
            // 
            // type1
            // 
            this.type1.Location = new System.Drawing.Point(283, 37);
            this.type1.Name = "type1";
            this.type1.Size = new System.Drawing.Size(100, 20);
            this.type1.TabIndex = 10;
            this.type1.TextChanged += new System.EventHandler(this.columnTextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Table name";
            // 
            // tableName
            // 
            this.tableName.Location = new System.Drawing.Point(11, 37);
            this.tableName.Name = "tableName";
            this.tableName.Size = new System.Drawing.Size(100, 20);
            this.tableName.TabIndex = 17;
            // 
            // CreateTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 238);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tableName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.type5);
            this.Controls.Add(this.type3);
            this.Controls.Add(this.type4);
            this.Controls.Add(this.type2);
            this.Controls.Add(this.type1);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.name5);
            this.Controls.Add(this.name3);
            this.Controls.Add(this.name4);
            this.Controls.Add(this.name2);
            this.Controls.Add(this.name1);
            this.Name = "CreateTableForm";
            this.Text = "Create table";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name1;
        private System.Windows.Forms.TextBox name2;
        private System.Windows.Forms.TextBox name4;
        private System.Windows.Forms.TextBox name3;
        private System.Windows.Forms.TextBox name5;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox type5;
        private System.Windows.Forms.TextBox type3;
        private System.Windows.Forms.TextBox type4;
        private System.Windows.Forms.TextBox type2;
        private System.Windows.Forms.TextBox type1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tableName;
    }
}