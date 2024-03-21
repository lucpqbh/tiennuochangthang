using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ManagerApp
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            listViewWaterBill.View = View.Details;
            listViewWaterBill.GridLines = true;
            listViewWaterBill.FullRowSelect = true;
            // tao cac cot hien thi
            listViewWaterBill.Columns.Add("Customer", 120);
            listViewWaterBill.Columns.Add("Type", 80);
            listViewWaterBill.Columns.Add("People", 30);
            listViewWaterBill.Columns.Add("Water last month", 120);
            listViewWaterBill.Columns.Add("Water current month", 120);
            listViewWaterBill.Columns.Add("Water used", 50);
            listViewWaterBill.Columns.Add("money", 50);
            listViewWaterBill.Columns.Add("Total Money", 80);
            listViewWaterBill.Columns.Add("Created At", 100);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string customer = txtCustomer.Text.Trim();
            string typeCustomer = cboCustomerType.Text.Trim();
            //string numberPeople = txtPeople.Text.Trim();
            string lastWater = txtWaterLastMonth.Text.Trim();
            string currentWater = txtWaterCurrentMonth.Text.Trim();
            double usingWaterOtherCustomer = Convert.ToDouble(currentWater) - Convert.ToDouble(lastWater);

            int countMember = 0;
            double money = 0;
            if (string.IsNullOrEmpty(customer))
            {
                MessageBox.Show("Customer is not empty");
                return;
            }
            if (string.IsNullOrEmpty(typeCustomer))
            {
                MessageBox.Show("typeCustomer is not empty");
                return;
            }
            if (typeCustomer == "Household")
            {
                // da chon loai khac hang la ho gia dinh
                string member = txtPeople.Text.Trim();

                if (!int.TryParse(member, out countMember))
                {
                    MessageBox.Show("People id numeber ");
                    return;

                }
                double usingWater = Convert.ToDouble(currentWater) - Convert.ToDouble(lastWater);

                if (usingWater < 0)
                {
                    MessageBox.Show("So nuoc thang hien tai khong nho hown so nuoc thang truoc");
                    return;
                }
                double peopleWater = usingWater / countMember;
                double totalMoneyHouse = 0;
                if (peopleWater <= 10)
                {
                    money = (peopleWater * 5.973 * 1.1) / countMember;
                    totalMoneyHouse = usingWater * 5.973 * 1.1;
                }
                else if (peopleWater >= 10 && peopleWater <= 20)
                {
                    money = (usingWater * 7.052 * 1.1) / countMember;
                    totalMoneyHouse = usingWater * 7.052 * 1.1;
                }
                else if (peopleWater >= 20 && peopleWater <= 30)
                {
                    money = (usingWater * 8.689 * 1.1) / countMember;
                    totalMoneyHouse = usingWater * 8.689 * 1.1;
                }
                else if (peopleWater >= 30)
                {
                    money = (usingWater * 15.929 * 1.1) / countMember;
                    totalMoneyHouse = usingWater * 15.929 * 1.1;
                }
                //them du lieu vao listview
                ListViewItem newItems = new ListViewItem(customer);
                newItems.SubItems.Add(typeCustomer);
                newItems.SubItems.Add(countMember.ToString());
                newItems.SubItems.Add(lastWater.ToString());
                newItems.SubItems.Add(currentWater.ToString());
                newItems.SubItems.Add(peopleWater.ToString());
                newItems.SubItems.Add(money.ToString());
                newItems.SubItems.Add(totalMoneyHouse.ToString());
                newItems.SubItems.Add(DateTime.Now.ToString("dd/MM/yy"));
                listViewWaterBill.Items.Add(newItems);
                return;

            }
            else if (typeCustomer == "Administrative")
            {
                // loai khach hang khac
                money = usingWaterOtherCustomer * 9.955 * 1.1;
            }
            else if (typeCustomer == "Production")
            {
                money = usingWaterOtherCustomer * 11.615 * 1.1;
            }
            else if (typeCustomer == "Business")
            {
                money = usingWaterOtherCustomer * 22.068 * 1.1;
            }
            ListViewItem Items = new ListViewItem(customer);
            Items.SubItems.Add(typeCustomer);
            Items.SubItems.Add(countMember.ToString());
            Items.SubItems.Add(lastWater.ToString());
            Items.SubItems.Add(currentWater.ToString());
            Items.SubItems.Add(usingWaterOtherCustomer.ToString());
            Items.SubItems.Add(money.ToString());
            Items.SubItems.Add(DateTime.Now.ToString("dd/MM/yy"));
            listViewWaterBill.Items.Add(Items);
            return;


        }

        private void cboCustomerType_DropDownClosed(object sender, EventArgs e)
        {
            if (cboCustomerType.SelectedValue == "Household")
            {
                txtPeople.Enabled = false;
            }
            else
            {
                txtPeople.Clear();
                txtPeople.Enabled = true;
            }
        }

        private void cboCustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string val = cboCustomerType.SelectedItem.ToString();
            val = val.Trim();
            if (val == "Household")
            {
                txtPeople.Enabled = true;
            }
            else
            {
                txtPeople.Clear();
                txtPeople.Enabled = false;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listViewWaterBill.SelectedItems.Count > 0)
            {
                foreach (ListViewItem ListItem in listViewWaterBill.Items)
                {
                    if (ListItem.Selected == true)
                    {
                        listViewWaterBill.Items.Remove(ListItem);
                    }

                }

            }
            else
            {
                MessageBox.Show("Choose item to delete");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomer.Clear();
            txtPeople.Clear();
            txtPeople.Enabled = false;
            txtWaterCurrentMonth.Clear();
            txtWaterLastMonth.Clear();
            //cboCustomerType.SelectedItem = null; 
            cboCustomerType.Text = "";
            PictureBoxAvatar.Image = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listViewWaterBill.Items.Clear();
            listViewWaterBill.Refresh();
        }

        private void btnupload_Click(object sender, EventArgs e)
        {
            openFileDialogavt.InitialDirectory = "C://Desktop";
            openFileDialogavt.Title = "Select image to be upload";
            openFileDialogavt.Filter = "Image File(*.jpg; *.jpeg; *.png) | *.jpg; *.jpeg; *.png";
            openFileDialogavt.FilterIndex = 1;
            if (openFileDialogavt.ShowDialog() == DialogResult.OK)
            {
                PictureBoxAvatar.Image = new Bitmap
                    (openFileDialogavt.FileName);
                PictureBoxAvatar.SizeMode = PictureBoxSizeMode.StretchImage;

            }

        }

        private void txtCustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPeople_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWaterLastMonth_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWaterCurrentMonth_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
