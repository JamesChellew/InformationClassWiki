using System.Globalization;
using System.Text;

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
        private string StyleText(string s)
        {
            TextInfo ti = new CultureInfo("en-US").TextInfo;
            return ti.ToTitleCase(s.Trim());
        }
        private string GetRadioSelection()
        {
            if (RadioButtonLinear.Checked)
            {
                return "Linear";
            }
            else if (RadioButtonNonLinear.Checked)
            {
                return "Non-Linear";
            }
            else // should never be reached. Will fix later.
            {
                return "n/a";
            }
        } // returns a string of the selected button

        private void SetRadioSelection(int x)
        {
            if (x == 0)
            {
                RadioButtonLinear.Checked = true;
            }
            else if (x == 1)
            {
                RadioButtonNonLinear.Checked = true;
            }
            else
            {
                RadioButtonLinear.Checked = false;
                RadioButtonNonLinear.Checked = false;
            }
        } // checks a radio 0 = linear, 1 = nonLinear, else neither.

        private void LoadComboBox()
        {
            try
            {
                using FileStream file = new FileStream("Categories.txt", FileMode.Open);
                using StreamReader sr = new StreamReader(file);
                while (file.CanRead)
                {
                    string item = sr.ReadLine();
                    ComboBoxCategory.Items.Add(item);
                }
            }
            catch (Exception ex)
            {

            }
        } // Load comboBox options from text file

        private void DisplayList()
        {
            ListViewWiki.Items.Clear();
            wiki.Sort();
            foreach (Information w in wiki)
            {
                ListViewItem displayItem = new ListViewItem(w.GetName());
                displayItem.SubItems.Add(w.GetCategory());
                displayItem.SubItems.Add(w.GetStructure());
                ListViewWiki.Items.Add(displayItem);
            }
        } // Displays wiki<Information> contents.

        private void DisplayItemData(Information item)
        {
            ClearFields();
            TextBoxName.Text = item.GetName();
            ComboBoxCategory.Text = item.GetCategory();
            if (item.GetStructure() == "Linear")
            {
                SetRadioSelection(0);
            }
            else
            {
                SetRadioSelection(1);
            }
            TextBoxDefinition.Text = item.GetDefinition();
        }

        private void ClearFields()
        {
            TextBoxName.Clear();
            ComboBoxCategory.SelectedIndex = 0;
            SetRadioSelection(-1);
            TextBoxDefinition.Clear();
        } // Clears the Input Fields 

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
            if (String.IsNullOrWhiteSpace(TextBoxDefinition.Text))
            {
                return false;
            }
            else { return true; }
        }
        private bool AllFieldsFilled()
        {
            bool filled = true;
            string errorMessage = "Please Enter the Following Fields:";
            if (!IsNameEntered()) // Might be a way to simply this but not sure if worth the time rn
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

            if (filled) // I could just return filled but I want clarity here
            {
                return true;
            }
            else// Same thing, could just return filled.
            {
                MessageBox.Show(errorMessage, "Please Enter Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        #endregion
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            string name = TextBoxName.Text;
            string category = ComboBoxCategory.Text;
            string structure = GetRadioSelection();
            string definition = TextBoxDefinition.Text;
            name = StyleText(name);
            Information addItem = new Information(name, category, structure, definition);

            if (AllFieldsFilled() && !wiki.Exists(x => x.CompareTo(addItem) == 0))
            {
                wiki.Add(addItem);
                DisplayList();
            }
            else
            {
                MessageBox.Show(
                    "Definition for this name already exists.\n\nPlease enter another name.",
                    "Duplicate Entry",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                TextBoxName.Focus();
            }
        } // Adds entry to list
        private bool ValidName(string s) // dont know what to do with this yet.
        {
            foreach (Information item in wiki)
            {
                if (s == item.GetName())
                {
                    return false;
                }
            }
            return true;
        }

        private void InformationClassWiki_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        } //Performs on load methods

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        } // ClearFields

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            ListViewWiki.Items.Clear();
            wiki.Clear();
            ClearFields();
        } // ClearFields, Clear ListView, Clear List

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            TextInfo ti = new CultureInfo("en_AU").TextInfo;
            string searchTerm = ti.ToTitleCase(TextBoxSearch.Text.Trim());
            Information searchItem = new Information(searchTerm);
            if (!String.IsNullOrEmpty(searchTerm))
            {
                int index = wiki.BinarySearch(searchItem);

                if (index > -1)
                {
                    ListViewWiki.SelectedItems.Clear();
                    ListViewWiki.Items[index].Selected = true;
                }
                else
                {
                    TextBoxFeedback.Text = "Cannot be found";
                }
            }
        }
        private void ListViewWiki_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListViewWiki.SelectedItems.Count > 0)
            {
                int index = ListViewWiki.SelectedIndices[0];
                DisplayItemData(wiki[index]);
            }
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SavePrompt();
        }
        private void SavePrompt()
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Bin Files|*.bin";
            saveDialog.DefaultExt = "*.bin";
            saveDialog.Title = "Choose Where to Save Wiki";
            saveDialog.InitialDirectory = Application.StartupPath;

            DialogResult result = saveDialog.ShowDialog();
            string fileName = saveDialog.FileName;
            if (result == DialogResult.OK)
            {
                SaveFile(fileName);
            }
            else
            {
                TextBoxFeedback.Text = "Save File Cancelled";
            }
        }
        private void SaveFile(string fileName)
        {
            using FileStream fs = new FileStream(fileName, FileMode.Create);
            using BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8, false);
            foreach (Information x in wiki)
            {
                bw.Write(x.GetName());
                bw.Write(x.GetCategory());
                bw.Write(x.GetStructure());
                bw.Write(x.GetDefinition());
            }
        }


        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            OpenPrompt();
        }
        private void OpenPrompt() 
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Bin Files|*.bin";
            openDialog.DefaultExt = ".bin";
            openDialog.Title = "Choose a File to Load to Wiki";
            openDialog.InitialDirectory = Application.StartupPath;

            DialogResult result = openDialog.ShowDialog();
            string fileName = openDialog.FileName;
            if (result == DialogResult.OK)
            {
                OpenFile(fileName);
            }
            else
            {
                TextBoxFeedback.Text = "Open File Cancelled";
            }

        }
        private void OpenFile(string fileName)
        {
            using FileStream fs = new FileStream (fileName, FileMode.Open);
            using BinaryReader br = new BinaryReader(fs);
            wiki.Clear();
            while (fs.Position < fs.Length)
            {
                wiki.Add(new Information(br.ReadString(), br.ReadString(), br.ReadString(), br.ReadString()));
            }
            DisplayList();
        }
    }
}