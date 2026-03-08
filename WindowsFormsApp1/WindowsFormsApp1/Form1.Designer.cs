namespace WindowsFormsApp1
{
    partial class lstBebidas
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
            this.btnPedido = new System.Windows.Forms.Button();
            this.cboComida = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lsbBebidas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnPedido
            // 
            this.btnPedido.Location = new System.Drawing.Point(132, 215);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(75, 23);
            this.btnPedido.TabIndex = 0;
            this.btnPedido.Text = "finalizar pedido";
            this.btnPedido.UseVisualStyleBackColor = true;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // cboComida
            // 
            this.cboComida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboComida.FormattingEnabled = true;
            this.cboComida.Items.AddRange(new object[] {
            "misto quente",
            "suco de laranja ",
            "pão na chapa"});
            this.cboComida.Location = new System.Drawing.Point(132, 35);
            this.cboComida.Name = "cboComida";
            this.cboComida.Size = new System.Drawing.Size(121, 21);
            this.cboComida.TabIndex = 1;
            this.cboComida.SelectedIndexChanged += new System.EventHandler(this.cboComida_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(468, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "oq voce vai comer ?";
            // 
            // lsbBebidas
            // 
            this.lsbBebidas.FormattingEnabled = true;
            this.lsbBebidas.Location = new System.Drawing.Point(132, 62);
            this.lsbBebidas.Name = "lsbBebidas";
            this.lsbBebidas.Size = new System.Drawing.Size(120, 95);
            this.lsbBebidas.TabIndex = 4;
            // 
            // lstBebidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 319);
            this.Controls.Add(this.lsbBebidas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cboComida);
            this.Controls.Add(this.btnPedido);
            this.Name = "lstBebidas";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.ComboBox cboComida;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsbBebidas;
    }
}

