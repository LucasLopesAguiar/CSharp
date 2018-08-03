using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0208_Console_OrientadoOBJ.Modelos
{
    class Carro : Veiculo, IMotorizado
    {
        public int Velocidade { get; set; }
        public void Acelerar()
        {
            Console.WriteLine("Carro: Pisando no pedal...");
            Velocidade += 7;
        }

        public void Frenar()
        {
            Console.WriteLine("Carro: Pisando no Freio...");
            Velocidade -= 7;
        }
    }
}
