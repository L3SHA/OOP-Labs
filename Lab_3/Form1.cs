using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var productList = new List<Product>();
            var processor = new Processor("Intel Core I5", 150, "Intel", 6, 4.5, 7, 4, 65);
            productList.Add(processor);
            var serializeService = new SerializeJSonService();
            serializeService.Serialize(productList.Last(), @"C:\Fourth semester\test.txt");
            serializeService.Deserialize(@"C:\Fourth semester\test.txt");
            //Product proc = (Product) objList.Last();
            //Console.WriteLine(proc.Price);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
