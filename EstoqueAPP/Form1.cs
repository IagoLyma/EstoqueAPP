using System.Data;
using System.Data.SQLite;

namespace EstoqueAPP
{
    public partial class Form1 : Form
    {
        string dbPath = @"C:\Users\Iago\Desktop\EstoqueAPP\logistica.db";

        string connectString;
        public Form1()
        {
            InitializeComponent();

            connectString = $"Data Source = {dbPath};Version=3;";
        }

        private void TestarConexao()
        {
            try
            {
                using (var connection = new SQLiteConnection(connectString))
                {
                    connection.Open();
                    MessageBox.Show("Conectado ao banco!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TestarConexao();
        }

        private void InserirVeiculo()
        {
            try
            {
                using (var connection = new SQLiteConnection(connectString))
                {
                    connection.Open();

                    string sqlinsert = "INSERT INTO VEICULO (MODELO, PLACA, CONSUMO_MEDIO, CARGA_MAXIMA) VALUES (@modelov, @placav, @cons, @carga)";

                    using (var cmd = new SQLiteCommand(sqlinsert, connection))
                    {
                        cmd.Parameters.AddWithValue("@modelov", txt_modeloveiculo.Text);
                        cmd.Parameters.AddWithValue("@placav", txt_placaveiculo.Text);
                        cmd.Parameters.AddWithValue("@cons", txt_consumoveiculo.Text);
                        cmd.Parameters.AddWithValue("@carga", txt_cargaveiculo.Text);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Veiculo inserido com sucesso!");


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir {ex.Message}");
            }
        }

        private void btn_salvar_veiculo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_modeloveiculo.Text))
            {
                MessageBox.Show("O campo Modelo do Veiculo é obrigatório para inserir!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_modeloveiculo.Focus();
            }

            if (string.IsNullOrWhiteSpace(txt_placaveiculo.Text))
            {
                MessageBox.Show("O campo Placa é obrigatório para inserir!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_placaveiculo.Focus();
            }

            if (string.IsNullOrWhiteSpace(txt_consumoveiculo.Text))
            {
                MessageBox.Show("O campo Consumo é obrigatório para inserir!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_consumoveiculo.Focus();
            }

            if (string.IsNullOrWhiteSpace(txt_cargaveiculo.Text))
            {
                MessageBox.Show("O campo Carga Máxima é obrigatório para inserir!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_cargaveiculo.Focus();
            }

            else
            {
                InserirVeiculo();
            }
        }

        private void ConsultaVeiculoViagem()
        {
            try
            {
                using (var connection = new SQLiteConnection(connectString))
                {
                    connection.Open();

                    string sqlselect = "SELECT (MODELO || ' - ' || PLACA) AS DESCRICAO, PLACA FROM VEICULO ORDER BY MODELO";

                    using (var adapter = new SQLiteDataAdapter(sqlselect, connection))
                    {

                        DataTable tabelaVeiculos = new DataTable();

                        adapter.Fill(tabelaVeiculos);

                        cb_veiculoviagem.DataSource = tabelaVeiculos;

                        cb_veiculoviagem.DisplayMember = "DESCRICAO";

                        cb_veiculoviagem.ValueMember = "PLACA";

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar veiculos {ex.Message}");
            }
        }

        private void cb_veiculoviagem_DropDown(object sender, EventArgs e)
        {
            ConsultaVeiculoViagem();
        }
    }
}
