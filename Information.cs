using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationClassWiki
{
    internal class Information : IComparable<Information>
    {
        // 6.1
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
        public void SetName(string _name)
        {
            this.name = _name;
        }
        // get; set; Category
        public string GetCategory()
        {
            return category;
        }
        public void SetCategory(string _category)
        {
            this.category = _category;
        }
        // get; set; Structure
        public string GetStructure()
        {
            return structure;
        }
        public void SetStructure(string _structure)
        {
            this.structure = _structure;
        }
        // get; set; Definition
        public string GetDefinition()
        {
            return definition;
        }
        public void SetDefinition(string _definition)
        {
            this.definition = _definition;
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
