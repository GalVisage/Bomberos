namespace ProyectoBVSV_Visgarra_Godino_Da_Silva_Diaz_Orlandi
{
    partial class frm_reuniones
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
            txt_obsreunionF6 = new TextBox();
            lbl_obsreunionF6 = new Label();
            dtp_fechareuniones = new DateTimePicker();
            lbl_fechahorareunionF6 = new Label();
            pnl_datosreuniones = new Panel();
            btn_bajaparticipantesReu = new Button();
            txt_bajaparticipantereuniones = new TextBox();
            lbl_cancelparticipantereu = new Label();
            btn_cargaparticipantereunion = new Button();
            txt_participantereunion = new TextBox();
            lbl_participantesFormReu = new Label();
            pnl_obsreuniones = new Panel();
            dgv_reunionesbomb = new DataGridView();
            lbl_listareuniones = new Label();
            btn_cancelarreuniones = new Button();
            btn_guardarreuniones = new Button();
            pnl_listareuniones = new Panel();
            pnl_datosreuniones.SuspendLayout();
            pnl_obsreuniones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_reunionesbomb).BeginInit();
            pnl_listareuniones.SuspendLayout();
            SuspendLayout();
            // 
            // txt_obsreunionF6
            // 
            txt_obsreunionF6.Location = new Point(20, 29);
            txt_obsreunionF6.Multiline = true;
            txt_obsreunionF6.Name = "txt_obsreunionF6";
            txt_obsreunionF6.Size = new Size(200, 64);
            txt_obsreunionF6.TabIndex = 2;
            // 
            // lbl_obsreunionF6
            // 
            lbl_obsreunionF6.AutoSize = true;
            lbl_obsreunionF6.Location = new Point(20, 11);
            lbl_obsreunionF6.Name = "lbl_obsreunionF6";
            lbl_obsreunionF6.Size = new Size(87, 15);
            lbl_obsreunionF6.TabIndex = 4;
            lbl_obsreunionF6.Text = "Observaciones:";
            // 
            // dtp_fechareuniones
            // 
            dtp_fechareuniones.Format = DateTimePickerFormat.Short;
            dtp_fechareuniones.Location = new Point(20, 37);
            dtp_fechareuniones.Name = "dtp_fechareuniones";
            dtp_fechareuniones.Size = new Size(200, 23);
            dtp_fechareuniones.TabIndex = 7;
            // 
            // lbl_fechahorareunionF6
            // 
            lbl_fechahorareunionF6.AutoSize = true;
            lbl_fechahorareunionF6.Location = new Point(20, 19);
            lbl_fechahorareunionF6.Name = "lbl_fechahorareunionF6";
            lbl_fechahorareunionF6.Size = new Size(100, 15);
            lbl_fechahorareunionF6.TabIndex = 5;
            lbl_fechahorareunionF6.Text = "Seleccione Fecha:";
            // 
            // pnl_datosreuniones
            // 
            pnl_datosreuniones.Anchor = AnchorStyles.None;
            pnl_datosreuniones.BackColor = Color.White;
            pnl_datosreuniones.Controls.Add(btn_bajaparticipantesReu);
            pnl_datosreuniones.Controls.Add(txt_bajaparticipantereuniones);
            pnl_datosreuniones.Controls.Add(lbl_cancelparticipantereu);
            pnl_datosreuniones.Controls.Add(btn_cargaparticipantereunion);
            pnl_datosreuniones.Controls.Add(txt_participantereunion);
            pnl_datosreuniones.Controls.Add(lbl_participantesFormReu);
            pnl_datosreuniones.Controls.Add(lbl_fechahorareunionF6);
            pnl_datosreuniones.Controls.Add(dtp_fechareuniones);
            pnl_datosreuniones.Location = new Point(29, 12);
            pnl_datosreuniones.Name = "pnl_datosreuniones";
            pnl_datosreuniones.Size = new Size(234, 252);
            pnl_datosreuniones.TabIndex = 10;
            // 
            // btn_bajaparticipantesReu
            // 
            btn_bajaparticipantesReu.BackColor = Color.FromArgb(139, 59, 59);
            btn_bajaparticipantesReu.FlatAppearance.BorderSize = 0;
            btn_bajaparticipantesReu.FlatStyle = FlatStyle.Flat;
            btn_bajaparticipantesReu.Font = new Font("Sitka Small", 8F, FontStyle.Bold);
            btn_bajaparticipantesReu.ForeColor = Color.White;
            btn_bajaparticipantesReu.Location = new Point(145, 200);
            btn_bajaparticipantesReu.Name = "btn_bajaparticipantesReu";
            btn_bajaparticipantesReu.Size = new Size(75, 35);
            btn_bajaparticipantesReu.TabIndex = 13;
            btn_bajaparticipantesReu.Text = "Eliminar";
            btn_bajaparticipantesReu.UseVisualStyleBackColor = false;
            btn_bajaparticipantesReu.Click += btn_bajaparticipantesReu_Click;
            // 
            // txt_bajaparticipantereuniones
            // 
            txt_bajaparticipantereuniones.Location = new Point(21, 207);
            txt_bajaparticipantereuniones.Name = "txt_bajaparticipantereuniones";
            txt_bajaparticipantereuniones.Size = new Size(102, 23);
            txt_bajaparticipantereuniones.TabIndex = 12;
            // 
            // lbl_cancelparticipantereu
            // 
            lbl_cancelparticipantereu.AutoSize = true;
            lbl_cancelparticipantereu.Location = new Point(20, 165);
            lbl_cancelparticipantereu.Name = "lbl_cancelparticipantereu";
            lbl_cancelparticipantereu.Size = new Size(190, 30);
            lbl_cancelparticipantereu.TabIndex = 11;
            lbl_cancelparticipantereu.Text = "Para eliminar un participante de la \r\nlista ingrese su codigo:";
            // 
            // btn_cargaparticipantereunion
            // 
            btn_cargaparticipantereunion.BackColor = Color.FromArgb(139, 59, 59);
            btn_cargaparticipantereunion.FlatAppearance.BorderSize = 0;
            btn_cargaparticipantereunion.FlatStyle = FlatStyle.Flat;
            btn_cargaparticipantereunion.Font = new Font("Sitka Small", 8F, FontStyle.Bold);
            btn_cargaparticipantereunion.ForeColor = Color.White;
            btn_cargaparticipantereunion.Location = new Point(145, 106);
            btn_cargaparticipantereunion.Name = "btn_cargaparticipantereunion";
            btn_cargaparticipantereunion.Size = new Size(75, 35);
            btn_cargaparticipantereunion.TabIndex = 10;
            btn_cargaparticipantereunion.Text = "Cargar";
            btn_cargaparticipantereunion.UseVisualStyleBackColor = false;
            btn_cargaparticipantereunion.Click += btn_cargaparticipantereunion_Click;
            // 
            // txt_participantereunion
            // 
            txt_participantereunion.Location = new Point(21, 113);
            txt_participantereunion.Name = "txt_participantereunion";
            txt_participantereunion.Size = new Size(102, 23);
            txt_participantereunion.TabIndex = 9;
            // 
            // lbl_participantesFormReu
            // 
            lbl_participantesFormReu.AutoSize = true;
            lbl_participantesFormReu.Location = new Point(20, 88);
            lbl_participantesFormReu.Name = "lbl_participantesFormReu";
            lbl_participantesFormReu.Size = new Size(170, 15);
            lbl_participantesFormReu.TabIndex = 8;
            lbl_participantesFormReu.Text = "Ingrese codigo de participante:";
            // 
            // pnl_obsreuniones
            // 
            pnl_obsreuniones.Anchor = AnchorStyles.None;
            pnl_obsreuniones.BackColor = Color.White;
            pnl_obsreuniones.Controls.Add(lbl_obsreunionF6);
            pnl_obsreuniones.Controls.Add(txt_obsreunionF6);
            pnl_obsreuniones.Location = new Point(29, 281);
            pnl_obsreuniones.Name = "pnl_obsreuniones";
            pnl_obsreuniones.Size = new Size(234, 112);
            pnl_obsreuniones.TabIndex = 11;
            // 
            // dgv_reunionesbomb
            // 
            dgv_reunionesbomb.AllowUserToAddRows = false;
            dgv_reunionesbomb.AllowUserToDeleteRows = false;
            dgv_reunionesbomb.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_reunionesbomb.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_reunionesbomb.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_reunionesbomb.Location = new Point(26, 45);
            dgv_reunionesbomb.Name = "dgv_reunionesbomb";
            dgv_reunionesbomb.ReadOnly = true;
            dgv_reunionesbomb.RowHeadersVisible = false;
            dgv_reunionesbomb.Size = new Size(608, 255);
            dgv_reunionesbomb.TabIndex = 0;
            // 
            // lbl_listareuniones
            // 
            lbl_listareuniones.AutoSize = true;
            lbl_listareuniones.Location = new Point(23, 20);
            lbl_listareuniones.Name = "lbl_listareuniones";
            lbl_listareuniones.Size = new Size(360, 15);
            lbl_listareuniones.TabIndex = 1;
            lbl_listareuniones.Text = "Lista de participantes precargados hasta el momento en la reunión:";
            // 
            // btn_cancelarreuniones
            // 
            btn_cancelarreuniones.BackColor = Color.Transparent;
            btn_cancelarreuniones.FlatAppearance.BorderColor = Color.Black;
            btn_cancelarreuniones.FlatAppearance.BorderSize = 2;
            btn_cancelarreuniones.FlatAppearance.MouseOverBackColor = Color.FromArgb(139, 59, 59);
            btn_cancelarreuniones.FlatStyle = FlatStyle.Flat;
            btn_cancelarreuniones.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cancelarreuniones.ForeColor = Color.Black;
            btn_cancelarreuniones.Location = new Point(108, 319);
            btn_cancelarreuniones.Name = "btn_cancelarreuniones";
            btn_cancelarreuniones.Size = new Size(203, 42);
            btn_cancelarreuniones.TabIndex = 2;
            btn_cancelarreuniones.Text = "CANCELAR";
            btn_cancelarreuniones.UseVisualStyleBackColor = false;
            btn_cancelarreuniones.Click += btn_cancelarreuniones_Click;
            // 
            // btn_guardarreuniones
            // 
            btn_guardarreuniones.BackColor = Color.FromArgb(139, 59, 59);
            btn_guardarreuniones.FlatAppearance.BorderColor = Color.Black;
            btn_guardarreuniones.FlatStyle = FlatStyle.Flat;
            btn_guardarreuniones.Font = new Font("Sitka Small", 9F, FontStyle.Bold);
            btn_guardarreuniones.ForeColor = Color.White;
            btn_guardarreuniones.Location = new Point(351, 320);
            btn_guardarreuniones.Name = "btn_guardarreuniones";
            btn_guardarreuniones.Size = new Size(203, 42);
            btn_guardarreuniones.TabIndex = 3;
            btn_guardarreuniones.Text = "GUARDAR";
            btn_guardarreuniones.UseVisualStyleBackColor = false;
            btn_guardarreuniones.Click += btn_guardarreuniones_Click;
            // 
            // pnl_listareuniones
            // 
            pnl_listareuniones.Anchor = AnchorStyles.None;
            pnl_listareuniones.BackColor = Color.White;
            pnl_listareuniones.Controls.Add(btn_guardarreuniones);
            pnl_listareuniones.Controls.Add(btn_cancelarreuniones);
            pnl_listareuniones.Controls.Add(lbl_listareuniones);
            pnl_listareuniones.Controls.Add(dgv_reunionesbomb);
            pnl_listareuniones.Location = new Point(296, 12);
            pnl_listareuniones.Name = "pnl_listareuniones";
            pnl_listareuniones.Size = new Size(661, 381);
            pnl_listareuniones.TabIndex = 9;
            pnl_listareuniones.Paint += pnl_listareuniones_Paint;
            // 
            // frm_reuniones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 55, 60);
            ClientSize = new Size(986, 420);
            Controls.Add(pnl_listareuniones);
            Controls.Add(pnl_obsreuniones);
            Controls.Add(pnl_datosreuniones);
            MaximumSize = new Size(1002, 459);
            MinimumSize = new Size(1002, 459);
            Name = "frm_reuniones";
            Text = "Reuniones";
            pnl_datosreuniones.ResumeLayout(false);
            pnl_datosreuniones.PerformLayout();
            pnl_obsreuniones.ResumeLayout(false);
            pnl_obsreuniones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_reunionesbomb).EndInit();
            pnl_listareuniones.ResumeLayout(false);
            pnl_listareuniones.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txt_obsreunionF6;
        private Label lbl_obsreunionF6;
        private DateTimePicker dtp_fechareuniones;
        private Label lbl_fechahorareunionF6;
        private Panel pnl_datosreuniones;
        private Button btn_descargardgvF6;
        private Panel pnl_reuniones;
        private Panel pnl_reuniones2;
        private Label lbl_participantesFormReu;
        private TextBox txt_participantereunion;
        private Button btn_cargaparticipantereunion;
        private Label lbl_cancelparticipantereu;
        private TextBox txt_bajaparticipantereuniones;
        private Button btn_bajaparticipantesReu;
        private Panel pnl_obsreuniones;
        private DataGridView dgv_reunionesbomb;
        private Label lbl_listareuniones;
        private Button btn_cancelarreuniones;
        private Button btn_guardarreuniones;
        private Panel pnl_listareuniones;
    }
}