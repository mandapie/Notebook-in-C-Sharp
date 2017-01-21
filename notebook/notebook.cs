using System;
using System.Collections.Generic; //for List
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notebook
{
    class notebook
    {
        static List<note> page = new List<note>();
        static void Main(string[] args)
        {
            Console.Write("This is a notebook console.\n");
            bool notDone = true;
            while (notDone)
            {
                Console.Write("Menu:\n1. add new note\n2. list all note title\n3. access note\n4. delete note\n5. done\n");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        //add note
                        addNote();
                        break;
                    case 2:
                        //list all title();
                        printNotebook(page);
                        break;
                    case 3:
                        //access note
                        accessNote();
                        break;
                    case 4:
                        //delete note
                        deleteNote();
                        break;
                    case 5:
                        //quit
                        notDone = false;
                        break;
                    default:
                        //wrong input
                        Console.Write("only 1-4\n");
                        break;
                }
            }
        }
        //methods
        public static void addNote()
        {
            Console.Write("title: ");
            string title = Console.ReadLine();
            Console.Write("message: ");
            string msg = Console.ReadLine();
            page.Add(new note(title, msg));
        }
        public static void printNotebook(List<note> page)
        {
            int counter = 1;
            foreach(var titles in page)
            {
                Console.Write(counter + ". " + titles.getTitle() + "\n");
                counter++;
            }
        }
        public static void accessNote()
        {
            Console.Write("Enter the title of the note to access it: ");
            string access = Console.ReadLine();
            int counter = 0;
            foreach (var titles in page)
            {
                titles.getTitle();
                if(titles.getTitle() == access)
                {
                    Console.Write("title: " + page[counter].getTitle() + "\nmessage: " + page[counter].getMsg() + "\n");
                    return;
                }
                counter++;
            }
            Console.Write("Can't find title\n");
        }
        public static void deleteNote()
        {
            Console.Write("Enter the title of the note to delete it: ");
            string access = Console.ReadLine();
            int counter = 0;
            foreach (var titles in page)
            {
                titles.getTitle();
                if (titles.getTitle() == access)
                {
                    page.RemoveAt(counter);
                    Console.Write("Note deleted\n");
                    return;
                }
                counter++;
            }
            Console.Write("Can't find title\n");
        }
    }
}