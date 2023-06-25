using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Exam
{
    public partial class frmStudentExam : Form
    {
        public frmStudentExam()
        {
            InitializeComponent();
        }
        public string Username = "";
        public string Userpwd = "";
        SqlConnection conn = BaseClass.DBCon();

        private void checkIsTest()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select Username from tb_User where UserName='"+Username+"'", conn);
            string flag = cmd.ExecuteScalar().ToString();
            if (flag == "0")
            {
                ��ʼ����SToolStripMenuItem.Enabled = true;
                ��ѯ����SToolStripMenuItem.Enabled = false;
            }
            else
            {
                ��ʼ����SToolStripMenuItem.Enabled = false;
                ��ѯ����SToolStripMenuItem.Enabled = true;
            }
            conn.Close();
        }

        private void �˳�ϵͳOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void �޸�����CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePwd changepwd = new frmChangePwd();
            changepwd.username = Username;
            changepwd.ShowDialog();
        }

        private void ��ʼ����SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStartExam startexam = new frmStartExam();
            startexam.studentNumber = Username;
            startexam.Show();
        }
       
     
        private void frmStudentExam_Activated(object sender, EventArgs e)
        {
            checkIsTest();
        }

        private void ��ѯ����SToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string sql = "select * from tb_ExamResult where UserID='"+Username+"'";
            SqlConnection conn = BaseClass.DBCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql,conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();

            string xz = sdr[2].ToString();
            string pd = sdr[3].ToString();
            string tk = sdr[4].ToString();
            string all = sdr[5].ToString();

            string mess = Username + "��ã����Ŀ������£�\n"+"ѡ����÷֣�"+xz+"\n"+"�ж���÷֣�"+pd+"\n"+"�����÷֣�"+tk+"\n"+"����ܷ�Ϊ��"+all;

            MessageBox.Show(mess,"���Գɼ���ѯ");
        }

        private void ����AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.ShowDialog();
        }

        private void ϵͳ��ϢToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("MSINFO32.EXE");
        }

        private void frmStudentExam_Load(object sender, EventArgs e)
        {

        }

        private void frmStudentExam_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void �ļ�FToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ������ʷToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmTestHistory testhistory = new frmTestHistory();
            testhistory.Show();
        }

        private void ��ʼ����SToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStartExam startexam = new frmStartExam();
            startexam.studentNumber = Username;
            startexam.Show();
        }

      

       

        
    }
}