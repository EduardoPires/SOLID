namespace EP.SOLID.SRP.Solucao
{
    public static class CPFServices
    {
        public static bool IsValid(string cpf)
        {
            return cpf.Length == 11;
        }
    }
}