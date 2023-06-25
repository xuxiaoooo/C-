﻿using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagerSystem.Model;

namespace HotelManagerSystem.DAL
{
    public class RoomTypeDao
    {
        #region 获取所有房间类型
        /// <summary>
        /// 获取所有房间类型
        /// </summary>
        /// <returns></returns>
        public static List<RoomType> SelectRoomTypesAll()
        {
            List<RoomType> types = new List<RoomType>();
            string sql = "select * from ROOMTYPE";
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                RoomType type = new RoomType();
                type.Roomtype = (int)dr["Roomtype"];
                type.RoomName = dr["RoomName"].ToString();
                types.Add(type);
            }
            dr.Close();
            DBHelper.Closecon();

            return types;
        }
        #endregion

        #region 根据房间编号查询房间类型名称
        /// <summary>
        /// 根据房间编号查询房间类型名称
        /// </summary>
        /// <param name="no"></param>
        /// <returns></returns>
        public static RoomType SelectRoomTypeByRoomNo(string no)
        {
            RoomType roomtype = null;
            string sql = "select t.RoomName from ROOMTYPE t,ROOM r where t.RoomType=r.RoomType and r.RoomNo='" + no + "'";
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
            if (dr.Read())
            {
                roomtype = new RoomType();
                roomtype.RoomName = dr["RoomName"].ToString();
            }
            dr.Close();
            DBHelper.Closecon();
            return roomtype;
        }
        #endregion
    }
}
