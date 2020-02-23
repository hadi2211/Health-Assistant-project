using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Assistant
{
    public partial class Food_Form : Form
    {
        public Food_Form()
        {
            InitializeComponent();
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FruitsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FoodFormTabs_MouseClick(object sender, MouseEventArgs e)
        {
            //if(fruitTab)

        }

        private void Fruits_textbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Fruits_textbox.Visible = true;
            Fruits_textbox.ReadOnly = true;
            Fruits_textbox.Clear();
            string filename = "fruit.txt";
            if (File.Exists(filename))
            {
                StreamReader stream;
                try
                {
                    using (stream = new StreamReader(filename))
                    {
                        Fruits_textbox.AppendText(stream.ReadToEnd());
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("Error Reading from file", "error file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show(filename + " does not exit", "file error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Vegetable_button_Click(object sender, EventArgs e)
        {
            vegetables_textbox.Clear();
            vegetables_textbox.ReadOnly = true;
            vegetables_textbox.Visible = true;
            string filename = "vegetable.txt";
            if (File.Exists(filename))
            {
                StreamReader stream;
                try
                {
                    using (stream = new StreamReader(filename))
                    {
                        vegetables_textbox.AppendText(stream.ReadToEnd());
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("Error Reading from file", "error file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show(filename + " does not exit", "file error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            vitamins_textbox.Visible = true;
            vitamins_textbox.Clear();
            vitamins_textbox.ReadOnly = true;
            string filename = "vitamin.txt";
            if (File.Exists(filename))
            {
                StreamReader stream;
                try
                {
                    using (stream = new StreamReader(filename))
                    {
                        vitamins_textbox.AppendText(stream.ReadToEnd());
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("Error Reading from file", "error file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show(filename + " does not exit", "file error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            calories_textbox.Visible = true;
            calories_textbox.Clear();
            calories_textbox.ReadOnly = true;
            string filename = "calorie.txt";
            if (File.Exists(filename))
            {
                StreamReader stream;
                try
                {
                    using (stream = new StreamReader(filename))
                    {
                        calories_textbox.AppendText(stream.ReadToEnd());
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("Error Reading from file", "error file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show(filename + " does not exit", "file error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddInformation_button_Click(object sender, EventArgs e)
        {
            Fruits_textbox.Visible = true;
            Fruits_textbox.ReadOnly = false;
            Fruits_textbox.Clear();
            MessageBox.Show("Add Information option is enabled now", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            save_button.Visible = true;
        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            string filename = "fruit.txt";
            if (File.Exists(filename))
            {
                try
                {
                    File.AppendAllText(filename, " " + Fruits_textbox.Text);
                    fruit_button.Visible = true;
                    save_button.Visible = false;
                    Fruits_textbox.Clear();
                    Fruits_textbox.Visible = false;
                    MessageBox.Show("File Updated successfully");
                }
                catch (IOException)
                {
                    MessageBox.Show("Error Reading from file", "error file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show(filename + " does not exit", "file error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Addvegetable_button_Click(object sender, EventArgs e)
        {
            vegetables_textbox.Visible = true;
            vegetables_textbox.ReadOnly = false;
            vegetables_textbox.Clear();
            MessageBox.Show("Add Information option is enabled now", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            vegetableSave_button.Visible = true;
        }

        private void VegetableSave_button_Click(object sender, EventArgs e)
        {
           // string filename = "vegetable.txt";
            if (File.Exists("vegetable.txt"))
            {
                try
                {
                    File.AppendAllText("vegetable.txt", " " + vegetables_textbox.Text);
                    vegetable_button.Visible = true;
                    vegetableSave_button.Visible = false;
                    vegetables_textbox.Visible = false;
                    vegetables_textbox.Clear();
                    MessageBox.Show("File Updated successfully");
                }
                catch (IOException)
                {
                    MessageBox.Show("Error Reading from file", "error file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show(" does not exit", "file error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Addvitamin_information_Click(object sender, EventArgs e)
        {
            vitamins_textbox.Visible = true;
            vitamins_textbox.ReadOnly = false;
            vitamins_textbox.Clear();
            MessageBox.Show("Add Information option is enabled now", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            save_vitmain.Visible = true;
        }

        private void Save_vitmain_Click(object sender, EventArgs e)
        {
            //string filename = "vitamin.txt";
            if (File.Exists("vitamin.txt"))
            {
                try
                {
                    File.AppendAllText("vitamin.txt", " " + vitamins_textbox.Text);
                    vitamin_button.Visible = true;
                    save_vitmain.Visible = false;
                    vitamins_textbox.Visible = false;
                    vitamins_textbox.Clear();
                    MessageBox.Show("File Updated successfully");

                }
                catch (IOException)
                {
                    MessageBox.Show("Error Reading from file", "error file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show(" does not exit", "file error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddCalorieinfo_Click(object sender, EventArgs e)
        {
            calories_textbox.Visible = true;
            calories_textbox.ReadOnly = false;
            calories_textbox.Clear();
            MessageBox.Show("Add Information option is enabled now", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            saveCalorie.Visible = true;
        }

        private void SaveCalorie_Click(object sender, EventArgs e)
        {
            //string filename = "calorie.txt";
            if (File.Exists("calorie.txt"))
            {
                try
                {
                    File.AppendAllText("calorie.txt", " " + calories_textbox.Text);
                    calories_button.Visible = true;
                    saveCalorie.Visible = false;
                    calories_textbox.Clear();
                    calories_textbox.Visible = false;
                    MessageBox.Show("File Updated successfully");

                }
                catch (IOException)
                {
                    MessageBox.Show("Error Reading from file", "error file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormatBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (FormatBox.SelectedIndex)
            {
                case 0:
                    Fruits_textbox.Font = new Font("Times New Roman", 12, Fruits_textbox.Font.Style);
                    break;
                case 1:
                    Fruits_textbox.Font = new Font("Microsoft Sans Serif", 12, Fruits_textbox.Font.Style);
                    break;
                case 2:
                    Fruits_textbox.Font = new Font("Segoe Print", 12, Fruits_textbox.Font.Style);
                    break;
                case 3:
                    Fruits_textbox.Font = new Font("Calibri", 12, Fruits_textbox.Font.Style);
                    break;
                case 4:
                    Fruits_textbox.Font = new Font("Cambia", 12, Fruits_textbox.Font.Style);
                    break;

            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    vegetables_textbox.Font = new Font("Times New Roman", 12, vegetables_textbox.Font.Style);
                    break;
                case 1:
                    vegetables_textbox.Font = new Font("Microsoft Sans Serif", 12, vegetables_textbox.Font.Style);
                    break;
                case 2:
                    vegetables_textbox.Font = new Font("Segoe Print", 12, vegetables_textbox.Font.Style);
                    break;
                case 3:
                    vegetables_textbox.Font = new Font("Calibri", 12, vegetables_textbox.Font.Style);
                    break;
                case 4:
                    vegetables_textbox.Font = new Font("Cambia", 12, vegetables_textbox.Font.Style);
                    break;
            }
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    vitamins_textbox.Font = new Font("Times New Roman", 12, vitamins_textbox.Font.Style);
                    break;
                case 1:
                    vitamins_textbox.Font = new Font("Microsoft Sans Serif", 12, vitamins_textbox.Font.Style);
                    break;
                case 2:
                    vitamins_textbox.Font = new Font("Segoe Print", 12, vitamins_textbox.Font.Style);
                    break;
                case 3:
                    vitamins_textbox.Font = new Font("Calibri", 12, vitamins_textbox.Font.Style);
                    break;
                case 4:
                    vitamins_textbox.Font = new Font("Cambia", 12, vitamins_textbox.Font.Style);
                    break;
            }
        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox3.SelectedIndex)
            {
                case 0:
                    calories_textbox.Font = new Font("Times New Roman", 12, calories_textbox.Font.Style);
                    break;
                case 1:
                    calories_textbox.Font = new Font("Microsoft Sans Serif", 12, calories_textbox.Font.Style);
                    break;
                case 2:
                    calories_textbox.Font = new Font("Segoe Print", 12, calories_textbox.Font.Style);
                    break;
                case 3:
                    calories_textbox.Font = new Font("Calibri", 12, calories_textbox.Font.Style);
                    break;
                case 4:
                    calories_textbox.Font = new Font("Cambia", 12, calories_textbox.Font.Style);
                    break;
            }
        }
    }
}