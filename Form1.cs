using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum Operacoes
        {
            Soma,
            Subtrai,
            Multiplica,
            Divide,
            Nenhuma
        }

        static Operacoes ultimaOperacao = Operacoes.Nenhuma;

        private void buttonCansel_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Clear();
            ultimaOperacao = Operacoes.Nenhuma;
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacoes.Nenhuma)
            {
                ultimaOperacao = Operacoes.Subtrai;
            }
            else
            {
                FazerCalculo(ultimaOperacao);
            }
            textBoxDisplay.Text += (sender as Button).Text;
        }

        private void buttonSoma_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacoes.Nenhuma) 
            {
                ultimaOperacao = Operacoes.Soma;
            }
            else
            {
                FazerCalculo(ultimaOperacao);
            }
            textBoxDisplay.Text += (sender as Button).Text;
        }

        private void FazerCalculo(Operacoes ultimaOperacao)
        {
            List<double> ListaDeNumeros = new List<double>();

            switch (ultimaOperacao)
            {
                case Operacoes.Soma: 
                    ListaDeNumeros = textBoxDisplay.Text.Split('+').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (ListaDeNumeros[0] + ListaDeNumeros[1]).ToString();
                    break;
                case Operacoes.Subtrai:
                    ListaDeNumeros = textBoxDisplay.Text.Split('-').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (ListaDeNumeros[0] - ListaDeNumeros[1]).ToString();
                    break;
                case Operacoes.Multiplica:
                    ListaDeNumeros = textBoxDisplay.Text.Split('×').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (ListaDeNumeros[0] * ListaDeNumeros[1]).ToString();
                    break;
                case Operacoes.Divide:
                    try
                    {
                        ListaDeNumeros = textBoxDisplay.Text.Split('÷').Select(double.Parse).ToList();
                        textBoxDisplay.Text = (ListaDeNumeros[0] / ListaDeNumeros[1]).ToString();
                    }
                    catch (DivideByZeroException) 
                    {
                        textBoxDisplay.Text = "Divisão por zero.";
                    }
                    break;
                case Operacoes.Nenhuma:
                    break;
                default:
                    break;
            }
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacoes.Nenhuma)
            {
                ultimaOperacao = Operacoes.Multiplica;
            }
            else
            {
                FazerCalculo(ultimaOperacao);
            }
            textBoxDisplay.Text += (sender as Button).Text;
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacoes.Nenhuma)
            {
                ultimaOperacao = Operacoes.Divide;
            }
            else
            {
                FazerCalculo(ultimaOperacao);
            }
            textBoxDisplay.Text += (sender as Button).Text;
        }

        private void buttonVirg_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text.Contains(","))
            {
                return;
            }
            else
            {
                textBoxDisplay.Text = textBoxDisplay.Text + ",";
            }
        }

        private void buttonNum_Click(object sender, EventArgs e)
        {
            //textBoxDisplay.Text = textBoxDisplay.Text + "0";
            textBoxDisplay.Text += (sender as Button).Text;
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxDisplay.Text);
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text.Length > 0)
            {
                textBoxDisplay.Text = textBoxDisplay.Text.Remove(textBoxDisplay.Text.Length - 1, 1);
            }
            else
            {
                return;
            }
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao != Operacoes.Nenhuma)
            {
                FazerCalculo(ultimaOperacao);
            }
            ultimaOperacao = Operacoes.Nenhuma;
        }

        private void buttonPi_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + "3,14";
        }

        private void buttonParen_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text.Contains("("))
            {
                textBoxDisplay.Text = textBoxDisplay.Text + ")";
            }
            else
            {
                textBoxDisplay.Text = textBoxDisplay.Text + "(";
            }
        }
    }
}
