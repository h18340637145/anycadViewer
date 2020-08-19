namespace StpViewer
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeViewStp = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSTLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSTEPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSTLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharedAndFrameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stdViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeViewStp);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(1434, 988);
            this.splitContainer1.SplitterDistance = 478;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeViewStp
            // 
            this.treeViewStp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewStp.ForeColor = System.Drawing.Color.YellowGreen;
            this.treeViewStp.Location = new System.Drawing.Point(0, 39);
            this.treeViewStp.Margin = new System.Windows.Forms.Padding(6);
            this.treeViewStp.Name = "treeViewStp";
            this.treeViewStp.Size = new System.Drawing.Size(478, 949);
            this.treeViewStp.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(478, 39);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.openSTLToolStripMenuItem,
            this.saveSTEPToolStripMenuItem,
            this.saveSTLToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(73, 35);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(274, 44);
            this.openToolStripMenuItem.Text = "Open STEP";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openSTLToolStripMenuItem
            // 
            this.openSTLToolStripMenuItem.Name = "openSTLToolStripMenuItem";
            this.openSTLToolStripMenuItem.Size = new System.Drawing.Size(274, 44);
            this.openSTLToolStripMenuItem.Text = "Open STL";
            this.openSTLToolStripMenuItem.Click += new System.EventHandler(this.openSTLToolStripMenuItem_Click);
            // 
            // saveSTEPToolStripMenuItem
            // 
            this.saveSTEPToolStripMenuItem.Name = "saveSTEPToolStripMenuItem";
            this.saveSTEPToolStripMenuItem.Size = new System.Drawing.Size(274, 44);
            this.saveSTEPToolStripMenuItem.Text = "Save STEP";
            this.saveSTEPToolStripMenuItem.Click += new System.EventHandler(this.saveSTEPToolStripMenuItem_Click);
            // 
            // saveSTLToolStripMenuItem
            // 
            this.saveSTLToolStripMenuItem.Name = "saveSTLToolStripMenuItem";
            this.saveSTLToolStripMenuItem.Size = new System.Drawing.Size(274, 44);
            this.saveSTLToolStripMenuItem.Text = "Save STL";
            this.saveSTLToolStripMenuItem.Click += new System.EventHandler(this.saveSTLToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sharedAndFrameToolStripMenuItem,
            this.shadeToolStripMenuItem,
            this.edgeModeToolStripMenuItem,
            this.stdViewToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(89, 35);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // sharedAndFrameToolStripMenuItem
            // 
            this.sharedAndFrameToolStripMenuItem.Name = "sharedAndFrameToolStripMenuItem";
            this.sharedAndFrameToolStripMenuItem.Size = new System.Drawing.Size(396, 44);
            this.sharedAndFrameToolStripMenuItem.Text = "ShadeWithEdgeMode";
            this.sharedAndFrameToolStripMenuItem.Click += new System.EventHandler(this.sharedAndFrameToolStripMenuItem_Click);
            // 
            // shadeToolStripMenuItem
            // 
            this.shadeToolStripMenuItem.Name = "shadeToolStripMenuItem";
            this.shadeToolStripMenuItem.Size = new System.Drawing.Size(396, 44);
            this.shadeToolStripMenuItem.Text = "Shade";
            this.shadeToolStripMenuItem.Click += new System.EventHandler(this.shadeToolStripMenuItem_Click);
            // 
            // edgeModeToolStripMenuItem
            // 
            this.edgeModeToolStripMenuItem.Name = "edgeModeToolStripMenuItem";
            this.edgeModeToolStripMenuItem.Size = new System.Drawing.Size(396, 44);
            this.edgeModeToolStripMenuItem.Text = "EdgeMode";
            this.edgeModeToolStripMenuItem.Click += new System.EventHandler(this.edgeModeToolStripMenuItem_Click);
            // 
            // stdViewToolStripMenuItem
            // 
            this.stdViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topToolStripMenuItem,
            this.frontToolStripMenuItem,
            this.leftToolStripMenuItem});
            this.stdViewToolStripMenuItem.Name = "stdViewToolStripMenuItem";
            this.stdViewToolStripMenuItem.Size = new System.Drawing.Size(396, 44);
            this.stdViewToolStripMenuItem.Text = "Std View";
            // 
            // topToolStripMenuItem
            // 
            this.topToolStripMenuItem.Name = "topToolStripMenuItem";
            this.topToolStripMenuItem.Size = new System.Drawing.Size(208, 44);
            this.topToolStripMenuItem.Text = "Top";
            this.topToolStripMenuItem.Click += new System.EventHandler(this.topToolStripMenuItem_Click);
            // 
            // frontToolStripMenuItem
            // 
            this.frontToolStripMenuItem.Name = "frontToolStripMenuItem";
            this.frontToolStripMenuItem.Size = new System.Drawing.Size(208, 44);
            this.frontToolStripMenuItem.Text = "Front";
            this.frontToolStripMenuItem.Click += new System.EventHandler(this.frontToolStripMenuItem_Click);
            // 
            // leftToolStripMenuItem
            // 
            this.leftToolStripMenuItem.Name = "leftToolStripMenuItem";
            this.leftToolStripMenuItem.Size = new System.Drawing.Size(208, 44);
            this.leftToolStripMenuItem.Text = "Left";
            this.leftToolStripMenuItem.Click += new System.EventHandler(this.leftToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(92, 35);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 988);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "stl & step viewer produced by hhw & framework ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeViewStp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSTLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharedAndFrameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stdViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSTEPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSTLToolStripMenuItem;
    }
}

