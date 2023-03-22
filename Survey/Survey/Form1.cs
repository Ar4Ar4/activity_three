using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) 
        {
            OthLab.Visible = false;
            OtherBox.Visible = false;
            OtherBox.Multiline = true;

          
        }
        private void SubBtn_Click(object sender, EventArgs e)
        {
            string str = "";

            //asn1a =
            if(ans1a.Checked == true){

                str = str + ans1a.Text;
                str +=" ";
            }

            //asn4a =
            if (ans2a.Checked == true)
            {

                str = str + ans2a.Text;
                str += " ";
            }

            //asn4a =
            if (ans3a.Checked == true)
            {

                str = str + ans3a.Text;
                str += " ";
            }

            //asn4a =
            if (ans4a.Checked == true)
            {

                str = str + ans4a.Text;
                str += " ";
            }

            if (ans5a.Checked == true)
            {

                str = str + OtherBox.Text;
                str += " ";
            }

            if (!string.IsNullOrEmpty(str)){
                MessageBox.Show("You Selected: \n"+ str +"\nThank You!", "Survey", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else {
                MessageBox.Show("You a bitch", "Survey", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void ans1a_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ans2a_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ans3a_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ans4a_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ClrBtn_Click(object sender, EventArgs e)
        {
            ans1a.Checked = false;
            ans2a.Checked = false;
            ans3a.Checked = false;
            ans4a.Checked = false;
            ans5a.Checked = false;
        }

        private void CloBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ans5a_CheckedChanged(object sender, EventArgs e)
        {
            if (ans5a.Checked)
            {
                OthLab.Visible = true;
                OtherBox.Visible = true;
            }
            else {
                OthLab.Visible = false;
                OtherBox.Visible = false;
            }

        }

        private void OtherBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SurForm_Load(object sender, EventArgs e)
        {

        }

        private void OthLab_Click(object sender, EventArgs e)
        {

        }

    }
}
