using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public static class UI
    {
        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
        public static string GetInput()
        {
            return Console.ReadLine();
        }

        public static string GetUserName()
        {
            Console.WriteLine("Informe seu Nome de Usuario:");
            return Console.ReadLine();
        }

        public static void DisplayChatRoomOptions()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Bem vindo ao hegChatRoom");
            Console.WriteLine("Comece a digitar para bater papo com outra pessoa.");
            Console.WriteLine("Digite 'exit' para sair da sala e fechar a janela.");
            Console.ResetColor();
        }
    }
}
