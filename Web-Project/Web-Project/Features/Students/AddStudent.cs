using System;
using System.Windows.Forms;
using Web_Project.Applications.Features.Students;
using Web_Project.Applications.Features.Teachers;
using Web_Project.Domain.Features.Students;

namespace Web_Project.Features.Students
{
    public partial class AddStudent : Form
    {
        private Student student;
        private StudentService service = new StudentService();
        private TeacherService teacherService = new TeacherService();
        public AddStudent()
        {
            InitializeComponent();
            PopulateComboBoxTeacher();
        }

        private void btnsave_Click(object sender, System.EventArgs e)
        {
            student = new Student();
            student.Name = Convert.ToString(txtName.Text);
            student.BirthDate = Convert.ToDateTime(dateBirth);
            student.Teacher.Id = Convert.ToInt32(cbxTeacher.SelectedItem);

            service.Add(student);
        }

        private void PopulateComboBoxTeacher()
        {
            cbxTeacher.Items.Clear();
            var list = teacherService.GetAll();
            foreach (var item in list)
            {
                cbxTeacher.Items.Add(item);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
