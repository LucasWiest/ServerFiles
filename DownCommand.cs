using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerFiles
{
    internal class DownCommand
    {
        public void DownloadFile (int position)
        {
            ListCommand listCommand = new ListCommand (); 

            var listPath = listCommand.GetDestFiles ();

            if (position < 1 || position > listPath.Count())
            {
                Console.WriteLine("Código de arquivo inválido");
                return;
            }

            position--;

            File.Copy(listPath[position], Path.Combine(GetDownloadsFolder(), Path.GetFileName(listPath[position])), true);

            Console.WriteLine("Download concluido com sucesso, o arquivo está em downloads");
        }

        private static string GetDownloadsFolder()
        {
            string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string downloadsFolder = Path.Combine(userProfile, "Downloads");

            return downloadsFolder;
        }
    }
}
