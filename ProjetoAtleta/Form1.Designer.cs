namespace ProjetoAtleta
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
            this.btn_resultado = new System.Windows.Forms.Button();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_altura = new System.Windows.Forms.Label();
            this.lbl_peso = new System.Windows.Forms.Label();
            this.lbl_idade = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_altura = new System.Windows.Forms.TextBox();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.txt_idade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_resultado
            // 
            this.btn_resultado.Location = new System.Drawing.Point(29, 198);
            this.btn_resultado.Name = "btn_resultado";
            this.btn_resultado.Size = new System.Drawing.Size(205, 36);
            this.btn_resultado.TabIndex = 0;
            this.btn_resultado.Text = "Resultado";
            this.btn_resultado.UseVisualStyleBackColor = true;
            this.btn_resultado.Click += new System.EventHandler(this.btn_resultado_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(26, 36);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(33, 13);
            this.lbl_nome.TabIndex = 1;
            this.lbl_nome.Text = "nome";
            // 
            // lbl_altura
            // 
            this.lbl_altura.AutoSize = true;
            this.lbl_altura.Location = new System.Drawing.Point(26, 72);
            this.lbl_altura.Name = "lbl_altura";
            this.lbl_altura.Size = new System.Drawing.Size(33, 13);
            this.lbl_altura.TabIndex = 2;
            this.lbl_altura.Text = "altura";
            // 
            // lbl_peso
            // 
            this.lbl_peso.AutoSize = true;
            this.lbl_peso.Location = new System.Drawing.Point(26, 114);
            this.lbl_peso.Name = "lbl_peso";
            this.lbl_peso.Size = new System.Drawing.Size(30, 13);
            this.lbl_peso.TabIndex = 3;
            this.lbl_peso.Text = "peso";
            // 
            // lbl_idade
            // 
            this.lbl_idade.AutoSize = true;
            this.lbl_idade.Location = new System.Drawing.Point(26, 154);
            this.lbl_idade.Name = "lbl_idade";
            this.lbl_idade.Size = new System.Drawing.Size(33, 13);
            this.lbl_idade.TabIndex = 4;
            this.lbl_idade.Text = "idade";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(85, 36);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(149, 20);
            this.txt_nome.TabIndex = 5;
            // 
            // txt_altura
            // 
            this.txt_altura.Location = new System.Drawing.Point(85, 72);
            this.txt_altura.Name = "txt_altura";
            this.txt_altura.Size = new System.Drawing.Size(149, 20);
            this.txt_altura.TabIndex = 6;
            // 
            // txt_peso
            // 
            this.txt_peso.Location = new System.Drawing.Point(85, 114);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(149, 20);
            this.txt_peso.TabIndex = 7;
            // 
            // txt_idade
            // 
            this.txt_idade.Location = new System.Drawing.Point(85, 154);
            this.txt_idade.Name = "txt_idade";
            this.txt_idade.Size = new System.Drawing.Size(149, 20);
            this.txt_idade.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 257);
            this.Controls.Add(this.txt_idade);
            this.Controls.Add(this.txt_peso);
            this.Controls.Add(this.txt_altura);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_idade);
            this.Controls.Add(this.lbl_peso);
            this.Controls.Add(this.lbl_altura);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.btn_resultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_resultado;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_altura;
        private System.Windows.Forms.Label lbl_peso;
        private System.Windows.Forms.Label lbl_idade;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_altura;
        private System.Windows.Forms.TextBox txt_peso;
        private System.Windows.Forms.TextBox txt_idade;
    }
}

