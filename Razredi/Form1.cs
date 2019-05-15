using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Razredi
{
    public partial class Form1 : Form
    {
        public void lista()
        {
            listBox1.Items.Clear();
            SQLiteConnection conn = new SQLiteConnection("data source=itemsDatabase.db");
            conn.Open();
            SQLiteCommand comm = new SQLiteCommand("SELECT * FROM Items;", conn);
            using (SQLiteDataReader read = comm.ExecuteReader())
            {
                while (read.Read())
                {
                    listBox1.Items.Add(read["SerialNumber"].ToString() + " " + read["ItemName"].ToString() + " " + read["Price"].ToString()
                    + "  " + read["LicenceKey"].ToString() + "   " + read["SizeInMB"].ToString() + "    " + read["Weight"].ToString() +
                    "   " + read["NoOfCores"].ToString() + "    " + read["AmountRAM"].ToString() + "   " + read["HDDSize"].ToString() +
                    "   " + read["Resolution"].ToString() + "   " + read["MonitorType"].ToString());
                    listBox1.DisplayMember = read["ItemName"].ToString() + "  " + read["Price"].ToString() + " " + read["SerialNumber"].ToString()
                        + "  " + read["LicenceKey"].ToString() + "   " + read["SizeInMB"].ToString() + "    " + read["Weight"].ToString() +
                        "   " + read["NoOfCores"].ToString() + "    " + read["AmountRAM"].ToString() + "   " + read["HDDSize"].ToString() +
                        "   " + read["Resolution"].ToString() + "   " + read["MonitorType"].ToString();
                }
            }
            listBox1.Visible = true;
            forUpdateLabel.Visible = true;
            deleteListButton.Visible = true;
            deleteButton.Visible = false;
            DeleteTextBox.Visible = false;
            readButton.Visible = false;
            readOneTextBox.Visible = false;
            conn.Close();
        }
        public void listaUp()
        {
            if (licenceTextBox.Text != "" || sizeMbTextBox.Text != "")
            {
                string itemID = itemIDTextBox.Text;
                string itemName = itemNameTextBox.Text;
                double price;
                Double.TryParse(priceTextBox.Text, out price);
                int id;
                int.TryParse(itemID, out id);
                string licence = licenceTextBox.Text;
                int size = Convert.ToInt32(sizeMbTextBox.Text);
                SofwareItem newItem = new SofwareItem(id, price, itemName, licence, size);
                ItemsDatabase db = new ItemsDatabase();
                db.updateSoftware(id, newItem);
                MessageBox.Show("Updated");
            }
            if (weightTextBox.Text != "")
            {
                string itemID = itemIDTextBox.Text;
                string itemName = itemNameTextBox.Text;
                double price;
                Double.TryParse(priceTextBox.Text, out price);
                int id;
                int.TryParse(itemID, out id);
                double weight;
                Double.TryParse(weightTextBox.Text, out weight);
                HardwareItem newItem = new HardwareItem(id, price, itemName, weight);
                ItemsDatabase db = new ItemsDatabase();
                db.updateHardware(id, newItem);
                MessageBox.Show("Updated");
            }
            if (noOfCoresTextBox.Text != "" || ramTextBox.Text != "" || hddTextBox.Text != "")
            {
                string itemID = itemIDTextBox.Text;
                string itemName = itemNameTextBox.Text;
                double price;
                Double.TryParse(priceTextBox.Text, out price);
                int id;
                int.TryParse(itemID, out id);
                int ram = Convert.ToInt32(ramTextBox.Text);
                int cores = Convert.ToInt32(noOfCoresTextBox.Text);
                int hdd = Convert.ToInt32(hddTextBox.Text);
                Computer newItem = new Computer(id, itemName, price, cores, ram, hdd);
                ItemsDatabase db = new ItemsDatabase();
                db.updateComp(id, newItem);
                MessageBox.Show("Updated");
            }
            if (resolutionTextBox.Text != "" || monTypeTextBox.Text != "")
            {
                string itemID = itemIDTextBox.Text;
                string itemName = itemNameTextBox.Text;
                double price;
                Double.TryParse(priceTextBox.Text, out price);
                int id;
                int.TryParse(itemID, out id);
                string resol = resolutionTextBox.Text;
                string type = monTypeTextBox.Text;
                Monitor newItem = new Monitor(id, itemName, price, resol, type);
                ItemsDatabase db = new ItemsDatabase();
                db.updateMon(id, newItem);
                MessageBox.Show("Updated");
            }
            if (itemComboBox.SelectedItem.ToString() == "Item")
            {
                string itemID = itemIDTextBox.Text;
                string itemName = itemNameTextBox.Text;
                double price;
                Double.TryParse(priceTextBox.Text, out price);
                int id;
                int.TryParse(itemID, out id);
                Item newItem = new Item(id, itemName, price);
                ItemsDatabase db = new ItemsDatabase();
                db.updateItem(id, newItem);
                MessageBox.Show("Updated");
            }
        }
        public Form1()
        {
            InitializeComponent();
            //Item newItem = new Item("dasdsad", "dasdsad", 3,5);
        }
        public string[] splits;
        public int serNum;
        private void saveButton_Click(object sender, EventArgs e)
        {
            try { 
                if (licenceTextBox.Text != "" || sizeMbTextBox.Text != "")
                {
                    int itemID = Convert.ToInt32(itemIDTextBox.Text);
                    string itemName = itemNameTextBox.Text;
                    double price;
                    Double.TryParse(priceTextBox.Text, out price);
                    string licence = licenceTextBox.Text;
                    int sizeMb = Convert.ToInt32(sizeMbTextBox.Text);
                    SofwareItem newSoft = new SofwareItem(itemID, price, itemName, licence, sizeMb);
                    ItemsDatabase db = new ItemsDatabase();
                    db.SaveSoftware(newSoft);
                    MessageBox.Show("Saved");
                }
                if (weightTextBox.Text != "")
                    {
                    int itemID = Convert.ToInt32(itemIDTextBox.Text);
                    string itemName = itemNameTextBox.Text;
                    double price;
                    Double.TryParse(priceTextBox.Text, out price);
                    double weight;
                    Double.TryParse(weightTextBox.Text, out weight);
                    HardwareItem newhard = new HardwareItem(itemID, price, itemName, weight);
                    ItemsDatabase db = new ItemsDatabase();
                    db.SaveHardware(newhard);
                    MessageBox.Show("Saved");

                }
                if (noOfCoresTextBox.Text != "" || ramTextBox.Text != "" || hddTextBox.Text != "")
                {
                    int itemID = Convert.ToInt32(itemIDTextBox.Text);
                    string itemName = itemNameTextBox.Text;
                    double price;
                    Double.TryParse(priceTextBox.Text, out price);
                    int ram = Convert.ToInt32(ramTextBox.Text);
                    int cores = Convert.ToInt32(noOfCoresTextBox.Text);
                    int hdd = Convert.ToInt32(hddTextBox.Text);
                    Computer newComp = new Computer(itemID, itemName, price, ram, cores, hdd);
                    ItemsDatabase db = new ItemsDatabase();
                    db.SaveComputer(newComp);
                    MessageBox.Show("Saved");
                }
                if (resolutionTextBox.Text != "" || monTypeTextBox.Text != "")
                {
                    int itemID = Convert.ToInt32(itemIDTextBox.Text);
                    string itemName = itemNameTextBox.Text;
                    double price;
                    Double.TryParse(priceTextBox.Text, out price);
                    string resol = resolutionTextBox.Text;
                    string type = monTypeTextBox.Text;
                    Monitor newMon = new Monitor(itemID, itemName, price, resol, type);
                    ItemsDatabase db = new ItemsDatabase();
                    db.SaveMonitor(newMon);
                    MessageBox.Show("Saved");
                }
                if (itemComboBox.SelectedItem.ToString() == "Item")
                {
                    int itemID = Convert.ToInt32(itemIDTextBox.Text);
                    string itemName = itemNameTextBox.Text;
                    double price;
                    Double.TryParse(priceTextBox.Text, out price);
                    Item newItem = new Item(itemID, itemName, price);
                    ItemsDatabase db = new ItemsDatabase();
                    db.SaveItem(newItem);
                    MessageBox.Show("Saved");
                }
            }
            catch
            {
                MessageBox.Show("Try again");            
            }
        }

        private void itemIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                listaUp();
                lista();
            }
            catch
            {
                MessageBox.Show("Try again");
            }
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            try {
                string itemID = readOneTextBox.Text;
                int id = Convert.ToInt32(itemID);
                Item newItem = new Item(id);
                SofwareItem newSoft = new SofwareItem(id);
                HardwareItem newhard = new HardwareItem(id);
                Computer newComp = new Computer(id);
                Monitor newmon = new Monitor(id);
                ItemsDatabase db = new ItemsDatabase();
                MessageBox.Show(db.readItem(id) + " " + db.readHardware(id) + " " + db.readSoftware(id) + " " + db.readComp(id) + " " + db.readMon(id));
            }
            catch
            {
                MessageBox.Show("Try again");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                string itemID = DeleteTextBox.Text;
                int id = Convert.ToInt32(itemID);
                Item newItem = new Item(id);
                ItemsDatabase db = new ItemsDatabase();
                db.deleteItem(id);
                MessageBox.Show("Deleted");
            }
            catch
            {
                MessageBox.Show("Try again");
            }
        }

        private void allButton_Click(object sender, EventArgs e)
        {
            try {
                lista();
            }
            catch
            {
                MessageBox.Show("Try again");
            }
        }
        private void izbButton_Click(object sender, EventArgs e)
        {
            if (itemComboBox.Text=="")
            {
                MessageBox.Show("Try again");
            }
            else if (itemComboBox.SelectedItem.ToString() != "")
            {
                if (itemComboBox.SelectedItem.ToString() == "Software")
                {
                    licenceLabel.Visible = true;
                    sizeMbLabel.Visible = true;
                    licenceTextBox.Visible = true;
                    sizeMbTextBox.Visible = true;
                    weightLabel.Visible = false;
                    weightTextBox.Visible = false;
                    noOfCoresLabel.Visible = false;
                    ramLabel.Visible = false;
                    hddLabel.Visible = false;
                    noOfCoresTextBox.Visible = false;
                    ramTextBox.Visible = false;
                    hddTextBox.Visible = false;
                    resolutionLabel.Visible = false;
                    monTypeLabel.Visible = false;
                    resolutionTextBox.Visible = false;
                    monTypeTextBox.Visible = false;
                }
                if (itemComboBox.SelectedItem.ToString() == "Hardware")
                {
                    licenceLabel.Visible = false;
                    sizeMbLabel.Visible = false;
                    licenceTextBox.Visible = false;
                    sizeMbTextBox.Visible = false;
                    weightLabel.Visible = true;
                    weightTextBox.Visible = true;
                    noOfCoresLabel.Visible = false;
                    ramLabel.Visible = false;
                    hddLabel.Visible = false;
                    noOfCoresTextBox.Visible = false;
                    ramTextBox.Visible = false;
                    hddTextBox.Visible = false;
                    resolutionLabel.Visible = false;
                    monTypeLabel.Visible = false;
                    resolutionTextBox.Visible = false;
                    monTypeTextBox.Visible = false;
                }
                if (itemComboBox.SelectedItem.ToString() == "Computer")
                {
                    noOfCoresLabel.Visible = true;
                    ramLabel.Visible = true;
                    hddLabel.Visible = true;
                    noOfCoresTextBox.Visible = true;
                    ramTextBox.Visible = true;
                    hddTextBox.Visible = true;
                    licenceLabel.Visible = false;
                    sizeMbLabel.Visible = false;
                    licenceTextBox.Visible = false;
                    sizeMbTextBox.Visible = false;
                    weightLabel.Visible = false;
                    weightTextBox.Visible = false;
                    resolutionLabel.Visible = false;
                    monTypeLabel.Visible = false;
                    resolutionTextBox.Visible = false;
                    monTypeTextBox.Visible = false;
                }
                if (itemComboBox.SelectedItem.ToString() == "Monitor")
                {
                    resolutionLabel.Visible = true;
                    monTypeLabel.Visible = true;
                    resolutionTextBox.Visible = true;
                    monTypeTextBox.Visible = true;
                    noOfCoresLabel.Visible = false;
                    ramLabel.Visible = false;
                    hddLabel.Visible = false;
                    noOfCoresTextBox.Visible = false;
                    ramTextBox.Visible = false;
                    hddTextBox.Visible = false;
                    weightLabel.Visible = false;
                    weightTextBox.Visible = false;
                    licenceLabel.Visible = false;
                    sizeMbLabel.Visible = false;
                    licenceTextBox.Visible = false;
                    sizeMbTextBox.Visible = false;
                }
                if (itemComboBox.SelectedItem.ToString() == "Item")
                {
                    itemIDTextBox.Visible = true;
                    itemNameTextBox.Visible = true;
                    priceTextBox.Visible = true;
                    noOfCoresLabel.Visible = false;
                    ramLabel.Visible = false;
                    hddLabel.Visible = false;
                    noOfCoresTextBox.Visible = false;
                    ramTextBox.Visible = false;
                    hddTextBox.Visible = false;
                    weightLabel.Visible = false;
                    weightTextBox.Visible = false;
                    licenceLabel.Visible = false;
                    sizeMbLabel.Visible = false;
                    licenceTextBox.Visible = false;
                    sizeMbTextBox.Visible = false;
                    resolutionLabel.Visible = false;
                    monTypeLabel.Visible = false;
                    resolutionTextBox.Visible = false;
                    monTypeTextBox.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Try again");
                itemIDTextBox.Visible = true;
                itemNameTextBox.Visible = true;
                priceTextBox.Visible = true;
            }
        }

        private void noOfCoresLabel_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deleteListButton_Click(object sender, EventArgs e)
        {
            try
            {
                splits = listBox1.SelectedItem.ToString().Split(' ');
                serNum = Convert.ToInt32(splits[0]);
                ItemsDatabase delete = new ItemsDatabase();
                delete.deleteItem(serNum);
                MessageBox.Show("Deleted");
                lista();
            }
            catch
            {
                MessageBox.Show("Try again!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            splits = listBox1.SelectedItem.ToString().Split(' ');
            serNum = Convert.ToInt32(splits[0]);
            itemIDTextBox.Text = splits[0];
            itemNameTextBox.Text = "";
            priceTextBox.Text = "";
            licenceTextBox.Text = "";
            sizeMbTextBox.Text = "";
            weightTextBox.Text = "";
            noOfCoresTextBox.Text = "";
            ramTextBox.Text = "";
            monTypeTextBox.Text = "";
            resolutionTextBox.Text = "";
            hddTextBox.Text = "";
        }
    }
}
