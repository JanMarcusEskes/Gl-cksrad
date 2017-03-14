﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glücksrad
{
    public partial class Main : Form
    {
        List<string> einträge = new List<string> { "800", "200", "500", "Bankrott", "1000", "Extradreh", "50", "600" };
        int index = 0;
        public Main()
        {
            InitializeComponent();
            RefreshList();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            index++;
            RefreshList();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            index--;
            RefreshList();
        }

        private void RefreshList()
        {
            if (index == einträge.Count || index == -einträge.Count)
                index = 0;
            int aktuellerIndex = index;
            foreach (Control label in groupBox1.Controls)
            {
                if (aktuellerIndex >= einträge.Count)
                    aktuellerIndex -= einträge.Count;
                else if (aktuellerIndex < 0)
                    aktuellerIndex += einträge.Count;

                label.Text = einträge[aktuellerIndex];
                aktuellerIndex++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAddRemove.Text == String.Empty)
            {
                MessageBox.Show("Sie haben nichts einegegeben!\nBitte geben Sie einen Wert ein!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (einträge.Contains(txtAddRemove.Text))
                einträge.Remove(txtAddRemove.Text);
            else
                einträge.Add(txtAddRemove.Text);

            if (einträge.Count == 0)
            {
                MessageBox.Show("Sie haben alle Einträge entfernt!\nBitte fürgen Sie einige Werte wieder hinzu.\nStandartwerte wieder hergestellt.", "Werte fehlen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                einträge = new List<string> { "800", "200", "500", "Bankrott", "1000", "Extradreh", "50", "600" };
            }
            RefreshList();
        }
    }
}
