using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar()
        {
            var executouTrabalho1 = false;
            var executouTrabalho2 = false;

            bool comrouTv50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine("Comprou a Tv 50? {0}", comrouTv50);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine("Comprou o soevete? {0}", comprouSorvete);

            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine("Comprou a Tv 32? {0}", comprouTv32);

            Console.WriteLine("Mais saudável? {0}", !comprouSorvete);
        }
    }
}
