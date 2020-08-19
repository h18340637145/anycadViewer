using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AnyCAD.Platform;
using AnyCAD.Presentation;

namespace StpViewer
{
    public partial class MainForm : Form
    {
        private AnyCAD.Presentation.RenderWindow3d renderView = null;

        public MainForm()
        {
            InitializeComponent();

            var container = this.splitContainer1.Panel2;//new 一个容器
            renderView = new RenderWindow3d();

            //界面固定代码，写上就完了
            this.renderView.Dock = DockStyle.Fill;
            this.renderView.TabIndex = 1;
            this.splitContainer1.Panel2.Controls.Add(this.renderView);
            //用鼠标单击控件时发生。
            this.renderView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnRenderWindow_MouseClick);
        }

        private void OnRenderWindow_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void MainForm_Resize(object sender, EventArgs e)
        {

        }

      

        //生成默认渲染视图
//----------------------------------------------------------------------------------------------------------------------------
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.renderView.ShowCoordinateAxis(true);
            renderView.ExecuteCommand("ShadeWithEdgeMode");
            this.renderView.RequestDraw();

            renderView.View3d.ShowCoordinateAxis(false);
        }

        //------------------------------------------------------------------------------------------------------------------
        //打开文件功能      
        //-----------------------------------------------------------------------------------------------------------------------------
        //打开step文件
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "STEP File(*.stp;*.step)|*.stp;*.step|All Files(*.*)|*.*";

            if (DialogResult.OK == dlg.ShowDialog())
            {
                CADBrower browser = new CADBrower(dlg.SafeFileName, this.treeViewStp, this.renderView);
                AnyCAD.Exchange.StepReader reader = new AnyCAD.Exchange.StepReader();
                reader.Read(dlg.FileName, browser);
            }
            renderView.FitAll();
        }

        //打开stl文件
        private void openSTLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "STEP File(*.stl)|*.stl|All Files(*.*)|*.*";

            if (DialogResult.OK != dlg.ShowDialog())
                return;

            TopoShape shape = GlobalInstance.BrepTools.LoadFile(new AnyCAD.Platform.Path(dlg.FileName));
            renderView.RenderTimer.Enabled = false;
            if (shape != null)
            {
                //加载到stl文件时
                TopoShapeGroup group = new TopoShapeGroup();
                group.Add(shape);
                
                SceneManager sceneMgr = renderView.SceneManager;
                SceneNode rootNode = GlobalInstance.TopoShapeConvert.ToSceneNode(shape, 0.1f);
                if (rootNode != null)
                {
                    sceneMgr.AddNode(rootNode);
                }
            }
            renderView.RenderTimer.Enabled = true;
            renderView.FitAll();
            renderView.RequestDraw(EnumRenderHint.RH_LoadScene);
        }

        //------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------



        //清除表面模型
        //------------------------------------------------------------------------------------------------------------------
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            renderView.ClearScene();
        }
        //------------------------------------------------------------------------------------------------------------------



        //三种视图
        //------------------------------------------------------------------------------------------------------------------
        //渲染线框
        private void sharedAndFrameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            renderView.SetDisplayMode((int)(EnumDisplayStyle.DS_Face | EnumDisplayStyle.DS_Edge | EnumDisplayStyle.DS_Realistic));
        }

        //渲染
        private void shadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            renderView.SetDisplayMode((int)(EnumDisplayStyle.DS_Face | EnumDisplayStyle.DS_Realistic));
        }

        //线框
        private void edgeModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            renderView.Renderer.SetDisplayMode((int)EnumDisplayStyle.DS_Edge);
            renderView.RequestDraw();
        }

        //------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------

        //三视图功能
        //俯视图
        private void topToolStripMenuItem_Click(object sender, EventArgs e)
        {
            renderView.Renderer.SetStandardView(EnumStandardView.SV_Top);
            renderView.RequestDraw();
        }
        //主视图
        private void frontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            renderView.Renderer.SetStandardView(EnumStandardView.SV_Front);
            renderView.RequestDraw();
        }
        //左视图
        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            renderView.Renderer.SetStandardView(EnumStandardView.SV_Left);
            renderView.RequestDraw();
        }

        //------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------
        //保存step
        private void saveSTEPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "step（*.step）|*.stp";
            sfd.FilterIndex = 1;
            sfd.RestoreDirectory = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(sfd.FileName.ToString());
            }
            else
            {
                MessageBox.Show("取消保存");
                return;
            }
        }

        private void saveSTLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "stl（*.stl）|*.stl";
            sfd.FilterIndex = 1;
            sfd.RestoreDirectory = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(sfd.FileName.ToString());
            }
            else
            {
                MessageBox.Show("取消保存");
                return;
            }
        }
    }
}
