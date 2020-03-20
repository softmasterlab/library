using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class ManagersForm : Form
    {
        Database1Entities db = new Database1Entities();

        public ManagersForm()
        {
            InitializeComponent();
        }

        private void LoadManagers()
        {
            managersList.Items.Clear();
            foreach (Managers m in db.Managers)
            {
                var item = managersList.Items.Add(m.Id.ToString());
                item.SubItems.Add(m.Name);
                item.SubItems.Add(m.Contact);
            }
        }

        private void ManagersForm_Load(object sender, EventArgs e)
        {
            LoadManagers();
        }

        private void managersList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addManager_Click(object sender, EventArgs e)
        {
            if (nameBox.Text == "" || contactsBox.Text == "")
            {
                MessageBox.Show("Вы не заполнили полей данных!");
            }
            else
            {
                db.Managers.Add(new Managers()
                {
                    Name = nameBox.Text,
                    Contact = contactsBox.Text
                });
                db.SaveChanges();
                LoadManagers();
            }
        }

        private void saveManager_Click(object sender, EventArgs e)
        {

        }

        private void delManager_Click(object sender, EventArgs e)
        {

        }
    }
}
