using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto11._4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int acumulado = 0;
                int numero;

                do
                {
                    Console.Write("Ingrese un numero diferente a 9999 para seguir la suma y no terminar: ");
                    numero = int.Parse(Console.ReadLine());
                    if(numero != 9999) 
                    {
                        acumulado = acumulado + numero;
                    }
                   
                } while (numero != 9999);
                Console.Write("El acumulado es "+acumulado);

                if (acumulado == 0)
                {
                    Console.WriteLine(" y es igual a 0.");
                }
                else if(acumulado > 0)
                {
                    Console.WriteLine(" y es mayor que 0.");
                }
                else
                {
                    Console.WriteLine(" y es menor que 0.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ha introducido un dato invalido.");                
            }
            Console.ReadKey();
        }
    }
}
