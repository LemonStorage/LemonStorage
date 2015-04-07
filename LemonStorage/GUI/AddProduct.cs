using LemonStorage.Classes.Computers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LemonStorage.Enumerations;
using LemonStorage.Classes.Mobiles;

namespace LemonStorage.GUI
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            string[] Articuls = { Products.Computer.ToString(), Products.Mobile.ToString(), Products.Peripheral.ToString() + " " + Products.Device.ToString(), Products.Accessory.ToString() };
            comboBox1.DataSource = Articuls;
            comboBox1.SelectedIndex = -1;
            UnvisibleFields();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)comboBox1.SelectedItem == "Computer")
            {
                string[] Articuls2 = { "Laptop", "Desktop Computer" };
                comboBox2.DataSource = Articuls2;
                comboBox2.SelectedIndex = 0;
            }
            if ((string)comboBox1.SelectedItem == "Mobile")
            {
                string[] Articuls2 = { "Mobile Phone", "Smart Phone", "Tablet" };
                comboBox2.DataSource = Articuls2;
                comboBox2.SelectedIndex = 0;
            }
            if ((string)comboBox1.SelectedItem == "Accessory")
            {
                string[] Articuls2 = { "Charger", "Handsfree", "Laptop Bag", "Memory Card", "Phone Case", "Tablet Case" };
                comboBox2.DataSource = Articuls2;
                comboBox2.SelectedIndex = 0;
            }
            if ((string)comboBox1.SelectedItem == "Peripheral Device")
            {
                string[] Articuls2 = { "Monitor", "Printer", "Scener" };
                comboBox2.DataSource = Articuls2;
                comboBox2.SelectedIndex = 0;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)comboBox2.SelectedItem == "Laptop")
            {
                UnvisibleFields();
                VisibleFields();
                Processor.Visible = true; Processorlabel.Visible = true;
                RAM.Visible = true; RAMlabel.Visible = true;
                HDD.Visible = true; HDDlabel.Visible = true;
                VideoCard.Visible = true; Videocardlabel.Visible = true;
                SoundCard.Visible = true; Soundlabel.Visible = true;
                BatteryDuration.Visible = true; Batterylabel.Visible = true;
                Weight.Visible = true; Weightlabel.Visible = true;
                Size.Visible = true; Sizelabel.Visible = true;
                Core.Visible = true; Corelabel.Visible = true;
                label13.Visible = true;
                button1.Visible = true;
            }
            if ((string)comboBox2.SelectedItem == "Desktop Computer")
            {
                UnvisibleFields();
                VisibleFields();
                Processor.Visible = true; Processorlabel.Visible = true;
                RAM.Visible = true; HDDlabel.Visible = true;
                HDD.Visible = true; RAMlabel.Visible = true;
                VideoCard.Visible = true; Soundlabel.Visible = true;
                SoundCard.Visible = true; Videocardlabel.Visible = true;
                Core.Visible = true; Corelabel.Visible = true;
                label13.Visible = true;
                button1.Visible = true;
            }
            if ((string)comboBox2.SelectedItem == "Mobile Phone" || (string)comboBox2.SelectedItem == "Smart Phone" || (string)comboBox2.SelectedItem == "Tablet")
            {
                UnvisibleFields();
                VisibleFields();
                Processor.Visible = true; Processorlabel.Visible = true;
                RAM.Visible = true; RAMlabel.Visible = true;
                Rom.Visible = true; ROMlabel.Visible = true;
                Display.Visible = true; Displaylabel.Visible = true;
                Camera.Visible = true; Cameralabel.Visible = true;
                label13.Visible = true;
                button1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Do you want to save this product?", "Exit", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                if ((string)comboBox2.SelectedItem == "Laptop")
                {
                    Laptop laptop = new Laptop(decimal.Parse(Price.Text), Brand.Text, Model.Text, Color.Text, Processor.Text,
                   uint.Parse(RAM.Text), uint.Parse(HDD.Text), VideoCard.Text, SoundCard.Text, int.Parse(BatteryDuration.Text)
                   , double.Parse(Weight.Text), int.Parse(Size.Text), byte.Parse(Core.Text));
                    laptop.SaveToSQL();
                    FieldsClear();
                    this.Close();
                }
                if ((string)comboBox2.SelectedItem == "Desktop Computer")
                {
                    DesktopPC pc = new DesktopPC(decimal.Parse(Price.Text), Brand.Text, Model.Text, Color.Text, Processor.Text,
                        uint.Parse(RAM.Text), uint.Parse(HDD.Text), VideoCard.Text, SoundCard.Text, byte.Parse(Core.Text));
                    pc.SaveToSQL();
                    FieldsClear();
                    this.Close();
                }
                if ((string)comboBox2.SelectedItem == "Mobile Phone")
                {
                    Mobile mobile = new MobilePhone(decimal.Parse(Price.Text), Brand.Text, Model.Text, Color.Text, Processor.Text, double.Parse(Display.Text),
                        double.Parse(Camera.Text), uint.Parse(RAM.Text), uint.Parse(Rom.Text));
                   var mb = (MobilePhone)mobile;
                    mb.SaveToSQL();
                    FieldsClear();
                    this.Close();
                }
                if ((string)comboBox2.SelectedItem == "Smart Phone")
                {
                    Mobile smart = new SmartPhone(decimal.Parse(Price.Text), Brand.Text, Model.Text, Color.Text, Processor.Text, double.Parse(Display.Text),
                        double.Parse(Camera.Text), uint.Parse(RAM.Text), uint.Parse(Rom.Text));
                    var sm = (SmartPhone)smart;
                    sm.SaveToSQL();
                    FieldsClear();
                    this.Close();
                }
                if ((string)comboBox2.SelectedItem == "Tablet")
                {
                    Mobile tablet = new Tablet(decimal.Parse(Price.Text), Brand.Text, Model.Text, Color.Text, Processor.Text, double.Parse(Display.Text),
                        double.Parse(Camera.Text), uint.Parse(RAM.Text), uint.Parse(Rom.Text));
                    Tablet tb = tablet as Tablet;
                    tb.SaveToSQL();
                    FieldsClear();
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }


        private void VisibleFields()
        {
            Price.Visible = true; Pricelabel.Visible = true;
            Brand.Visible = true; Brandlabel.Visible = true;
            Model.Visible = true; Modellabel.Visible = true;
            Color.Visible = true; Colorlabel.Visible = true;
        }
        private void UnvisibleFields()
        {
            Rom.Visible = false; ROMlabel.Visible = false;
            Display.Visible = false; Displaylabel.Visible = false;
            Camera.Visible = false; Cameralabel.Visible = false;
            Price.Visible = false; Brandlabel.Visible = false;
            Brand.Visible = false; Modellabel.Visible = false;
            Model.Visible = false; Pricelabel.Visible = false;
            Color.Visible = false; Colorlabel.Visible = false;
            Processor.Visible = false; Processorlabel.Visible = false;
            RAM.Visible = false; HDDlabel.Visible = false;
            HDD.Visible = false; Batterylabel.Visible = false;
            VideoCard.Visible = false; Soundlabel.Visible = false;
            SoundCard.Visible = false; Sizelabel.Visible = false;
            BatteryDuration.Visible = false; RAMlabel.Visible = false;
            Weight.Visible = false; Videocardlabel.Visible = false;
            Size.Visible = false; Corelabel.Visible = false;
            Core.Visible = false; Weightlabel.Visible = false;
            label13.Visible = false;
            button1.Visible = false;
        }
        private void FieldsClear()
        {
            Rom.Clear(); Display.Clear(); Camera.Clear();
            Price.Clear(); Brand.Clear(); Model.Clear(); Color.Clear(); Processor.Clear();
            RAM.Clear(); HDD.Clear(); VideoCard.Clear(); SoundCard.Clear(); BatteryDuration.Clear();
            Weight.Clear(); Size.Clear(); Core.Clear();
        }

        private void Videocardlabel_Click(object sender, EventArgs e)
        {

        }

        private void Soundlabel_Click(object sender, EventArgs e)
        {

        }
    }
}
