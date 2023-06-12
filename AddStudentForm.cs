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
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            string firstname = textBoxFirstName.Text;
            string lastname = textBoxLastName.Text;
            string indexnumber = textBoxIndexNumber.Text;
            DateTime birthdate = dateTimePicker1.Value;

            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;

            if(((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("Wiek studenta musi byc pomiędzy 10, a 100 lat", "Zła data urodzenia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(verification())
            {
                if(student.insertStudent(firstname, lastname, indexnumber, birthdate))
                {
                    MessageBox.Show("Nowy student został dodany", "Dodawanie Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Błąd", "Dodawanie Studenta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Puste pola", "Dodawanie Studenta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        bool verification() 
        {
            if((textBoxFirstName.Text.Trim() == "") ||
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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
