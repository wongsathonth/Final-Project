using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Final_project1
{
    public partial class Form1 : Form
    {
        public string name;
        public string color;
        public string price;
        public string size;
        public string connect;
        public string length;
        public string usbType;
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("ขาว");
            comboBox1.Items.Add("ดำ");
            comboBox1.Items.Add("ชมพู");

            comboBox2.Items.Add("full");
            comboBox2.Items.Add("75%layout");
            comboBox2.Items.Add("40%layout");

            comboBox3.Items.Add("ไร้สาย");
            comboBox3.Items.Add("สาย");

            comboBox4.Items.Add("1เมตร");
            comboBox4.Items.Add("2เมตร");
            comboBox4.Items.Add("5เมตร");

            comboBox5.Items.Add("ขาว");
            comboBox5.Items.Add("ดำ");
            comboBox5.Items.Add("แดง");
            comboBox5.Items.Add("ส้ม");
            comboBox5.Items.Add("ฟ้า");

            comboBox6.Items.Add("lightning port");
            comboBox6.Items.Add("type c");
            comboBox6.Items.Add("micrco usb");
           
            

        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.Commercial;
            name = this.label3.Text;
            length = this.comboBox4.SelectedItem.ToString();
            color = this.comboBox5.SelectedItem.ToString();
            usbType = this.comboBox6.SelectedItem.ToString();
            price = "350";
            Cable cable = new Cable(name, length, color, usbType, price);
            var message = $"คุณได้สั่งซื้อ: {cable.getName()} \nสี: {cable.getColor()} \nราคา: {cable.getPrice()}";

            using (var package = new ExcelPackage(new FileInfo(@"C:\Users\ASUS\Documents\Lap5\Final project1\Final project1\bin\Debug\data.xlsx")))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets["Sheet1"];
                if (worksheet == null)
                {
                    throw new Exception("Worksheet does not exist");
                }
                int lastUsedRow = worksheet.Dimension.End.Row;

                ExcelRange cell = worksheet.Cells[lastUsedRow + 1, 1];
                cell.Value = message;

                package.Save();
            }
            this.DialogResult = DialogResult.OK;
            this.Hide();
            MessageBox.Show(message);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.Commercial;
            name = this.label1.Text;
            color=this.comboBox1.SelectedItem.ToString();
            size= this.comboBox2.SelectedItem.ToString();
            price = "1000";
            Keyboard keyboard = new Keyboard(name, color, size, price);
            var message = $"คุณได้สั่งซื้อ: {keyboard.getName()} \nสี: {keyboard.getColor()} \nขนาด: {keyboard.getSize()} \nราคา: {keyboard.getPrice()}";

            using (var package = new ExcelPackage(new FileInfo(@"C:\Users\ASUS\Documents\Lap5\Final project1\Final project1\bin\Debug\data.xlsx")))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets["Sheet1"];
                if (worksheet == null)
                {
                    throw new Exception("Worksheet does not exist");
                }
                int lastUsedRow = worksheet.Dimension.End.Row;

                ExcelRange cell = worksheet.Cells[lastUsedRow + 1, 1];
                cell.Value = message;

                package.Save();
            }
            this.DialogResult = DialogResult.OK;
            this.Hide();
            MessageBox.Show(message);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.Commercial;
            name = this.label2.Text;
            color = null;
            connect= this.comboBox3.SelectedItem.ToString();
            price = "1200";
            Mouse mouse = new Mouse(name, color, connect, price);
            var message = $"คุณได้สั่งซื้อ: {mouse.getName()} \nการเชื่อต่อ:{mouse.getConnect()}\nราคา: {mouse.getPrice()}";
            using (var package = new ExcelPackage(new FileInfo(@"C:\Users\ASUS\Documents\Lap5\Final project1\Final project1\bin\Debug\data.xlsx")))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets["Sheet1"];
                if (worksheet == null)
                {
                    throw new Exception("Worksheet does not exist");
                }
                int lastUsedRow = worksheet.Dimension.End.Row;

                ExcelRange cell = worksheet.Cells[lastUsedRow + 1, 1];
                cell.Value = message;

                package.Save();
            }
            this.DialogResult = DialogResult.OK;
            this.Hide();
            MessageBox.Show(message);
        }
    }
}
