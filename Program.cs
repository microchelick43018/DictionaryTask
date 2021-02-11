using System;
using System.Collections;
using System.Collections.Generic;

namespace DictionaryTask
{
    class Program
    {
        static int MakeAChoice()
        {
            int choice = 0;
            bool unCorrected = true;
            while (unCorrected)
            {
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice > 3 || choice < 0)
                {
                    Console.Write("Повторите ввод: ");
                }
                else
                {
                    unCorrected = false;
                }
            }
            return choice;
        }

        static void ShowMenu()
        {
            Console.WriteLine("1 - Добавить в словарь новое слово");
            Console.WriteLine("2 - Найти слово;");
            Console.WriteLine("3 - Выход.");
        }

        static void AddWord(ref Dictionary<string, string> words)
        {
            string word;
            string meaning;
            Console.WriteLine("Введите слово");
            word = Console.ReadLine();
            Console.WriteLine("Введите значение этого слова");
            meaning = Console.ReadLine();
            words.Add(word, meaning);
        }

        static void FindWord(Dictionary<string, string> words)
        {
            Console.WriteLine("Введите слово, которое хотите найти: ");
            string keyWord = Console.ReadLine();
            if(words.ContainsKey(keyWord))
            {
                Console.WriteLine($"Значение: {words[keyWord]}");
            }
            else
            {
                Console.WriteLine("В словаре такого слова нет!");
            }
        }

        static void Main(string[] args)
        {
            Dictionary<string, string> words = new Dictionary<string, string>();
            bool exit = false;
            while(!exit)
            {
                ShowMenu();
                switch (MakeAChoice())
                {
                    case 1:
                        AddWord(ref words);
                        break;
                    case 2:
                        FindWord(words);
                        break;
                    case 3:
                        exit = true;
                        break;
                    default:
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}

