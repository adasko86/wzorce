using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Notebook_v2 : INotebook_v2
    {
        List<Note> catalog = new List<Note>();
        public void createNote(string title, string description, string time)
        {
            Note note = new NoteBuilder()
                .For(x => x.Title, title)
                .For(x => x.Description, description)
                .For(x => x.Time, time)
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
                    returnedString += " Time: ";
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

        public string notesList()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Note note in catalog)
            {
                sb.Append("Tytuł: ");
                sb.Append(note.Title);
                sb.Append(" Notatka: ");
                sb.Append(note.Description);
                sb.Append(" Time: ");
                sb.AppendLine(note.Time);
            }
            return sb.ToString();
        }
    }
}
