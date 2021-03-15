using project1.Modifiers;

namespace project1
{
    partial class MainWindow
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aggregateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.createViwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.order = new project1.Modifiers.OrderModifier();
            this.pageSelector = new project1.Modifiers.PageSelectorModifier();
            this.joinTable = new project1.Modifiers.JoinTableModifier();
            this.columnsSelect = new project1.Modifiers.ColumnsSelectModifier();
            this.filter = new project1.Modifiers.FilterModifier();
            this.tableSelect = new project1.Modifiers.TableModifier();
            this.view = new project1.SelectView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionToolStripMenuItem,
            this.calculateToolStripMenuItem,
            this.actionToolStripMenuItem1,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(845, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createTableToolStripMenuItem,
            this.insertRowToolStripMenuItem});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.actionToolStripMenuItem.Text = "Table";
            // 
            // createTableToolStripMenuItem
            // 
            this.createTableToolStripMenuItem.Name = "createTableToolStripMenuItem";
            this.createTableToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.createTableToolStripMenuItem.Text = "Create table";
            this.createTableToolStripMenuItem.Click += new System.EventHandler(this.createTableToolStripMenuItem_Click);
            // 
            // insertRowToolStripMenuItem
            // 
            this.insertRowToolStripMenuItem.Name = "insertRowToolStripMenuItem";
            this.insertRowToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.insertRowToolStripMenuItem.Text = "Insert row";
            this.insertRowToolStripMenuItem.Click += new System.EventHandler(this.insertRowToolStripMenuItem_Click);
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aggregateToolStripMenuItem});
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.calculateToolStripMenuItem.Text = "Calculate";
            // 
            // aggregateToolStripMenuItem
            // 
            this.aggregateToolStripMenuItem.Name = "aggregateToolStripMenuItem";
            this.aggregateToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.aggregateToolStripMenuItem.Text = "Aggregate";
            this.aggregateToolStripMenuItem.Click += new System.EventHandler(this.aggregateToolStripMenuItem_Click);
            // 
            // actionToolStripMenuItem1
            // 
            this.actionToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createViwToolStripMenuItem});
            this.actionToolStripMenuItem1.Name = "actionToolStripMenuItem1";
            this.actionToolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
            this.actionToolStripMenuItem1.Text = "Action";
            // 
            // createViwToolStripMenuItem
            // 
            this.createViwToolStripMenuItem.Name = "createViwToolStripMenuItem";
            this.createViwToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.createViwToolStripMenuItem.Text = "Create view";
            this.createViwToolStripMenuItem.Click += new System.EventHandler(this.createViwToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // logsToolStripMenuItem
            // 
            this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            this.logsToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.logsToolStripMenuItem.Text = "Logs";
            this.logsToolStripMenuItem.Click += new System.EventHandler(this.logsToolStripMenuItem_Click);
            // 
            // order
            // 
            this.order.Location = new System.Drawing.Point(16, 363);
            this.order.Margin = new System.Windows.Forms.Padding(4);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(160, 97);
            this.order.TabIndex = 15;
            this.order.StateChanged += new System.EventHandler(this.UpdateTable);
            // 
            // pageSelector
            // 
            this.pageSelector.Database = null;
            this.pageSelector.Location = new System.Drawing.Point(184, 600);
            this.pageSelector.Margin = new System.Windows.Forms.Padding(4);
            this.pageSelector.Name = "pageSelector";
            this.pageSelector.Page = ((ulong)(1ul));
            this.pageSelector.PageSize = ((ulong)(1ul));
            this.pageSelector.Size = new System.Drawing.Size(644, 26);
            this.pageSelector.TabIndex = 14;
            this.pageSelector.StateChanged += new System.EventHandler(this.UpdateTable);
            // 
            // joinTable
            // 
            this.joinTable.Database = null;
            this.joinTable.Location = new System.Drawing.Point(16, 468);
            this.joinTable.Margin = new System.Windows.Forms.Padding(4);
            this.joinTable.Name = "joinTable";
            this.joinTable.Size = new System.Drawing.Size(160, 158);
            this.joinTable.TabIndex = 13;
            this.joinTable.StateChanged += new System.EventHandler(this.joinTable_StateChanged);
            // 
            // columnsSelect
            // 
            this.columnsSelect.Database = null;
            this.columnsSelect.Location = new System.Drawing.Point(16, 91);
            this.columnsSelect.Margin = new System.Windows.Forms.Padding(4);
            this.columnsSelect.Name = "columnsSelect";
            this.columnsSelect.Size = new System.Drawing.Size(160, 154);
            this.columnsSelect.TabIndex = 12;
            this.columnsSelect.StateChanged += new System.EventHandler(this.UpdateTable);
            // 
            // filter
            // 
            this.filter.Location = new System.Drawing.Point(16, 253);
            this.filter.Margin = new System.Windows.Forms.Padding(4);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(160, 102);
            this.filter.TabIndex = 16;
            this.filter.StateChanged += new System.EventHandler(this.UpdateTable);
            // 
            // tableSelect
            // 
            this.tableSelect.Database = null;
            this.tableSelect.Location = new System.Drawing.Point(16, 28);
            this.tableSelect.Margin = new System.Windows.Forms.Padding(4);
            this.tableSelect.Name = "tableSelect";
            this.tableSelect.Size = new System.Drawing.Size(160, 55);
            this.tableSelect.TabIndex = 17;
            this.tableSelect.StateChanged += new System.EventHandler(this.tableSelect_StateChanged);
            // 
            // view
            // 
            this.view.ColumnsSelect = null;
            this.view.Filter = null;
            this.view.JoinTable = null;
            this.view.Location = new System.Drawing.Point(184, 28);
            this.view.Margin = new System.Windows.Forms.Padding(4);
            this.view.Name = "view";
            this.view.Order = null;
            this.view.PageSelect = null;
            this.view.Size = new System.Drawing.Size(644, 564);
            this.view.TabIndex = 18;
            this.view.TableSelect = null;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 641);
            this.Controls.Add(this.view);
            this.Controls.Add(this.tableSelect);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.order);
            this.Controls.Add(this.pageSelector);
            this.Controls.Add(this.joinTable);
            this.Controls.Add(this.columnsSelect);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Text = "Window";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aggregateToolStripMenuItem;
        private ColumnsSelectModifier columnsSelect;
        private JoinTableModifier joinTable;
        private PageSelectorModifier pageSelector;
        private OrderModifier order;
        private FilterModifier filter;
        private TableModifier tableSelect;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem createViwToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;
        private SelectView view;
    }
}

