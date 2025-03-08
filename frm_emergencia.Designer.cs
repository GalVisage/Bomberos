namespace ProyectoBVSV_Visgarra_Godino_Da_Silva_Diaz_Orlandi
{
    partial class frm_emergencia
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
            dtp_horainicioemerg = new DateTimePicker();
            btn_altaParticipantesEmer = new Button();
            lbl_listaparticipantes = new Label();
            lbl_inicioHoraEmerg = new Label();
            pnl_eliminarpartiemerg = new Panel();
            txt_observacionesEmer = new TextBox();
            lbl_observacion = new Label();
            btn_eliminarpartiemerg = new Button();
            lbl_cancelparticipanteemerg = new Label();
            txt_altabajaParticipantesEMER = new TextBox();
            pnl_datosemerg = new Panel();
            dtp_finhoraemerg = new DateTimePicker();
            lbl_finHora = new Label();
            pnl_listaemerg = new Panel();
            btn_guardarEmergencia = new Button();
            dgv_emergencia = new DataGridView();
            btn_cancelarEmergencia = new Button();
            pnl_eliminarpartiemerg.SuspendLayout();
            pnl_datosemerg.SuspendLayout();
            pnl_listaemerg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_emergencia).BeginInit();
            SuspendLayout();
            // 
            // dtp_horainicioemerg
            // 
            dtp_horainicioemerg.Format = DateTimePickerFormat.Time;
            dtp_horainicioemerg.Location = new Point(19, 35);
            dtp_horainicioemerg.Name = "dtp_horainicioemerg";
            dtp_horainicioemerg.Size = new Size(200, 23);
            dtp_horainicioemerg.TabIndex = 0;
            // 
            // btn_altaParticipantesEmer
            // 
            btn_altaParticipantesEmer.BackColor = Color.FromArgb(139, 59, 59);
            btn_altaParticipantesEmer.FlatAppearance.BorderColor = Color.Black;
            btn_altaParticipantesEmer.FlatStyle = FlatStyle.Flat;
            btn_altaParticipantesEmer.Font = new Font("Sitka Small", 8.25F);
            btn_altaParticipantesEmer.ForeColor = Color.White;
            btn_altaParticipantesEmer.Location = new Point(137, 229);
            btn_altaParticipantesEmer.Name = "btn_altaParticipantesEmer";
            btn_altaParticipantesEmer.Size = new Size(82, 33);
            btn_altaParticipantesEmer.TabIndex = 1;
            btn_altaParticipantesEmer.Text = "Cargar";
            btn_altaParticipantesEmer.UseVisualStyleBackColor = false;
            btn_altaParticipantesEmer.Click += btn_altaParticipantesEmer_Click;
            // 
            // lbl_listaparticipantes
            // 
            lbl_listaparticipantes.AutoSize = true;
            lbl_listaparticipantes.Location = new Point(26, 17);
            lbl_listaparticipantes.Name = "lbl_listaparticipantes";
            lbl_listaparticipantes.Size = new Size(381, 15);
            lbl_listaparticipantes.TabIndex = 3;
            lbl_listaparticipantes.Text = "Lista de participantes precargados hasta el momento en la emergencia:";
            // 
            // lbl_inicioHoraEmerg
            // 
            lbl_inicioHoraEmerg.AutoSize = true;
            lbl_inicioHoraEmerg.Location = new Point(14, 17);
            lbl_inicioHoraEmerg.Name = "lbl_inicioHoraEmerg";
            lbl_inicioHoraEmerg.Size = new Size(153, 15);
            lbl_inicioHoraEmerg.TabIndex = 5;
            lbl_inicioHoraEmerg.Text = "Seleccione la hora de inicio:";
            // 
            // pnl_eliminarpartiemerg
            // 
            pnl_eliminarpartiemerg.Anchor = AnchorStyles.Top;
            pnl_eliminarpartiemerg.BackColor = Color.White;
            pnl_eliminarpartiemerg.Controls.Add(txt_observacionesEmer);
            pnl_eliminarpartiemerg.Controls.Add(lbl_observacion);
            pnl_eliminarpartiemerg.Location = new Point(29, 322);
            pnl_eliminarpartiemerg.Name = "pnl_eliminarpartiemerg";
            pnl_eliminarpartiemerg.Size = new Size(234, 96);
            pnl_eliminarpartiemerg.TabIndex = 6;
            // 
            // txt_observacionesEmer
            // 
            txt_observacionesEmer.Location = new Point(19, 28);
            txt_observacionesEmer.Multiline = true;
            txt_observacionesEmer.Name = "txt_observacionesEmer";
            txt_observacionesEmer.Size = new Size(200, 57);
            txt_observacionesEmer.TabIndex = 9;
            // 
            // lbl_observacion
            // 
            lbl_observacion.AutoSize = true;
            lbl_observacion.Location = new Point(19, 10);
            lbl_observacion.Name = "lbl_observacion";
            lbl_observacion.Size = new Size(76, 15);
            lbl_observacion.TabIndex = 8;
            lbl_observacion.Text = "Observación:\r\n";
            // 
            // btn_eliminarpartiemerg
            // 
            btn_eliminarpartiemerg.BackColor = Color.FromArgb(139, 59, 59);
            btn_eliminarpartiemerg.FlatAppearance.BorderColor = Color.Black;
            btn_eliminarpartiemerg.FlatStyle = FlatStyle.Flat;
            btn_eliminarpartiemerg.Font = new Font("Sitka Small", 8.25F);
            btn_eliminarpartiemerg.ForeColor = Color.White;
            btn_eliminarpartiemerg.Location = new Point(19, 229);
            btn_eliminarpartiemerg.Name = "btn_eliminarpartiemerg";
            btn_eliminarpartiemerg.Size = new Size(82, 33);
            btn_eliminarpartiemerg.TabIndex = 9;
            btn_eliminarpartiemerg.Text = "Eliminar";
            btn_eliminarpartiemerg.UseVisualStyleBackColor = false;
            btn_eliminarpartiemerg.Click += btn_eliminarpartiemerg_Click;
            // 
            // lbl_cancelparticipanteemerg
            // 
            lbl_cancelparticipanteemerg.AutoSize = true;
            lbl_cancelparticipanteemerg.Location = new Point(19, 149);
            lbl_cancelparticipanteemerg.Name = "lbl_cancelparticipanteemerg";
            lbl_cancelparticipanteemerg.Size = new Size(200, 30);
            lbl_cancelparticipanteemerg.TabIndex = 7;
            lbl_cancelparticipanteemerg.Text = "Para cargar/eliminar un participante \r\ningrese su codigo:";
            // 
            // txt_altabajaParticipantesEMER
            // 
            txt_altabajaParticipantesEMER.Location = new Point(43, 188);
            txt_altabajaParticipantesEMER.Multiline = true;
            txt_altabajaParticipantesEMER.Name = "txt_altabajaParticipantesEMER";
            txt_altabajaParticipantesEMER.Size = new Size(155, 24);
            txt_altabajaParticipantesEMER.TabIndex = 8;
            // 
            // pnl_datosemerg
            // 
            pnl_datosemerg.Anchor = AnchorStyles.Top;
            pnl_datosemerg.BackColor = Color.White;
            pnl_datosemerg.Controls.Add(txt_altabajaParticipantesEMER);
            pnl_datosemerg.Controls.Add(btn_eliminarpartiemerg);
            pnl_datosemerg.Controls.Add(dtp_finhoraemerg);
            pnl_datosemerg.Controls.Add(lbl_cancelparticipanteemerg);
            pnl_datosemerg.Controls.Add(lbl_finHora);
            pnl_datosemerg.Controls.Add(btn_altaParticipantesEmer);
            pnl_datosemerg.Controls.Add(lbl_inicioHoraEmerg);
            pnl_datosemerg.Controls.Add(dtp_horainicioemerg);
            pnl_datosemerg.Location = new Point(29, 29);
            pnl_datosemerg.Name = "pnl_datosemerg";
            pnl_datosemerg.Size = new Size(234, 279);
            pnl_datosemerg.TabIndex = 7;
            // 
            // dtp_finhoraemerg
            // 
            dtp_finhoraemerg.Format = DateTimePickerFormat.Time;
            dtp_finhoraemerg.Location = new Point(19, 98);
            dtp_finhoraemerg.Name = "dtp_finhoraemerg";
            dtp_finhoraemerg.Size = new Size(200, 23);
            dtp_finhoraemerg.TabIndex = 7;
            // 
            // lbl_finHora
            // 
            lbl_finHora.AutoSize = true;
            lbl_finHora.Location = new Point(14, 80);
            lbl_finHora.Name = "lbl_finHora";
            lbl_finHora.Size = new Size(184, 15);
            lbl_finHora.TabIndex = 6;
            lbl_finHora.Text = "Seleccione la hora de finalizacion:";
            // 
            // pnl_listaemerg
            // 
            pnl_listaemerg.Anchor = AnchorStyles.Top;
            pnl_listaemerg.BackColor = Color.White;
            pnl_listaemerg.Controls.Add(btn_guardarEmergencia);
            pnl_listaemerg.Controls.Add(dgv_emergencia);
            pnl_listaemerg.Controls.Add(btn_cancelarEmergencia);
            pnl_listaemerg.Controls.Add(lbl_listaparticipantes);
            pnl_listaemerg.Location = new Point(296, 29);
            pnl_listaemerg.Name = "pnl_listaemerg";
            pnl_listaemerg.Size = new Size(663, 389);
            pnl_listaemerg.TabIndex = 8;
            pnl_listaemerg.Paint += pnl_listaemerg_Paint;
            // 
            // btn_guardarEmergencia
            // 
            btn_guardarEmergencia.BackColor = Color.FromArgb(139, 59, 59);
            btn_guardarEmergencia.FlatAppearance.BorderColor = Color.Black;
            btn_guardarEmergencia.FlatStyle = FlatStyle.Flat;
            btn_guardarEmergencia.Font = new Font("Sitka Small", 9F, FontStyle.Bold);
            btn_guardarEmergencia.ForeColor = Color.White;
            btn_guardarEmergencia.Location = new Point(349, 328);
            btn_guardarEmergencia.Name = "btn_guardarEmergencia";
            btn_guardarEmergencia.Size = new Size(203, 42);
            btn_guardarEmergencia.TabIndex = 10;
            btn_guardarEmergencia.Text = "GUARDAR EMERGENCIA";
            btn_guardarEmergencia.UseVisualStyleBackColor = false;
            btn_guardarEmergencia.Click += btn_guardarEmergencia_Click;
            // 
            // dgv_emergencia
            // 
            dgv_emergencia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_emergencia.Location = new Point(26, 35);
            dgv_emergencia.Name = "dgv_emergencia";
            dgv_emergencia.RowHeadersVisible = false;
            dgv_emergencia.RowHeadersWidth = 51;
            dgv_emergencia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_emergencia.Size = new Size(608, 283);
            dgv_emergencia.TabIndex = 4;
            // 
            // btn_cancelarEmergencia
            // 
            btn_cancelarEmergencia.BackColor = Color.Transparent;
            btn_cancelarEmergencia.FlatAppearance.BorderColor = Color.Black;
            btn_cancelarEmergencia.FlatAppearance.BorderSize = 2;
            btn_cancelarEmergencia.FlatAppearance.MouseOverBackColor = Color.FromArgb(139, 59, 59);
            btn_cancelarEmergencia.FlatStyle = FlatStyle.Flat;
            btn_cancelarEmergencia.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cancelarEmergencia.ForeColor = Color.Black;
            btn_cancelarEmergencia.Location = new Point(108, 328);
            btn_cancelarEmergencia.Name = "btn_cancelarEmergencia";
            btn_cancelarEmergencia.Size = new Size(203, 42);
            btn_cancelarEmergencia.TabIndex = 9;
            btn_cancelarEmergencia.Text = "CANCELAR EMERGENCIA";
            btn_cancelarEmergencia.UseVisualStyleBackColor = false;
            btn_cancelarEmergencia.Click += btn_cancelarEmergencia_Click;
            // 
            // frm_emergencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 55, 60);
            ClientSize = new Size(988, 430);
            Controls.Add(pnl_listaemerg);
            Controls.Add(pnl_datosemerg);
            Controls.Add(pnl_eliminarpartiemerg);
            MaximumSize = new Size(1004, 469);
            MinimumSize = new Size(1004, 469);
            Name = "frm_emergencia";
            Text = "Emergencia";
            pnl_eliminarpartiemerg.ResumeLayout(false);
            pnl_eliminarpartiemerg.PerformLayout();
            pnl_datosemerg.ResumeLayout(false);
            pnl_datosemerg.PerformLayout();
            pnl_listaemerg.ResumeLayout(false);
            pnl_listaemerg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_emergencia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtp_horainicioemerg;
        private Button btn_altaParticipantesEmer;
        private Label lbl_listaparticipantes;
        private Label lbl_inicioHoraEmerg;
        private Panel pnl_eliminarpartiemerg;
        private Label lbl_cancelparticipanteemerg;
        private TextBox txt_altabajaParticipantesEMER;
        private Button btn_eliminarpartiemerg;
        private Panel pnl_datosemerg;
        private Panel pnl_listaemerg;
        private Button btn_cancelarEmergencia;
        private Button btn_guardarEmergencia;
        private DataGridView dgv_emergencia;
        private DateTimePicker dtp_finhoraemerg;
        private Label lbl_finHora;
        private TextBox txt_observacionesEmer;
        private Label lbl_observacion;
    }
}