using System;
using System.IO;

namespace CursoCSharp.Api
{
    class Diretorios
    {
        public static void Executar()
        {
            var novoDir = @"~/PastaCSharp".ParseHome();
            var novoDirDestino = @"~/PastaCSharpDestino".ParseHome();
            var dirProjeto = @"C:\@gitEstudos\EstudosCSharp\CursoCSharp";

            if (Directory.Exists(novoDir))
                Directory.Delete(novoDir, true);

            if (Directory.Exists(novoDirDestino))
                Directory.Delete(novoDirDestino, true);

            
            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));

            Console.WriteLine("=  Pastas ====================");
            var pastas = Directory.GetDirectories(dirProjeto);
            foreach (var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }

            Console.WriteLine("\n ==== Arquivos =======");
            var arquivos = Directory.GetFiles(dirProjeto);

            foreach (var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }
            Console.WriteLine("\n \n Raiz ==================");
            Console.WriteLine(Directory.GetDirectoryRoot(novoDir));

            try
            {
                Directory.Move(novoDir, novoDirDestino);
                Console.WriteLine("Arquivos movidos com sucesso!");
            }
            catch (Exception ex)
            {

                Console.WriteLine("\n Ooops!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
