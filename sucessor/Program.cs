using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sucessor
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, pi=3.14;
            double altura, volume;
            
            Console.WriteLine("informe a altura");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("informe o raio");
            raio = double.Parse(Console.ReadLine());


            volume = (raio * raio) * altura * pi;

            Console.WriteLine("o volume do cilindro é:");
            Console.WriteLine(volume);

            Console.ReadKey();

            }
        }
    }

