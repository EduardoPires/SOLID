namespace EP.SOLID.DIP.Violacao
{
    public static class CPFServices
    {
        public static bool IsValid(string cpf)
        {
            return cpf.Length == 11;
        }
    }
}