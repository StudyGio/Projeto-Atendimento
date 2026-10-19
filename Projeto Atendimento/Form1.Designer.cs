namespace ProjetoAtendimento
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
            this.btnGerar = new System.Windows.Forms.Button();
            this.lstSenhas = new System.Windows.Forms.ListBox();
            this.btnListarSenhas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGuiche = new System.Windows.Forms.TextBox();
            this.btnAdicionarGuiche = new System.Windows.Forms.Button();
            this.btnChamar = new System.Windows.Forms.Button();
            this.lstAtendimentos = new System.Windows.Forms.ListBox();
            this.btnListarAtendimentos = new System.Windows.Forms.Button();
            this.lblQtdeGuiches = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(47, 47);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 23);
            this.btnGerar.TabIndex = 0;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            // 
            // lstSenhas
            // 
            this.lstSenhas.FormattingEnabled = true;
            this.lstSenhas.ItemHeight = 16;
            this.lstSenhas.Location = new System.Drawing.Point(24, 94);
            this.lstSenhas.Name = "lstSenhas";
            this.lstSenhas.Size = new System.Drawing.Size(120, 84);
            this.lstSenhas.TabIndex = 1;
            // 
            // btnListarSenhas
            // 
            this.btnListarSenhas.Location = new System.Drawing.Point(47, 205);
            this.btnListarSenhas.Name = "btnListarSenhas";
            this.btnListarSenhas.Size = new System.Drawing.Size(75, 23);
            this.btnListarSenhas.TabIndex = 2;
            this.btnListarSenhas.Text = "Listar Senhas";
            this.btnListarSenhas.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Guichê";
            // 
            // txtGuiche
            // 
            this.txtGuiche.Location = new System.Drawing.Point(386, 94);
            this.txtGuiche.Name = "txtGuiche";
            this.txtGuiche.Size = new System.Drawing.Size(100, 22);
            this.txtGuiche.TabIndex = 4;
            // 
            // btnAdicionarGuiche
            // 
            this.btnAdicionarGuiche.Location = new System.Drawing.Point(400, 143);
            this.btnAdicionarGuiche.Name = "btnAdicionarGuiche";
            this.btnAdicionarGuiche.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarGuiche.TabIndex = 5;
            this.btnAdicionarGuiche.Text = "Adicionar";
            this.btnAdicionarGuiche.UseVisualStyleBackColor = true;
            // 
            // btnChamar
            // 
            this.btnChamar.Location = new System.Drawing.Point(400, 190);
            this.btnChamar.Name = "btnChamar";
            this.btnChamar.Size = new System.Drawing.Size(75, 23);
            this.btnChamar.TabIndex = 6;
            this.btnChamar.Text = "Chamar";
            this.btnChamar.UseVisualStyleBackColor = true;
            // 
            // lstAtendimentos
            // 
            this.lstAtendimentos.FormattingEnabled = true;
            this.lstAtendimentos.ItemHeight = 16;
            this.lstAtendimentos.Location = new System.Drawing.Point(386, 235);
            this.lstAtendimentos.Name = "lstAtendimentos";
            this.lstAtendimentos.Size = new System.Drawing.Size(120, 84);
            this.lstAtendimentos.TabIndex = 7;
            // 
            // btnListarAtendimentos
            // 
            this.btnListarAtendimentos.Location = new System.Drawing.Point(400, 339);
            this.btnListarAtendimentos.Name = "btnListarAtendimentos";
            this.btnListarAtendimentos.Size = new System.Drawing.Size(75, 23);
            this.btnListarAtendimentos.TabIndex = 8;
            this.btnListarAtendimentos.Text = "Listar Atendimentos";
            this.btnListarAtendimentos.UseVisualStyleBackColor = true;
            // 
            // lblQtdeGuiches
            // 
            this.lblQtdeGuiches.AutoSize = true;
            this.lblQtdeGuiches.Location = new System.Drawing.Point(368, 387);
            this.lblQtdeGuiches.Name = "lblQtdeGuiches";
            this.lblQtdeGuiches.Size = new System.Drawing.Size(148, 16);
            this.lblQtdeGuiches.TabIndex = 9;
            this.lblQtdeGuiches.Text = "Guichês cadastrados: 0";
            this.lblQtdeGuiches.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblQtdeGuiches);
            this.Controls.Add(this.btnListarAtendimentos);
            this.Controls.Add(this.lstAtendimentos);
            this.Controls.Add(this.btnChamar);
            this.Controls.Add(this.btnAdicionarGuiche);
            this.Controls.Add(this.txtGuiche);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListarSenhas);
            this.Controls.Add(this.lstSenhas);
            this.Controls.Add(this.btnGerar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.ListBox lstSenhas;
        private System.Windows.Forms.Button btnListarSenhas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGuiche;
        private System.Windows.Forms.Button btnAdicionarGuiche;
        private System.Windows.Forms.Button btnChamar;
        private System.Windows.Forms.ListBox lstAtendimentos;
        private System.Windows.Forms.Button btnListarAtendimentos;
        private System.Windows.Forms.Label lblQtdeGuiches;
    }
}

