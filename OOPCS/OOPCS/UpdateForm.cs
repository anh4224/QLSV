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
    public partial class UpdateForm : Form
    {
        private StudentManagement Business;
        private int ClassID;
        public UpdateForm(int id)
        {
            InitializeComponent();
            this.Business = new StudentManagement();
            this.ClassID = id;
            this.btnCancle.Click += btnCancel_Click;
            this.btnSave.Click += btnSave_Click;
            this.Load += UpdateForm_Load;
        }



        void btnSave_Click(object sender, EventArgs e)
        {
            var name = this.txtName.Text;
            var code = this.txtCode.Text;
            var hometown = this.RTXHometown.Text;
            var male = this.rdbMale.Checked;
            var female = this.rdbFemale.Checked;
            bool gender;
            if (this.rdbFemale.Checked == true)
                gender = true;
            else
                gender = false;
            this.Business.EditClass(this.ClassID, name, code, hometown, gender);
            MessageBox.Show("Update Class successfully ");
            this.Close();
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void UpdateForm_Load(object sender, EventArgs e)
        {
            var @class = this.Business.GetStudent(this.ClassID);
            this.txtName.Text = @class.name;
            this.txtCode.Text = @class.code;
        }
    }
}