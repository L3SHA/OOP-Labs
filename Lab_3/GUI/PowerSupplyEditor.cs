using System;
using Storehouse.Model;
using Storehouse.DataRepository;
using System.Windows.Forms;

namespace Storehouse.GUI
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
                    tbEfficiency.ReadOnly = true;
                    tbPower.ReadOnly = true;
                    btnSave.Visible = false;
                    break;
            }
            LoadData(name);
        }

        private void LoadData(string name)
        {
            var item = (PowerSupply)ListItemStorage.GetInstance().GetItem(name);
            tbName.Text = item.Name;
            tbPrice.Text = item.Price.ToString();
            tbCompany.Text = item.Amount.ToString();
            tbAmount.Text = item.Amount.ToString();
            tbEfficiency.Text = item.Efficiency.ToString();
            tbPower.Text = item.Power.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var powerSupply = new PowerSupply(tbName.Text, int.Parse(tbPrice.Text), tbCompany.Text, int.Parse(tbAmount.Text), int.Parse(tbEfficiency.Text), int.Parse(tbPower.Text));
            IStorage storage = ListItemStorage.GetInstance();
            storage.AddItem(powerSupply);
            this.Close();
        }

        private void tb_KeyPress_IsDigit(object sender, KeyPressEventArgs e)
        {
            InputHandlerHelper.KeyPress_IsDigit(sender, e);
        }
    }
}
