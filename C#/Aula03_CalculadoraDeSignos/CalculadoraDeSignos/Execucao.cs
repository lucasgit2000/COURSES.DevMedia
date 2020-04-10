using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeSignos
{
    class Execucao
    {
        static void Main(string[] args)
        {
            string dia;
            string mes;
            
            Console.WriteLine("Digite o dia do nascimento: ");
            dia = (Console.ReadLine());
            Console.WriteLine("Digite o mes do nascimento: ");
            mes = (Console.ReadLine());

            InterpretadorDeSignos interpretador = new InterpretadorDeSignos();

            int diaInt=0;
            int mesInt=0;

            try
            {
                diaInt = Convert.ToInt32(dia);
                mesInt = Convert.ToInt32(mes);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                Environment.Exit(1);
            }

            signos1 signo = (interpretador.lol(diaInt, mesInt));

            if (signo != null)
            {
                Console.WriteLine(signo.nome + ": " + signo.caracteristicas);
            }

            else
            {
                Console.WriteLine("Não foi possivel interpretar o seu signo. Verifique se o mês ou dia está correto.");
            }
            
            Console.ReadLine();
        }
    }
}
