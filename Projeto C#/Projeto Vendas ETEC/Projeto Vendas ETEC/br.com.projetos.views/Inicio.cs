using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Vendas_ETEC.br.com.projetos.views
{
    public partial class Inicio : Form
    {
        bool mover = false;
        Point posicao_inicial;

        public Inicio()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frmclientes frm = new Frmclientes();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frmfornecedores forn = new Frmfornecedores();
            forn.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frmfuncionarios func = new Frmfuncionarios();
            func.Show();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mover = true;
            posicao_inicial = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                Point novo = PointToScreen(e.Location);
                Location = new Point(novo.X - this.posicao_inicial.X, novo.Y - this.posicao_inicial.Y);
            }
        }

        private void AdicionarEventosControlos(Control contentor)
        {
            foreach (Control c in contentor.Controls)
            {
                Type tipo = c.GetType();
                if (tipo == typeof(Panel))
                {
                    c.MouseDown += panel1_MouseDown;
                    c.MouseUp += panel1_MouseUp;
                    c.MouseMove += panel1_MouseMove;
                }

                if (c.Controls.Count != 0)
                {
                    AdicionarEventosControlos(c);
                }
            }
        }
    }
}
