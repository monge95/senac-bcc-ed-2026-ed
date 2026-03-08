namespace aula11
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
            this.ListarPartida = new System.Windows.Forms.Button();
            this.RetornoListaPartidas = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ListarPartida
            // 
            this.ListarPartida.Location = new System.Drawing.Point(12, 12);
            this.ListarPartida.Name = "ListarPartida";
            this.ListarPartida.Size = new System.Drawing.Size(108, 28);
            this.ListarPartida.TabIndex = 0;
            this.ListarPartida.Text = "listar partidas";
            this.ListarPartida.UseVisualStyleBackColor = true;
            this.ListarPartida.Click += new System.EventHandler(this.ListarPartida_Click);
            // 
            // RetornoListaPartidas
            // 
            this.RetornoListaPartidas.Location = new System.Drawing.Point(12, 46);
            this.RetornoListaPartidas.Multiline = true;
            this.RetornoListaPartidas.Name = "RetornoListaPartidas";
            this.RetornoListaPartidas.Size = new System.Drawing.Size(171, 249);
            this.RetornoListaPartidas.TabIndex = 1;
            this.RetornoListaPartidas.TextChanged += new System.EventHandler(this.RetornoListaPartidas_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(201, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(161, 251);
            this.listBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.RetornoListaPartidas);
            this.Controls.Add(this.ListarPartida);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ListarPartida;
        private System.Windows.Forms.TextBox RetornoListaPartidas;
        private System.Windows.Forms.ListBox listBox1;
    }
}

