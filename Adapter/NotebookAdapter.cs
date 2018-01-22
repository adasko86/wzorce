using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class NotebookAdapter : INotebook, INotebook_v2
    {
        Notebook_v2 notebook_v2 = new Notebook_v2();
        public void createNote(string title, string description)
        {
            notebook_v2.createNote(title, description, null);
        }

        public string getNote(string title)
        {
            return notebook_v2.getNote(title);
        }

        public string removeNote(string title)
        {
            return notebook_v2.removeNote(title);
        }

        public string notesCatalog()
        {
            return notebook_v2.notesList();
        }

        public void createNote(string title, string description, string time)
        {
            notebook_v2.createNote(title, description, time);
        }

        public string notesList()
        {
            return notebook_v2.notesList();
        }
    }
}
