using System;
using System.Collections.Generic;
using System.Text;

namespace Aula6
{
    class CarrodeLuxo : Classeaula6
    {

        public override void Calculo(int dias)
        {
            float valDiaria = (float)300.00;
            float calculo = (float)0.02;
            float calc = (float)(valDiaria * dias) * calculo;



            Console.WriteLine($"\n Valor da diária:R$300 \nQuantidade de Diárias: {dias}\nValor do Seguro: {calc.ToString("C")}");
        }
    }
}
