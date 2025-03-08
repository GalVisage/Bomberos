namespace ProyectoBVSV_Visgarra_Godino_Da_Silva_Diaz_Orlandi
{
    partial class frm_bombero
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_bombero));
            lbl_bienvenidobomberoF2 = new Label();
            picbox_iconoformbomb = new PictureBox();
            lbl_cargobomberoF2 = new Label();
            lbl_nombrebomberoF2 = new Label();
            btn_entradasalida = new Button();
            btn_regtarea = new Button();
            btn_modoemergencia = new Button();
            lbl_nrocodF2 = new Label();
            lbl_areaactual = new Label();
            lbl_areatrabajoF2 = new Label();
            pnl_listabomb = new Panel();
            btn_adminstrador = new Button();
            pnl_contenedoradm = new Panel();
            btn_aceptarcontr = new Button();
            lbl_contraseñaadmi = new Label();
            txt_contraseñadm = new TextBox();
            btn_regreunionesbomb = new Button();
            pnl_tituloformbomb = new Panel();
            lbl_tituloformbomb = new Label();
            pnl_cargaform = new Panel();
            pnl_nombreformbomb = new Panel();
            pnl_codyareaformbomb = new Panel();
            btn_aceptarcod = new Button();
            txt_codbombero = new TextBox();
            pnl_horaformbomb = new Panel();
            lbl_horabomb = new Label();
            lbl_fechabomb = new Label();
            timer_fechahorabomb = new System.Windows.Forms.Timer(components);
            lbl_fraseformbomb = new Label();
            ((System.ComponentModel.ISupportInitialize)picbox_iconoformbomb).BeginInit();
            pnl_listabomb.SuspendLayout();
            pnl_contenedoradm.SuspendLayout();
            pnl_tituloformbomb.SuspendLayout();
            pnl_nombreformbomb.SuspendLayout();
            pnl_codyareaformbomb.SuspendLayout();
            pnl_horaformbomb.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_bienvenidobomberoF2
            // 
            lbl_bienvenidobomberoF2.Anchor = AnchorStyles.Top;
            lbl_bienvenidobomberoF2.AutoSize = true;
            lbl_bienvenidobomberoF2.BackColor = Color.Transparent;
            lbl_bienvenidobomberoF2.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_bienvenidobomberoF2.ForeColor = Color.FromArgb(40, 45, 50);
            lbl_bienvenidobomberoF2.Location = new Point(17, 14);
            lbl_bienvenidobomberoF2.Name = "lbl_bienvenidobomberoF2";
            lbl_bienvenidobomberoF2.Size = new Size(142, 25);
            lbl_bienvenidobomberoF2.TabIndex = 0;
            lbl_bienvenidobomberoF2.Text = "Bienvenido,";
            lbl_bienvenidobomberoF2.Visible = false;
            // 
            // picbox_iconoformbomb
            // 
            picbox_iconoformbomb.BackColor = Color.Transparent;
            picbox_iconoformbomb.Image = Properties.Resources.Logo_BVSV_removebg_preview;
            picbox_iconoformbomb.Location = new Point(0, 17);
            picbox_iconoformbomb.Name = "picbox_iconoformbomb";
            picbox_iconoformbomb.Size = new Size(199, 174);
            picbox_iconoformbomb.SizeMode = PictureBoxSizeMode.Zoom;
            picbox_iconoformbomb.TabIndex = 1;
            picbox_iconoformbomb.TabStop = false;
            // 
            // lbl_cargobomberoF2
            // 
            lbl_cargobomberoF2.Anchor = AnchorStyles.Top;
            lbl_cargobomberoF2.BackColor = Color.Transparent;
            lbl_cargobomberoF2.Font = new Font("Georgia", 15.75F);
            lbl_cargobomberoF2.ForeColor = Color.Black;
            lbl_cargobomberoF2.Location = new Point(155, 14);
            lbl_cargobomberoF2.Name = "lbl_cargobomberoF2";
            lbl_cargobomberoF2.Size = new Size(261, 25);
            lbl_cargobomberoF2.TabIndex = 2;
            // 
            // lbl_nombrebomberoF2
            // 
            lbl_nombrebomberoF2.Anchor = AnchorStyles.Top;
            lbl_nombrebomberoF2.AutoSize = true;
            lbl_nombrebomberoF2.BackColor = Color.Transparent;
            lbl_nombrebomberoF2.Font = new Font("Georgia", 15.75F);
            lbl_nombrebomberoF2.ForeColor = Color.Black;
            lbl_nombrebomberoF2.Location = new Point(17, 48);
            lbl_nombrebomberoF2.Name = "lbl_nombrebomberoF2";
            lbl_nombrebomberoF2.Size = new Size(0, 25);
            lbl_nombrebomberoF2.TabIndex = 3;
            // 
            // btn_entradasalida
            // 
            btn_entradasalida.Anchor = AnchorStyles.None;
            btn_entradasalida.BackColor = Color.FromArgb(50, 55, 60);
            btn_entradasalida.FlatAppearance.BorderSize = 0;
            btn_entradasalida.FlatStyle = FlatStyle.Flat;
            btn_entradasalida.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold);
            btn_entradasalida.ForeColor = Color.FromArgb(234, 234, 234);
            btn_entradasalida.Location = new Point(1, 209);
            btn_entradasalida.Name = "btn_entradasalida";
            btn_entradasalida.Size = new Size(198, 61);
            btn_entradasalida.TabIndex = 4;
            btn_entradasalida.Text = "REGISTRAR INGRESO/SALIDA";
            btn_entradasalida.UseVisualStyleBackColor = false;
            btn_entradasalida.Visible = false;
            btn_entradasalida.Click += btn_entradaF2_Click;
            // 
            // btn_regtarea
            // 
            btn_regtarea.Anchor = AnchorStyles.None;
            btn_regtarea.BackColor = Color.FromArgb(50, 55, 60);
            btn_regtarea.FlatAppearance.BorderSize = 0;
            btn_regtarea.FlatStyle = FlatStyle.Flat;
            btn_regtarea.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold);
            btn_regtarea.ForeColor = Color.FromArgb(234, 234, 234);
            btn_regtarea.Location = new Point(1, 273);
            btn_regtarea.Margin = new Padding(3, 5, 3, 5);
            btn_regtarea.Name = "btn_regtarea";
            btn_regtarea.Size = new Size(198, 61);
            btn_regtarea.TabIndex = 6;
            btn_regtarea.Text = "REGISTRAR TAREA REALIZADA";
            btn_regtarea.UseVisualStyleBackColor = false;
            btn_regtarea.Visible = false;
            btn_regtarea.Click += btn_regtarea_Click;
            // 
            // btn_modoemergencia
            // 
            btn_modoemergencia.Anchor = AnchorStyles.None;
            btn_modoemergencia.BackColor = Color.FromArgb(50, 55, 60);
            btn_modoemergencia.FlatAppearance.BorderSize = 0;
            btn_modoemergencia.FlatStyle = FlatStyle.Flat;
            btn_modoemergencia.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold);
            btn_modoemergencia.ForeColor = Color.FromArgb(234, 234, 234);
            btn_modoemergencia.Location = new Point(1, 335);
            btn_modoemergencia.Name = "btn_modoemergencia";
            btn_modoemergencia.Size = new Size(198, 61);
            btn_modoemergencia.TabIndex = 7;
            btn_modoemergencia.Text = "REGISTRAR EMERGENCIA";
            btn_modoemergencia.UseVisualStyleBackColor = false;
            btn_modoemergencia.Visible = false;
            btn_modoemergencia.Click += btn_modoemergencia_Click;
            // 
            // lbl_nrocodF2
            // 
            lbl_nrocodF2.Anchor = AnchorStyles.Top;
            lbl_nrocodF2.AutoSize = true;
            lbl_nrocodF2.BackColor = Color.Transparent;
            lbl_nrocodF2.Font = new Font("Georgia", 15.75F);
            lbl_nrocodF2.ForeColor = Color.Black;
            lbl_nrocodF2.Location = new Point(15, 14);
            lbl_nrocodF2.Name = "lbl_nrocodF2";
            lbl_nrocodF2.Size = new Size(91, 25);
            lbl_nrocodF2.TabIndex = 10;
            lbl_nrocodF2.Text = "Cód. N°:";
            // 
            // lbl_areaactual
            // 
            lbl_areaactual.Anchor = AnchorStyles.Top;
            lbl_areaactual.AutoSize = true;
            lbl_areaactual.BackColor = Color.Transparent;
            lbl_areaactual.Font = new Font("Georgia", 15.75F);
            lbl_areaactual.ForeColor = Color.Black;
            lbl_areaactual.Location = new Point(422, 14);
            lbl_areaactual.Name = "lbl_areaactual";
            lbl_areaactual.Size = new Size(125, 25);
            lbl_areaactual.TabIndex = 11;
            lbl_areaactual.Text = "Área actual:";
            lbl_areaactual.Visible = false;
            // 
            // lbl_areatrabajoF2
            // 
            lbl_areatrabajoF2.Anchor = AnchorStyles.Top;
            lbl_areatrabajoF2.AutoSize = true;
            lbl_areatrabajoF2.BackColor = Color.Transparent;
            lbl_areatrabajoF2.Font = new Font("Georgia", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_areatrabajoF2.ForeColor = Color.Black;
            lbl_areatrabajoF2.Location = new Point(422, 48);
            lbl_areatrabajoF2.Name = "lbl_areatrabajoF2";
            lbl_areatrabajoF2.Size = new Size(0, 25);
            lbl_areatrabajoF2.TabIndex = 13;
            // 
            // pnl_listabomb
            // 
            pnl_listabomb.BackColor = Color.FromArgb(50, 55, 60);
            pnl_listabomb.Controls.Add(btn_adminstrador);
            pnl_listabomb.Controls.Add(pnl_contenedoradm);
            pnl_listabomb.Controls.Add(btn_regreunionesbomb);
            pnl_listabomb.Controls.Add(picbox_iconoformbomb);
            pnl_listabomb.Controls.Add(btn_regtarea);
            pnl_listabomb.Controls.Add(btn_entradasalida);
            pnl_listabomb.Controls.Add(btn_modoemergencia);
            pnl_listabomb.Dock = DockStyle.Left;
            pnl_listabomb.Location = new Point(0, 0);
            pnl_listabomb.Name = "pnl_listabomb";
            pnl_listabomb.Size = new Size(199, 681);
            pnl_listabomb.TabIndex = 17;
            // 
            // btn_adminstrador
            // 
            btn_adminstrador.BackColor = Color.FromArgb(50, 55, 60);
            btn_adminstrador.FlatAppearance.BorderSize = 0;
            btn_adminstrador.FlatStyle = FlatStyle.Flat;
            btn_adminstrador.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_adminstrador.ForeColor = Color.FromArgb(243, 243, 243);
            btn_adminstrador.Location = new Point(0, 474);
            btn_adminstrador.Name = "btn_adminstrador";
            btn_adminstrador.Size = new Size(198, 61);
            btn_adminstrador.TabIndex = 0;
            btn_adminstrador.Text = "SECTOR ADMINISTRACIÓN";
            btn_adminstrador.UseVisualStyleBackColor = false;
            btn_adminstrador.Visible = false;
            btn_adminstrador.Click += btn_adminstrador_Click;
            // 
            // pnl_contenedoradm
            // 
            pnl_contenedoradm.BackColor = Color.FromArgb(40, 45, 50);
            pnl_contenedoradm.Controls.Add(btn_aceptarcontr);
            pnl_contenedoradm.Controls.Add(lbl_contraseñaadmi);
            pnl_contenedoradm.Controls.Add(txt_contraseñadm);
            pnl_contenedoradm.Dock = DockStyle.Bottom;
            pnl_contenedoradm.Location = new Point(0, 541);
            pnl_contenedoradm.Name = "pnl_contenedoradm";
            pnl_contenedoradm.Size = new Size(199, 140);
            pnl_contenedoradm.TabIndex = 21;
            pnl_contenedoradm.Visible = false;
            // 
            // btn_aceptarcontr
            // 
            btn_aceptarcontr.BackColor = Color.FromArgb(174, 35, 40);
            btn_aceptarcontr.FlatAppearance.BorderColor = Color.Black;
            btn_aceptarcontr.FlatAppearance.BorderSize = 0;
            btn_aceptarcontr.FlatStyle = FlatStyle.Flat;
            btn_aceptarcontr.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_aceptarcontr.ForeColor = Color.White;
            btn_aceptarcontr.Location = new Point(45, 86);
            btn_aceptarcontr.Name = "btn_aceptarcontr";
            btn_aceptarcontr.Size = new Size(104, 38);
            btn_aceptarcontr.TabIndex = 20;
            btn_aceptarcontr.Text = "ACEPTAR";
            btn_aceptarcontr.UseVisualStyleBackColor = false;
            btn_aceptarcontr.Click += btn_aceptarcontr_Click;
            // 
            // lbl_contraseñaadmi
            // 
            lbl_contraseñaadmi.AutoSize = true;
            lbl_contraseñaadmi.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_contraseñaadmi.ForeColor = Color.White;
            lbl_contraseñaadmi.Location = new Point(45, 11);
            lbl_contraseñaadmi.Name = "lbl_contraseñaadmi";
            lbl_contraseñaadmi.Size = new Size(106, 23);
            lbl_contraseñaadmi.TabIndex = 19;
            lbl_contraseñaadmi.Text = "Contraseña:";
            // 
            // txt_contraseñadm
            // 
            txt_contraseñadm.Location = new Point(45, 37);
            txt_contraseñadm.Name = "txt_contraseñadm";
            txt_contraseñadm.Size = new Size(104, 23);
            txt_contraseñadm.TabIndex = 17;
            // 
            // btn_regreunionesbomb
            // 
            btn_regreunionesbomb.Anchor = AnchorStyles.None;
            btn_regreunionesbomb.BackColor = Color.FromArgb(50, 55, 60);
            btn_regreunionesbomb.FlatAppearance.BorderSize = 0;
            btn_regreunionesbomb.FlatStyle = FlatStyle.Flat;
            btn_regreunionesbomb.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold);
            btn_regreunionesbomb.ForeColor = Color.FromArgb(234, 234, 234);
            btn_regreunionesbomb.Location = new Point(0, 401);
            btn_regreunionesbomb.Name = "btn_regreunionesbomb";
            btn_regreunionesbomb.Size = new Size(198, 61);
            btn_regreunionesbomb.TabIndex = 16;
            btn_regreunionesbomb.Text = "REGISTRAR REUNIONES";
            btn_regreunionesbomb.UseVisualStyleBackColor = false;
            btn_regreunionesbomb.Visible = false;
            btn_regreunionesbomb.Click += btn_regreunionesbomb_Click;
            // 
            // pnl_tituloformbomb
            // 
            pnl_tituloformbomb.BackColor = Color.FromArgb(40, 45, 50);
            pnl_tituloformbomb.Controls.Add(lbl_tituloformbomb);
            pnl_tituloformbomb.Location = new Point(229, 28);
            pnl_tituloformbomb.Name = "pnl_tituloformbomb";
            pnl_tituloformbomb.Size = new Size(1002, 52);
            pnl_tituloformbomb.TabIndex = 18;
            // 
            // lbl_tituloformbomb
            // 
            lbl_tituloformbomb.AutoSize = true;
            lbl_tituloformbomb.Font = new Font("Palatino Linotype", 29.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_tituloformbomb.ForeColor = Color.FromArgb(234, 234, 234);
            lbl_tituloformbomb.Location = new Point(137, -3);
            lbl_tituloformbomb.Name = "lbl_tituloformbomb";
            lbl_tituloformbomb.Size = new Size(705, 53);
            lbl_tituloformbomb.TabIndex = 0;
            lbl_tituloformbomb.Text = "Bomberos Voluntarios de San Vicente";
            // 
            // pnl_cargaform
            // 
            pnl_cargaform.BackColor = Color.White;
            pnl_cargaform.BackgroundImage = (Image)resources.GetObject("pnl_cargaform.BackgroundImage");
            pnl_cargaform.BackgroundImageLayout = ImageLayout.Stretch;
            pnl_cargaform.Location = new Point(229, 191);
            pnl_cargaform.Margin = new Padding(3, 2, 3, 2);
            pnl_cargaform.MaximumSize = new Size(1002, 459);
            pnl_cargaform.MinimumSize = new Size(1002, 459);
            pnl_cargaform.Name = "pnl_cargaform";
            pnl_cargaform.Size = new Size(1002, 459);
            pnl_cargaform.TabIndex = 8;
            // 
            // pnl_nombreformbomb
            // 
            pnl_nombreformbomb.AutoSize = true;
            pnl_nombreformbomb.BackColor = Color.White;
            pnl_nombreformbomb.Controls.Add(lbl_bienvenidobomberoF2);
            pnl_nombreformbomb.Controls.Add(lbl_areatrabajoF2);
            pnl_nombreformbomb.Controls.Add(lbl_cargobomberoF2);
            pnl_nombreformbomb.Controls.Add(lbl_areaactual);
            pnl_nombreformbomb.Controls.Add(lbl_nombrebomberoF2);
            pnl_nombreformbomb.Location = new Point(444, 89);
            pnl_nombreformbomb.Margin = new Padding(3, 2, 3, 2);
            pnl_nombreformbomb.Name = "pnl_nombreformbomb";
            pnl_nombreformbomb.Size = new Size(582, 91);
            pnl_nombreformbomb.TabIndex = 19;
            pnl_nombreformbomb.Paint += pnl_nombrebombF2_Paint;
            // 
            // pnl_codyareaformbomb
            // 
            pnl_codyareaformbomb.BackColor = Color.White;
            pnl_codyareaformbomb.Controls.Add(btn_aceptarcod);
            pnl_codyareaformbomb.Controls.Add(txt_codbombero);
            pnl_codyareaformbomb.Controls.Add(lbl_nrocodF2);
            pnl_codyareaformbomb.Location = new Point(229, 89);
            pnl_codyareaformbomb.Margin = new Padding(3, 2, 3, 2);
            pnl_codyareaformbomb.Name = "pnl_codyareaformbomb";
            pnl_codyareaformbomb.Size = new Size(197, 91);
            pnl_codyareaformbomb.TabIndex = 20;
            // 
            // btn_aceptarcod
            // 
            btn_aceptarcod.BackColor = Color.FromArgb(139, 59, 59);
            btn_aceptarcod.FlatAppearance.BorderColor = Color.Black;
            btn_aceptarcod.FlatAppearance.BorderSize = 0;
            btn_aceptarcod.FlatStyle = FlatStyle.Flat;
            btn_aceptarcod.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_aceptarcod.ForeColor = Color.White;
            btn_aceptarcod.Location = new Point(55, 45);
            btn_aceptarcod.Name = "btn_aceptarcod";
            btn_aceptarcod.Size = new Size(92, 38);
            btn_aceptarcod.TabIndex = 21;
            btn_aceptarcod.Text = "ACEPTAR";
            btn_aceptarcod.UseVisualStyleBackColor = false;
            btn_aceptarcod.Click += btn_aceptarcod_Click;
            // 
            // txt_codbombero
            // 
            txt_codbombero.Location = new Point(112, 16);
            txt_codbombero.Name = "txt_codbombero";
            txt_codbombero.Size = new Size(62, 23);
            txt_codbombero.TabIndex = 11;
            // 
            // pnl_horaformbomb
            // 
            pnl_horaformbomb.Anchor = AnchorStyles.Right;
            pnl_horaformbomb.BackColor = Color.White;
            pnl_horaformbomb.Controls.Add(lbl_horabomb);
            pnl_horaformbomb.Controls.Add(lbl_fechabomb);
            pnl_horaformbomb.Location = new Point(1052, 89);
            pnl_horaformbomb.Margin = new Padding(3, 2, 3, 2);
            pnl_horaformbomb.Name = "pnl_horaformbomb";
            pnl_horaformbomb.Size = new Size(179, 91);
            pnl_horaformbomb.TabIndex = 21;
            // 
            // lbl_horabomb
            // 
            lbl_horabomb.AutoSize = true;
            lbl_horabomb.Font = new Font("Georgia", 15.75F);
            lbl_horabomb.Location = new Point(11, 50);
            lbl_horabomb.Name = "lbl_horabomb";
            lbl_horabomb.Size = new Size(67, 25);
            lbl_horabomb.TabIndex = 1;
            lbl_horabomb.Text = "Hora:";
            // 
            // lbl_fechabomb
            // 
            lbl_fechabomb.AutoSize = true;
            lbl_fechabomb.Font = new Font("Georgia", 15.75F);
            lbl_fechabomb.Location = new Point(11, 19);
            lbl_fechabomb.Name = "lbl_fechabomb";
            lbl_fechabomb.Size = new Size(75, 25);
            lbl_fechabomb.TabIndex = 0;
            lbl_fechabomb.Text = "Fecha:";
            // 
            // timer_fechahorabomb
            // 
            timer_fechahorabomb.Interval = 1000;
            timer_fechahorabomb.Tick += timer_fechahorabomb_Tick;
            // 
            // lbl_fraseformbomb
            // 
            lbl_fraseformbomb.AutoSize = true;
            lbl_fraseformbomb.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_fraseformbomb.ForeColor = Color.Maroon;
            lbl_fraseformbomb.Location = new Point(647, 653);
            lbl_fraseformbomb.Name = "lbl_fraseformbomb";
            lbl_fraseformbomb.Size = new Size(243, 21);
            lbl_fraseformbomb.TabIndex = 22;
            lbl_fraseformbomb.Text = "\"Sacrificio - Valor - Abnegación\"";
            // 
            // frm_bombero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1264, 681);
            Controls.Add(lbl_fraseformbomb);
            Controls.Add(pnl_codyareaformbomb);
            Controls.Add(pnl_horaformbomb);
            Controls.Add(pnl_nombreformbomb);
            Controls.Add(pnl_cargaform);
            Controls.Add(pnl_tituloformbomb);
            Controls.Add(pnl_listabomb);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1280, 720);
            MinimumSize = new Size(1280, 720);
            Name = "frm_bombero";
            StartPosition = FormStartPosition.Manual;
            Text = "Cuerpo Activo";
            WindowState = FormWindowState.Maximized;
            Load += frm_bombero_Load;
            ((System.ComponentModel.ISupportInitialize)picbox_iconoformbomb).EndInit();
            pnl_listabomb.ResumeLayout(false);
            pnl_contenedoradm.ResumeLayout(false);
            pnl_contenedoradm.PerformLayout();
            pnl_tituloformbomb.ResumeLayout(false);
            pnl_tituloformbomb.PerformLayout();
            pnl_nombreformbomb.ResumeLayout(false);
            pnl_nombreformbomb.PerformLayout();
            pnl_codyareaformbomb.ResumeLayout(false);
            pnl_codyareaformbomb.PerformLayout();
            pnl_horaformbomb.ResumeLayout(false);
            pnl_horaformbomb.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_bienvenidobomberoF2;
        private PictureBox picbox_iconoformbomb;
        private Label lbl_cargobomberoF2;
        private Label lbl_nombrebomberoF2;
        public Button btn_entradasalida;
        public Button btn_regtarea;
        public Button btn_modoemergencia;
        private TextBox txt_obstareaF2;
        private CheckBox chkbox_colaboracionF2;
        private Label lbl_observacionF2;
        private Button btn_enviarF2;
        private Label lbl_nrocodF2;
        private Label lbl_areaactual;
        private Label lbl_areatrabajoF2;
        private ComboBox comboBox1;
        private Button btn_borrartodoF2;
        private Label lbl_selecareaF2;
        private CheckBox chkbox_guardia;
        private Panel pnl_listabomb;
        private Panel pnl_tituloformbomb;
        public Panel pnl_cargaform;
        private Panel pnl_nombreformbomb;
        private Panel pnl_codyareaformbomb;
        private Panel pnl_horaformbomb;
        private Label lbl_tituloformbomb;
        public Button btn_regreunionesbomb;
        private System.Windows.Forms.Timer timer_fechahorabomb;
        private Label lbl_contraseñaadmi;
        private TextBox txt_contraseñadm;
        private Button btn_aceptarcontr;
        private Button button1;
        private Label lbl_fraseformbomb;
        private Button btn_adminstrador;
        private Panel pnl_contenedoradm;
        private Button btn_aceptarcod;
        public Label lbl_horabomb;
        public Label lbl_fechabomb;
        public TextBox txt_codbombero;
    }
}