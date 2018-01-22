using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluence_Builder
{
    public class Class_cat
    {

        private String name; // final because the name is required
        private String color;
        private int age;
        private String owner;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public String Color
        {
            get { return color; }
            set { color = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public String Owner
        {
            get { return owner; }
            set { owner = value; }
        }
        public Class_cat()
        { }

        public Class_cat(Builder builder)
        {
            this.name = builder.Name;
            this.color = builder.Color;
            this.age = builder.Age;
            this.owner = builder.Owner;
        }

        public String getName()
        {
            return name;
        }
        public String getColor()
        {
            return color;
        }
        public int getAge()
        {
            return age;
        }
        public String getOwner()
        {
            return owner;
        }
        public override string ToString()
        {
            return "Cat [name=" + name + ", color=" + color + ", age=" + age
                    + ", owner=" + owner + "]";
        }
    }

    public class Builder
    {
        private String name; // final because the name is required
        private String color;
        private int age;
        private String owner;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public String Color
        {
            get { return color; }
            set { color = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public String Owner
        {
            get { return owner; }
            set { owner = value; }
        }
 
        public Builder(String name)
        {
            this.name = name;
        }
 
        public Builder _color(String color)
        {
            this.color = color;
            return this;
        }
 
        public Builder _age(int age)
        {
            this.age = age;
            return this;
        }
 
        public Builder _owner(String owner)
        {
            this.owner = owner;
            return this;
        }

        public Class_cat build()
        {
            return new Class_cat(this);
        }
    }
}
