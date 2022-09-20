using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string numero = "";
        Canditado alguem;
        Canditado[] lista = new Canditado[4];
        // int branco = 0, nulo = 0;

        private void insereCandidato()
        {
            alguem = new Canditado();
            alguem.Numero = 12;
            alguem.Nome = "Antônio Silva";
            alguem.Turma = "1º ADS";
            alguem.Foto = "anonio.jpg";
            lista[0] = alguem;

            alguem = new Canditado();
            alguem.Numero = 23;
            alguem.Nome = "Joana Lima";
            alguem.Turma = "1º ADS";
            alguem.Foto = "joana.jpg";
            lista[1] = alguem;

            alguem = new Canditado();
            alguem.Numero = 34;
            alguem.Nome = "Frederico Ferreira";
            alguem.Turma = "1º ADS";
            alguem.Foto = "frederico.jpg";
            lista[2] = alguem;

            alguem = new Canditado();
            alguem.Numero = 45;
            alguem.Nome = "Vivian Almeida";
            alguem.Turma = "1º ADS";
            alguem.Foto = "vivian.jpg";
            lista[3] = alguem;

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            txtNum1.Enabled = false; // desabilita o campo texto
            txtNum2.Enabled = false; 
            btnConfirmar.Enabled = false; // desabilia o botão confirma
            lblMensagem.Visible = false; // panel ocultada
            insereCandidato();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Preenche("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Preenche("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Preenche("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Preenche("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Preenche("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Preenche("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Preenche("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Preenche("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Preenche("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Preenche("0");
        }

        private void Preenche(string n)
        {
            if (numero.Length == 0)
            {
                txtNum1.Text = n;
                numero += n; // numero=numero+n
            }
            else
            {
                txtNum2.Text = n;
                numero += n; // numero=numero+n
                for (int i=0; i < 4; i++)
                {
                    if(Convert.ToInt32(numero) == lista[i].Numero)
                    {
                        lblCandidato.Text = lista[i].Nome;
                        lblTurma.Text=lista[i].Turma;
                        pxFoto.Image = Image.FromFile(@"" + lista[i].Foto); // caminho da foto
                        i=3;

                    }
                    else
                    {
                        lblCandidato.Text = "VOTO NULO";
                    }
                    lblMensagem.Visible = true;
                    btnConfirmar.Enabled = true;
                }
            }
        }
    }
}
