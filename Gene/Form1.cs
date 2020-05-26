using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Gene
{
    public partial class Login : Form
    {

        public String login = "devtec";

        public String senha = "12345";

        Thread homepage;

        public Login()
        {
            InitializeComponent();
        }

        private void btn_Acessar_Click(object sender, EventArgs e)
        {

            if(tb_Login.Text.Equals(this.login) && tb_Senha.Text.Equals(this.senha))
            {

                MessageBox.Show("Bem vindo DevTec!");

                this.Close();

                homepage = new Thread(iniciarHomepage);

                homepage.SetApartmentState(ApartmentState.STA);

                homepage.Start();

            }
            else
            {

                MessageBox.Show("Login ou senha incorretos!");

            }


        }

        private void iniciarHomepage()
        {

            Application.Run(new Homepage());

        }
    }
}
