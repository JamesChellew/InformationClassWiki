namespace InformationClassWiki
{
    partial class InformationClassWiki
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationClassWiki));
            TextBoxName = new TextBox();
            ComboBoxCategory = new ComboBox();
            GroupBoxStructure = new GroupBox();
            RadioButtonNonLinear = new RadioButton();
            RadioButtonLinear = new RadioButton();
            TextBoxDefinition = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            GroupBoxEditing = new GroupBox();
            ButtonDelete = new Button();
            ButtonEdit = new Button();
            ButtonAdd = new Button();
            GroupBoxFileControls = new GroupBox();
            ButtonSave = new Button();
            ButtonOpen = new Button();
            GroupBoxClear = new GroupBox();
            ButtonReset = new Button();
            ButtonClear = new Button();
            TextBoxSearch = new TextBox();
            ButtonSearch = new Button();
            ListViewWiki = new ListView();
            ColumnName = new ColumnHeader();
            ColumnCategory = new ColumnHeader();
            ColumnStructure = new ColumnHeader();
            label5 = new Label();
            TextBoxFeedback = new TextBox();
            label6 = new Label();
            label7 = new Label();
            GroupBoxStructure.SuspendLayout();
            GroupBoxEditing.SuspendLayout();
            GroupBoxFileControls.SuspendLayout();
            GroupBoxClear.SuspendLayout();
            SuspendLayout();
            // 
            // TextBoxName
            // 
            TextBoxName.Location = new Point(10, 20);
            TextBoxName.Margin = new Padding(3, 2, 3, 2);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(225, 23);
            TextBoxName.TabIndex = 0;
            // 
            // ComboBoxCategory
            // 
            ComboBoxCategory.FormattingEnabled = true;
            ComboBoxCategory.Location = new Point(10, 60);
            ComboBoxCategory.Margin = new Padding(3, 2, 3, 2);
            ComboBoxCategory.Name = "ComboBoxCategory";
            ComboBoxCategory.Size = new Size(225, 23);
            ComboBoxCategory.TabIndex = 1;
            // 
            // GroupBoxStructure
            // 
            GroupBoxStructure.Controls.Add(RadioButtonNonLinear);
            GroupBoxStructure.Controls.Add(RadioButtonLinear);
            GroupBoxStructure.Location = new Point(10, 100);
            GroupBoxStructure.Margin = new Padding(3, 2, 3, 2);
            GroupBoxStructure.Name = "GroupBoxStructure";
            GroupBoxStructure.Padding = new Padding(3, 2, 3, 2);
            GroupBoxStructure.Size = new Size(225, 94);
            GroupBoxStructure.TabIndex = 2;
            GroupBoxStructure.TabStop = false;
            // 
            // RadioButtonNonLinear
            // 
            RadioButtonNonLinear.AutoSize = true;
            RadioButtonNonLinear.Location = new Point(5, 56);
            RadioButtonNonLinear.Margin = new Padding(3, 2, 3, 2);
            RadioButtonNonLinear.Name = "RadioButtonNonLinear";
            RadioButtonNonLinear.Size = new Size(85, 19);
            RadioButtonNonLinear.TabIndex = 1;
            RadioButtonNonLinear.TabStop = true;
            RadioButtonNonLinear.Text = "Non-Linear";
            RadioButtonNonLinear.UseVisualStyleBackColor = true;
            // 
            // RadioButtonLinear
            // 
            RadioButtonLinear.AutoSize = true;
            RadioButtonLinear.Location = new Point(5, 20);
            RadioButtonLinear.Margin = new Padding(3, 2, 3, 2);
            RadioButtonLinear.Name = "RadioButtonLinear";
            RadioButtonLinear.Size = new Size(57, 19);
            RadioButtonLinear.TabIndex = 0;
            RadioButtonLinear.TabStop = true;
            RadioButtonLinear.Text = "Linear";
            RadioButtonLinear.UseVisualStyleBackColor = true;
            // 
            // TextBoxDefinition
            // 
            TextBoxDefinition.Location = new Point(10, 214);
            TextBoxDefinition.Margin = new Padding(3, 2, 3, 2);
            TextBoxDefinition.Multiline = true;
            TextBoxDefinition.Name = "TextBoxDefinition";
            TextBoxDefinition.Size = new Size(225, 123);
            TextBoxDefinition.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 43);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 5;
            label2.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 196);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 6;
            label3.Text = "Definition";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 90);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 20;
            label4.Text = "Structure";
            // 
            // GroupBoxEditing
            // 
            GroupBoxEditing.Controls.Add(ButtonDelete);
            GroupBoxEditing.Controls.Add(ButtonEdit);
            GroupBoxEditing.Controls.Add(ButtonAdd);
            GroupBoxEditing.Location = new Point(250, 7);
            GroupBoxEditing.Margin = new Padding(3, 2, 3, 2);
            GroupBoxEditing.Name = "GroupBoxEditing";
            GroupBoxEditing.Padding = new Padding(3, 2, 3, 2);
            GroupBoxEditing.Size = new Size(169, 117);
            GroupBoxEditing.TabIndex = 4;
            GroupBoxEditing.TabStop = false;
            GroupBoxEditing.Text = "Data Editing";
            // 
            // ButtonDelete
            // 
            ButtonDelete.Location = new Point(43, 82);
            ButtonDelete.Margin = new Padding(3, 2, 3, 2);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(82, 22);
            ButtonDelete.TabIndex = 2;
            ButtonDelete.Text = "Delete";
            ButtonDelete.UseVisualStyleBackColor = true;
            // 
            // ButtonEdit
            // 
            ButtonEdit.Location = new Point(43, 50);
            ButtonEdit.Margin = new Padding(3, 2, 3, 2);
            ButtonEdit.Name = "ButtonEdit";
            ButtonEdit.Size = new Size(82, 22);
            ButtonEdit.TabIndex = 1;
            ButtonEdit.Text = "Edit";
            ButtonEdit.UseVisualStyleBackColor = true;
            // 
            // ButtonAdd
            // 
            ButtonAdd.Location = new Point(43, 16);
            ButtonAdd.Margin = new Padding(3, 2, 3, 2);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(82, 22);
            ButtonAdd.TabIndex = 0;
            ButtonAdd.Text = "Add";
            ButtonAdd.UseVisualStyleBackColor = true;
            ButtonAdd.Click += ButtonAdd_Click;
            // 
            // GroupBoxFileControls
            // 
            GroupBoxFileControls.Controls.Add(ButtonSave);
            GroupBoxFileControls.Controls.Add(ButtonOpen);
            GroupBoxFileControls.Location = new Point(250, 128);
            GroupBoxFileControls.Margin = new Padding(3, 2, 3, 2);
            GroupBoxFileControls.Name = "GroupBoxFileControls";
            GroupBoxFileControls.Padding = new Padding(3, 2, 3, 2);
            GroupBoxFileControls.Size = new Size(169, 101);
            GroupBoxFileControls.TabIndex = 5;
            GroupBoxFileControls.TabStop = false;
            GroupBoxFileControls.Text = "File Controls";
            // 
            // ButtonSave
            // 
            ButtonSave.Location = new Point(43, 62);
            ButtonSave.Margin = new Padding(3, 2, 3, 2);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(82, 22);
            ButtonSave.TabIndex = 1;
            ButtonSave.Text = "Save";
            ButtonSave.UseVisualStyleBackColor = true;
            ButtonSave.Click += ButtonSave_Click;
            // 
            // ButtonOpen
            // 
            ButtonOpen.Location = new Point(43, 27);
            ButtonOpen.Margin = new Padding(3, 2, 3, 2);
            ButtonOpen.Name = "ButtonOpen";
            ButtonOpen.Size = new Size(82, 22);
            ButtonOpen.TabIndex = 0;
            ButtonOpen.Text = "Open";
            ButtonOpen.UseVisualStyleBackColor = true;
            ButtonOpen.Click += ButtonOpen_Click;
            // 
            // GroupBoxClear
            // 
            GroupBoxClear.Controls.Add(ButtonReset);
            GroupBoxClear.Controls.Add(ButtonClear);
            GroupBoxClear.Location = new Point(250, 234);
            GroupBoxClear.Margin = new Padding(3, 2, 3, 2);
            GroupBoxClear.Name = "GroupBoxClear";
            GroupBoxClear.Padding = new Padding(3, 2, 3, 2);
            GroupBoxClear.Size = new Size(169, 114);
            GroupBoxClear.TabIndex = 6;
            GroupBoxClear.TabStop = false;
            GroupBoxClear.Text = "Clear or Reset";
            // 
            // ButtonReset
            // 
            ButtonReset.Location = new Point(43, 72);
            ButtonReset.Margin = new Padding(3, 2, 3, 2);
            ButtonReset.Name = "ButtonReset";
            ButtonReset.Size = new Size(82, 22);
            ButtonReset.TabIndex = 1;
            ButtonReset.Text = "Reset";
            ButtonReset.UseVisualStyleBackColor = true;
            ButtonReset.Click += ButtonReset_Click;
            // 
            // ButtonClear
            // 
            ButtonClear.Location = new Point(43, 27);
            ButtonClear.Margin = new Padding(3, 2, 3, 2);
            ButtonClear.Name = "ButtonClear";
            ButtonClear.Size = new Size(82, 22);
            ButtonClear.TabIndex = 0;
            ButtonClear.Text = "Clear";
            ButtonClear.UseVisualStyleBackColor = true;
            ButtonClear.Click += ButtonClear_Click;
            // 
            // TextBoxSearch
            // 
            TextBoxSearch.Location = new Point(424, 21);
            TextBoxSearch.Margin = new Padding(3, 2, 3, 2);
            TextBoxSearch.Name = "TextBoxSearch";
            TextBoxSearch.Size = new Size(178, 23);
            TextBoxSearch.TabIndex = 7;
            // 
            // ButtonSearch
            // 
            ButtonSearch.Location = new Point(607, 20);
            ButtonSearch.Margin = new Padding(3, 2, 3, 2);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(82, 22);
            ButtonSearch.TabIndex = 8;
            ButtonSearch.Text = "Search";
            ButtonSearch.UseVisualStyleBackColor = true;
            ButtonSearch.Click += ButtonSearch_Click;
            // 
            // ListViewWiki
            // 
            ListViewWiki.Columns.AddRange(new ColumnHeader[] { ColumnName, ColumnCategory, ColumnStructure });
            ListViewWiki.Location = new Point(424, 61);
            ListViewWiki.Margin = new Padding(3, 2, 3, 2);
            ListViewWiki.MultiSelect = false;
            ListViewWiki.Name = "ListViewWiki";
            ListViewWiki.Size = new Size(266, 288);
            ListViewWiki.TabIndex = 9;
            ListViewWiki.UseCompatibleStateImageBehavior = false;
            ListViewWiki.View = View.Details;
            ListViewWiki.SelectedIndexChanged += ListViewWiki_SelectedIndexChanged;
            // 
            // ColumnName
            // 
            ColumnName.Text = "Name";
            ColumnName.Width = 100;
            // 
            // ColumnCategory
            // 
            ColumnCategory.Text = "Category";
            ColumnCategory.Width = 75;
            // 
            // ColumnStructure
            // 
            ColumnStructure.Text = "Structure";
            ColumnStructure.Width = 75;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(424, 44);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 14;
            label5.Text = "Information Wiki";
            // 
            // TextBoxFeedback
            // 
            TextBoxFeedback.Location = new Point(10, 352);
            TextBoxFeedback.Margin = new Padding(3, 2, 3, 2);
            TextBoxFeedback.Name = "TextBoxFeedback";
            TextBoxFeedback.ReadOnly = true;
            TextBoxFeedback.Size = new Size(680, 23);
            TextBoxFeedback.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 338);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 16;
            label6.Text = "Feedback";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(424, 7);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 17;
            label7.Text = "Search Wiki";
            // 
            // InformationClassWiki
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 379);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(TextBoxFeedback);
            Controls.Add(label5);
            Controls.Add(ListViewWiki);
            Controls.Add(ButtonSearch);
            Controls.Add(TextBoxSearch);
            Controls.Add(GroupBoxClear);
            Controls.Add(GroupBoxFileControls);
            Controls.Add(GroupBoxEditing);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TextBoxDefinition);
            Controls.Add(GroupBoxStructure);
            Controls.Add(ComboBoxCategory);
            Controls.Add(TextBoxName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "InformationClassWiki";
            Text = "Information Class Wiki";
            Load += InformationClassWiki_Load;
            GroupBoxStructure.ResumeLayout(false);
            GroupBoxStructure.PerformLayout();
            GroupBoxEditing.ResumeLayout(false);
            GroupBoxFileControls.ResumeLayout(false);
            GroupBoxClear.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxName;
        private ComboBox ComboBoxCategory;
        private GroupBox GroupBoxStructure;
        private RadioButton RadioButtonNonLinear;
        private RadioButton RadioButtonLinear;
        private TextBox TextBoxDefinition;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox GroupBoxEditing;
        private Button ButtonDelete;
        private Button ButtonEdit;
        private Button ButtonAdd;
        private GroupBox GroupBoxFileControls;
        private Button ButtonSave;
        private Button ButtonOpen;
        private GroupBox GroupBoxClear;
        private Button ButtonReset;
        private Button ButtonClear;
        private TextBox TextBoxSearch;
        private Button ButtonSearch;
        private ListView ListViewWiki;
        private Label label5;
        private TextBox TextBoxFeedback;
        private Label label6;
        private Label label7;
        private ColumnHeader ColumnName;
        private ColumnHeader ColumnCategory;
        private ColumnHeader ColumnStructure;
    }
}