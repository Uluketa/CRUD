namespace Projeto_Vendas_ETEC.br.com.projetos.views
{
    partial class Frmprodutos
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.forn = new System.Windows.Forms.ComboBox();
            this.cod = new System.Windows.Forms.TextBox();
            this.qtd = new System.Windows.Forms.TextBox();
            this.preco = new System.Windows.Forms.TextBox();
            this.desc = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgprodutos = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.cRUDCADASTROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTAToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem19 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem20 = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTAToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgprodutos)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label15);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1026, 24);
            this.panel2.TabIndex = 11;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(998, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 24);
            this.label15.TabIndex = 7;
            this.label15.Text = "X";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(828, 340);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 45);
            this.button3.TabIndex = 10;
            this.button3.Text = "Excluir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(602, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 45);
            this.button2.TabIndex = 9;
            this.button2.Text = "Alterar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(378, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(378, 73);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(636, 251);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.forn);
            this.tabPage1.Controls.Add(this.cod);
            this.tabPage1.Controls.Add(this.qtd);
            this.tabPage1.Controls.Add(this.preco);
            this.tabPage1.Controls.Add(this.desc);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(628, 220);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Pessoais";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // forn
            // 
            this.forn.FormattingEnabled = true;
            this.forn.Location = new System.Drawing.Point(199, 163);
            this.forn.Name = "forn";
            this.forn.Size = new System.Drawing.Size(313, 26);
            this.forn.TabIndex = 39;
            // 
            // cod
            // 
            this.cod.Location = new System.Drawing.Point(297, 23);
            this.cod.Name = "cod";
            this.cod.Size = new System.Drawing.Size(104, 26);
            this.cod.TabIndex = 27;
            // 
            // qtd
            // 
            this.qtd.Location = new System.Drawing.Point(324, 114);
            this.qtd.Name = "qtd";
            this.qtd.Size = new System.Drawing.Size(296, 26);
            this.qtd.TabIndex = 22;
            // 
            // preco
            // 
            this.preco.Location = new System.Drawing.Point(63, 112);
            this.preco.Name = "preco";
            this.preco.Size = new System.Drawing.Size(133, 26);
            this.preco.TabIndex = 15;
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(89, 67);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(531, 26);
            this.desc.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(108, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 19);
            this.label12.TabIndex = 11;
            this.label12.Text = "Fornecedor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(216, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Qtd. estoque:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Preço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgprodutos);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(628, 220);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta de clientes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgprodutos
            // 
            this.dgprodutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgprodutos.Location = new System.Drawing.Point(6, 6);
            this.dgprodutos.Name = "dgprodutos";
            this.dgprodutos.Size = new System.Drawing.Size(616, 208);
            this.dgprodutos.TabIndex = 40;
            this.dgprodutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgprodutos_CellClick);
            this.dgprodutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgprodutos_CellContentClick);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 24);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(40, 434);
            this.panel6.TabIndex = 36;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Location = new System.Drawing.Point(0, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(69, 311);
            this.panel3.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem13,
            this.toolStripMenuItem16,
            this.toolStripMenuItem19});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(35, 311);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical270;
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.BackColor = System.Drawing.Color.Black;
            this.toolStripMenuItem13.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem14,
            this.cRUDCADASTROToolStripMenuItem});
            this.toolStripMenuItem13.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem13.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(22, 57);
            this.toolStripMenuItem13.Text = "Clientes";
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.BackColor = System.Drawing.Color.Black;
            this.toolStripMenuItem14.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(139, 22);
            this.toolStripMenuItem14.Text = "CRUD";
            this.toolStripMenuItem14.Click += new System.EventHandler(this.toolStripMenuItem14_Click);
            // 
            // cRUDCADASTROToolStripMenuItem
            // 
            this.cRUDCADASTROToolStripMenuItem.Name = "cRUDCADASTROToolStripMenuItem";
            this.cRUDCADASTROToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.cRUDCADASTROToolStripMenuItem.Text = "CONSULTA";
            this.cRUDCADASTROToolStripMenuItem.Click += new System.EventHandler(this.cRUDCADASTROToolStripMenuItem_Click);
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.BackColor = System.Drawing.Color.Black;
            this.toolStripMenuItem16.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem17,
            this.cONSULTAToolStripMenuItem1});
            this.toolStripMenuItem16.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.toolStripMenuItem16.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(22, 92);
            this.toolStripMenuItem16.Text = "Fornecedores";
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.BackColor = System.Drawing.Color.Black;
            this.toolStripMenuItem17.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new System.Drawing.Size(139, 22);
            this.toolStripMenuItem17.Text = "CRUD";
            this.toolStripMenuItem17.Click += new System.EventHandler(this.toolStripMenuItem17_Click);
            // 
            // cONSULTAToolStripMenuItem1
            // 
            this.cONSULTAToolStripMenuItem1.Name = "cONSULTAToolStripMenuItem1";
            this.cONSULTAToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.cONSULTAToolStripMenuItem1.Text = "CONSULTA";
            this.cONSULTAToolStripMenuItem1.Click += new System.EventHandler(this.cONSULTAToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem19
            // 
            this.toolStripMenuItem19.BackColor = System.Drawing.Color.Black;
            this.toolStripMenuItem19.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem20,
            this.cONSULTAToolStripMenuItem2});
            this.toolStripMenuItem19.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.toolStripMenuItem19.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem19.Name = "toolStripMenuItem19";
            this.toolStripMenuItem19.Size = new System.Drawing.Size(22, 85);
            this.toolStripMenuItem19.Text = "Funcionários";
            // 
            // toolStripMenuItem20
            // 
            this.toolStripMenuItem20.BackColor = System.Drawing.Color.Black;
            this.toolStripMenuItem20.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem20.Name = "toolStripMenuItem20";
            this.toolStripMenuItem20.Size = new System.Drawing.Size(139, 22);
            this.toolStripMenuItem20.Text = "CRUD";
            this.toolStripMenuItem20.Click += new System.EventHandler(this.toolStripMenuItem20_Click);
            // 
            // cONSULTAToolStripMenuItem2
            // 
            this.cONSULTAToolStripMenuItem2.Name = "cONSULTAToolStripMenuItem2";
            this.cONSULTAToolStripMenuItem2.Size = new System.Drawing.Size(139, 22);
            this.cONSULTAToolStripMenuItem2.Text = "CONSULTA";
            this.cONSULTAToolStripMenuItem2.Click += new System.EventHandler(this.cONSULTAToolStripMenuItem2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(46, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 78);
            this.label4.TabIndex = 37;
            this.label4.Text = "PRODUTOS";
            // 
            // Frmprodutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 458);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmprodutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmprodutos";
            this.Load += new System.EventHandler(this.Frmprodutos_load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgprodutos)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox cod;
        private System.Windows.Forms.TextBox qtd;
        private System.Windows.Forms.TextBox preco;
        private System.Windows.Forms.TextBox desc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgprodutos;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox forn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem cRUDCADASTROToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem17;
        private System.Windows.Forms.ToolStripMenuItem cONSULTAToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem19;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem20;
        private System.Windows.Forms.ToolStripMenuItem cONSULTAToolStripMenuItem2;
    }
}