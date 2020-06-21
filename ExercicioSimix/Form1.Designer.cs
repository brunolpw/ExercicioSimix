namespace ExercicioSimix
{
    partial class Form1
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
            this.BtnEnviar = new System.Windows.Forms.Button();
            this.TxbResult = new System.Windows.Forms.TextBox();
            this.TxbTitulo = new System.Windows.Forms.TextBox();
            this.LblFeedback = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.Location = new System.Drawing.Point(12, 96);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(75, 23);
            this.BtnEnviar.TabIndex = 0;
            this.BtnEnviar.Text = "Enviar";
            this.BtnEnviar.UseVisualStyleBackColor = true;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // TxbResult
            // 
            this.TxbResult.Location = new System.Drawing.Point(12, 125);
            this.TxbResult.Multiline = true;
            this.TxbResult.Name = "TxbResult";
            this.TxbResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxbResult.Size = new System.Drawing.Size(776, 300);
            this.TxbResult.TabIndex = 1;
            // 
            // TxbTitulo
            // 
            this.TxbTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxbTitulo.Location = new System.Drawing.Point(12, 12);
            this.TxbTitulo.Multiline = true;
            this.TxbTitulo.Name = "TxbTitulo";
            this.TxbTitulo.ReadOnly = true;
            this.TxbTitulo.Size = new System.Drawing.Size(776, 78);
            this.TxbTitulo.TabIndex = 2;
            // 
            // LblFeedback
            // 
            this.LblFeedback.AutoSize = true;
            this.LblFeedback.Location = new System.Drawing.Point(12, 428);
            this.LblFeedback.Name = "LblFeedback";
            this.LblFeedback.Size = new System.Drawing.Size(0, 13);
            this.LblFeedback.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblFeedback);
            this.Controls.Add(this.TxbTitulo);
            this.Controls.Add(this.TxbResult);
            this.Controls.Add(this.BtnEnviar);
            this.Name = "Form1";
            this.Text = "Exercício Símix Sistemas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEnviar;
        private System.Windows.Forms.TextBox TxbResult;
        private System.Windows.Forms.TextBox TxbTitulo;
        private System.Windows.Forms.Label LblFeedback;
    }
}

