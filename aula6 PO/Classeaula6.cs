using System;
using System.Collections.Generic;
using System.Text;

namespace Aula6
{
    class Classeaula6
    {
        public virtual void Calculo(int dias)
        {
            float valDiaria = (float)100.00;
            float calculo = (float)0.01;
            float calc = (float)(valDiaria * dias) * calculo;



            Console.WriteLine($"\n Valor da diária:R$100 \nQuantidade de Diárias: {dias}\nValor do Seguro: {calc.ToString("C")}");

        }
    }
}
