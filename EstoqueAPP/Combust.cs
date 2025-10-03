using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EstoqueAPP.form_veiculo;

namespace EstoqueAPP
{
    public partial class Combust : Form
    {

        string dbPath = @"C:\Users\iago.lfarias\Desktop\EstoqueAPP\logistica.db";

        string connectString;

        public class PrecoCombustivel
        {
            public string precoid { get; set; }
            public string comb { get; set; }
            public string precocomb { get; set; }
            public string dataconscomb { get; set; }
        }

        public PrecoCombustivel CombSelecionado { get; private set; }

        public Combust()
        {
            InitializeComponent();

            connectString = $"Data Source = {dbPath};Version=3;";
        }

        private void Combust_Load(object sender, EventArgs e)
        {
            PesquisarComb();
        }

        private void PesquisarComb()
        {
            try
            {
                using (var connection = new SQLiteConnection(connectString))
                {
                    connection.Open();

                    string sqlselect = "SELECT * FROM PRECO_COMBUSTIVEL";

                    using (var grid = new SQLiteDataAdapter(sqlselect, connection))
                    {
                        DataTable dt = new DataTable(); //Cria o data table
                        grid.Fill(dt); //preenche o data table
                        grid_comb.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao consultar combustivel: {ex.Message}");
            }
        }

        private void grid_comb_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = grid_comb.Rows[e.RowIndex];


                CombSelecionado = new PrecoCombustivel
                {
                    precoid = row.Cells["PRECOID"].Value.ToString(),
                    comb = row.Cells["COMBUSTIVEL"].Value.ToString(),
                    precocomb = row.Cells["PRECO"].Value.ToString(),
                    dataconscomb = row.Cells["DATA_CONSULTA"].Value.ToString()
                };


                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btn_procurar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new SQLiteConnection(connectString))
                {
                    connection.Open();

                    string sqlpesquisa = "SELECT * FROM PRECO_COMBUSTIVEL \r\nWHERE COMBUSTIVEL LIKE @Termo \r\n   OR PRECO LIKE @Termo;";

                    using (var cmd = new SQLiteCommand(sqlpesquisa, connection))
                    {
                        cmd.Parameters.AddWithValue("@Termo", txt_pesquisa.Text);
                        cmd.ExecuteNonQuery();

                        using (var adapter = new SQLiteDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            grid_comb.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao pesquisar: {ex.Message}");
            }
        }

        private void btn_resetarpesquisa_Click(object sender, EventArgs e)
        {
            ResetarProcurar();
        }

        private void ResetarProcurar()
        {
            try
            {
                using (var connection = new SQLiteConnection(connectString))
                {
                    connection.Open();

                    string select = "SELECT * FROM PRECO_COMBUSTIVEL;";

                    using (var cmd = new SQLiteCommand(select, connection))
                    {
                        cmd.ExecuteNonQuery();

                        using (var adpter = new SQLiteDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adpter.Fill(dt);
                            grid_comb.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao pesquisar no banco: ${ex.Message}");
            }
        }
    }
}
