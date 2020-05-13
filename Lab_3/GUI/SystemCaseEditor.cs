using System;
using Storehouse.Model;
using Storehouse.DataRepository;
using System.Windows.Forms;

namespace Storehouse.GUI
{
    public partial class SystemCaseEditor : Form
    {
        public SystemCaseEditor()
        {
            InitializeComponent();
        }

        public SystemCaseEditor(openType type, string name)
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
                    tbFansAmount.ReadOnly = true;
                    tbUSBPorts.ReadOnly = true;
                    btnSave.Visible = false;
                    break;
            }
            LoadData(name);
        }

        private void LoadData(string name)
        {
            var item = (SystemCase)ListItemStorage.GetInstance().GetItem(name);
            tbName.Text = item.Name;
            tbPrice.Text = item.Price.ToString();
            tbCompany.Text = item.CompanyName.ToString();
            tbAmount.Text = item.Amount.ToString();
            tbFansAmount.Text = item.FansAmount.ToString();
            tbUSBPorts.Text = item.USBPortAmount.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var systemCase = new SystemCase(tbName.Text, int.Parse(tbPrice.Text), tbCompany.Text, int.Parse(tbAmount.Text), int.Parse(tbFansAmount.Text), int.Parse(tbUSBPorts.Text));
            IStorage storage = ListItemStorage.GetInstance();
            storage.AddItem(systemCase);
            this.Close();
        }

        private void tb_KeyPress_IsDigit(object sender, KeyPressEventArgs e)
        {
            InputHandlerHelper.KeyPress_IsDigit(sender, e);
        }
    }
}
