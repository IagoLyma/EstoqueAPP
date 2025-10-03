using System.Data;
using System.Data.SQLite;
using static EstoqueAPP.form_veiculo;
using static EstoqueAPP.Rota;
using static EstoqueAPP.Motorista;
using static EstoqueAPP.Combust;
using System.Windows.Forms.VisualStyles;

namespace EstoqueAPP
{
    public partial class Form1 : Form
    {
        string dbPath = @"C:\Users\iago.lfarias\Desktop\EstoqueAPP\logistica.db";

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
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_placaveiculo.Text))
            {
                MessageBox.Show("O campo Placa é obrigatório para inserir!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_placaveiculo.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_consumoveiculo.Text))
            {
                MessageBox.Show("O campo Consumo é obrigatório para inserir!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_consumoveiculo.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_cargaveiculo.Text))
            {
                MessageBox.Show("O campo Carga Máxima é obrigatório para inserir!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_cargaveiculo.Focus();
                return;
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

        private void ConsultaRotaViagem()
        {
            try
            {
                using (var connection = new SQLiteConnection(connectString))
                {
                    connection.Open();

                    string sqlselect = "SELECT (ORIGEM || ' - Até - ' || DESTINO) AS DESCRICAO, ORIGEM FROM ROTA ORDER BY ORIGEM";

                    using (var adapter = new SQLiteDataAdapter(sqlselect, connection))
                    {

                        DataTable tabelaRotas = new DataTable();

                        adapter.Fill(tabelaRotas);

                        cb_rotaviagem.DataSource = tabelaRotas;

                        cb_rotaviagem.DisplayMember = "DESCRICAO";

                        cb_rotaviagem.ValueMember = "ORIGEM";

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar rotas {ex.Message}");
            }
        }

        private void cb_rotaviagem_DropDown(object sender, EventArgs e)
        {
            ConsultaRotaViagem();
        }

        private void ConsultaMotoristaViagem()
        {
            try
            {
                using (var connection = new SQLiteConnection(connectString))
                {
                    connection.Open();

                    string sqlselect = "SELECT (NOME || ' - ' || TELEFONE) AS DESCRICAO, NOME FROM MOTORISTA ORDER BY NOME";

                    using (var adapter = new SQLiteDataAdapter(sqlselect, connection))
                    {

                        DataTable tabelaMotorista = new DataTable();

                        adapter.Fill(tabelaMotorista);

                        cb_motoristaviagem.DataSource = tabelaMotorista;

                        cb_motoristaviagem.DisplayMember = "DESCRICAO";

                        cb_motoristaviagem.ValueMember = "NOME";

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar motoristas {ex.Message}");
            }
        }

        private void cb_motoristaviagem_DropDown(object sender, EventArgs e)
        {
            ConsultaMotoristaViagem();
        }

        private void InserirMotorista()
        {
            try
            {
                using (var connection = new SQLiteConnection(connectString))
                {
                    connection.Open();

                    string sqlinsert = "INSERT INTO MOTORISTA (NOME, CNH, TELEFONE) VALUES (@nome, @cnh, @tel);";

                    using (var cmd = new SQLiteCommand(sqlinsert, connection))
                    {
                        cmd.Parameters.AddWithValue("@nome", txt_nomemotorista.Text);
                        cmd.Parameters.AddWithValue("@cnh", txt_cnhmoto.Text);
                        cmd.Parameters.AddWithValue("@tel", txt_fonemoto.Text);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Motorista inserido(a) com sucesso!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir {ex.Message}");
            }
        }

        private void btn_salvar_motorista_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_nomemotorista.Text))
            {
                MessageBox.Show("O campo Nome motorista precisa ser preenchido!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_nomemotorista.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_cnhmoto.Text))
            {
                MessageBox.Show("O campo Cnh do motorista precisa ser preenchido!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_cnhmoto.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_fonemoto.Text))
            {
                MessageBox.Show("O campo Fone do motorista precisa ser preenchido!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_fonemoto.Focus();
                return;
            }

            else
            {
                InserirMotorista();
            }
        }

        private void InserirRota()
        {
            try
            {
                using (var connection = new SQLiteConnection(connectString))
                {
                    connection.Open();

                    string sqlinsert = "INSERT INTO ROTA (ORIGEM, DESTINO, DISTANCIA) VALUES (@origem , @destino, @distancia);";

                    using (var cmd = new SQLiteCommand(sqlinsert, connection))
                    {
                        cmd.Parameters.AddWithValue("@origem", txt_origemrota.Text);
                        cmd.Parameters.AddWithValue("@destino", txt_destinorota.Text);
                        cmd.Parameters.AddWithValue("@distancia", txt_distanciarota.Text);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Rota inserida com sucesso!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir {ex.Message}");
            }
        }

        private void btn_salvar_rota_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_origemrota.Text))
            {
                MessageBox.Show("O campo Origem precisa ser preenchido!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_origemrota.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_destinorota.Text))
            {
                MessageBox.Show("O campo Destino precisa ser preenchido!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_destinorota.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_distanciarota.Text))
            {
                MessageBox.Show("O campo Distancia precisa ser preenchido!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_distanciarota.Focus();
                return;
            }

            else
            {
                InserirRota();
            }
        }

        private void btn_consultar_veiculo_Click(object sender, EventArgs e)
        {

            form_veiculo formSelecao = new form_veiculo();

            if (formSelecao.ShowDialog() == DialogResult.OK)
            {

                DadosVeiculo veiculo = formSelecao.VeiculoSelecionado;

                txt_veiculoid.Text = veiculo.veiculoid;
                txt_modeloveiculo.Text = veiculo.modelo;
                txt_placaveiculo.Text = veiculo.placa;
                txt_consumoveiculo.Text = veiculo.consumo;
                txt_cargaveiculo.Text = veiculo.carga;
            }
        }

        private void btn_consultar_rota_Click(object sender, EventArgs e)
        {
            Rota formSelecao = new Rota();

            if (formSelecao.ShowDialog() == DialogResult.OK)
            {
                DadosRota rota = formSelecao.RotaSelecionado;

                txt_rotaid.Text = rota.rotaid;
                txt_origemrota.Text = rota.origemrota;
                txt_destinorota.Text = rota.destinorota;
                txt_distanciarota.Text = rota.distanciarota;
            }
        }

        private void btn_consultar_motorista_Click(object sender, EventArgs e)
        {
            Motorista formSelecao = new Motorista();

            if (formSelecao.ShowDialog() == DialogResult.OK)
            {
                DadosMotorista moto = formSelecao.MotoristaSelecionado;

                txt_motoid.Text = moto.motoristaid;
                txt_nomemotorista.Text = moto.nomemoto;
                txt_cnhmoto.Text = moto.cnhmoto;
                txt_fonemoto.Text = moto.fonemoto;
            }
        }

        private void tabcontrol_SelectedIndexChanged(object sender, EventArgs e)
        {
            limparcampos();
        }

        private void limparcampos()
        {
            txt_veiculoid.Clear();
            txt_modeloveiculo.Clear();
            txt_placaveiculo.Clear();
            txt_consumoveiculo.Clear();
            txt_cargaveiculo.Clear();

            txt_motoid.Clear();
            txt_nomemotorista.Clear();
            txt_cnhmoto.Clear();
            txt_fonemoto.Clear();

            txt_rotaid.Clear();
            txt_origemrota.Clear();
            txt_destinorota.Clear();
            txt_distanciarota.Clear();

            txt_combid.Clear();
            cb_precomb.SelectedIndex = -1;
            txt_precoprecomb.Clear();

            txt_viagemid.Clear();
            cb_veiculoviagem.SelectedIndex = -1;
            cb_rotaviagem.SelectedIndex = -1;
            cb_motoristaviagem.SelectedIndex = -1;
        }

        private void btn_consultar_combustivel_Click(object sender, EventArgs e)
        {
            Combust formSelecao = new Combust();

            if (formSelecao.ShowDialog() == DialogResult.OK)
            {
                PrecoCombustivel comb = formSelecao.CombSelecionado;

                txt_combid.Text = comb.precoid;
                cb_precomb.Text = comb.comb;
                txt_precoprecomb.Text = comb.precocomb;

                if (DateTime.TryParse(comb.dataconscomb, out DateTime dataDB))
                {
                    date_precomb.Value = dataDB;
                }
            }
        }

        private void btn_salvar_combustivel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cb_precomb.Text))
            {
                MessageBox.Show("O campo Combustivel não pode ser vazio!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cb_precomb.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(date_precomb.Text))
            {
                MessageBox.Show("O campo data precisa ser preenchido!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                date_precomb.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_precoprecomb.Text))
            {
                MessageBox.Show("O campo preço precisa ser preenchido!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_precoprecomb.Focus();
                return;
            }

            else
            {
                InserirComb();
            }
        }

        private void InserirComb()
        {
            try
            {
                using (var connection = new SQLiteConnection(connectString))
                {
                    connection.Open();

                    string sqlinsert = "INSERT INTO PRECO_COMBUSTIVEL (COMBUSTIVEL, PRECO, DATA_CONSULTA) VALUES (@comb, @preco, @date);";

                    using (var cmd = new SQLiteCommand(sqlinsert, connection))
                    {

                        DateTime dataParaInserir = date_precomb.Value;

                        cmd.Parameters.AddWithValue("@comb", cb_precomb.Text);
                        cmd.Parameters.AddWithValue("@preco", txt_precoprecomb.Text);
                        string dataFormatada = dataParaInserir.ToString("yyyy-MM-dd");
                        cmd.Parameters.AddWithValue("@date", dataFormatada);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Combustivel inserido com sucesso!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir {ex.Message}");
            }
        }
    }
}
