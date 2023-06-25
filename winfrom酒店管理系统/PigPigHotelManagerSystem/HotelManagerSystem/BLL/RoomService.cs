﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using HotelManagerSystem.Model;
using HotelManagerSystem.DAL;

namespace HotelManagerSystem.BLL
{
    public class RoomService
    {
        public List<Room> SelectRoomAll()
        {
            return RoomDao.SelectRoomAll();
        }

        public static Room SelectRoomByRoomNo(string no)
        {
            return RoomDao.SelectRoomByRoomNo(no);
        }

        #region 根据房间状态来查询可使用的房间
        /// <summary>
        /// 根据房间状态来查询可使用的房间
        /// </summary>
        /// <returns></returns>
        public static List<Room> SelectCanUseRoomAll()
        {
            List<Room> rooms = new List<Room>();
            string sql = "select * from ROOM r,ROOMTYPE t,ROOMSTATE rs where r.RoomType=t.RoomType and r.RoomStateId=rs.RoomStateId and r.RoomStateId='0'";
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Room room = new Room();
                room.RoomNo = (string)dr["RoomNo"];
                room.CustoNo = dr["CustoNo"].ToString();
                room.RoomMoney = (decimal)dr["RoomMoney"];
                room.PersonNum = Convert.ToString(dr["PersonNum"]);
                if (!DBNull.Value.Equals(dr["CheckTime"]))
                {
                    room.CheckTime = DateTime.Parse(dr["CheckTime"].ToString());
                }
                if (!DBNull.Value.Equals(dr["CheckOutTime"]))
                {
                    room.CheckOutTime = DateTime.Parse(dr["CheckOutTime"].ToString());
                }
                room.RoomStateId = (int)dr["RoomStateId"];
                room.RoomState = (string)dr["RoomState"];
                room.RoomType = (int)dr["RoomType"];
                room.RoomPosition = (string)dr["RoomPosition"];
                room.typeName = (string)dr["RoomName"];
                rooms.Add(room);
            }
            dr.Close();
            DBHelper.Closecon();
            return rooms;
        }
        #endregion

        #region 根据房间编号退房（退房）
        /// <summary>
        /// 根据房间编号退房（退房）
        /// </summary>
        /// <param name="room"></param>
        /// <returns></returns>
        public static int UpdateRoomByRoomNo(string room)
        {
            return RoomDao.UpdateRoomByRoomNo(room);
        }
        #endregion

        #region 根据房间编号查询截止到今天住了多少天
        /// <summary>
        /// 根据房间编号查询截止到今天住了多少天
        /// </summary>
        /// <param name="roomno"></param>
        /// <returns></returns>
        public static object DayByRoomNo(string roomno)
        {
            return RoomDao.DayByRoomNo(roomno);
        }
        #endregion

        #region 根据房间编号修改房间信息（入住）
        /// <summary>
        /// 根据房间编号修改房间信息（入住）
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public static int UpdateRoomInfo(Room r)
        {
            return RoomDao.UpdateRoomInfo(r);
        }
        #endregion

        #region 查询可入住房间数量
        /// <summary>
        /// 查询可入住房间数量
        /// </summary>
        /// <returns></returns>
        public static object SelectCanUseRoomAllByRoomState()
        {
            return RoomDao.SelectCanUseRoomAllByRoomState();
        }
        #endregion

        #region 查询已入住房间数量
        /// <summary>
        /// 查询已入住房间数量
        /// </summary>
        /// <returns></returns>
        public static object SelectNotUseRoomAllByRoomState()
        {
            return RoomDao.SelectNotUseRoomAllByRoomState();
        }
        #endregion

        #region 查询脏房间数量
        /// <summary>
        /// 查询脏房间数量
        /// </summary>
        /// <returns></returns>
        public static object SelectNotClearRoomAllByRoomState()
        {
            return RoomDao.SelectNotClearRoomAllByRoomState();
        }
        #endregion

        #region 查询脏房间数量
        /// <summary>
        /// 查询脏房间数量
        /// </summary>
        /// <returns></returns>
        public static object SelectFixingRoomAllByRoomState()
        {
            return RoomDao.SelectFixingRoomAllByRoomState();
        }
        #endregion

        #region 根据房间编号查询房间状态名称
        /// <summary>
        /// 根据房间编号查询房间状态名称
        /// </summary>
        /// <param name="roomno"></param>
        /// <returns></returns>
        public static object SelectRoomStateNameByRoomNo(string roomno)
        {
            return RoomDao.SelectRoomStateNameByRoomNo(roomno);
        }
        #endregion

        #region 根据房间编号更改房间状态
        /// <summary>
        /// 根据房间编号更改房间状态
        /// </summary>
        /// <param name="roomno"></param>
        /// <param name="stateid"></param>
        /// <returns></returns>
        public static int UpdateRoomStateByRoomNo(string roomno, int stateid)
        {
            return RoomDao.UpdateRoomStateByRoomNo(roomno, stateid);
        }
        #endregion

        #region 查询所有可消费（已住）房间
        /// <summary>
        /// 查询所有可消费（已住）房间
        /// </summary>
        /// <returns></returns>
        public static List<Room> SelectRoomByStateAll()
        {
            return RoomDao.SelectRoomByStateAll();
        }
        #endregion

        #region 获取所有房间状态
        /// <summary>
        /// 获取所有房间状态
        /// </summary>
        /// <returns></returns>
        public static List<Room> SelectRoomStateAll()
        {
            return RoomDao.SelectRoomStateAll();
        }
        #endregion

        #region 根据房间编号查询房间状态编号
        /// <summary>
        /// 根据房间编号查询房间状态编号
        /// </summary>
        /// <param name="roomno"></param>
        /// <returns></returns>
        public static object SelectRoomStateIdByRoomNo(string roomno)
        {
            return RoomDao.SelectRoomStateIdByRoomNo(roomno);
        }
        #endregion
    }
}
