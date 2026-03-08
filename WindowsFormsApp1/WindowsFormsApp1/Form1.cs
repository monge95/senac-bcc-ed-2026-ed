using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class lstBebidas : Form
    {
        public static string Items { get; private set; }
        public static string Item { get; private set; }

        public lstBebidas()
        {
            InitializeComponent();
            cboComida.Items.Add("pão com mantega");
            cboComida.Items.Add("pão com requejão");
            cboComida.SelectedIndex = 0;f

            lsbBebidas.Items.Add("café");
            lsbBebidas.Items.Add("suco de laranja");
        }

        private void cboComida_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            string pedido = ("seu pedido é: \n -  ");
            pedido += cboComida.SelectedItem.ToString();
            pedido += "\n -  " + lsbBebidas.SelectedItem.ToString();
            MessageBox.Show(pedido);
        }
    }
}
