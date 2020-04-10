using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPintura
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO ARQUIVO .CS É UMA CLASSE NO C#

            //PROBLEMA:
            //ESCREVER UM PROGRAMA QUE CALCULA A AREA A SER PINTADA.
            //FORMULAS MATEMATICAS: CALCULAR AREA DAS PAREDES DE UM COMODO: 2 x (LARGURA + PROFUNDIDADE) x ALTURA;
            //CALCULAR AREA DO TETO DESSE COMODO: LARGURA x PROFUNDIDADE
            //LITRAGEM: areaParedes + areaTeto / r_fornecedor

            //INPUT USUARIO
            Console.WriteLine("Largura: ");
            double largura = double.Parse(Console.ReadLine());
            Console.WriteLine("Profundidade: ");
            double profundidade = double.Parse(Console.ReadLine());
            Console.WriteLine("Altura: ");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Rendimento Fornecedor: ");
            double r_fornecedor = double.Parse(Console.ReadLine());

            //DEFININDO CONSTATANTES(ALGO QUE EU NAO SABIA ANTES DESSE CODIGO),
            //AS CONSTANTES SAO VALORES QUE NAO MUDAM E SAO DECLARADOS PARA MELHOR COMPILACAO DO CODIGO:
            const double DoisFormula = 2; //CONSTANTES SEMPRE INICIAM COM LETRA MAIUSCULA
                                          //O USO DO '2' REFERE-SE A FORMULA PARA CALCULA DAS PAREDES(SENDO LARGURA+PROFUNDIDADE E LARGURA+PROF)
                                          //CONSTANTE DECLARADA, NAO É POSSIVEL MAIS ALTERAR DURANTE O RESTO DO CODIGO E É POR ISSO E OUTRAS IDEIAS QUE CONSTANTE É IMPORTANTE

            //Instaciando a classe(Objeto 'Calculadora') na 'Program' para uso de seus atributos.
            Calculadora calculadora = new Calculadora();

            //METODO/CALCULO
            //calculadora.areaParedes = calculadora.Calcular_areaParedes(largura, profundidade, altura, Convert.ToInt32(DoisFormula)); //METODO/CALCULA AREA PAREDE

            //RESULTADO/OUTPUT USUARIO
            Console.WriteLine("Área paredes: " + calculadora.Calcular_areaParedes(largura, profundidade, altura, Convert.ToInt32(DoisFormula)));
            //calculadora.areaTeto = (largura * profundidade); //METODO/CALCULA AREA TETO
            Console.WriteLine("Área teto: " + calculadora.Calcular_areaTeto(largura, profundidade));
            //calculadora.calcLitragem = (calculadora.areaTeto + calculadora.areaParedes) / r_fornecedor; //METODO/CALCULA LITRAGEM
            Console.WriteLine("Litragem: " + calculadora.Calcular_calcLitragem(//largura, profundidade, altura, Convert.ToInt32(DoisFormula), 
                r_fornecedor) + " Litros");

            Console.ReadLine();
        }
    }
}
