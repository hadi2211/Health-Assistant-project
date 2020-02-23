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
    
    public partial class Daily_Routine : Form
    {
       
      public Daily_Routine()
        {
            InitializeComponent();
        }

        
        public void Filename_textbox_KeyDown(object sender, KeyEventArgs e)
        {
         //  if (e.KeyCode == Keys.Enter)
           // {
             //   File.AppendAllText(filename_textbox.Text,answer_textbox.Text);
            //}
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            try
                {
                    File.AppendAllText(filename_textbox.Text + ".txt", answer_textbox.Text);
                MessageBox.Show("File saved successfully");
                    answer_textbox.Visible = false;
                    answer_textbox.Clear();
                    name_label.Visible = false;
                    filename_textbox.Visible = false;
                    openLabel.Visible = false;
                    open_textbox.Visible = false;
                    open_button.Visible = false;
                    dailyRoutine_listbox.Visible = false;
                    savebutton.Visible = false;
                }
                catch (IOException)
                {
                    MessageBox.Show("Error Creating File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        private void Open_button_Click(object sender, EventArgs e)
        {
            StreamReader reader;
            if (File.Exists(open_textbox.Text+".txt"))
            {
                
                try
                {
                    using(reader=new StreamReader(open_textbox.Text+".txt"))
                    {
                        answer_textbox.Clear();
                        answer_textbox.AppendText(reader.ReadToEnd());
                        dailyRoutine_listbox.Visible = true;
                        answer_textbox.Visible = true;
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("Enter correct name of File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("File does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            answer_textbox.ReadOnly = true;
        }

        private void New_button_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
            filename_textbox.Clear();
            answer_textbox.Clear();
            answer_textbox.ReadOnly = false;
            dailyRoutine_listbox.Visible = true;
            answer_textbox.Visible = true;
            openLabel.Visible = false;
            open_button.Visible = false;
            open_textbox.Visible = false;
            name_label.Visible = true;
            filename_textbox.Visible = true;
            savebutton.Visible = true;
        }

        private void Open_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
            dailyRoutine_listbox.Visible = false;
            answer_textbox.Visible = false;
            answer_textbox.ReadOnly = true;
            answer_textbox.Clear();
            answer_textbox.ReadOnly = false;
            name_label.Visible = false;
            filename_textbox.Visible = false;
            savebutton.Visible = false;
            openLabel.Visible = true;
            open_button.Visible = true;
            open_textbox.Clear();
            open_textbox.Visible = true;
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    answer_textbox.Font = new Font("Times New Roman", 12, answer_textbox.Font.Style);
                    break;
                case 1:
                    answer_textbox.Font = new Font("Calibri", 12, answer_textbox.Font.Style);
                    break;
                case 2:
                    answer_textbox.Font = new Font("Cambria", 12, answer_textbox.Font.Style);
                    break;
                case 3:
                    answer_textbox.Font = new Font("Segoe Print", 12, answer_textbox.Font.Style);
                    break;
                case 4:
                    answer_textbox.Font = new Font("Microsoft Sans Serif", 12, answer_textbox.Font.Style);
                    break;
            }
        }
    }
}

