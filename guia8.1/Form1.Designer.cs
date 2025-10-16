namespace Guia8._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbNombre = new TextBox();
            tbDni = new TextBox();
            tbImporte = new TextBox();
            btnConfirmar = new Button();
            btnActualizar = new Button();
            lbVer = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 40);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 88);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 1;
            label2.Text = "DNI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 132);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 2;
            label3.Text = "Importe";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(159, 40);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(100, 23);
            tbNombre.TabIndex = 3;
            // 
            // tbDni
            // 
            tbDni.Location = new Point(159, 85);
            tbDni.Name = "tbDni";
            tbDni.Size = new Size(100, 23);
            tbDni.TabIndex = 4;
            // 
            // tbImporte
            // 
            tbImporte.Location = new Point(159, 132);
            tbImporte.Name = "tbImporte";
            tbImporte.Size = new Size(100, 23);
            tbImporte.TabIndex = 5;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(327, 67);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(92, 56);
            btnConfirmar.TabIndex = 6;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(327, 185);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(92, 56);
            btnActualizar.TabIndex = 7;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // lbVer
            // 
            lbVer.FormattingEnabled = true;
            lbVer.ItemHeight = 15;
            lbVer.Location = new Point(42, 185);
            lbVer.Name = "lbVer";
            lbVer.Size = new Size(253, 124);
            lbVer.TabIndex = 8;
            lbVer.SelectedIndexChanged += lbVer_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 351);
            Controls.Add(lbVer);
            Controls.Add(btnActualizar);
            Controls.Add(btnConfirmar);
            Controls.Add(tbImporte);
            Controls.Add(tbDni);
            Controls.Add(tbNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbNombre;
        private TextBox tbDni;
        private TextBox tbImporte;
        private Button btnConfirmar;
        private Button btnActualizar;
        private ListBox lbVer;
    }
}
