using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Draft;



namespace aula11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ListarPartida_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.ListarPartidas("T");
            RetornoListaPartidas.Text = retorno;

            retorno = retorno.Replace("\r", "");
            retorno = retorno.Substring(0, retorno.Length - 1);

            string[] partidas = retorno.Split('\n');

            listBox1.Items.AddRange(partidas);
            
           
        }

        private void RetornoListaPartidas_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
