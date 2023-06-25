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
    public partial class frmAdminFindScore : Form
    {
        public frmAdminFindScore()
        {
            InitializeComponent();
        }

        private void frmAdminFindScore_Load(object sender, EventArgs e)
        {
            cbbTiaojian.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbbTiaojian.Text.Trim() == "��ѯ����")
            {
                BaseClass.Message("��ʾ����ѡ���ѯ������", "����");
            }
            else
            {
                if (cbbTiaojian.Text.Trim() == "����")
                {
                    string sql = "";
                    if (txtKey.Text.Trim() == "")
                    {
                        sql = "select ID as 'ϵͳ���',UserID as '��������',selectexam as 'ѡ����',judgeexam as '�ж���',Fileexam as '�����',exampoint as '�����ܷ�' from tb_ExamResult";
                        BaseClass.DataGridViewBind(dataGridView1, sql);
                    }
                    else
                    {
                        sql = "select ID as 'ϵͳ���',UserID as '��������',selectexam as 'ѡ����',judgeexam as '�ж���',Fileexam as '�����',exampoint as '�����ܷ�' from tb_ExamResult where UserID like '%"+txtKey.Text.Trim()+"%'";
                        BaseClass.DataGridViewBind(dataGridView1,sql);
                    }
                }
                else
                {
                    string sql = "";
                    if (txtKey.Text.Trim() == "")
                    {
                        sql = "select ID as 'ϵͳ���',UserID as '��������',selectexam as 'ѡ����',judgeexam as '�ж���',Fileexam as '�����',exampoint as '�����ܷ�' from tb_ExamResult";
                        BaseClass.DataGridViewBind(dataGridView1, sql);
                    }
                    else
                    {
                        sql = "select UserName from tb_User where UserCH like '%"+txtKey.Text.Trim()+"%'";
                        SqlConnection conn = BaseClass.DBCon();
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(sql,conn);
                        string id = cmd.ExecuteScalar().ToString();
                        sql = "select ID as 'ϵͳ���',UserID as '��������',selectexam as 'ѡ����',judgeexam as '�ж���',Fileexam as '�����',exampoint as '�����ܷ�' from tb_ExamResult where UserID like '%" + id + "%'";
                        BaseClass.DataGridViewBind(dataGridView1, sql);
                    }
                }
            }
        }

        private void frmAdminFindScore_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            frmAdminManage adminmanage = new frmAdminManage();
            adminmanage.Show();
        }
    }
}