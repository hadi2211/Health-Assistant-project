namespace Health_Assistant
{
    partial class Food_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Food_Form));
            this.FoodFormTabs = new System.Windows.Forms.TabControl();
            this.fruitTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.FormatBox = new System.Windows.Forms.ComboBox();
            this.save_button = new System.Windows.Forms.Button();
            this.addInformation_button = new System.Windows.Forms.Button();
            this.fruit_button = new System.Windows.Forms.Button();
            this.Fruits_textbox = new System.Windows.Forms.TextBox();
            this.VegetableTab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.vegetableSave_button = new System.Windows.Forms.Button();
            this.addvegetable_button = new System.Windows.Forms.Button();
            this.vegetable_button = new System.Windows.Forms.Button();
            this.vegetables_textbox = new System.Windows.Forms.TextBox();
            this.VitaminsTab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.save_vitmain = new System.Windows.Forms.Button();
            this.addvitamin_information = new System.Windows.Forms.Button();
            this.vitamin_button = new System.Windows.Forms.Button();
            this.vitamins_textbox = new System.Windows.Forms.TextBox();
            this.CaloriesTab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.saveCalorie = new System.Windows.Forms.Button();
            this.addCalorieinfo = new System.Windows.Forms.Button();
            this.calories_button = new System.Windows.Forms.Button();
            this.calories_textbox = new System.Windows.Forms.TextBox();
            this.FoodFormTabs.SuspendLayout();
            this.fruitTab.SuspendLayout();
            this.VegetableTab.SuspendLayout();
            this.VitaminsTab.SuspendLayout();
            this.CaloriesTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // FoodFormTabs
            // 
            this.FoodFormTabs.Controls.Add(this.fruitTab);
            this.FoodFormTabs.Controls.Add(this.VegetableTab);
            this.FoodFormTabs.Controls.Add(this.VitaminsTab);
            this.FoodFormTabs.Controls.Add(this.CaloriesTab);
            this.FoodFormTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.FoodFormTabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodFormTabs.Location = new System.Drawing.Point(0, 0);
            this.FoodFormTabs.Name = "FoodFormTabs";
            this.FoodFormTabs.SelectedIndex = 0;
            this.FoodFormTabs.Size = new System.Drawing.Size(800, 451);
            this.FoodFormTabs.TabIndex = 0;
            this.FoodFormTabs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FoodFormTabs_MouseClick);
            // 
            // fruitTab
            // 
            this.fruitTab.AutoScroll = true;
            this.fruitTab.Controls.Add(this.label1);
            this.fruitTab.Controls.Add(this.FormatBox);
            this.fruitTab.Controls.Add(this.save_button);
            this.fruitTab.Controls.Add(this.addInformation_button);
            this.fruitTab.Controls.Add(this.fruit_button);
            this.fruitTab.Controls.Add(this.Fruits_textbox);
            this.fruitTab.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.fruitTab.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fruitTab.Location = new System.Drawing.Point(4, 29);
            this.fruitTab.Name = "fruitTab";
            this.fruitTab.Padding = new System.Windows.Forms.Padding(3);
            this.fruitTab.Size = new System.Drawing.Size(792, 418);
            this.fruitTab.TabIndex = 0;
            this.fruitTab.Text = "Fruits";
            this.fruitTab.UseVisualStyleBackColor = true;
            this.fruitTab.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(479, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Font";
            this.label1.UseWaitCursor = true;
            // 
            // FormatBox
            // 
            this.FormatBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FormatBox.FormattingEnabled = true;
            this.FormatBox.Items.AddRange(new object[] {
            "1.Times New Roman",
            "2. Microsoft Sans Serif",
            "3. Segoe Print",
            "4. Calibri",
            "5.Cambria"});
            this.FormatBox.Location = new System.Drawing.Point(479, 26);
            this.FormatBox.Name = "FormatBox";
            this.FormatBox.Size = new System.Drawing.Size(142, 28);
            this.FormatBox.TabIndex = 5;
            this.FormatBox.UseWaitCursor = true;
            this.FormatBox.SelectedIndexChanged += new System.EventHandler(this.FormatBox_SelectedIndexChanged);
            // 
            // save_button
            // 
            this.save_button.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_button.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.save_button.Location = new System.Drawing.Point(334, 6);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(139, 48);
            this.save_button.TabIndex = 4;
            this.save_button.Text = "SAVE";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.UseWaitCursor = true;
            this.save_button.Visible = false;
            this.save_button.Click += new System.EventHandler(this.Button1_Click_2);
            // 
            // addInformation_button
            // 
            this.addInformation_button.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInformation_button.ForeColor = System.Drawing.Color.Red;
            this.addInformation_button.Location = new System.Drawing.Point(164, 6);
            this.addInformation_button.Name = "addInformation_button";
            this.addInformation_button.Size = new System.Drawing.Size(157, 49);
            this.addInformation_button.TabIndex = 2;
            this.addInformation_button.Text = "Add Information";
            this.addInformation_button.UseVisualStyleBackColor = true;
            this.addInformation_button.UseWaitCursor = true;
            this.addInformation_button.Click += new System.EventHandler(this.AddInformation_button_Click);
            // 
            // fruit_button
            // 
            this.fruit_button.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fruit_button.ForeColor = System.Drawing.Color.Lime;
            this.fruit_button.Location = new System.Drawing.Point(6, 6);
            this.fruit_button.Name = "fruit_button";
            this.fruit_button.Size = new System.Drawing.Size(146, 50);
            this.fruit_button.TabIndex = 1;
            this.fruit_button.Text = "Click To Read";
            this.fruit_button.UseVisualStyleBackColor = true;
            this.fruit_button.UseWaitCursor = true;
            this.fruit_button.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Fruits_textbox
            // 
            this.Fruits_textbox.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Fruits_textbox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fruits_textbox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Fruits_textbox.Location = new System.Drawing.Point(3, 62);
            this.Fruits_textbox.Multiline = true;
            this.Fruits_textbox.Name = "Fruits_textbox";
            this.Fruits_textbox.ReadOnly = true;
            this.Fruits_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Fruits_textbox.Size = new System.Drawing.Size(786, 350);
            this.Fruits_textbox.TabIndex = 3;
            this.Fruits_textbox.UseWaitCursor = true;
            this.Fruits_textbox.Visible = false;
            this.Fruits_textbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Fruits_textbox_MouseDoubleClick);
            // 
            // VegetableTab
            // 
            this.VegetableTab.AutoScroll = true;
            this.VegetableTab.Controls.Add(this.label2);
            this.VegetableTab.Controls.Add(this.comboBox1);
            this.VegetableTab.Controls.Add(this.vegetableSave_button);
            this.VegetableTab.Controls.Add(this.addvegetable_button);
            this.VegetableTab.Controls.Add(this.vegetable_button);
            this.VegetableTab.Controls.Add(this.vegetables_textbox);
            this.VegetableTab.Location = new System.Drawing.Point(4, 29);
            this.VegetableTab.Name = "VegetableTab";
            this.VegetableTab.Padding = new System.Windows.Forms.Padding(3);
            this.VegetableTab.Size = new System.Drawing.Size(792, 418);
            this.VegetableTab.TabIndex = 1;
            this.VegetableTab.Text = "Vegetables";
            this.VegetableTab.UseVisualStyleBackColor = true;
            this.VegetableTab.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Font";
            this.label2.UseWaitCursor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1.Times New Roman",
            "2. Microsoft Sans Serif",
            "3. Segoe Print",
            "4. Calibri",
            "5.Cambria"});
            this.comboBox1.Location = new System.Drawing.Point(521, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 28);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.UseWaitCursor = true;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // vegetableSave_button
            // 
            this.vegetableSave_button.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vegetableSave_button.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.vegetableSave_button.Location = new System.Drawing.Point(376, 6);
            this.vegetableSave_button.Name = "vegetableSave_button";
            this.vegetableSave_button.Size = new System.Drawing.Size(139, 48);
            this.vegetableSave_button.TabIndex = 4;
            this.vegetableSave_button.Text = "SAVE";
            this.vegetableSave_button.UseVisualStyleBackColor = true;
            this.vegetableSave_button.UseWaitCursor = true;
            this.vegetableSave_button.Visible = false;
            this.vegetableSave_button.Click += new System.EventHandler(this.VegetableSave_button_Click);
            // 
            // addvegetable_button
            // 
            this.addvegetable_button.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addvegetable_button.ForeColor = System.Drawing.Color.Red;
            this.addvegetable_button.Location = new System.Drawing.Point(193, 6);
            this.addvegetable_button.Name = "addvegetable_button";
            this.addvegetable_button.Size = new System.Drawing.Size(157, 49);
            this.addvegetable_button.TabIndex = 2;
            this.addvegetable_button.Text = "Add Information";
            this.addvegetable_button.UseVisualStyleBackColor = true;
            this.addvegetable_button.UseWaitCursor = true;
            this.addvegetable_button.Click += new System.EventHandler(this.Addvegetable_button_Click);
            // 
            // vegetable_button
            // 
            this.vegetable_button.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vegetable_button.ForeColor = System.Drawing.Color.LawnGreen;
            this.vegetable_button.Location = new System.Drawing.Point(8, 6);
            this.vegetable_button.Name = "vegetable_button";
            this.vegetable_button.Size = new System.Drawing.Size(146, 53);
            this.vegetable_button.TabIndex = 1;
            this.vegetable_button.Text = "Click To Read";
            this.vegetable_button.UseVisualStyleBackColor = true;
            this.vegetable_button.UseWaitCursor = true;
            this.vegetable_button.Click += new System.EventHandler(this.Vegetable_button_Click);
            // 
            // vegetables_textbox
            // 
            this.vegetables_textbox.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.vegetables_textbox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vegetables_textbox.Location = new System.Drawing.Point(3, 65);
            this.vegetables_textbox.Multiline = true;
            this.vegetables_textbox.Name = "vegetables_textbox";
            this.vegetables_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.vegetables_textbox.Size = new System.Drawing.Size(786, 347);
            this.vegetables_textbox.TabIndex = 3;
            this.vegetables_textbox.UseWaitCursor = true;
            this.vegetables_textbox.Visible = false;
            // 
            // VitaminsTab
            // 
            this.VitaminsTab.AutoScroll = true;
            this.VitaminsTab.Controls.Add(this.label3);
            this.VitaminsTab.Controls.Add(this.comboBox2);
            this.VitaminsTab.Controls.Add(this.save_vitmain);
            this.VitaminsTab.Controls.Add(this.addvitamin_information);
            this.VitaminsTab.Controls.Add(this.vitamin_button);
            this.VitaminsTab.Controls.Add(this.vitamins_textbox);
            this.VitaminsTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VitaminsTab.Location = new System.Drawing.Point(4, 29);
            this.VitaminsTab.Name = "VitaminsTab";
            this.VitaminsTab.Size = new System.Drawing.Size(792, 418);
            this.VitaminsTab.TabIndex = 2;
            this.VitaminsTab.Text = "Vitamins";
            this.VitaminsTab.UseVisualStyleBackColor = true;
            this.VitaminsTab.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(516, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Font";
            this.label3.UseWaitCursor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1.Times New Roman",
            "2. Microsoft Sans Serif",
            "3. Segoe Print",
            "4. Calibri",
            "5.Cambria"});
            this.comboBox2.Location = new System.Drawing.Point(516, 24);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(142, 28);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.UseWaitCursor = true;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // save_vitmain
            // 
            this.save_vitmain.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_vitmain.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.save_vitmain.Location = new System.Drawing.Point(371, 4);
            this.save_vitmain.Name = "save_vitmain";
            this.save_vitmain.Size = new System.Drawing.Size(139, 48);
            this.save_vitmain.TabIndex = 4;
            this.save_vitmain.Text = "SAVE";
            this.save_vitmain.UseVisualStyleBackColor = true;
            this.save_vitmain.UseWaitCursor = true;
            this.save_vitmain.Visible = false;
            this.save_vitmain.Click += new System.EventHandler(this.Save_vitmain_Click);
            // 
            // addvitamin_information
            // 
            this.addvitamin_information.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addvitamin_information.ForeColor = System.Drawing.Color.Red;
            this.addvitamin_information.Location = new System.Drawing.Point(188, 4);
            this.addvitamin_information.Name = "addvitamin_information";
            this.addvitamin_information.Size = new System.Drawing.Size(157, 49);
            this.addvitamin_information.TabIndex = 2;
            this.addvitamin_information.Text = "Add Information";
            this.addvitamin_information.UseVisualStyleBackColor = true;
            this.addvitamin_information.UseWaitCursor = true;
            this.addvitamin_information.Click += new System.EventHandler(this.Addvitamin_information_Click);
            // 
            // vitamin_button
            // 
            this.vitamin_button.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vitamin_button.ForeColor = System.Drawing.Color.LawnGreen;
            this.vitamin_button.Location = new System.Drawing.Point(8, 3);
            this.vitamin_button.Name = "vitamin_button";
            this.vitamin_button.Size = new System.Drawing.Size(146, 50);
            this.vitamin_button.TabIndex = 1;
            this.vitamin_button.Text = "Click To Read";
            this.vitamin_button.UseVisualStyleBackColor = true;
            this.vitamin_button.UseWaitCursor = true;
            this.vitamin_button.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // vitamins_textbox
            // 
            this.vitamins_textbox.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.vitamins_textbox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vitamins_textbox.Location = new System.Drawing.Point(3, 59);
            this.vitamins_textbox.Multiline = true;
            this.vitamins_textbox.Name = "vitamins_textbox";
            this.vitamins_textbox.ReadOnly = true;
            this.vitamins_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.vitamins_textbox.Size = new System.Drawing.Size(786, 353);
            this.vitamins_textbox.TabIndex = 3;
            this.vitamins_textbox.UseWaitCursor = true;
            this.vitamins_textbox.Visible = false;
            // 
            // CaloriesTab
            // 
            this.CaloriesTab.AutoScroll = true;
            this.CaloriesTab.Controls.Add(this.label4);
            this.CaloriesTab.Controls.Add(this.comboBox3);
            this.CaloriesTab.Controls.Add(this.saveCalorie);
            this.CaloriesTab.Controls.Add(this.addCalorieinfo);
            this.CaloriesTab.Controls.Add(this.calories_button);
            this.CaloriesTab.Controls.Add(this.calories_textbox);
            this.CaloriesTab.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.CaloriesTab.Location = new System.Drawing.Point(4, 29);
            this.CaloriesTab.Name = "CaloriesTab";
            this.CaloriesTab.Size = new System.Drawing.Size(792, 418);
            this.CaloriesTab.TabIndex = 3;
            this.CaloriesTab.Text = "Calories";
            this.CaloriesTab.UseVisualStyleBackColor = true;
            this.CaloriesTab.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(536, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Font";
            this.label4.UseWaitCursor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "1.Times New Roman",
            "2. Microsoft Sans Serif",
            "3. Segoe Print",
            "4. Calibri",
            "5.Cambria"});
            this.comboBox3.Location = new System.Drawing.Point(540, 24);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(142, 28);
            this.comboBox3.TabIndex = 6;
            this.comboBox3.UseWaitCursor = true;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.ComboBox3_SelectedIndexChanged);
            // 
            // saveCalorie
            // 
            this.saveCalorie.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveCalorie.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.saveCalorie.Location = new System.Drawing.Point(375, 4);
            this.saveCalorie.Name = "saveCalorie";
            this.saveCalorie.Size = new System.Drawing.Size(139, 48);
            this.saveCalorie.TabIndex = 4;
            this.saveCalorie.Text = "SAVE";
            this.saveCalorie.UseVisualStyleBackColor = true;
            this.saveCalorie.UseWaitCursor = true;
            this.saveCalorie.Visible = false;
            this.saveCalorie.Click += new System.EventHandler(this.SaveCalorie_Click);
            // 
            // addCalorieinfo
            // 
            this.addCalorieinfo.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCalorieinfo.ForeColor = System.Drawing.Color.Red;
            this.addCalorieinfo.Location = new System.Drawing.Point(192, 4);
            this.addCalorieinfo.Name = "addCalorieinfo";
            this.addCalorieinfo.Size = new System.Drawing.Size(157, 49);
            this.addCalorieinfo.TabIndex = 2;
            this.addCalorieinfo.Text = "Add Information";
            this.addCalorieinfo.UseVisualStyleBackColor = true;
            this.addCalorieinfo.UseWaitCursor = true;
            this.addCalorieinfo.Click += new System.EventHandler(this.AddCalorieinfo_Click);
            // 
            // calories_button
            // 
            this.calories_button.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calories_button.ForeColor = System.Drawing.Color.LawnGreen;
            this.calories_button.Location = new System.Drawing.Point(8, 3);
            this.calories_button.Name = "calories_button";
            this.calories_button.Size = new System.Drawing.Size(146, 50);
            this.calories_button.TabIndex = 1;
            this.calories_button.Text = "Click To Read";
            this.calories_button.UseVisualStyleBackColor = true;
            this.calories_button.UseWaitCursor = true;
            this.calories_button.Click += new System.EventHandler(this.Button2_Click);
            // 
            // calories_textbox
            // 
            this.calories_textbox.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.calories_textbox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calories_textbox.Location = new System.Drawing.Point(3, 59);
            this.calories_textbox.Multiline = true;
            this.calories_textbox.Name = "calories_textbox";
            this.calories_textbox.ReadOnly = true;
            this.calories_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.calories_textbox.Size = new System.Drawing.Size(786, 353);
            this.calories_textbox.TabIndex = 3;
            this.calories_textbox.UseWaitCursor = true;
            this.calories_textbox.Visible = false;
            // 
            // Food_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.FoodFormTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Food_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Food";
            this.FoodFormTabs.ResumeLayout(false);
            this.fruitTab.ResumeLayout(false);
            this.fruitTab.PerformLayout();
            this.VegetableTab.ResumeLayout(false);
            this.VegetableTab.PerformLayout();
            this.VitaminsTab.ResumeLayout(false);
            this.VitaminsTab.PerformLayout();
            this.CaloriesTab.ResumeLayout(false);
            this.CaloriesTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl FoodFormTabs;
        private System.Windows.Forms.TabPage fruitTab;
        private System.Windows.Forms.TabPage VegetableTab;
        private System.Windows.Forms.TabPage VitaminsTab;
        private System.Windows.Forms.TabPage CaloriesTab;
        private System.Windows.Forms.TextBox Fruits_textbox;
        private System.Windows.Forms.TextBox vegetables_textbox;
        private System.Windows.Forms.TextBox vitamins_textbox;
        private System.Windows.Forms.TextBox calories_textbox;
        private System.Windows.Forms.Button fruit_button;
        private System.Windows.Forms.Button vegetable_button;
        private System.Windows.Forms.Button vitamin_button;
        private System.Windows.Forms.Button calories_button;
        private System.Windows.Forms.Button addInformation_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button vegetableSave_button;
        private System.Windows.Forms.Button addvegetable_button;
        private System.Windows.Forms.Button save_vitmain;
        private System.Windows.Forms.Button addvitamin_information;
        private System.Windows.Forms.Button saveCalorie;
        private System.Windows.Forms.Button addCalorieinfo;
        private System.Windows.Forms.ComboBox FormatBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}