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
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conect;
            //mudar para o endereço no seu pc
            conect = new SqlConnection(@"Data Source=DESKTOP-J2QA716\SQLEXPRESS;Initial Catalog=Veiculo;Integrated Security=True");

            conect.Open();
            if (comboBusca.Text == "PLACA")
            {
                SqlCommand busca = new SqlCommand("select * from cliente, carro where placa='" + buscaPlaca.Text + "'", conect);

                SqlDataReader res = busca.ExecuteReader();

                if (res.Read())
                {
                    groupBusca.Visible = true;
                    boxName.Text = res[0].ToString();
                    boxCpf.Text = res[1].ToString();
                    boxEnd.Text = res[2].ToString();
                    boxPlaca.Text = res[3].ToString();
                    boxMarc.Text = res[4].ToString();
                    boxModel.Text = res[5].ToString();
                    boxCor.Text = res[6].ToString();
                    boxObs.Text = res[7].ToString();
                }
                else
                {
                    groupBusca.Visible = false;
                    MessageBox.Show("Não encontrado!");
                }
            }
            if (comboBusca.Text == "NOME")
            {
                SqlCommand busca = new SqlCommand("select * from cliente, carro where nome='" + buscaName.Text + "'", conect);

                SqlDataReader res = busca.ExecuteReader();

                if (res.Read())
                {
                    groupBusca.Visible = true;
                    boxName.Text = res[0].ToString();
                    boxCpf.Text = res[1].ToString();
                    boxEnd.Text = res[2].ToString();
                    boxPlaca.Text = res[3].ToString();
                    boxMarc.Text = res[4].ToString();
                    boxModel.Text = res[5].ToString();
                    boxCor.Text = res[6].ToString();
                    boxObs.Text = res[7].ToString();
                }
                else
                {
                    groupBusca.Visible = false;
                    MessageBox.Show("Não encontrado!");
                }
            }
            

        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            /*labelDC.Visible = false;
            labelNome.Visible = false;
            boxName.Visible = false;
            labelCpf.Visible = false;
            boxCpf.Visible = false;
            labelEnd.Visible = false;
            boxEnd.Visible = false;
            labelDV.Visible = false;
            labelPlaca.Visible = false;
            boxPlaca.Visible = false;
            labelMarc.Visible = false;
            boxMarc.Visible = false;
            labelModel.Visible = false;*/

            buscaPlaca.Visible = false;
            buscaName.Visible = false;
            groupBusca.Visible = false;
        }

        private void comboBusca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBusca.Text == "PLACA")
            {
                buscaPlaca.Visible = true;
                buscaName.Visible = false;
            }
            if (comboBusca.Text == "NOME")
            {
                buscaName.Visible = true;
                buscaPlaca.Visible = false;
            }
        }
    }
}
