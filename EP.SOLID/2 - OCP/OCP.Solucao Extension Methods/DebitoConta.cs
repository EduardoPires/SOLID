using System;
using System.Linq;

namespace EP.SOLID.OCP.Solucao_Extension_Methods
{
    public class DebitoConta
    {
        public string NumeroConta { get; set; }
        public decimal Valor { get; set; }
        public string NumeroTransacao { get; set; }
        
        public string FormatarTransacao()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            NumeroTransacao = new string(Enumerable.Repeat(chars, 15)
              .Select(s => s[random.Next(s.Length)]).ToArray());

            // Numero de transacao formatado
            return NumeroTransacao;
        } 
    }
}