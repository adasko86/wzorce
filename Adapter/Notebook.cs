using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Notebook : INotebook
    {
        List<Note> catalog = new List<Note>();
        public void createNote(string title, string description)
        {
            Note note = new NoteBuilder()
                .For(x => x.Title, title)
                .For(x => x.Description, description)
                .build();

            catalog.Add(note);
        }

        public string getNote(string title)
        {
            String returnedString = null;
            foreach (Note note in catalog)
            {
                if (note.Equals(title))
                {
                    returnedString = "Tytuł: ";
                    returnedString += note.Title;
                    returnedString += " Notatka: ";
                    returnedString += note.Description;
                    break;
                }
            }

            if (String.IsNullOrWhiteSpace(returnedString))
                returnedString = "Nie odnaleziono notatki: " + title;

            return returnedString;
        }

        public string removeNote(string title)
        {
            String returnedString = null;
            Note noteToRemove = null;
            foreach (Note note in catalog)
            {
                if (note.Title.Equals(title))
                {
                    noteToRemove = note;
                    break;
                }
            }

            if (noteToRemove != null)
            {
                catalog.Remove(noteToRemove);
                returnedString = "Usunięto notatkę: " + title;
            }

            if (String.IsNullOrWhiteSpace(returnedString))
                returnedString = "Nie odnaleziono notatki: " + title;

            return returnedString;
        }

        public string notesCatalog()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Note note in catalog)
            {
                sb.Append("Tytuł: ");
                sb.Append(note.Title);
                sb.Append(" Notatka: ");
                sb.AppendLine(note.Description);
            }
            return sb.ToString();
        }
    }
}
