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
            }

            string choice = Console.ReadLine();
            switch (choice)
            {
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
