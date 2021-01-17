using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework5
{
    public partial class EmployersForm : Form
    {
        List<Organisation> employers;
        List<Organisation> Organizations
        {
            get
            {
                return employers;
            }
            set
            {
                employers = value;
                ItemsLV.Items.Clear();
                for (int i = 0; i < value.Count; i++)
                {
                    for (int j = i + 1; j < value.Count; j++)
                        if (value[i].Equals(value[j]))
                        {
                            MessageBox.Show("Обнаружены одинаковые организации! Лишние дубликаты удалены.");
                            Organisation o = new Organisation(value[i]);
                            _ = i == value.Count - 1 ? i--  : i;
                            j = Math.Max(j -= value.RemoveAll(p => p.Equals(o)), i + 1);
                            value.Insert(i, o);
                        }
                    ItemsLV.Items.Add(value[i].ToString());
                }
                ItemsLV.Sort();
                ItemsPG.SelectedObject = null;
            }
        }
        public EmployersForm()
        {
            InitializeComponent();
            Organizations = new List<Organisation>();
            BasicFounders();
        }

        private void BasicFounders()
        {
            Organisation MIEE = new Organisation("Russia", "Moscow", "Zelenograd", "Schokina", 1, 124498);
            Organisation MIEE_copy = new Organisation("Russia", "Moscow", "Zelenograd", "Schokina", 2, 124498);
            Organisation MIEE_copy_copy = new Organisation("Russia", "Moscow", "Zelenograd", "Schokina", 3, 124498);
            Organisation MIEE_copy_copy_copy = new Organisation("Russia", "Moscow", "Zelenograd", "Schokina", 4, 124498);
            Organisation MIEE_copy_copy_copy_copy = new Organisation("Russia", "Moscow", "Zelenograd", "Schokina", 5, 124498);

            Organizations.Add(MIEE);
            Organizations.Add(MIEE_copy);
            Organizations.Add(MIEE_copy_copy);
            Organizations.Add(MIEE_copy_copy_copy);
            Organizations.Add(MIEE_copy_copy_copy_copy);
            Organizations = Organizations;
        }

        private int IsThereOrganisation(object orgj)
        {
            int count = 0;
            Organisation organisation = orgj as Organisation;
            foreach (Organisation org in Organizations)
                if (org.Equals(organisation))
                    count++;
            return count;
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                _ = int.TryParse(Prop4CB.Text, out int res1) ? 0 : throw new Exception("Номер дома должен быть целым и положительным!");
                _ = int.TryParse(Prop5CB.Text, out int res2) ? 0 : throw new Exception("Индекс должен быть целым и положительным!");
                Organisation organisation = new Organisation(
                    Prop1CB.Text, Prop2CB.Text, Prop3CB.Text, Prop3CB.Text,
                    res1, res2
                );
                _ = IsThereOrganisation(organisation) > 0 ? 
                    throw new Exception("Такая организация уже есть в списке!") : 0;
                Organizations.Add(organisation);
                Organizations = Organizations;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteItemButton_Click(object sender, EventArgs e)
        {
            if (ItemsLV.SelectedItems.Count == 0) return;
            foreach (ListViewItem el in ItemsLV.SelectedItems)
                Organizations.RemoveAll(p => p.ToString() == el.Text);
            Organizations = Organizations;
        }

        private void ChangeItemButton_Click(object sender, EventArgs e)
        {
            if (ItemsLV.SelectedItems.Count < 1) return;
            if (ItemsLV.SelectedItems.Count > 1)
                MessageBox.Show("Пожалуйста, выберите только одну организацию!");
            ItemsPG.SelectedObject = Organizations.Find(p => 
                p.ToString() == ItemsLV.SelectedItems.Cast<ListViewItem>().ToArray()[0].Text);
        }

        private void MoreInfoButton_Click(object sender, EventArgs e)
        {
            if (ItemsLV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите хотя бы одну организацию!");
                return;
            }
            foreach (ListViewItem lvi in ItemsLV.SelectedItems)
                MessageBox.Show(Organizations.Find(p => p.ToString() == lvi.Text).ToString());
        }

        private void ItemsPG_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            object org = (s as PropertyGrid).SelectedObject;
                Organizations = Organizations;
                (s as PropertyGrid).SelectedObject = org;
        }
    }
}
