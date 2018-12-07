using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Jogo_da_Velha
{
    public partial class Form1 : Form
    {
        int pontosX = 0, pontosO = 0, empt = 0, rodadas = 0;
        bool turno = true, finalJogo = false;
        string[] texto = new string[9];

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            btn.Text = "";
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";

            rodadas = 0;
            finalJogo = false;
            for (int i = 0; i <9; i++)
            {
                texto[i] = "";
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        public Form1 (string jog1, string jog2)

        {
            InitializeComponent();
            lb_Jog1.Text = jog1;
            lb_Jog2.Text = jog2;



        }


        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int buttonIndex = btn.TabIndex;

            if (btn.Text == "" && finalJogo == false)
            {
                if (turno)
                {
                    btn.Text = "X";
                    texto[buttonIndex] = btn.Text;
                    rodadas++;
                    turno = !turno;
                    Checar(1);
                }
                else
                {
                    btn.Text = "O";
                    texto[buttonIndex] = btn.Text;
                    rodadas++;
                    turno = !turno;
                    Checar(2);
                }
            }
 
            
        }

        void Checar(int ChecarJogador)
        {
            string sup = "";

            if (ChecarJogador == 1)
            {
                sup = "X";
            }
            else
            {
                sup = "O";
            }

            for (int horizontal = 0; horizontal < 8; horizontal += 3)
            {
                if (sup == texto[horizontal])
                {

                    // verificação horizontal

                    if (texto[horizontal] == texto[horizontal + 1] && texto[horizontal] == texto[horizontal + 2])
                    {
                        Vencedor(ChecarJogador);
                        return;
                    } // final da checagem horizontal 
                }
            } // final do for horizontal

            // verificação vertial

            for (int vertical = 0; vertical < 3; vertical++)
            {
                if (sup == texto[vertical])
                {

                    // inicio verificação vertical

                    if (texto[vertical] == texto[vertical + 3] && texto[vertical] == texto[vertical + 6])
                    {
                        Vencedor(ChecarJogador);
                        return;
                    } // final da checagem vertial 
                }
            } // final do for vertical

            // verificação das diagonais

            if (texto[0] == sup) //sup1
            {
                // diagonal 1
                if (texto[0] == texto[4] && texto[0] == texto[8])
                {
                    Vencedor(ChecarJogador);
                    return;
                } // final verificação diagonal1

            } //final sup1

            if (texto[2] == sup) // sup2
            {
                // diagonal 2
                if (texto[2] == texto[4] && texto[2] == texto[6])
                {
                    Vencedor(ChecarJogador);
                    return;
                } // final diagonal 2
            } // final sup2

            if (rodadas == 9 && finalJogo == false)
            {
                empt++;
                Empates.Text = Convert.ToString(empt);
                MessageBox.Show("Deu Velha !");
                finalJogo = true;
                return;
            }

        } // final Checar

        void Vencedor (int JogVencedor)
        {
            finalJogo = true;

            if (JogVencedor == 1)
            {
                pontosX++;
                xPontos.Text = Convert.ToString(pontosX);
                MessageBox.Show(lb_Jog1.Text, "Vencedor !");
                turno = true;
            }
            else
            {
                pontosO++;
                oPontos.Text = Convert.ToString(pontosO);
                MessageBox.Show(lb_Jog2.Text, "Vencedor !");
                turno = false;
            }
        }
    }

}
