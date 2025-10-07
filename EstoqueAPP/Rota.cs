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

namespace EstoqueAPP
{
    public partial class Rota : Form
    {

        string dbPath = @"C:\Users\iago.lfarias\Desktop\EstoqueAPP\logistica.db";

        string connectString;

        public class DadosRota
        {
            public string rotaid { get; set; }
            public string origemrota { get; set; }
            public string destinorota { get; set; }
            public string distanciarota { get; set; }
        }

        public DadosRota RotaSelecionado { get; private set; }
        public Rota()
        {
            InitializeComponent();

            connectString = $"Data Source = {dbPath};Version=3;";
        }

        private void Rota_Load(object sender, EventArgs e)
        {
            PesquisarRota();
        }

        private void PesquisarRota()
        {
            try
            {
                using (var connection = new SQLiteConnection(connectString))
                {
                    connection.Open();

                    string selectmoto = "SELECT * FROM ROTA";

                    using (var grid = new SQLiteDataAdapter(selectmoto, connection))
                    {
                        DataTable dt = new DataTable();
                        grid.Fill(dt);
                        grid_rota.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao consultar rotas: {ex.Message}");
            }
        }

        private void grid_motorista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = grid_rota.Rows[e.RowIndex];

                RotaSelecionado = new DadosRota
                {
                    rotaid = row.Cells["ROTAID"].Value.ToString(),
                    origemrota = row.Cells["ORIGEM"].Value.ToString(),
                    destinorota = row.Cells["DESTINO"].Value.ToString(),
                    distanciarota = row.Cells["DISTANCIA"].Value.ToString()
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

                    string sqlpesquisa = "SELECT * FROM ROTA \r\nWHERE ROTAID LIKE @Termo OR ORIGEM LIKE @Termo \r\n   OR DESTINO LIKE @Termo \r\n OR DISTANCIA LIKE @Termo;";

                    using (var cmd = new SQLiteCommand(sqlpesquisa, connection))
                    {
                        cmd.Parameters.AddWithValue("@Termo", txt_pesquisa.Text);
                        cmd.ExecuteNonQuery();

                        using (var adapter = new SQLiteDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            grid_rota.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao pesquisar: {ex.Message}");
            }
        }

        private void btn_resetarrota_Click(object sender, EventArgs e)
        {
            ResetarProcura();
        }

        private void ResetarProcura()
        {
            try
            {
                using (var connection = new SQLiteConnection(connectString))
                {
                    connection.Open();

                    string select = "SELECT * FROM ROTA;";

                    using (var cmd = new SQLiteCommand(select, connection))
                    {
                        cmd.ExecuteNonQuery();

                        using (var adpter = new SQLiteDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adpter.Fill(dt);
                            grid_rota.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao pesquisar no banco: ${ex.Message}");
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
