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
    public partial class frmChangePwd : Form
    {
        public frmChangePwd()
        {
            InitializeComponent();
        }
        public string username = "";
        SqlConnection conn = BaseClass.DBCon();
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtOldPwd.Text.Trim() == "")
            {
                BaseClass.Message("��ʾ����������룡", "����");
            }
            else
            {
                if (txtNewPwd.Text.Trim() == "")
                {
                    BaseClass.Message("��ʾ�����������룡", "����");
                }
                else
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select * from tb_User where UserFlag=0 and UserName='" + username + "'and UserPwd='" + txtOldPwd.Text.Trim() + "'", conn);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    sdr.Read();
                    if (sdr.HasRows)
                    {
                        sdr.Close();
                        cmd = new SqlCommand("update tb_User set UserPwd='" + txtNewPwd.Text.Trim() + "' where UserFlag=0 and UserName='" + username + "'", conn);
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            if (txtConfirmPwd.Text == txtNewPwd.Text)
                            {
                                BaseClass.Message("��ʾ�������޸ĳɹ���", "��ʾ");
                            }
                            else
                            {
                                BaseClass.Message("��ʾ��������������벻һ�£�", "��ʾ");
                            }
                            this.Close();
                        }
                    }
                    else
                    {
                        BaseClass.Message("��ʾ�����������", "����");
                    }
                    conn.Close();
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}