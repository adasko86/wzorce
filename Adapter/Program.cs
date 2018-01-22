using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook noteBook = new Notebook();
            noteBook.createNote("Tytuł1", "Notatka1");
            noteBook.createNote("Tytuł2", "Notatka2");
            noteBook.createNote("Tytuł3", "Notatka3");

            Console.WriteLine(noteBook.notesCatalog());

            Console.WriteLine(noteBook.removeNote("Tytuł1"));
            Console.WriteLine(noteBook.removeNote("Tytuł4"));
            Console.WriteLine();
            Console.WriteLine(noteBook.notesCatalog());
            Console.Read();

            /*
            NotebookAdapter noteBookAdapter = new NotebookAdapter();
            noteBookAdapter.createNote("Tytuł1", "Notatka1");
            noteBookAdapter.createNote("Tytuł2", "Notatka2");
            noteBookAdapter.createNote("Tytuł3", "Notatka3");
            noteBookAdapter.createNote("Tytuł4", "Notatka5", "29-01-2018");
            noteBookAdapter.createNote("Tytuł5", "Notatka5", "30-01-2018");

            Console.WriteLine(noteBookAdapter.notesCatalog());

            Console.WriteLine(noteBookAdapter.removeNote("Tytuł1"));
            Console.WriteLine(noteBookAdapter.removeNote("Tytuł4"));
            Console.WriteLine();
            Console.WriteLine(noteBookAdapter.notesCatalog());
            Console.Read();
             * */
        }
    }
}
