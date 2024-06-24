namespace ServerFiles;

class Program
{
    static void Main(string[] args)
    {

        string currentDirectory = Directory.GetCurrentDirectory();

        string directoryFiles = Path.Combine(currentDirectory, "Files");

        bool existDirectory = Directory.Exists(directoryFiles); 

        if (!existDirectory)
        {
            Directory.CreateDirectory(directoryFiles);
        }

        Console.WriteLine(
            "Seja bem-vindo\n"
            + "Lista de comandos:\n"
            + "list - Vai listar os arquivos salvos no repositório\n"
            + "down - Vai fazer o download do arquivo\n"
            + "up - Vai salvar o arquivo na pasta dest\n" 
            + "exit");


        bool running = true;
        Commands commands = new Commands();
        string? command = "";

        while (running)
        {

            Console.Write("O que tu deseja fazer? ");
            command = Console.ReadLine();

            if (command == "exit") 
            { 
                running = false; 
                break; 
            }

            commands.RouteCommands(command);
        }
    }
}
