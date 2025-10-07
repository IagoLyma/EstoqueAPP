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
    public partial class Viagem : Form
    {
        string dbPath = @"C:\Users\iago.lfarias\Desktop\EstoqueAPP\logistica.db";

        string connectString;

        public class DadosViagem
        {
            public string viagemid { get; set; }
            public string dataSaida { get; set; }
            public string dataChegada { get; set; }
            public string veiculoPlaca { get; set; }
            public string rotaOrigem { get; set; }
            public string motoristaNome { get; set; }
            public string situacao { get; set; }
        }

        public DadosViagem ViagemSelecionada { get; private set; }

        public Viagem()
        {
            InitializeComponent();
            connectString = $"Data Source = {dbPath};Version=3;";

        }

        private void Viagem_Load(object sender, EventArgs e)
        {
            CarregarViagens();
        }

        private void CarregarViagens()
        {
            try
            {
                using (var connection = new SQLiteConnection(connectString))
                {
                    connection.Open();

                    string sqlselect = @"
                SELECT 
                    V.VIAGEMID,
                    (VE.MODELO || ' - ' || VE.PLACA) AS VEICULO, 
                    M.NOME AS MOTORISTA,
                    (R.ORIGEM || ' - ' || R.DESTINO) AS ROTA,
                    V.DATA_SAIDA, 
                    V.DATA_CHEGADA, 
                    V.SITUACAO,
                    -- Campos ocultos para resgatar o ID e usar na Edição
                    V.VEICULOID, 
                    V.MOTORISTAID, 
                    V.ROTAID 
                FROM VIAGEM AS V
                JOIN VEICULO AS VE ON V.VEICULOID = VE.VEICULOID
                JOIN MOTORISTA AS M ON V.MOTORISTAID = M.MOTORISTAID
                JOIN ROTA AS R ON V.ROTAID = R.ROTAID
                ORDER BY V.DATA_SAIDA DESC";

                    using (var adapter = new SQLiteDataAdapter(sqlselect, connection))
                    {
                        DataTable tabelaViagens = new DataTable();
                        adapter.Fill(tabelaViagens);

                        grid_viagem.DataSource = tabelaViagens;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar Viagens: {ex.Message}");
            }
        }

        private void grid_viagem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = grid_viagem.Rows[e.RowIndex];


                ViagemSelecionada = new DadosViagem
                {
                    viagemid = row.Cells["VIAGEMID"].Value.ToString(),
                    dataSaida = row.Cells["DATA_SAIDA"].Value.ToString(),
                    dataChegada = row.Cells["DATA_CHEGADA"].Value.ToString(),
                    veiculoPlaca = row.Cells["VEICULOID"].Value.ToString(),
                    rotaOrigem = row.Cells["ROTAID"].Value.ToString(),
                    motoristaNome = row.Cells["MOTORISTAID"].Value.ToString(),
                    situacao = row.Cells["SITUACAO"].Value.ToString()

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

                    string sqlpesquisa = @"
                SELECT 
                    V.VIAGEMID,
                    (VE.MODELO || ' - ' || VE.PLACA) AS VEICULO, 
                    M.NOME AS MOTORISTA,
                    (R.ORIGEM || ' - ' || R.DESTINO) AS ROTA,
                    V.DATA_SAIDA, 
                    V.DATA_CHEGADA, 
                    V.SITUACAO,
                    V.VEICULOID, 
                    V.MOTORISTAID, 
                    V.ROTAID 
                FROM VIAGEM AS V
                JOIN VEICULO AS VE ON V.VEICULOID = VE.VEICULOID
                JOIN MOTORISTA AS M ON V.MOTORISTAID = M.MOTORISTAID
                JOIN ROTA AS R ON V.ROTAID = R.ROTAID
                WHERE 
                    V.VIAGEMID LIKE @TermoCompleto 
                    OR (VE.MODELO || ' - ' || VE.PLACA) LIKE @TermoCompleto 
                    OR M.NOME LIKE @TermoCompleto
                    OR (R.ORIGEM || ' - ' || R.DESTINO) LIKE @TermoCompleto
                    OR V.SITUACAO LIKE @TermoCompleto
                ORDER BY V.DATA_SAIDA DESC";

                    using (var cmd = new SQLiteCommand(sqlpesquisa, connection))
                    {
                        string termo = $"%{txt_pesquisa.Text.Trim()}%";
                        cmd.Parameters.AddWithValue("@TermoCompleto", termo);

                        using (var adapter = new SQLiteDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            grid_viagem.DataSource = dt;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao pesquisar: {ex.Message}");
            }
        }

        private void ResetarProcura()
        {
            try
            {
                using (var connection = new SQLiteConnection(connectString))
                {
                    connection.Open();

                    string select = @"
                SELECT 
                    V.VIAGEMID,
                    (VE.MODELO || ' - ' || VE.PLACA) AS VEICULO, 
                    M.NOME AS MOTORISTA,
                    (R.ORIGEM || ' - ' || R.DESTINO) AS ROTA,
                    V.DATA_SAIDA, 
                    V.DATA_CHEGADA, 
                    V.SITUACAO,
                    -- Campos ocultos para resgatar o ID e usar na Edição
                    V.VEICULOID, 
                    V.MOTORISTAID, 
                    V.ROTAID 
                FROM VIAGEM AS V
                JOIN VEICULO AS VE ON V.VEICULOID = VE.VEICULOID
                JOIN MOTORISTA AS M ON V.MOTORISTAID = M.MOTORISTAID
                JOIN ROTA AS R ON V.ROTAID = R.ROTAID
                ORDER BY V.DATA_SAIDA DESC";

                    using (var cmd = new SQLiteCommand(select, connection))
                    {
                        cmd.ExecuteNonQuery();

                        using (var adpter = new SQLiteDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adpter.Fill(dt);
                            grid_viagem.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao pesquisar no banco: ${ex.Message}");
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            ResetarProcura();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
