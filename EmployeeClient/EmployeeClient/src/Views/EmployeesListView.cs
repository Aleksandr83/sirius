﻿// Copyright (c) 2021 Lukin Aleksandr
using alg.Types.Controls;
using EmployeeClient.Services.Views;
using EmployeeClient.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeClient.Views
{
    public partial class EmployeesListView : UserControl, IEmployeesListView
    {
        #region Header
        String _Header = GetResourceString("View.Header");

        public String Header
        {
            get { return _Header; }
            private set
            {
                _Header = value;
                OnPropertyChanged("Header");
            }
        }
        #endregion Header

        #region ResourceManager
        static readonly ResourceManager _ResourceManager = new ResourceManager(typeof(EmployeesListView));
        static ResourceManager GetResourceManager() => _ResourceManager;
        static String GetResourceString(String name) => GetResourceManager().GetString(name);
        #endregion ResourceManager

        public EmployeesListView()
        {
            InitializeComponent();            
        }

        private IUserControl GetEmployeeListFiltersControl()
            => (IUserControl)this.employeeListFiltersControl1;

        private IUserControl GetEmployeeDataGridControl()
            => (IUserControl)this.employeeDataGridViewControl1;

        public new void Update()
        {
            GetEmployeeListFiltersControl()?.Update();
            GetEmployeeDataGridControl()?.Update();
        }

        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        #endregion PropertyChanged
    }
}
