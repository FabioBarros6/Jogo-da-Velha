using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;

namespace Jogo_da_Velha
{
    public partial class Form2 : Form
    {
        public object ToolStripeMenu { get; private set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            var game = new Form1(txtJog1.Text, txtJog2.Text);
            game.ShowDialog();


        }

        private void txtJog2_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ToolStripMenuItem menu = (ToolStripMenuItem)sender;

            switch (menu.Text)

            {
                case "Sobre":
                    string info = "Jogo da Velha \n Desenvolvimento by SITI \n 2018";
                    MessageBox.Show(info); break;

                case "Sair": Application.Exit(); break;
            }


        }

    }

}
       