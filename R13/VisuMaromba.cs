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
    public partial class VisuMaromba : Form
    {
        #region Variáveis globais
        private string? pesquisaPaga;
        private string? pesquisaNpaga;
        private string? nomeMaromba;
        private string data_source = "datasource=localhost;username=root;password=;database=bd_r13academia";
        private DateTime prxData;
        private int idData;
        private int idMaromba;
        #endregion

        public VisuMaromba()
        {
            InitializeComponent();

            #region Gerar LTV
            ltvPaga.View = View.Details;
            ltvPaga.LabelEdit = true;
            ltvPaga.AllowColumnReorder = true;
            ltvPaga.FullRowSelect = true;
            ltvPaga.GridLines = true;
            ltvPaga.Columns.Add("Nome", 280, HorizontalAlignment.Left);
            ltvPaga.Columns.Add("Ultimo Pagamento", 120, HorizontalAlignment.Right);
            ltvPaga.Columns.Add("Validade", 120, HorizontalAlignment.Right);

            ltvNpaga.View = View.Details;
            ltvNpaga.LabelEdit = true;
            ltvNpaga.AllowColumnReorder = true;
            ltvNpaga.FullRowSelect = true;
            ltvNpaga.GridLines = true;
            ltvNpaga.Columns.Add("Nome", 280, HorizontalAlignment.Left);
            ltvNpaga.Columns.Add("Ultimo Pagamento", 120, HorizontalAlignment.Right);
            ltvNpaga.Columns.Add("Validade", 120, HorizontalAlignment.Right);
            #endregion
        }

        

        private void VisuMaromba_Load(object sender, EventArgs e)
        {
            try
            {
                var Conexao = new MySqlConnection(data_source);

                #region LIST VIEW PAGA
                string sqlLtv = "select ma.nm_maromba, dt.ult_pagamento as UltimoPag, dt.prx_pagamento as ProximoPag from tb_marombas as ma inner join tb_datas as dt on (dt.id_data = ma.id_data) where dt.prx_pagamento > curdate() order by ma.nm_maromba";

                // a linha abaixo junta a instrução sql mais a conexao com o banco
                MySqlCommand comandoLtv = new MySqlCommand(sqlLtv, Conexao);

                //A linha abaixo vai criar uma variavel de memória chamada Reader
                // para guardar o resutado do Select   *****

                Conexao.Open();

                MySqlDataReader reader = comandoLtv.ExecuteReader();

                ltvPaga.Items.Clear();

                while (reader.Read())
                {
                    // a linha abaixo cria um vetor para organizar a linhas da ListView

                    string[] row =
                    {
                            reader.GetString(0),
                            reader.GetDateTime(1).ToString("dd/MM/yyyy"),
                            reader.GetDateTime(2).ToString("dd/MM/yyyy"),
                        };
                    // elemento windows forms para criar as linhas da ListView
                    var linha_listview = new ListViewItem(row);
                    // a linha abaixo adiciona na listview a linha que 
                    // acabou de ser criada no passo anterior
                    ltvPaga.Items.Add(linha_listview);

                }
                Conexao.Close();
                #endregion

                #region LIST VIEW N PAGA
                string sqlLtvNpag = "select ma.nm_maromba, dt.ult_pagamento as UltimoPag, dt.prx_pagamento as ProximoPag from tb_marombas as ma inner join tb_datas as dt on (dt.id_data = ma.id_data) where dt.prx_pagamento <= curdate() order by ma.nm_maromba";

                // a linha abaixo junta a instrução sql mais a conexao com o banco
                MySqlCommand comandoNpag = new MySqlCommand(sqlLtvNpag, Conexao);

                Conexao.Open();

                MySqlDataReader readerN = comandoNpag.ExecuteReader();

                ltvNpaga .Items.Clear();

                while (readerN.Read())
                {
                    // a linha abaixo cria um vetor para organizar a linhas da ListView

                    string[] row =
                    {
                            readerN.GetString(0),
                            readerN.GetDateTime(1).ToString("dd/MM/yyyy"),
                            readerN.GetDateTime(2).ToString("dd/MM/yyyy"),
                        };
                    // elemento windows forms para criar as linhas da ListView
                    var linha_listviewN = new ListViewItem(row);
                    // a linha abaixo adiciona na listview a linha que 
                    // acabou de ser criada no passo anterior
                    ltvNpaga.Items.Add(linha_listviewN);

                }
                Conexao.Close();
                #endregion 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        #region Pesquisas
        private void icbPesquisarPaga_Click(object sender, EventArgs e)
        {
            var Conexao = new MySqlConnection(data_source);
            pesquisaPaga = txbPesquisarPaga.Texts;

            #region LIST VIEW PAGA
            string pesquisaSql = pesquisaPaga + "%";
            string sqlLtv = "select ma.nm_maromba, dt.ult_pagamento as UltimoPag, dt.prx_pagamento as ProximoPag from tb_marombas as ma inner join tb_datas as dt on (dt.id_data = ma.id_data) where dt.prx_pagamento > curdate() and ma.nm_maromba like '"+ pesquisaSql + "' ";

            // a linha abaixo junta a instrução sql mais a conexao com o banco
            MySqlCommand comandoLtv = new MySqlCommand(sqlLtv, Conexao);

            //A linha abaixo vai criar uma variavel de memória chamada Reader
            // para guardar o resutado do Select   *****

            Conexao.Open();

            MySqlDataReader reader = comandoLtv.ExecuteReader();

            ltvPaga.Items.Clear();

            while (reader.Read())
            {
                // a linha abaixo cria um vetor para organizar a linhas da ListView

                string[] row =
                {
                            reader.GetString(0),
                            reader.GetDateTime(1).ToString("dd/MM/yyyy"),
                            reader.GetDateTime(2).ToString("dd/MM/yyyy"),
                        };
                // elemento windows forms para criar as linhas da ListView
                var linha_listview = new ListViewItem(row);
                // a linha abaixo adiciona na listview a linha que 
                // acabou de ser criada no passo anterior
                ltvPaga.Items.Add(linha_listview);

            }
            Conexao.Close();
            #endregion

            txbPesquisarPaga.Focus();
        }
        private void txbPesquisarPaga_Enter(object sender, EventArgs e)
        {
        }

        private void icbPesquisarNpaga_Click(object sender, EventArgs e)
        {
            var Conexao = new MySqlConnection(data_source);
            pesquisaNpaga = txbPesquisarNpaga.Texts;

            #region LIST VIEW N PAGA
            string pesquisaSql2 = pesquisaNpaga + "%";

            string sqlLtvNpag = "select ma.nm_maromba, dt.ult_pagamento as UltimoPag, dt.prx_pagamento as ProximoPag from tb_marombas as ma inner join tb_datas as dt on (dt.id_data = ma.id_data) where dt.prx_pagamento <= curdate() and ma.nm_maromba like '"+ pesquisaSql2 +"' order by ma.nm_maromba";

            // a linha abaixo junta a instrução sql mais a conexao com o banco
            MySqlCommand comandoNpag = new MySqlCommand(sqlLtvNpag, Conexao);

            Conexao.Open();

            MySqlDataReader readerN = comandoNpag.ExecuteReader();

            ltvNpaga.Items.Clear();

            while (readerN.Read())
            {
                // a linha abaixo cria um vetor para organizar a linhas da ListView

                string[] row =
                {
                            readerN.GetString(0),
                            readerN.GetDateTime(1).ToString("dd/MM/yyyy"),
                            readerN.GetDateTime(2).ToString("dd/MM/yyyy"),
                        };
                // elemento windows forms para criar as linhas da ListView
                var linha_listviewN = new ListViewItem(row);
                // a linha abaixo adiciona na listview a linha que 
                // acabou de ser criada no passo anterior
                ltvNpaga.Items.Add(linha_listviewN);

            }
            Conexao.Close();
            #endregion

            txbPesquisarNpaga.Focus();
        }
        private void txbPesquisarNpaga_Enter(object sender, EventArgs e)
        {
        }
        #endregion

        #region Editar Dados LTV
        private void ltvPaga_DoubleClick(object sender, EventArgs e)
        {
            string qtdRegiao = ltvPaga.Items.Count.ToString();

            if(qtdRegiao == "0")
            {
                MessageBox.Show("Não existe registro para alterar!", "Aviso");
            }
            else
            {
                nomeMaromba = ltvPaga.SelectedItems[0].SubItems[0].Text;
                txbNmCompletoAtt.Texts = nomeMaromba;
                txbNmCompletoAtt.BackColor = Color.MidnightBlue;

                try
                {
                    #region Pegar Data do Maromba
                    var Conexao = new MySqlConnection(data_source);
                    string sqlDtMaromba = "select dt.prx_pagamento from tb_marombas as ma join tb_datas as dt on (dt.id_data = ma.id_data) where ma.nm_maromba = '"+ nomeMaromba +"'";

                    MySqlCommand comandDt = new MySqlCommand(sqlDtMaromba, Conexao);

                    Conexao.Open();

                    MySqlDataReader readerDt = comandDt.ExecuteReader();

                    while (readerDt.Read())
                    {
                        prxData = readerDt.GetDateTime(0);
                    }

                    dtpSerPaga.Value = prxData;

                    Conexao.Close();
                    #endregion

                    #region Pegar id do Maromba
                    string sqlIdMaromba = "select id_maromba from tb_marombas where nm_maromba = '" + nomeMaromba + "'";

                    MySqlCommand comandId = new MySqlCommand(sqlIdMaromba, Conexao);

                    Conexao.Open();

                    MySqlDataReader readerId = comandId.ExecuteReader();

                    while (readerId.Read())
                    {
                        idMaromba = readerId.GetInt32(0);
                    }

                    Conexao.Close();
                    #endregion
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ltvNpaga_DoubleClick(object sender, EventArgs e)
        {
            string qtdRegiao2 = ltvNpaga.Items.Count.ToString();

            if (qtdRegiao2 == "0")
            {
                MessageBox.Show("Não existe registro para alterar!", "Aviso");
            }
            else
            {
                nomeMaromba = ltvNpaga.SelectedItems[0].SubItems[0].Text;
                txbNmCompletoAtt.Texts = nomeMaromba;
                txbNmCompletoAtt.BackColor = Color.MidnightBlue;

                try
                {
                    #region Pegar Data do Maromba
                    var Conexao = new MySqlConnection(data_source);
                    string sqlDtMaromba = "select dt.prx_pagamento from tb_marombas as ma join tb_datas as dt on (dt.id_data = ma.id_data) where ma.nm_maromba = '" + nomeMaromba + "'";

                    MySqlCommand comandDt = new MySqlCommand(sqlDtMaromba, Conexao);

                    Conexao.Open();

                    MySqlDataReader readerDt = comandDt.ExecuteReader();

                    while (readerDt.Read())
                    {
                        prxData = readerDt.GetDateTime(0);
                    }

                    dtpSerPaga.Value = prxData;

                    Conexao.Close();
                    #endregion
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion


        #region Botoes
        private void btnAttPagamento_Click(object sender, EventArgs e)
        {
            if (txbNmCompletoAtt.Texts == "Selecione um dado")
            {
                MessageBox.Show("Nenhum Dado Selecionado");
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja atualizar as INFORMAÇÕES desse registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    try
                    {
                        #region Pegar id da data
                        var Conexao = new MySqlConnection(data_source);

                        string sqlidDt = "select dt.id_data from tb_marombas as ma join tb_datas as dt on (dt.id_data = ma.id_data) where ma.nm_maromba = '" + nomeMaromba + "'";

                        MySqlCommand comandIdDt = new MySqlCommand(sqlidDt, Conexao);

                        Conexao.Open();

                        MySqlDataReader readerIdDt = comandIdDt.ExecuteReader();

                        while (readerIdDt.Read())
                        {
                            idData = readerIdDt.GetInt32(0);
                        }
                        Conexao.Close();
                        #endregion

                        #region Atualizar Pagamento
                        DateTime dateTimeAtt = (dtpAttPagamento.Value).Date;
                        var attDataPagamento = dateTimeAtt.ToString("yyyy-MM-dd");

                        string upSql = "update tb_datas set ult_pagamento = '" + attDataPagamento + "' where id_data = '" + idData + "' ";

                        MySqlCommand comandoUp = new MySqlCommand(upSql, Conexao);

                        Conexao.Open();

                        comandoUp.ExecuteReader();

                        Conexao.Close();
                        #endregion

                        #region Mudar Nome
                        if (icbLockName.IconChar == FontAwesome.Sharp.IconChar.LockOpen)
                        {
                            nomeMaromba = txbNmCompletoAtt.Texts;

                            string upNomeSql = "update tb_marombas set nm_maromba = '" + nomeMaromba + "' where id_maromba = " + idMaromba + " ";

                            MySqlCommand comandoNmUp = new MySqlCommand(upNomeSql, Conexao);

                            Conexao.Open();

                            comandoNmUp.ExecuteReader();

                            Conexao.Close();
                        }
                        #endregion

                        #region LIST VIEW PAGA
                        string sqlLtv = "select ma.nm_maromba, dt.ult_pagamento as UltimoPag, dt.prx_pagamento as ProximoPag from tb_marombas as ma inner join tb_datas as dt on (dt.id_data = ma.id_data) where dt.prx_pagamento > curdate() order by ma.nm_maromba";

                        // a linha abaixo junta a instrução sql mais a conexao com o banco
                        MySqlCommand comandoLtv = new MySqlCommand(sqlLtv, Conexao);

                        //A linha abaixo vai criar uma variavel de memória chamada Reader
                        // para guardar o resutado do Select   *****

                        Conexao.Open();

                        MySqlDataReader reader = comandoLtv.ExecuteReader();

                        ltvPaga.Items.Clear();

                        while (reader.Read())
                        {
                            // a linha abaixo cria um vetor para organizar a linhas da ListView

                            string[] row =
                            {
                            reader.GetString(0),
                            reader.GetDateTime(1).ToString("dd/MM/yyyy"),
                            reader.GetDateTime(2).ToString("dd/MM/yyyy"),
                        };
                            // elemento windows forms para criar as linhas da ListView
                            var linha_listview = new ListViewItem(row);
                            // a linha abaixo adiciona na listview a linha que 
                            // acabou de ser criada no passo anterior
                            ltvPaga.Items.Add(linha_listview);

                        }
                        Conexao.Close();
                        #endregion

                        #region LIST VIEW N PAGA
                        string sqlLtvNpag = "select ma.nm_maromba, dt.ult_pagamento as UltimoPag, dt.prx_pagamento as ProximoPag from tb_marombas as ma inner join tb_datas as dt on (dt.id_data = ma.id_data) where dt.prx_pagamento <= curdate() order by ma.nm_maromba";

                        // a linha abaixo junta a instrução sql mais a conexao com o banco
                        MySqlCommand comandoNpag = new MySqlCommand(sqlLtvNpag, Conexao);

                        Conexao.Open();

                        MySqlDataReader readerN = comandoNpag.ExecuteReader();

                        ltvNpaga.Items.Clear();

                        while (readerN.Read())
                        {
                            // a linha abaixo cria um vetor para organizar a linhas da ListView

                            string[] row =
                            {
                            readerN.GetString(0),
                            readerN.GetDateTime(1).ToString("dd/MM/yyyy"),
                            readerN.GetDateTime(2).ToString("dd/MM/yyyy"),
                        };
                            // elemento windows forms para criar as linhas da ListView
                            var linha_listviewN = new ListViewItem(row);
                            // a linha abaixo adiciona na listview a linha que 
                            // acabou de ser criada no passo anterior
                            ltvNpaga.Items.Add(linha_listviewN);

                        }
                        Conexao.Close();
                        #endregion
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    txbNmCompletoAtt.BackColor = Color.LightGray;
                    txbNmCompletoAtt.Texts = "Selecione um dado";
                    dtpSerPaga.Value = new DateTime(2000, 01, 01);

                    MessageBox.Show("Registro atualizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbNmCompletoAtt.BackColor = Color.LightGray;
            txbNmCompletoAtt.Enabled = false;
            icbLockName.IconChar = FontAwesome.Sharp.IconChar.Lock;
            txbNmCompletoAtt.Texts = "Selecione um dado";
            dtpSerPaga.Value = new DateTime(2000, 01, 01);
        }

        private void icbLockName_Click(object sender, EventArgs e)
        {
            if ((icbLockName.IconChar == FontAwesome.Sharp.IconChar.Lock) && (txbNmCompletoAtt.Texts != "Selecione um dado"))
            {
                icbLockName.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
                txbNmCompletoAtt.Enabled = true;
            }
            else
            {
                icbLockName.IconChar = FontAwesome.Sharp.IconChar.Lock;
                txbNmCompletoAtt.Enabled = false;
            }

        }
        #endregion

        #region Lixo
        private void ltvPaga_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        #endregion

        
    }
}
