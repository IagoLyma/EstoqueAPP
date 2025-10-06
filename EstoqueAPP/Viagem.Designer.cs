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
            grid_viagem = new DataGridView();
            label1 = new Label();
            txt_pesquisa = new TextBox();
            btn_procurar = new Button();
            button2 = new Button();
            btn_reset = new Button();
            ((System.ComponentModel.ISupportInitialize)grid_viagem).BeginInit();
            SuspendLayout();
            // 
            // grid_viagem
            // 
            grid_viagem.AllowUserToAddRows = false;
            grid_viagem.AllowUserToDeleteRows = false;
            grid_viagem.AllowUserToOrderColumns = true;
            grid_viagem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_viagem.Location = new Point(12, 119);
            grid_viagem.Name = "grid_viagem";
            grid_viagem.ReadOnly = true;
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
            btn_procurar.Location = new Point(309, 76);
            btn_procurar.Name = "btn_procurar";
            btn_procurar.Size = new Size(75, 23);
            btn_procurar.TabIndex = 3;
            btn_procurar.Text = "Procurar";
            btn_procurar.UseVisualStyleBackColor = true;
            btn_procurar.Click += btn_procurar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(713, 77);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Voltar";
            button2.UseVisualStyleBackColor = true;
            // 
            // btn_reset
            // 
            btn_reset.Location = new Point(400, 75);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(75, 23);
            btn_reset.TabIndex = 5;
            btn_reset.Text = "Reset";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // Viagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_reset);
            Controls.Add(button2);
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
        private Button button2;
        private Button btn_reset;
    }
}