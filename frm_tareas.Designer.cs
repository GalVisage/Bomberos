namespace ProyectoBVSV_Visgarra_Godino_Da_Silva_Diaz_Orlandi
{
    partial class frm_tareas
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
            pnl_redtareasF8 = new Panel();
            dgv_tareasagregadas = new DataGridView();
            lbl_selecareaF8 = new Label();
            btn_cancelartarea = new Button();
            btn_enviartarea = new Button();
            cmbox_selecarea = new ComboBox();
            lbl_observacionF8 = new Label();
            chkbox_colaboracionF8 = new CheckBox();
            txt_obstarea = new TextBox();
            pnl_redtareasF8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_tareasagregadas).BeginInit();
            SuspendLayout();
            // 
            // pnl_redtareasF8
            // 
            pnl_redtareasF8.BackColor = Color.FromArgb(50, 55, 60);
            pnl_redtareasF8.Controls.Add(dgv_tareasagregadas);
            pnl_redtareasF8.Controls.Add(lbl_selecareaF8);
            pnl_redtareasF8.Controls.Add(btn_cancelartarea);
            pnl_redtareasF8.Controls.Add(btn_enviartarea);
            pnl_redtareasF8.Controls.Add(cmbox_selecarea);
            pnl_redtareasF8.Controls.Add(lbl_observacionF8);
            pnl_redtareasF8.Controls.Add(chkbox_colaboracionF8);
            pnl_redtareasF8.Controls.Add(txt_obstarea);
            pnl_redtareasF8.Dock = DockStyle.Fill;
            pnl_redtareasF8.Location = new Point(0, 0);
            pnl_redtareasF8.Name = "pnl_redtareasF8";
            pnl_redtareasF8.Size = new Size(986, 420);
            pnl_redtareasF8.TabIndex = 0;
            // 
            // dgv_tareasagregadas
            // 
            dgv_tareasagregadas.AllowUserToAddRows = false;
            dgv_tareasagregadas.AllowUserToDeleteRows = false;
            dgv_tareasagregadas.Anchor = AnchorStyles.None;
            dgv_tareasagregadas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_tareasagregadas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_tareasagregadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_tareasagregadas.Location = new Point(22, 149);
            dgv_tareasagregadas.Name = "dgv_tareasagregadas";
            dgv_tareasagregadas.ReadOnly = true;
            dgv_tareasagregadas.RowHeadersVisible = false;
            dgv_tareasagregadas.RowHeadersWidth = 51;
            dgv_tareasagregadas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_tareasagregadas.Size = new Size(937, 257);
            dgv_tareasagregadas.TabIndex = 15;
            // 
            // lbl_selecareaF8
            // 
            lbl_selecareaF8.Anchor = AnchorStyles.None;
            lbl_selecareaF8.AutoSize = true;
            lbl_selecareaF8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_selecareaF8.ForeColor = Color.FromArgb(234, 234, 234);
            lbl_selecareaF8.Location = new Point(22, 22);
            lbl_selecareaF8.Name = "lbl_selecareaF8";
            lbl_selecareaF8.Size = new Size(135, 20);
            lbl_selecareaF8.TabIndex = 14;
            lbl_selecareaF8.Text = "Seleccione el area:";
            // 
            // btn_cancelartarea
            // 
            btn_cancelartarea.Anchor = AnchorStyles.None;
            btn_cancelartarea.BackColor = Color.Transparent;
            btn_cancelartarea.FlatAppearance.MouseOverBackColor = Color.FromArgb(139, 59, 59);
            btn_cancelartarea.FlatStyle = FlatStyle.Flat;
            btn_cancelartarea.Font = new Font("Sitka Small", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cancelartarea.ForeColor = Color.White;
            btn_cancelartarea.Location = new Point(827, 36);
            btn_cancelartarea.Name = "btn_cancelartarea";
            btn_cancelartarea.Size = new Size(132, 46);
            btn_cancelartarea.TabIndex = 12;
            btn_cancelartarea.Text = "CANCELAR";
            btn_cancelartarea.UseVisualStyleBackColor = false;
            btn_cancelartarea.Click += btn_cancelartarea_Click;
            // 
            // btn_enviartarea
            // 
            btn_enviartarea.Anchor = AnchorStyles.None;
            btn_enviartarea.BackColor = Color.FromArgb(139, 59, 59);
            btn_enviartarea.FlatStyle = FlatStyle.Flat;
            btn_enviartarea.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold);
            btn_enviartarea.ForeColor = Color.White;
            btn_enviartarea.Location = new Point(827, 87);
            btn_enviartarea.Name = "btn_enviartarea";
            btn_enviartarea.Size = new Size(132, 46);
            btn_enviartarea.TabIndex = 11;
            btn_enviartarea.Text = "ENVIAR";
            btn_enviartarea.UseVisualStyleBackColor = false;
            btn_enviartarea.Click += btn_enviartarea_Click;
            // 
            // cmbox_selecarea
            // 
            cmbox_selecarea.Anchor = AnchorStyles.None;
            cmbox_selecarea.BackColor = Color.FromArgb(234, 234, 234);
            cmbox_selecarea.FormattingEnabled = true;
            cmbox_selecarea.Items.AddRange(new object[] { "", "Edificio", "Roperia", "Capacitacion", "Taller", "Automotores", "Furrieles", "Guardia" });
            cmbox_selecarea.Location = new Point(22, 49);
            cmbox_selecarea.Name = "cmbox_selecarea";
            cmbox_selecarea.Size = new Size(204, 23);
            cmbox_selecarea.TabIndex = 13;
            // 
            // lbl_observacionF8
            // 
            lbl_observacionF8.Anchor = AnchorStyles.None;
            lbl_observacionF8.AutoSize = true;
            lbl_observacionF8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_observacionF8.ForeColor = Color.FromArgb(234, 234, 234);
            lbl_observacionF8.Location = new Point(248, 22);
            lbl_observacionF8.Name = "lbl_observacionF8";
            lbl_observacionF8.Size = new Size(100, 20);
            lbl_observacionF8.TabIndex = 10;
            lbl_observacionF8.Text = "Observación:";
            // 
            // chkbox_colaboracionF8
            // 
            chkbox_colaboracionF8.Anchor = AnchorStyles.None;
            chkbox_colaboracionF8.AutoSize = true;
            chkbox_colaboracionF8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkbox_colaboracionF8.ForeColor = Color.FromArgb(234, 234, 234);
            chkbox_colaboracionF8.Location = new Point(22, 111);
            chkbox_colaboracionF8.Name = "chkbox_colaboracionF8";
            chkbox_colaboracionF8.Size = new Size(194, 24);
            chkbox_colaboracionF8.TabIndex = 8;
            chkbox_colaboracionF8.Text = " ¿Fue una colaboración?";
            chkbox_colaboracionF8.UseVisualStyleBackColor = true;
            // 
            // txt_obstarea
            // 
            txt_obstarea.Anchor = AnchorStyles.None;
            txt_obstarea.BackColor = Color.FromArgb(234, 234, 234);
            txt_obstarea.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_obstarea.Location = new Point(248, 49);
            txt_obstarea.Multiline = true;
            txt_obstarea.Name = "txt_obstarea";
            txt_obstarea.Size = new Size(548, 85);
            txt_obstarea.TabIndex = 9;
            // 
            // frm_tareas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 420);
            Controls.Add(pnl_redtareasF8);
            MaximumSize = new Size(1002, 459);
            MinimumSize = new Size(1002, 459);
            Name = "frm_tareas";
            Text = "Carga de tareas";
            pnl_redtareasF8.ResumeLayout(false);
            pnl_redtareasF8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_tareasagregadas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_redtareasF8;
        private Label lbl_selecareaF8;
        private Button btn_cancelartarea;
        private Button btn_enviartarea;
        private ComboBox cmbox_selecarea;
        private Label lbl_observacionF8;
        private CheckBox chkbox_colaboracionF8;
        private TextBox txt_obstarea;
        private DataGridView dgv_tareasagregadas;
    }
}