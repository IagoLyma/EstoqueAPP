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


    public partial class form_veiculo : Form
    {

        string dbPath = @"C:\Users\iago.lfarias\Desktop\EstoqueAPP\logistica.db";

        string connectString;

        public class DadosVeiculo
        {
            public string veiculoid { get; set; }
            public string modelo { get; set; }
            public string placa { get; set; }
            public string consumo { get; set; }
            public string carga { get; set; }
        }

        public DadosVeiculo VeiculoSelecionado { get; private set; }

        public form_veiculo()
        {
            InitializeComponent();

            connectString = $"Data Source = {dbPath};Version=3;";
        }

        private void form_veiculo_Load(object sender, EventArgs e)
        {
            PesquisarVeiculos();
        }

        private void PesquisarVeiculos()
        {
            try
            {
                using (var connection = new SQLiteConnection(connectString))
                {
                    connection.Open();

                    string sqlselect = "SELECT * FROM VEICULO";

                    using (var grid = new SQLiteDataAdapter(sqlselect, connection))
                    {
                        DataTable dt = new DataTable(); //Cria o data table
                        grid.Fill(dt); //preenche o data table
                        grid_veiculos.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao consultar veiculos: {ex.Message}");
            }
        }

        private void grid_veiculos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = grid_veiculos.Rows[e.RowIndex];


                VeiculoSelecionado = new DadosVeiculo
                {
                    veiculoid = row.Cells["VEICULOID"].Value.ToString(),
                    modelo = row.Cells["MODELO"].Value.ToString(),
                    placa = row.Cells["PLACA"].Value.ToString(),
                    consumo = row.Cells["CONSUMO_MEDIO"].Value.ToString(),
                    carga = row.Cells["CARGA_MAXIMA"].Value.ToString()
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

                    string sqlpesquisa = "SELECT * FROM VEICULO \r\nWHERE MODELO LIKE @Termo \r\n   OR PLACA LIKE @Termo \r\n   OR CONSUMO_MEDIO LIKE @Termo \r\n   OR CARGA_MAXIMA LIKE @Termo;";

                    using (var cmd = new SQLiteCommand(sqlpesquisa, connection))
                    {
                        cmd.Parameters.AddWithValue("@Termo", txt_pesquisa.Text);
                        cmd.ExecuteNonQuery();

                        using (var adapter = new SQLiteDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            grid_veiculos.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao pesquisar: {ex.Message}");
            }
        }

        private void btn_resetveiculo_Click(object sender, EventArgs e)
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

                    string select = "SELECT * FROM VEICULO;";

                    using (var cmd = new SQLiteCommand(select, connection))
                    {
                        cmd.ExecuteNonQuery();

                        using (var adpter = new SQLiteDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adpter.Fill(dt);
                            grid_veiculos.DataSource= dt;
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
