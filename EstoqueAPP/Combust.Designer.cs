namespace EstoqueAPP
{
    partial class Combust
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
            grid_comb = new DataGridView();
            btn_resetarpesquisa = new Button();
            ((System.ComponentModel.ISupportInitialize)grid_comb).BeginInit();
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
            // grid_comb
            // 
            grid_comb.AllowUserToAddRows = false;
            grid_comb.AllowUserToDeleteRows = false;
            grid_comb.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionBackColor = Color.Gray;
            grid_comb.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            grid_comb.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_comb.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            grid_comb.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            grid_comb.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            grid_comb.DefaultCellStyle = dataGridViewCellStyle3;
            grid_comb.Location = new Point(12, 105);
            grid_comb.Name = "grid_comb";
            grid_comb.ReadOnly = true;
            grid_comb.RowHeadersVisible = false;
            grid_comb.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_comb.Size = new Size(776, 319);
            grid_comb.TabIndex = 5;
            grid_comb.CellDoubleClick += grid_comb_CellDoubleClick;
            // 
            // btn_resetarpesquisa
            // 
            btn_resetarpesquisa.BackColor = Color.LightGray;
            btn_resetarpesquisa.Cursor = Cursors.Hand;
            btn_resetarpesquisa.FlatStyle = FlatStyle.Flat;
            btn_resetarpesquisa.ForeColor = Color.Black;
            btn_resetarpesquisa.Location = new Point(399, 59);
            btn_resetarpesquisa.Name = "btn_resetarpesquisa";
            btn_resetarpesquisa.Size = new Size(90, 30);
            btn_resetarpesquisa.TabIndex = 10;
            btn_resetarpesquisa.Text = "Resetar";
            btn_resetarpesquisa.UseVisualStyleBackColor = false;
            btn_resetarpesquisa.Click += btn_resetarpesquisa_Click;
            // 
            // Combust
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_resetarpesquisa);
            Controls.Add(btn_voltar);
            Controls.Add(btn_procurar);
            Controls.Add(txt_pesquisa);
            Controls.Add(label1);
            Controls.Add(grid_comb);
            Name = "Combust";
            Text = "Combust";
            Load += Combust_Load;
            ((System.ComponentModel.ISupportInitialize)grid_comb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_voltar;
        private Button btn_procurar;
        private TextBox txt_pesquisa;
        private Label label1;
        private DataGridView grid_comb;
        private Button btn_resetarpesquisa;
    }
}