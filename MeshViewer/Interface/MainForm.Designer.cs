﻿namespace MeshViewer.Interface
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this._wowComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.attachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGeometryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.captureScreenshotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.glControl1 = new OpenTK.GLControl(new OpenTK.Graphics.GraphicsMode(new OpenTK.Graphics.ColorFormat(32), 32, 8, 4), 4, 1, OpenTK.Graphics.GraphicsContextFlags.Debug | OpenTK.Graphics.GraphicsContextFlags.ForwardCompatible);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this._playerExplorer = new MeshViewer.Interface.Controls.EntityExplorer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this._unitExplorer = new MeshViewer.Interface.Controls.EntityExplorer();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this._gameObjectExplorer = new MeshViewer.Interface.Controls.EntityExplorer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._wowComboBox,
            this.attachToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.loadGeometryToolStripMenuItem,
            this.captureScreenshotToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(840, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // _wowComboBox
            // 
            this._wowComboBox.Name = "_wowComboBox";
            this._wowComboBox.Size = new System.Drawing.Size(150, 23);
            // 
            // attachToolStripMenuItem
            // 
            this.attachToolStripMenuItem.Image = global::MeshViewer.Properties.Resources.Attach;
            this.attachToolStripMenuItem.Name = "attachToolStripMenuItem";
            this.attachToolStripMenuItem.Size = new System.Drawing.Size(70, 23);
            this.attachToolStripMenuItem.Text = "Attach";
            this.attachToolStripMenuItem.Click += new System.EventHandler(this.OnAttachRequest);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::MeshViewer.Properties.Resources.Refresh;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(74, 23);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // loadGeometryToolStripMenuItem
            // 
            this.loadGeometryToolStripMenuItem.Image = global::MeshViewer.Properties.Resources.Compass;
            this.loadGeometryToolStripMenuItem.Name = "loadGeometryToolStripMenuItem";
            this.loadGeometryToolStripMenuItem.Size = new System.Drawing.Size(172, 23);
            this.loadGeometryToolStripMenuItem.Text = "Load Serverside Geometry";
            this.loadGeometryToolStripMenuItem.Click += new System.EventHandler(this.OnLoadGeometryRequest);
            // 
            // captureScreenshotToolStripMenuItem
            // 
            this.captureScreenshotToolStripMenuItem.Image = global::MeshViewer.Properties.Resources.Screenshot;
            this.captureScreenshotToolStripMenuItem.Name = "captureScreenshotToolStripMenuItem";
            this.captureScreenshotToolStripMenuItem.Size = new System.Drawing.Size(137, 23);
            this.captureScreenshotToolStripMenuItem.Text = "Capture screenshot";
            this.captureScreenshotToolStripMenuItem.Click += new System.EventHandler(this.OnScreenshotRequest);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.settingsToolStripMenuItem.Image = global::MeshViewer.Properties.Resources.Settings;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(77, 23);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.OnOpenSettingsRequest);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(13, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(815, 524);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.glControl1);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(807, 498);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Terrain";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.glControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glControl1.Location = new System.Drawing.Point(3, 3);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(801, 492);
            this.glControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this._playerExplorer);
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(807, 498);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Players";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // _playerExplorer
            // 
            this._playerExplorer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._playerExplorer.FilterEnabled = true;
            this._playerExplorer.Location = new System.Drawing.Point(3, 3);
            this._playerExplorer.Name = "_playerExplorer";
            this._playerExplorer.Size = new System.Drawing.Size(801, 492);
            this._playerExplorer.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this._unitExplorer);
            this.tabPage3.ImageIndex = 2;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(807, 498);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Units";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // _unitExplorer
            // 
            this._unitExplorer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._unitExplorer.FilterEnabled = false;
            this._unitExplorer.Location = new System.Drawing.Point(3, 3);
            this._unitExplorer.Name = "_unitExplorer";
            this._unitExplorer.Size = new System.Drawing.Size(801, 492);
            this._unitExplorer.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this._gameObjectExplorer);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(807, 498);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "GameObjects";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // _gameObjectExplorer
            // 
            this._gameObjectExplorer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._gameObjectExplorer.FilterEnabled = true;
            this._gameObjectExplorer.Location = new System.Drawing.Point(3, 3);
            this._gameObjectExplorer.Name = "_gameObjectExplorer";
            this._gameObjectExplorer.Size = new System.Drawing.Size(801, 492);
            this._gameObjectExplorer.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 558);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(840, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 580);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MeshViewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClose);
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripComboBox _wowComboBox;
        private System.Windows.Forms.ToolStripMenuItem attachToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private Controls.EntityExplorer _playerExplorer;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private Controls.EntityExplorer _unitExplorer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem loadGeometryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.ToolStripMenuItem captureScreenshotToolStripMenuItem;
        private Controls.EntityExplorer _gameObjectExplorer;
    }
}