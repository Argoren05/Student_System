using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_System
{
    public partial class UpdateDelateStudentForm : Form
    {
        public UpdateDelateStudentForm()
        {
            InitializeComponent();
        }

        Student student = new Student();

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text);
            string firstname = textBoxFirstName.Text;
            string lastname = textBoxLastName.Text;
            string indexnumber = textBoxIndexNumber.Text;
            DateTime birthdate = dateTimePicker1.Value;

            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;

            if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("Wiek studenta musi byc pomiędzy 10, a 100 lat", "Zła data urodzenia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verification())
            {
                if (student.updateStudent(id ,firstname, lastname, indexnumber, birthdate))
                {
                    MessageBox.Show("Dane Studenta zostały zmienione", "Aktualizowanie Studenta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Błąd", "Aktualizowanie Studenta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Puste pola", "Aktualizowanie Studenta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool verification()
        {
            if ((textBoxFirstName.Text.Trim() == "") ||
                (textBoxLastName.Text.Trim() == "") ||
                (textBoxIndexNumber.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonDelate_Click(object sender, EventArgs e)
        {
            int id  = Convert.ToInt32(textBoxID.Text);
            if(MessageBox.Show("Czy na pewno chcesz usunąć studenta z listy?","Usuwanie Studenta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(student.deleteStudent(id))
                {
                    MessageBox.Show("Student został usunięty", "Usuwanie Studenta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxID.Text = "";
                    textBoxFirstName.Text = "";
                    textBoxLastName.Text = "";
                    textBoxIndexNumber.Text = "";
                    dateTimePicker1.Value = DateTime.Now;
                    Close();
                }
                else
                {
                    MessageBox.Show("Student nie został usunięty", "Usuwanie Studenta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


       
    }
}
