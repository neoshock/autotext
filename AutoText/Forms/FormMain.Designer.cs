using System.ComponentModel;
using System.Windows.Forms;

namespace AutoText.Forms
{
	partial class FormMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPhraseContent = new System.Windows.Forms.TextBox();
            this.contextMenuStripPhraseContentEdit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.macrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keyComboMacrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateAndTimeMacrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomStringMacrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomNumberMacrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertFileContentsMacrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertEnvironmentVariableValueMacrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAutotext = new System.Windows.Forms.TextBox();
            this.checkBoxAutotextCaseSensetive = new System.Windows.Forms.CheckBox();
            this.checkBoxSubstitute = new System.Windows.Forms.CheckBox();
            this.groupBoxTriggers = new System.Windows.Forms.GroupBox();
            this.buttonRemovePhrase = new System.Windows.Forms.Button();
            this.buttonAddPhrase = new System.Windows.Forms.Button();
            this.buttonSavePhrase = new System.Windows.Forms.Button();
            this.comboBoxProcessMacros = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.dataGridViewPhrases = new System.Windows.Forms.DataGridView();
            this.AutotextColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnHeaderAutotext = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDescripton = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.keyLogWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.globalAllowedDisallowedProgramsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAllowedDisallowedPrograms = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minusBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AutoText = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCambioIngles = new System.Windows.Forms.Button();
            this.btnCambioEspaniol = new System.Windows.Forms.Button();
            this.contextMenuStripPhraseContentEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhrases)).BeginInit();
            this.menuStripMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Phrases";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Phrase description";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(19, 54);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(314, 26);
            this.textBoxDescription.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(354, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phrase content(right-click to insert macros)";
            // 
            // textBoxPhraseContent
            // 
            this.textBoxPhraseContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPhraseContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPhraseContent.ContextMenuStrip = this.contextMenuStripPhraseContentEdit;
            this.textBoxPhraseContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPhraseContent.HideSelection = false;
            this.textBoxPhraseContent.Location = new System.Drawing.Point(19, 140);
            this.textBoxPhraseContent.Multiline = true;
            this.textBoxPhraseContent.Name = "textBoxPhraseContent";
            this.textBoxPhraseContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPhraseContent.Size = new System.Drawing.Size(680, 119);
            this.textBoxPhraseContent.TabIndex = 10;
            this.textBoxPhraseContent.TextChanged += new System.EventHandler(this.textBoxPhraseContent_TextChanged);
            this.textBoxPhraseContent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPhraseContent_KeyDown);
            // 
            // contextMenuStripPhraseContentEdit
            // 
            this.contextMenuStripPhraseContentEdit.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripPhraseContentEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.macrosToolStripMenuItem,
            this.toolStripSeparator1,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.selectAllToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.undoToolStripMenuItem});
            this.contextMenuStripPhraseContentEdit.Name = "contextMenuStripPhraseContentEdit";
            this.contextMenuStripPhraseContentEdit.Size = new System.Drawing.Size(123, 164);
            // 
            // macrosToolStripMenuItem
            // 
            this.macrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keyComboMacrosToolStripMenuItem,
            this.dateAndTimeMacrosToolStripMenuItem,
            this.randomStringMacrosToolStripMenuItem,
            this.randomNumberMacrosToolStripMenuItem,
            this.insertFileContentsMacrosToolStripMenuItem,
            this.insertEnvironmentVariableValueMacrosToolStripMenuItem});
            this.macrosToolStripMenuItem.Name = "macrosToolStripMenuItem";
            this.macrosToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.macrosToolStripMenuItem.Text = "Macros";
            // 
            // keyComboMacrosToolStripMenuItem
            // 
            this.keyComboMacrosToolStripMenuItem.Name = "keyComboMacrosToolStripMenuItem";
            this.keyComboMacrosToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.keyComboMacrosToolStripMenuItem.Text = "Key Macros";
            this.keyComboMacrosToolStripMenuItem.Click += new System.EventHandler(this.keyComboMacrosToolStripMenuItem_Click);
            // 
            // dateAndTimeMacrosToolStripMenuItem
            // 
            this.dateAndTimeMacrosToolStripMenuItem.Name = "dateAndTimeMacrosToolStripMenuItem";
            this.dateAndTimeMacrosToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.dateAndTimeMacrosToolStripMenuItem.Text = "Date And Time Macros";
            this.dateAndTimeMacrosToolStripMenuItem.Click += new System.EventHandler(this.dateAndTimeMacrosToolStripMenuItem_Click);
            // 
            // randomStringMacrosToolStripMenuItem
            // 
            this.randomStringMacrosToolStripMenuItem.Name = "randomStringMacrosToolStripMenuItem";
            this.randomStringMacrosToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.randomStringMacrosToolStripMenuItem.Text = "Random Text Macros";
            this.randomStringMacrosToolStripMenuItem.Click += new System.EventHandler(this.randomStringMacrosToolStripMenuItem_Click);
            // 
            // randomNumberMacrosToolStripMenuItem
            // 
            this.randomNumberMacrosToolStripMenuItem.Name = "randomNumberMacrosToolStripMenuItem";
            this.randomNumberMacrosToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.randomNumberMacrosToolStripMenuItem.Text = "Random Number Macros";
            this.randomNumberMacrosToolStripMenuItem.Click += new System.EventHandler(this.randomNumberMacrosToolStripMenuItem_Click);
            // 
            // insertFileContentsMacrosToolStripMenuItem
            // 
            this.insertFileContentsMacrosToolStripMenuItem.Name = "insertFileContentsMacrosToolStripMenuItem";
            this.insertFileContentsMacrosToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.insertFileContentsMacrosToolStripMenuItem.Text = "Insert File Contents Macros";
            this.insertFileContentsMacrosToolStripMenuItem.Click += new System.EventHandler(this.insertFileContentsMacrosToolStripMenuItem_Click);
            // 
            // insertEnvironmentVariableValueMacrosToolStripMenuItem
            // 
            this.insertEnvironmentVariableValueMacrosToolStripMenuItem.Name = "insertEnvironmentVariableValueMacrosToolStripMenuItem";
            this.insertEnvironmentVariableValueMacrosToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.insertEnvironmentVariableValueMacrosToolStripMenuItem.Text = "Environment Variable Macros";
            this.insertEnvironmentVariableValueMacrosToolStripMenuItem.Click += new System.EventHandler(this.insertEnvironmentVariableValueMacrosToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(119, 6);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(384, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Phrase autotext";
            // 
            // textBoxAutotext
            // 
            this.textBoxAutotext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAutotext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAutotext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAutotext.Location = new System.Drawing.Point(388, 44);
            this.textBoxAutotext.Name = "textBoxAutotext";
            this.textBoxAutotext.Size = new System.Drawing.Size(311, 26);
            this.textBoxAutotext.TabIndex = 12;
            // 
            // checkBoxAutotextCaseSensetive
            // 
            this.checkBoxAutotextCaseSensetive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxAutotextCaseSensetive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAutotextCaseSensetive.Location = new System.Drawing.Point(388, 86);
            this.checkBoxAutotextCaseSensetive.Name = "checkBoxAutotextCaseSensetive";
            this.checkBoxAutotextCaseSensetive.Size = new System.Drawing.Size(287, 24);
            this.checkBoxAutotextCaseSensetive.TabIndex = 13;
            this.checkBoxAutotextCaseSensetive.Text = "Case sensitive";
            this.checkBoxAutotextCaseSensetive.UseVisualStyleBackColor = true;
            // 
            // checkBoxSubstitute
            // 
            this.checkBoxSubstitute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxSubstitute.Checked = true;
            this.checkBoxSubstitute.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSubstitute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSubstitute.Location = new System.Drawing.Point(388, 116);
            this.checkBoxSubstitute.Name = "checkBoxSubstitute";
            this.checkBoxSubstitute.Size = new System.Drawing.Size(215, 24);
            this.checkBoxSubstitute.TabIndex = 20;
            this.checkBoxSubstitute.Text = "Substitute by phrase";
            this.checkBoxSubstitute.UseVisualStyleBackColor = true;
            // 
            // groupBoxTriggers
            // 
            this.groupBoxTriggers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTriggers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBoxTriggers.Location = new System.Drawing.Point(19, 12);
            this.groupBoxTriggers.Name = "groupBoxTriggers";
            this.groupBoxTriggers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxTriggers.Size = new System.Drawing.Size(350, 158);
            this.groupBoxTriggers.TabIndex = 21;
            this.groupBoxTriggers.TabStop = false;
            this.groupBoxTriggers.Text = "Phrase triggers";
            // 
            // buttonRemovePhrase
            // 
            this.buttonRemovePhrase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemovePhrase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRemovePhrase.BackgroundImage")));
            this.buttonRemovePhrase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRemovePhrase.FlatAppearance.BorderSize = 0;
            this.buttonRemovePhrase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemovePhrase.Location = new System.Drawing.Point(197, 43);
            this.buttonRemovePhrase.Name = "buttonRemovePhrase";
            this.buttonRemovePhrase.Size = new System.Drawing.Size(30, 30);
            this.buttonRemovePhrase.TabIndex = 22;
            this.buttonRemovePhrase.UseVisualStyleBackColor = true;
            this.buttonRemovePhrase.Click += new System.EventHandler(this.buttonRemovePhrase_Click);
            // 
            // buttonAddPhrase
            // 
            this.buttonAddPhrase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddPhrase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAddPhrase.BackgroundImage")));
            this.buttonAddPhrase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddPhrase.FlatAppearance.BorderSize = 0;
            this.buttonAddPhrase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPhrase.Location = new System.Drawing.Point(161, 43);
            this.buttonAddPhrase.Name = "buttonAddPhrase";
            this.buttonAddPhrase.Size = new System.Drawing.Size(30, 30);
            this.buttonAddPhrase.TabIndex = 23;
            this.buttonAddPhrase.UseVisualStyleBackColor = true;
            this.buttonAddPhrase.Click += new System.EventHandler(this.buttonAddPhrase_Click);
            this.buttonAddPhrase.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonAddPhrase_KeyDown);
            // 
            // buttonSavePhrase
            // 
            this.buttonSavePhrase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSavePhrase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonSavePhrase.FlatAppearance.BorderSize = 0;
            this.buttonSavePhrase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSavePhrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSavePhrase.ForeColor = System.Drawing.Color.White;
            this.buttonSavePhrase.Location = new System.Drawing.Point(609, 135);
            this.buttonSavePhrase.Name = "buttonSavePhrase";
            this.buttonSavePhrase.Size = new System.Drawing.Size(90, 35);
            this.buttonSavePhrase.TabIndex = 24;
            this.buttonSavePhrase.Text = "Save";
            this.buttonSavePhrase.UseVisualStyleBackColor = false;
            this.buttonSavePhrase.Click += new System.EventHandler(this.buttonSavePhrase_Click);
            // 
            // comboBoxProcessMacros
            // 
            this.comboBoxProcessMacros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProcessMacros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProcessMacros.FormattingEnabled = true;
            this.comboBoxProcessMacros.Items.AddRange(new object[] {
            "Execute",
            "Skip"});
            this.comboBoxProcessMacros.Location = new System.Drawing.Point(549, 53);
            this.comboBoxProcessMacros.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxProcessMacros.Name = "comboBoxProcessMacros";
            this.comboBoxProcessMacros.Size = new System.Drawing.Size(150, 28);
            this.comboBoxProcessMacros.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(363, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Phrase macros mode";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "AutoText";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // dataGridViewPhrases
            // 
            this.dataGridViewPhrases.AllowUserToAddRows = false;
            this.dataGridViewPhrases.AllowUserToDeleteRows = false;
            this.dataGridViewPhrases.AllowUserToResizeRows = false;
            this.dataGridViewPhrases.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewPhrases.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPhrases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhrases.ColumnHeadersVisible = false;
            this.dataGridViewPhrases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AutotextColumn,
            this.ColumnDescription});
            this.dataGridViewPhrases.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewPhrases.Location = new System.Drawing.Point(0, 79);
            this.dataGridViewPhrases.MultiSelect = false;
            this.dataGridViewPhrases.Name = "dataGridViewPhrases";
            this.dataGridViewPhrases.ReadOnly = true;
            this.dataGridViewPhrases.RowHeadersVisible = false;
            this.dataGridViewPhrases.RowHeadersWidth = 51;
            this.dataGridViewPhrases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPhrases.Size = new System.Drawing.Size(240, 471);
            this.dataGridViewPhrases.TabIndex = 28;
            this.dataGridViewPhrases.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewPhrases_CellFormatting);
            this.dataGridViewPhrases.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewPhrases_RowValidating);
            this.dataGridViewPhrases.SelectionChanged += new System.EventHandler(this.dataGridViewPhrases_SelectionChanged);
            this.dataGridViewPhrases.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewPhrases_KeyDown);
            // 
            // AutotextColumn
            // 
            this.AutotextColumn.DataPropertyName = "Abbreviation.AbbreviationText";
            this.AutotextColumn.HeaderText = "Autotext";
            this.AutotextColumn.MinimumWidth = 6;
            this.AutotextColumn.Name = "AutotextColumn";
            this.AutotextColumn.ReadOnly = true;
            this.AutotextColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AutotextColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.AutotextColumn.Width = 125;
            // 
            // ColumnDescription
            // 
            this.ColumnDescription.DataPropertyName = "Description";
            this.ColumnDescription.HeaderText = "Description";
            this.ColumnDescription.MinimumWidth = 6;
            this.ColumnDescription.Name = "ColumnDescription";
            this.ColumnDescription.ReadOnly = true;
            this.ColumnDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnDescription.Width = 203;
            // 
            // menuStripMain
            // 
            this.menuStripMain.AutoSize = false;
            this.menuStripMain.BackColor = System.Drawing.SystemColors.Window;
            this.menuStripMain.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 53);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1000, 28);
            this.menuStripMain.TabIndex = 29;
            this.menuStripMain.Text = "menuStrip1";
            this.menuStripMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStripMain_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.closeToolStripMenuItem.Text = "Exit";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem1
            // 
            this.toolsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keyLogWindowToolStripMenuItem,
            this.globalAllowedDisallowedProgramsListToolStripMenuItem});
            this.toolsToolStripMenuItem1.Name = "toolsToolStripMenuItem1";
            this.toolsToolStripMenuItem1.Size = new System.Drawing.Size(46, 24);
            this.toolsToolStripMenuItem1.Text = "Tools";
            // 
            // keyLogWindowToolStripMenuItem
            // 
            this.keyLogWindowToolStripMenuItem.Name = "keyLogWindowToolStripMenuItem";
            this.keyLogWindowToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.keyLogWindowToolStripMenuItem.Text = "Key Log Window";
            this.keyLogWindowToolStripMenuItem.Click += new System.EventHandler(this.keyLogWindowToolStripMenuItem_Click);
            // 
            // globalAllowedDisallowedProgramsListToolStripMenuItem
            // 
            this.globalAllowedDisallowedProgramsListToolStripMenuItem.Name = "globalAllowedDisallowedProgramsListToolStripMenuItem";
            this.globalAllowedDisallowedProgramsListToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.globalAllowedDisallowedProgramsListToolStripMenuItem.Text = "Global Allowed/Disallowed Programs List";
            this.globalAllowedDisallowedProgramsListToolStripMenuItem.Click += new System.EventHandler(this.globalAllowedDisallowedProgramsListToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // buttonAllowedDisallowedPrograms
            // 
            this.buttonAllowedDisallowedPrograms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonAllowedDisallowedPrograms.FlatAppearance.BorderSize = 0;
            this.buttonAllowedDisallowedPrograms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAllowedDisallowedPrograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAllowedDisallowedPrograms.ForeColor = System.Drawing.Color.White;
            this.buttonAllowedDisallowedPrograms.Location = new System.Drawing.Point(367, 12);
            this.buttonAllowedDisallowedPrograms.Name = "buttonAllowedDisallowedPrograms";
            this.buttonAllowedDisallowedPrograms.Size = new System.Drawing.Size(332, 30);
            this.buttonAllowedDisallowedPrograms.TabIndex = 30;
            this.buttonAllowedDisallowedPrograms.Text = "Allowed/Disallowed Programs List";
            this.buttonAllowedDisallowedPrograms.UseVisualStyleBackColor = false;
            this.buttonAllowedDisallowedPrograms.Click += new System.EventHandler(this.buttonAllowedDisallowedPrograms_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.minusBtn);
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.AutoText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 50);
            this.panel1.TabIndex = 31;
            // 
            // minusBtn
            // 
            this.minusBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minusBtn.BackgroundImage")));
            this.minusBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minusBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minusBtn.FlatAppearance.BorderSize = 0;
            this.minusBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.minusBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.minusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusBtn.Location = new System.Drawing.Point(923, 12);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(20, 20);
            this.minusBtn.TabIndex = 3;
            this.minusBtn.UseVisualStyleBackColor = true;
            this.minusBtn.Click += new System.EventHandler(this.minusBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitBtn.BackgroundImage")));
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.exitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Location = new System.Drawing.Point(968, 12);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(20, 20);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // AutoText
            // 
            this.AutoText.AutoSize = true;
            this.AutoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoText.Location = new System.Drawing.Point(48, 7);
            this.AutoText.Name = "AutoText";
            this.AutoText.Size = new System.Drawing.Size(116, 29);
            this.AutoText.TabIndex = 0;
            this.AutoText.Text = "AutoText";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.buttonAddPhrase);
            this.panel2.Controls.Add(this.buttonRemovePhrase);
            this.panel2.Controls.Add(this.dataGridViewPhrases);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 550);
            this.panel2.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBoxDescription);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.buttonAllowedDisallowedPrograms);
            this.panel3.Controls.Add(this.comboBoxProcessMacros);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.textBoxPhraseContent);
            this.panel3.Location = new System.Drawing.Point(255, 94);
            this.panel3.Margin = new System.Windows.Forms.Padding(12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(720, 277);
            this.panel3.TabIndex = 33;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.groupBoxTriggers);
            this.panel4.Controls.Add(this.textBoxAutotext);
            this.panel4.Controls.Add(this.checkBoxAutotextCaseSensetive);
            this.panel4.Controls.Add(this.checkBoxSubstitute);
            this.panel4.Controls.Add(this.buttonSavePhrase);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(255, 386);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(9);
            this.panel4.Size = new System.Drawing.Size(720, 182);
            this.panel4.TabIndex = 34;
            // 
            // btnCambioIngles
            // 
            this.btnCambioIngles.Location = new System.Drawing.Point(804, 50);
            this.btnCambioIngles.Name = "btnCambioIngles";
            this.btnCambioIngles.Size = new System.Drawing.Size(75, 23);
            this.btnCambioIngles.TabIndex = 36;
            this.btnCambioIngles.Text = "English";
            this.btnCambioIngles.UseVisualStyleBackColor = true;
            this.btnCambioIngles.Click += new System.EventHandler(this.btnCambioIngles_Click);
            // 
            // btnCambioEspaniol
            // 
            this.btnCambioEspaniol.Location = new System.Drawing.Point(925, 50);
            this.btnCambioEspaniol.Name = "btnCambioEspaniol";
            this.btnCambioEspaniol.Size = new System.Drawing.Size(75, 23);
            this.btnCambioEspaniol.TabIndex = 37;
            this.btnCambioEspaniol.Text = "Español";
            this.btnCambioEspaniol.UseVisualStyleBackColor = true;
            this.btnCambioEspaniol.Click += new System.EventHandler(this.btnCambioEspaniol_Click);
            // 
            // FormMain
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btnCambioEspaniol);
            this.Controls.Add(this.btnCambioIngles);
            this.Controls.Add(this.menuStripMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStripMain;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoText";
            this.Activated += new System.EventHandler(this.FormMain_Activated);
            this.Deactivate += new System.EventHandler(this.FormMain_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.contextMenuStripPhraseContentEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhrases)).EndInit();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private Label label2;
		private Label label3;
		private TextBox textBoxDescription;
		private Label label4;
		private TextBox textBoxPhraseContent;
		private Label label5;
		private TextBox textBoxAutotext;
		private CheckBox checkBoxAutotextCaseSensetive;
		private CheckBox checkBoxSubstitute;
		private GroupBox groupBoxTriggers;
		private Button buttonRemovePhrase;
		private Button buttonAddPhrase;
		private Button buttonSavePhrase;
		private ComboBox comboBoxProcessMacros;
		private Label label1;
		private NotifyIcon notifyIcon;
		private ContextMenuStrip contextMenuStripPhraseContentEdit;
		private ToolStripMenuItem macrosToolStripMenuItem;
		private ToolStripMenuItem copyToolStripMenuItem;
		private ToolStripMenuItem pasteToolStripMenuItem;
		private ToolStripMenuItem cutToolStripMenuItem;
		private ToolStripMenuItem selectAllToolStripMenuItem;
		private ToolStripMenuItem deleteToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripMenuItem keyComboMacrosToolStripMenuItem;
		private ToolStripMenuItem dateAndTimeMacrosToolStripMenuItem;
		private ToolStripMenuItem undoToolStripMenuItem;
		private ColumnHeader columnHeaderAutotext;
		private ColumnHeader columnHeaderDescripton;
		private DataGridView dataGridViewPhrases;
		private DataGridViewTextBoxColumn AutotextColumn;
		private DataGridViewTextBoxColumn ColumnDescription;
		private MenuStrip menuStripMain;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem closeToolStripMenuItem;
		private ToolStripMenuItem helpToolStripMenuItem;
		private ToolStripMenuItem aboutToolStripMenuItem;
		private ToolStripMenuItem toolsToolStripMenuItem1;
		private ToolStripMenuItem keyLogWindowToolStripMenuItem;
		private ToolStripMenuItem randomStringMacrosToolStripMenuItem;
		private ToolStripMenuItem randomNumberMacrosToolStripMenuItem;
		private ToolStripMenuItem insertFileContentsMacrosToolStripMenuItem;
		private ToolStripMenuItem insertEnvironmentVariableValueMacrosToolStripMenuItem;
		private Button buttonAllowedDisallowedPrograms;
		private ToolStripMenuItem globalAllowedDisallowedProgramsListToolStripMenuItem;
        private Panel panel1;
        private Label AutoText;
        private PictureBox pictureBox1;
        private Button exitBtn;
        private Button minusBtn;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button btnCambioIngles;
        private Button btnCambioEspaniol;
    }
}

