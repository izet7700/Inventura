using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    public class Item
    {
        //prop+2xTab-get,set
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }
        //ctor+2xTab-constructor
        public Item(int itemid, string itemname, double itemprice)
        {
            ItemID = itemid;
            ItemName = itemname;
            ItemPrice = itemprice;
        }
        public Item(int itemId)
        {
            ItemID = itemId;
        }
        public Item()
        {

        }
        //override-pozabi ToString, ki si ga dobil od Object-a
        public override string ToString()
        {
            string stringToReturn;
            stringToReturn = ItemID + " " + ItemName;
            return stringToReturn;
        }
    }
    public class SofwareItem:Item
    {
        public string LicenceKey { get; set; }
        private int size;
        public int SizeInMB {
            get {
                return size;
            }
            set {
                if (value > 0) size = value;
            }
        }
        public SofwareItem(int itemID, double price, string name, string licence, int sizeMB):base(itemID,name,price)
        {
            LicenceKey = licence;
            SizeInMB = sizeMB;
        }
        public SofwareItem()
        {

        }
        public SofwareItem(int id)
        {
            ItemID = id;
        }
        public override string ToString()
        {
            return base.ToString() + " " + LicenceKey + " " + SizeInMB;
        }
    }
    public class HardwareItem : Item
    {
        private double wei;
        public double Weight {
            get { return wei; }
            set { if (value >= 0.0) wei = value; }
        }
        public HardwareItem()
        {

        }
        public HardwareItem(int id, double price, string name, double we) : base(id, name, price)
        {
            Weight = we;
        }
        public HardwareItem(int id)
        {
            ItemID = id;
        }
        public override string ToString()
        {
            return base.ToString() + " " + Weight;
        }
    }
    public class Computer : Item
    {
        private int stJ;
        public int NoOfCores
        {
            get { return stJ; }
            set { if (value > 0) stJ = value; }
        }
        private int ram;
        public int AmountOfRAM
        {
            get { return ram; }
            set { if (value > 0) ram = value; }
        }
        private int hdd;
        public int HDDSize
        {
            get { return hdd; }
            set { if (value > 0) hdd = value; }
        }
        public Computer(int id, string name, double price, int noc, int _ram, int _hdd) : base(id, name, price)
        {
            NoOfCores = noc;
            AmountOfRAM = _ram;
            HDDSize = _hdd;
        }
        public Computer()
        {

        }
        public Computer(int id)
        {
            ItemID = id;
        }
        public override string ToString()
        {
            return base.ToString()+" "+NoOfCores+" "+AmountOfRAM+" "+HDDSize;
        }
    }
    public class Monitor : Item
    {
        public string Resolution { get; set; }
        private string tip;
        public string MonitorType
        {
            get { return tip; }
            set { if (value == "LCD" || value == "LED" || value == "CRT") tip = value;}
        }
        public Monitor(int id, string name, double price, string resol, string tipM):base(id, name,price)
        {
            Resolution = resol;
            MonitorType = tipM;
        }
        public Monitor()
        {

        }
        public Monitor(int id)
        {
            ItemID = id;
        }
        public override string ToString()
        {
            return base.ToString()+" "+Resolution+" "+MonitorType;
        }
    }
}
