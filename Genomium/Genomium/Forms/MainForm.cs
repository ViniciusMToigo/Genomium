using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genomium
{
    public partial class MainForm : Form
    {
        List<Organismo> Organismos = new List<Organismo>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (CaminhoValido(txtCaminho.Text))
            {
                string[] linhas = System.IO.File.ReadAllLines(txtCaminho.Text);

                //foreach (string linha in linhas)
                Parallel.ForEach(linhas, new ParallelOptions() { MaxDegreeOfParallelism = 8 }, linha =>
                {
                    string[] dados = linha.Split(';');
                    Organismos.Add(new Organismo(dados[0], dados[1], dados[2], dados[3], dados[4], Convert.ToInt32(dados[5]), Convert.ToInt32(dados[6]), dados[7]));
                });

                this.gvDados.AutoGenerateColumns = false;
                this.gvDados.DataSource = Organismos;
            }
        }

        private bool CaminhoValido(string caminho)
        {
            if (string.IsNullOrWhiteSpace(caminho))
            {
                MessageBox.Show("É necessário informar um caminho para carregar os dados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if(!File.Exists(caminho))
            {
                MessageBox.Show("O arquivo informado não foi encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
