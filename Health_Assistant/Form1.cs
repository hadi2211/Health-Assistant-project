using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Food_Form food_ = new Food_Form
            {
                MdiParent = this
            };
            food_.Show();
        }

        private void DiseasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Disease_form Disease = new Disease_form
            {
                MdiParent = this
            };
            Disease.Show();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void DailyRoutineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Daily_Routine _Routine = new Daily_Routine
            {
                MdiParent = this
            };
            _Routine.Show();
        }
        private void ClearCheckBoxes()
        {
            redToolStripMenuItem.Checked = false;
            yellowToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            darkVioletToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;

        }
        private void RedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearCheckBoxes();
            quoatation_label.ForeColor = Color.Red;
            redToolStripMenuItem.Checked = true;
        }

        private void YellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearCheckBoxes();
            quoatation_label.ForeColor = Color.Yellow;
            yellowToolStripMenuItem.Checked = true;
        }

        private void BlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearCheckBoxes();
            quoatation_label.ForeColor = Color.Blue;
            blueToolStripMenuItem.Checked = true;
        }

       /* private void DarkSelmonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearCheckBoxes();
            quoatation_label.ForeColor = Color.DarkSalmon;
            DarkSelmonToolStripMenuItem_Click.Checked = true;
        }*/

        private void DarkVioletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearCheckBoxes();
            quoatation_label.ForeColor = Color.DarkViolet;
            darkVioletToolStripMenuItem.Checked = true;
        }

        private void MenuHighlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearCheckBoxes();
            quoatation_label.ForeColor = Color.DarkGreen;
            menuHighlightToolStripMenuItem.Checked = true;
        }

        private void BoldToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // italicToolStripMenuItem.Checked = false;
            
            //boldToolStripMenuItem.Checked = true;
        }

        private void ItalicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //boldToolStripMenuItem.Checked = false;
        }

        private void BoldToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            quoatation_label.Font = new Font(quoatation_label.Font, quoatation_label.Font.Style ^ FontStyle.Bold);
        }

        private void ItalicToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            quoatation_label.Font = new Font(quoatation_label.Font, quoatation_label.Font.Style ^ FontStyle.Italic);

        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm
            {
                MdiParent = this
            };
            help.Show();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About
            {
                MdiParent = this
            };
            about.Show();
        }
    }
}
