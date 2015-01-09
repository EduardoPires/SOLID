using System;

namespace EP.SOLID.LSP.Violacao
{
    public class Program
    {
        private static void ObterAreaRetangulo(Retangulo ret)
        {
            Console.WriteLine("Calculo da área do Retangulo");
            Console.WriteLine(ret.Altura.ToString() + " * " + ret.Largura.ToString());
            Console.WriteLine(ret.Area);
            Console.ReadKey();
        }

        private static void Main()
        {
            var quad = new Quadrado()
            {
                Altura = 10,
                Largura = 5
            };

            ObterAreaRetangulo(quad);
        }
    }
}