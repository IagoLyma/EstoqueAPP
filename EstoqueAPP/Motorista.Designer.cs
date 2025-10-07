namespace EstoqueAPP
{
    partial class Motorista
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
            btn_procurarmotorista = new Button();
            txt_pesquisarmoto = new TextBox();
            label1 = new Label();
            grid_motorista = new DataGridView();
            btn_resetmoto = new Button();
            ((System.ComponentModel.ISupportInitialize)grid_motorista).BeginInit();
            SuspendLayout();
            // 
            // btn_voltar
            // 
            btn_voltar.BackColor = Color.LightCoral;
            btn_voltar.Cursor = Cursors.Hand;
            btn_voltar.FlatStyle = FlatStyle.Flat;
            btn_voltar.Location = new Point(698, 58);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(90, 30);
            btn_voltar.TabIndex = 9;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = false;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // btn_procurarmotorista
            // 
            btn_procurarmotorista.BackColor = Color.ForestGreen;
            btn_procurarmotorista.Cursor = Cursors.Hand;
            btn_procurarmotorista.FlatStyle = FlatStyle.Flat;
            btn_procurarmotorista.ForeColor = SystemColors.Control;
            btn_procurarmotorista.Location = new Point(295, 58);
            btn_procurarmotorista.Name = "btn_procurarmotorista";
            btn_procurarmotorista.Size = new Size(90, 30);
            btn_procurarmotorista.TabIndex = 8;
            btn_procurarmotorista.Text = "Procurar";
            btn_procurarmotorista.UseVisualStyleBackColor = false;
            btn_procurarmotorista.Click += btn_procurarmotorista_Click;
            // 
            // txt_pesquisarmoto
            // 
            txt_pesquisarmoto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_pesquisarmoto.Location = new Point(12, 61);
            txt_pesquisarmoto.Name = "txt_pesquisarmoto";
            txt_pesquisarmoto.Size = new Size(277, 25);
            txt_pesquisarmoto.TabIndex = 7;
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
            // grid_motorista
            // 
            grid_motorista.AllowUserToAddRows = false;
            grid_motorista.AllowUserToDeleteRows = false;
            grid_motorista.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            grid_motorista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            grid_motorista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_motorista.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            grid_motorista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            grid_motorista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            grid_motorista.DefaultCellStyle = dataGridViewCellStyle3;
            grid_motorista.Location = new Point(12, 105);
            grid_motorista.Name = "grid_motorista";
            grid_motorista.ReadOnly = true;
            grid_motorista.RowHeadersVisible = false;
            grid_motorista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_motorista.Size = new Size(776, 319);
            grid_motorista.TabIndex = 5;
            grid_motorista.CellDoubleClick += grid_motorista_CellDoubleClick;
            // 
            // btn_resetmoto
            // 
            btn_resetmoto.BackColor = Color.LightGray;
            btn_resetmoto.Cursor = Cursors.Hand;
            btn_resetmoto.FlatStyle = FlatStyle.Flat;
            btn_resetmoto.Location = new Point(403, 58);
            btn_resetmoto.Name = "btn_resetmoto";
            btn_resetmoto.Size = new Size(90, 30);
            btn_resetmoto.TabIndex = 10;
            btn_resetmoto.Text = "Resetar";
            btn_resetmoto.UseVisualStyleBackColor = false;
            btn_resetmoto.Click += btn_resetmoto_Click;
            // 
            // Motorista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_resetmoto);
            Controls.Add(btn_voltar);
            Controls.Add(btn_procurarmotorista);
            Controls.Add(txt_pesquisarmoto);
            Controls.Add(label1);
            Controls.Add(grid_motorista);
            Name = "Motorista";
            Text = "Motorista";
            Load += Motorista_Load;
            ((System.ComponentModel.ISupportInitialize)grid_motorista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_voltar;
        private Button btn_procurarmotorista;
        private TextBox txt_pesquisarmoto;
        private Label label1;
        private DataGridView grid_motorista;
        private Button btn_resetmoto;
    }
}