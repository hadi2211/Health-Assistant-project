namespace Health_Assistant
{
    partial class Disease_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Disease_form));
            this.disease_textbox = new System.Windows.Forms.TextBox();
            this.Diseases_listbox = new System.Windows.Forms.ListBox();
            this.edit_button = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.adddiseasebutton = new System.Windows.Forms.Button();
            this.newDisease_name = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.openDiseaseTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // disease_textbox
            // 
            this.disease_textbox.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disease_textbox.ForeColor = System.Drawing.Color.Blue;
            this.disease_textbox.Location = new System.Drawing.Point(276, 20);
            this.disease_textbox.Multiline = true;
            this.disease_textbox.Name = "disease_textbox";
            this.disease_textbox.ReadOnly = true;
            this.disease_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.disease_textbox.Size = new System.Drawing.Size(525, 412);
            this.disease_textbox.TabIndex = 1;
            this.disease_textbox.Visible = false;
            // 
            // Diseases_listbox
            // 
            this.Diseases_listbox.Font = new System.Drawing.Font("Segoe Print", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diseases_listbox.ForeColor = System.Drawing.Color.Red;
            this.Diseases_listbox.FormattingEnabled = true;
            this.Diseases_listbox.ItemHeight = 30;
            this.Diseases_listbox.Items.AddRange(new object[] {
            "1. Food Poisoning",
            "2. Diabeties",
            "3. Cancer",
            "4. Flu and Sneezing",
            "5. Jaundice ",
            "6. Tuber Culosis",
            "7. Poliomyelitis",
            "8. Dengue Virus",
            "9. Malaria",
            "10. Fever",
            "11. Hepatitis",
            "12. Hair Fall",
            "13. Anemia",
            "14. Thalassemia"});
            this.Diseases_listbox.Location = new System.Drawing.Point(12, 20);
            this.Diseases_listbox.Name = "Diseases_listbox";
            this.Diseases_listbox.Size = new System.Drawing.Size(258, 454);
            this.Diseases_listbox.TabIndex = 0;
            this.Diseases_listbox.SelectedIndexChanged += new System.EventHandler(this.Diseases_SelectedIndexChanged);
            this.Diseases_listbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Diseases_listbox_MouseDoubleClick);
            // 
            // edit_button
            // 
            this.edit_button.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_button.ForeColor = System.Drawing.Color.DarkGreen;
            this.edit_button.Location = new System.Drawing.Point(276, 438);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(140, 36);
            this.edit_button.TabIndex = 2;
            this.edit_button.Text = "Add New Data";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Visible = false;
            this.edit_button.Click += new System.EventHandler(this.Button1_Click);
            // 
            // savebutton
            // 
            this.savebutton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebutton.ForeColor = System.Drawing.Color.Blue;
            this.savebutton.Location = new System.Drawing.Point(422, 438);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(97, 36);
            this.savebutton.TabIndex = 3;
            this.savebutton.Text = "SAVE";
            this.savebutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Visible = false;
            this.savebutton.Click += new System.EventHandler(this.Button2_Click);
            // 
            // adddiseasebutton
            // 
            this.adddiseasebutton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adddiseasebutton.ForeColor = System.Drawing.Color.Red;
            this.adddiseasebutton.Location = new System.Drawing.Point(12, 490);
            this.adddiseasebutton.Name = "adddiseasebutton";
            this.adddiseasebutton.Size = new System.Drawing.Size(176, 35);
            this.adddiseasebutton.TabIndex = 4;
            this.adddiseasebutton.Text = "Add New Disease";
            this.adddiseasebutton.UseVisualStyleBackColor = true;
            this.adddiseasebutton.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // newDisease_name
            // 
            this.newDisease_name.Location = new System.Drawing.Point(12, 531);
            this.newDisease_name.Name = "newDisease_name";
            this.newDisease_name.Size = new System.Drawing.Size(176, 20);
            this.newDisease_name.TabIndex = 5;
            this.newDisease_name.Visible = false;
            this.newDisease_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewDisease_name_KeyDown);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.MediumBlue;
            this.button4.Location = new System.Drawing.Point(194, 490);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(176, 35);
            this.button4.TabIndex = 6;
            this.button4.Text = "Open ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // openDiseaseTextBox
            // 
            this.openDiseaseTextBox.Location = new System.Drawing.Point(194, 531);
            this.openDiseaseTextBox.Name = "openDiseaseTextBox";
            this.openDiseaseTextBox.Size = new System.Drawing.Size(176, 20);
            this.openDiseaseTextBox.TabIndex = 7;
            this.openDiseaseTextBox.Visible = false;
            this.openDiseaseTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OpenDiseaseTextBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(391, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Font";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1. Times New Roman",
            "2. Calibri",
            "3. Cambria",
            "4. Segoe Print",
            "5. Microsft Sans Serif"});
            this.comboBox1.Location = new System.Drawing.Point(445, 493);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(118, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // Disease_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.ClientSize = new System.Drawing.Size(804, 563);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openDiseaseTextBox);
            this.Controls.Add(this.newDisease_name);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.adddiseasebutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.Diseases_listbox);
            this.Controls.Add(this.disease_textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Disease_form";
            this.Text = "Diseases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox disease_textbox;
        private System.Windows.Forms.ListBox Diseases_listbox;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button adddiseasebutton;
        private System.Windows.Forms.TextBox newDisease_name;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox openDiseaseTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}