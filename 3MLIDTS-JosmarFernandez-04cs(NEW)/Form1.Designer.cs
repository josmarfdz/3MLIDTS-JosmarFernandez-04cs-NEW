namespace _3MLIDTS_JosmarFernandez_04cs_NEW_
{
    partial class Form1
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.gbGénero = new System.Windows.Forms.GroupBox();
            this.rbFem = new System.Windows.Forms.RadioButton();
            this.rbMasc = new System.Windows.Forms.RadioButton();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtTeléfono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEstatura = new System.Windows.Forms.TextBox();
            this.lblEstatura = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gbGénero.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Montserrat SemiBold", 7.8F);
            this.lblNombre.Location = new System.Drawing.Point(150, 67);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(80, 18);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre(s)";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(236, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(188, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // gbGénero
            // 
            this.gbGénero.Controls.Add(this.rbFem);
            this.gbGénero.Controls.Add(this.rbMasc);
            this.gbGénero.Font = new System.Drawing.Font("Montserrat SemiBold", 7.8F);
            this.gbGénero.Location = new System.Drawing.Point(153, 261);
            this.gbGénero.Name = "gbGénero";
            this.gbGénero.Size = new System.Drawing.Size(271, 100);
            this.gbGénero.TabIndex = 2;
            this.gbGénero.TabStop = false;
            this.gbGénero.Text = "Género";
            // 
            // rbFem
            // 
            this.rbFem.AutoSize = true;
            this.rbFem.Location = new System.Drawing.Point(10, 59);
            this.rbFem.Name = "rbFem";
            this.rbFem.Size = new System.Drawing.Size(97, 22);
            this.rbFem.TabIndex = 4;
            this.rbFem.TabStop = true;
            this.rbFem.Text = "Femenino";
            this.rbFem.UseVisualStyleBackColor = true;
            // 
            // rbMasc
            // 
            this.rbMasc.AutoSize = true;
            this.rbMasc.Location = new System.Drawing.Point(10, 33);
            this.rbMasc.Name = "rbMasc";
            this.rbMasc.Size = new System.Drawing.Size(98, 22);
            this.rbMasc.TabIndex = 3;
            this.rbMasc.TabStop = true;
            this.rbMasc.Text = "Masculino";
            this.rbMasc.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnConfirmar.Font = new System.Drawing.Font("Montserrat SemiBold", 7.8F);
            this.btnConfirmar.Location = new System.Drawing.Point(177, 367);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(106, 39);
            this.btnConfirmar.TabIndex = 4;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(236, 104);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(188, 22);
            this.txtApellidos.TabIndex = 6;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Montserrat SemiBold", 7.8F);
            this.lblApellido.Location = new System.Drawing.Point(150, 104);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(81, 18);
            this.lblApellido.TabIndex = 5;
            this.lblApellido.Text = "Apellido(s)";
            // 
            // txtTeléfono
            // 
            this.txtTeléfono.Location = new System.Drawing.Point(236, 142);
            this.txtTeléfono.Name = "txtTeléfono";
            this.txtTeléfono.Size = new System.Drawing.Size(188, 22);
            this.txtTeléfono.TabIndex = 8;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Montserrat SemiBold", 7.8F);
            this.lblTelefono.Location = new System.Drawing.Point(160, 142);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(65, 18);
            this.lblTelefono.TabIndex = 7;
            this.lblTelefono.Text = "Teléfono";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(236, 180);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(188, 22);
            this.txtEdad.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 7.8F);
            this.label1.Location = new System.Drawing.Point(160, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Edad";
            // 
            // txtEstatura
            // 
            this.txtEstatura.Location = new System.Drawing.Point(236, 220);
            this.txtEstatura.Name = "txtEstatura";
            this.txtEstatura.Size = new System.Drawing.Size(188, 22);
            this.txtEstatura.TabIndex = 12;
            // 
            // lblEstatura
            // 
            this.lblEstatura.AutoSize = true;
            this.lblEstatura.Font = new System.Drawing.Font("Montserrat SemiBold", 7.8F);
            this.lblEstatura.Location = new System.Drawing.Point(160, 220);
            this.lblEstatura.Name = "lblEstatura";
            this.lblEstatura.Size = new System.Drawing.Size(65, 18);
            this.lblEstatura.TabIndex = 11;
            this.lblEstatura.Text = "Estatura";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Montserrat SemiBold", 7.8F);
            this.btnLimpiar.Location = new System.Drawing.Point(318, 367);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(106, 39);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtEstatura);
            this.Controls.Add(this.lblEstatura);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTeléfono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.gbGénero);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Captura de datos";
            this.gbGénero.ResumeLayout(false);
            this.gbGénero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox gbGénero;
        private System.Windows.Forms.RadioButton rbMasc;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtTeléfono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEstatura;
        private System.Windows.Forms.Label lblEstatura;
        private System.Windows.Forms.RadioButton rbFem;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

