using DevExpress.XtraBars.Ribbon;
using System.Linq;
using System.Windows.Forms;
using Web_Project.Applications.Features.Students;
using Web_Project.Domain.Features.Students;
using Web_Project.Features.Students;
using Web_Project.Features.Teachers;

namespace Web_Project
{
    public partial class Form1 : RibbonForm
    {
        private AddStudent formStudent;
        private AddTeacher formTeahcer;
        private StudentService service;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddStudent_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formStudent = new AddStudent();
            //formStudent.Show();
            DialogResult result = formStudent.ShowDialog();
            if (result == DialogResult.OK)
                PopulateListStudents();
        }

        private void btnCadTeacher_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formTeahcer = new AddTeacher();
            formTeahcer.Show();
        }

        public void PopulateListStudents()
        {
            IQueryable<Student> students = service.GetAll();

            if (students != null)
            {
                list.Items.Clear();
                foreach (var item in students)
                {
                    list.Items.Add(item);
                }
            }
        }
    }
}
