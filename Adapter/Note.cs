using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Note
    {
        private String title;
        public String Title
        {
            get { return title; }
            set { title = value; }
        }

        private String description;
        public String Description
        {
            get { return description; }
            set { description = value; }
        }

        private String time;
        public String Time
        {
            get { return time; }
            set { time = value; }
        }
    }

    public class NoteBuilder : Fluency.DynamicFluentBuilder<Note>
    {

    }

}
