using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Items
{
    public class ItemsDatabase
    { 
        public ItemsDatabase()
        {
        }
        public void SaveItem(Item itemToSave)
        {
            SQLiteConnection conn = new SQLiteConnection("data source=itemsDatabase.db");
            conn.Open();
            using (SQLiteCommand com = new SQLiteCommand(conn))
            {
                com.CommandText = "INSERT INTO Items (SerialNumber,ItemName,Price) " +
                    "VALUES (" + itemToSave.ItemID + ",'" + itemToSave.ItemName + "','" + itemToSave.ItemPrice + "')";
                com.ExecuteNonQuery();
                com.Dispose();
            }
            conn.Close();
        }
        public void SaveSoftware(SofwareItem softToSave)
        {
            SQLiteConnection conn = new SQLiteConnection("data source=itemsDatabase.db");
            conn.Open();
            using (SQLiteCommand com = new SQLiteCommand(conn))
            {
                com.CommandText = "INSERT INTO Items (SerialNumber,ItemName,Price,LicenceKey,SizeInMB) " +
                    "VALUES (" + softToSave.ItemID + ",'" + softToSave.ItemName + "','" + softToSave.ItemPrice + "'," +
                    "'" + softToSave.LicenceKey + "','" + softToSave.SizeInMB + "')";
                com.ExecuteNonQuery();
                com.Dispose();
            }
            conn.Close();
        }
        public void SaveHardware(HardwareItem hardToSave)
        {
            SQLiteConnection conn = new SQLiteConnection("data source=itemsDatabase.db");
            conn.Open();
            using (SQLiteCommand com = new SQLiteCommand(conn))
            {
                com.CommandText = "INSERT INTO Items (SerialNumber,ItemName,Price,Weight) " +
                    "VALUES (" + hardToSave.ItemID + ",'" + hardToSave.ItemName + "','" + hardToSave.ItemPrice + "','" + hardToSave.Weight + "')";
                com.ExecuteNonQuery();
                com.Dispose();
            }
            conn.Close();
        }
        public void SaveComputer(Computer compToSave)
        {
            SQLiteConnection conn = new SQLiteConnection("data source=itemsDatabase.db");
            conn.Open();
            using (SQLiteCommand com = new SQLiteCommand(conn))
            {
                com.CommandText = "INSERT INTO Items (SerialNumber,ItemName,Price,NoOfCores,AmountRAM,HDDSize) " +
                    "VALUES (" + compToSave.ItemID + ",'" + compToSave.ItemName + "','" + compToSave.ItemPrice + "'," +
                    "'" + compToSave.NoOfCores + "','" + compToSave.AmountOfRAM + "','" + compToSave.HDDSize + "')";
                com.ExecuteNonQuery();
                com.Dispose();
            }
            conn.Close();
        }
        public void SaveMonitor(Monitor monToSave)
        {
            SQLiteConnection conn = new SQLiteConnection("data source=itemsDatabase.db");
            conn.Open();
            using (SQLiteCommand com = new SQLiteCommand(conn))
            {
                com.CommandText = "INSERT INTO Items (SerialNumber,ItemName,Price,Resolution,MonitorType) " +
                    "VALUES (" + monToSave.ItemID + ",'" + monToSave.ItemName + "','" + monToSave.ItemPrice + "'," +
                    "'" + monToSave.Resolution + "','" + monToSave.MonitorType + "')";
                com.ExecuteNonQuery();
                com.Dispose();
            }
            conn.Close();
        }
        //readItem(int id)-vrne en item
        public string readItem(int id)
        {
            SQLiteConnection conn = new SQLiteConnection("data source=itemsDatabase.db");
            conn.Open();
            SQLiteCommand comm = new SQLiteCommand("SELECT ItemName,Price FROM Items WHERE SerialNumber=" + id + ";", conn);
            int itemid = id;
            string itemnm;
            double itemprice;
            using (SQLiteDataReader read = comm.ExecuteReader())
            {
                if (read.HasRows)
                {
                    read.Read();
                    itemnm = read["ItemName"].ToString();//read.GetString
                    itemprice = Convert.ToDouble(read["Price"]);
                    Item readed = new Item(itemid, itemnm, itemprice);
                    return readed.ItemID + " " + readed.ItemName + " " + readed.ItemPrice;
                }
                else
                    return "id don't exist";
            }
        }
        //readitems()-prebere in vrne vse
        public void Readitems()
        {
            
        }
        public SofwareItem readSoftware(int id)
        {
            SofwareItem soft = new SofwareItem();
            SQLiteConnection conn = new SQLiteConnection("data source=itemsDatabase.db");
            conn.Open();
            SQLiteCommand comm = new SQLiteCommand("SELECT LicenceKey,SizeInMB FROM Items WHERE ItemID=" + id + ";", conn);
            using (SQLiteDataReader read = comm.ExecuteReader())
            {
                while (read.Read())
                {
                    soft.LicenceKey = read.GetString(0);
                    soft.SizeInMB = read.GetInt32(1);
                }
                return soft;
            }
        }
        public HardwareItem readHardware(int id)
        {
            HardwareItem hard = new HardwareItem();
            SQLiteConnection conn = new SQLiteConnection("data source=itemsDatabase.db");
            conn.Open();
            SQLiteCommand comm = new SQLiteCommand("SELECT Weight FROM Items WHERE ItemID=" + id + ";", conn);
            using (SQLiteDataReader read = comm.ExecuteReader())
            {
                while (read.Read())
                { 
                     hard.Weight = read.GetDouble(0);
                }
                return hard;
            }
        }
        public Computer readComp(int id)
        {
            Computer comp = new Computer();
            SQLiteConnection conn = new SQLiteConnection("data source=itemsDatabase.db");
            conn.Open();
            SQLiteCommand comm = new SQLiteCommand("SELECT NoOfCores, AmountRAM, HDDSize FROM Items WHERE ItemID=" + id + ";", conn);
            using (SQLiteDataReader read = comm.ExecuteReader())
            {
                while (read.Read())
                {
                    comp.NoOfCores = read.GetInt32(0);
                    comp.AmountOfRAM = read.GetInt32(1);
                    comp.HDDSize = read.GetInt32(2);
                }
                return comp;
            }
        }
        public Monitor readMon(int id)
        {
            Monitor mon = new Monitor();
            SQLiteConnection conn = new SQLiteConnection("data source=itemsDatabase.db");
            conn.Open();
            SQLiteCommand comm = new SQLiteCommand("SELECT Resolution, MonitorType FROM Items WHERE ItemID=" + id + ";", conn);
            using (SQLiteDataReader read = comm.ExecuteReader())
            {
                while (read.Read())
                {
                    mon.Resolution = read.GetString(0);
                    mon.MonitorType = read.GetString(1);
                }
                return mon;
            }
        }
        public int count()
        {
            int id=0;
            SQLiteConnection conn = new SQLiteConnection("data source=itemsDatabase.db");
            conn.Open();
            SQLiteCommand comm = new SQLiteCommand("SELECT COUNT(*) FROM Items",conn);
            SQLiteDataReader read = comm.ExecuteReader();
            while (read.Read()) {
                 id=read.GetInt32(0);
            }
            return id;
        }
        //updateItem(int id, Item itemToUpdate)
        public void updateItem(int id,Item itemToUpdate)
        {
            SQLiteConnection conn = new SQLiteConnection("data source=itemsDatabase.db");
            conn.Open();
            using (SQLiteCommand com = new SQLiteCommand(conn))
            {
                com.CommandText = "UPDATE Items " +
                    "SET ItemName='"+itemToUpdate.ItemName+"', Price="+itemToUpdate.ItemPrice+
                    " WHERE SerialNumber="+id+";";
                com.ExecuteNonQuery();
                com.Dispose();
            }
            conn.Close();
        }
        public void updateHardware(int id, HardwareItem hardToUpdate)
        {
            SQLiteConnection conn = new SQLiteConnection("data source=itemsDatabase.db");
            conn.Open();
            using (SQLiteCommand com = new SQLiteCommand(conn))
            {
                com.CommandText = "UPDATE Items " +
                    "SET ItemName='" + hardToUpdate.ItemName + "', Price=" + hardToUpdate.ItemPrice +", Weight="+ hardToUpdate.Weight +""+
                    " WHERE SerialNumber=" + id + ";";
                com.ExecuteNonQuery();
                com.Dispose();
            }
            conn.Close();
        }
        public void updateSoftware(int id, SofwareItem softToUpdate)
        {
            SQLiteConnection conn = new SQLiteConnection("data source=itemsDatabase.db");
            conn.Open();
            using (SQLiteCommand com = new SQLiteCommand(conn))
            {
                com.CommandText = "UPDATE Items " +
                    "SET ItemName='" + softToUpdate.ItemName + "', Price=" + softToUpdate.ItemPrice + ", LicenceKey=" + softToUpdate.LicenceKey + "," +
                    " SizeInMB=" + softToUpdate.SizeInMB +
                    " WHERE SerialNumber=" + id + ";";
                com.ExecuteNonQuery();
                com.Dispose();
            }
            conn.Close();
        }
        public void updateComp(int id, Computer compToUpdate)
        {
            SQLiteConnection conn = new SQLiteConnection("data source=itemsDatabase.db");
            conn.Open();
            using (SQLiteCommand com = new SQLiteCommand(conn))
            {
                com.CommandText = "UPDATE Items " +
                    "SET ItemName='" + compToUpdate.ItemName + "', Price=" + compToUpdate.ItemPrice + ", NoOfCores=" + compToUpdate.NoOfCores + "," +
                    " AmountRAM=" + compToUpdate.AmountOfRAM + ", HDDSize="+ compToUpdate.HDDSize +
                    " WHERE SerialNumber=" + id + ";";
                com.ExecuteNonQuery();
                com.Dispose();
            }
            conn.Close();
        }
        public void updateMon(int id, Monitor monToUpdate)
        {
            SQLiteConnection conn = new SQLiteConnection("data source=itemsDatabase.db");
            conn.Open();
            using (SQLiteCommand com = new SQLiteCommand(conn))
            {
                com.CommandText = "UPDATE Items " +
                    "SET ItemName='" + monToUpdate.ItemName + "', Price=" + monToUpdate.ItemPrice + "," +
                    " Resoluton=" + monToUpdate.Resolution + ", MonitorType=" + monToUpdate.MonitorType +
                    " WHERE SerialNumber=" + id + ";";
                com.ExecuteNonQuery();
                com.Dispose();
            }
            conn.Close();
        }
        //deleteItem(int ID)
        public void deleteItem(int id)
        {
            SQLiteConnection conn = new SQLiteConnection("data source=itemsDatabase.db");
            conn.Open();
            using (SQLiteCommand com = new SQLiteCommand(conn))
            {
                com.CommandText = "DELETE FROM Items " +
                    "WHERE SerialNumber=" + id + ";";
                com.ExecuteNonQuery();
                com.Dispose();
            }
            conn.Close();
        }
    }
}
