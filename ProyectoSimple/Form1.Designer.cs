namespace ProyectoSimple
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
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.txbNacionalidad = new System.Windows.Forms.TextBox();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txbUrlFoto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCargaPersona = new System.Windows.Forms.Button();
            this.btnBorrarPersona = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.Location = new System.Drawing.Point(27, 12);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.Size = new System.Drawing.Size(718, 114);
            this.dgvPersonas.TabIndex = 0;
            // 
            // pbFoto
            // 
            this.pbFoto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Location = new System.Drawing.Point(436, 132);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(309, 227);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 1;
            this.pbFoto.TabStop = false;
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Location = new System.Drawing.Point(670, 380);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(75, 23);
            this.btnCargarImagen.TabIndex = 2;
            this.btnCargarImagen.Text = "Mostrar";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(108, 144);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(264, 20);
            this.txbNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(58, 147);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Location = new System.Drawing.Point(33, 202);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(69, 13);
            this.lblNacionalidad.TabIndex = 5;
            this.lblNacionalidad.Text = "Nacionalidad";
            // 
            // txbNacionalidad
            // 
            this.txbNacionalidad.Location = new System.Drawing.Point(108, 199);
            this.txbNacionalidad.Name = "txbNacionalidad";
            this.txbNacionalidad.Size = new System.Drawing.Size(264, 20);
            this.txbNacionalidad.TabIndex = 6;
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(108, 256);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(120, 20);
            this.nudEdad.TabIndex = 7;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(70, 258);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 8;
            this.lblEdad.Text = "Edad";
            // 
            // txbUrlFoto
            // 
            this.txbUrlFoto.Location = new System.Drawing.Point(108, 305);
            this.txbUrlFoto.Name = "txbUrlFoto";
            this.txbUrlFoto.Size = new System.Drawing.Size(264, 20);
            this.txbUrlFoto.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Url de foto";
            // 
            // btnCargaPersona
            // 
            this.btnCargaPersona.Location = new System.Drawing.Point(61, 380);
            this.btnCargaPersona.Name = "btnCargaPersona";
            this.btnCargaPersona.Size = new System.Drawing.Size(171, 23);
            this.btnCargaPersona.TabIndex = 11;
            this.btnCargaPersona.Text = "Cargar Persona";
            this.btnCargaPersona.UseVisualStyleBackColor = true;
            this.btnCargaPersona.Click += new System.EventHandler(this.btnCargaPersona_Click);
            // 
            // btnBorrarPersona
            // 
            this.btnBorrarPersona.Location = new System.Drawing.Point(253, 380);
            this.btnBorrarPersona.Name = "btnBorrarPersona";
            this.btnBorrarPersona.Size = new System.Drawing.Size(87, 23);
            this.btnBorrarPersona.TabIndex = 12;
            this.btnBorrarPersona.Text = "Borrar Persona";
            this.btnBorrarPersona.UseVisualStyleBackColor = true;
            this.btnBorrarPersona.Click += new System.EventHandler(this.btnBorrarPersona_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBorrarPersona);
            this.Controls.Add(this.btnCargaPersona);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbUrlFoto);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.nudEdad);
            this.Controls.Add(this.txbNacionalidad);
            this.Controls.Add(this.lblNacionalidad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.btnCargarImagen);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.dgvPersonas);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.TextBox txbNacionalidad;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txbUrlFoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCargaPersona;
        private System.Windows.Forms.Button btnBorrarPersona;
    }
}

