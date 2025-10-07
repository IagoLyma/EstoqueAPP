namespace EstoqueAPP
{
    partial class form_veiculo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btn_voltar = new Button();
            btn_procurar = new Button();
            txt_pesquisa = new TextBox();
            label1 = new Label();
            grid_veiculos = new DataGridView();
            btn_resetveiculo = new Button();
            ((System.ComponentModel.ISupportInitialize)grid_veiculos).BeginInit();
            SuspendLayout();
            // 
            // btn_voltar
            // 
            btn_voltar.BackColor = Color.LightCoral;
            btn_voltar.Cursor = Cursors.Hand;
            btn_voltar.FlatStyle = FlatStyle.Flat;
            btn_voltar.Location = new Point(698, 61);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(90, 30);
            btn_voltar.TabIndex = 9;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = false;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // btn_procurar
            // 
            btn_procurar.BackColor = Color.ForestGreen;
            btn_procurar.Cursor = Cursors.Hand;
            btn_procurar.FlatStyle = FlatStyle.Flat;
            btn_procurar.ForeColor = Color.White;
            btn_procurar.Location = new Point(295, 59);
            btn_procurar.Name = "btn_procurar";
            btn_procurar.Size = new Size(90, 30);
            btn_procurar.TabIndex = 8;
            btn_procurar.Text = "Procurar";
            btn_procurar.UseVisualStyleBackColor = false;
            btn_procurar.Click += btn_procurar_Click;
            // 
            // txt_pesquisa
            // 
            txt_pesquisa.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_pesquisa.Location = new Point(12, 61);
            txt_pesquisa.Name = "txt_pesquisa";
            txt_pesquisa.Size = new Size(277, 25);
            txt_pesquisa.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(78, 21);
            label1.TabIndex = 6;
            label1.Text = "Pesquisar";
            // 
            // grid_veiculos
            // 
            grid_veiculos.AllowUserToAddRows = false;
            grid_veiculos.AllowUserToDeleteRows = false;
            grid_veiculos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            grid_veiculos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            grid_veiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_veiculos.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            grid_veiculos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            grid_veiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            grid_veiculos.DefaultCellStyle = dataGridViewCellStyle3;
            grid_veiculos.Location = new Point(12, 105);
            grid_veiculos.MultiSelect = false;
            grid_veiculos.Name = "grid_veiculos";
            grid_veiculos.ReadOnly = true;
            grid_veiculos.RowHeadersVisible = false;
            grid_veiculos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_veiculos.Size = new Size(776, 319);
            grid_veiculos.TabIndex = 5;
            grid_veiculos.CellDoubleClick += grid_veiculos_CellDoubleClick;
            // 
            // btn_resetveiculo
            // 
            btn_resetveiculo.BackColor = Color.LightGray;
            btn_resetveiculo.Cursor = Cursors.Hand;
            btn_resetveiculo.FlatStyle = FlatStyle.Flat;
            btn_resetveiculo.Location = new Point(407, 59);
            btn_resetveiculo.Name = "btn_resetveiculo";
            btn_resetveiculo.Size = new Size(90, 30);
            btn_resetveiculo.TabIndex = 10;
            btn_resetveiculo.Text = "Resetar";
            btn_resetveiculo.UseVisualStyleBackColor = false;
            btn_resetveiculo.Click += btn_resetveiculo_Click;
            // 
            // form_veiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_resetveiculo);
            Controls.Add(btn_voltar);
            Controls.Add(btn_procurar);
            Controls.Add(txt_pesquisa);
            Controls.Add(label1);
            Controls.Add(grid_veiculos);
            Name = "form_veiculo";
            Text = "Veiculo";
            Load += form_veiculo_Load;
            ((System.ComponentModel.ISupportInitialize)grid_veiculos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_voltar;
        private Button btn_procurar;
        private TextBox txt_pesquisa;
        private Label label1;
        private DataGridView grid_veiculos;
        private Button btn_resetveiculo;
    }
}