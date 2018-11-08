using Newtonsoft.Json;
using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace New_year_gifts
{
    public partial class NewYearsGift : Form
    {
        List<Sweets> CandysInGift = new List<Sweets>();
        List<Sweets> Candys = new List<Sweets>();
        private static Logger log = LogManager.GetCurrentClassLogger();
        public int CountWeight()
        {
            int weight = 0;
            foreach (DataGridViewRow row in dataGridViewGift.Rows)
            {
               weight = Convert.ToInt32(row.Cells[1].Value) + weight;
            }
            labelGram.Text = Convert.ToString(weight) + "g";
            
            return weight;
        }
        public NewYearsGift()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewLoad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLoad.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridViewGift.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewGift.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {

        }

        private void buttonSaveXML_Click(object sender, EventArgs e)
        {
            //XmlDocument xmlSweets = new XmlDocument();
            //xmlSweets.Load("sweets.xml");

        }
       private void buttonLoad_Click(object sender, EventArgs e)
        {
            dataGridViewLoad.Rows.Clear();
            List<string> Manufacturer = new List<string>();
            List<string> Category = new List<string>();
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;
            if (settings.AllKeys.FirstOrDefault() == "XML")
            {
                List<Sweets> Candys = new List<Sweets>();
                XmlDocument xmlSweets = new XmlDocument();
                xmlSweets.Load("sweets.xml");
                XmlElement Xroot = xmlSweets.DocumentElement;

                foreach (XmlNode childNode in Xroot)
                {
                    if (childNode.Name == "Chocolate")
                    {

                        foreach (XmlNode childNodeChoc in childNode.ChildNodes)
                        {
                            ChocolateSweets chocolate = new ChocolateSweets();
                            XmlNode attribute = childNodeChoc.Attributes.GetNamedItem("name");
                            if (attribute != null)
                            {
                                chocolate.SweetName = attribute.Value;
                                chocolate.Category = "Шоколадные";
                                if (!Category.Contains(chocolate.Category))
                                {
                                    Category.Add(chocolate.Category);
                                }
                            }
                            foreach (XmlNode childChoc in childNodeChoc.ChildNodes)
                            {
                                if (childChoc.Name == "weight")
                                {
                                    chocolate.Weight = Int32.Parse(childChoc.InnerText);
                                }
                                if (childChoc.Name == "manufacturer")
                                {
                                    chocolate.Manufacturer = childChoc.InnerText;
                                }
                                if (childChoc.Name == "stuff")
                                {
                                    chocolate.Stuff = childChoc.InnerText;
                                }
                                if (childChoc.Name == "type")
                                {
                                    chocolate.Type = childChoc.InnerText;
                                }
                            }
                            Candys.Add(chocolate);
                            if (!Manufacturer.Contains(chocolate.Manufacturer))
                            {
                                Manufacturer.Add(chocolate.Manufacturer);
                            }
                            
                        }

                    }
                    if (childNode.Name == "Lollipop")
                    {

                        foreach (XmlNode childNodelollipop in childNode.ChildNodes)
                        {
                            Lollipop caramel = new Lollipop();
                            XmlNode attribute = childNodelollipop.Attributes.GetNamedItem("name");
                            if (attribute != null)
                            {
                                caramel.SweetName = attribute.Value;
                                caramel.Category = "Леденцы";
                                if (!Category.Contains(caramel.Category))
                                {
                                    Category.Add(caramel.Category);
                                }
                            }
                            foreach (XmlNode childLollipop in childNodelollipop.ChildNodes)
                            {
                                if (childLollipop.Name == "weight")
                                {
                                    caramel.Weight = Int32.Parse(childLollipop.InnerText);
                                }
                                if (childLollipop.Name == "manufacturer")
                                {
                                    caramel.Manufacturer = childLollipop.InnerText;
                                }
                                if (childLollipop.Name == "type")
                                {
                                    caramel.Type = childLollipop.InnerText;
                                }
                                if (childLollipop.Name == "kind")
                                {
                                    caramel.Kind = childLollipop.InnerText;
                                }


                            }
                            Candys.Add(caramel);
                            if (!Manufacturer.Contains(caramel.Manufacturer))
                            {
                                Manufacturer.Add(caramel.Manufacturer);
                            }
                        }

                    }
                }
                //int count = 0;
                foreach (Sweets item in Candys)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridViewLoad.Rows[0].Clone();
                    //if (item.Category == "Шоколадные" && count==0)
                    //{
                    //     row.Cells[0].Value = item.Category;
                    //     dataGridViewLoad.Rows.Add(row);
                    //     count++;
                    //}
                    row.Cells[0].Value = item.SweetName;
                    row.Cells[1].Value = item.Weight;
                    row.Cells[2].Value = item.Manufacturer;
                    row.Cells[3].Value = item.Category;
                    dataGridViewLoad.Rows.Add(row);
                    //if (item.Category == "Леденцы" && count > 0)
                    //{

                    //    row.Cells[0].Value = item.Category;
                    //    dataGridViewLoad.Rows.Add(row);
                    //    count++;
                    //}

                }
                log.Debug("{0}: Items from xml were added succsessfully ", this.Text);               
            }
            else if (settings.AllKeys.FirstOrDefault() == "JSON")
            {
                var encoding = Encoding.GetEncoding(1251);
                Root chocolate = new Root();
                using (StreamReader r = new StreamReader("sweets.json",encoding))
                {
                    string json = r.ReadToEnd();
                    chocolate = JsonConvert.DeserializeObject<Root>(json);
                    
                }
                if (chocolate.Chocolate.Count != 0)
                {
                    
                    foreach (var item in chocolate.Chocolate)
                    {
                        DataGridViewRow row = (DataGridViewRow)dataGridViewLoad.Rows[0].Clone();
                        row.Cells[0].Value = item.SweetName;
                        row.Cells[1].Value = item.Weight;
                        row.Cells[2].Value = item.Manufacturer;
                        row.Cells[3].Value = item.Category;
                        dataGridViewLoad.Rows.Add(row);
                        if (!Manufacturer.Contains(item.Manufacturer))
                        {
                            Manufacturer.Add(item.Manufacturer);
                        }
                        if (!Category.Contains(item.Category))
                        {
                            Category.Add(item.Category);
                        }
                    }
                }
                if (chocolate.Lollipop.Count != 0)
                {
                    foreach (var item in chocolate.Lollipop)
                    {
                        DataGridViewRow row = (DataGridViewRow)dataGridViewLoad.Rows[0].Clone();
                        row.Cells[0].Value = item.SweetName;
                        row.Cells[1].Value = item.Weight;
                        row.Cells[2].Value = item.Manufacturer;
                        row.Cells[3].Value = item.Category;
                        dataGridViewLoad.Rows.Add(row);
                        if (!Manufacturer.Contains(item.Manufacturer))
                        {
                            Manufacturer.Add(item.Manufacturer);
                        }
                        if (!Category.Contains(item.Category))
                        {
                            Category.Add(item.Category);
                        }
                    }
                }
                log.Debug("{0}: Items from xml succsessfully were added", this.Text);
            }
            else
            {
                string message = "Настройки не выбраны";
                DialogResult result;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                result = MessageBox.Show(message,"",buttons);
                if(result==System.Windows.Forms.DialogResult.OK)
                {
                    this.Close();
                }
            }
            try
            {
                foreach (string item in Manufacturer)
                {
                    comboBoxManufacturer.Items.Add(item);

                    log.Debug("{0}: Manufacturers were loaded succsessfully ", this.Text);
                }
                foreach (string item in Category)
                {
                    comboBoxType.Items.Add(item);

                    log.Debug("{0}: Types were loaded succsessfully ", this.Text);
                }
            }
            catch
            {
                log.Debug("{0}: Items MANUFACTORS or TYPES were NOT loaded succsessfully ", this.Text);
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            dataGridViewGift.Rows.Clear();
            var allindex = dataGridViewLoad.SelectedRows.Cast<DataGridViewRow>().Select(index => index.Index).ToList();
            //List<Sweets> Candys = new List<Sweets>();
            foreach (int item in allindex)
            {
               foreach (DataGridViewRow row in dataGridViewLoad.Rows)
                {
                
                   if(row.Index==item)
                    {
                        if (row.Cells[3].Value != null)
                        {
                            if (row.Cells[3].Value.ToString() == "Шоколадные")
                            {
                                ChocolateSweets chocolate = new ChocolateSweets();
                                chocolate.SweetName = row.Cells[0].Value.ToString();
                                chocolate.Weight = Convert.ToInt32(row.Cells[1].Value);
                                chocolate.Manufacturer = row.Cells[2].Value.ToString();
                                chocolate.Category = row.Cells[3].Value.ToString();
                                CandysInGift.Add(chocolate);
                            }
                            if (row.Cells[3].Value.ToString() == "Леденцы")
                            {
                                Lollipop caramel = new Lollipop();
                                caramel.SweetName = row.Cells[0].Value.ToString();
                                caramel.Weight = Convert.ToInt32(row.Cells[1].Value);
                                caramel.Manufacturer = row.Cells[2].Value.ToString();
                                caramel.Category = row.Cells[3].Value.ToString();
                                CandysInGift.Add(caramel);
                            }
                        }
                    }
                }
            }
            int weight = 0;
            foreach (Sweets item in CandysInGift)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridViewGift.Rows[0].Clone();
                row.Cells[0].Value = item.SweetName;
                row.Cells[1].Value = item.Weight;
                row.Cells[2].Value = item.Manufacturer;
                row.Cells[3].Value = item.Category;
                dataGridViewGift.Rows.Add(row);
                //weight = weight + item.Weight;
            }

            this.TabforSweets.SelectTab("GatherGift");
            CountWeight();
            //foreach (DataGridViewRow row in dataGridViewGift.Rows)
            //{
            //    weight = Convert.ToInt32(row.Cells[1].Value) + weight;
            //}
            //labelGram.Text = Convert.ToString(weight) + "g";

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dataGridViewGift.Rows.Clear();
            buttonSort.Enabled = false;
            string Manufacturer = comboBoxManufacturer.Text;
            string Type = comboBoxType.Text;
            int _fromWeight = 0;
            int _toWeight = 0;
            try
            {
                _fromWeight = Convert.ToInt32(textBoxWeightFrom.Text);
            }
            catch
            {
                _fromWeight = 0;
            }
            try
            {
                _toWeight = Convert.ToInt32(textBoxWeightTo.Text);
            }
            catch
            {
                _toWeight = 0;
            }
  
            foreach(Sweets item in CandysInGift)
            {
                if(item.Category==Type && item.Manufacturer==Manufacturer && item.Weight>=_fromWeight
                    && item.Weight <= _toWeight)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridViewGift.Rows[0].Clone();
                    row.Cells[0].Value = item.SweetName;
                    row.Cells[1].Value = item.Weight;
                    row.Cells[2].Value = item.Manufacturer;
                    row.Cells[3].Value = item.Category;
                    dataGridViewGift.Rows.Add(row);
                }
            }
            if (dataGridViewGift.Rows.Count > 0 &&  dataGridViewGift.Rows[0].Cells[3].Value != null)

            {
                CountWeight();
            }
            else
            {
                string message = "No matches. Try again.";
                DialogResult result;
                //MessageBoxButtons buttons = MessageBoxButtons.OK;
                result = MessageBox.Show(message, "");
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            CandysInGift.Clear();
            foreach (DataGridViewRow row in dataGridViewGift.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    if (row.Cells[3].Value.ToString() == "Шоколадные")
                    {
                        ChocolateSweets chocolate = new ChocolateSweets();
                        chocolate.SweetName = row.Cells[0].Value.ToString();
                        chocolate.Weight = Convert.ToInt32(row.Cells[1].Value);
                        chocolate.Manufacturer = row.Cells[2].Value.ToString();
                        chocolate.Category = row.Cells[3].Value.ToString();
                        CandysInGift.Add(chocolate);
                    }
                    if (row.Cells[3].Value.ToString() == "Леденцы" && row.Cells[3].Value != null)
                    {
                        Lollipop caramel = new Lollipop();
                        caramel.SweetName = row.Cells[0].Value.ToString();
                        caramel.Weight = Convert.ToInt32(row.Cells[1].Value);
                        caramel.Manufacturer = row.Cells[2].Value.ToString();
                        caramel.Category = row.Cells[3].Value.ToString();
                        CandysInGift.Add(caramel);
                    }
                }
            }
            if(radioButtonManufacturer.Checked)
            {
                List<Sweets> SortCandys = CandysInGift.OrderBy(sweet => sweet.Manufacturer).ToList();
                dataGridViewGift.Rows.Clear();
                foreach (Sweets item in SortCandys)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridViewGift.Rows[0].Clone();
                    row.Cells[0].Value = item.SweetName;
                    row.Cells[1].Value = item.Weight;
                    row.Cells[2].Value = item.Manufacturer;
                    row.Cells[3].Value = item.Category;
                    dataGridViewGift.Rows.Add(row);
                }
            }
            if (radioButtonType.Checked)
            {
                List<Sweets> SortCandys = CandysInGift.OrderBy(sweet => sweet.Category).ToList();
                dataGridViewGift.Rows.Clear();
                foreach (Sweets item in SortCandys)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridViewGift.Rows[0].Clone();
                    row.Cells[0].Value = item.SweetName;
                    row.Cells[1].Value = item.Weight;
                    row.Cells[2].Value = item.Manufacturer;
                    row.Cells[3].Value = item.Category;
                    dataGridViewGift.Rows.Add(row);
                }
            }
            if (radioButtonWeight.Checked)
            {
                List<Sweets> SortCandys = CandysInGift.OrderByDescending(sweet => sweet.Weight).ToList();
                dataGridViewGift.Rows.Clear();
                foreach (Sweets item in SortCandys)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridViewGift.Rows[0].Clone();
                    row.Cells[0].Value = item.SweetName;
                    row.Cells[1].Value = item.Weight;
                    row.Cells[2].Value = item.Manufacturer;
                    row.Cells[3].Value = item.Category;
                    dataGridViewGift.Rows.Add(row);
                }
            }

        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            //chocolate
            ICollection<ChocolateSweets> chocRoot = new List<ChocolateSweets>();
            ICollection<Lollipop> caramelRoot = new List<Lollipop>();
            foreach (DataGridViewRow row in dataGridViewGift.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    if (row.Cells[3].Value.ToString() == "Шоколадные")
                    {
                        ChocolateSweets choc = new ChocolateSweets();
                        choc.SweetName = row.Cells[0].Value.ToString();
                        choc.Weight = Convert.ToInt32(row.Cells[1].Value);
                        choc.Manufacturer = row.Cells[2].Value.ToString();
                        choc.Category = row.Cells[3].Value.ToString();
                        chocRoot.Add(choc);
                    }
                    if (row.Cells[3].Value.ToString() == "Леденцы")
                    {
                        Lollipop caramel = new Lollipop();
                        caramel.SweetName = row.Cells[0].Value.ToString();
                        caramel.Weight = Convert.ToInt32(row.Cells[1].Value);
                        caramel.Manufacturer = row.Cells[2].Value.ToString();
                        caramel.Category = row.Cells[3].Value.ToString();
                        caramelRoot.Add(caramel);
                    }

                }
            }
                    //foreach (Sweets item in CandysInGift)
                    //{
                    //    if (item.Category == "Шоколадные")
                    //    {
                    //        ChocolateSweets choc = new ChocolateSweets();
                    //        choc.SweetName = item.SweetName;
                    //        choc.Manufacturer = item.Manufacturer;
                    //        choc.Weight = item.Weight;
                    //        choc.Category = item.Category;
                    //        choc.Stuff = "";
                    //        choc.Type = "";
                    //        chocRoot.Add(choc);
                    //    }
                    //    if (item.Category == "Леденцы")
                    //    {
                    //        Lollipop caramel = new Lollipop();
                    //        caramel.SweetName = item.SweetName;
                    //        caramel.Manufacturer = item.Manufacturer;
                    //        caramel.Weight = item.Weight;
                    //        caramel.Category = item.Category;
                    //        caramel.Kind = "";
                    //        caramel.Type = "";
                    //        caramelRoot.Add(caramel);
                    //    }
                    //}
            Root chocolate = new Root();
            //chocolate.Chocolate.ToList();

            chocolate.Chocolate = chocRoot;
                chocolate.Lollipop = caramelRoot;
            //DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Root));
            var encoding = Encoding.GetEncoding(1251);
            string path = ("UserChoice" + DateTime.Now.ToString("dd_MMMM_yyyy_HH_mm_ss") +
                ".json").Trim();
            using (StreamWriter writer = new StreamWriter(path,true,encoding))
            {
                string s = JsonConvert.SerializeObject(chocolate);
                writer.Write(s);
                writer.Close();
            }
            //using (FileStream fs = new FileStream("UserChoice.json", FileMode.CreateNew))
            //{
                
            //    fs.Write();
            //}



        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            buttonSort.Enabled = true;
            dataGridViewGift.Rows.Clear();
            foreach(Sweets item in CandysInGift)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridViewGift.Rows[0].Clone();
                row.Cells[0].Value = item.SweetName;
                row.Cells[1].Value = item.Weight;
                row.Cells[2].Value = item.Manufacturer;
                row.Cells[3].Value = item.Category;
                dataGridViewGift.Rows.Add(row);
                CountWeight();
            }
        }
    }
}
