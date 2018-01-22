using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluence_Builder
{
    public class Class_ProblemCat
    {
        private String name;
        private String color;
        private int age;
        private String owner;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public String Color
        {
            get { return color; }
            set { color = value; }
        }

        public Class_ProblemCat(String name)
        {
            this.name = name;
        }

        public Class_ProblemCat(int age)
        {
            this.age = age;
        }

        public Class_ProblemCat(String name, String owner)
        {
            this.name = name;
            this.owner = owner;
        }

        ///
        ///etc.
        ///

        public override string ToString()
        {
            return "Cat [name=" + name + ", color=" + color + ", age=" + age
                    + ", owner=" + owner + "]";
        }
    }
}
