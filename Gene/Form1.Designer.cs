namespace Gene
{
    partial class Homepage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_NovoChamado = new System.Windows.Forms.Button();
            this.btn_ConsutarChamado = new System.Windows.Forms.Button();
            this.btn_AtualizarChamado = new System.Windows.Forms.Button();
            this.btn_AtualizarCadastros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_NovoChamado
            // 
            this.btn_NovoChamado.Location = new System.Drawing.Point(115, 59);
            this.btn_NovoChamado.Name = "btn_NovoChamado";
            this.btn_NovoChamado.Size = new System.Drawing.Size(163, 71);
            this.btn_NovoChamado.TabIndex = 0;
            this.btn_NovoChamado.Text = "Novo Chamado";
            this.btn_NovoChamado.UseVisualStyleBackColor = true;
            // 
            // btn_ConsutarChamado
            // 
            this.btn_ConsutarChamado.Location = new System.Drawing.Point(597, 97);
            this.btn_ConsutarChamado.Name = "btn_ConsutarChamado";
            this.btn_ConsutarChamado.Size = new System.Drawing.Size(163, 71);
            this.btn_ConsutarChamado.TabIndex = 1;
            this.btn_ConsutarChamado.Text = "Consultar Chamado";
            this.btn_ConsutarChamado.UseVisualStyleBackColor = true;
            // 
            // btn_AtualizarChamado
            // 
            this.btn_AtualizarChamado.Location = new System.Drawing.Point(115, 233);
            this.btn_AtualizarChamado.Name = "btn_AtualizarChamado";
            this.btn_AtualizarChamado.Size = new System.Drawing.Size(163, 71);
            this.btn_AtualizarChamado.TabIndex = 2;
            this.btn_AtualizarChamado.Text = "Atualizar Chamado";
            this.btn_AtualizarChamado.UseVisualStyleBackColor = true;
            // 
            // btn_AtualizarCadastros
            // 
            this.btn_AtualizarCadastros.Location = new System.Drawing.Point(597, 279);
            this.btn_AtualizarCadastros.Name = "btn_AtualizarCadastros";
            this.btn_AtualizarCadastros.Size = new System.Drawing.Size(163, 71);
            this.btn_AtualizarCadastros.TabIndex = 3;
            this.btn_AtualizarCadastros.Text = "Atualizar Cadastros";
            this.btn_AtualizarCadastros.UseVisualStyleBackColor = true;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 450);
            this.Controls.Add(this.btn_AtualizarCadastros);
            this.Controls.Add(this.btn_AtualizarChamado);
            this.Controls.Add(this.btn_ConsutarChamado);
            this.Controls.Add(this.btn_NovoChamado);
            this.Name = "Homepage";
            this.Text = "Gene - Gerenciador de Demandas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_NovoChamado;
        private System.Windows.Forms.Button btn_ConsutarChamado;
        private System.Windows.Forms.Button btn_AtualizarChamado;
        private System.Windows.Forms.Button btn_AtualizarCadastros;
    }
}

