
namespace ViauslDB.Modifiers
{
    partial class ColumnsSelectModifier
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
            this.panel = new System.Windows.Forms.Panel();
            this.group.SuspendLayout();
            this.SuspendLayout();
            // 
            // group
            // 
            this.group.Controls.Add(this.panel);
            this.group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group.Location = new System.Drawing.Point(0, 0);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(132, 150);
            this.group.TabIndex = 0;
            this.group.TabStop = false;
            this.group.Text = "Columns select";
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(3, 16);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(126, 131);
            this.panel.TabIndex = 0;
            // 
            // ColumnsSelectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.group);
            this.Name = "ColumnsSelectControl";
            this.Size = new System.Drawing.Size(132, 150);
            this.group.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.Panel panel;
    }
}
