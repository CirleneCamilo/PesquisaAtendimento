using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PesquisaAtendimento
{
    public partial class Form1 : Form
    {
        //variáveis globais
        int ContSim = 0;
        int ContNao = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtSim_Click(object sender, EventArgs e)
        {
            ContSim += 1;   //atualizando as contagens
            AtualizandoContagens();
        }

        private void BtNao_Click(object sender, EventArgs e)
        {
            ContNao += 1;   //atualizando as contagens
            AtualizandoContagens();
        }
        private void AtualizandoContagens()  //um procedimento de atualização de contagens
        {
            LbNao.Text = ContNao.ToString();
            LbSim.Text = ContSim.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
