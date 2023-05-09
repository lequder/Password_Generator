using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class Program
    {
        private static void Main()
        {
            string o0, o1, o2, o3, o4, otvet;
            int lenghtPass;
            Random rnd = new Random();
            string Pass = "";
            string Pass1 = "";
            string Pass2 = "";
            string Pass3 = "";
            string Pass4 = "";

            Console.WriteLine("Добро пожаловать в генератор паролей!");
            Console.WriteLine("");

            Console.WriteLine("Какой длины должен быть пароль?");
            o0 = Console.ReadLine();
            lenghtPass = Convert.ToInt32(o0);
            Console.WriteLine("");

            Console.WriteLine("В пароле должны присутствовать цифры?");
            Console.WriteLine("Yes/No");
            o1 = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("В пароле должны присутствовать специальные символы?");
            Console.WriteLine("Yes/No");
            o2 = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("В пароле должны присутствовать буквы верхнего регистра?");
            Console.WriteLine("Yes/No");
            o3 = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("В пароле должны присутствовать буквы нижнего регистра?");
            Console.WriteLine("Yes/No");
            o4 = Console.ReadLine();

            if (o1 == "yes")
            {
                o1 = "1";
            }
            else
            {
                o1 = "0";
            }
            if (o2 == "yes")
            {
                o2 = "1";
            }
            else
            {
                o2 = "0";
            }
            if (o3 == "yes")
            {
                o3 = "1";
            }
            else
            {
                o3 = "0";
            }
            if (o4 == "yes")
            {
                o4 = "1";
            }
            else
            {
                o4 = "0";
            }

            otvet = o1 + o2 + o3 + o4;

            switch (otvet)
            {
                case "1111":
                    for (int i = 0; i < lenghtPass; i = i + 1)
                    {
                        string[] arrayPass =
                        {
                        "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "!", "@", "#", "$", "%", "^", "&", "?", "/", "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "A", "S", "D", "F", "G", "H", "J", "K", "L", "Z", "X", "C", "V", "B", "N", "M", "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "z", "x", "c", "v", "b", "n", "m"
                        };
                        Pass = Pass + arrayPass[rnd.Next(0, 70)];
                        Pass1 = Pass1 + arrayPass[rnd.Next(0, 70)];
                        Pass2 = Pass2 + arrayPass[rnd.Next(0, 70)];
                        Pass3 = Pass3 + arrayPass[rnd.Next(0, 70)];
                        Pass4 = Pass4 + arrayPass[rnd.Next(0, 70)];
                    }
                    break;
                case "0000":
                    Pass = "Пароль невозможен";
                    break;
                case "1110":
                    for (int i = 0; i < lenghtPass; i = i + 1)
                    {
                        string[] arrayPass =
                        {
                        "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "!", "@", "#", "$", "%", "^", "&", "?", "/", "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "A", "S", "D", "F", "G", "H", "J", "K", "L", "Z", "X", "C", "V", "B", "N", "M"
                        };
                        Pass = Pass + arrayPass[rnd.Next(0, 44)];
                        Pass1 = Pass1 + arrayPass[rnd.Next(0, 44)];
                        Pass2 = Pass2 + arrayPass[rnd.Next(0, 44)];
                        Pass3 = Pass3 + arrayPass[rnd.Next(0, 44)];
                        Pass4 = Pass4 + arrayPass[rnd.Next(0, 44)];
                    }
                    break;
                case "1100":
                    for (int i = 0; i < lenghtPass; i = i + 1)
                    {
                        string[] arrayPass =
                        {
                        "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "!", "@", "#", "$", "%", "^", "&", "?", "/"
                        };
                        Pass = Pass + arrayPass[rnd.Next(0, 18)];
                        Pass1 = Pass1 + arrayPass[rnd.Next(0, 18)];
                        Pass2 = Pass2 + arrayPass[rnd.Next(0, 18)];
                        Pass3 = Pass3 + arrayPass[rnd.Next(0, 18)];
                        Pass4 = Pass4 + arrayPass[rnd.Next(0, 18)];
                    }
                    break;
                case "1000":
                    for (int i = 0; i < lenghtPass; i = i + 1)
                    {
                        string[] arrayPass =
                        {
                        "1", "2", "3", "4", "5", "6", "7", "8", "9", "0"
                        };
                        Pass = Pass + arrayPass[rnd.Next(0, 9)];
                        Pass1 = Pass1 + arrayPass[rnd.Next(0, 9)];
                        Pass2 = Pass2 + arrayPass[rnd.Next(0, 9)];
                        Pass3 = Pass3 + arrayPass[rnd.Next(0, 9)];
                        Pass4 = Pass4 + arrayPass[rnd.Next(0, 9)];
                    }
                    break;
                case "1001":
                    for (int i = 0; i < lenghtPass; i = i + 1)
                    {
                        string[] arrayPass =
                        {
                        "1", "2", "3", "4", "5", "6", "7", "8", "9", "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "z", "x", "c", "v", "b", "n", "m"
                        };
                        Pass = Pass + arrayPass[rnd.Next(0, 35)];
                        Pass1 = Pass1 + arrayPass[rnd.Next(0, 35)];
                        Pass2 = Pass2 + arrayPass[rnd.Next(0, 35)];
                        Pass3 = Pass3 + arrayPass[rnd.Next(0, 35)];
                        Pass4 = Pass4 + arrayPass[rnd.Next(0, 35)];
                    }
                    break;
                case "0110":
                    for (int i = 0; i < lenghtPass; i = i + 1)
                    {
                        string[] arrayPass =
                        {
                        "!", "@", "#", "$", "%", "^", "&", "?", "/", "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "A", "S", "D", "F", "G", "H", "J", "K", "L", "Z", "X", "C", "V", "B", "N", "M"
                        };
                        Pass = Pass + arrayPass[rnd.Next(0, 34)];
                        Pass1 = Pass1 + arrayPass[rnd.Next(0, 34)];
                        Pass2 = Pass2 + arrayPass[rnd.Next(0, 34)];
                        Pass3 = Pass3 + arrayPass[rnd.Next(0, 34)];
                        Pass4 = Pass4 + arrayPass[rnd.Next(0, 34)];
                    }
                    break;
                case "1010":
                    for (int i = 0; i < lenghtPass; i = i + 1)
                    {
                        string[] arrayPass =
                        {
                        "1", "2", "3", "4", "5", "6", "7", "8", "9", "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "A", "S", "D", "F", "G", "H", "J", "K", "L", "Z", "X", "C", "V", "B", "N", "M"
                        };
                        Pass = Pass + arrayPass[rnd.Next(0, 35)];
                        Pass1 = Pass1 + arrayPass[rnd.Next(0, 35)];
                        Pass2 = Pass2 + arrayPass[rnd.Next(0, 35)];
                        Pass3 = Pass3 + arrayPass[rnd.Next(0, 35)];
                        Pass4 = Pass4 + arrayPass[rnd.Next(0, 35)];
                    }
                    break;
                case "0101":
                    for (int i = 0; i < lenghtPass; i = i + 1)
                    {
                        string[] arrayPass =
                        {
                        "!", "@", "#", "$", "%", "^", "&", "?", "/", "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "z", "x", "c", "v", "b", "n", "m"
                        };
                        Pass = Pass + arrayPass[rnd.Next(0, 34)];
                        Pass1 = Pass1 + arrayPass[rnd.Next(0, 34)];
                        Pass2 = Pass2 + arrayPass[rnd.Next(0, 34)];
                        Pass3 = Pass3 + arrayPass[rnd.Next(0, 34)];
                        Pass4 = Pass4 + arrayPass[rnd.Next(0, 34)];
                    }
                    break;
                case "0001":
                    for (int i = 0; i < lenghtPass; i = i + 1)
                    {
                        string[] arrayPass =
                        {
                        "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "z", "x", "c", "v", "b", "n", "m"
                        };
                        Pass = Pass + arrayPass[rnd.Next(0, 25)];
                        Pass1 = Pass1 + arrayPass[rnd.Next(0, 25)];
                        Pass2 = Pass2 + arrayPass[rnd.Next(0, 25)];
                        Pass3 = Pass3 + arrayPass[rnd.Next(0, 25)];
                        Pass4 = Pass4 + arrayPass[rnd.Next(0, 25)];
                    }
                    break;
                case "0011":
                    for (int i = 0; i < lenghtPass; i = i + 1)
                    {
                        string[] arrayPass =
                        {
                        "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "A", "S", "D", "F", "G", "H", "J", "K", "L", "Z", "X", "C", "V", "B", "N", "M", "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "z", "x", "c", "v", "b", "n", "m"
                        };
                        Pass = Pass + arrayPass[rnd.Next(0, 51)];
                        Pass1 = Pass1 + arrayPass[rnd.Next(0, 51)];
                        Pass2 = Pass2 + arrayPass[rnd.Next(0, 51)];
                        Pass3 = Pass3 + arrayPass[rnd.Next(0, 51)];
                        Pass4 = Pass4 + arrayPass[rnd.Next(0, 51)];
                    }
                    break;
                case "0111":
                    for (int i = 0; i < lenghtPass; i = i + 1)
                    {
                        string[] arrayPass =
                        {
                        "!", "@", "#", "$", "%", "^", "&", "?", "/", "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "A", "S", "D", "F", "G", "H", "J", "K", "L", "Z", "X", "C", "V", "B", "N", "M", "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "z", "x", "c", "v", "b", "n", "m"
                        };
                        Pass = Pass + arrayPass[rnd.Next(0, 60)];
                        Pass1 = Pass1 + arrayPass[rnd.Next(0, 60)];
                        Pass2 = Pass2 + arrayPass[rnd.Next(0, 60)];
                        Pass3 = Pass3 + arrayPass[rnd.Next(0, 60)];
                        Pass4 = Pass4 + arrayPass[rnd.Next(0, 60)];
                    }
                    break;
                case "0100":
                    for (int i = 0; i < lenghtPass; i = i + 1)
                    {
                        string[] arrayPass =
                        {
                        "!", "@", "#", "$", "%", "^", "&", "?", "/"
                        };
                        Pass = Pass + arrayPass[rnd.Next(0, 8)];
                        Pass1 = Pass1 + arrayPass[rnd.Next(0, 8)];
                        Pass2 = Pass2 + arrayPass[rnd.Next(0, 8)];
                        Pass3 = Pass3 + arrayPass[rnd.Next(0, 8)];
                        Pass4 = Pass4 + arrayPass[rnd.Next(0, 8)];
                    }
                    break;
                case "0010":
                    for (int i = 0; i < lenghtPass; i = i + 1)
                    {
                        string[] arrayPass =
                        {
                        "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "A", "S", "D", "F", "G", "H", "J", "K", "L", "Z", "X", "C", "V", "B", "N", "M"
                        };
                        Pass = Pass + arrayPass[rnd.Next(0, 25)];
                        Pass1 = Pass1 + arrayPass[rnd.Next(0, 25)];
                        Pass2 = Pass2 + arrayPass[rnd.Next(0, 25)];
                        Pass3 = Pass3 + arrayPass[rnd.Next(0, 25)];
                        Pass4 = Pass4 + arrayPass[rnd.Next(0, 25)];
                    }
                    break;
                case "1011":
                    for (int i = 0; i < lenghtPass; i = i + 1)
                    {
                        string[] arrayPass =
                        {
                        "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "A", "S", "D", "F", "G", "H", "J", "K", "L", "Z", "X", "C", "V", "B", "N", "M", "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "z", "x", "c", "v", "b", "n", "m"
                        };
                        Pass = Pass + arrayPass[rnd.Next(0, 61)];
                        Pass1 = Pass1 + arrayPass[rnd.Next(0, 61)];
                        Pass2 = Pass2 + arrayPass[rnd.Next(0, 61)];
                        Pass3 = Pass3 + arrayPass[rnd.Next(0, 61)];
                        Pass4 = Pass4 + arrayPass[rnd.Next(0, 61)];
                    }
                    break;
                case "1101":
                    for (int i = 0; i < lenghtPass; i = i + 1)
                    {
                        string[] arrayPass =
                        {
                        "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "!", "@", "#", "$", "%", "^", "&", "?", "/", "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "z", "x", "c", "v", "b", "n", "m"                        
                        };
                        Pass = Pass + arrayPass[rnd.Next(0, 44)];
                        Pass1 = Pass1 + arrayPass[rnd.Next(0, 44)];
                        Pass2 = Pass2 + arrayPass[rnd.Next(0, 44)];
                        Pass3 = Pass3 + arrayPass[rnd.Next(0, 44)];
                        Pass4 = Pass4 + arrayPass[rnd.Next(0, 44)];
                    }
                    break;
            }

            Console.Clear();
            Console.WriteLine("Ваши пароли:");
            Console.WriteLine(Pass);
            Console.WriteLine(Pass1);
            Console.WriteLine(Pass2);
            Console.WriteLine(Pass3);
            Console.WriteLine(Pass4);
            Console.ReadLine();
        }
    }
}
