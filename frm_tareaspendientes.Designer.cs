namespace ProyectoBVSV_Visgarra_Godino_Da_Silva_Diaz_Orlandi
{
    partial class frm_tareaspendientes
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
            btn_confirmarFTP = new Button();
            dgv_tareascargadas = new DataGridView();
            btn_atrastareaspendientes = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_tareascargadas).BeginInit();
            SuspendLayout();
            // 
            // btn_confirmarFTP
            // 
            btn_confirmarFTP.Anchor = AnchorStyles.None;
            btn_confirmarFTP.BackColor = Color.FromArgb(139, 59, 59);
            btn_confirmarFTP.FlatAppearance.BorderColor = Color.White;
            btn_confirmarFTP.FlatStyle = FlatStyle.Flat;
            btn_confirmarFTP.Font = new Font("Sitka Small", 9F, FontStyle.Bold);
            btn_confirmarFTP.ForeColor = Color.White;
            btn_confirmarFTP.Location = new Point(812, 357);
            btn_confirmarFTP.Name = "btn_confirmarFTP";
            btn_confirmarFTP.Size = new Size(141, 39);
            btn_confirmarFTP.TabIndex = 3;
            btn_confirmarFTP.Text = "ANULAR TAREA";
            btn_confirmarFTP.UseVisualStyleBackColor = false;
            btn_confirmarFTP.Click += btn_confirmarFTP_Click;
            // 
            // dgv_tareascargadas
            // 
            dgv_tareascargadas.AllowUserToAddRows = false;
            dgv_tareascargadas.AllowUserToDeleteRows = false;
            dgv_tareascargadas.AllowUserToResizeColumns = false;
            dgv_tareascargadas.AllowUserToResizeRows = false;
            dgv_tareascargadas.Anchor = AnchorStyles.Top;
            dgv_tareascargadas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_tareascargadas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_tareascargadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_tareascargadas.Location = new Point(29, 23);
            dgv_tareascargadas.Name = "dgv_tareascargadas";
            dgv_tareascargadas.ReadOnly = true;
            dgv_tareascargadas.RowHeadersVisible = false;
            dgv_tareascargadas.RowHeadersWidth = 51;
            dgv_tareascargadas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_tareascargadas.Size = new Size(924, 297);
            dgv_tareascargadas.TabIndex = 16;
            // 
            // btn_atrastareaspendientes
            // 
            btn_atrastareaspendientes.Anchor = AnchorStyles.None;
            btn_atrastareaspendientes.BackColor = Color.Transparent;
            btn_atrastareaspendientes.FlatAppearance.BorderColor = Color.White;
            btn_atrastareaspendientes.FlatStyle = FlatStyle.Flat;
            btn_atrastareaspendientes.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_atrastareaspendientes.ForeColor = Color.White;
            btn_atrastareaspendientes.Location = new Point(29, 360);
            btn_atrastareaspendientes.Name = "btn_atrastareaspendientes";
            btn_atrastareaspendientes.Size = new Size(128, 36);
            btn_atrastareaspendientes.TabIndex = 15;
            btn_atrastareaspendientes.Text = "ATRAS";
            btn_atrastareaspendientes.UseVisualStyleBackColor = false;
            btn_atrastareaspendientes.Click += btn_atrastareaspendientes_Click;
            // 
            // frm_tareaspendientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 55, 60);
            ClientSize = new Size(986, 418);
            Controls.Add(dgv_tareascargadas);
            Controls.Add(btn_atrastareaspendientes);
            Controls.Add(btn_confirmarFTP);
            MaximumSize = new Size(1002, 457);
            MinimumSize = new Size(1002, 457);
            Name = "frm_tareaspendientes";
            Text = "Validación de tareas pendientes";
            Load += frm_tareaspendientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_tareascargadas).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnl_observacionesFTP;
        private Button btn_confirmarFTP;
        private Label lbl_colaboracionFTP;
        private Label lbl_tareaFTP;
        private Label lbl_datosBombFTP;
        private Label lbl_fechaFTP;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btn_atrastareaspendientes;
        public DataGridView dgv_tareascargadas;
    }
}