using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_banco
{
    class Program
    {
        static List<Conta> listContas = new List<Conta>();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpçãoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario) { 
                case "1":
                    ListarContas();
                        break;
                case "2":
                    InserirConta();
                        break;
                case "3":
                    Transferir();
                        break;
                 case "4":
                    Sacar();
                        break;
                 case "5":
                    Depositar();
                        break;
                 case "C":
                    Console.Clear();
                        break;
                 default:

                        throw new ArgumentOutOfRangeException();

                }
                opcaoUsuario = ObterOpçãoUsuario();
            }
            Console.WriteLine("Obrigado por utilizar nossos Serviços");
            Console.ReadLine();
        }

        private static void Transferir()
        {
            Console.Write("Digite o Numero da Conta de Origem: ");
            int indiceContaOrigem = int.Parse(Console.ReadLine());

            Console.Write("Digite o Numero da Conta de Destino: ");
            int indiceContaDestino = int.Parse(Console.ReadLine());

            Console.Write("Digite o Valor a ser Transferido: ");
            double valorTransferencia = double.Parse(Console.ReadLine());

            listContas[indiceContaOrigem].Transferir(valorTransferencia, listContas[indiceContaDestino]);
        }

        private static void Depositar()
        {
            Console.Write("Digite o Numero da Conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o Valor a ser Sacado: ");
            double valorDeposito = double.Parse(Console.ReadLine());

            listContas[indiceConta].Depositar(valorDeposito);
        }

        private static void Sacar()
        {
            Console.Write("Digite o Numero da Conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o Valor a ser Sacado: ");
            double valorsaque = double.Parse(Console.ReadLine());

            listContas[indiceConta].Sacar(valorsaque);
        }

        private static void ListarContas()
        {
            Console.WriteLine("Listar Contas");
            if (listContas.Count == 0)
            {
                Console.WriteLine("Nenhuma Conta Cadastrada!");
                return;
            }
            for(int i = 0; i < listContas.Count; i++)
            {
                Conta conta = listContas[i];
                Console.Write("#{0} . ", i);
                Console.WriteLine(conta);
            }
        }

        private static void InserirConta()
        {
            Console.WriteLine("Inserir nova Conta");

            Console.Write("Digite 1 para Conta Física ou 2 para conta Juridica:  ");
            int entradaTipoConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o Nome do Cliente: ");
            string entradaNome = Console.ReadLine();

            Console.Write("Digite o Saldo Inicial: ");
            double entradaSaldo = double.Parse(Console.ReadLine());

            Console.Write("Digite o Crédito");
            double entradaCredito = double.Parse(Console.ReadLine());

            Conta novaConta = new Conta(tipoConta: (TipoConta)entradaTipoConta,
                saldo: entradaSaldo, credito: entradaCredito, nome: entradaNome);

            listContas.Add(novaConta);

        }

        private static string ObterOpçãoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("App Banco a seu Dispor!!!");
            Console.WriteLine("Informe a opção desejada");

            Console.WriteLine("1 - Listar Contas");
            Console.WriteLine("2 - Inserir nova conta");
            Console.WriteLine("3 - Transferir");
            Console.WriteLine("4 - Sacar");
            Console.WriteLine("5 - Depositar");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("2 - Inserir nova conta");
          
            string opcaoUsuario = Console.ReadLine().ToUpper();
            
            return opcaoUsuario;
           
        }
    }
}
