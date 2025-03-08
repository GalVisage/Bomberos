namespace ProyectoBVSV_Visgarra_Godino_Da_Silva_Diaz_Orlandi
{
    partial class frm_ingresosalida
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
            btn_ingresobomb = new Button();
            btn__salidabomb = new Button();
            lbl_confirmacioningsal = new Label();
            pnl_btn_ing_sal = new Panel();
            btn_atrasingresosalida = new Button();
            pnl_btn_ing_sal.SuspendLayout();
            SuspendLayout();
            // 
            // btn_ingresobomb
            // 
            btn_ingresobomb.Anchor = AnchorStyles.None;
            btn_ingresobomb.BackColor = SystemColors.MenuHighlight;
            btn_ingresobomb.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 192);
            btn_ingresobomb.FlatAppearance.BorderSize = 2;
            btn_ingresobomb.FlatStyle = FlatStyle.Flat;
            btn_ingresobomb.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
            btn_ingresobomb.ForeColor = Color.White;
            btn_ingresobomb.Location = new Point(53, 64);
            btn_ingresobomb.Margin = new Padding(3, 4, 3, 4);
            btn_ingresobomb.Name = "btn_ingresobomb";
            btn_ingresobomb.Size = new Size(458, 117);
            btn_ingresobomb.TabIndex = 0;
            btn_ingresobomb.Text = "MARCAR INGRESO";
            btn_ingresobomb.UseVisualStyleBackColor = false;
            btn_ingresobomb.Click += btn_ingresobomb_Click;
            // 
            // btn__salidabomb
            // 
            btn__salidabomb.Anchor = AnchorStyles.None;
            btn__salidabomb.BackColor = Color.Brown;
            btn__salidabomb.FlatAppearance.BorderColor = Color.Maroon;
            btn__salidabomb.FlatAppearance.BorderSize = 2;
            btn__salidabomb.FlatStyle = FlatStyle.Flat;
            btn__salidabomb.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
            btn__salidabomb.ForeColor = Color.White;
            btn__salidabomb.Location = new Point(53, 257);
            btn__salidabomb.Margin = new Padding(3, 4, 3, 4);
            btn__salidabomb.Name = "btn__salidabomb";
            btn__salidabomb.Size = new Size(458, 117);
            btn__salidabomb.TabIndex = 1;
            btn__salidabomb.Text = "MARCAR SALIDA";
            btn__salidabomb.UseVisualStyleBackColor = false;
            btn__salidabomb.Click += btn__salidabomb_Click;
            // 
            // lbl_confirmacioningsal
            // 
            lbl_confirmacioningsal.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbl_confirmacioningsal.AutoSize = true;
            lbl_confirmacioningsal.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_confirmacioningsal.ForeColor = Color.FromArgb(243, 243, 243);
            lbl_confirmacioningsal.Location = new Point(400, 515);
            lbl_confirmacioningsal.Name = "lbl_confirmacioningsal";
            lbl_confirmacioningsal.Size = new Size(0, 32);
            lbl_confirmacioningsal.TabIndex = 2;
            // 
            // pnl_btn_ing_sal
            // 
            pnl_btn_ing_sal.Anchor = AnchorStyles.None;
            pnl_btn_ing_sal.BackColor = Color.White;
            pnl_btn_ing_sal.Controls.Add(btn__salidabomb);
            pnl_btn_ing_sal.Controls.Add(btn_ingresobomb);
            pnl_btn_ing_sal.Location = new Point(282, 60);
            pnl_btn_ing_sal.Margin = new Padding(3, 4, 3, 4);
            pnl_btn_ing_sal.Name = "pnl_btn_ing_sal";
            pnl_btn_ing_sal.Size = new Size(570, 433);
            pnl_btn_ing_sal.TabIndex = 4;
            pnl_btn_ing_sal.Paint += pnl_btn_ing_sal_Paint;
            // 
            // btn_atrasingresosalida
            // 
            btn_atrasingresosalida.Anchor = AnchorStyles.None;
            btn_atrasingresosalida.BackColor = Color.FromArgb(139, 59, 59);
            btn_atrasingresosalida.FlatAppearance.BorderColor = Color.White;
            btn_atrasingresosalida.FlatStyle = FlatStyle.Flat;
            btn_atrasingresosalida.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_atrasingresosalida.ForeColor = Color.White;
            btn_atrasingresosalida.Location = new Point(27, 496);
            btn_atrasingresosalida.Margin = new Padding(3, 4, 3, 4);
            btn_atrasingresosalida.Name = "btn_atrasingresosalida";
            btn_atrasingresosalida.Size = new Size(126, 48);
            btn_atrasingresosalida.TabIndex = 15;
            btn_atrasingresosalida.Text = "ATRAS";
            btn_atrasingresosalida.UseVisualStyleBackColor = false;
            btn_atrasingresosalida.Click += btn_atrasingresosalida_Click;
            // 
            // frm_ingresosalida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 55, 60);
            ClientSize = new Size(1125, 549);
            Controls.Add(btn_atrasingresosalida);
            Controls.Add(pnl_btn_ing_sal);
            Controls.Add(lbl_confirmacioningsal);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1143, 596);
            MinimumSize = new Size(1143, 596);
            Name = "frm_ingresosalida";
            Text = "Marcar ingreso/salida";
            pnl_btn_ing_sal.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_ingresobomb;
        private Button btn__salidabomb;
        private Label lbl_confirmacioningsal;
        private Panel pnl_btn_ing_sal;
        private Button btn_atrasingresosalida;
    }
}