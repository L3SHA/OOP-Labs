using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOP_Lab_3
{
    public enum openType
    {
        view,
        edit
    }
    public partial class fMain : Form
    {
        Action action;
        Dictionary<Type, Func<openType, string, Form>> fEditOrViewConstructor;
        Dictionary<string, Func<Form>> fAddConstructor;
        ListItemStorage listItemStorage;

        public fMain()
        {
            InitializeComponent();
            InitializeData();
            action = UpdateItemList;
            listItemStorage = ListItemStorage.GetInstance();
            listItemStorage.SubscribeUIUpdate(action);
        }

        private void InitializeData()
        {
            fEditOrViewConstructor = new Dictionary<Type, Func<openType, string, Form>>();
            fEditOrViewConstructor.Add(typeof(Processor), (openType type, string name) => { return new ProcessorEditor(type, name); });
            fEditOrViewConstructor.Add(typeof(Motherboard), (openType type, string name) => { return new MotherboardEditor(type, name); });
            fEditOrViewConstructor.Add(typeof(RAM), (openType type, string name) => { return new RAMEditor(type, name); });
            fEditOrViewConstructor.Add(typeof(PowerSupply), (openType type, string name) => { return new PowerSupplyEditor(type, name); });
            fEditOrViewConstructor.Add(typeof(HardDrive), (openType type, string name) => { return new HardDriveEditor(type, name); });
            fEditOrViewConstructor.Add(typeof(SystemCase), (openType type, string name) => { return new SystemCaseEditor(type, name); });

            fAddConstructor = new Dictionary<string, Func<Form>>();
            fAddConstructor.Add("Processor", () => { return new ProcessorEditor(); });
            fAddConstructor.Add("Motherboard", () => { return new MotherboardEditor(); });
            fAddConstructor.Add("RAM", () => { return new RAMEditor(); });
            fAddConstructor.Add("PowerSupply", () => { return new PowerSupplyEditor(); });
            fAddConstructor.Add("HardDrive", () => { return new HardDriveEditor(); });
            fAddConstructor.Add("SystemCase", () => { return new SystemCaseEditor(); });

            foreach(string name in fAddConstructor.Keys)
            {
                cbItemTypes.Items.Add(name);
            }
        }

        private void UpdateItemList()
        {
            lbItems.Items.Clear();
            foreach (Item item in ListItemStorage.GetInstance().GetItemList())
            {
                lbItems.Items.Add(item.Name);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(cbItemTypes.SelectedIndex != -1)
            {
                var chosenType = cbItemTypes.SelectedItem.ToString();
                var func = fAddConstructor[chosenType];
                var form = func();
                form.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Please choose type of item you want to add!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }     
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lbItems.SelectedIndex != -1)
            {
                ListItemStorage.GetInstance().DeleteItem(lbItems.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Please, choose item, which you want to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(lbItems.SelectedIndex != -1)
            {
                var obj = listItemStorage.GetItem(lbItems.SelectedItem.ToString());
                var func = fEditOrViewConstructor[obj.GetType()];
                var form = func(openType.edit, listItemStorage.GetItem(lbItems.SelectedItem.ToString()).Name);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please, choose item, which you want to edit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (lbItems.SelectedIndex != -1)
            {
                var obj = listItemStorage.GetItem(lbItems.SelectedItem.ToString());
                var func = fEditOrViewConstructor[obj.GetType()];
                var form = func(openType.view, listItemStorage.GetItem(lbItems.SelectedItem.ToString()).Name);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please, choose item, which you want to view!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            ofdOpenFile.ShowDialog();
            string path = ofdOpenFile.FileName;
            if (path != "")
            {
                FileService fs = new FileService();
                var tempList = JsonObjectSerializer<Dictionary<string, Item>>.getInstance().Deserialize(fs.ReadFromFile(path));
                foreach (string name in tempList.Keys)
                {
                    listItemStorage.AddItem(tempList[name]);
                }
            }
            else
            {
                MessageBox.Show("You haven't chosen work file, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            sfdSaveFile.ShowDialog();
            string path = sfdSaveFile.FileName;
            if(path != "")
            {
                FileService fs = new FileService();
                var tempList = listItemStorage.GetItemList();
                var tempDictionary = new Dictionary<string, Item>();
                foreach (Item item in tempList)
                {
                    tempDictionary.Add(item.Name, item);
                }
                fs.SaveToFile(path, JsonObjectSerializer<Dictionary<string, Item>>.getInstance().Serialize(tempDictionary));
            }
            else 
            {
                MessageBox.Show("You haven't chosen work file, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
