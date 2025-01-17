﻿// Copyright (c) 2021 Lukin Aleksandr
using alg.Types.Controls.DataGrid;
using alg.Types.Controls.DataGrid.Schema;
using alg.Types.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeClient.Controls
{
    public partial class DataGridViewControl : 
        UserControl, IDataGridControl
    {
        ColumnsSchema _ColumnsSchema;

        public DataGridViewControl()
        {
            InitializeComponent(); 
        }

        private DataGridView  GetDataGridView()  => this.dataGridView1;
        private ColumnsSchema GetColumnsSchema() => _ColumnsSchema;

        public void SetReadOnly(bool value)
        {
            GetDataGridView().ReadOnly = value;
        }

        public void SetAutoGenerateColumns(bool value)
        {
            GetDataGridView().AutoGenerateColumns = value;
        }

        public void SetAllowUserAddRows(bool value)
        {
            GetDataGridView().AllowUserToAddRows = value;
        }

        public void SetColumnsSchema(ColumnsSchema columnsSchema)
        {
            _ColumnsSchema = columnsSchema;
        }

        public void SetDataSource(object dataSource)
        {            
            GetDataGridView().DataSource = dataSource;
        }

        public void CreateColumns()
        {
            ClearColumns();
            var columnsSchema = GetColumnsSchema();
            foreach (var columnSchema in columnsSchema?.Columns??List.Empty<Column>())
            {
                AddColumn(columnSchema);
            }
        }

        private void ClearColumns()
        {
            GetDataGridView()?.Columns?.Clear();
        }

        private void AddColumn(Column columnSchema)
        {
            var column = new DataGridViewTextBoxColumn()
            {
                HeaderText       = columnSchema.Header,
                MinimumWidth     = 20,
                Width            = columnSchema.DefaultWidth,
                DataPropertyName = columnSchema.Name
            };            
            GetDataGridView()?.Columns?.Add(column);            
        }
    }
}
