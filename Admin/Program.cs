using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Admin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegistryKey current = Registry.CurrentUser;
            RegistryKey create = current.CreateSubKey("Porno", true);

            Console.Write("Введите цвет задника\n> ");
            create.SetValue("window", Console.ReadLine());

            Console.Write("Введите цвет текста\n> ");
            create.SetValue("button", Console.ReadLine());

            create.Close();
        }
    }
}
