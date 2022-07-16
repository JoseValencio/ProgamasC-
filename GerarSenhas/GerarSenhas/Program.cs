using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerarSenhas
{
  internal  class Program
    {

        public static void Main(string[] args)
        {

           

            string opcao = ObterOpcao();
             
           

            while (opcao.ToUpper() != "X") {
                switch (opcao) {

                    case "1":

                        SenhaGerada();
                        
                        break;

                    case "X":

                        Console.ReadLine();

                        break;

                    case "C":

                        Console.Clear();

                        break;

                         default: throw new ArgumentOutOfRangeException();

                }

                opcao = ObterOpcao();
            }
            
          
           
        }

        private static void Sair()
        {
            Console.ReadLine();
        }

        private static void SenhaGerada()
        {
            int length = 10;
            string senha = GerarSenhaAleatoria(length);

            Console.WriteLine("Senha Gerada " + senha);
            Console.WriteLine("Precione Enter para continuar");
            Console.ReadLine();
        }

       private static string GerarSenhaAleatoria(int length)
        {

            const string caracters = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            StringBuilder sa = new StringBuilder();
            Random gsa = new Random();

            for (int i = 0; i < length; i++)
            {
                int indice = gsa.Next(caracters.Length);
                sa.Append(caracters[indice]);
            }

            return sa.ToString();
        }


        private  static string ObterOpcao(){

            Console.WriteLine();
            Console.WriteLine("App de Senhas Aleatórias!!!");
            Console.WriteLine("Informe a Opção Desejada:");

            Console.WriteLine("1 - Gerar Senha");
            Console.WriteLine("C - limpar");
            Console.WriteLine("X - Sair");

            string opcao = Console.ReadLine().ToUpper();
            Console.WriteLine();

               return opcao;
            }


        }
      
    }

