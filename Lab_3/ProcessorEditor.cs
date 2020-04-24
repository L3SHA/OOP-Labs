using System;
using System.Windows.Forms;

namespace OOP_Lab_3
{
    public partial class ProcessorEditor : Form
    {
        public ProcessorEditor()
        {
            InitializeComponent();
        }

        public ProcessorEditor(openType type, string name)
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
                    tbCoresNum.ReadOnly = true;
                    tbFrequency.ReadOnly = true;
                    tbProcessTechnology.ReadOnly = true;
                    tbCacheSize.ReadOnly = true;
                    tbThermalDesignPower.ReadOnly = true;
                    btnSave.Visible = false;
                    break;
            }
            LoadData(name);
        }

        private void LoadData(string name)
        {
            var item = (Processor)ListItemStorage.GetInstance().GetItem(name);
            tbName.Text = item.Name;
            tbPrice.Text = item.Price.ToString();
            tbCompany.Text = item.Amount.ToString();
            tbAmount.Text = item.Amount.ToString();
            tbCoresNum.Text = item.CoresNum.ToString();
            tbFrequency.Text = item.Frequency.ToString();
            tbProcessTechnology.Text = item.ProcessTechnology.ToString();
            tbCacheSize.Text = item.CacheSize.ToString();
            tbThermalDesignPower.Text = item.ThermalDesignPower.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var processor = new Processor(tbName.Text, int.Parse(tbPrice.Text), tbCompany.Text,  int.Parse(tbAmount.Text), int.Parse(tbCoresNum.Text), double.Parse(tbFrequency.Text), int.Parse(tbProcessTechnology.Text), int.Parse(tbCacheSize.Text), int.Parse(tbThermalDesignPower.Text));
            IStorage storage = ListItemStorage.GetInstance();
            storage.AddItem(processor);
            this.Close();
        }

        private void tb_KeyPress_IsDigit(object sender, KeyPressEventArgs e)
        {
            InputHandlerHelper.KeyPress_IsDigit(sender, e);
        }
        
    }
}
