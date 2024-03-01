using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace PasswordManager
{
    internal class Program
    {
        private static readonly Dictionary<string, string> passwordEntries = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            Console.WriteLine("1) List all passwords.");
            Console.WriteLine("2) Add or change password.");
            Console.WriteLine("3) Get password.");
            Console.WriteLine("4) Delete password.");
            Console.WriteLine("--------------------------------");
            ReadPassword();
            while (true)
            {
                Console.Write("Please select an option :");

                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("--------------------------------");
                
                if (option == 1)
                {
                    ListAllPasswords();
                }
                else if (option == 2)
                {
                    AddOrChangePassword();
                }
                else if (option == 3)
                {
                    GetPassword();
                }
                else if (option == 4)
                {
                    DeletePassword();
                }
                else
                {
                    Console.WriteLine("Invalid Input.");
                    break;
                }
                Console.WriteLine("--------------------------------");
            }
           
        }

        private static void ReadPassword()
        {
            string? password;

            if (File.Exists("password.txt"))
            {
                
                var passwordsLines = File.ReadAllText("password.txt");
                foreach(var line in passwordsLines.Split(Environment.NewLine))
                {
                    if (!String.IsNullOrEmpty(line))
                    {
                        int posOfEquel =line.IndexOf('=');
                        string appName= line.Substring(0, posOfEquel).Trim();
                        password = line.Substring(posOfEquel + 1).Trim();
                        passwordEntries.Add(appName,password);
                    }
                }
              
            }
            if (passwordEntries.ContainsKey("master_Key"))
            {
                Console.Write("Please enter your master key : ");
                 password = Console.ReadLine();
                if (password != Encryption.decryptCipherText(passwordEntries["master_Key"]))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("Invalid Password.");

                }
            }
            else
            {
                Console.Write("Please set your master key : ");
                password = Console.ReadLine();
                passwordEntries.Add("master_Key", Encryption.EncryptPlainText(password));
                SavePassword();
            }

        }
        private static void SavePassword()
        {
            var sb = new StringBuilder();
            foreach (var entry in passwordEntries.Keys)
            {
                
                sb.AppendLine($"{entry} = { passwordEntries[entry]}");
            }
            File.WriteAllText("password.txt" , sb.ToString());
        }

        private static void DeletePassword()
        {
            Console.Write("Enter a website / app name : ");
            string? appName = Console.ReadLine();
            if (passwordEntries.ContainsKey(appName))
            {
                passwordEntries.Remove(appName);
                SavePassword();
            }
            else
            {
                Console.WriteLine("Password not found.");
            }
        }
        private static void GetPassword()
        {
            Console.Write("Enter a website / app name : ");
            string? appName = Console.ReadLine();
            if(passwordEntries.ContainsKey(appName))
            {
                Console.WriteLine($"{appName} = {Encryption.decryptCipherText(passwordEntries[appName])}");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }

        private static void AddOrChangePassword()
        {
            Console.Write("Enter a website / app name : ");
            string ? appName= Console.ReadLine();
            Console.Write("Enter a password : ");
            string? password = Console.ReadLine();
            password= Encryption.EncryptPlainText(password);
            if(passwordEntries.ContainsKey(appName))
            {
                passwordEntries[appName] = password;
            }
            else
            {
                passwordEntries.Add(appName, password);
            }
            SavePassword();
        }

        private static void ListAllPasswords()
        {
            foreach(var key in passwordEntries.Keys)
            {
                Console.WriteLine($"{key} = {Encryption.decryptCipherText( passwordEntries[key]) }");
            }
        }
    }
}
