using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public interface INotebook
    {
        void createNote(String title, String description);
        String getNote(String title);
        String removeNote(String title);
        String notesCatalog();
    }
}
