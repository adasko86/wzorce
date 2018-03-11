using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class Class_DescriptionCreator
    {
        private Dictionary<String, Class_Description> relations = new Dictionary<String, Class_Description>();

        public Class_Description createRelation(String description)
        {
            Class_Description relation = !relations.ContainsKey(description) ? null : relations[description];
            if (relations == null)
            {
                relation = new Class_Description(description);
                relations.Add(description, relation);
                //Console.WriteLine("Creating new relation: " + relation.getDescription());
            }
            return relation;
        }
    }
}
