using System;

namespace Aula6
{
    class Program
    {
        static void Main(string[] args)

        {

            //Desenvolver uma sistema de locadora onde calcula o seguro pago do cliente , obedecendo os seguintes critérios:

            Locadora();



        }
        enum Opcoes { CarroPolular = 1, CarroDeLuxo, CarroUtilitario, Sair}
        static void Locadora()
        {
            bool saida = !true;
            while (saida != true)
            {

                Console.WriteLine("\n\t Locadora de Carros");
                Console.WriteLine("\n\t\t1- CarroPopular\n\t\t2- CarroDeLuxo\n\t\t3- CarroUtilitario\n\t\t4- Sair");
                Console.Write("\n\t\tEscolha uma opção:");
                int opcao = int.Parse(Console.ReadLine());


                Opcoes opcaoEscolhida = (Opcoes)opcao;

                if (opcao > 0 && opcao <=4)
                {
                    switch (opcaoEscolhida)
                    {
                        case Opcoes.CarroPolular:
                            Classeaula6 carPop = new CarroPopular();
                            Console.Write("Digite quantas diárias: ");
                            carPop.Calculo(int.Parse(Console.ReadLine()));
                            break;
                        case Opcoes.CarroDeLuxo:
                            Classeaula6 carLux = new CarrodeLuxo();
                            Console.Write("Digite quantas diárias: ");
                            carLux.Calculo(int.Parse(Console.ReadLine()));
                            break;
                        case Opcoes.CarroUtilitario:
                            Classeaula6 carUti = new CarroUtilitario();
                            Console.Write("Digite quantas diárias: ");
                            carUti.Calculo(int.Parse(Console.ReadLine()));
                            break;
                        case Opcoes.Sair:
                            saida = true;
                            break;
                        
                            
                    }
                    
                }


            }
            



        }
    }
}
