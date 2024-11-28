using DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BackupDAL
    {
        public bool BackupDatabase(string backupPath)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["BackupsDBWin"].ConnectionString;

                string query = $"BACKUP DATABASE QuanLyBanVeXeKhach TO DISK = '{backupPath}'";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Backup failed: " + ex.Message);
            }


        }



    }
}
