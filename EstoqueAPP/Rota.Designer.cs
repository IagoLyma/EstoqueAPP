namespace EstoqueAPP
{
    partial class Rota
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
            button2 = new Button();
            btn_procurar = new Button();
            txt_pesquisa = new TextBox();
            label1 = new Label();
            grid_rota = new DataGridView();
            btn_resetarrota = new Button();
            ((System.ComponentModel.ISupportInitialize)grid_rota).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(713, 63);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "Voltar";
            button2.UseVisualStyleBackColor = true;
            // 
            // btn_procurar
            // 
            btn_procurar.Location = new Point(309, 62);
            btn_procurar.Name = "btn_procurar";
            btn_procurar.Size = new Size(75, 23);
            btn_procurar.TabIndex = 8;
            btn_procurar.Text = "Procurar";
            btn_procurar.UseVisualStyleBackColor = true;
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
            // grid_rota
            // 
            grid_rota.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_rota.Location = new Point(12, 105);
            grid_rota.Name = "grid_rota";
            grid_rota.Size = new Size(776, 319);
            grid_rota.TabIndex = 5;
            grid_rota.CellDoubleClick += grid_motorista_CellDoubleClick;
            // 
            // btn_resetarrota
            // 
            btn_resetarrota.Location = new Point(399, 63);
            btn_resetarrota.Name = "btn_resetarrota";
            btn_resetarrota.Size = new Size(75, 23);
            btn_resetarrota.TabIndex = 10;
            btn_resetarrota.Text = "Resetar";
            btn_resetarrota.UseVisualStyleBackColor = true;
            btn_resetarrota.Click += btn_resetarrota_Click;
            // 
            // Rota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_resetarrota);
            Controls.Add(button2);
            Controls.Add(btn_procurar);
            Controls.Add(txt_pesquisa);
            Controls.Add(label1);
            Controls.Add(grid_rota);
            Name = "Rota";
            Text = "Rota";
            Load += Rota_Load;
            ((System.ComponentModel.ISupportInitialize)grid_rota).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button btn_procurar;
        private TextBox txt_pesquisa;
        private Label label1;
        private DataGridView grid_rota;
        private Button btn_resetarrota;
    }
}