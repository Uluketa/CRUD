namespace Projeto_Vendas_ETEC.br.com.projetos.views
{
    partial class Frmlogin
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
            this.label18 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label18);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(883, 24);
            this.panel2.TabIndex = 6;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = new System.Drawing.Point(855, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(25, 24);
            this.label18.TabIndex = 6;
            this.label18.Text = "X";
            this.label18.Click += new System.EventHandler(this.label18_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label16);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 136);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(96, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(699, 78);
            this.label16.TabIndex = 30;
            this.label16.Text = "BEM-VINDO AO SISTEMA";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(214, 246);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(531, 20);
            this.txtsenha.TabIndex = 19;
            this.txtsenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtsenha.UseSystemPasswordChar = true;
            this.txtsenha.TextChanged += new System.EventHandler(this.preco_TextChanged);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(214, 193);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(531, 20);
            this.txtemail.TabIndex = 18;
            this.txtemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtemail.TextChanged += new System.EventHandler(this.desc_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "Senha:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "E-mail:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(325, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(248, 43);
            this.button2.TabIndex = 20;
            this.button2.Text = "Entrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(883, 376);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}