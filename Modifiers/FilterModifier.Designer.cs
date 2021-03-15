
namespace ViauslDB.Modifiers
{
    partial class FilterModifier
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.predicate = new System.Windows.Forms.TextBox();
            this.columnSelect = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.predicate);
            this.groupBox2.Controls.Add(this.columnSelect);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(156, 86);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter";
            // 
            // predicate
            // 
            this.predicate.Location = new System.Drawing.Point(7, 52);
            this.predicate.Name = "predicate";
            this.predicate.Size = new System.Drawing.Size(100, 20);
            this.predicate.TabIndex = 2;
            this.predicate.TextChanged += new System.EventHandler(this.InnerStateChanged);
            // 
            // columnSelect
            // 
            this.columnSelect.FormattingEnabled = true;
            this.columnSelect.Location = new System.Drawing.Point(7, 21);
            this.columnSelect.Name = "columnSelect";
            this.columnSelect.Size = new System.Drawing.Size(102, 21);
            this.columnSelect.TabIndex = 1;
            this.columnSelect.SelectedIndexChanged += new System.EventHandler(this.InnerStateChanged);
            // 
            // FilterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Name = "FilterControl";
            this.Size = new System.Drawing.Size(156, 86);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox predicate;
        private System.Windows.Forms.ComboBox columnSelect;
    }
}
