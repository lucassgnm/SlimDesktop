using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SilmDesktop.View.Cliente;
using SilmDesktop.View.Venda;

namespace SilmDesktop.View
{
    public partial class FormPrincipal : MetroFramework.Forms.MetroForm
    {
        public FormPrincipal(string nomeadm)
        {
            InitializeComponent();
            lblNomeAdm.Text = nomeadm;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = (1000); // 1 sec
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblDataHora.Text = DateTime.Now.ToString();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            FormProduto f = new FormProduto();
            f.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormCliente f = new FormCliente();
            f.ShowDialog();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            FormVenda f = new FormVenda();
            f.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblNomeAdm_Click(object sender, EventArgs e)
        {

        }
    }
}
