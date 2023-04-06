using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckLibrary;

namespace Dictionary
{
    internal class SimpleDictionary
    {
        Dictionary<string, string> dictionary;
        public SimpleDictionary()
        {
            dictionary = new Dictionary<string, string>();
        }

        private void AddWord()
        {
            Console.WriteLine("Choose a czech word:");
            string wordCZ = Check.NotEmptyString();
            Console.WriteLine("Choose an english translation:");
            string translationEN = Check.NotEmptyString();
            Console.WriteLine("");

            dictionary.Add(wordCZ, translationEN);
        }

        private void ShowDictionary()
        {
            if (dictionary.Count == 0)
                Console.WriteLine("First fill dictionary with at least any value\n");
            else
            {
                foreach (var words in dictionary)
                {
                    Console.WriteLine("Czech version: '" + words.Key + "', english translate: '" + words.Value + "'");
                }
            }
        }

        private void RemoveFromDictionary()
        {
            Console.WriteLine("Write a czech word you want to remove from the dictionary:");
            string removeWord = Check.NotEmptyString();
            dictionary.Remove(removeWord);
        }

        private void MenuText()
        {
            Console.WriteLine("Select an option from the Menu");

            Console.WriteLine("1 - Add a new czech word with its english translation");
            Console.WriteLine("2 - View the entire dictionary");
            Console.WriteLine("3 - Remove from dictionary");
            Console.WriteLine("4 - Export dictionary to XML");
            Console.WriteLine("5 - Import dictionary from XML");
            Console.WriteLine("6 - End program");

        }
        public void Menu()
        {
            bool Menu_continue = true;
            do
            {
                MenuText();
                int option = Check.PositiveIntCheck();
                switch (option)
                {
                    case 1:
                        AddWord();
                        break;
                    case 2:
                        ShowDictionary();
                        break;
                    case 3:
                        RemoveFromDictionary();
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        Menu_continue = false;
                        break;
                    default:
                        break;
                }
            }
            while (Menu_continue == true);
        }
    }
}
