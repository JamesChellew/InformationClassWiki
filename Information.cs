using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace InformationClassWiki
{
    internal class Information : IComparable<Information>
    {
        // 6.1
        #region Private Properties
        private string name;
        private string category;
        private string structure;
        private string definition;
        #endregion

        #region Style Text
        private string StyleText(string s) // Return text in Title Case
        {
            TextInfo ti = new CultureInfo("en-US").TextInfo;
            return ti.ToTitleCase(s.Trim());
        }
        #endregion // This probably could be put in the Information class.

        #region Getters and Setters
        // get; set; Name
        public string GetName()
        {
            return name;
        }
        public void SetName(string _name)
        {
            if (!string.IsNullOrWhiteSpace(_name))
            {
                this.name = StyleText(_name);
            }
            else
            {
                this.name = "default";
            }
        }
        // get; set; Category
        public string GetCategory()
        {
            return category;
        }
        public void SetCategory(string _category)
        {
            if (!string.IsNullOrWhiteSpace(_category))
            {
                this.category = _category;
            }
            else
            {
                this.category = "";
            }
        }
        // get; set; Structure
        public string GetStructure()
        {
            return structure;
        }
        public void SetStructure(string _structure)
        {
            if (!string.IsNullOrWhiteSpace(_structure))
            {
                this.structure = _structure;
            }
            else
            {
                this.structure = "Linear";
            }
        }
        // get; set; Definition
        public string GetDefinition()
        {
            return definition;
        }
        public void SetDefinition(string _definition)
        {
            if (!string.IsNullOrEmpty(_definition))
            {
                this.definition = _definition;
            }
            else
            {
                this.definition = "Default";
            }
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
