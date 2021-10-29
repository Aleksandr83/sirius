﻿// Copyright (c) 2021 Lukin Aleksandr
using SiriusClient.Services.DockManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiriusClient.Controls
{
    public partial class DockManagerPresenter : UserControl
    {
        public DockManagerPresenter()
        {
            InitializeComponent();
            AddDockManagerControl();
        }

        void AddDockManagerControl()
        {
            var dockManager  = (UserControl)GetDockManagerControl();
            dockManager.Dock = DockStyle.Fill;
            this.Controls.Add(dockManager);
        }

        dynamic GetDockManagerControl()
        {
            return ServicesManager.GetService<IDockManagerService>();
        }
    }
}
