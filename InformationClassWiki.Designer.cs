﻿namespace InformationClassWiki
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
            TextBoxDefintion = new TextBox();
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
            TextBoxName.Location = new Point(12, 26);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(257, 27);
            TextBoxName.TabIndex = 0;
            // 
            // ComboBoxCategory
            // 
            ComboBoxCategory.FormattingEnabled = true;
            ComboBoxCategory.Location = new Point(12, 80);
            ComboBoxCategory.Name = "ComboBoxCategory";
            ComboBoxCategory.Size = new Size(257, 28);
            ComboBoxCategory.TabIndex = 1;
            // 
            // GroupBoxStructure
            // 
            GroupBoxStructure.Controls.Add(RadioButtonNonLinear);
            GroupBoxStructure.Controls.Add(RadioButtonLinear);
            GroupBoxStructure.Location = new Point(12, 134);
            GroupBoxStructure.Name = "GroupBoxStructure";
            GroupBoxStructure.Size = new Size(257, 125);
            GroupBoxStructure.TabIndex = 2;
            GroupBoxStructure.TabStop = false;
            // 
            // RadioButtonNonLinear
            // 
            RadioButtonNonLinear.AutoSize = true;
            RadioButtonNonLinear.Location = new Point(6, 75);
            RadioButtonNonLinear.Name = "RadioButtonNonLinear";
            RadioButtonNonLinear.Size = new Size(104, 24);
            RadioButtonNonLinear.TabIndex = 1;
            RadioButtonNonLinear.TabStop = true;
            RadioButtonNonLinear.Text = "Non-Linear";
            RadioButtonNonLinear.UseVisualStyleBackColor = true;
            // 
            // RadioButtonLinear
            // 
            RadioButtonLinear.AutoSize = true;
            RadioButtonLinear.Location = new Point(6, 26);
            RadioButtonLinear.Name = "RadioButtonLinear";
            RadioButtonLinear.Size = new Size(70, 24);
            RadioButtonLinear.TabIndex = 0;
            RadioButtonLinear.TabStop = true;
            RadioButtonLinear.Text = "Linear";
            RadioButtonLinear.UseVisualStyleBackColor = true;
            // 
            // TextBoxDefintion
            // 
            TextBoxDefintion.Location = new Point(12, 285);
            TextBoxDefintion.Multiline = true;
            TextBoxDefintion.Name = "TextBoxDefintion";
            TextBoxDefintion.Size = new Size(257, 163);
            TextBoxDefintion.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 5;
            label2.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 262);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 6;
            label3.Text = "Definition";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 120);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 20;
            label4.Text = "Structure";
            // 
            // GroupBoxEditing
            // 
            GroupBoxEditing.Controls.Add(ButtonDelete);
            GroupBoxEditing.Controls.Add(ButtonEdit);
            GroupBoxEditing.Controls.Add(ButtonAdd);
            GroupBoxEditing.Location = new Point(286, 9);
            GroupBoxEditing.Name = "GroupBoxEditing";
            GroupBoxEditing.Size = new Size(193, 156);
            GroupBoxEditing.TabIndex = 4;
            GroupBoxEditing.TabStop = false;
            GroupBoxEditing.Text = "Data Editing";
            // 
            // ButtonDelete
            // 
            ButtonDelete.Location = new Point(49, 110);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(94, 29);
            ButtonDelete.TabIndex = 2;
            ButtonDelete.Text = "Delete";
            ButtonDelete.UseVisualStyleBackColor = true;
            // 
            // ButtonEdit
            // 
            ButtonEdit.Location = new Point(49, 66);
            ButtonEdit.Name = "ButtonEdit";
            ButtonEdit.Size = new Size(94, 29);
            ButtonEdit.TabIndex = 1;
            ButtonEdit.Text = "Edit";
            ButtonEdit.UseVisualStyleBackColor = true;
            // 
            // ButtonAdd
            // 
            ButtonAdd.Location = new Point(49, 22);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(94, 29);
            ButtonAdd.TabIndex = 0;
            ButtonAdd.Text = "Add";
            ButtonAdd.UseVisualStyleBackColor = true;
            // 
            // GroupBoxFileControls
            // 
            GroupBoxFileControls.Controls.Add(ButtonSave);
            GroupBoxFileControls.Controls.Add(ButtonOpen);
            GroupBoxFileControls.Location = new Point(286, 171);
            GroupBoxFileControls.Name = "GroupBoxFileControls";
            GroupBoxFileControls.Size = new Size(193, 135);
            GroupBoxFileControls.TabIndex = 5;
            GroupBoxFileControls.TabStop = false;
            GroupBoxFileControls.Text = "File Controls";
            // 
            // ButtonSave
            // 
            ButtonSave.Location = new Point(49, 82);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(94, 29);
            ButtonSave.TabIndex = 1;
            ButtonSave.Text = "Save";
            ButtonSave.UseVisualStyleBackColor = true;
            // 
            // ButtonOpen
            // 
            ButtonOpen.Location = new Point(49, 36);
            ButtonOpen.Name = "ButtonOpen";
            ButtonOpen.Size = new Size(94, 29);
            ButtonOpen.TabIndex = 0;
            ButtonOpen.Text = "Open";
            ButtonOpen.UseVisualStyleBackColor = true;
            // 
            // GroupBoxClear
            // 
            GroupBoxClear.Controls.Add(ButtonReset);
            GroupBoxClear.Controls.Add(ButtonClear);
            GroupBoxClear.Location = new Point(286, 312);
            GroupBoxClear.Name = "GroupBoxClear";
            GroupBoxClear.Size = new Size(193, 152);
            GroupBoxClear.TabIndex = 6;
            GroupBoxClear.TabStop = false;
            GroupBoxClear.Text = "Clear or Reset";
            // 
            // ButtonReset
            // 
            ButtonReset.Location = new Point(49, 96);
            ButtonReset.Name = "ButtonReset";
            ButtonReset.Size = new Size(94, 29);
            ButtonReset.TabIndex = 1;
            ButtonReset.Text = "Reset";
            ButtonReset.UseVisualStyleBackColor = true;
            // 
            // ButtonClear
            // 
            ButtonClear.Location = new Point(49, 36);
            ButtonClear.Name = "ButtonClear";
            ButtonClear.Size = new Size(94, 29);
            ButtonClear.TabIndex = 0;
            ButtonClear.Text = "Clear";
            ButtonClear.UseVisualStyleBackColor = true;
            // 
            // TextBoxSearch
            // 
            TextBoxSearch.Location = new Point(485, 28);
            TextBoxSearch.Name = "TextBoxSearch";
            TextBoxSearch.Size = new Size(203, 27);
            TextBoxSearch.TabIndex = 7;
            // 
            // ButtonSearch
            // 
            ButtonSearch.Location = new Point(694, 27);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(94, 29);
            ButtonSearch.TabIndex = 8;
            ButtonSearch.Text = "Search";
            ButtonSearch.UseVisualStyleBackColor = true;
            // 
            // ListViewWiki
            // 
            ListViewWiki.Location = new Point(485, 81);
            ListViewWiki.Name = "ListViewWiki";
            ListViewWiki.Size = new Size(303, 383);
            ListViewWiki.TabIndex = 9;
            ListViewWiki.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(485, 58);
            label5.Name = "label5";
            label5.Size = new Size(120, 20);
            label5.TabIndex = 14;
            label5.Text = "Information Wiki";
            // 
            // TextBoxFeedback
            // 
            TextBoxFeedback.Location = new Point(12, 470);
            TextBoxFeedback.Name = "TextBoxFeedback";
            TextBoxFeedback.ReadOnly = true;
            TextBoxFeedback.Size = new Size(776, 27);
            TextBoxFeedback.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 451);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 16;
            label6.Text = "Feedback";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(485, 9);
            label7.Name = "label7";
            label7.Size = new Size(86, 20);
            label7.TabIndex = 17;
            label7.Text = "Search Wiki";
            // 
            // InformationClassWiki
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 505);
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
            Controls.Add(TextBoxDefintion);
            Controls.Add(GroupBoxStructure);
            Controls.Add(ComboBoxCategory);
            Controls.Add(TextBoxName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "InformationClassWiki";
            Text = "Information Class Wiki";
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
        private TextBox TextBoxDefintion;
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
    }
}