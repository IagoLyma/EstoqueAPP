namespace EstoqueAPP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tab_veiculo = new TabPage();
            tool_veiculo = new ToolStrip();
            btn_salvar_veiculo = new ToolStripButton();
            btn_editar_veiculo = new ToolStripButton();
            btn_consultar_veiculo = new ToolStripButton();
            btn_excluir_veiculo = new ToolStripButton();
            txt_cargaveiculo = new TextBox();
            txt_consumoveiculo = new TextBox();
            txt_placaveiculo = new TextBox();
            txt_modeloveiculo = new TextBox();
            txt_veiculoid = new TextBox();
            label5 = new Label();
            lbl_consumo = new Label();
            lbl_placa = new Label();
            lbl_modeloveiculo = new Label();
            lbl_veiculoid = new Label();
            tab_motorista = new TabPage();
            tool_motorista = new ToolStrip();
            btn_salvar_motorista = new ToolStripButton();
            btn_editar_motorista = new ToolStripButton();
            btn_consultar_motorista = new ToolStripButton();
            btn_excluir_motorista = new ToolStripButton();
            txt_fonemoto = new TextBox();
            txt_cnhmoto = new TextBox();
            txt_nomemotorista = new TextBox();
            txt_motoid = new TextBox();
            lbl_fonemotorista = new Label();
            lbl_cnhmotorista = new Label();
            lbl_nomemotorista = new Label();
            lbl_motoristaid = new Label();
            tab_rota = new TabPage();
            tool_rota = new ToolStrip();
            btn_salvar_rota = new ToolStripButton();
            btn_editar_rota = new ToolStripButton();
            btn_consultar_rota = new ToolStripButton();
            btn_excluir_rota = new ToolStripButton();
            txt_distanciarota = new TextBox();
            txt_destinorota = new TextBox();
            txt_origemrota = new TextBox();
            txt_rotaid = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tab_combustivel = new TabPage();
            tool_combustivel = new ToolStrip();
            btn_salvar_combustivel = new ToolStripButton();
            btn_editar_combustivel = new ToolStripButton();
            btn_consultar_combustivel = new ToolStripButton();
            btn_excluir_combustivel = new ToolStripButton();
            comboBox4 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            textBox10 = new TextBox();
            textBox13 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            tab_viagem = new TabPage();
            tool_viagem = new ToolStrip();
            btn_salvar_viagem = new ToolStripButton();
            btn_editar_viagem = new ToolStripButton();
            btn_consultar_viagem = new ToolStripButton();
            btn_excluir_viagem = new ToolStripButton();
            dateTimePicker3 = new DateTimePicker();
            cb_motoristaviagem = new ComboBox();
            cb_rotaviagem = new ComboBox();
            cb_veiculoviagem = new ComboBox();
            label15 = new Label();
            label14 = new Label();
            dateTimePicker2 = new DateTimePicker();
            textBox15 = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            tabControl1.SuspendLayout();
            tab_veiculo.SuspendLayout();
            tool_veiculo.SuspendLayout();
            tab_motorista.SuspendLayout();
            tool_motorista.SuspendLayout();
            tab_rota.SuspendLayout();
            tool_rota.SuspendLayout();
            tab_combustivel.SuspendLayout();
            tool_combustivel.SuspendLayout();
            tab_viagem.SuspendLayout();
            tool_viagem.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tab_veiculo);
            tabControl1.Controls.Add(tab_motorista);
            tabControl1.Controls.Add(tab_rota);
            tabControl1.Controls.Add(tab_combustivel);
            tabControl1.Controls.Add(tab_viagem);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(923, 566);
            tabControl1.TabIndex = 1;
            // 
            // tab_veiculo
            // 
            tab_veiculo.Controls.Add(tool_veiculo);
            tab_veiculo.Controls.Add(txt_cargaveiculo);
            tab_veiculo.Controls.Add(txt_consumoveiculo);
            tab_veiculo.Controls.Add(txt_placaveiculo);
            tab_veiculo.Controls.Add(txt_modeloveiculo);
            tab_veiculo.Controls.Add(txt_veiculoid);
            tab_veiculo.Controls.Add(label5);
            tab_veiculo.Controls.Add(lbl_consumo);
            tab_veiculo.Controls.Add(lbl_placa);
            tab_veiculo.Controls.Add(lbl_modeloveiculo);
            tab_veiculo.Controls.Add(lbl_veiculoid);
            tab_veiculo.Location = new Point(4, 24);
            tab_veiculo.Name = "tab_veiculo";
            tab_veiculo.Padding = new Padding(3);
            tab_veiculo.Size = new Size(915, 538);
            tab_veiculo.TabIndex = 0;
            tab_veiculo.Text = "Veiculo";
            tab_veiculo.UseVisualStyleBackColor = true;
            // 
            // tool_veiculo
            // 
            tool_veiculo.AutoSize = false;
            tool_veiculo.ImageScalingSize = new Size(50, 50);
            tool_veiculo.Items.AddRange(new ToolStripItem[] { btn_salvar_veiculo, btn_editar_veiculo, btn_consultar_veiculo, btn_excluir_veiculo });
            tool_veiculo.Location = new Point(3, 3);
            tool_veiculo.Name = "tool_veiculo";
            tool_veiculo.Size = new Size(909, 100);
            tool_veiculo.TabIndex = 10;
            tool_veiculo.Text = "toolStrip1";
            // 
            // btn_salvar_veiculo
            // 
            btn_salvar_veiculo.AutoSize = false;
            btn_salvar_veiculo.BackgroundImageLayout = ImageLayout.Stretch;
            btn_salvar_veiculo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_salvar_veiculo.Font = new Font("Segoe UI", 50F);
            btn_salvar_veiculo.Image = (Image)resources.GetObject("btn_salvar_veiculo.Image");
            btn_salvar_veiculo.ImageTransparentColor = Color.Magenta;
            btn_salvar_veiculo.Name = "btn_salvar_veiculo";
            btn_salvar_veiculo.Size = new Size(80, 80);
            btn_salvar_veiculo.Text = "toolStripButton1";
            btn_salvar_veiculo.Click += btn_salvar_veiculo_Click;
            // 
            // btn_editar_veiculo
            // 
            btn_editar_veiculo.AutoSize = false;
            btn_editar_veiculo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_editar_veiculo.Image = (Image)resources.GetObject("btn_editar_veiculo.Image");
            btn_editar_veiculo.ImageTransparentColor = Color.Magenta;
            btn_editar_veiculo.Name = "btn_editar_veiculo";
            btn_editar_veiculo.Size = new Size(80, 80);
            btn_editar_veiculo.Text = "toolStripButton2";
            // 
            // btn_consultar_veiculo
            // 
            btn_consultar_veiculo.AutoSize = false;
            btn_consultar_veiculo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_consultar_veiculo.Image = (Image)resources.GetObject("btn_consultar_veiculo.Image");
            btn_consultar_veiculo.ImageTransparentColor = Color.Magenta;
            btn_consultar_veiculo.Name = "btn_consultar_veiculo";
            btn_consultar_veiculo.Size = new Size(80, 80);
            btn_consultar_veiculo.Text = "Consultar veiculos";
            btn_consultar_veiculo.Click += btn_consultar_veiculo_Click;
            // 
            // btn_excluir_veiculo
            // 
            btn_excluir_veiculo.AutoSize = false;
            btn_excluir_veiculo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_excluir_veiculo.Image = (Image)resources.GetObject("btn_excluir_veiculo.Image");
            btn_excluir_veiculo.ImageTransparentColor = Color.Magenta;
            btn_excluir_veiculo.Name = "btn_excluir_veiculo";
            btn_excluir_veiculo.Size = new Size(80, 80);
            btn_excluir_veiculo.Text = "toolStripButton4";
            // 
            // txt_cargaveiculo
            // 
            txt_cargaveiculo.Font = new Font("Segoe UI", 12F);
            txt_cargaveiculo.Location = new Point(301, 316);
            txt_cargaveiculo.Name = "txt_cargaveiculo";
            txt_cargaveiculo.Size = new Size(148, 29);
            txt_cargaveiculo.TabIndex = 9;
            // 
            // txt_consumoveiculo
            // 
            txt_consumoveiculo.Font = new Font("Segoe UI", 12F);
            txt_consumoveiculo.Location = new Point(301, 275);
            txt_consumoveiculo.Name = "txt_consumoveiculo";
            txt_consumoveiculo.Size = new Size(110, 29);
            txt_consumoveiculo.TabIndex = 8;
            // 
            // txt_placaveiculo
            // 
            txt_placaveiculo.Font = new Font("Segoe UI", 12F);
            txt_placaveiculo.Location = new Point(301, 237);
            txt_placaveiculo.Name = "txt_placaveiculo";
            txt_placaveiculo.Size = new Size(173, 29);
            txt_placaveiculo.TabIndex = 7;
            // 
            // txt_modeloveiculo
            // 
            txt_modeloveiculo.Font = new Font("Segoe UI", 12F);
            txt_modeloveiculo.Location = new Point(301, 193);
            txt_modeloveiculo.Name = "txt_modeloveiculo";
            txt_modeloveiculo.Size = new Size(211, 29);
            txt_modeloveiculo.TabIndex = 6;
            // 
            // txt_veiculoid
            // 
            txt_veiculoid.Font = new Font("Segoe UI", 12F);
            txt_veiculoid.Location = new Point(302, 154);
            txt_veiculoid.Name = "txt_veiculoid";
            txt_veiculoid.ReadOnly = true;
            txt_veiculoid.Size = new Size(140, 29);
            txt_veiculoid.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F);
            label5.Location = new Point(121, 318);
            label5.Name = "label5";
            label5.Size = new Size(176, 25);
            label5.TabIndex = 4;
            label5.Text = "Carga máxima (Kg):";
            // 
            // lbl_consumo
            // 
            lbl_consumo.AutoSize = true;
            lbl_consumo.Font = new Font("Segoe UI", 14.25F);
            lbl_consumo.Location = new Point(88, 277);
            lbl_consumo.Name = "lbl_consumo";
            lbl_consumo.Size = new Size(214, 25);
            lbl_consumo.TabIndex = 3;
            lbl_consumo.Text = "Consumo medio (Km/L):";
            // 
            // lbl_placa
            // 
            lbl_placa.AutoSize = true;
            lbl_placa.Font = new Font("Segoe UI", 14.25F);
            lbl_placa.Location = new Point(143, 238);
            lbl_placa.Name = "lbl_placa";
            lbl_placa.Size = new Size(153, 25);
            lbl_placa.TabIndex = 2;
            lbl_placa.Text = "Placa do veiculo:";
            // 
            // lbl_modeloveiculo
            // 
            lbl_modeloveiculo.AutoSize = true;
            lbl_modeloveiculo.Font = new Font("Segoe UI", 14.25F);
            lbl_modeloveiculo.Location = new Point(126, 193);
            lbl_modeloveiculo.Name = "lbl_modeloveiculo";
            lbl_modeloveiculo.Size = new Size(173, 25);
            lbl_modeloveiculo.TabIndex = 1;
            lbl_modeloveiculo.Text = "Modelo do veiculo:";
            // 
            // lbl_veiculoid
            // 
            lbl_veiculoid.AutoSize = true;
            lbl_veiculoid.Font = new Font("Segoe UI", 14.25F);
            lbl_veiculoid.Location = new Point(195, 154);
            lbl_veiculoid.Name = "lbl_veiculoid";
            lbl_veiculoid.Size = new Size(101, 25);
            lbl_veiculoid.TabIndex = 0;
            lbl_veiculoid.Text = "Veiculo ID:";
            // 
            // tab_motorista
            // 
            tab_motorista.Controls.Add(tool_motorista);
            tab_motorista.Controls.Add(txt_fonemoto);
            tab_motorista.Controls.Add(txt_cnhmoto);
            tab_motorista.Controls.Add(txt_nomemotorista);
            tab_motorista.Controls.Add(txt_motoid);
            tab_motorista.Controls.Add(lbl_fonemotorista);
            tab_motorista.Controls.Add(lbl_cnhmotorista);
            tab_motorista.Controls.Add(lbl_nomemotorista);
            tab_motorista.Controls.Add(lbl_motoristaid);
            tab_motorista.Location = new Point(4, 24);
            tab_motorista.Name = "tab_motorista";
            tab_motorista.Padding = new Padding(3);
            tab_motorista.Size = new Size(915, 538);
            tab_motorista.TabIndex = 1;
            tab_motorista.Text = "Motorista";
            tab_motorista.UseVisualStyleBackColor = true;
            // 
            // tool_motorista
            // 
            tool_motorista.AutoSize = false;
            tool_motorista.ImageScalingSize = new Size(50, 50);
            tool_motorista.Items.AddRange(new ToolStripItem[] { btn_salvar_motorista, btn_editar_motorista, btn_consultar_motorista, btn_excluir_motorista });
            tool_motorista.Location = new Point(3, 3);
            tool_motorista.Name = "tool_motorista";
            tool_motorista.Size = new Size(909, 100);
            tool_motorista.TabIndex = 19;
            tool_motorista.Text = "toolStrip1";
            // 
            // btn_salvar_motorista
            // 
            btn_salvar_motorista.AutoSize = false;
            btn_salvar_motorista.BackgroundImageLayout = ImageLayout.Stretch;
            btn_salvar_motorista.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_salvar_motorista.Font = new Font("Segoe UI", 50F);
            btn_salvar_motorista.Image = (Image)resources.GetObject("btn_salvar_motorista.Image");
            btn_salvar_motorista.ImageTransparentColor = Color.Magenta;
            btn_salvar_motorista.Name = "btn_salvar_motorista";
            btn_salvar_motorista.Size = new Size(80, 80);
            btn_salvar_motorista.Text = "Inserir / Salvar";
            btn_salvar_motorista.Click += btn_salvar_motorista_Click;
            // 
            // btn_editar_motorista
            // 
            btn_editar_motorista.AutoSize = false;
            btn_editar_motorista.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_editar_motorista.Image = (Image)resources.GetObject("btn_editar_motorista.Image");
            btn_editar_motorista.ImageTransparentColor = Color.Magenta;
            btn_editar_motorista.Name = "btn_editar_motorista";
            btn_editar_motorista.Size = new Size(80, 80);
            btn_editar_motorista.Text = "toolStripButton2";
            // 
            // btn_consultar_motorista
            // 
            btn_consultar_motorista.AutoSize = false;
            btn_consultar_motorista.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_consultar_motorista.Image = (Image)resources.GetObject("btn_consultar_motorista.Image");
            btn_consultar_motorista.ImageTransparentColor = Color.Magenta;
            btn_consultar_motorista.Name = "btn_consultar_motorista";
            btn_consultar_motorista.Size = new Size(80, 80);
            btn_consultar_motorista.Text = "Consultar motoristas";
            btn_consultar_motorista.ToolTipText = "Consultar motorista";
            btn_consultar_motorista.Click += btn_consultar_motorista_Click;
            // 
            // btn_excluir_motorista
            // 
            btn_excluir_motorista.AutoSize = false;
            btn_excluir_motorista.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_excluir_motorista.Image = (Image)resources.GetObject("btn_excluir_motorista.Image");
            btn_excluir_motorista.ImageTransparentColor = Color.Magenta;
            btn_excluir_motorista.Name = "btn_excluir_motorista";
            btn_excluir_motorista.Size = new Size(80, 80);
            btn_excluir_motorista.Text = "toolStripButton4";
            // 
            // txt_fonemoto
            // 
            txt_fonemoto.Font = new Font("Segoe UI", 12F);
            txt_fonemoto.Location = new Point(302, 272);
            txt_fonemoto.Name = "txt_fonemoto";
            txt_fonemoto.Size = new Size(198, 29);
            txt_fonemoto.TabIndex = 18;
            // 
            // txt_cnhmoto
            // 
            txt_cnhmoto.Font = new Font("Segoe UI", 12F);
            txt_cnhmoto.Location = new Point(302, 232);
            txt_cnhmoto.Name = "txt_cnhmoto";
            txt_cnhmoto.Size = new Size(198, 29);
            txt_cnhmoto.TabIndex = 17;
            // 
            // txt_nomemotorista
            // 
            txt_nomemotorista.Font = new Font("Segoe UI", 12F);
            txt_nomemotorista.Location = new Point(302, 185);
            txt_nomemotorista.Name = "txt_nomemotorista";
            txt_nomemotorista.Size = new Size(280, 29);
            txt_nomemotorista.TabIndex = 16;
            // 
            // txt_motoid
            // 
            txt_motoid.Font = new Font("Segoe UI", 12F);
            txt_motoid.Location = new Point(303, 146);
            txt_motoid.Name = "txt_motoid";
            txt_motoid.ReadOnly = true;
            txt_motoid.Size = new Size(197, 29);
            txt_motoid.TabIndex = 15;
            // 
            // lbl_fonemotorista
            // 
            lbl_fonemotorista.AutoSize = true;
            lbl_fonemotorista.Font = new Font("Segoe UI", 14.25F);
            lbl_fonemotorista.Location = new Point(127, 272);
            lbl_fonemotorista.Name = "lbl_fonemotorista";
            lbl_fonemotorista.Size = new Size(169, 25);
            lbl_fonemotorista.TabIndex = 13;
            lbl_fonemotorista.Text = "Fone do motorista:";
            // 
            // lbl_cnhmotorista
            // 
            lbl_cnhmotorista.AutoSize = true;
            lbl_cnhmotorista.Font = new Font("Segoe UI", 14.25F);
            lbl_cnhmotorista.Location = new Point(134, 232);
            lbl_cnhmotorista.Name = "lbl_cnhmotorista";
            lbl_cnhmotorista.Size = new Size(162, 25);
            lbl_cnhmotorista.TabIndex = 12;
            lbl_cnhmotorista.Text = "Cnh do motorista:";
            // 
            // lbl_nomemotorista
            // 
            lbl_nomemotorista.AutoSize = true;
            lbl_nomemotorista.Font = new Font("Segoe UI", 14.25F);
            lbl_nomemotorista.Location = new Point(144, 189);
            lbl_nomemotorista.Name = "lbl_nomemotorista";
            lbl_nomemotorista.Size = new Size(152, 25);
            lbl_nomemotorista.TabIndex = 11;
            lbl_nomemotorista.Text = "Nome motorista:";
            // 
            // lbl_motoristaid
            // 
            lbl_motoristaid.AutoSize = true;
            lbl_motoristaid.Font = new Font("Segoe UI", 14.25F);
            lbl_motoristaid.Location = new Point(176, 150);
            lbl_motoristaid.Name = "lbl_motoristaid";
            lbl_motoristaid.Size = new Size(120, 25);
            lbl_motoristaid.TabIndex = 10;
            lbl_motoristaid.Text = "Motorista ID:";
            // 
            // tab_rota
            // 
            tab_rota.Controls.Add(tool_rota);
            tab_rota.Controls.Add(txt_distanciarota);
            tab_rota.Controls.Add(txt_destinorota);
            tab_rota.Controls.Add(txt_origemrota);
            tab_rota.Controls.Add(txt_rotaid);
            tab_rota.Controls.Add(label1);
            tab_rota.Controls.Add(label2);
            tab_rota.Controls.Add(label3);
            tab_rota.Controls.Add(label4);
            tab_rota.Location = new Point(4, 24);
            tab_rota.Name = "tab_rota";
            tab_rota.Padding = new Padding(3);
            tab_rota.Size = new Size(915, 538);
            tab_rota.TabIndex = 2;
            tab_rota.Text = "Rota";
            tab_rota.UseVisualStyleBackColor = true;
            // 
            // tool_rota
            // 
            tool_rota.AutoSize = false;
            tool_rota.ImageScalingSize = new Size(50, 50);
            tool_rota.Items.AddRange(new ToolStripItem[] { btn_salvar_rota, btn_editar_rota, btn_consultar_rota, btn_excluir_rota });
            tool_rota.Location = new Point(3, 3);
            tool_rota.Name = "tool_rota";
            tool_rota.Size = new Size(909, 100);
            tool_rota.TabIndex = 27;
            tool_rota.Text = "toolStrip1";
            // 
            // btn_salvar_rota
            // 
            btn_salvar_rota.AutoSize = false;
            btn_salvar_rota.BackgroundImageLayout = ImageLayout.Stretch;
            btn_salvar_rota.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_salvar_rota.Font = new Font("Segoe UI", 50F);
            btn_salvar_rota.Image = (Image)resources.GetObject("btn_salvar_rota.Image");
            btn_salvar_rota.ImageTransparentColor = Color.Magenta;
            btn_salvar_rota.Name = "btn_salvar_rota";
            btn_salvar_rota.Size = new Size(80, 80);
            btn_salvar_rota.Text = "Salvar / Inserir rota";
            btn_salvar_rota.Click += btn_salvar_rota_Click;
            // 
            // btn_editar_rota
            // 
            btn_editar_rota.AutoSize = false;
            btn_editar_rota.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_editar_rota.Image = (Image)resources.GetObject("btn_editar_rota.Image");
            btn_editar_rota.ImageTransparentColor = Color.Magenta;
            btn_editar_rota.Name = "btn_editar_rota";
            btn_editar_rota.Size = new Size(80, 80);
            btn_editar_rota.Text = "toolStripButton2";
            // 
            // btn_consultar_rota
            // 
            btn_consultar_rota.AutoSize = false;
            btn_consultar_rota.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_consultar_rota.Image = (Image)resources.GetObject("btn_consultar_rota.Image");
            btn_consultar_rota.ImageTransparentColor = Color.Magenta;
            btn_consultar_rota.Name = "btn_consultar_rota";
            btn_consultar_rota.Size = new Size(80, 80);
            btn_consultar_rota.Text = "Consultar rotas";
            btn_consultar_rota.ToolTipText = "Consultar rota";
            btn_consultar_rota.Click += btn_consultar_rota_Click;
            // 
            // btn_excluir_rota
            // 
            btn_excluir_rota.AutoSize = false;
            btn_excluir_rota.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_excluir_rota.Image = (Image)resources.GetObject("btn_excluir_rota.Image");
            btn_excluir_rota.ImageTransparentColor = Color.Magenta;
            btn_excluir_rota.Name = "btn_excluir_rota";
            btn_excluir_rota.Size = new Size(80, 80);
            btn_excluir_rota.Text = "toolStripButton4";
            // 
            // txt_distanciarota
            // 
            txt_distanciarota.Font = new Font("Segoe UI", 12F);
            txt_distanciarota.Location = new Point(273, 285);
            txt_distanciarota.Name = "txt_distanciarota";
            txt_distanciarota.Size = new Size(165, 29);
            txt_distanciarota.TabIndex = 26;
            // 
            // txt_destinorota
            // 
            txt_destinorota.Font = new Font("Segoe UI", 12F);
            txt_destinorota.Location = new Point(273, 247);
            txt_destinorota.Name = "txt_destinorota";
            txt_destinorota.Size = new Size(165, 29);
            txt_destinorota.TabIndex = 25;
            // 
            // txt_origemrota
            // 
            txt_origemrota.Font = new Font("Segoe UI", 12F);
            txt_origemrota.Location = new Point(273, 203);
            txt_origemrota.Name = "txt_origemrota";
            txt_origemrota.Size = new Size(165, 29);
            txt_origemrota.TabIndex = 24;
            // 
            // txt_rotaid
            // 
            txt_rotaid.Font = new Font("Segoe UI", 12F);
            txt_rotaid.Location = new Point(274, 164);
            txt_rotaid.Name = "txt_rotaid";
            txt_rotaid.ReadOnly = true;
            txt_rotaid.Size = new Size(164, 29);
            txt_rotaid.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(63, 287);
            label1.Name = "label1";
            label1.Size = new Size(203, 25);
            label1.TabIndex = 22;
            label1.Text = "Distancia da rota (KM):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(121, 247);
            label2.Name = "label2";
            label2.Size = new Size(145, 25);
            label2.TabIndex = 21;
            label2.Text = "Destino da rota:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(122, 203);
            label3.Name = "label3";
            label3.Size = new Size(144, 25);
            label3.TabIndex = 20;
            label3.Text = "Origem da rota:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.Location = new Point(190, 164);
            label4.Name = "label4";
            label4.Size = new Size(76, 25);
            label4.TabIndex = 19;
            label4.Text = "Rota ID:";
            // 
            // tab_combustivel
            // 
            tab_combustivel.Controls.Add(tool_combustivel);
            tab_combustivel.Controls.Add(comboBox4);
            tab_combustivel.Controls.Add(dateTimePicker1);
            tab_combustivel.Controls.Add(textBox10);
            tab_combustivel.Controls.Add(textBox13);
            tab_combustivel.Controls.Add(label6);
            tab_combustivel.Controls.Add(label7);
            tab_combustivel.Controls.Add(label8);
            tab_combustivel.Controls.Add(label9);
            tab_combustivel.Location = new Point(4, 24);
            tab_combustivel.Name = "tab_combustivel";
            tab_combustivel.Padding = new Padding(3);
            tab_combustivel.Size = new Size(915, 538);
            tab_combustivel.TabIndex = 3;
            tab_combustivel.Text = "Preço Combustível";
            tab_combustivel.UseVisualStyleBackColor = true;
            // 
            // tool_combustivel
            // 
            tool_combustivel.AutoSize = false;
            tool_combustivel.ImageScalingSize = new Size(50, 50);
            tool_combustivel.Items.AddRange(new ToolStripItem[] { btn_salvar_combustivel, btn_editar_combustivel, btn_consultar_combustivel, btn_excluir_combustivel });
            tool_combustivel.Location = new Point(3, 3);
            tool_combustivel.Name = "tool_combustivel";
            tool_combustivel.Size = new Size(909, 100);
            tool_combustivel.TabIndex = 37;
            tool_combustivel.Text = "toolStrip1";
            // 
            // btn_salvar_combustivel
            // 
            btn_salvar_combustivel.AutoSize = false;
            btn_salvar_combustivel.BackgroundImageLayout = ImageLayout.Stretch;
            btn_salvar_combustivel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_salvar_combustivel.Font = new Font("Segoe UI", 50F);
            btn_salvar_combustivel.Image = (Image)resources.GetObject("btn_salvar_combustivel.Image");
            btn_salvar_combustivel.ImageTransparentColor = Color.Magenta;
            btn_salvar_combustivel.Name = "btn_salvar_combustivel";
            btn_salvar_combustivel.Size = new Size(80, 80);
            btn_salvar_combustivel.Text = "toolStripButton1";
            // 
            // btn_editar_combustivel
            // 
            btn_editar_combustivel.AutoSize = false;
            btn_editar_combustivel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_editar_combustivel.Image = (Image)resources.GetObject("btn_editar_combustivel.Image");
            btn_editar_combustivel.ImageTransparentColor = Color.Magenta;
            btn_editar_combustivel.Name = "btn_editar_combustivel";
            btn_editar_combustivel.Size = new Size(80, 80);
            btn_editar_combustivel.Text = "toolStripButton2";
            // 
            // btn_consultar_combustivel
            // 
            btn_consultar_combustivel.AutoSize = false;
            btn_consultar_combustivel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_consultar_combustivel.Image = (Image)resources.GetObject("btn_consultar_combustivel.Image");
            btn_consultar_combustivel.ImageTransparentColor = Color.Magenta;
            btn_consultar_combustivel.Name = "btn_consultar_combustivel";
            btn_consultar_combustivel.Size = new Size(80, 80);
            btn_consultar_combustivel.Text = "toolStripButton3";
            // 
            // btn_excluir_combustivel
            // 
            btn_excluir_combustivel.AutoSize = false;
            btn_excluir_combustivel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_excluir_combustivel.Image = (Image)resources.GetObject("btn_excluir_combustivel.Image");
            btn_excluir_combustivel.ImageTransparentColor = Color.Magenta;
            btn_excluir_combustivel.Name = "btn_excluir_combustivel";
            btn_excluir_combustivel.Size = new Size(80, 80);
            btn_excluir_combustivel.Text = "toolStripButton4";
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("Segoe UI", 12F);
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(306, 212);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(165, 29);
            comboBox4.TabIndex = 36;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 12F);
            dateTimePicker1.Location = new Point(306, 259);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(297, 29);
            dateTimePicker1.TabIndex = 35;
            // 
            // textBox10
            // 
            textBox10.Font = new Font("Segoe UI", 12F);
            textBox10.Location = new Point(306, 299);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(165, 29);
            textBox10.TabIndex = 34;
            // 
            // textBox13
            // 
            textBox13.Font = new Font("Segoe UI", 12F);
            textBox13.Location = new Point(306, 171);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(164, 29);
            textBox13.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F);
            label6.Location = new Point(128, 300);
            label6.Name = "label6";
            label6.Size = new Size(171, 25);
            label6.TabIndex = 30;
            label6.Text = "Preço do precomb:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F);
            label7.Location = new Point(61, 259);
            label7.Name = "label7";
            label7.Size = new Size(238, 25);
            label7.TabIndex = 29;
            label7.Text = "Data consulta do precomb:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F);
            label8.Location = new Point(73, 212);
            label8.Name = "label8";
            label8.Size = new Size(226, 25);
            label8.TabIndex = 28;
            label8.Text = "Combustível da precomb:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F);
            label9.Location = new Point(210, 171);
            label9.Name = "label9";
            label9.Size = new Size(89, 25);
            label9.TabIndex = 27;
            label9.Text = "Comb ID:";
            // 
            // tab_viagem
            // 
            tab_viagem.Controls.Add(tool_viagem);
            tab_viagem.Controls.Add(dateTimePicker3);
            tab_viagem.Controls.Add(cb_motoristaviagem);
            tab_viagem.Controls.Add(cb_rotaviagem);
            tab_viagem.Controls.Add(cb_veiculoviagem);
            tab_viagem.Controls.Add(label15);
            tab_viagem.Controls.Add(label14);
            tab_viagem.Controls.Add(dateTimePicker2);
            tab_viagem.Controls.Add(textBox15);
            tab_viagem.Controls.Add(label10);
            tab_viagem.Controls.Add(label11);
            tab_viagem.Controls.Add(label12);
            tab_viagem.Controls.Add(label13);
            tab_viagem.Location = new Point(4, 24);
            tab_viagem.Name = "tab_viagem";
            tab_viagem.Padding = new Padding(3);
            tab_viagem.Size = new Size(915, 538);
            tab_viagem.TabIndex = 4;
            tab_viagem.Text = "Viagem";
            tab_viagem.UseVisualStyleBackColor = true;
            // 
            // tool_viagem
            // 
            tool_viagem.AutoSize = false;
            tool_viagem.ImageScalingSize = new Size(50, 50);
            tool_viagem.Items.AddRange(new ToolStripItem[] { btn_salvar_viagem, btn_editar_viagem, btn_consultar_viagem, btn_excluir_viagem });
            tool_viagem.Location = new Point(3, 3);
            tool_viagem.Name = "tool_viagem";
            tool_viagem.Size = new Size(909, 100);
            tool_viagem.TabIndex = 51;
            tool_viagem.Text = "toolStrip1";
            // 
            // btn_salvar_viagem
            // 
            btn_salvar_viagem.AutoSize = false;
            btn_salvar_viagem.BackgroundImageLayout = ImageLayout.Stretch;
            btn_salvar_viagem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_salvar_viagem.Font = new Font("Segoe UI", 50F);
            btn_salvar_viagem.Image = (Image)resources.GetObject("btn_salvar_viagem.Image");
            btn_salvar_viagem.ImageTransparentColor = Color.Magenta;
            btn_salvar_viagem.Name = "btn_salvar_viagem";
            btn_salvar_viagem.Size = new Size(80, 80);
            btn_salvar_viagem.Text = "toolStripButton1";
            // 
            // btn_editar_viagem
            // 
            btn_editar_viagem.AutoSize = false;
            btn_editar_viagem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_editar_viagem.Image = (Image)resources.GetObject("btn_editar_viagem.Image");
            btn_editar_viagem.ImageTransparentColor = Color.Magenta;
            btn_editar_viagem.Name = "btn_editar_viagem";
            btn_editar_viagem.Size = new Size(80, 80);
            btn_editar_viagem.Text = "toolStripButton2";
            // 
            // btn_consultar_viagem
            // 
            btn_consultar_viagem.AutoSize = false;
            btn_consultar_viagem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_consultar_viagem.Image = (Image)resources.GetObject("btn_consultar_viagem.Image");
            btn_consultar_viagem.ImageTransparentColor = Color.Magenta;
            btn_consultar_viagem.Name = "btn_consultar_viagem";
            btn_consultar_viagem.Size = new Size(80, 80);
            btn_consultar_viagem.Text = "toolStripButton3";
            // 
            // btn_excluir_viagem
            // 
            btn_excluir_viagem.AutoSize = false;
            btn_excluir_viagem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_excluir_viagem.Image = (Image)resources.GetObject("btn_excluir_viagem.Image");
            btn_excluir_viagem.ImageTransparentColor = Color.Magenta;
            btn_excluir_viagem.Name = "btn_excluir_viagem";
            btn_excluir_viagem.Size = new Size(80, 80);
            btn_excluir_viagem.Text = "toolStripButton4";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Font = new Font("Segoe UI", 12F);
            dateTimePicker3.Location = new Point(302, 190);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(315, 29);
            dateTimePicker3.TabIndex = 50;
            // 
            // cb_motoristaviagem
            // 
            cb_motoristaviagem.Font = new Font("Segoe UI", 12F);
            cb_motoristaviagem.FormattingEnabled = true;
            cb_motoristaviagem.Location = new Point(302, 360);
            cb_motoristaviagem.Name = "cb_motoristaviagem";
            cb_motoristaviagem.Size = new Size(411, 29);
            cb_motoristaviagem.TabIndex = 49;
            cb_motoristaviagem.DropDown += cb_motoristaviagem_DropDown;
            // 
            // cb_rotaviagem
            // 
            cb_rotaviagem.Font = new Font("Segoe UI", 12F);
            cb_rotaviagem.FormattingEnabled = true;
            cb_rotaviagem.Location = new Point(302, 316);
            cb_rotaviagem.Name = "cb_rotaviagem";
            cb_rotaviagem.Size = new Size(482, 29);
            cb_rotaviagem.TabIndex = 48;
            cb_rotaviagem.DropDown += cb_rotaviagem_DropDown;
            // 
            // cb_veiculoviagem
            // 
            cb_veiculoviagem.Font = new Font("Segoe UI", 12F);
            cb_veiculoviagem.FormattingEnabled = true;
            cb_veiculoviagem.Location = new Point(302, 274);
            cb_veiculoviagem.Name = "cb_veiculoviagem";
            cb_veiculoviagem.Size = new Size(164, 29);
            cb_veiculoviagem.TabIndex = 47;
            cb_veiculoviagem.DropDown += cb_veiculoviagem_DropDown;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 15.75F);
            label15.Location = new Point(184, 360);
            label15.Name = "label15";
            label15.Size = new Size(107, 30);
            label15.TabIndex = 46;
            label15.Text = "Motorista:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 15.75F);
            label14.Location = new Point(129, 315);
            label14.Name = "label14";
            label14.Size = new Size(162, 30);
            label14.TabIndex = 44;
            label14.Text = "Rota da viagem:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Segoe UI", 12F);
            dateTimePicker2.Location = new Point(302, 234);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(315, 29);
            dateTimePicker2.TabIndex = 43;
            // 
            // textBox15
            // 
            textBox15.Font = new Font("Segoe UI", 12F);
            textBox15.Location = new Point(302, 146);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(164, 29);
            textBox15.TabIndex = 40;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15.75F);
            label10.Location = new Point(104, 274);
            label10.Name = "label10";
            label10.Size = new Size(187, 30);
            label10.TabIndex = 39;
            label10.Text = "Veiculo da viagem:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15.75F);
            label11.Location = new Point(10, 233);
            label11.Name = "label11";
            label11.Size = new Size(281, 30);
            label11.TabIndex = 38;
            label11.Text = "Data de Chegada da viagem:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15.75F);
            label12.Location = new Point(42, 190);
            label12.Name = "label12";
            label12.Size = new Size(249, 30);
            label12.TabIndex = 37;
            label12.Text = "Data de Saida da viagem:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 15.75F);
            label13.Location = new Point(176, 146);
            label13.Name = "label13";
            label13.Size = new Size(115, 30);
            label13.TabIndex = 36;
            label13.Text = "Viagem ID:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 563);
            Controls.Add(tabControl1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tab_veiculo.ResumeLayout(false);
            tab_veiculo.PerformLayout();
            tool_veiculo.ResumeLayout(false);
            tool_veiculo.PerformLayout();
            tab_motorista.ResumeLayout(false);
            tab_motorista.PerformLayout();
            tool_motorista.ResumeLayout(false);
            tool_motorista.PerformLayout();
            tab_rota.ResumeLayout(false);
            tab_rota.PerformLayout();
            tool_rota.ResumeLayout(false);
            tool_rota.PerformLayout();
            tab_combustivel.ResumeLayout(false);
            tab_combustivel.PerformLayout();
            tool_combustivel.ResumeLayout(false);
            tool_combustivel.PerformLayout();
            tab_viagem.ResumeLayout(false);
            tab_viagem.PerformLayout();
            tool_viagem.ResumeLayout(false);
            tool_viagem.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tab_veiculo;
        private TabPage tab_motorista;
        private TabPage tab_rota;
        private TabPage tab_combustivel;
        private TabPage tab_viagem;
        private Label lbl_veiculoid;
        private Label label5;
        private Label lbl_consumo;
        private Label lbl_placa;
        private Label lbl_modeloveiculo;
        private TextBox txt_veiculoid;
        private TextBox txt_placaveiculo;
        private TextBox txt_modeloveiculo;
        private TextBox txt_cargaveiculo;
        private TextBox txt_consumoveiculo;
        private TextBox txt_fonemoto;
        private TextBox txt_cnhmoto;
        private TextBox txt_nomemotorista;
        private TextBox txt_motoid;
        private Label lbl_fonemotorista;
        private Label lbl_cnhmotorista;
        private Label lbl_nomemotorista;
        private Label lbl_motoristaid;
        private TextBox txt_distanciarota;
        private TextBox txt_destinorota;
        private TextBox txt_origemrota;
        private TextBox txt_rotaid;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox10;
        private TextBox textBox13;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label15;
        private Label label14;
        private DateTimePicker dateTimePicker2;
        private TextBox textBox15;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private ToolStrip tool_veiculo;
        private ToolStripButton btn_salvar_veiculo;
        private ToolStripButton btn_editar_veiculo;
        private ToolStripButton btn_consultar_veiculo;
        private ToolStripButton btn_excluir_veiculo;
        private ComboBox comboBox4;
        private DateTimePicker dateTimePicker3;
        private ComboBox cb_motoristaviagem;
        private ComboBox cb_rotaviagem;
        private ComboBox cb_veiculoviagem;
        private ToolStrip tool_motorista;
        private ToolStripButton btn_salvar_motorista;
        private ToolStripButton btn_editar_motorista;
        private ToolStripButton btn_consultar_motorista;
        private ToolStripButton btn_excluir_motorista;
        private ToolStrip tool_rota;
        private ToolStripButton btn_salvar_rota;
        private ToolStripButton btn_editar_rota;
        private ToolStripButton btn_consultar_rota;
        private ToolStripButton btn_excluir_rota;
        private ToolStrip tool_combustivel;
        private ToolStripButton btn_salvar_combustivel;
        private ToolStripButton btn_editar_combustivel;
        private ToolStripButton btn_consultar_combustivel;
        private ToolStripButton btn_excluir_combustivel;
        private ToolStrip tool_viagem;
        private ToolStripButton btn_salvar_viagem;
        private ToolStripButton btn_editar_viagem;
        private ToolStripButton btn_consultar_viagem;
        private ToolStripButton btn_excluir_viagem;
    }
}
