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
            button2 = new Button();
            btn_procurarmotorista = new Button();
            txt_pesquisarmoto = new TextBox();
            label1 = new Label();
            grid_motorista = new DataGridView();
            btn_resetmoto = new Button();
            ((System.ComponentModel.ISupportInitialize)grid_motorista).BeginInit();
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
            // btn_procurarmotorista
            // 
            btn_procurarmotorista.Location = new Point(309, 62);
            btn_procurarmotorista.Name = "btn_procurarmotorista";
            btn_procurarmotorista.Size = new Size(75, 23);
            btn_procurarmotorista.TabIndex = 8;
            btn_procurarmotorista.Text = "Procurar";
            btn_procurarmotorista.UseVisualStyleBackColor = true;
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
            grid_motorista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_motorista.Location = new Point(12, 105);
            grid_motorista.Name = "grid_motorista";
            grid_motorista.ReadOnly = true;
            grid_motorista.Size = new Size(776, 319);
            grid_motorista.TabIndex = 5;
            grid_motorista.CellDoubleClick += grid_motorista_CellDoubleClick;
            // 
            // btn_resetmoto
            // 
            btn_resetmoto.Location = new Point(407, 61);
            btn_resetmoto.Name = "btn_resetmoto";
            btn_resetmoto.Size = new Size(75, 23);
            btn_resetmoto.TabIndex = 10;
            btn_resetmoto.Text = "Resetar";
            btn_resetmoto.UseVisualStyleBackColor = true;
            btn_resetmoto.Click += btn_resetmoto_Click;
            // 
            // Motorista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_resetmoto);
            Controls.Add(button2);
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

        private Button button2;
        private Button btn_procurarmotorista;
        private TextBox txt_pesquisarmoto;
        private Label label1;
        private DataGridView grid_motorista;
        private Button btn_resetmoto;
    }
}