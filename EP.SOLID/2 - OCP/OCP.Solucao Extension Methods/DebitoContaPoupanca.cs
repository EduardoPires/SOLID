namespace EP.SOLID.OCP.Solucao_Extension_Methods
{
    public static class DebitoContaPoupanca
    {
        public static string DebitarContaPoupanca(this DebitoConta debitoConta)
        {
            // Logica de negócio para debito em conta poupanca.
            return debitoConta.FormatarTransacao();
        }
    }
}