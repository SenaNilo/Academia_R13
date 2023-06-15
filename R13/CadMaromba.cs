using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace R13System
{
    public partial class CadMaromba : Form
    {
        private MySqlConnection? Conexao;
        private string data_source = "datasource=localhost;username=root;password=;database=bd_r13academia;convert zero datetime=True";

        public CadMaromba()
        {
            InitializeComponent();
        }

        private void btnCadMaromba_Click(object sender, EventArgs e)
        {
            #region Cadastro Maromba
            try
            {
                Conexao = new MySqlConnection(data_source);

                DateTime dateTime = (dtpMensalidade.Value).Date;
                var ultimoPag = dateTime.ToString("yyyy-MM-dd");

                string cadSql = "call cadMarombas('"+ txbNmCompletoCad.Texts +"', '"+ ultimoPag + "')";
                
                MySqlCommand comando = new MySqlCommand(cadSql, Conexao);

                Conexao.Open();

                comando.ExecuteReader();

                MessageBox.Show("Cadastrado com Sucesso !!");
                txbNmCompletoCad.Texts = "";
                txbNmCompletoCad.Focus();

                Conexao.Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            #endregion
        }
    }
}
