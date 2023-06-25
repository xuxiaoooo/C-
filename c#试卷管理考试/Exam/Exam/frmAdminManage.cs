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
    public partial class frmAdminManage : Form
    {
        public frmAdminManage()
        {
            InitializeComponent();
        }
        public string username = "";
        private void �˳�ϵͳToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmAdminManage_Load(object sender, EventArgs e)
        {



        }


        private void ���ѡ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminAddSelectExam addselectexam = new frmAdminAddSelectExam();
            addselectexam.Show();
        }

        private void ����ж���ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminAddJudgeExam addjudgeExam = new frmAdminAddJudgeExam();
            addjudgeExam.Show();
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminFillExam fillexam = new frmAdminFillExam();
            fillexam.Show();
        }

        private void ɾ��ToolStripMenuItem_Click(object sender, EventArgs e)//ɾ��ѡ����
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                contextMenuStrip1.Enabled = false;
            }
            else
            {
                int MMid = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
                string sql = "delete from tb_Test where ID='" + MMid + "'";
                BaseClass.DeleteData(sql);
            }
        }

        private void frmAdminManage_Activated(object sender, EventArgs e)
        {
            tsslAdmin.Text = "��ǰ��¼�û���" + username + "  �û���ݣ�����Ա";
            //�������е�ѡ����
            string sql = "select ID as 'ϵͳ���',subject as 'ѡ������Ŀ',A as 'ѡ��A',B as 'ѡ��B',C as 'ѡ��C',D as 'ѡ��D',rightkey as '��ȷѡ��' from tb_Test where TypeID=1";
            BaseClass.DataGridViewBind(dataGridView1, sql);

            //�������е��ж���
            string sql1 = "select ID as 'ϵͳ���',subject as '�ж�����Ŀ',rightkey as '��ȷ�ж�' from tb_Test where TypeID=2";
            BaseClass.DataGridViewBind(dataGridView2, sql1);
            //�������е������
            string sql2 = "select ID as 'ϵͳ���',subject as '�������Ŀ',rightkey as '��ȷ��' from tb_Test where TypeID=3";
            BaseClass.DataGridViewBind(dataGridView3, sql2);
        }

        private void �޸�ToolStripMenuItem_Click(object sender, EventArgs e)//�޸�ѡ����
        {
            int MMid = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
            this.Hide();
            frmAdminAddSelectExam selectexam = new frmAdminAddSelectExam();
            selectexam.flag = MMid;
            selectexam.Text = "���Թ���-�޸�ѡ����";
            selectexam.button1.Text = "�޸�";
            selectexam.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//˫��ѡ�����ĳһ�е����޸Ĵ���
        {
            �޸�ToolStripMenuItem_Click(sender,e);
        }

        private void ɾ��ToolStripMenuItem1_Click(object sender, EventArgs e)//ɾ���ж���
        {
            if (dataGridView2.SelectedRows.Count == 0)
            {
                contextMenuStrip2.Enabled = false;
            }
            else
            {
                int MMid = Convert.ToInt32(dataGridView2.SelectedCells[0].Value);
                string sql = "delete from tb_Test where ID='" + MMid + "'";
                BaseClass.DeleteData(sql);
            }
        }

        private void �޸�ToolStripMenuItem1_Click(object sender, EventArgs e)//�޸��ж���
        {
            int MMid = Convert.ToInt32(dataGridView2.SelectedCells[0].Value);
            this.Hide();
            frmAdminAddJudgeExam judgeexam = new frmAdminAddJudgeExam();
            judgeexam.flag = MMid;
            judgeexam.Text = "���Թ���-�޸��ж���";
            judgeexam.button1.Text = "�޸�";
            judgeexam.Show();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//˫���ж����ĳһ�е����޸��ж��ⴰ��
        {
            �޸�ToolStripMenuItem1_Click(sender,e);
        }

        private void ɾ��ToolStripMenuItem2_Click(object sender, EventArgs e)//ɾ�������
        {
            if (dataGridView3.SelectedRows.Count == 0)
            {
                contextMenuStrip3.Enabled = false;
            }
            else
            {
                int MMid = Convert.ToInt32(dataGridView3.SelectedCells[0].Value);
                string sql = "delete from tb_Test where ID='" + MMid + "'";
                BaseClass.DeleteData(sql);
            }
        }

        private void �޸�ToolStripMenuItem2_Click(object sender, EventArgs e)//�޸������
        {
            int MMid = Convert.ToInt32(dataGridView3.SelectedCells[0].Value);
            this.Hide();
            frmAdminFillExam fillexam = new frmAdminFillExam();
            fillexam.flag = MMid;
            fillexam.Text = "���Թ���-�޸������";
            fillexam.button1.Text = "�޸�";
            fillexam.Show();
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//˫��������ĳһ�е����޸Ĵ���
        {
            �޸�ToolStripMenuItem2_Click(sender,e);
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminExamSet adminexamset = new frmAdminExamSet();
            adminexamset.Show();
        }

        private void ����ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("MSINFO32.EXE");
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.ShowDialog();
        }

        private void �ɼ���ѯToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminFindScore findscore = new frmAdminFindScore();
            findscore.Show();
        }

        private void �û�����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminStudent student = new frmAdminStudent();
            student.Show();
        }

        private void frmAdminManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}