using System;
<<<<<<< HEAD
using System.Collections.Generic;
using System.Text;

=======
using System.IO;
>>>>>>> 6551ef14a02270d7491e8bf21360faf4b9d11149
namespace CursoCSharp.Api
{
    class ExemploDirectoryInfo
    {
        public static void Executar()
        {
<<<<<<< HEAD

=======
            //Alterar depois
            var dirProjeto = @"C:\@gitEstudos\EstudosCSharp\CursoCSharp";

            var dirInfo = new DirectoryInfo(dirProjeto);

            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            Console.WriteLine("=== Arquivos ====");

            var arquivos = dirInfo.GetFiles();
            foreach (var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("\n ===== Diretórios ======");

            var pastas = dirInfo.GetDirectories();
            foreach (var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }

            Console.WriteLine(dirInfo.CreationTime);
            Console.WriteLine(dirInfo.FullName);
            Console.WriteLine(dirInfo.Root);
            Console.WriteLine(dirInfo.Parent);
>>>>>>> 6551ef14a02270d7491e8bf21360faf4b9d11149
        }
    }
}
