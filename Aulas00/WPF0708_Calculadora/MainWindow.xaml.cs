using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF0708_Calculadora
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        //Toda vez que selecionar algo, vai validar se é operador para limpar a tela
        bool clica_operacao = false;
        bool mostra_calculo = false;
        double num1 = 0;
        double calculo = 0;
        string qual_operacao= "";


        //Função que válida se foi digitado numero ou operador
        public void ler_num(double Num_Lido)
        {
            if (clica_operacao == false)

                Visor.Text += Num_Lido;

            else Visor.Text = Num_Lido.ToString();

            //Depois de uma operação ele valida e deixa aparecer mais numeros
            clica_operacao = false;


        }

        //Limpar a tela apos escolher operação
        public void Botao_Operacao (string Qual_operacao)
        {

            clica_operacao = true;
            if (mostra_calculo == true)
                Calcula_Apresenta();

            //Determino que aqui irá puxar o operar definido em cada click 
            this.qual_operacao = Qual_operacao;
            num1 = double.Parse(Visor.Text);
            mostra_calculo = true;
        }
        
        public void Calcula_Apresenta()
        {
            if (qual_operacao == "+")
                calculo = num1 + double.Parse(Visor.Text);
            if (qual_operacao == "-")
                calculo = num1 - double.Parse(Visor.Text);
            if (qual_operacao == "/")
                calculo = num1 / double.Parse(Visor.Text);
            if (qual_operacao == "*")
                calculo = num1 * double.Parse(Visor.Text);
            if (qual_operacao == "√")
                calculo = Math.Sqrt(double.Parse(Visor.Text));
            //if (qual_operacao == "%")
            //calculo = num1 % double.Parse(Visor.Text);

            Visor.Text = calculo.ToString();

        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Numero0_Click(object sender, RoutedEventArgs e)
        {
            ler_num(0);
        }

        private void Numero1_Click(object sender, RoutedEventArgs e)
        {
            ler_num(1);
        }

        private void Numero2_Click(object sender, RoutedEventArgs e)
        {
            ler_num(2);
        }

        private void Numero3_Click(object sender, RoutedEventArgs e)
        {
            ler_num(3);
        }

        private void Numero4_Click(object sender, RoutedEventArgs e)
        {
            ler_num(4);
        }

        private void Numero5_Click(object sender, RoutedEventArgs e)
        {
            ler_num(5);
        }

        private void Numero6_Click(object sender, RoutedEventArgs e)
        {
            ler_num(6);
        }

        private void Numero7_Click(object sender, RoutedEventArgs e)
        {
            ler_num(7);
        }

        private void Numero8_Click(object sender, RoutedEventArgs e)
        {
            ler_num(8);
        }

        private void Numero9_Click(object sender, RoutedEventArgs e)
        {
            ler_num(9);
        }

        private void Soma_Click(object sender, RoutedEventArgs e)
        {
            Botao_Operacao("+");
        }

        private void Subtrair_Click(object sender, RoutedEventArgs e)
        {
            Botao_Operacao("-");
        }

        private void Divisão_Click(object sender, RoutedEventArgs e)
        {
            Botao_Operacao("/");
        }

        private void Multiplicação_Click(object sender, RoutedEventArgs e)
        {
            Botao_Operacao("*");
        }

        private void RaizQuadrada_Click(object sender, RoutedEventArgs e)
        {
            Botao_Operacao("√"); 
        }

        private void Potencia_Click(object sender, RoutedEventArgs e)
        {
            Botao_Operacao("%");
        }

        private void ApagaDig_Click(object sender, RoutedEventArgs e)
        {
            int tamanho = Visor.Text.Length;
            if (tamanho > 0)
                Visor.Text = Visor.Text.Substring(0, tamanho - 1);
        }

        private void LimpaCampo_Click(object sender, RoutedEventArgs e)
        {
            Visor.Text = "";
        }

        private void Pontual_Click(object sender, RoutedEventArgs e)
        {
            double virg;
            virg = Visor.Text.IndexOf(",");   //Procura por todo visor o caracter "," e se achar
            if (virg >= 0)                    //retorna a void, ou seja, faz nada
                return;
            else                           //se não achar, a vírgula é inserida
                Visor.Text += ",";

         
        }

        private void Resultado_Click(object sender, RoutedEventArgs e)
        {
            Calcula_Apresenta();
            mostra_calculo = false;
                
        }
    }
}
