namespace EstoqueAPP
{
    partial class Viagem
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
            grid_viagem = new DataGridView();
            label1 = new Label();
            txt_pesquisa = new TextBox();
            btn_procurar = new Button();
            btn_voltar = new Button();
            btn_reset = new Button();
            ((System.ComponentModel.ISupportInitialize)grid_viagem).BeginInit();
            SuspendLayout();
            // 
            // grid_viagem
            // 
            grid_viagem.AllowUserToAddRows = false;
            grid_viagem.AllowUserToDeleteRows = false;
            grid_viagem.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            grid_viagem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            grid_viagem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_viagem.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            grid_viagem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            grid_viagem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            grid_viagem.DefaultCellStyle = dataGridViewCellStyle3;
            grid_viagem.Location = new Point(12, 119);
            grid_viagem.Name = "grid_viagem";
            grid_viagem.ReadOnly = true;
            grid_viagem.RowHeadersVisible = false;
            grid_viagem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_viagem.Size = new Size(776, 319);
            grid_viagem.TabIndex = 0;
            grid_viagem.CellDoubleClick += grid_viagem_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(78, 21);
            label1.TabIndex = 1;
            label1.Text = "Pesquisar";
            // 
            // txt_pesquisa
            // 
            txt_pesquisa.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_pesquisa.Location = new Point(12, 75);
            txt_pesquisa.Name = "txt_pesquisa";
            txt_pesquisa.Size = new Size(277, 25);
            txt_pesquisa.TabIndex = 2;
            // 
            // btn_procurar
            // 
            btn_procurar.BackColor = Color.ForestGreen;
            btn_procurar.Cursor = Cursors.Hand;
            btn_procurar.FlatStyle = FlatStyle.Flat;
            btn_procurar.ForeColor = Color.White;
            btn_procurar.Location = new Point(295, 73);
            btn_procurar.Name = "btn_procurar";
            btn_procurar.Size = new Size(90, 30);
            btn_procurar.TabIndex = 3;
            btn_procurar.Text = "Procurar";
            btn_procurar.UseVisualStyleBackColor = false;
            btn_procurar.Click += btn_procurar_Click;
            // 
            // btn_voltar
            // 
            btn_voltar.BackColor = Color.LightCoral;
            btn_voltar.Cursor = Cursors.Hand;
            btn_voltar.FlatStyle = FlatStyle.Flat;
            btn_voltar.Location = new Point(698, 73);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(90, 30);
            btn_voltar.TabIndex = 4;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = false;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // btn_reset
            // 
            btn_reset.BackColor = Color.LightGray;
            btn_reset.Cursor = Cursors.Hand;
            btn_reset.FlatStyle = FlatStyle.Flat;
            btn_reset.Location = new Point(403, 73);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(90, 30);
            btn_reset.TabIndex = 5;
            btn_reset.Text = "Reset";
            btn_reset.UseVisualStyleBackColor = false;
            btn_reset.Click += btn_reset_Click;
            // 
            // Viagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_reset);
            Controls.Add(btn_voltar);
            Controls.Add(btn_procurar);
            Controls.Add(txt_pesquisa);
            Controls.Add(label1);
            Controls.Add(grid_viagem);
            Name = "Viagem";
            Text = "Viagem";
            Load += Viagem_Load;
            ((System.ComponentModel.ISupportInitialize)grid_viagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grid_viagem;
        private Label label1;
        private TextBox txt_pesquisa;
        private Button btn_procurar;
        private Button btn_voltar;
        private Button btn_reset;
    }
}