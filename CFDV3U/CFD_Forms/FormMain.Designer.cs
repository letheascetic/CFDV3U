namespace CFD_Forms
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savedirMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PIEditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uesrMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interfaceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.deviceToolStripLb = new System.Windows.Forms.ToolStripLabel();
            this.portNameToolStripCbx = new System.Windows.Forms.ToolStripComboBox();
            this.connectToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cameraToolStripLb = new System.Windows.Forms.ToolStripLabel();
            this.cameraToolStripTbx = new System.Windows.Forms.ToolStripTextBox();
            this.gainToolStripLb = new System.Windows.Forms.ToolStripLabel();
            this.propToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.modeToolStripLb = new System.Windows.Forms.ToolStripLabel();
            this.modeToolStripCbx = new System.Windows.Forms.ToolStripComboBox();
            this.measureToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLbIns = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusIns = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLbCamera = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusCameraFound = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusCameraCon = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLbMeas = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLbMeasInt = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLbAct = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLbActInt = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLbSat = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLbSatInt = new System.Windows.Forms.ToolStripStatusLabel();
            this.statuslbSaveDir = new System.Windows.Forms.ToolStripStatusLabel();
            this.menu.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.configMenuItem,
            this.helpToolStripMenuItem,
            this.aboutMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menu.ShowItemToolTips = true;
            this.menu.Size = new System.Drawing.Size(994, 35);
            this.menu.TabIndex = 10;
            this.menu.Text = "主菜单";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.AutoToolTip = true;
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenuItem,
            this.saveMenuItem,
            this.savedirMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fileMenuItem.Size = new System.Drawing.Size(69, 29);
            this.fileMenuItem.Text = "文件(&F)";
            this.fileMenuItem.ToolTipText = "读取/保存文件";
            // 
            // openMenuItem
            // 
            this.openMenuItem.AutoToolTip = true;
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openMenuItem.Size = new System.Drawing.Size(193, 24);
            this.openMenuItem.Text = "打开";
            this.openMenuItem.ToolTipText = "打开文件";
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.AutoToolTip = true;
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveMenuItem.Size = new System.Drawing.Size(193, 24);
            this.saveMenuItem.Text = "保存";
            this.saveMenuItem.ToolTipText = "保存文件";
            // 
            // savedirMenuItem
            // 
            this.savedirMenuItem.AutoToolTip = true;
            this.savedirMenuItem.Name = "savedirMenuItem";
            this.savedirMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.savedirMenuItem.Size = new System.Drawing.Size(193, 24);
            this.savedirMenuItem.Text = "存储路径";
            this.savedirMenuItem.ToolTipText = "设置存储路径";
            // 
            // configMenuItem
            // 
            this.configMenuItem.AutoToolTip = true;
            this.configMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deviceMenuItem,
            this.cameraMenuItem,
            this.parasMenuItem,
            this.PIEditMenuItem});
            this.configMenuItem.Name = "configMenuItem";
            this.configMenuItem.Size = new System.Drawing.Size(71, 29);
            this.configMenuItem.Text = "设置(&C)";
            this.configMenuItem.ToolTipText = "设置";
            // 
            // deviceMenuItem
            // 
            this.deviceMenuItem.AutoToolTip = true;
            this.deviceMenuItem.Name = "deviceMenuItem";
            this.deviceMenuItem.ShortcutKeyDisplayString = "";
            this.deviceMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.deviceMenuItem.Size = new System.Drawing.Size(211, 24);
            this.deviceMenuItem.Text = "设备";
            this.deviceMenuItem.ToolTipText = "设置端口";
            // 
            // cameraMenuItem
            // 
            this.cameraMenuItem.AutoToolTip = true;
            this.cameraMenuItem.Name = "cameraMenuItem";
            this.cameraMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.cameraMenuItem.Size = new System.Drawing.Size(211, 24);
            this.cameraMenuItem.Text = "相机";
            this.cameraMenuItem.ToolTipText = "设置相机";
            // 
            // parasMenuItem
            // 
            this.parasMenuItem.AutoToolTip = true;
            this.parasMenuItem.Name = "parasMenuItem";
            this.parasMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.parasMenuItem.Size = new System.Drawing.Size(211, 24);
            this.parasMenuItem.Text = "测量参数";
            this.parasMenuItem.ToolTipText = "设置测量参数";
            // 
            // PIEditMenuItem
            // 
            this.PIEditMenuItem.AutoToolTip = true;
            this.PIEditMenuItem.Name = "PIEditMenuItem";
            this.PIEditMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.PIEditMenuItem.Size = new System.Drawing.Size(211, 24);
            this.PIEditMenuItem.Text = "快速光曲线";
            this.PIEditMenuItem.ToolTipText = "设置快速光曲线";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.AutoToolTip = true;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uesrMenuItem,
            this.interfaceMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.helpToolStripMenuItem.Text = "帮助(&H)";
            this.helpToolStripMenuItem.ToolTipText = "帮助文件";
            // 
            // uesrMenuItem
            // 
            this.uesrMenuItem.Name = "uesrMenuItem";
            this.uesrMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.uesrMenuItem.Size = new System.Drawing.Size(195, 24);
            this.uesrMenuItem.Text = "操作手册";
            this.uesrMenuItem.ToolTipText = "植物荧光成像系统操作手册";
            // 
            // interfaceMenuItem
            // 
            this.interfaceMenuItem.Name = "interfaceMenuItem";
            this.interfaceMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.interfaceMenuItem.Size = new System.Drawing.Size(195, 24);
            this.interfaceMenuItem.Text = "接口说明";
            this.interfaceMenuItem.ToolTipText = "系统硬件接口及接线说明";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.AutoToolTip = true;
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutMenuItem.Size = new System.Drawing.Size(72, 29);
            this.aboutMenuItem.Text = "关于(&A)";
            this.aboutMenuItem.ToolTipText = "公司及软件版本信息";
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.SystemColors.Window;
            this.toolStrip.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deviceToolStripLb,
            this.portNameToolStripCbx,
            this.connectToolStripBtn,
            this.toolStripSeparator1,
            this.cameraToolStripLb,
            this.cameraToolStripTbx,
            this.gainToolStripLb,
            this.propToolStripBtn,
            this.toolStripSeparator2,
            this.modeToolStripLb,
            this.modeToolStripCbx,
            this.measureToolStripBtn});
            this.toolStrip.Location = new System.Drawing.Point(0, 35);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(994, 27);
            this.toolStrip.TabIndex = 11;
            // 
            // deviceToolStripLb
            // 
            this.deviceToolStripLb.Name = "deviceToolStripLb";
            this.deviceToolStripLb.Size = new System.Drawing.Size(35, 24);
            this.deviceToolStripLb.Text = "设备";
            // 
            // portNameToolStripCbx
            // 
            this.portNameToolStripCbx.AutoSize = false;
            this.portNameToolStripCbx.BackColor = System.Drawing.SystemColors.Window;
            this.portNameToolStripCbx.DropDownWidth = 60;
            this.portNameToolStripCbx.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.portNameToolStripCbx.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6"});
            this.portNameToolStripCbx.MaxDropDownItems = 6;
            this.portNameToolStripCbx.MaxLength = 60;
            this.portNameToolStripCbx.Name = "portNameToolStripCbx";
            this.portNameToolStripCbx.Size = new System.Drawing.Size(60, 25);
            this.portNameToolStripCbx.ToolTipText = "端口号";
            // 
            // connectToolStripBtn
            // 
            this.connectToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.connectToolStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("connectToolStripBtn.Image")));
            this.connectToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.connectToolStripBtn.Name = "connectToolStripBtn";
            this.connectToolStripBtn.Size = new System.Drawing.Size(23, 24);
            this.connectToolStripBtn.Text = "连接或断开设备";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // cameraToolStripLb
            // 
            this.cameraToolStripLb.Name = "cameraToolStripLb";
            this.cameraToolStripLb.Size = new System.Drawing.Size(35, 24);
            this.cameraToolStripLb.Text = "相机";
            // 
            // cameraToolStripTbx
            // 
            this.cameraToolStripTbx.BackColor = System.Drawing.SystemColors.Window;
            this.cameraToolStripTbx.Name = "cameraToolStripTbx";
            this.cameraToolStripTbx.ReadOnly = true;
            this.cameraToolStripTbx.Size = new System.Drawing.Size(100, 27);
            this.cameraToolStripTbx.ToolTipText = "相机";
            // 
            // gainToolStripLb
            // 
            this.gainToolStripLb.Name = "gainToolStripLb";
            this.gainToolStripLb.Size = new System.Drawing.Size(35, 24);
            this.gainToolStripLb.Text = "增益";
            this.gainToolStripLb.ToolTipText = "相机增益";
            // 
            // propToolStripBtn
            // 
            this.propToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.propToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.propToolStripBtn.Name = "propToolStripBtn";
            this.propToolStripBtn.Size = new System.Drawing.Size(39, 24);
            this.propToolStripBtn.Text = "属性";
            this.propToolStripBtn.ToolTipText = "相机属性";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // modeToolStripLb
            // 
            this.modeToolStripLb.Name = "modeToolStripLb";
            this.modeToolStripLb.Size = new System.Drawing.Size(61, 24);
            this.modeToolStripLb.Text = "测量模式";
            // 
            // modeToolStripCbx
            // 
            this.modeToolStripCbx.AutoSize = false;
            this.modeToolStripCbx.BackColor = System.Drawing.SystemColors.Window;
            this.modeToolStripCbx.DropDownWidth = 60;
            this.modeToolStripCbx.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.modeToolStripCbx.Items.AddRange(new object[] {
            "测量光",
            "光化光",
            "饱和光",
            "测量Fo,Fm",
            "连续饱和脉冲",
            "动力学曲线",
            "快速光曲线",
            "GFP模式"});
            this.modeToolStripCbx.MaxDropDownItems = 6;
            this.modeToolStripCbx.MaxLength = 80;
            this.modeToolStripCbx.Name = "modeToolStripCbx";
            this.modeToolStripCbx.Size = new System.Drawing.Size(80, 25);
            this.modeToolStripCbx.ToolTipText = "选择测量模式";
            // 
            // measureToolStripBtn
            // 
            this.measureToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.measureToolStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("measureToolStripBtn.Image")));
            this.measureToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.measureToolStripBtn.Name = "measureToolStripBtn";
            this.measureToolStripBtn.Size = new System.Drawing.Size(23, 24);
            this.measureToolStripBtn.Text = "连接设备";
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLbIns,
            this.statusIns,
            this.statusLbCamera,
            this.statusCameraFound,
            this.statusCameraCon,
            this.statusLbMeas,
            this.statusLbMeasInt,
            this.statusLbAct,
            this.statusLbActInt,
            this.statusLbSat,
            this.statusLbSatInt,
            this.statuslbSaveDir});
            this.statusStrip.Location = new System.Drawing.Point(0, 742);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(994, 25);
            this.statusStrip.TabIndex = 12;
            this.statusStrip.Text = "状态栏";
            // 
            // statusLbIns
            // 
            this.statusLbIns.BackColor = System.Drawing.Color.Transparent;
            this.statusLbIns.Name = "statusLbIns";
            this.statusLbIns.Size = new System.Drawing.Size(38, 20);
            this.statusLbIns.Text = "设备:";
            // 
            // statusIns
            // 
            this.statusIns.BackColor = System.Drawing.Color.Transparent;
            this.statusIns.Name = "statusIns";
            this.statusIns.Size = new System.Drawing.Size(0, 20);
            // 
            // statusLbCamera
            // 
            this.statusLbCamera.BackColor = System.Drawing.Color.Transparent;
            this.statusLbCamera.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
            this.statusLbCamera.Name = "statusLbCamera";
            this.statusLbCamera.Size = new System.Drawing.Size(38, 20);
            this.statusLbCamera.Text = "相机:";
            // 
            // statusCameraFound
            // 
            this.statusCameraFound.BackColor = System.Drawing.Color.Transparent;
            this.statusCameraFound.Image = ((System.Drawing.Image)(resources.GetObject("statusCameraFound.Image")));
            this.statusCameraFound.Name = "statusCameraFound";
            this.statusCameraFound.Size = new System.Drawing.Size(16, 20);
            // 
            // statusCameraCon
            // 
            this.statusCameraCon.BackColor = System.Drawing.Color.Transparent;
            this.statusCameraCon.Name = "statusCameraCon";
            this.statusCameraCon.Size = new System.Drawing.Size(0, 20);
            // 
            // statusLbMeas
            // 
            this.statusLbMeas.BackColor = System.Drawing.Color.Transparent;
            this.statusLbMeas.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
            this.statusLbMeas.Name = "statusLbMeas";
            this.statusLbMeas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusLbMeas.Size = new System.Drawing.Size(51, 20);
            this.statusLbMeas.Text = "测量光:";
            // 
            // statusLbMeasInt
            // 
            this.statusLbMeasInt.BackColor = System.Drawing.Color.Transparent;
            this.statusLbMeasInt.Name = "statusLbMeasInt";
            this.statusLbMeasInt.Size = new System.Drawing.Size(35, 20);
            this.statusLbMeasInt.Text = "  /   ";
            // 
            // statusLbAct
            // 
            this.statusLbAct.BackColor = System.Drawing.Color.Transparent;
            this.statusLbAct.Name = "statusLbAct";
            this.statusLbAct.Size = new System.Drawing.Size(51, 20);
            this.statusLbAct.Text = "光化光:";
            // 
            // statusLbActInt
            // 
            this.statusLbActInt.BackColor = System.Drawing.Color.Transparent;
            this.statusLbActInt.Name = "statusLbActInt";
            this.statusLbActInt.Size = new System.Drawing.Size(35, 20);
            this.statusLbActInt.Text = "  /   ";
            // 
            // statusLbSat
            // 
            this.statusLbSat.BackColor = System.Drawing.Color.Transparent;
            this.statusLbSat.Name = "statusLbSat";
            this.statusLbSat.Size = new System.Drawing.Size(51, 20);
            this.statusLbSat.Text = "饱和光:";
            // 
            // statusLbSatInt
            // 
            this.statusLbSatInt.BackColor = System.Drawing.Color.Transparent;
            this.statusLbSatInt.Name = "statusLbSatInt";
            this.statusLbSatInt.Size = new System.Drawing.Size(35, 20);
            this.statusLbSatInt.Text = "  /   ";
            // 
            // statuslbSaveDir
            // 
            this.statuslbSaveDir.AutoSize = false;
            this.statuslbSaveDir.AutoToolTip = true;
            this.statuslbSaveDir.BackColor = System.Drawing.Color.Transparent;
            this.statuslbSaveDir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statuslbSaveDir.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
            this.statuslbSaveDir.Name = "statuslbSaveDir";
            this.statuslbSaveDir.Size = new System.Drawing.Size(687, 20);
            this.statuslbSaveDir.Spring = true;
            this.statuslbSaveDir.Text = " 存储路径";
            this.statuslbSaveDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statuslbSaveDir.ToolTipText = "存储目录";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 767);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "炬像植物叶绿素荧光成像分析软件 ";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savedirMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deviceMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cameraMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parasMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PIEditMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uesrMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interfaceMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel deviceToolStripLb;
        private System.Windows.Forms.ToolStripComboBox portNameToolStripCbx;
        private System.Windows.Forms.ToolStripButton connectToolStripBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel cameraToolStripLb;
        private System.Windows.Forms.ToolStripTextBox cameraToolStripTbx;
        private System.Windows.Forms.ToolStripLabel gainToolStripLb;
        private System.Windows.Forms.ToolStripButton propToolStripBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel modeToolStripLb;
        private System.Windows.Forms.ToolStripComboBox modeToolStripCbx;
        private System.Windows.Forms.ToolStripButton measureToolStripBtn;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLbIns;
        private System.Windows.Forms.ToolStripStatusLabel statusIns;
        private System.Windows.Forms.ToolStripStatusLabel statusLbCamera;
        private System.Windows.Forms.ToolStripStatusLabel statusCameraFound;
        private System.Windows.Forms.ToolStripStatusLabel statusCameraCon;
        private System.Windows.Forms.ToolStripStatusLabel statusLbMeas;
        private System.Windows.Forms.ToolStripStatusLabel statusLbMeasInt;
        private System.Windows.Forms.ToolStripStatusLabel statusLbAct;
        private System.Windows.Forms.ToolStripStatusLabel statusLbActInt;
        private System.Windows.Forms.ToolStripStatusLabel statusLbSat;
        private System.Windows.Forms.ToolStripStatusLabel statusLbSatInt;
        private System.Windows.Forms.ToolStripStatusLabel statuslbSaveDir;
    }
}

