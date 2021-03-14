
namespace project1.Modifiers
{
    partial class OrderModifier
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.orderSelect = new System.Windows.Forms.ComboBox();
            this.columnSelect = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.orderSelect);
            this.groupBox1.Controls.Add(this.columnSelect);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 84);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order";
            // 
            // orderSelect
            // 
            this.orderSelect.FormattingEnabled = true;
            this.orderSelect.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.orderSelect.Location = new System.Drawing.Point(6, 48);
            this.orderSelect.Name = "orderSelect";
            this.orderSelect.Size = new System.Drawing.Size(100, 21);
            this.orderSelect.TabIndex = 1;
            this.orderSelect.SelectedIndexChanged += new System.EventHandler(this.InnerStateChanged);
            // 
            // columnSelect
            // 
            this.columnSelect.FormattingEnabled = true;
            this.columnSelect.Location = new System.Drawing.Point(6, 21);
            this.columnSelect.Name = "columnSelect";
            this.columnSelect.Size = new System.Drawing.Size(102, 21);
            this.columnSelect.TabIndex = 0;
            this.columnSelect.SelectedIndexChanged += new System.EventHandler(this.InnerStateChanged);
            // 
            // OrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "OrderControl";
            this.Size = new System.Drawing.Size(161, 84);
            this.Load += new System.EventHandler(this.OrderControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox orderSelect;
        private System.Windows.Forms.ComboBox columnSelect;
    }
}
