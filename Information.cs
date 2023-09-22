using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationClassWiki
{
    internal class Information : IComparable<Information>
    {
        // Private initial variables
        private string name;
        private string category;
        private string structure;
        private string definition;

        // get; set; Name
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        // get; set; Category
        public string GetCategory()
        {
            return category;
        }
        public void SetCategory(string category)
        {
            this.category = category;
        }
        // get; set; Strucure
        public string GetStructure()
        {
            return structure;
        }
        public void SetStructure(string structure)
        {
            this.structure = structure;
        }
        // get; set; Definition
        public string GetDefition()
        {
            return definition;
        }
        public void SetDefinition(string definition)
        {
            this.definition = definition;
        }

        public int CompareTo(Information other)
        {
            return this.GetName().CompareTo(other.GetName());
        }
    }
    
}
