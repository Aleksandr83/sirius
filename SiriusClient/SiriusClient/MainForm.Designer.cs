﻿namespace SiriusClient
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolBarControl1 = new SiriusClient.Controls.ToolBarControl();
            this.dockManagerPresenter1 = new SiriusClient.Controls.DockManagerPresenter();
            this.SuspendLayout();
            // 
            // toolBarControl1
            // 
            this.toolBarControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolBarControl1.Location = new System.Drawing.Point(0, 0);
            this.toolBarControl1.Name = "toolBarControl1";
            this.toolBarControl1.Size = new System.Drawing.Size(1130, 31);
            this.toolBarControl1.TabIndex = 0;
            // 
            // dockManagerPresenter1
            // 
            this.dockManagerPresenter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockManagerPresenter1.Location = new System.Drawing.Point(0, 31);
            this.dockManagerPresenter1.Name = "dockManagerPresenter1";
            this.dockManagerPresenter1.Size = new System.Drawing.Size(1130, 461);
            this.dockManagerPresenter1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 492);
            this.Controls.Add(this.dockManagerPresenter1);
            this.Controls.Add(this.toolBarControl1);
            this.Name = "MainForm";
            this.Text = "SiriusClient";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ToolBarControl toolBarControl1;
        private Controls.DockManagerPresenter dockManagerPresenter1;
    }
}

