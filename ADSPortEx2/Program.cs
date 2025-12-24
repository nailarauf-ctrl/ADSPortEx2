using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BSTree<VideoGame> tree = new BSTree<VideoGame>();
            bool running = true;
            while (running)
            {
                Console.WriteLine("1. Add Video Game");
                Console.WriteLine("2. Display Tree");
                Console.WriteLine("3. Show Earliest Release Year");
                Console.WriteLine("4. Show Tree Height");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Title: ");
                        string title = Console.ReadLine();

                        Console.Write("Enter Developer: ");
                        string developer = Console.ReadLine();

                        Console.Write("Enter Release Year: ");
                        int year = int.Parse(Console.ReadLine());

                        tree.InsertItem(new VideoGame(title, developer, year));
                        Console.WriteLine("Game added.");
                        break;

                    case "2":
                        Console.WriteLine("\nChoose traversal:");
                        Console.WriteLine("1. InOrder");
                        Console.WriteLine("2. PreOrder");
                        Console.WriteLine("3. PostOrder");
                        Console.Write("Choice: ");

                        string traversal = Console.ReadLine();
                        string buffer = "";

                        if (traversal == "1")
                            tree.InOrder(ref buffer);
                        else if (traversal == "2")
                            tree.PreOrder(ref buffer);
                        else if (traversal == "3")
                            tree.PostOrder(ref buffer);
                        else
                        {
                            Console.WriteLine("Invalid traversal choice.");
                            break;
                        }

                        Console.WriteLine(buffer);
                        break;


                    case "3":
                        VideoGame earliest = tree.EarlieseGame();

                        if (earliest == null)
                        {
                            Console.WriteLine("Tree is empty.");
                        }
                        else
                        {
                            Console.WriteLine("Earliest released game:");
                            Console.WriteLine(earliest);
                        }

                        break;

                    case "4":
                        Console.WriteLine("Current tree height: " + tree.Height());
                        break;

                    case "5":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;

                }

            }

            Console.ReadLine();

        }
    }
}
