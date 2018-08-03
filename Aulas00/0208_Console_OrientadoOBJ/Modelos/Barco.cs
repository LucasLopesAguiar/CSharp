using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0208_Console_OrientadoOBJ.Modelos
{
    class Barco : Veiculo, IMotorizado

    {
        public int Velocidade { get; set; }
        public void Acelerar()
        {
            Console.WriteLine("Barco: Bomba no manete");
            Velocidade -= 10;
        }

        public void Frenar()
        {
            Console.WriteLine("Barco: Bombando no manete");
            Velocidade -= 10;
        }
    }
}
