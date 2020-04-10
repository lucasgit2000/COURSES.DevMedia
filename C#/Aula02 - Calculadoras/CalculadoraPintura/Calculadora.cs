using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPintura
{
    class Calculadora
    {
        //Toda Classe Deve Começar Com Letra Maiuscula.

        //Atributos(Variaveis a serem declaradas do objeto 'Calculadora').
        private double areaParedes;
        private double areaTeto;
        private double calcLitragem;
        //OBS: para fins de evitar descuidos na hora da compilacao do codigo sendo esse descuido gerado pela mudanca dos valores dos atributos acima
        //, é recomendado entao que fique em private, sendo impossivel mudar o valor das variaveis na classe de execucao do codigo 'Program'.

        //Metodos do Objeto(Acoes a serem executadas pelo objeto/classe 'Calculadora).
        public double Calcular_areaParedes(double largura, double profundidade, double altura, int DoisFormula)
        {
            areaParedes = (DoisFormula * (largura + profundidade) * altura);
            return areaParedes;
        }

        public double Calcular_areaTeto(double largura, double profundidade)
        {
            areaTeto = largura * profundidade;
            return areaTeto;
        }

        public double Calcular_calcLitragem(//double largura, double profundidade, double altura, int DoisFormula, 
            double r_fornecedor)
        {
            //calcLitragem = ((DoisFormula * (largura + profundidade) * altura) + (largura * profundidade)) / r_fornecedor;
            //return calcLitragem; //ou apenas use o return para retornar os valores de areaParedes+areaTeto:
            return (areaParedes + areaTeto) / r_fornecedor;
        }
    }
}
