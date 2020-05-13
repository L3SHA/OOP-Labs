using System;
using Storehouse.Model;
using Storehouse.DataRepository;
using System.Windows.Forms;

namespace Storehouse.GUI
{
    public partial class MotherboardEditor : Form
    {
        public MotherboardEditor()
        {
            InitializeComponent();
        }

        public MotherboardEditor(openType type, string name)
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
                    tbCompanyName.ReadOnly = true;
                    tbAmount.ReadOnly = true;
                    tbCPUSupport.ReadOnly = true;
                    tbSocket.ReadOnly = true;
                    tbFormFactor.ReadOnly = true;
                    btnSave.Visible = false;
                    break;
            }
            LoadData(name);
        }
        private void LoadData(string name)
        {
            var item = (Motherboard)ListItemStorage.GetInstance().GetItem(name);
            tbName.Text = item.Name;
            tbPrice.Text = item.Price.ToString();
            tbCompanyName.Text = item.Amount.ToString();
            tbAmount.Text = item.Amount.ToString();
            tbCPUSupport.Text = item.CPUSupport.ToString();
            tbSocket.Text = item.Socket.ToString();
            tbFormFactor.Text = item.FormFactor.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var motherboard = new Motherboard(tbName.Text, int.Parse(tbPrice.Text), tbCompanyName.Text, int.Parse(tbAmount.Text), tbCPUSupport.Text, tbSocket.Text, tbFormFactor.Text);
            IStorage storage = ListItemStorage.GetInstance();
            storage.AddItem(motherboard);
            this.Close();
        }

        private void tbAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandlerHelper.KeyPress_IsDigit(sender, e);
        }
    }
}
