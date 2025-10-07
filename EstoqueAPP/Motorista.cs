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
    public partial class Motorista : Form
    {

        string dbPath = @"C:\Users\iago.lfarias\Desktop\EstoqueAPP\logistica.db";

        string connectString;

        public class DadosMotorista
        {
            public string motoristaid { get; set; }
            public string nomemoto { get; set; }
            public string cnhmoto { get; set; }
            public string fonemoto { get; set; }
        }

        public DadosMotorista MotoristaSelecionado { get; private set; }

        public Motorista()
        {
            InitializeComponent();

            connectString = $"Data Source = {dbPath};Version=3;";

        }

        private void Motorista_Load(object sender, EventArgs e)
        {
            PesquisarMotorista();
        }

        private void PesquisarMotorista()
        {
            try
            {
                using (var connection = new SQLiteConnection(connectString))
                {
                    connection.Open();

                    string sqlselect = "SELECT * FROM MOTORISTA";

                    using (var grid = new SQLiteDataAdapter(sqlselect, connection))
                    {
                        DataTable dt = new DataTable(); //Cria o data table
                        grid.Fill(dt); //preenche o data table
                        grid_motorista.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao consultar veiculos: {ex.Message}");
            }
        }

        private void grid_motorista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = grid_motorista.Rows[e.RowIndex];


                MotoristaSelecionado = new DadosMotorista
                {
                    motoristaid = row.Cells["MOTORISTAID"].Value.ToString(),
                    nomemoto = row.Cells["NOME"].Value.ToString(),
                    cnhmoto = row.Cells["CNH"].Value.ToString(),
                    fonemoto = row.Cells["TELEFONE"].Value.ToString()
                };


                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btn_procurarmotorista_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new SQLiteConnection(connectString))
                {
                    connection.Open();

                    string sqlpesquisa = "SELECT * FROM MOTORISTA \r\nWHERE NOME LIKE @Termo \r\n   OR CNH LIKE @Termo \r\n   OR TELEFONE LIKE @Termo;";

                    using (var cmd = new SQLiteCommand(sqlpesquisa, connection))
                    {
                        cmd.Parameters.AddWithValue("@Termo", txt_pesquisarmoto.Text);
                        cmd.ExecuteNonQuery();

                        using (var adapter = new SQLiteDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            grid_motorista.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao pesquisar: {ex.Message}");
            }
        }

        private void btn_resetmoto_Click(object sender, EventArgs e)
        {
            ResetarProcuraMoto();
        }

        private void ResetarProcuraMoto()
        {
            try
            {
                using (var connection = new SQLiteConnection(connectString))
                {
                    connection.Open();

                    string select = "SELECT * FROM MOTORISTA;";

                    using (var cmd = new SQLiteCommand(select, connection))
                    {
                        cmd.ExecuteNonQuery();

                        using (var adpter = new SQLiteDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adpter.Fill(dt);
                            grid_motorista.DataSource = dt;
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
