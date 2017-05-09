using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace AC.ExtendedRenderer.Navigator
{
    public partial class OutlookBarNavigationPaneOptions : Form
    { 
            OutlookBarButtonCollection Items;
            Collection OriginalItems = new Collection();

            public OutlookBarNavigationPaneOptions(OutlookBarButtonCollection items)
            {
                InitializeComponent();
                this.Items = items;
                foreach (OutlookBarButton b in this.Items)
                {
                    this.OriginalItems.Add(b, null, null, null);
                }

                this.FillList();
                this.CheckedListBox1.SelectedIndex = 0;
            }

        private void FillList()
        {
            this.CheckedListBox1.Items.Clear();
            foreach (OutlookBarButton b in this.Items)
            {
                if (b.Allowed) this.CheckedListBox1.Items.Add(b, b.Visible);
            }
        }

        private void btn_Up_Click(object sender, EventArgs e)
        {
            int newIndex = this.CheckedListBox1.SelectedIndex - 1;
            this.Items.Insert(newIndex, (OutlookBarButton)this.CheckedListBox1.SelectedItem);
            this.Items.RemoveAt(newIndex + 2);
            this.FillList();
            this.CheckedListBox1.SelectedIndex = newIndex;

        }

        private void btn_Down_Click(object sender, EventArgs e)
        {
            OutlookBarButton b = (OutlookBarButton)this.CheckedListBox1.SelectedItem;
            int newIndex = this.CheckedListBox1.SelectedIndex + 2;
            this.Items.Insert(newIndex, (OutlookBarButton)this.CheckedListBox1.SelectedItem);
            this.Items.Remove(b);
            this.FillList();
            this.CheckedListBox1.SelectedIndex = newIndex - 1;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            btn_Cancel_Click(sender, e);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Items.Clear();
            foreach (OutlookBarButton b in this.OriginalItems)
            {
                this.Items.Add(b);
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            foreach (OutlookBarButton b in this.Items)
            {
                b.Visible = false;
            }
            for (int i = 0; i <= this.CheckedListBox1.CheckedItems.Count - 1; i++)
            {
                ((OutlookBarButton)this.CheckedListBox1.CheckedItems[i]).Visible = true;
            }
            this.Close();
        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CheckedListBox1.SelectedIndex == 0)
            {
                this.btn_Up.Enabled = false;
            }
            else
            {
                this.btn_Up.Enabled = true;
            }
            if (this.CheckedListBox1.SelectedIndex == this.CheckedListBox1.Items.Count - 1)
            {
                this.btn_Down.Enabled = false;
            }
            else
            {
                this.btn_Down.Enabled = true;
            }
            if (this.CheckedListBox1.Items.Count == 1)
            {
                this.btn_Down.Enabled = false;
                this.btn_Up.Enabled = false;
            }
        }
    }
}
