using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace BimeCRM
{
    class AccessDatabase
    {
        public string connectionString;
        public string dataSourceAddress;

        public AccessDatabase(string dataSourceAddress)
        {
            this.dataSourceAddress = dataSourceAddress;
            LoadConnectionString();
        }

        public bool Exist()
        {
            using (IDbConnection cnn = new SQLiteConnection(connectionString))
            {
                try
                {
                    cnn.Query("select * from TestDb");

                    return true;
                }
                catch
                {
                    FileInfo fileInfo =new FileInfo(dataSourceAddress);
                    if (fileInfo.Length == 0)
                    {
                        File.Delete(dataSourceAddress);
                    }
                    return false;
                }
            }
        }

        public void LoadConnectionString()
        {
            this.connectionString = "Data Source=" + this.dataSourceAddress + ";Version=3;";
        }
    }
}
