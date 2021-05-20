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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conect;
            conect = new SqlConnection(@"Data Source=DESKTOP-J2QA716\SQLEXPRESS;Initial Catalog=clienteData;Integrated Security=True");

            conect.Open();

            SqlCommand inserir = new SqlCommand("insert into client values('"+
                textUser.Text+"','"+textNome.Text+"','"+textSobre.Text+"','"+
                maskedCpf.Text+"',"+int.Parse(maskedIdade.Text)+",'"+textEnd.Text+"')", conect);
            
            int res = inserir.ExecuteNonQuery();
            if(res == 1)
            {
                MessageBox.Show("Cadastrado com sucesso!");
                textUser.Clear();
                textNome.Clear();
                textSobre.Clear();
                textEnd.Clear();
                maskedCpf.Clear();
                maskedIdade.Clear();
            }
            else{
                MessageBox.Show("Erro!");
            }
            conect.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conect;
            conect = new SqlConnection(@"Data Source=DESKTOP-J2QA716\SQLEXPRESS;Initial Catalog=clienteData;Integrated Security=True");

            conect.Open();
            SqlCommand busca;
            busca = new SqlCommand("select sobrenome from client where nome ='"+datNome+"'");
            SqlDataReader dr = busca.ExecuteReader();
        }
    }
}
