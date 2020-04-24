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
    public partial class HardDriveEditor : Form
    {
        public HardDriveEditor()
        {
            InitializeComponent();
        }

        public HardDriveEditor(openType type, string name)
        {
            InitializeComponent();
            switch (type)
            {
                case openType.edit:
                    tbName.ReadOnly = true;
                    break;
                case openType.view:
                    tbName.ReadOnly = true;
                    tbPrice.ReadOnly = true;
                    tbCompany.ReadOnly = true;
                    tbAmount.ReadOnly = true;
                    tbCapacity.ReadOnly = true;
                    tbRotateSpeed.ReadOnly = true;
                    tbConnectionInterface.ReadOnly = true;
                    btnSave.Visible = false;
                    break;
            }
            LoadData(name);
        }

        private void LoadData(string name)
        {
            var item = (HardDrive)ListItemStorage.GetInstance().GetItem(name);
            tbName.Text = item.Name;
            tbPrice.Text = item.Price.ToString();
            tbCompany.Text = item.Amount.ToString();
            tbAmount.Text = item.Amount.ToString();
            tbCapacity.Text = item.Capacity.ToString();
            tbRotateSpeed.Text = item.RotateSpeed.ToString();
            tbConnectionInterface.Text = item.ConnectionInterface.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var hardDrive = new HardDrive(tbName.Text, int.Parse(tbPrice.Text), tbCompany.Text, int.Parse(tbAmount.Text), int.Parse(tbCapacity.Text), int.Parse(tbRotateSpeed.Text), tbConnectionInterface.Text);
            IStorage storage = ListItemStorage.GetInstance();
            storage.AddItem(hardDrive);
            this.Close();
        }

        private void tb_KeyPress_IsDigit(object sender, KeyPressEventArgs e)
        {
            InputHandlerHelper.KeyPress_IsDigit(sender, e);
        }
    }
}
