using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Health_Assistant
{
    public partial class Disease_form : Form
    {
        //public string[] array = new string[5];
        //public int counter=0;
        public string filename = null;
        public Disease_form()
        {
            InitializeComponent();
        }
        private void Diseases_SelectedIndexChanged(object sender, EventArgs e)
        {
            disease_textbox.ReadOnly = true;
            newDisease_name.Visible = false;
            disease_textbox.Visible = true;
            savebutton.Visible = false;
            edit_button.Visible = true;
            switch (Diseases_listbox.SelectedIndex)
            {
                case 0:
                    disease_textbox.Clear();
                    string filename = "1. Food Poisoning.txt";
                    if (File.Exists(filename))
                    {
                        StreamReader stream;
                        try
                        {
                            using (stream = new StreamReader(filename))
                            {
                                disease_textbox.AppendText(stream.ReadToEnd());
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
                    break;
                case 1:
                    disease_textbox.Clear();
                    filename = "2. Diabeties.txt";
                    if (File.Exists(filename))
                    {
                        StreamReader stream;
                        try
                        {
                            using (stream = new StreamReader(filename))
                            {
                                disease_textbox.AppendText(stream.ReadToEnd());
                            }
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
                    break;
                case 2:
                    disease_textbox.Clear();
                    filename = "3. Cancer.txt";
                    if (File.Exists(filename))
                    {
                        StreamReader stream;
                        try
                        {
                            using (stream = new StreamReader(filename))
                            {
                                disease_textbox.AppendText(stream.ReadToEnd());
                            }
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
                    break;
                case 3:
                    disease_textbox.Clear();
                    filename = "4. Flu and Sneezing.txt";
                    if (File.Exists(filename))
                    {
                        StreamReader stream;
                        try
                        {
                            using (stream = new StreamReader(filename))
                            {
                                disease_textbox.AppendText(stream.ReadToEnd());
                            }
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
                    break;
                case 4:
                    disease_textbox.Clear();
                    filename = "5. Jaundice.txt";
                    if (File.Exists(filename))
                    {
                        StreamReader stream;
                        try
                        {
                            using (stream = new StreamReader(filename))
                            {
                                disease_textbox.AppendText(stream.ReadToEnd());
                            }
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
                    break;
                case 5:
                    disease_textbox.Clear();
                    filename = "6. Tuber Culosis.txt";
                    if (File.Exists(filename))
                    {
                        StreamReader stream;
                        try
                        {
                            using (stream = new StreamReader(filename))
                            {
                                disease_textbox.AppendText(stream.ReadToEnd());
                            }
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
                    break;
                case 6:
                    disease_textbox.Clear();
                    filename = "7. Poliomyelitis.txt";
                    if (File.Exists(filename))
                    {
                        StreamReader stream;
                        try
                        {
                            using (stream = new StreamReader(filename))
                            {
                                disease_textbox.AppendText(stream.ReadToEnd());
                            }
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
                    break;
                case 7:
                    disease_textbox.Clear();
                    filename = "8. Dengue Virus.txt";
                    if (File.Exists(filename))
                    {
                        StreamReader stream;
                        try
                        {
                            using (stream = new StreamReader(filename))
                            {
                                disease_textbox.AppendText(stream.ReadToEnd());
                            }
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
                    break;
                case 8:
                    disease_textbox.Clear();
                    filename = "9. Malaria.txt";
                    if (File.Exists(filename))
                    {
                        StreamReader stream;
                        try
                        {
                            using (stream = new StreamReader(filename))
                            {
                                disease_textbox.AppendText(stream.ReadToEnd());
                            }
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
                    break;
                case 9:
                    disease_textbox.Clear();
                    filename = "10. Fever.txt";
                    if (File.Exists(filename))
                    {
                        StreamReader stream;
                        try
                        {
                            using (stream = new StreamReader(filename))
                            {
                                disease_textbox.AppendText(stream.ReadToEnd());
                            }
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
                    break;
                case 10:
                    disease_textbox.Clear();
                    filename = "11. Hepatitis.txt";
                    if (File.Exists(filename))
                    {
                        StreamReader stream;
                        try
                        {
                            using (stream = new StreamReader(filename))
                            {
                                disease_textbox.AppendText(stream.ReadToEnd());
                            }
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
                    break;
                case 11:
                    disease_textbox.Clear();
                    filename = "12. Hair Fall.txt";
                    if (File.Exists(filename))
                    {
                        StreamReader stream;
                        try
                        {
                            using (stream = new StreamReader(filename))
                            {
                                disease_textbox.AppendText(stream.ReadToEnd());
                            }
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
                    break;
                case 12:
                    disease_textbox.Clear();
                    filename = "13. Anemia.txt";
                    if (File.Exists(filename))
                    {
                        StreamReader stream;
                        try
                        {
                            using (stream = new StreamReader(filename))
                            {
                                disease_textbox.AppendText(stream.ReadToEnd());
                            }
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
                    break;
                case 13:
                    disease_textbox.Clear();
                    if (File.Exists(Diseases_listbox.GetItemText(Diseases_listbox.SelectedItem) + ".txt"))
                    {
                        StreamReader stream;
                        try
                        {
                            using (stream = new StreamReader(Diseases_listbox.GetItemText(Diseases_listbox.SelectedItem) + ".txt"))
                            {
                                disease_textbox.AppendText(stream.ReadToEnd());
                            }
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
                    break;

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            savebutton.Visible = true;
            disease_textbox.ReadOnly = false;
            MessageBox.Show("Now you can Add", "Add Data");
            disease_textbox.Clear();
            savebutton.Visible = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
               File.AppendAllText(Diseases_listbox.GetItemText(Diseases_listbox.SelectedItem) + ".txt"," "+disease_textbox.Text);
                disease_textbox.ReadOnly = true;
                savebutton.Visible = false;
                disease_textbox.Clear();
                filename =Diseases_listbox.GetItemText(Diseases_listbox.SelectedItem) + ".txt";
                MessageBox.Show("File updated successfully");
                if (File.Exists(filename))
                {
                    StreamReader stream;
                    try
                    {
                        using (stream = new StreamReader(filename))
                        {
                            disease_textbox.AppendText(stream.ReadToEnd());
                            
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
        private void Diseases_listbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            disease_textbox.ReadOnly = false;
            Diseases_listbox.Items.Add("exmapleDisease");
            Diseases_listbox.Items.Add(newDisease_name.Text);
            File.AppendAllText("example"+".txt", "example disease");
        }
        private void Button1_Click_1(object sender, EventArgs e)
        {
            openDiseaseTextBox.Visible = false;
            disease_textbox.Clear();
            disease_textbox.Visible = true;
            edit_button.Visible = false;
            savebutton.Visible = false;
            disease_textbox.ReadOnly = false;
            newDisease_name.Visible = true;
        }
        private void NewDisease_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                File.AppendAllText(newDisease_name.Text + ".txt", disease_textbox.Text);
                MessageBox.Show("Added Successfully", "");
                disease_textbox.Visible = false;
            }
            else
            {
               // MessageBox.Show("press enter to save");
            }
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            openDiseaseTextBox.Visible = true;
            disease_textbox.ReadOnly = true;
            edit_button.Visible = false;
            savebutton.Visible = false;
            newDisease_name.Visible = false;
        }
        private void OpenDiseaseTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            disease_textbox.Clear();
            disease_textbox.Visible = true;
            if (e.KeyCode == Keys.Enter)
            {
                StreamReader reader;
                if (File.Exists(openDiseaseTextBox.Text + ".txt"))
                {
                    try
                    {
                        using (reader = new StreamReader(openDiseaseTextBox.Text + ".txt"))
                        {
                            disease_textbox.AppendText(reader.ReadToEnd());
                        }
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error Reading File", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    openDiseaseTextBox.Visible = false;
                    adddiseasebutton.Visible = true;
                }
                else
                {
                    MessageBox.Show("File does not Exit", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
           
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    disease_textbox.Font = new Font("Times New Roman", 12, disease_textbox.Font.Style);
                    break;
                case 1:
                    disease_textbox.Font = new Font("Calibri", 12, disease_textbox.Font.Style);
                    break;
                case 2:
                    disease_textbox.Font = new Font("Cambria", 12, disease_textbox.Font.Style);
                    break;
                case 3:
                    disease_textbox.Font = new Font("Segoe Print", 12, disease_textbox.Font.Style);
                    break;
                case 4:
                    disease_textbox.Font = new Font("Microsoft Sans Serif", 12, disease_textbox.Font.Style);
                    break;
            }
        }
    }
}
