namespace BIBLIOTECA
{
    partial class frmMenu
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empréstimoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devoluçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geraisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estatísticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.movimentosToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(780, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.livrosToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(107, 29);
            this.cadastrosToolStripMenuItem.Text = "&Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(151, 30);
            this.clientesToolStripMenuItem.Text = "&Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // livrosToolStripMenuItem
            // 
            this.livrosToolStripMenuItem.Name = "livrosToolStripMenuItem";
            this.livrosToolStripMenuItem.Size = new System.Drawing.Size(151, 30);
            this.livrosToolStripMenuItem.Text = "&Livros";
            this.livrosToolStripMenuItem.Click += new System.EventHandler(this.livrosToolStripMenuItem_Click);
            // 
            // movimentosToolStripMenuItem
            // 
            this.movimentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empréstimoToolStripMenuItem,
            this.devoluçãoToolStripMenuItem});
            this.movimentosToolStripMenuItem.Name = "movimentosToolStripMenuItem";
            this.movimentosToolStripMenuItem.Size = new System.Drawing.Size(128, 29);
            this.movimentosToolStripMenuItem.Text = "&Movimentos";
            // 
            // empréstimoToolStripMenuItem
            // 
            this.empréstimoToolStripMenuItem.Name = "empréstimoToolStripMenuItem";
            this.empréstimoToolStripMenuItem.Size = new System.Drawing.Size(184, 30);
            this.empréstimoToolStripMenuItem.Text = "Empréstimo";
            this.empréstimoToolStripMenuItem.Click += new System.EventHandler(this.empréstimoToolStripMenuItem_Click);
            // 
            // devoluçãoToolStripMenuItem
            // 
            this.devoluçãoToolStripMenuItem.Name = "devoluçãoToolStripMenuItem";
            this.devoluçãoToolStripMenuItem.Size = new System.Drawing.Size(184, 30);
            this.devoluçãoToolStripMenuItem.Text = "Devolução";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geraisToolStripMenuItem,
            this.estatísticoToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(108, 29);
            this.relatóriosToolStripMenuItem.Text = "&Relatórios";
            // 
            // geraisToolStripMenuItem
            // 
            this.geraisToolStripMenuItem.Name = "geraisToolStripMenuItem";
            this.geraisToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.geraisToolStripMenuItem.Text = "Gerais";
            this.geraisToolStripMenuItem.Click += new System.EventHandler(this.geraisToolStripMenuItem_Click);
            // 
            // estatísticoToolStripMenuItem
            // 
            this.estatísticoToolStripMenuItem.Name = "estatísticoToolStripMenuItem";
            this.estatísticoToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.estatísticoToolStripMenuItem.Text = "Estatístico";
            this.estatísticoToolStripMenuItem.Click += new System.EventHandler(this.estatísticoToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.sobreToolStripMenuItem.Text = "&Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(56, 29);
            this.sairToolStripMenuItem.Text = "S&air";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 436);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(780, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(103, 17);
            this.toolStripStatusLabel1.Text = "Sistema Biblioteca";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Click += new System.EventHandler(this.frmMenu_Load);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 458);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Gestão Biblioteca - FEMA 2020";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empréstimoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devoluçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geraisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estatísticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    }
}