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

        //Função que válida se foi digitado numero ou operador
        public void ler_num(int Num_Lido)
        {
            if (clica_operacao == false)

                Visor.Text += Num_Lido;

            else Visor.Text = Num_Lido.ToString(); 


        }
        

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
