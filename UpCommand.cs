using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ServerFiles
{
    internal class UpCommand
    {

        public void UpFile (string dest) 
        {
            if (!validDest(dest))
                return;

            string currentDirectory = Directory.GetCurrentDirectory();

            string fileName = Path.GetFileName(dest);

            string directoryFiles = Path.Combine(currentDirectory, "Files", fileName); 

            File.Copy(dest, directoryFiles, true);

            Console.WriteLine("Arquivo salvo com sucesso!");
        }

        public bool validDest (string dest) 
        {
            if (dest.Count() == 0)
            {
                Console.WriteLine("Não existe o arquivo informado!");
                return false; 
            } 

            if (!Path.Exists(dest))
            {
                Console.WriteLine("Arquivo não existe!"); 
                return false;
            }

            return true; 
        }

    }
}
