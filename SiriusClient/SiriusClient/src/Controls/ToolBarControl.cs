﻿// Copyright (c) 2021 Lukin Aleksandr
using SiriusClient.Services.DockManager;
using SiriusClient.Services.Views;
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
    public partial class ToolBarControl : UserControl
    {
        public ToolBarControl()
        {
            InitializeComponent();
        }

        private void AutorenewButton_Click(object sender, EventArgs e)
        {
            var dockManager = (IDockManagerService)ServicesManager
                .GetService<IDockManagerService>();
            var activeView = (IView)dockManager.GetActiveView();
            activeView?.Update();
        }
    }
}
