using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ServerFiles
{
    public class ListCommand
    {

        public List<string> ListFiles()
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            string directoryFiles = Path.Combine(currentDirectory, "Files");

            List<string> files = Directory.EnumerateFiles(directoryFiles, "*", SearchOption.AllDirectories)
                .Select(x => Path.GetFileName(x))
                .ToList();

            if (files.Count == 0)
            {
                Console.WriteLine("Não há arquivos");
                return files;
            }

            for (int i = 0; i < files.Count(); i++)
            {
                Console.WriteLine($"{i + 1} - {files[i]}");
            }

            return files;
        }

        public List<string> GetDestFiles() 
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            string directoryFiles = Path.Combine(currentDirectory, "Files");

            List<string> files = Directory.EnumerateFiles(directoryFiles, "*", SearchOption.AllDirectories).ToList();

            return files;

        }

    }
}
