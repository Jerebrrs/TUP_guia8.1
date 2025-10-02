namespace Guia8
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
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbDni = new System.Windows.Forms.Label();
            this.lbImporte = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.tbImporte = new System.Windows.Forms.TextBox();
            this.btnConfitmar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lbActualizar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(51, 44);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(47, 13);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbDni
            // 
            this.lbDni.AutoSize = true;
            this.lbDni.Location = new System.Drawing.Point(51, 74);
            this.lbDni.Name = "lbDni";
            this.lbDni.Size = new System.Drawing.Size(26, 13);
            this.lbDni.TabIndex = 1;
            this.lbDni.Text = "Dni:";
            // 
            // lbImporte
            // 
            this.lbImporte.AutoSize = true;
            this.lbImporte.Location = new System.Drawing.Point(51, 99);
            this.lbImporte.Name = "lbImporte";
            this.lbImporte.Size = new System.Drawing.Size(42, 13);
            this.lbImporte.TabIndex = 2;
            this.lbImporte.Text = "Importe";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(158, 41);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 3;
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(158, 70);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(100, 20);
            this.tbDni.TabIndex = 4;
            // 
            // tbImporte
            // 
            this.tbImporte.Location = new System.Drawing.Point(158, 96);
            this.tbImporte.Name = "tbImporte";
            this.tbImporte.Size = new System.Drawing.Size(100, 20);
            this.tbImporte.TabIndex = 5;
            // 
            // btnConfitmar
            // 
            this.btnConfitmar.Location = new System.Drawing.Point(340, 54);
            this.btnConfitmar.Name = "btnConfitmar";
            this.btnConfitmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfitmar.TabIndex = 6;
            this.btnConfitmar.Text = "Confirmar";
            this.btnConfitmar.UseVisualStyleBackColor = true;
            this.btnConfitmar.Click += new System.EventHandler(this.btnConfitmar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(340, 173);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lbActualizar
            // 
            this.lbActualizar.FormattingEnabled = true;
            this.lbActualizar.Location = new System.Drawing.Point(54, 149);
            this.lbActualizar.Name = "lbActualizar";
            this.lbActualizar.Size = new System.Drawing.Size(263, 121);
            this.lbActualizar.TabIndex = 8;
            this.lbActualizar.SelectedIndexChanged += new System.EventHandler(this.lbActualizar_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 303);
            this.Controls.Add(this.lbActualizar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnConfitmar);
            this.Controls.Add(this.tbImporte);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lbImporte);
            this.Controls.Add(this.lbDni);
            this.Controls.Add(this.lbNombre);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbDni;
        private System.Windows.Forms.Label lbImporte;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.TextBox tbImporte;
        private System.Windows.Forms.Button btnConfitmar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ListBox lbActualizar;
    }
}

