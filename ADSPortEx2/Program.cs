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
                        break;

                    case "2":
                        string buffer = "";
                        tree.InOrder(ref buffer);
                        Console.WriteLine(buffer);
                        break;

                    case "3":
                        Console.WriteLine(tree.EarlieseGame());
                        break;

                }

            }

           






            //Create a Menu driven interface here so a user can interact with your implementations

            //I.e. while(true){
            // print to user - "Select an option"
            // "1. Add item to tree"
            // "2. Display all items... ect
            //}




            Console.ReadLine();

        }
    }
}
