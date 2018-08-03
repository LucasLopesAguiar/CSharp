using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0208_Console_OrientadoOBJ.Modelos
{
    interface IMotorizado
    {
        int Velocidade { get; set; }
        void Acelerar();
        void Frenar();


    }
}
