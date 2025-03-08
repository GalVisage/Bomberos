namespace ProyectoBVSV_Visgarra_Godino_Da_Silva_Diaz_Orlandi
{
    partial class frm_planillas
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
            dgv_planillas = new DataGridView();
            btn_descarplanilla = new Button();
            lbl_selecfecha = new Label();
            cmb_fechaplanilla = new ComboBox();
            btn_atrasplanillas = new Button();
            print_documento = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)dgv_planillas).BeginInit();
            SuspendLayout();
            // 
            // dgv_planillas
            // 
            dgv_planillas.Anchor = AnchorStyles.None;
            dgv_planillas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_planillas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_planillas.Location = new Point(29, 23);
            dgv_planillas.Name = "dgv_planillas";
            dgv_planillas.RowHeadersVisible = false;
            dgv_planillas.RowHeadersWidth = 51;
            dgv_planillas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_planillas.Size = new Size(924, 343);
            dgv_planillas.TabIndex = 0;
            // 
            // btn_descarplanilla
            // 
            btn_descarplanilla.Anchor = AnchorStyles.None;
            btn_descarplanilla.BackColor = Color.FromArgb(139, 59, 59);
            btn_descarplanilla.FlatAppearance.BorderColor = Color.White;
            btn_descarplanilla.FlatStyle = FlatStyle.Flat;
            btn_descarplanilla.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_descarplanilla.ForeColor = Color.White;
            btn_descarplanilla.Location = new Point(843, 382);
            btn_descarplanilla.Name = "btn_descarplanilla";
            btn_descarplanilla.Size = new Size(110, 36);
            btn_descarplanilla.TabIndex = 1;
            btn_descarplanilla.Text = "DESCARGAR";
            btn_descarplanilla.UseVisualStyleBackColor = false;
            btn_descarplanilla.Click += btn_descarplanilla_Click;
            // 
            // lbl_selecfecha
            // 
            lbl_selecfecha.Anchor = AnchorStyles.None;
            lbl_selecfecha.AutoSize = true;
            lbl_selecfecha.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_selecfecha.ForeColor = Color.FromArgb(243, 243, 243);
            lbl_selecfecha.Location = new Point(547, 393);
            lbl_selecfecha.Name = "lbl_selecfecha";
            lbl_selecfecha.Size = new Size(100, 17);
            lbl_selecfecha.TabIndex = 3;
            lbl_selecfecha.Text = "Filtrar por mes:";
            // 
            // cmb_fechaplanilla
            // 
            cmb_fechaplanilla.Anchor = AnchorStyles.None;
            cmb_fechaplanilla.FormattingEnabled = true;
            cmb_fechaplanilla.Location = new Point(674, 391);
            cmb_fechaplanilla.Name = "cmb_fechaplanilla";
            cmb_fechaplanilla.Size = new Size(145, 23);
            cmb_fechaplanilla.TabIndex = 4;
            // 
            // btn_atrasplanillas
            // 
            btn_atrasplanillas.Anchor = AnchorStyles.None;
            btn_atrasplanillas.BackColor = Color.FromArgb(139, 59, 59);
            btn_atrasplanillas.FlatAppearance.BorderColor = Color.White;
            btn_atrasplanillas.FlatStyle = FlatStyle.Flat;
            btn_atrasplanillas.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_atrasplanillas.ForeColor = Color.White;
            btn_atrasplanillas.Location = new Point(29, 382);
            btn_atrasplanillas.Name = "btn_atrasplanillas";
            btn_atrasplanillas.Size = new Size(110, 36);
            btn_atrasplanillas.TabIndex = 5;
            btn_atrasplanillas.Text = "ATRAS";
            btn_atrasplanillas.UseVisualStyleBackColor = false;
            btn_atrasplanillas.Click += btn_atrasplanillas_Click;
            // 
            // frm_planillas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 55, 60);
            ClientSize = new Size(986, 418);
            Controls.Add(btn_atrasplanillas);
            Controls.Add(cmb_fechaplanilla);
            Controls.Add(lbl_selecfecha);
            Controls.Add(btn_descarplanilla);
            Controls.Add(dgv_planillas);
            MaximumSize = new Size(1002, 457);
            MinimumSize = new Size(1002, 457);
            Name = "frm_planillas";
            Text = "Plantillas de consulta";
            Load += frm_planillas_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_planillas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_planillas;
        private Button btn_descarplanilla;
        private Label lbl_selecfecha;
        private ComboBox cmb_fechaplanilla;
        private Button btn_atrasplanillas;
        private System.Drawing.Printing.PrintDocument print_documento;
    }
}