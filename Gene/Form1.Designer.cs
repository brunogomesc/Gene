namespace Gene
{
    partial class Login
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
            this.btn_Acessar = new System.Windows.Forms.Button();
            this.lb_Login = new System.Windows.Forms.Label();
            this.lb_Senha = new System.Windows.Forms.Label();
            this.tb_Login = new System.Windows.Forms.TextBox();
            this.tb_Senha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Acessar
            // 
            this.btn_Acessar.Location = new System.Drawing.Point(334, 320);
            this.btn_Acessar.Name = "btn_Acessar";
            this.btn_Acessar.Size = new System.Drawing.Size(163, 71);
            this.btn_Acessar.TabIndex = 0;
            this.btn_Acessar.Text = "Conectar";
            this.btn_Acessar.UseVisualStyleBackColor = true;
            this.btn_Acessar.Click += new System.EventHandler(this.btn_Acessar_Click);
            // 
            // lb_Login
            // 
            this.lb_Login.AutoSize = true;
            this.lb_Login.Location = new System.Drawing.Point(144, 117);
            this.lb_Login.Name = "lb_Login";
            this.lb_Login.Size = new System.Drawing.Size(48, 20);
            this.lb_Login.TabIndex = 1;
            this.lb_Login.Text = "Login";
            // 
            // lb_Senha
            // 
            this.lb_Senha.AutoSize = true;
            this.lb_Senha.Location = new System.Drawing.Point(144, 198);
            this.lb_Senha.Name = "lb_Senha";
            this.lb_Senha.Size = new System.Drawing.Size(64, 20);
            this.lb_Senha.TabIndex = 2;
            this.lb_Senha.Text = "Senha: ";
            // 
            // tb_Login
            // 
            this.tb_Login.Location = new System.Drawing.Point(236, 117);
            this.tb_Login.Name = "tb_Login";
            this.tb_Login.Size = new System.Drawing.Size(172, 26);
            this.tb_Login.TabIndex = 3;
            // 
            // tb_Senha
            // 
            this.tb_Senha.Location = new System.Drawing.Point(236, 195);
            this.tb_Senha.Name = "tb_Senha";
            this.tb_Senha.Size = new System.Drawing.Size(172, 26);
            this.tb_Senha.TabIndex = 4;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.tb_Senha);
            this.Controls.Add(this.tb_Login);
            this.Controls.Add(this.lb_Senha);
            this.Controls.Add(this.lb_Login);
            this.Controls.Add(this.btn_Acessar);
            this.Name = "Login";
            this.Text = "Gene - Gerenciador de Demandas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Acessar;
        private System.Windows.Forms.Label lb_Login;
        private System.Windows.Forms.Label lb_Senha;
        private System.Windows.Forms.TextBox tb_Login;
        private System.Windows.Forms.TextBox tb_Senha;
    }
}

