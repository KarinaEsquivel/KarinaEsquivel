using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karinaesquivel_FP2
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            
            
            //Declaracion de variables 
            string nombredelcliente;
            double galonesdegasolina = 22.90;
            double litrosdegasolina = 3.758;
            double totaldepago;

            // Customizado de consola
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;





            Console.WriteLine("nombre delcliente");
            nombredelcliente = Convert.ToString(Console.ReadLine());

            Console.WriteLine("cuantos litros compro de gasolina?");
            litrosdegasolina = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("galones de gasolina");
            galonesdegasolina = Convert.ToDouble(Console.ReadLine());

            totaldepago = litrosdegasolina * galonesdegasolina;





        }
    }

