namespace InformationClassWiki
{
    public partial class InformationClassWiki : Form
    {
        public InformationClassWiki()
        {
            InitializeComponent();
        }
        // Global List for wiki
        List<Information> wiki = new List<Information>();
        private string GetRadioSelection()
        {
            if (RadioButtonLinear.Checked)
            {
                return "Linear";
            }
            else if(RadioButtonNonLinear.Checked) 
            { 
                return "Non-Linear"; 
            }
            else // should never be reached. Will fix later.
            {
                return "n/a";
            }
        }
        #region Field Validations
        private bool IsNameEntered()
        {
            if (String.IsNullOrWhiteSpace(TextBoxName.Text))
            {
                return false;
            }
            else { return true; }
        }
        private bool IsCategoryEntered()
        {
            if (String.IsNullOrWhiteSpace(ComboBoxCategory.Text))
            {
                return false;
            }
            else { return true; }
        }
        private bool IsStructureEntered()
        {
            if ((RadioButtonLinear.Checked || RadioButtonNonLinear.Checked) == true)
            {
                return true;
            }
            else { return false; }
        }
        private bool IsDefinitionEntered()
        {
            if(String.IsNullOrWhiteSpace(TextBoxDefintion.Text))
            {
                return false;
            }
            else { return true; }
        }
        private void IsAllFieldsFilled()
        {
            bool filled = true;
            string errorMessage= "Please Enter the Following Fields:";
            if (!IsNameEntered())
            {
                filled = false;
                errorMessage += "\nName";
            }
            if (!IsCategoryEntered())
            {
                filled = false;
                errorMessage += "\nCategory";
            }
            if (!IsStructureEntered())
            {
                filled = false;
                errorMessage += "\nStructure";
            }
            if (!IsDefinitionEntered())
            {
                filled = false;
                errorMessage += "\nDefinition";
            }

            if (filled == true)
            {
                MessageBox.Show(errorMessage, "Please Enter Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            
        }
    }
}