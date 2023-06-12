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
    public partial class AddGradeForm : Form
    {
        public AddGradeForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Grade grade = new Grade();
            int studentId = Convert.ToInt32(textBoxID.Text);
            string studentName = textBoxStudentName.Text;
            string studentLastName = textBoxStudentLastName.Text;
            string subject = textBoxSubject.Text;
            string grade_ = textBoxGrade.Text;

            if (verification())
            {
                if (grade.insertGrade(studentId, studentName, studentLastName, subject, grade_))
                {
                    MessageBox.Show("Ocena została dodana", "Dodawanie Oceny", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Błąd", "Dodawanie Oceny", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Puste pola", "Dodawanie Oceny", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        bool verification()
        {
            if ((textBoxID.Text.Trim() == "") ||
                (textBoxStudentName.Text.Trim() == "") ||
                (textBoxStudentLastName.Text.Trim() == "") ||
                (textBoxSubject.Text.Trim() == "") ||
                (textBoxGrade.Text.Trim() == ""))       
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
    }
}
