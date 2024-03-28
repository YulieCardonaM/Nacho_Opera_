namespace Nacho_Opera
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.lblRespuestas = new System.Windows.Forms.Label();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.btnOperaciones = new System.Windows.Forms.Button();
            this.lblSuma = new System.Windows.Forms.Label();
            this.lblResta = new System.Windows.Forms.Label();
            this.lblMultiplicacion = new System.Windows.Forms.Label();
            this.lblDivision = new System.Windows.Forms.Label();
            this.lblRespuestaSuma = new System.Windows.Forms.Label();
            this.lblRespuestaResta = new System.Windows.Forms.Label();
            this.lblRespuestaMulti = new System.Windows.Forms.Label();
            this.lblRespuestaDivision = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero1.Location = new System.Drawing.Point(97, 65);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(73, 16);
            this.lblNumero1.TabIndex = 0;
            this.lblNumero1.Text = "Número 1:";
            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero2.Location = new System.Drawing.Point(97, 119);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(73, 16);
            this.lblNumero2.TabIndex = 1;
            this.lblNumero2.Text = "Número 2:";
            // 
            // lblRespuestas
            // 
            this.lblRespuestas.AutoSize = true;
            this.lblRespuestas.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuestas.Location = new System.Drawing.Point(97, 189);
            this.lblRespuestas.Name = "lblRespuestas";
            this.lblRespuestas.Size = new System.Drawing.Size(83, 16);
            this.lblRespuestas.TabIndex = 2;
            this.lblRespuestas.Text = "Respuestas";
            this.lblRespuestas.Visible = false;
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(210, 65);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 20);
            this.txtNumero1.TabIndex = 3;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(210, 119);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(100, 20);
            this.txtNumero2.TabIndex = 4;
            // 
            // btnOperaciones
            // 
            this.btnOperaciones.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnOperaciones.Location = new System.Drawing.Point(369, 119);
            this.btnOperaciones.Name = "btnOperaciones";
            this.btnOperaciones.Size = new System.Drawing.Size(157, 23);
            this.btnOperaciones.TabIndex = 5;
            this.btnOperaciones.Text = "REALIZAR OPERACIONES";
            this.btnOperaciones.UseVisualStyleBackColor = false;
            this.btnOperaciones.Click += new System.EventHandler(this.btnOperaciones_Click);
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Location = new System.Drawing.Point(207, 192);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(41, 13);
            this.lblSuma.TabIndex = 6;
            this.lblSuma.Text = "SUMA:";
            this.lblSuma.Visible = false;
            // 
            // lblResta
            // 
            this.lblResta.AutoSize = true;
            this.lblResta.Location = new System.Drawing.Point(207, 240);
            this.lblResta.Name = "lblResta";
            this.lblResta.Size = new System.Drawing.Size(46, 13);
            this.lblResta.TabIndex = 7;
            this.lblResta.Text = "RESTA:";
            this.lblResta.Visible = false;
            // 
            // lblMultiplicacion
            // 
            this.lblMultiplicacion.AutoSize = true;
            this.lblMultiplicacion.Location = new System.Drawing.Point(207, 286);
            this.lblMultiplicacion.Name = "lblMultiplicacion";
            this.lblMultiplicacion.Size = new System.Drawing.Size(99, 13);
            this.lblMultiplicacion.TabIndex = 8;
            this.lblMultiplicacion.Text = "MULTIPLICACIÓN:";
            this.lblMultiplicacion.Visible = false;
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(207, 332);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(57, 13);
            this.lblDivision.TabIndex = 9;
            this.lblDivision.Text = "DIVISIÓN:";
            this.lblDivision.Visible = false;
            // 
            // lblRespuestaSuma
            // 
            this.lblRespuestaSuma.AutoSize = true;
            this.lblRespuestaSuma.Location = new System.Drawing.Point(255, 191);
            this.lblRespuestaSuma.Name = "lblRespuestaSuma";
            this.lblRespuestaSuma.Size = new System.Drawing.Size(0, 13);
            this.lblRespuestaSuma.TabIndex = 10;
            // 
            // lblRespuestaResta
            // 
            this.lblRespuestaResta.AutoSize = true;
            this.lblRespuestaResta.Location = new System.Drawing.Point(260, 239);
            this.lblRespuestaResta.Name = "lblRespuestaResta";
            this.lblRespuestaResta.Size = new System.Drawing.Size(0, 13);
            this.lblRespuestaResta.TabIndex = 11;
            // 
            // lblRespuestaMulti
            // 
            this.lblRespuestaMulti.AutoSize = true;
            this.lblRespuestaMulti.Location = new System.Drawing.Point(313, 285);
            this.lblRespuestaMulti.Name = "lblRespuestaMulti";
            this.lblRespuestaMulti.Size = new System.Drawing.Size(0, 13);
            this.lblRespuestaMulti.TabIndex = 12;
            // 
            // lblRespuestaDivision
            // 
            this.lblRespuestaDivision.AutoSize = true;
            this.lblRespuestaDivision.Location = new System.Drawing.Point(271, 331);
            this.lblRespuestaDivision.Name = "lblRespuestaDivision";
            this.lblRespuestaDivision.Size = new System.Drawing.Size(0, 13);
            this.lblRespuestaDivision.TabIndex = 13;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnLimpiar.Location = new System.Drawing.Point(447, 367);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(79, 32);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 439);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblRespuestaDivision);
            this.Controls.Add(this.lblRespuestaMulti);
            this.Controls.Add(this.lblRespuestaResta);
            this.Controls.Add(this.lblRespuestaSuma);
            this.Controls.Add(this.lblDivision);
            this.Controls.Add(this.lblMultiplicacion);
            this.Controls.Add(this.lblResta);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.btnOperaciones);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.lblRespuestas);
            this.Controls.Add(this.lblNumero2);
            this.Controls.Add(this.lblNumero1);
            this.Name = "frmPrincipal";
            this.Text = "REALIZANDO OPERACIONES BÁSICAS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.Label lblNumero2;
        private System.Windows.Forms.Label lblRespuestas;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Button btnOperaciones;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.Label lblResta;
        private System.Windows.Forms.Label lblMultiplicacion;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.Label lblRespuestaSuma;
        private System.Windows.Forms.Label lblRespuestaResta;
        private System.Windows.Forms.Label lblRespuestaMulti;
        private System.Windows.Forms.Label lblRespuestaDivision;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

