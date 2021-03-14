
namespace project1.Modifiers
{
    partial class JoinTableModifier
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
            this.group = new System.Windows.Forms.GroupBox();
            this.secondTableColumnSelect = new System.Windows.Forms.ComboBox();
            this.firstTableColumnSelect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.group.SuspendLayout();
            this.SuspendLayout();
            // 
            // group
            // 
            this.group.Controls.Add(this.secondTableColumnSelect);
            this.group.Controls.Add(this.firstTableColumnSelect);
            this.group.Controls.Add(this.label2);
            this.group.Controls.Add(this.tableSelect);
            this.group.Controls.Add(this.label1);
            this.group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group.Location = new System.Drawing.Point(0, 0);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(150, 150);
            this.group.TabIndex = 0;
            this.group.TabStop = false;
            this.group.Text = "Join";
            // 
            // secondTableColumnSelect
            // 
            this.secondTableColumnSelect.FormattingEnabled = true;
            this.secondTableColumnSelect.Location = new System.Drawing.Point(6, 99);
            this.secondTableColumnSelect.Name = "secondTableColumnSelect";
            this.secondTableColumnSelect.Size = new System.Drawing.Size(102, 21);
            this.secondTableColumnSelect.TabIndex = 4;
            this.secondTableColumnSelect.SelectedIndexChanged += new System.EventHandler(this.InnerStateChanged);
            // 
            // firstTableColumnSelect
            // 
            this.firstTableColumnSelect.FormattingEnabled = true;
            this.firstTableColumnSelect.Location = new System.Drawing.Point(6, 72);
            this.firstTableColumnSelect.Name = "firstTableColumnSelect";
            this.firstTableColumnSelect.Size = new System.Drawing.Size(102, 21);
            this.firstTableColumnSelect.TabIndex = 3;
            this.firstTableColumnSelect.SelectedIndexChanged += new System.EventHandler(this.InnerStateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "On";
            // 
            // tableSelect
            // 
            this.tableSelect.FormattingEnabled = true;
            this.tableSelect.Location = new System.Drawing.Point(6, 32);
            this.tableSelect.Name = "tableSelect";
            this.tableSelect.Size = new System.Drawing.Size(102, 21);
            this.tableSelect.TabIndex = 1;
            this.tableSelect.SelectedIndexChanged += new System.EventHandler(this.tableSelect_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "With";
            // 
            // JoinTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.group);
            this.Name = "JoinTable";
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.ComboBox tableSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox firstTableColumnSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox secondTableColumnSelect;
    }
}
