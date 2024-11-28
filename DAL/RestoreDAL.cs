using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RestoreDAL
    {

        public bool RestoreDatabase(string backupPath)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["BackupsDBWin"].ConnectionString;

                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Đóng mọi kết nối tới database
                    string closeConnections = "ALTER DATABASE QuanLyBanVeXeKhach SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                    using (var cmd = new SqlCommand(closeConnections, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    
                    // Restore database
                    string restoreQuery = $@"
                        RESTORE DATABASE QuanLyBanVeXeKhach 
                        FROM DISK = '{backupPath}' 
                        WITH MOVE 'QuanLyBanVeXeKhach' TO 'D:\Backups\QuanLyBanVeXeKhach.mdf',
                             MOVE 'QuanLyBanVeXeKhach_log' TO 'D:\Backups\QuanLyBanVeXeKhach.ldf',
                             REPLACE, RECOVERY;";
                    using (var cmd = new SqlCommand(restoreQuery, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }


                    // Đặt lại MULTI_USER mode
                    string setMultiUser = "ALTER DATABASE QuanLyBanVeXeKhach SET MULTI_USER;";
                    using (var cmd = new SqlCommand(setMultiUser, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Restore failed: " + ex.Message);
            }
        }




    }
}
