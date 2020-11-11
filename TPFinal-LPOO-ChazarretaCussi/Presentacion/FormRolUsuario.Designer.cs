namespace Presentacion
{
    partial class FormRolUsuario
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
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.rbnLider = new System.Windows.Forms.RadioButton();
            this.rbnVoluntario = new System.Windows.Forms.RadioButton();
            this.rbnAdoptante = new System.Windows.Forms.RadioButton();
            this.gbxTipoUser = new System.Windows.Forms.GroupBox();
            this.lblTipoVol = new System.Windows.Forms.Label();
            this.rbnVolPadrino = new System.Windows.Forms.RadioButton();
            this.rbnVolPaseador = new System.Windows.Forms.RadioButton();
            this.rbnVolHogar = new System.Windows.Forms.RadioButton();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.gbxTipoUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTitulo.Font = new System.Drawing.Font("Maiandra GD", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo.Location = new System.Drawing.Point(348, 198);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(250, 34);
            this.lblSubTitulo.TabIndex = 0;
            this.lblSubTitulo.Text = "TIPO DE USUARIO";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Maiandra GD", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(295, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(392, 46);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "REGISTRAR USUARIO";
            // 
            // rbnLider
            // 
            this.rbnLider.AutoSize = true;
            this.rbnLider.BackColor = System.Drawing.Color.Transparent;
            this.rbnLider.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnLider.Location = new System.Drawing.Point(226, 50);
            this.rbnLider.Name = "rbnLider";
            this.rbnLider.Size = new System.Drawing.Size(245, 33);
            this.rbnLider.TabIndex = 2;
            this.rbnLider.TabStop = true;
            this.rbnLider.Text = "Lider de Agrupación";
            this.rbnLider.UseVisualStyleBackColor = false;
            this.rbnLider.CheckedChanged += new System.EventHandler(this.rbnLider_CheckedChanged);
            // 
            // rbnVoluntario
            // 
            this.rbnVoluntario.AutoSize = true;
            this.rbnVoluntario.BackColor = System.Drawing.Color.Transparent;
            this.rbnVoluntario.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnVoluntario.Location = new System.Drawing.Point(45, 50);
            this.rbnVoluntario.Name = "rbnVoluntario";
            this.rbnVoluntario.Size = new System.Drawing.Size(145, 33);
            this.rbnVoluntario.TabIndex = 3;
            this.rbnVoluntario.TabStop = true;
            this.rbnVoluntario.Text = "Voluntario";
            this.rbnVoluntario.UseVisualStyleBackColor = false;
            this.rbnVoluntario.CheckedChanged += new System.EventHandler(this.rbnVoluntario_CheckedChanged);
            // 
            // rbnAdoptante
            // 
            this.rbnAdoptante.AutoSize = true;
            this.rbnAdoptante.BackColor = System.Drawing.Color.Transparent;
            this.rbnAdoptante.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnAdoptante.Location = new System.Drawing.Point(498, 50);
            this.rbnAdoptante.Name = "rbnAdoptante";
            this.rbnAdoptante.Size = new System.Drawing.Size(145, 33);
            this.rbnAdoptante.TabIndex = 4;
            this.rbnAdoptante.TabStop = true;
            this.rbnAdoptante.Text = "Adoptante";
            this.rbnAdoptante.UseVisualStyleBackColor = false;
            this.rbnAdoptante.CheckedChanged += new System.EventHandler(this.rbnAdoptante_CheckedChanged);
            // 
            // gbxTipoUser
            // 
            this.gbxTipoUser.BackColor = System.Drawing.Color.Transparent;
            this.gbxTipoUser.Controls.Add(this.lblTipoVol);
            this.gbxTipoUser.Controls.Add(this.rbnVolPadrino);
            this.gbxTipoUser.Controls.Add(this.rbnVolPaseador);
            this.gbxTipoUser.Controls.Add(this.rbnVolHogar);
            this.gbxTipoUser.Controls.Add(this.rbnAdoptante);
            this.gbxTipoUser.Controls.Add(this.rbnVoluntario);
            this.gbxTipoUser.Controls.Add(this.rbnLider);
            this.gbxTipoUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxTipoUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTipoUser.Location = new System.Drawing.Point(129, 235);
            this.gbxTipoUser.Name = "gbxTipoUser";
            this.gbxTipoUser.Size = new System.Drawing.Size(703, 266);
            this.gbxTipoUser.TabIndex = 5;
            this.gbxTipoUser.TabStop = false;
            // 
            // lblTipoVol
            // 
            this.lblTipoVol.AutoSize = true;
            this.lblTipoVol.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoVol.Font = new System.Drawing.Font("Maiandra GD", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVol.Location = new System.Drawing.Point(188, 145);
            this.lblTipoVol.Name = "lblTipoVol";
            this.lblTipoVol.Size = new System.Drawing.Size(310, 34);
            this.lblTipoVol.TabIndex = 21;
            this.lblTipoVol.Text = "TIPO DE VOLUNTARIO";
            // 
            // rbnVolPadrino
            // 
            this.rbnVolPadrino.AutoSize = true;
            this.rbnVolPadrino.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnVolPadrino.Location = new System.Drawing.Point(511, 203);
            this.rbnVolPadrino.Name = "rbnVolPadrino";
            this.rbnVolPadrino.Size = new System.Drawing.Size(99, 28);
            this.rbnVolPadrino.TabIndex = 7;
            this.rbnVolPadrino.TabStop = true;
            this.rbnVolPadrino.Text = "Padrino";
            this.rbnVolPadrino.UseVisualStyleBackColor = true;
            this.rbnVolPadrino.CheckedChanged += new System.EventHandler(this.rbnVolPadrino_CheckedChanged);
            // 
            // rbnVolPaseador
            // 
            this.rbnVolPaseador.AutoSize = true;
            this.rbnVolPaseador.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnVolPaseador.Location = new System.Drawing.Point(278, 203);
            this.rbnVolPaseador.Name = "rbnVolPaseador";
            this.rbnVolPaseador.Size = new System.Drawing.Size(191, 28);
            this.rbnVolPaseador.TabIndex = 6;
            this.rbnVolPaseador.TabStop = true;
            this.rbnVolPaseador.Text = "Paseador de Perro";
            this.rbnVolPaseador.UseVisualStyleBackColor = true;
            this.rbnVolPaseador.CheckedChanged += new System.EventHandler(this.rbnVolPaseador_CheckedChanged);
            // 
            // rbnVolHogar
            // 
            this.rbnVolHogar.AutoSize = true;
            this.rbnVolHogar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnVolHogar.Location = new System.Drawing.Point(58, 203);
            this.rbnVolHogar.Name = "rbnVolHogar";
            this.rbnVolHogar.Size = new System.Drawing.Size(190, 28);
            this.rbnVolHogar.TabIndex = 5;
            this.rbnVolHogar.TabStop = true;
            this.rbnVolHogar.Text = "Hogar de Acogida";
            this.rbnVolHogar.UseVisualStyleBackColor = true;
            this.rbnVolHogar.CheckedChanged += new System.EventHandler(this.rbnVolHogar_CheckedChanged);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnSiguiente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSiguiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSalmon;
            this.btnSiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Maiandra GD", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.Color.Black;
            this.btnSiguiente.Location = new System.Drawing.Point(747, 544);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(190, 50);
            this.btnSiguiente.TabIndex = 20;
            this.btnSiguiente.Text = "SIGUIENTE";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Maiandra GD", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(513, 544);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(149, 50);
            this.btnVolver.TabIndex = 21;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FormRolUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.FondoDegrade3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSubTitulo);
            this.Controls.Add(this.gbxTipoUser);
            this.Name = "FormRolUsuario";
            this.Text = "Tipo de Usuario";
            this.gbxTipoUser.ResumeLayout(false);
            this.gbxTipoUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RadioButton rbnLider;
        private System.Windows.Forms.RadioButton rbnVoluntario;
        private System.Windows.Forms.RadioButton rbnAdoptante;
        private System.Windows.Forms.GroupBox gbxTipoUser;
        private System.Windows.Forms.RadioButton rbnVolPadrino;
        private System.Windows.Forms.RadioButton rbnVolPaseador;
        private System.Windows.Forms.RadioButton rbnVolHogar;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label lblTipoVol;
        private System.Windows.Forms.Button btnVolver;
    }
}