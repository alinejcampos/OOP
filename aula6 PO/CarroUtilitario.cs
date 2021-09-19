using System;
using System.Collections.Generic;
using System.Text;

namespace Aula6
{
    class CarroUtilitario : Classeaula6
    {

        public override void Calculo(int dias)
        {
            float valDiaria = (float)400.00;
            float calculo = (float)0.25;
            float calc = (float)(valDiaria * dias) * calculo;



            Console.WriteLine($"\n Valor da diária:R$400 \nQuantidade de Diárias: {dias}\nValor do Seguro: {calc.ToString("C")}");
        }
    }

}
