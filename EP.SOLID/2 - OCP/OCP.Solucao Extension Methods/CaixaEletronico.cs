using System;

namespace EP.SOLID.OCP.Solucao_Extension_Methods
{
    public class CaixaEletronico
    {
        public static void Operacoes()
        {
            MenuOperacoes();

            var opcao = Console.ReadKey();
            var retorno = string.Empty;

            var debitoConta = DadosDebito();

            switch (opcao.KeyChar)
            {
                case '1':
                    Console.WriteLine("Efetuando operação em Conta Corrente");
                    retorno = debitoConta.DebitarContaCorrente();
                    break;
                case '2':
                    Console.WriteLine("Efetuando operação em Conta Poupança");
                    retorno = debitoConta.DebitarContaPoupanca();
                    break;
                case '3':
                    Console.WriteLine("Efetuando operação em Conta Investimento");
                    retorno = debitoConta.DebitarContaInvestimento();
                    break;
            }

            RetornoTransacao(retorno);
        }

        private static void MenuOperacoes()
        {
            Console.Clear();
            Console.WriteLine("Caixa Eletrônico SOLID");
            Console.WriteLine("Escolha sua opção:");
            Console.WriteLine();
            Console.WriteLine("1 - Saque Conta Corrente");
            Console.WriteLine("2 - Saque Conta Poupança");
            Console.WriteLine("3 - Saque Conta Investimento");
        }

        private static DebitoConta DadosDebito()
        {
            Console.WriteLine();
            Console.WriteLine("..............................");
            Console.WriteLine();
            Console.WriteLine("Digite a Conta");
            var conta = Console.ReadLine();
            Console.WriteLine("Digite o Valor");
            var valor = Convert.ToDecimal(Console.ReadLine());

            var debitoConta = new DebitoConta()
            {
                NumeroConta = conta,
                Valor = valor
            };

            return debitoConta;
        }

        private static void RetornoTransacao(string retorno)
        {
            Console.WriteLine();
            Console.WriteLine("Sucesso! Transação: " + retorno);
            Console.ReadKey();
        }
    }
}