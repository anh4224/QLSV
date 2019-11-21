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

    public partial class CreateForm : Form
    {
        private StudentManagement Business;
        public CreateForm()
        {
            InitializeComponent();
            this.Business = new StudentManagement();
            this.btnSave.Click += btnSave_Click;
            this.btnCancle.Click += btnCancel_Click;

        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

            this.Business.AddClass(name, code, hometown, gender);
            MessageBox.Show("Create Class successfully. ");
            this.Close();
        }
    }
}