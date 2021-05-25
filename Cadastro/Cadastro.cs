using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }


        private void comboMarc_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboMarc.Text == "CHEVROLET")
            {
                comboModel.Items.Add("ONIX");
                comboModel.Items.Add("CRUZE");
                comboModel.Items.Add("CAMARO");
            }
        }

        private void comboModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboModel.Text == "ONIX")
            {
                pictureBox2.Image = Image.FromFile("../Pics/onix_ver.jpg");
            }
            if (comboModel.Text == "CAMARO")
            {
                pictureBox2.Image = Image.FromFile("../Pics/camaro_ver.png");
            }
        }

        private void comboCor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboCor.Text == "BRANCO")
            {
                pictureBox2.Image = Image.FromFile("../Pics/onix_bran.jpg");
            }
            if (comboCor.Text == "PRETO")
            {
                pictureBox2.Image = Image.FromFile("../Pics/onix_pre.jpg");
            }
            if (comboCor.Text == "VERMELHO")
            {
                pictureBox2.Image = Image.FromFile("../Pics/onix_ver.jpg");
            }

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void concluir_Click(object sender, EventArgs e)
        {
            SqlConnection conect;
            //mudar para o endereço no seu pc
            conect = new SqlConnection(@"Data Source=DESKTOP-J2QA716\SQLEXPRESS;Initial Catalog=Veiculo;Integrated Security=True");

            conect.Open();

            SqlCommand cliente = new SqlCommand("insert into cliente values('" +
                boxName.Text + "','" + maskedCpf.Text + "','" + boxEnd.Text + "') insert into carro values('" + 
                maskedPlaca.Text + "', '" + comboMarc.Text + "', '" + comboModel.Text +
                "', '" + comboCor.Text + "', '" + boxObs.Text + "','" + maskedCpf.Text + "')", conect);

            int res = cliente.ExecuteNonQuery();
            if (res >= 1)
            {
                MessageBox.Show("Cadastrado com sucesso!");
                boxName.Clear();
                maskedCpf.Clear();
                boxEnd.Clear();
                maskedPlaca.Clear();
                comboMarc.SelectedItem.Equals("");
                comboModel.SelectedItem.Equals("");
                comboCor.SelectedItem.Equals("");
                boxObs.Text = "";

            }
            else
            {
                MessageBox.Show("Erro!");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
