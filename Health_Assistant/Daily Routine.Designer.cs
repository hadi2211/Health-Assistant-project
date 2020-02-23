namespace Health_Assistant
{
    partial class Daily_Routine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Daily_Routine));
            this.dailyRoutine_listbox = new System.Windows.Forms.CheckedListBox();
            this.savebutton = new System.Windows.Forms.Button();
            this.name_label = new System.Windows.Forms.Label();
            this.filename_textbox = new System.Windows.Forms.TextBox();
            this.answer_textbox = new System.Windows.Forms.TextBox();
            this.openLabel = new System.Windows.Forms.Label();
            this.open_textbox = new System.Windows.Forms.TextBox();
            this.open_button = new System.Windows.Forms.Button();
            this.new_button = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dailyRoutine_listbox
            // 
            this.dailyRoutine_listbox.CheckOnClick = true;
            this.dailyRoutine_listbox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyRoutine_listbox.FormattingEnabled = true;
            this.dailyRoutine_listbox.Items.AddRange(new object[] {
            "Wake up time",
            "Exercise",
            "Break Fast",
            "University",
            "Refreshment during Break",
            "Lunch",
            "Rest",
            "HomeWork",
            "Uncomplished Tasks",
            "Accompilished Tasks",
            "Evening Walk",
            "Family Time",
            "Extra Curicullar Activity",
            "Dinner",
            "Notes(if any)"});
            this.dailyRoutine_listbox.Location = new System.Drawing.Point(26, 53);
            this.dailyRoutine_listbox.Name = "dailyRoutine_listbox";
            this.dailyRoutine_listbox.Size = new System.Drawing.Size(325, 469);
            this.dailyRoutine_listbox.TabIndex = 1;
            this.dailyRoutine_listbox.Visible = false;
            // 
            // savebutton
            // 
            this.savebutton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebutton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.savebutton.Location = new System.Drawing.Point(369, 547);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(131, 35);
            this.savebutton.TabIndex = 4;
            this.savebutton.Text = "SAVE";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Visible = false;
            this.savebutton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(21, 525);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(143, 28);
            this.name_label.TabIndex = 3;
            this.name_label.Text = "Enter File Name";
            this.name_label.Visible = false;
            // 
            // filename_textbox
            // 
            this.filename_textbox.Location = new System.Drawing.Point(26, 556);
            this.filename_textbox.Name = "filename_textbox";
            this.filename_textbox.Size = new System.Drawing.Size(325, 20);
            this.filename_textbox.TabIndex = 3;
            this.filename_textbox.Visible = false;
            // 
            // answer_textbox
            // 
            this.answer_textbox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer_textbox.ForeColor = System.Drawing.Color.MediumBlue;
            this.answer_textbox.Location = new System.Drawing.Point(383, 53);
            this.answer_textbox.Multiline = true;
            this.answer_textbox.Name = "answer_textbox";
            this.answer_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.answer_textbox.Size = new System.Drawing.Size(345, 469);
            this.answer_textbox.TabIndex = 2;
            this.answer_textbox.Visible = false;
            // 
            // openLabel
            // 
            this.openLabel.AutoSize = true;
            this.openLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openLabel.Location = new System.Drawing.Point(21, 579);
            this.openLabel.Name = "openLabel";
            this.openLabel.Size = new System.Drawing.Size(143, 28);
            this.openLabel.TabIndex = 3;
            this.openLabel.Text = "Enter File Name";
            this.openLabel.Visible = false;
            // 
            // open_textbox
            // 
            this.open_textbox.Location = new System.Drawing.Point(26, 608);
            this.open_textbox.Name = "open_textbox";
            this.open_textbox.Size = new System.Drawing.Size(325, 20);
            this.open_textbox.TabIndex = 6;
            this.open_textbox.Visible = false;
            this.open_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Filename_textbox_KeyDown);
            // 
            // open_button
            // 
            this.open_button.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_button.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.open_button.Location = new System.Drawing.Point(369, 597);
            this.open_button.Name = "open_button";
            this.open_button.Size = new System.Drawing.Size(131, 38);
            this.open_button.TabIndex = 7;
            this.open_button.Text = "OPEN";
            this.open_button.UseVisualStyleBackColor = true;
            this.open_button.Visible = false;
            this.open_button.Click += new System.EventHandler(this.Open_button_Click);
            // 
            // new_button
            // 
            this.new_button.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_button.ForeColor = System.Drawing.Color.Red;
            this.new_button.Location = new System.Drawing.Point(26, 12);
            this.new_button.Name = "new_button";
            this.new_button.Size = new System.Drawing.Size(89, 35);
            this.new_button.TabIndex = 0;
            this.new_button.Text = "NEW";
            this.new_button.UseVisualStyleBackColor = true;
            this.new_button.Click += new System.EventHandler(this.New_button_Click);
            // 
            // open
            // 
            this.open.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open.ForeColor = System.Drawing.Color.Blue;
            this.open.Location = new System.Drawing.Point(121, 12);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(89, 35);
            this.open.TabIndex = 5;
            this.open.Text = "OPEN";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.Open_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(539, 583);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "FORMAT";
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
            "5. Microsoft Sans Serif"});
            this.comboBox1.Location = new System.Drawing.Point(543, 614);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(131, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // Daily_Routine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 636);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.open);
            this.Controls.Add(this.new_button);
            this.Controls.Add(this.answer_textbox);
            this.Controls.Add(this.open_textbox);
            this.Controls.Add(this.filename_textbox);
            this.Controls.Add(this.openLabel);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.open_button);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.dailyRoutine_listbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Daily_Routine";
            this.Text = "Daily Routine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox dailyRoutine_listbox;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox filename_textbox;
        private System.Windows.Forms.TextBox answer_textbox;
        private System.Windows.Forms.Label openLabel;
        private System.Windows.Forms.TextBox open_textbox;
        private System.Windows.Forms.Button open_button;
        private System.Windows.Forms.Button new_button;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}