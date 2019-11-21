using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPCS
{
    public partial class Form1 : Form
    {
        private StudentManagement business;
        public Form1()
        {
            InitializeComponent();
            this.business = new StudentManagement();
            this.Load += IndexForm_Load;
            this.btnCreate.Click += btnCreate_Click;
            this.btnDelete.Click += btnDelete_Click;
            this.grdStudent.Click += grdStudent_Click;
            
        }
        private void IndexForm_Load(object sender, EventArgs e)
        {
            LoadAllStudent();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            var CreateForm = new CreateForm();
            CreateForm.ShowDialog();
            LoadAllStudent();
        }
     
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grdStudent.SelectedRows.Count == 1)
            {
                if ((MessageBox.Show("Bạn có chắc xóa phần này không", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes))
                {
                    var students = (PM23737)grdStudent.SelectedRows[0].DataBoundItem;
                    this.business.DeleteStudent(students.id);
                    MessageBox.Show("Xóa thành công");
                    LoadAllStudent();
                }
            }

        }
        private void LoadAllStudent()
        {
            var students = this.business.GetStudent();
            this.grdStudent.DataSource = students;
        }
        private void grdStudent_Click(object sender, EventArgs e)
        {
        }
        
    }
}