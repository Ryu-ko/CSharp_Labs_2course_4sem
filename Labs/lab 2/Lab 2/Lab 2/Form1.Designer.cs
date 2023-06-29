namespace Lab_2
{
    partial class Library
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
            this.components = new System.ComponentModel.Container();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.textBoxAuthorName = new System.Windows.Forms.TextBox();
            this.textBoxAuthorCountry = new System.Windows.Forms.TextBox();
            this.maskedTextBoxAuthorID = new System.Windows.Forms.MaskedTextBox();
            this.errorProviderApp = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelBook = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.groupBoxFormat = new System.Windows.Forms.GroupBox();
            this.radioButtonTXT = new System.Windows.Forms.RadioButton();
            this.radioButtonFB2 = new System.Windows.Forms.RadioButton();
            this.radioButtonPDF = new System.Windows.Forms.RadioButton();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.hScrollBarFileSize = new System.Windows.Forms.HScrollBar();
            this.labelFileSize = new System.Windows.Forms.Label();
            this.richTextBoxAuthorsAndLinks = new System.Windows.Forms.RichTextBox();
            this.labelauthorsAndLinks = new System.Windows.Forms.Label();
            this.checkBoxFree = new System.Windows.Forms.CheckBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.maskedTextBoxYear = new System.Windows.Forms.MaskedTextBox();
            this.labelUDC = new System.Windows.Forms.Label();
            this.textBoxUDC = new System.Windows.Forms.TextBox();
            this.textBoxPublisher = new System.Windows.Forms.TextBox();
            this.textBoxPages = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelUploadDate = new System.Windows.Forms.Label();
            this.numericUpDownChapters = new System.Windows.Forms.NumericUpDown();
            this.labelChapters = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).BeginInit();
            this.groupBoxFormat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChapters)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(261, 12);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(54, 20);
            this.labelAuthor.TabIndex = 0;
            this.labelAuthor.Text = "Author";
            // 
            // textBoxAuthorName
            // 
            this.textBoxAuthorName.Location = new System.Drawing.Point(261, 36);
            this.textBoxAuthorName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAuthorName.Name = "textBoxAuthorName";
            this.textBoxAuthorName.PlaceholderText = "Name";
            this.textBoxAuthorName.Size = new System.Drawing.Size(228, 27);
            this.textBoxAuthorName.TabIndex = 1;
            this.textBoxAuthorName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAuthorName_Validating);
            this.textBoxAuthorName.Validated += new System.EventHandler(this.textBoxAuthorName_Validated);
            // 
            // textBoxAuthorCountry
            // 
            this.textBoxAuthorCountry.Location = new System.Drawing.Point(261, 75);
            this.textBoxAuthorCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAuthorCountry.Name = "textBoxAuthorCountry";
            this.textBoxAuthorCountry.PlaceholderText = "Country";
            this.textBoxAuthorCountry.Size = new System.Drawing.Size(228, 27);
            this.textBoxAuthorCountry.TabIndex = 2;
            this.textBoxAuthorCountry.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAuthorCountry_Validating);
            this.textBoxAuthorCountry.Validated += new System.EventHandler(this.textBoxAuthorCountry_Validated);
            // 
            // maskedTextBoxAuthorID
            // 
            this.maskedTextBoxAuthorID.Location = new System.Drawing.Point(261, 133);
            this.maskedTextBoxAuthorID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maskedTextBoxAuthorID.Mask = "0000";
            this.maskedTextBoxAuthorID.Name = "maskedTextBoxAuthorID";
            this.maskedTextBoxAuthorID.Size = new System.Drawing.Size(228, 27);
            this.maskedTextBoxAuthorID.TabIndex = 3;
            this.maskedTextBoxAuthorID.ValidatingType = typeof(int);
            this.maskedTextBoxAuthorID.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBoxAuthorID_Validating);
            this.maskedTextBoxAuthorID.Validated += new System.EventHandler(this.maskedTextBoxAuthorID_Validated);
            // 
            // errorProviderApp
            // 
            this.errorProviderApp.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderApp.ContainerControl = this;
            // 
            // labelBook
            // 
            this.labelBook.AutoSize = true;
            this.labelBook.Location = new System.Drawing.Point(14, 12);
            this.labelBook.Name = "labelBook";
            this.labelBook.Size = new System.Drawing.Size(43, 20);
            this.labelBook.TabIndex = 4;
            this.labelBook.Text = "Book";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(261, 109);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(27, 20);
            this.labelID.TabIndex = 5;
            this.labelID.Text = "ID:";
            // 
            // groupBoxFormat
            // 
            this.groupBoxFormat.Controls.Add(this.radioButtonTXT);
            this.groupBoxFormat.Controls.Add(this.radioButtonFB2);
            this.groupBoxFormat.Controls.Add(this.radioButtonPDF);
            this.groupBoxFormat.Location = new System.Drawing.Point(14, 425);
            this.groupBoxFormat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxFormat.Name = "groupBoxFormat";
            this.groupBoxFormat.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxFormat.Size = new System.Drawing.Size(229, 133);
            this.groupBoxFormat.TabIndex = 7;
            this.groupBoxFormat.TabStop = false;
            this.groupBoxFormat.Text = "Format";
            this.groupBoxFormat.Leave += new System.EventHandler(this.groupBoxFormat_Leave);
            // 
            // radioButtonTXT
            // 
            this.radioButtonTXT.AutoSize = true;
            this.radioButtonTXT.Location = new System.Drawing.Point(7, 96);
            this.radioButtonTXT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonTXT.Name = "radioButtonTXT";
            this.radioButtonTXT.Size = new System.Drawing.Size(55, 24);
            this.radioButtonTXT.TabIndex = 2;
            this.radioButtonTXT.Text = "TXT";
            this.radioButtonTXT.UseVisualStyleBackColor = true;
            // 
            // radioButtonFB2
            // 
            this.radioButtonFB2.AutoSize = true;
            this.radioButtonFB2.Location = new System.Drawing.Point(7, 63);
            this.radioButtonFB2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonFB2.Name = "radioButtonFB2";
            this.radioButtonFB2.Size = new System.Drawing.Size(54, 24);
            this.radioButtonFB2.TabIndex = 1;
            this.radioButtonFB2.Text = "FB2";
            this.radioButtonFB2.UseVisualStyleBackColor = true;
            // 
            // radioButtonPDF
            // 
            this.radioButtonPDF.AutoSize = true;
            this.radioButtonPDF.Checked = true;
            this.radioButtonPDF.Location = new System.Drawing.Point(7, 29);
            this.radioButtonPDF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonPDF.Name = "radioButtonPDF";
            this.radioButtonPDF.Size = new System.Drawing.Size(56, 24);
            this.radioButtonPDF.TabIndex = 0;
            this.radioButtonPDF.TabStop = true;
            this.radioButtonPDF.Text = "PDF";
            this.radioButtonPDF.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(14, 605);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(86, 31);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(106, 605);
            this.buttonLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(86, 31);
            this.buttonLoad.TabIndex = 9;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(14, 36);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PlaceholderText = "Name";
            this.textBoxName.Size = new System.Drawing.Size(228, 27);
            this.textBoxName.TabIndex = 10;
            this.textBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxName_Validating);
            this.textBoxName.Validated += new System.EventHandler(this.textBoxName_Validated);
            // 
            // hScrollBarFileSize
            // 
            this.hScrollBarFileSize.Location = new System.Drawing.Point(264, 348);
            this.hScrollBarFileSize.Name = "hScrollBarFileSize";
            this.hScrollBarFileSize.Size = new System.Drawing.Size(229, 17);
            this.hScrollBarFileSize.TabIndex = 11;
            this.hScrollBarFileSize.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarFileSize_Scroll);
            // 
            // labelFileSize
            // 
            this.labelFileSize.AutoSize = true;
            this.labelFileSize.Location = new System.Drawing.Point(261, 324);
            this.labelFileSize.Name = "labelFileSize";
            this.labelFileSize.Size = new System.Drawing.Size(103, 20);
            this.labelFileSize.TabIndex = 12;
            this.labelFileSize.Text = "File size: small";
            // 
            // richTextBoxAuthorsAndLinks
            // 
            this.richTextBoxAuthorsAndLinks.Location = new System.Drawing.Point(14, 289);
            this.richTextBoxAuthorsAndLinks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBoxAuthorsAndLinks.Name = "richTextBoxAuthorsAndLinks";
            this.richTextBoxAuthorsAndLinks.Size = new System.Drawing.Size(228, 127);
            this.richTextBoxAuthorsAndLinks.TabIndex = 13;
            this.richTextBoxAuthorsAndLinks.Text = "";
            this.richTextBoxAuthorsAndLinks.TextChanged += new System.EventHandler(this.richTextBoxAuthorsAndLinks_TextChanged);
            // 
            // labelauthorsAndLinks
            // 
            this.labelauthorsAndLinks.AutoSize = true;
            this.labelauthorsAndLinks.Location = new System.Drawing.Point(14, 265);
            this.labelauthorsAndLinks.Name = "labelauthorsAndLinks";
            this.labelauthorsAndLinks.Size = new System.Drawing.Size(125, 20);
            this.labelauthorsAndLinks.TabIndex = 14;
            this.labelauthorsAndLinks.Text = "Authors and links:";
            // 
            // checkBoxFree
            // 
            this.checkBoxFree.AutoSize = true;
            this.checkBoxFree.Location = new System.Drawing.Point(261, 392);
            this.checkBoxFree.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxFree.Name = "checkBoxFree";
            this.checkBoxFree.Size = new System.Drawing.Size(59, 24);
            this.checkBoxFree.TabIndex = 15;
            this.checkBoxFree.Text = "Free";
            this.checkBoxFree.UseVisualStyleBackColor = true;
            this.checkBoxFree.CheckedChanged += new System.EventHandler(this.checkBoxFree_CheckedChanged);
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(135, 109);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(40, 20);
            this.labelYear.TabIndex = 17;
            this.labelYear.Text = "Year:";
            // 
            // maskedTextBoxYear
            // 
            this.maskedTextBoxYear.Location = new System.Drawing.Point(135, 133);
            this.maskedTextBoxYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maskedTextBoxYear.Mask = "0000";
            this.maskedTextBoxYear.Name = "maskedTextBoxYear";
            this.maskedTextBoxYear.Size = new System.Drawing.Size(107, 27);
            this.maskedTextBoxYear.TabIndex = 16;
            this.maskedTextBoxYear.ValidatingType = typeof(int);
            this.maskedTextBoxYear.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBoxYear_Validating);
            this.maskedTextBoxYear.Validated += new System.EventHandler(this.maskedTextBoxYear_Validated);
            // 
            // labelUDC
            // 
            this.labelUDC.AutoSize = true;
            this.labelUDC.Location = new System.Drawing.Point(14, 109);
            this.labelUDC.Name = "labelUDC";
            this.labelUDC.Size = new System.Drawing.Size(42, 20);
            this.labelUDC.TabIndex = 19;
            this.labelUDC.Text = "UDC:";
            // 
            // textBoxUDC
            // 
            this.textBoxUDC.Location = new System.Drawing.Point(14, 133);
            this.textBoxUDC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxUDC.Name = "textBoxUDC";
            this.textBoxUDC.Size = new System.Drawing.Size(114, 27);
            this.textBoxUDC.TabIndex = 20;
            this.textBoxUDC.TextChanged += new System.EventHandler(this.textBoxUDC_TextChanged);
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.Location = new System.Drawing.Point(14, 75);
            this.textBoxPublisher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.PlaceholderText = "Publisher";
            this.textBoxPublisher.Size = new System.Drawing.Size(228, 27);
            this.textBoxPublisher.TabIndex = 21;
            this.textBoxPublisher.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPublisher_Validating);
            this.textBoxPublisher.Validated += new System.EventHandler(this.textBoxPublisher_Validated);
            // 
            // textBoxPages
            // 
            this.textBoxPages.Location = new System.Drawing.Point(14, 172);
            this.textBoxPages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPages.Name = "textBoxPages";
            this.textBoxPages.PlaceholderText = "Pages";
            this.textBoxPages.Size = new System.Drawing.Size(228, 27);
            this.textBoxPages.TabIndex = 22;
            this.textBoxPages.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPages_Validating);
            this.textBoxPages.Validated += new System.EventHandler(this.textBoxPages_Validated);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(261, 289);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(228, 27);
            this.dateTimePicker.TabIndex = 23;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // labelUploadDate
            // 
            this.labelUploadDate.AutoSize = true;
            this.labelUploadDate.Location = new System.Drawing.Point(261, 265);
            this.labelUploadDate.Name = "labelUploadDate";
            this.labelUploadDate.Size = new System.Drawing.Size(95, 20);
            this.labelUploadDate.TabIndex = 24;
            this.labelUploadDate.Text = "Upload date:";
            // 
            // numericUpDownChapters
            // 
            this.numericUpDownChapters.Location = new System.Drawing.Point(14, 231);
            this.numericUpDownChapters.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownChapters.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownChapters.Name = "numericUpDownChapters";
            this.numericUpDownChapters.Size = new System.Drawing.Size(229, 27);
            this.numericUpDownChapters.TabIndex = 25;
            this.numericUpDownChapters.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownChapters.ValueChanged += new System.EventHandler(this.numericUpDownChapters_ValueChanged);
            // 
            // labelChapters
            // 
            this.labelChapters.AutoSize = true;
            this.labelChapters.Location = new System.Drawing.Point(14, 207);
            this.labelChapters.Name = "labelChapters";
            this.labelChapters.Size = new System.Drawing.Size(70, 20);
            this.labelChapters.TabIndex = 26;
            this.labelChapters.Text = "Chapters:";
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 652);
            this.Controls.Add(this.labelChapters);
            this.Controls.Add(this.numericUpDownChapters);
            this.Controls.Add(this.labelUploadDate);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.textBoxPages);
            this.Controls.Add(this.textBoxPublisher);
            this.Controls.Add(this.textBoxUDC);
            this.Controls.Add(this.labelUDC);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.maskedTextBoxYear);
            this.Controls.Add(this.checkBoxFree);
            this.Controls.Add(this.labelauthorsAndLinks);
            this.Controls.Add(this.richTextBoxAuthorsAndLinks);
            this.Controls.Add(this.labelFileSize);
            this.Controls.Add(this.hScrollBarFileSize);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxFormat);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelBook);
            this.Controls.Add(this.maskedTextBoxAuthorID);
            this.Controls.Add(this.textBoxAuthorCountry);
            this.Controls.Add(this.textBoxAuthorName);
            this.Controls.Add(this.labelAuthor);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Library";
            this.Text = "Library";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).EndInit();
            this.groupBoxFormat.ResumeLayout(false);
            this.groupBoxFormat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChapters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelAuthor;
        private TextBox textBoxAuthorName;
        private TextBox textBoxAuthorCountry;
        private MaskedTextBox maskedTextBoxAuthorID;
        private ErrorProvider errorProviderApp;
        private GroupBox groupBoxFormat;
        private RadioButton radioButtonTXT;
        private RadioButton radioButtonFB2;
        private RadioButton radioButtonPDF;
        private Label labelID;
        private Label labelBook;
        private Button buttonSave;
        private Button buttonLoad;
        private TextBox textBoxName;
        private Label labelFileSize;
        private HScrollBar hScrollBarFileSize;
        private Label labelauthorsAndLinks;
        private RichTextBox richTextBoxAuthorsAndLinks;
        private CheckBox checkBoxFree;
        private Label labelYear;
        private MaskedTextBox maskedTextBoxYear;
        private TextBox textBoxUDC;
        private Label labelUDC;
        private TextBox textBoxPublisher;
        private TextBox textBoxPages;
        private DateTimePicker dateTimePicker;
        private Label labelUploadDate;
        private Label labelChapters;
        private NumericUpDown numericUpDownChapters;
    }
}