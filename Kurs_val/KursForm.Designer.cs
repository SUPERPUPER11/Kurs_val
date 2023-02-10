namespace Kurs_val
{
    partial class KursForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.KursTab = new System.Windows.Forms.TabControl();
            this.Kursval1 = new System.Windows.Forms.TabPage();
            this.Favourites1 = new System.Windows.Forms.TabPage();
            this.forFavouritesDataGrid = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameValute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Button = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.KursTab.SuspendLayout();
            this.Favourites1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.forFavouritesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.KursTab);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(69, 20);
            this.toolStripStatusLabel1.Text = "__________";
            // 
            // KursTab
            // 
            this.KursTab.Controls.Add(this.Kursval1);
            this.KursTab.Controls.Add(this.Favourites1);
            this.KursTab.Location = new System.Drawing.Point(3, 28);
            this.KursTab.Name = "KursTab";
            this.KursTab.SelectedIndex = 0;
            this.KursTab.Size = new System.Drawing.Size(794, 410);
            this.KursTab.TabIndex = 1;
            this.KursTab.SelectedIndexChanged += new System.EventHandler(this.KursTab_SelectedIndexChanged);
            // 
            // Kursval1
            // 
            this.Kursval1.Location = new System.Drawing.Point(4, 29);
            this.Kursval1.Name = "Kursval1";
            this.Kursval1.Padding = new System.Windows.Forms.Padding(3);
            this.Kursval1.Size = new System.Drawing.Size(786, 377);
            this.Kursval1.TabIndex = 0;
            this.Kursval1.Text = "Курс валют";
            this.Kursval1.UseVisualStyleBackColor = true;
            // 
            // Favourites1
            // 
            this.Favourites1.Controls.Add(this.forFavouritesDataGrid);
            this.Favourites1.Location = new System.Drawing.Point(4, 29);
            this.Favourites1.Name = "Favourites1";
            this.Favourites1.Padding = new System.Windows.Forms.Padding(3);
            this.Favourites1.Size = new System.Drawing.Size(786, 377);
            this.Favourites1.TabIndex = 1;
            this.Favourites1.Text = "Избранное";
            this.Favourites1.UseVisualStyleBackColor = true;
            // 
            // forFavouritesDataGrid
            // 
            this.forFavouritesDataGrid.AllowUserToAddRows = false;
            this.forFavouritesDataGrid.AllowUserToDeleteRows = false;
            this.forFavouritesDataGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.forFavouritesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.forFavouritesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.NameValute,
            this.Count,
            this.Curse,
            this.Button});
            this.forFavouritesDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.forFavouritesDataGrid.Location = new System.Drawing.Point(3, 3);
            this.forFavouritesDataGrid.Name = "forFavouritesDataGrid";
            this.forFavouritesDataGrid.ReadOnly = true;
            this.forFavouritesDataGrid.RowHeadersWidth = 51;
            this.forFavouritesDataGrid.RowTemplate.Height = 29;
            this.forFavouritesDataGrid.Size = new System.Drawing.Size(780, 371);
            this.forFavouritesDataGrid.TabIndex = 0;
            this.forFavouritesDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.forFavouritesDataGrid_CellContentClick);
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "Код Валюты";
            this.Code.MinimumWidth = 6;
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 125;
            // 
            // NameValute
            // 
            this.NameValute.DataPropertyName = "Name";
            this.NameValute.HeaderText = "Название";
            this.NameValute.MinimumWidth = 6;
            this.NameValute.Name = "NameValute";
            this.NameValute.ReadOnly = true;
            this.NameValute.Width = 125;
            // 
            // Count
            // 
            this.Count.DataPropertyName = "Nominal";
            this.Count.HeaderText = "Количество";
            this.Count.MinimumWidth = 6;
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Width = 125;
            // 
            // Curse
            // 
            this.Curse.DataPropertyName = "Curs";
            this.Curse.HeaderText = "Курс";
            this.Curse.MinimumWidth = 6;
            this.Curse.Name = "Curse";
            this.Curse.ReadOnly = true;
            this.Curse.Width = 125;
            // 
            // Button
            // 
            this.Button.HeaderText = "";
            this.Button.MinimumWidth = 6;
            this.Button.Name = "Button";
            this.Button.ReadOnly = true;
            this.Button.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Button.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Button.Text = "❌";
            this.Button.UseColumnTextForButtonValue = true;
            this.Button.Width = 125;
            // 
            // KursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "KursForm";
            this.Text = "KursForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.KursTab.ResumeLayout(false);
            this.Favourites1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.forFavouritesDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TabControl KursTab;
        private TabPage Favourites1;
        public StatusStrip statusStrip1;
        public ToolStripStatusLabel toolStripStatusLabel1;
        public DataGridView forFavouritesDataGrid;
        public TabPage Kursval1;
        private DataGridViewTextBoxColumn Code;
        private DataGridViewTextBoxColumn NameValute;
        private DataGridViewTextBoxColumn Count;
        private DataGridViewTextBoxColumn Curse;
        private DataGridViewButtonColumn Button;
        public Panel panel1;
    }
}