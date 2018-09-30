namespace XPTO.UI
{
    partial class DesafioUI
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGerarDigitoVerificador = new System.Windows.Forms.Button();
            this.btnVerificarMatriculas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGerarDigitoVerificador
            // 
            this.btnGerarDigitoVerificador.Location = new System.Drawing.Point(81, 61);
            this.btnGerarDigitoVerificador.Name = "btnGerarDigitoVerificador";
            this.btnGerarDigitoVerificador.Size = new System.Drawing.Size(172, 50);
            this.btnGerarDigitoVerificador.TabIndex = 1;
            this.btnGerarDigitoVerificador.Text = "Gerar Dígito Verificador";
            this.btnGerarDigitoVerificador.UseVisualStyleBackColor = true;
            this.btnGerarDigitoVerificador.Click += new System.EventHandler(this.btnGerarDigitoVerificador_Click);
            // 
            // btnVerificarMatriculas
            // 
            this.btnVerificarMatriculas.Location = new System.Drawing.Point(259, 61);
            this.btnVerificarMatriculas.Name = "btnVerificarMatriculas";
            this.btnVerificarMatriculas.Size = new System.Drawing.Size(172, 50);
            this.btnVerificarMatriculas.TabIndex = 2;
            this.btnVerificarMatriculas.Text = "Verificar Matrículas";
            this.btnVerificarMatriculas.UseVisualStyleBackColor = true;
            this.btnVerificarMatriculas.Click += new System.EventHandler(this.btnVerificarMatriculas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 183);
            this.Controls.Add(this.btnVerificarMatriculas);
            this.Controls.Add(this.btnGerarDigitoVerificador);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGerarDigitoVerificador;
        private System.Windows.Forms.Button btnVerificarMatriculas;
    }
}

