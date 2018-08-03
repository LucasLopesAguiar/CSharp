﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0208_Console_OrientadoOBJ.Modelos
{
    class Moto : Veiculo, IMotorizado

    {
        public int Velocidade { get; set; }
        public void Acelerar()
        {
            Console.WriteLine("Moto: Bomba na manopla do acelerador");
            Velocidade += 5;
        }

        public void Frenar()
        {
            Console.WriteLine("Moto: Bomba no manopla do freio");
            Velocidade -= 5;
        }
    }
}
