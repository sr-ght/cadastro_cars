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
                    boxMarc.Text = res[5].ToString();
                    boxModel.Text = res[6].ToString();
                    boxCor.Text = res[7].ToString();
                    boxObs.Text = res[8].ToString();

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
            
            buscaPlaca.Visible = false;
            buscaName.Visible = false;
            groupBusca.Visible = false;
            editar.Enabled = false;
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

        private void excluir_Click(object sender, EventArgs e)
        {
            SqlConnection conect;
            //mudar para o endereço no seu pc
            conect = new SqlConnection(@"Data Source=DESKTOP-J2QA716\SQLEXPRESS;Initial Catalog=Veiculo;Integrated Security=True");

            conect.Open();
            var result = MessageBox.Show(this, "Tem certeza que deseja excluir?",
                                   "Alerta", MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Warning);

            if(result == DialogResult.Yes)
            {
                SqlCommand excluir = new SqlCommand("delete from carro where placa='" + buscaPlaca.Text + "'", conect);

                int res = excluir.ExecuteNonQuery();
                if(res == 1)
                {
                    MessageBox.Show("Excluido!");
                }
                else
                {
                    MessageBox.Show("Algo deu errado!");
                }
                
            }

            conect.Close();

        }

        private void editar_Click(object sender, EventArgs e)
        {
            SqlConnection conect;
            //mudar para o endereço no seu pc
            conect = new SqlConnection(@"Data Source=DESKTOP-J2QA716\SQLEXPRESS;Initial Catalog=Veiculo;Integrated Security=True");

            conect.Open();
            var result = MessageBox.Show(this, "Tem certeza que deseja excluir?",
                                   "Alerta", MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                SqlCommand excluir = new SqlCommand("update carro set marca='" + boxMarc.Text + "',modelo='" + boxModel.Text + "',cor='" + boxCor.Text + "',obs='" + boxObs.Text + "' where placa='" + buscaPlaca.Text + "'", conect);

                int res = excluir.ExecuteNonQuery();
                if (res == 1)
                {
                    MessageBox.Show("Editado!");
                    groupBusca.Visible = false;
                }
                else
                {
                    MessageBox.Show("Algo deu errado!");
                }
            }
        }

        private void habilitar_CheckedChanged(object sender, EventArgs e)
        {
            if (habilitar.Checked)
            {

                editar.BackColor = Color.DodgerBlue;
                excluir.BackColor = Color.LightCoral;
                editar.Enabled = true;
                //boxName.Enabled = true;
                //boxCpf.Enabled = true;
                //boxEnd.Enabled = true;
                boxMarc.Enabled = true;
                boxModel.Enabled = true;
                boxCor.Enabled = true;
                boxObs.Enabled = true;
                excluir.Enabled = false;
            }
            else
            {
                editar.BackColor = Color.Wheat;
                excluir.BackColor = Color.Red;
                editar.Enabled = false;
                //boxName.Enabled = false;
                //boxCpf.Enabled = false;
                //boxEnd.Enabled = false;
                boxMarc.Enabled = false;
                boxModel.Enabled = false;
                boxCor.Enabled = false;
                boxObs.Enabled = false;
                excluir.Enabled = true;
            }
        }
    }
}
