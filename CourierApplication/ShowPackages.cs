﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurierApplication
{
    public partial class ShowPackages : Form
    {
        private int customerId;
        List<Package> packages = new List<Package>();

        public ShowPackages(int idNumber)
        {
            InitializeComponent();
            customerId = idNumber;
            LoadDataAboutPackages();
        }

        private void LoadDataAboutPackages()
        {
            Packages packs = ManagePackage.ReadListPackages(customerId, GlobalVar.pathPackagesFile);
            if (packs != null)
            {
                packages = packs.packages;
            }
            refreshDataGridView();
        }

        private void refreshDataGridView()
        {
            dataGridViewDataAboutPackagesCustomer.Rows.Clear();
            foreach (var package in packages)
            {
                dataGridViewDataAboutPackagesCustomer.Rows.Add(package.number , package.status, package.hour);
            }
        }
    }
}
