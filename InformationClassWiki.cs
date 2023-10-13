using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Text;
using System.Web;

namespace InformationClassWiki
{
    public partial class InformationClassWiki : Form
    {
        public InformationClassWiki()
        {
            InitializeComponent();
        }
        #region Form Load Q6.2, 6.4
        List<Information> wiki = new List<Information>(); // 6.2 Global List for wiki
        private void InformationClassWiki_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        } //Performs on load methods
        private void LoadComboBox()
        {
            string[] loadComboData = File.ReadAllLines(@"Categories.txt");
            foreach (string x in loadComboData)
            {
                ComboBoxCategory.Items.Add(x);
            }
        } // Reads all lines from file and puts it into the combobox
        // Modified to take less lines based on Code from course resources.
        #endregion
        #region Style Text
        private string StyleText(string s) // Return text in Title Case
        {
            TextInfo ti = new CultureInfo("en-US").TextInfo;
            return ti.ToTitleCase(s.Trim());
        }
        #endregion // This probably could be put in the Information class.
        #region Radio Option Get and Set Q6.6
        private string GetRadioSelection()
        {
            foreach (RadioButton radio in GroupBoxStructure.Controls)
            {
                if (radio.Checked)
                {
                    return radio.Text;
                }
            }
            return "";
        } // returns a string of the selected button
        // Modified this so it will work if other options were added later.
        private void SetRadioSelection(int index)
        {
            if (index >= 0)
            {
                foreach (RadioButton radio in GroupBoxStructure.Controls.OfType<RadioButton>())
                {
                    if (radio.Text == wiki[index].GetStructure())
                    {
                        radio.Checked = true;
                    }
                }
            }
            else
            {
                foreach (RadioButton radio in GroupBoxStructure.Controls.OfType<RadioButton>())
                {
                    radio.Checked = false;
                }
            }
        } // Will select the radio button base from the index of item in wiki.
        // Modified this so that it will work if another option was added later.
        #endregion
        #region Display List and Items Q6.9 Q6.11
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
        private void DisplayItemData(int index)
        {
            ClearFields();
            var item = wiki[index];
            TextBoxName.Text = item.GetName();
            ComboBoxCategory.Text = item.GetCategory();
            SetRadioSelection(index);
            TextBoxDefinition.Text = item.GetDefinition();
        } // Display Item Information into entry fields
        private void ListViewWiki_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListViewWiki.SelectedItems.Count > 0)
            {
                DisplayItemData(ListViewWiki.SelectedIndices[0]);
            }
        } //Checks for selection event
        #endregion
        #region Validations Q6.5
        private bool IsFieldFilled(string field)
        {
            if (string.IsNullOrWhiteSpace(field))
            {
                return false;
            }
            return true;
        }
        private bool AllFieldsFilled()
        {
            bool filled = true;
            string errorMessage = "Please Enter the Following Fields:";
            if (!IsFieldFilled(TextBoxName.Text))
            {
                filled = false;
                errorMessage += "\nName";
            }
            if (!IsFieldFilled(ComboBoxCategory.Text))
            {
                filled = false;
                errorMessage += "\nCategory";
            }
            if (!IsFieldFilled(GetRadioSelection()))
            {
                filled = false;
                errorMessage += "\nStructure";
            }
            if (!IsFieldFilled(TextBoxDefinition.Text))
            {
                filled = false;
                errorMessage += "\nDefinition";
            }
            if (filled)
            {
                return true;
            }
            else
            {
                MessageBox.Show(errorMessage, "Please Enter Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TextBoxName.Focus();
                return false;
            }
        }
        private bool ValidName(string s) // Returns true if there are no matching names in wiki
        {
            return !wiki.Exists(x => x.GetName().Equals(s));
        }
        #endregion
        #region Add Q6.3
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            string name = StyleText(TextBoxName.Text); // for clarity
            string category = ComboBoxCategory.Text;
            string structure = GetRadioSelection();
            string definition = TextBoxDefinition.Text;
            if (AllFieldsFilled() && ValidName(name))
            {
                Information item = new Information(name, category, structure, definition);
                wiki.Add(item);
                TextBoxFeedback.Text = $"{item.GetName()} Was Added";
                DisplayList();
                return;
            }
            if (!ValidName(name))
            {
                MessageBox.Show(
                    "Definition for this name already exists.\n\nPlease enter another name.",
                    "Duplicate Entry",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                TextBoxName.Focus();
            }
        } // Q6.3 Adds entry to list
        #endregion
        #region Delete Q6.7
        private void DeleteItem()
        {
            if (ListViewWiki.SelectedItems.Count > 0)
            {
                DialogResult delete = MessageBox.Show
                    ("Are you sure you want to delete this item?",
                    "Deletion Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (delete == DialogResult.Yes)
                {
                    wiki.RemoveAt(ListViewWiki.SelectedIndices[0]);
                    TextBoxFeedback.Text = "Selected Item was deleted";
                    DisplayList();
                }
                else { TextBoxFeedback.Text = "Did not delete selection"; }
            }
            else { TextBoxFeedback.Text = "No item selected to delete."; }
        } // Delete item at selected index
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            DeleteItem();
        } // Delete on button click event
        private void ListViewWiki_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DeleteItem();
        } // delete on list view double click event
        #endregion
        #region Edit Q6.8
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (ListViewWiki.SelectedItems.Count > 0)
            {
                int index = ListViewWiki.SelectedIndices[0];
                Information item = wiki[index];
                string name = StyleText(TextBoxName.Text);
                if (AllFieldsFilled() && ValidName(name))
                {
                    item.SetName(StyleText(name));
                    item.SetCategory(ComboBoxCategory.Text);
                    item.SetStructure(GetRadioSelection());
                    item.SetDefinition(TextBoxDefinition.Text);
                    wiki[index] = item;
                    TextBoxFeedback.Text = "Item Edited";
                    DisplayList();
                }
                if (!ValidName(name))
                {
                    MessageBox.Show("Cannot change data as that name already exists in the Wiki", "Name Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                TextBoxFeedback.Text = "Noting selected to edit";
            }
        }
        #endregion
        #region Search Q6.10
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = StyleText(TextBoxSearch.Text);
            if (!String.IsNullOrEmpty(searchTerm))
            {
                Information searchItem = new Information(searchTerm);
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
        #endregion
        #region Clear and Reset Q6.12 Q6.13
        private void ClearFields()
        {
            TextBoxName.Clear();
            ComboBoxCategory.SelectedIndex = 0;
            SetRadioSelection(-1); // -1 outside of index range so will uncheck radios.
            TextBoxDefinition.Clear();
        } // Clears the Input Fields 
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            ListViewWiki.SelectedItems.Clear();
            ClearFields();
        } // ClearFields
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            ListViewWiki.Items.Clear();
            wiki.Clear();
            ClearFields();
        } // ClearFields, Clear ListView, Clear List
        private void TextBoxName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ClearFields();
        }
        #endregion
        #region Save File Q6.14
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SavePrompt();
        }
        private bool SavePrompt()
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
                return true;
            }
            else
            {
                TextBoxFeedback.Text = "Save File Cancelled";
                return false;
            }
        }
        private void SaveFile(string fileName)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "File Save Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Open File Q6.14
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
            try
            {
                using FileStream fs = new FileStream(fileName, FileMode.Open);
                using BinaryReader br = new BinaryReader(fs);
                wiki.Clear();
                while (fs.Position < fs.Length)
                {
                    wiki.Add(new Information(br.ReadString(), br.ReadString(), br.ReadString(), br.ReadString()));
                }
                DisplayList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Open File Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Form Closing Q6.15
        private void InformationClassWiki_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Your information will be lost\n\nWould you like to save before exiting?",
                "Exit Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                bool saveAndClose = SavePrompt();
                if (!saveAndClose)
                {
                    e.Cancel = true;
                }
            }
        }
        #endregion
    }
}