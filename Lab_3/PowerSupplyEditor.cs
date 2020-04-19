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
    public partial class PowerSupplyEditor : Form
    {
        public PowerSupplyEditor()
        {
            InitializeComponent();
        }

        public PowerSupplyEditor(openType type, string name)
        {
            InitializeComponent();
        }
    }
}
