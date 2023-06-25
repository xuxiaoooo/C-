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
    class BaseClass
    {
        public static SqlConnection DBCon()
        {
            //�����˵����ˣ���Ҫ������ġ�DESKTOP-B8V7E97\\A���ĳ����Լ��ķ�������
            return new SqlConnection("Data Source=.;Initial Catalog=db_Exam;User ID=sa;password=xuxiao");//�������ݿ�
        }
        public static void Message(string a, string b)
        {
            MessageBox.Show(a,b,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }
        public static void InsertData(string strSQL)
        {
            SqlConnection conn = DBCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand(strSQL,conn);
            if (cmd.ExecuteNonQuery() > 0)
            {
                Message("��ʾ����ӳɹ���", "��ʾ");
            }
            else
            {
                Message("��ʾ�����ʧ�ܣ�","����");
            }
            conn.Close();
        }

        public static void UpdateData(string strSQL)
        {
            SqlConnection conn = DBCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            if (cmd.ExecuteNonQuery() > 0)
            {
                Message("��ʾ���޸ĳɹ���", "��ʾ");
            }
            else
            {
                Message("��ʾ���޸�ʧ�ܣ�", "����");
            }
            conn.Close();
        }

        public static void DeleteData(string strSQL)
        {
            SqlConnection conn = DBCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            if (cmd.ExecuteNonQuery() > 0)
            {
                Message("��ʾ��ɾ���ɹ���", "��ʾ");
            }
            else
            {
                Message("��ʾ��ɾ��ʧ�ܣ�", "����");
            }
            conn.Close();
        }
        public static void DataGridViewBind(DataGridView dgv,string strSQL)
        {
            SqlConnection conn = DBCon();
            SqlDataAdapter sda = new SqlDataAdapter(strSQL,conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dgv.DataSource = ds.Tables[0];
        }
    }
}
