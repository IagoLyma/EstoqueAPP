using System.Data;
using System.Data.SQLite;
using static EstoqueAPP.form_veiculo;
using static EstoqueAPP.Rota;
using static EstoqueAPP.Motorista;
using static EstoqueAPP.Combust;
using System.Windows.Forms.VisualStyles;
using static EstoqueAPP.Viagem;

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

            ConsultaVeiculoViagem();
            ConsultaRotaViagem();
            ConsultaMotoristaViagem();

            CarregarSituacoesViagem();


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

                    limparcampos();


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

                    string sqlselect = "SELECT (MODELO || ' - ' || PLACA) AS DESCRICAO, VEICULOID FROM VEICULO ORDER BY MODELO";

                    using (var adapter = new SQLiteDataAdapter(sqlselect, connection))
                    {

                        DataTable tabelaVeiculos = new DataTable();

                        adapter.Fill(tabelaVeiculos);

                        cb_veiculoviagem.DataSource = tabelaVeiculos;

                        cb_veiculoviagem.DisplayMember = "DESCRICAO";

                        cb_veiculoviagem.ValueMember = "VEICULOID";

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

                    string sqlselect = "SELECT (ORIGEM || ' - Até - ' || DESTINO) AS DESCRICAO, ROTAID FROM ROTA ORDER BY ORIGEM";

                    using (var adapter = new SQLiteDataAdapter(sqlselect, connection))
                    {

                        DataTable tabelaRotas = new DataTable();

                        adapter.Fill(tabelaRotas);

                        cb_rotaviagem.DataSource = tabelaRotas;

                        cb_rotaviagem.DisplayMember = "DESCRICAO";

                        cb_rotaviagem.ValueMember = "ROTAID";

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

                    string sqlselect = "SELECT (NOME || ' - ' || TELEFONE) AS DESCRICAO, MOTORISTAID FROM MOTORISTA ORDER BY NOME";

                    using (var adapter = new SQLiteDataAdapter(sqlselect, connection))
                    {

                        DataTable tabelaMotorista = new DataTable();

                        adapter.Fill(tabelaMotorista);

                        cb_motoristaviagem.DataSource = tabelaMotorista;

                        cb_motoristaviagem.DisplayMember = "DESCRICAO";

                        cb_motoristaviagem.ValueMember = "MOTORISTAID";

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

                limparcampos();
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

                limparcampos();
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
            cb_situacao_viagem.SelectedIndex = -1;
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

                limparcampos();
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

        private int VeiculoSelected = -1;

        private void btn_editar_veiculo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_modeloveiculo.Text))
            {
                MessageBox.Show("O campo Modelo precisa ser preenchido para editar!", "Atenção!");
                txt_modeloveiculo.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_placaveiculo.Text))
            {
                MessageBox.Show("O campo Placa precisa ser preenchido para editar!", "Atenção!");
                txt_placaveiculo.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_consumoveiculo.Text))
            {
                MessageBox.Show("O campo Consumo precisa ser preenchido para editar!", "Atenção!");
                txt_consumoveiculo.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_cargaveiculo.Text))
            {
                MessageBox.Show("O campo Carga precisa ser preenchido para editar!", "Atenção!");
                txt_cargaveiculo.Focus();
                return;
            }

            AtualizarVeiculo();

            limparcampos();
        }

        private void AtualizarVeiculo()
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txt_veiculoid.Text))
                {
                    MessageBox.Show("Selecione um veiculo para editar!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var connection = new SQLiteConnection(connectString))
                {
                    connection.Open();


                    string sqlupdate = "UPDATE VEICULO SET MODELO = @modelov, PLACA = @placav, CONSUMO_MEDIO = @cons, CARGA_MAXIMA = @carga WHERE VEICULOID = @id;";

                    using (var cmd = new SQLiteCommand(sqlupdate, connection))
                    {

                        cmd.Parameters.AddWithValue("@modelov", txt_modeloveiculo.Text);
                        cmd.Parameters.AddWithValue("@placav", txt_placaveiculo.Text);
                        cmd.Parameters.AddWithValue("@cons", txt_consumoveiculo.Text);
                        cmd.Parameters.AddWithValue("@carga", txt_cargaveiculo.Text);
                        cmd.Parameters.AddWithValue("@id", txt_veiculoid.Text);

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Veículo atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("Veículo não encontrado ou nenhum dado alterado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_excluir_veiculo_Click(object sender, EventArgs e)
        {
            DeletarVeiculo();

            limparcampos();
        }

        private void DeletarVeiculo()
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txt_veiculoid.Text))
                {
                    MessageBox.Show("Selecione um veiculo para Deletar!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show(
                         $"Deseja realmente excluir o Veiculo?", "Confirmação",
                            MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question
                         );

                if (result == DialogResult.No)
                    return;


                using (var connection = new SQLiteConnection(connectString))
                {
                    connection.Open();


                    string sqlupdate = "DELETE FROM VEICULO WHERE VEICULOID = @id";

                    using (var cmd = new SQLiteCommand(sqlupdate, connection))
                    {

                        cmd.Parameters.AddWithValue("@id", txt_veiculoid.Text);

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Veículo deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("Veículo não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao deletar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_editar_motorista_Click(object sender, EventArgs e)
        {
            AtualizarMotorista();

            limparcampos();
        }

        private void AtualizarMotorista()
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txt_motoid.Text))
                {
                    MessageBox.Show("Selecione um motorista para editar!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var connection = new SQLiteConnection(connectString))
                {
                    connection.Open();


                    string sqlupdate = "UPDATE MOTORISTA SET NOME = @nome, CNH = @cnh, TELEFONE = @fone WHERE MOTORISTAID = @id;";

                    using (var cmd = new SQLiteCommand(sqlupdate, connection))
                    {

                        cmd.Parameters.AddWithValue("@nome", txt_nomemotorista.Text);
                        cmd.Parameters.AddWithValue("@cnh", txt_cnhmoto.Text);
                        cmd.Parameters.AddWithValue("@fone", txt_fonemoto.Text);
                        cmd.Parameters.AddWithValue("@id", txt_motoid.Text);

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Motorista atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("Motorista não encontrado ou nenhum dado alterado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_excluir_motorista_Click(object sender, EventArgs e)
        {
            DeletarMotorista();
            limparcampos();
        }

        private void DeletarMotorista()
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txt_motoid.Text))
                {
                    MessageBox.Show("Selecione um motorista para Deletar!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show(
                         $"Deseja realmente excluir o(a) Motorista?", "Confirmação",
                            MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question
                         );

                if (result == DialogResult.No)
                    return;


                using (var connection = new SQLiteConnection(connectString))
                {
                    connection.Open();


                    string sqlupdate = "DELETE FROM MOTORISTA WHERE MOTORISTAID = @id";

                    using (var cmd = new SQLiteCommand(sqlupdate, connection))
                    {

                        cmd.Parameters.AddWithValue("@id", txt_motoid.Text);

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Motorista deletado(a) com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("Motorista não encontrado(a).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao deletar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AtualizarRota()
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txt_rotaid.Text))
                {
                    MessageBox.Show("Selecione uma Rota para editar!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var connection = new SQLiteConnection(connectString))
                {
                    connection.Open();


                    string sqlupdate = "UPDATE ROTA SET ORIGEM = @origem, DESTINO = @destino, DISTANCIA = @distancia WHERE ROTAID = @id;";

                    using (var cmd = new SQLiteCommand(sqlupdate, connection))
                    {

                        cmd.Parameters.AddWithValue("@origem", txt_origemrota.Text);
                        cmd.Parameters.AddWithValue("@destino", txt_destinorota.Text);
                        cmd.Parameters.AddWithValue("@distancia", txt_distanciarota.Text);
                        cmd.Parameters.AddWithValue("@id", txt_rotaid.Text);

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Rota atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("Rota não encontrado ou nenhum dado alterado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeletarRota()
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txt_rotaid.Text))
                {
                    MessageBox.Show("Selecione uma Rota para Deletar!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show(
                         $"Deseja realmente excluir a Rota?", "Confirmação",
                            MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question
                         );

                if (result == DialogResult.No)
                    return;


                using (var connection = new SQLiteConnection(connectString))
                {
                    connection.Open();


                    string sqldelete = "DELETE FROM ROTA WHERE ROTAID = @id";

                    using (var cmd = new SQLiteCommand(sqldelete, connection))
                    {

                        cmd.Parameters.AddWithValue("@id", txt_rotaid.Text);

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Rota deletada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("Rota não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao deletar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_editar_rota_Click(object sender, EventArgs e)
        {
            AtualizarRota();

            limparcampos();
        }

        private void btn_excluir_rota_Click(object sender, EventArgs e)
        {
            DeletarRota();

            limparcampos();
        }

        private void AtualizarComb()
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txt_combid.Text))
                {
                    MessageBox.Show("Selecione um Combustível para editar!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var connection = new SQLiteConnection(connectString))
                {
                    connection.Open();


                    string sqlupdate = "UPDATE PRECO_COMBUSTIVEL SET COMBUSTIVEL = @comb, DATA_CONSULTA = @date, PRECO = @preco WHERE PRECOID = @id;";

                    using (var cmd = new SQLiteCommand(sqlupdate, connection))
                    {

                        DateTime dataParaInserir = date_precomb.Value;


                        cmd.Parameters.AddWithValue("@comb", cb_precomb.Text);
                        string dataFormatada = dataParaInserir.ToString("yyyy-MM-dd");
                        cmd.Parameters.AddWithValue("@date", dataFormatada);
                        cmd.Parameters.AddWithValue("@preco", txt_precoprecomb.Text);
                        cmd.Parameters.AddWithValue("@id", txt_combid.Text);

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Combustível atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("Combustível não encontrado ou nenhum dado alterado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeletarComb()
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txt_combid.Text))
                {
                    MessageBox.Show("Selecione um Combustível para Deletar!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show(
                         $"Deseja realmente excluir o Combustível?", "Confirmação",
                            MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question
                         );

                if (result == DialogResult.No)
                    return;


                using (var connection = new SQLiteConnection(connectString))
                {
                    connection.Open();


                    string sqldelete = "DELETE FROM PRECO_COMBUSTIVEL WHERE PRECOID = @id";

                    using (var cmd = new SQLiteCommand(sqldelete, connection))
                    {

                        cmd.Parameters.AddWithValue("@id", txt_combid.Text);

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Combustível deletada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("Combustível não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao deletar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_editar_combustivel_Click(object sender, EventArgs e)
        {
            AtualizarComb();

            limparcampos();
        }

        private void btn_excluir_combustivel_Click(object sender, EventArgs e)
        {
            DeletarComb();

            limparcampos();
        }

        private void InserirViagem()
        {
            try
            {
                using (var connection = new SQLiteConnection(connectString))
                {
                    connection.Open();

                    string sqlinsert = "INSERT INTO VIAGEM (VEICULOID, MOTORISTAID, ROTAID, DATA_SAIDA, DATA_CHEGADA, SITUACAO) VALUES (@veiculoId, @motoristaId, @rotaId, @saida, @chegada, @situacao);";

                    using (var cmd = new SQLiteCommand(sqlinsert, connection))
                    {

                        string dataSaida = date_saidaviagem.Value.ToString("yyyy-MM-dd");
                        string dataChegada = date_viagemchegada.Value.ToString("yyyy-MM-dd");

                        cmd.Parameters.AddWithValue("@veiculoId", cb_veiculoviagem.SelectedValue);
                        cmd.Parameters.AddWithValue("@motoristaId", cb_motoristaviagem.SelectedValue);
                        cmd.Parameters.AddWithValue("@rotaId", cb_rotaviagem.SelectedValue);

                        
                        cmd.Parameters.AddWithValue("@saida", dataSaida);
                        cmd.Parameters.AddWithValue("@chegada", dataChegada);
                        cmd.Parameters.AddWithValue("@situacao", cb_situacao_viagem.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Viagem inserida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limparcampos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir Viagem: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_salvar_viagem_Click(object sender, EventArgs e)
        {
            if (cb_veiculoviagem.SelectedIndex == -1 || cb_rotaviagem.SelectedIndex == -1 || cb_motoristaviagem.SelectedIndex == -1)
            {
                MessageBox.Show("Todos os campos de seleção (Veículo, Rota, Motorista) são obrigatórios!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (date_viagemchegada.Value < date_saidaviagem.Value)
            {
                MessageBox.Show("A data de chegada não pode ser antes que a de saida");
                return;
            }

            InserirViagem();
        }

        private void btn_consultar_viagem_Click(object sender, EventArgs e)
        {
            Viagem formSelecao = new Viagem();

            if (formSelecao.ShowDialog() == DialogResult.OK)
            {
                DadosViagem viagem = formSelecao.ViagemSelecionada;

                txt_viagemid.Text = viagem.viagemid;

                if (DateTime.TryParse(viagem.dataSaida, out DateTime dataSaidaDB))
                    date_saidaviagem.Value = dataSaidaDB;

                if (DateTime.TryParse(viagem.dataChegada, out DateTime dataChegadaDB))
                    date_viagemchegada.Value = dataChegadaDB;

                try
                {

                    int veiculoId = Convert.ToInt32(viagem.veiculoPlaca);
                    cb_veiculoviagem.SelectedValue = veiculoId;
                }
                catch (FormatException) { }

                try
                {
                    int rotaId = Convert.ToInt32(viagem.rotaOrigem);
                    cb_rotaviagem.SelectedValue = rotaId;
                }
                catch (FormatException) { }

                try
                {
                    int motoristaId = Convert.ToInt32(viagem.motoristaNome);
                    cb_motoristaviagem.SelectedValue = motoristaId;
                }
                catch (FormatException) { }


                cb_situacao_viagem.Text = viagem.situacao;

            }
        }

        private void AtualizarViagem()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_viagemid.Text))
                {
                    MessageBox.Show("Selecione uma Viagem para editar!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var connection = new SQLiteConnection(connectString))
                {
                    connection.Open();

                    string sqlupdate = "UPDATE VIAGEM SET VEICULOID = @veiculoId, MOTORISTAID = @motoristaId, ROTAID = @rotaId, DATA_SAIDA = @saida, DATA_CHEGADA = @chegada, SITUACAO = @situacao WHERE VIAGEMID = @id;";

                    using (var cmd = new SQLiteCommand(sqlupdate, connection))
                    {
                        string dataSaida = date_saidaviagem.Value.ToString("yyyy-MM-dd");
                        string dataChegada = date_viagemchegada.Value.ToString("yyyy-MM-dd");

                        cmd.Parameters.AddWithValue("@veiculoId", cb_veiculoviagem.SelectedValue);
                        cmd.Parameters.AddWithValue("@motoristaId", cb_motoristaviagem.SelectedValue);
                        cmd.Parameters.AddWithValue("@rotaId", cb_rotaviagem.SelectedValue);

                        cmd.Parameters.AddWithValue("@saida", dataSaida);
                        cmd.Parameters.AddWithValue("@chegada", dataChegada);
                        cmd.Parameters.AddWithValue("@situacao", cb_situacao_viagem.Text);

                        cmd.Parameters.AddWithValue("@id", txt_viagemid.Text);

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Viagem atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Viagem não encontrada ou nenhum dado alterado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        limparcampos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar Viagem: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeletarViagem()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_viagemid.Text))
                {
                    MessageBox.Show("Selecione uma Viagem para Deletar!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    $"Deseja realmente excluir a Viagem ID {txt_viagemid.Text}?", "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.No)
                    return;

                using (var connection = new SQLiteConnection(connectString))
                {
                    connection.Open();

                    string sqldelete = "DELETE FROM VIAGEM WHERE VIAGEMID = @id";

                    using (var cmd = new SQLiteCommand(sqldelete, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", txt_viagemid.Text);

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Viagem deletada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Viagem não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        limparcampos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao deletar Viagem: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_editar_viagem_Click(object sender, EventArgs e)
        {
            if (cb_veiculoviagem.SelectedIndex == -1 || cb_rotaviagem.SelectedIndex == -1 || cb_motoristaviagem.SelectedIndex == -1)
            {
                MessageBox.Show("Todos os campos de seleção (Veículo, Rota, Motorista) são obrigatórios para editar!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AtualizarViagem();

            limparcampos();
        }

        private void btn_excluir_viagem_Click(object sender, EventArgs e)
        {
            DeletarViagem();

            limparcampos();
        }
        private void CarregarSituacoesViagem()
        {
            string[] situacoes = { "PENDENTE", "EM ANDAMENTO", "CONCLUÍDA", "CANCELADA" };

            cb_situacao_viagem.Items.Clear();
            cb_situacao_viagem.Items.AddRange(situacoes);

            if (cb_situacao_viagem.Items.Count > 0)
            {
                cb_situacao_viagem.SelectedIndex = 0;
            }
        }
    }
}
