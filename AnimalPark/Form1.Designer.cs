namespace AnimalPark
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.groupBox_specific = new System.Windows.Forms.GroupBox();
            this.connect_button = new System.Windows.Forms.Button();
            this.lstRecipeList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.change_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.FoodItem_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.img_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.add_button = new System.Windows.Forms.Button();
            this.groupBox_objectspec = new System.Windows.Forms.GroupBox();
            this.textBox_secondTwo = new System.Windows.Forms.TextBox();
            this.label_secondspec = new System.Windows.Forms.Label();
            this.textBox_specOne = new System.Windows.Forms.TextBox();
            this.label_firstspec = new System.Windows.Forms.Label();
            this.groupBox_object = new System.Windows.Forms.GroupBox();
            this.listBox_species = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox_category = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox_gender = new System.Windows.Forms.ListBox();
            this.textBox_age = new System.Windows.Forms.TextBox();
            this.label_age = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.RichBox_Result = new System.Windows.Forms.RichTextBox();
            this.RB_EaterType = new System.Windows.Forms.RichTextBox();
            this.labelForfood = new System.Windows.Forms.Label();
            this.labelForFood2 = new System.Windows.Forms.Label();
            this.listView_Animals = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Names = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ComboBoxForSort = new System.Windows.Forms.ComboBox();
            this.RB_Ingredients = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenBFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsBFile = new System.Windows.Forms.ToolStripMenuItem();
            this.Dash = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileXML = new System.Windows.Forms.ToolStripMenuItem();
            this.importXMLFile = new System.Windows.Forms.ToolStripMenuItem();
            this.exportXMLFile = new System.Windows.Forms.ToolStripMenuItem();
            this.Dash2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.groupBox_specific.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox_objectspec.SuspendLayout();
            this.groupBox_object.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.mnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_specific
            // 
            this.groupBox_specific.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_specific.Controls.Add(this.connect_button);
            this.groupBox_specific.Controls.Add(this.lstRecipeList);
            this.groupBox_specific.Controls.Add(this.change_button);
            this.groupBox_specific.Controls.Add(this.delete_button);
            this.groupBox_specific.Controls.Add(this.FoodItem_button);
            this.groupBox_specific.Controls.Add(this.clear_button);
            this.groupBox_specific.Controls.Add(this.img_button);
            this.groupBox_specific.Controls.Add(this.pictureBox1);
            this.groupBox_specific.Controls.Add(this.checkBox1);
            this.groupBox_specific.Controls.Add(this.add_button);
            this.groupBox_specific.Controls.Add(this.groupBox_objectspec);
            this.groupBox_specific.Controls.Add(this.groupBox_object);
            this.groupBox_specific.Controls.Add(this.groupBox2);
            this.groupBox_specific.Controls.Add(this.groupBox1);
            this.groupBox_specific.Controls.Add(this.textBox_age);
            this.groupBox_specific.Controls.Add(this.label_age);
            this.groupBox_specific.Controls.Add(this.textBox_name);
            this.groupBox_specific.Controls.Add(this.label_name);
            this.groupBox_specific.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_specific.ForeColor = System.Drawing.Color.Green;
            this.groupBox_specific.Location = new System.Drawing.Point(13, 26);
            this.groupBox_specific.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_specific.Name = "groupBox_specific";
            this.groupBox_specific.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_specific.Size = new System.Drawing.Size(1554, 461);
            this.groupBox_specific.TabIndex = 0;
            this.groupBox_specific.TabStop = false;
            this.groupBox_specific.Text = "Animal specifications";
            // 
            // connect_button
            // 
            this.connect_button.BackColor = System.Drawing.Color.LightGray;
            this.connect_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.connect_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connect_button.ForeColor = System.Drawing.Color.Green;
            this.connect_button.Location = new System.Drawing.Point(1384, 307);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(154, 35);
            this.connect_button.TabIndex = 38;
            this.connect_button.Text = "Connect";
            this.connect_button.UseVisualStyleBackColor = false;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // lstRecipeList
            // 
            this.lstRecipeList.BackColor = System.Drawing.Color.White;
            this.lstRecipeList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstRecipeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRecipeList.FullRowSelect = true;
            this.lstRecipeList.GridLines = true;
            this.lstRecipeList.HideSelection = false;
            this.lstRecipeList.Location = new System.Drawing.Point(1206, 42);
            this.lstRecipeList.Name = "lstRecipeList";
            this.lstRecipeList.Size = new System.Drawing.Size(332, 258);
            this.lstRecipeList.TabIndex = 34;
            this.lstRecipeList.UseCompatibleStateImageBehavior = false;
            this.lstRecipeList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 165;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ingrediens";
            this.columnHeader2.Width = 170;
            // 
            // change_button
            // 
            this.change_button.BackColor = System.Drawing.Color.LightGray;
            this.change_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.change_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.change_button.Location = new System.Drawing.Point(847, 401);
            this.change_button.Name = "change_button";
            this.change_button.Size = new System.Drawing.Size(141, 35);
            this.change_button.TabIndex = 37;
            this.change_button.Text = "Change";
            this.change_button.UseVisualStyleBackColor = false;
            this.change_button.Click += new System.EventHandler(this.change_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.LightGray;
            this.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.ForeColor = System.Drawing.Color.Red;
            this.delete_button.Location = new System.Drawing.Point(700, 401);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(141, 35);
            this.delete_button.TabIndex = 36;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // FoodItem_button
            // 
            this.FoodItem_button.BackColor = System.Drawing.Color.LightGray;
            this.FoodItem_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FoodItem_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodItem_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.FoodItem_button.Location = new System.Drawing.Point(1206, 307);
            this.FoodItem_button.Name = "FoodItem_button";
            this.FoodItem_button.Size = new System.Drawing.Size(154, 35);
            this.FoodItem_button.TabIndex = 35;
            this.FoodItem_button.Text = "Add food Item";
            this.FoodItem_button.UseVisualStyleBackColor = false;
            this.FoodItem_button.Click += new System.EventHandler(this.FoodItem_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.BackColor = System.Drawing.Color.LightGray;
            this.clear_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clear_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_button.ForeColor = System.Drawing.Color.Red;
            this.clear_button.Location = new System.Drawing.Point(1356, 401);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(182, 35);
            this.clear_button.TabIndex = 30;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = false;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // img_button
            // 
            this.img_button.BackColor = System.Drawing.Color.LightGray;
            this.img_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.img_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.img_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.img_button.Location = new System.Drawing.Point(880, 316);
            this.img_button.Name = "img_button";
            this.img_button.Size = new System.Drawing.Size(182, 35);
            this.img_button.TabIndex = 29;
            this.img_button.Text = "Load Animal Photo";
            this.img_button.UseVisualStyleBackColor = false;
            this.img_button.Click += new System.EventHandler(this.img_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Location = new System.Drawing.Point(755, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(432, 258);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(582, 316);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(151, 29);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "List all animals";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.LightGray;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.Location = new System.Drawing.Point(553, 401);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(141, 35);
            this.add_button.TabIndex = 27;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // groupBox_objectspec
            // 
            this.groupBox_objectspec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_objectspec.Controls.Add(this.textBox_secondTwo);
            this.groupBox_objectspec.Controls.Add(this.label_secondspec);
            this.groupBox_objectspec.Controls.Add(this.textBox_specOne);
            this.groupBox_objectspec.Controls.Add(this.label_firstspec);
            this.groupBox_objectspec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_objectspec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox_objectspec.Location = new System.Drawing.Point(26, 307);
            this.groupBox_objectspec.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_objectspec.Name = "groupBox_objectspec";
            this.groupBox_objectspec.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_objectspec.Size = new System.Drawing.Size(700, 129);
            this.groupBox_objectspec.TabIndex = 7;
            this.groupBox_objectspec.TabStop = false;
            this.groupBox_objectspec.Text = "Mammal specifications";
            // 
            // textBox_secondTwo
            // 
            this.textBox_secondTwo.Location = new System.Drawing.Point(279, 85);
            this.textBox_secondTwo.Name = "textBox_secondTwo";
            this.textBox_secondTwo.Size = new System.Drawing.Size(214, 29);
            this.textBox_secondTwo.TabIndex = 3;
            // 
            // label_secondspec
            // 
            this.label_secondspec.AutoSize = true;
            this.label_secondspec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_secondspec.Location = new System.Drawing.Point(12, 88);
            this.label_secondspec.Name = "label_secondspec";
            this.label_secondspec.Size = new System.Drawing.Size(50, 24);
            this.label_secondspec.TabIndex = 2;
            this.label_secondspec.Text = "Age:";
            // 
            // textBox_specOne
            // 
            this.textBox_specOne.Location = new System.Drawing.Point(279, 39);
            this.textBox_specOne.Name = "textBox_specOne";
            this.textBox_specOne.Size = new System.Drawing.Size(214, 29);
            this.textBox_specOne.TabIndex = 1;
            // 
            // label_firstspec
            // 
            this.label_firstspec.AutoSize = true;
            this.label_firstspec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_firstspec.Location = new System.Drawing.Point(12, 42);
            this.label_firstspec.Name = "label_firstspec";
            this.label_firstspec.Size = new System.Drawing.Size(66, 24);
            this.label_firstspec.TabIndex = 0;
            this.label_firstspec.Text = "Name:";
            // 
            // groupBox_object
            // 
            this.groupBox_object.Controls.Add(this.listBox_species);
            this.groupBox_object.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_object.Location = new System.Drawing.Point(515, 29);
            this.groupBox_object.Name = "groupBox_object";
            this.groupBox_object.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.groupBox_object.Size = new System.Drawing.Size(220, 271);
            this.groupBox_object.TabIndex = 6;
            this.groupBox_object.TabStop = false;
            this.groupBox_object.Text = "Animal Object";
            // 
            // listBox_species
            // 
            this.listBox_species.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_species.FormattingEnabled = true;
            this.listBox_species.ItemHeight = 20;
            this.listBox_species.Location = new System.Drawing.Point(0, 25);
            this.listBox_species.Margin = new System.Windows.Forms.Padding(0);
            this.listBox_species.Name = "listBox_species";
            this.listBox_species.Size = new System.Drawing.Size(218, 244);
            this.listBox_species.TabIndex = 1;
            this.listBox_species.SelectedIndexChanged += new System.EventHandler(this.listBox_species_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox_category);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(278, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.groupBox2.Size = new System.Drawing.Size(216, 271);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CategoryType";
            // 
            // listBox_category
            // 
            this.listBox_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_category.FormattingEnabled = true;
            this.listBox_category.ItemHeight = 20;
            this.listBox_category.Location = new System.Drawing.Point(0, 25);
            this.listBox_category.Margin = new System.Windows.Forms.Padding(0);
            this.listBox_category.Name = "listBox_category";
            this.listBox_category.Size = new System.Drawing.Size(214, 244);
            this.listBox_category.TabIndex = 1;
            this.listBox_category.SelectedIndexChanged += new System.EventHandler(this.listBox_category_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox_gender);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 122);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 1);
            this.groupBox1.Size = new System.Drawing.Size(229, 176);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GenderType";
            // 
            // listBox_gender
            // 
            this.listBox_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_gender.FormattingEnabled = true;
            this.listBox_gender.ItemHeight = 20;
            this.listBox_gender.Location = new System.Drawing.Point(0, 25);
            this.listBox_gender.Margin = new System.Windows.Forms.Padding(0);
            this.listBox_gender.Name = "listBox_gender";
            this.listBox_gender.Size = new System.Drawing.Size(229, 144);
            this.listBox_gender.TabIndex = 1;
            // 
            // textBox_age
            // 
            this.textBox_age.Location = new System.Drawing.Point(94, 76);
            this.textBox_age.Name = "textBox_age";
            this.textBox_age.Size = new System.Drawing.Size(161, 29);
            this.textBox_age.TabIndex = 3;
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_age.Location = new System.Drawing.Point(22, 79);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(50, 24);
            this.label_age.TabIndex = 2;
            this.label_age.Text = "Age:";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(94, 37);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(161, 29);
            this.textBox_name.TabIndex = 1;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_name.Location = new System.Drawing.Point(22, 42);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(66, 24);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Name:";
            // 
            // RichBox_Result
            // 
            this.RichBox_Result.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.RichBox_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichBox_Result.Location = new System.Drawing.Point(39, 494);
            this.RichBox_Result.Name = "RichBox_Result";
            this.RichBox_Result.ReadOnly = true;
            this.RichBox_Result.Size = new System.Drawing.Size(242, 251);
            this.RichBox_Result.TabIndex = 1;
            this.RichBox_Result.Text = "";
            // 
            // RB_EaterType
            // 
            this.RB_EaterType.BackColor = System.Drawing.Color.White;
            this.RB_EaterType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_EaterType.Location = new System.Drawing.Point(993, 521);
            this.RB_EaterType.Name = "RB_EaterType";
            this.RB_EaterType.ReadOnly = true;
            this.RB_EaterType.Size = new System.Drawing.Size(343, 224);
            this.RB_EaterType.TabIndex = 2;
            this.RB_EaterType.Text = "";
            // 
            // labelForfood
            // 
            this.labelForfood.AutoSize = true;
            this.labelForfood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForfood.Location = new System.Drawing.Point(989, 494);
            this.labelForfood.Name = "labelForfood";
            this.labelForfood.Size = new System.Drawing.Size(86, 20);
            this.labelForfood.TabIndex = 3;
            this.labelForfood.Text = "EaterType:";
            // 
            // labelForFood2
            // 
            this.labelForFood2.AutoSize = true;
            this.labelForFood2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForFood2.Location = new System.Drawing.Point(1081, 494);
            this.labelForFood2.Name = "labelForFood2";
            this.labelForFood2.Size = new System.Drawing.Size(18, 20);
            this.labelForFood2.TabIndex = 4;
            this.labelForFood2.Text = "?";
            // 
            // listView_Animals
            // 
            this.listView_Animals.BackColor = System.Drawing.Color.White;
            this.listView_Animals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Names,
            this.Age,
            this.Gender});
            this.listView_Animals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_Animals.FullRowSelect = true;
            this.listView_Animals.GridLines = true;
            this.listView_Animals.HideSelection = false;
            this.listView_Animals.Location = new System.Drawing.Point(291, 521);
            this.listView_Animals.Name = "listView_Animals";
            this.listView_Animals.Size = new System.Drawing.Size(696, 224);
            this.listView_Animals.TabIndex = 5;
            this.listView_Animals.UseCompatibleStateImageBehavior = false;
            this.listView_Animals.View = System.Windows.Forms.View.Details;
            this.listView_Animals.SelectedIndexChanged += new System.EventHandler(this.listView_Animals_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 170;
            // 
            // Names
            // 
            this.Names.Text = "Name";
            this.Names.Width = 170;
            // 
            // Age
            // 
            this.Age.Text = "Age";
            this.Age.Width = 170;
            // 
            // Gender
            // 
            this.Gender.Text = "Gender";
            this.Gender.Width = 180;
            // 
            // ComboBoxForSort
            // 
            this.ComboBoxForSort.BackColor = System.Drawing.SystemColors.Window;
            this.ComboBoxForSort.DropDownHeight = 150;
            this.ComboBoxForSort.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ComboBoxForSort.FormattingEnabled = true;
            this.ComboBoxForSort.IntegralHeight = false;
            this.ComboBoxForSort.ItemHeight = 18;
            this.ComboBoxForSort.Items.AddRange(new object[] {
            "0. Choose an alternative",
            "1. Sort by age",
            "2. Sort by name"});
            this.ComboBoxForSort.Location = new System.Drawing.Point(694, 492);
            this.ComboBoxForSort.Name = "ComboBoxForSort";
            this.ComboBoxForSort.Size = new System.Drawing.Size(293, 26);
            this.ComboBoxForSort.TabIndex = 33;
            this.ComboBoxForSort.TabStop = false;
            this.ComboBoxForSort.Text = "Choose an alternative";
            this.ComboBoxForSort.SelectedIndexChanged += new System.EventHandler(this.ComboBoxForSort_SelectedIndexChanged);
            // 
            // RB_Ingredients
            // 
            this.RB_Ingredients.BackColor = System.Drawing.Color.White;
            this.RB_Ingredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Ingredients.Location = new System.Drawing.Point(1342, 521);
            this.RB_Ingredients.Name = "RB_Ingredients";
            this.RB_Ingredients.ReadOnly = true;
            this.RB_Ingredients.Size = new System.Drawing.Size(226, 224);
            this.RB_Ingredients.TabIndex = 34;
            this.RB_Ingredients.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1407, 494);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 35;
            this.label1.Text = "Ingredients";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // mnuFile
            // 
            this.mnuFile.Checked = true;
            this.mnuFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.mnuFileOpen,
            this.mnuFileSave,
            this.mnuFileSaveAs,
            this.Dash,
            this.mnuFileXML,
            this.Dash2,
            this.mnuFileExit});
            this.mnuFile.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(44, 24);
            this.mnuFile.Text = "File";
            // 
            // mnuFileNew
            // 
            this.mnuFileNew.Name = "mnuFileNew";
            this.mnuFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuFileNew.Size = new System.Drawing.Size(226, 24);
            this.mnuFileNew.Text = "New";
            this.mnuFileNew.Click += new System.EventHandler(this.mnuFileNew_Click);
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenBFile});
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuFileOpen.Size = new System.Drawing.Size(226, 24);
            this.mnuFileOpen.Text = "Open...";
            // 
            // OpenBFile
            // 
            this.OpenBFile.Name = "OpenBFile";
            this.OpenBFile.Size = new System.Drawing.Size(146, 24);
            this.OpenBFile.Text = "Binary File";
            this.OpenBFile.Click += new System.EventHandler(this.OpenBFile_Click);
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.Name = "mnuFileSave";
            this.mnuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuFileSave.Size = new System.Drawing.Size(226, 24);
            this.mnuFileSave.Text = "Save";
            this.mnuFileSave.Click += new System.EventHandler(this.mnuFileSave_Click);
            // 
            // mnuFileSaveAs
            // 
            this.mnuFileSaveAs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveAsBFile});
            this.mnuFileSaveAs.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuFileSaveAs.Name = "mnuFileSaveAs";
            this.mnuFileSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.mnuFileSaveAs.Size = new System.Drawing.Size(226, 24);
            this.mnuFileSaveAs.Text = "Save as...";
            // 
            // SaveAsBFile
            // 
            this.SaveAsBFile.Name = "SaveAsBFile";
            this.SaveAsBFile.Size = new System.Drawing.Size(146, 24);
            this.SaveAsBFile.Text = "Binary File";
            this.SaveAsBFile.Click += new System.EventHandler(this.SaveAsBFile_Click);
            // 
            // Dash
            // 
            this.Dash.Name = "Dash";
            this.Dash.Size = new System.Drawing.Size(223, 6);
            // 
            // mnuFileXML
            // 
            this.mnuFileXML.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importXMLFile,
            this.exportXMLFile});
            this.mnuFileXML.Name = "mnuFileXML";
            this.mnuFileXML.Size = new System.Drawing.Size(226, 24);
            this.mnuFileXML.Text = "XML";
            // 
            // importXMLFile
            // 
            this.importXMLFile.Name = "importXMLFile";
            this.importXMLFile.Size = new System.Drawing.Size(219, 24);
            this.importXMLFile.Text = "Import from XML File";
            this.importXMLFile.Click += new System.EventHandler(this.importXMLFile_Click);
            // 
            // exportXMLFile
            // 
            this.exportXMLFile.Name = "exportXMLFile";
            this.exportXMLFile.Size = new System.Drawing.Size(219, 24);
            this.exportXMLFile.Text = "Export to XML File";
            this.exportXMLFile.Click += new System.EventHandler(this.exportXMLFile_Click);
            // 
            // Dash2
            // 
            this.Dash2.Name = "Dash2";
            this.Dash2.Size = new System.Drawing.Size(223, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(226, 24);
            this.mnuFileExit.Text = "Exit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuStrip
            // 
            this.mnuStrip.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mnuStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.mnuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mnuStrip.Size = new System.Drawing.Size(1580, 28);
            this.mnuStrip.TabIndex = 38;
            this.mnuStrip.Text = "menuStrip1";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1580, 757);
            this.Controls.Add(this.mnuStrip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RB_Ingredients);
            this.Controls.Add(this.ComboBoxForSort);
            this.Controls.Add(this.listView_Animals);
            this.Controls.Add(this.labelForFood2);
            this.Controls.Add(this.labelForfood);
            this.Controls.Add(this.RB_EaterType);
            this.Controls.Add(this.RichBox_Result);
            this.Controls.Add(this.groupBox_specific);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(50, 0);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1600, 800);
            this.MinimumSize = new System.Drawing.Size(1400, 800);
            this.Name = "mainForm";
            this.Text = "Apu Animal Park";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.groupBox_specific.ResumeLayout(false);
            this.groupBox_specific.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox_objectspec.ResumeLayout(false);
            this.groupBox_objectspec.PerformLayout();
            this.groupBox_object.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_specific;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_age;
        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox_gender;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox_category;
        private System.Windows.Forms.GroupBox groupBox_object;
        private System.Windows.Forms.ListBox listBox_species;
        private System.Windows.Forms.GroupBox groupBox_objectspec;
        private System.Windows.Forms.TextBox textBox_secondTwo;
        private System.Windows.Forms.Label label_secondspec;
        private System.Windows.Forms.TextBox textBox_specOne;
        private System.Windows.Forms.Label label_firstspec;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RichTextBox RichBox_Result;
        private System.Windows.Forms.Button img_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.RichTextBox RB_EaterType;
        private System.Windows.Forms.Label labelForfood;
        private System.Windows.Forms.Label labelForFood2;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Names;
        private System.Windows.Forms.ColumnHeader Age;
        private System.Windows.Forms.ColumnHeader Gender;
        private System.Windows.Forms.ComboBox ComboBoxForSort;
        private System.Windows.Forms.Button FoodItem_button;
        private System.Windows.Forms.Button change_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.ListView lstRecipeList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        public System.Windows.Forms.ListView listView_Animals;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.RichTextBox RB_Ingredients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator Dash;
        private System.Windows.Forms.ToolStripMenuItem mnuFileXML;
        private System.Windows.Forms.ToolStripSeparator Dash2;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem OpenBFile;
        private System.Windows.Forms.ToolStripMenuItem SaveAsBFile;
        private System.Windows.Forms.ToolStripMenuItem importXMLFile;
        private System.Windows.Forms.ToolStripMenuItem exportXMLFile;
    }
}

