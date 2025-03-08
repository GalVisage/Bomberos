namespace ProyectoBVSV_Visgarra_Godino_Da_Silva_Diaz_Orlandi
{
    partial class frm_ABMareas
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
            btn_atrasABMareas = new Button();
            btn_eliminarareaABM = new Button();
            btn_editarareaABM = new Button();
            btn_agregaareaABM = new Button();
            lbl_nombreareaABM = new Label();
            txt_IDarea = new TextBox();
            txt_nombreareaABM = new TextBox();
            dgv_planillaareasABM = new DataGridView();
            btn_Cancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_planillaareasABM).BeginInit();
            SuspendLayout();
            // 
            // btn_atrasABMareas
            // 
            btn_atrasABMareas.Anchor = AnchorStyles.None;
            btn_atrasABMareas.BackColor = Color.Transparent;
            btn_atrasABMareas.FlatAppearance.BorderColor = Color.White;
            btn_atrasABMareas.FlatStyle = FlatStyle.Flat;
            btn_atrasABMareas.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_atrasABMareas.ForeColor = Color.White;
            btn_atrasABMareas.Location = new Point(23, 398);
            btn_atrasABMareas.Name = "btn_atrasABMareas";
            btn_atrasABMareas.Size = new Size(110, 36);
            btn_atrasABMareas.TabIndex = 29;
            btn_atrasABMareas.Text = "ATRAS";
            btn_atrasABMareas.UseVisualStyleBackColor = false;
            // 
            // btn_eliminarareaABM
            // 
            btn_eliminarareaABM.BackColor = Color.FromArgb(139, 59, 59);
            btn_eliminarareaABM.Enabled = false;
            btn_eliminarareaABM.FlatAppearance.BorderColor = Color.White;
            btn_eliminarareaABM.FlatStyle = FlatStyle.Flat;
            btn_eliminarareaABM.Font = new Font("Sitka Small", 9F, FontStyle.Bold);
            btn_eliminarareaABM.ForeColor = Color.White;
            btn_eliminarareaABM.Location = new Point(874, 398);
            btn_eliminarareaABM.Name = "btn_eliminarareaABM";
            btn_eliminarareaABM.Size = new Size(100, 39);
            btn_eliminarareaABM.TabIndex = 28;
            btn_eliminarareaABM.Text = "Eliminar";
            btn_eliminarareaABM.UseVisualStyleBackColor = false;
            btn_eliminarareaABM.Click += btn_eliminarareaABM_Click;
            // 
            // btn_editarareaABM
            // 
            btn_editarareaABM.BackColor = Color.FromArgb(139, 59, 59);
            btn_editarareaABM.Enabled = false;
            btn_editarareaABM.FlatAppearance.BorderColor = Color.White;
            btn_editarareaABM.FlatStyle = FlatStyle.Flat;
            btn_editarareaABM.Font = new Font("Sitka Small", 9F, FontStyle.Bold);
            btn_editarareaABM.ForeColor = Color.White;
            btn_editarareaABM.Location = new Point(768, 398);
            btn_editarareaABM.Name = "btn_editarareaABM";
            btn_editarareaABM.Size = new Size(100, 39);
            btn_editarareaABM.TabIndex = 27;
            btn_editarareaABM.Text = "Editar";
            btn_editarareaABM.UseVisualStyleBackColor = false;
            btn_editarareaABM.Click += btn_editarareaABM_Click;
            // 
            // btn_agregaareaABM
            // 
            btn_agregaareaABM.BackColor = Color.FromArgb(139, 59, 59);
            btn_agregaareaABM.FlatAppearance.BorderColor = Color.White;
            btn_agregaareaABM.FlatStyle = FlatStyle.Flat;
            btn_agregaareaABM.Font = new Font("Sitka Small", 9F, FontStyle.Bold);
            btn_agregaareaABM.ForeColor = Color.White;
            btn_agregaareaABM.Location = new Point(662, 398);
            btn_agregaareaABM.Name = "btn_agregaareaABM";
            btn_agregaareaABM.Size = new Size(100, 39);
            btn_agregaareaABM.TabIndex = 26;
            btn_agregaareaABM.Text = "Agregar";
            btn_agregaareaABM.UseVisualStyleBackColor = false;
            btn_agregaareaABM.Click += btn_agregaareaABM_Click;
            // 
            // lbl_nombreareaABM
            // 
            lbl_nombreareaABM.AutoSize = true;
            lbl_nombreareaABM.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_nombreareaABM.ForeColor = Color.White;
            lbl_nombreareaABM.Location = new Point(283, 399);
            lbl_nombreareaABM.Name = "lbl_nombreareaABM";
            lbl_nombreareaABM.Size = new Size(75, 21);
            lbl_nombreareaABM.TabIndex = 20;
            lbl_nombreareaABM.Text = "Nombre:";
            // 
            // txt_IDarea
            // 
            txt_IDarea.Location = new Point(224, 396);
            txt_IDarea.Name = "txt_IDarea";
            txt_IDarea.Size = new Size(39, 23);
            txt_IDarea.TabIndex = 18;
            txt_IDarea.Visible = false;
            // 
            // txt_nombreareaABM
            // 
            txt_nombreareaABM.Location = new Point(364, 398);
            txt_nombreareaABM.Name = "txt_nombreareaABM";
            txt_nombreareaABM.Size = new Size(157, 23);
            txt_nombreareaABM.TabIndex = 16;
            // 
            // dgv_planillaareasABM
            // 
            dgv_planillaareasABM.AllowUserToAddRows = false;
            dgv_planillaareasABM.AllowUserToDeleteRows = false;
            dgv_planillaareasABM.AllowUserToResizeColumns = false;
            dgv_planillaareasABM.AllowUserToResizeRows = false;
            dgv_planillaareasABM.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgv_planillaareasABM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_planillaareasABM.Location = new Point(23, 12);
            dgv_planillaareasABM.MultiSelect = false;
            dgv_planillaareasABM.Name = "dgv_planillaareasABM";
            dgv_planillaareasABM.ReadOnly = true;
            dgv_planillaareasABM.RowHeadersVisible = false;
            dgv_planillaareasABM.RowHeadersWidth = 51;
            dgv_planillaareasABM.ScrollBars = ScrollBars.Vertical;
            dgv_planillaareasABM.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_planillaareasABM.Size = new Size(939, 350);
            dgv_planillaareasABM.TabIndex = 15;
            dgv_planillaareasABM.CellContentClick += dgv_planillaareasABM_CellContentClick;
            dgv_planillaareasABM.SelectionChanged += dgv_planillaareasABM_SelectionChanged;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Anchor = AnchorStyles.None;
            btn_Cancelar.BackColor = Color.Transparent;
            btn_Cancelar.FlatAppearance.BorderColor = Color.White;
            btn_Cancelar.FlatStyle = FlatStyle.Flat;
            btn_Cancelar.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Cancelar.ForeColor = Color.White;
            btn_Cancelar.Location = new Point(546, 398);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(110, 39);
            btn_Cancelar.TabIndex = 30;
            btn_Cancelar.Text = "CANCELAR";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // frm_ABMareas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 55, 60);
            ClientSize = new Size(986, 418);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_atrasABMareas);
            Controls.Add(btn_eliminarareaABM);
            Controls.Add(btn_editarareaABM);
            Controls.Add(btn_agregaareaABM);
            Controls.Add(lbl_nombreareaABM);
            Controls.Add(txt_IDarea);
            Controls.Add(txt_nombreareaABM);
            Controls.Add(dgv_planillaareasABM);
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(1002, 457);
            MinimumSize = new Size(1002, 457);
            Name = "frm_ABMareas";
            Text = "ABMareas";
            Load += ABMareas_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_planillaareasABM).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_atrasABMareas;
        private Button btn_eliminarareaABM;
        private Button btn_editarareaABM;
        private Button btn_agregaareaABM;
        private Label lbl_nombreareaABM;
        private TextBox txt_IDarea;
        private TextBox txt_nombreareaABM;
        private DataGridView dgv_planillaareasABM;
        private Button btn_Cancelar;
    }
}