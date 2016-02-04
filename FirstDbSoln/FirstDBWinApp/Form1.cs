using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirstDB.DAL;

namespace FirstDBWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            StudentInfo NewSTDObj = new StudentInfo();
            StudentInfoDl NewNewSTD = new StudentInfoDl();

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Azeez Comment
            NewSTDObj.Matric_Num = Convert.ToInt32 (txtMatNum.Text);
            NewSTDObj.Fullname = txtFName.Text;
            NewSTDObj.Address = txtAdd.Text;
            NewSTDObj.Age = txtAge.Text;
            NewNewSTD.Save(NewSTDObj);
            MessageBox.Show("Record Save Succesfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewStudents NewVfrm = new ViewStudents();
            NewVfrm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmReport NewRprtFrm = new frmReport();
            NewRprtFrm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 Newfrm1 = new Form1();
            Application.Exit();
            
        }

        }
    }
