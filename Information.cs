using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationClassWiki
{
    internal class Information : IComparable<Information>
    {
        #region Private Properties
        private string name;
        private string? category;
        private string? structure;
        private string? definition;
        #endregion

        #region Getters and Setters
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
        // get; set; Structure
        public string GetStructure()
        {
            return structure;
        }
        public void SetStructure(string structure)
        {
            this.structure = structure;
        }
        // get; set; Definition
        public string GetDefinition()
        {
            return definition;
        }
        public void SetDefinition(string definition)
        {
            this.definition = definition;
        }
        #endregion

        #region Constructors
        public Information(string name) // This Creates a temp object for Binary Search which uses the IComparable to compare names.
        { 
            SetName(name);
        }
        public Information(string name, string category, string structure, string definition)
        {
                SetName(name);
                SetCategory(category);
                SetStructure(structure);
                SetDefinition(definition);
        }
        #endregion

        #region CompareTo IComparable method
        public int CompareTo(Information other)
        {
            return this.GetName().CompareTo(other.GetName());
        }
        #endregion
    }
}
