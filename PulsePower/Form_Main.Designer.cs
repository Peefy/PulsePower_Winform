namespace PulsePower
{
    partial class Form_Main
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出软件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelStatus = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.comcmb = new System.Windows.Forms.ComboBox();
            this.timerGetData = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.labelPulseWidth = new System.Windows.Forms.Label();
            this.labelTimesOfLow = new System.Windows.Forms.Label();
            this.textBoxPulseWidth = new System.Windows.Forms.TextBox();
            this.textBoxTimesOfLow = new System.Windows.Forms.TextBox();
            this.labelCurrent = new System.Windows.Forms.Label();
            this.textBoxCurrent = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(507, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出软件ToolStripMenuItem});
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.系统ToolStripMenuItem.Text = "系统";
            // 
            // 退出软件ToolStripMenuItem
            // 
            this.退出软件ToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.退出软件ToolStripMenuItem.Name = "退出软件ToolStripMenuItem";
            this.退出软件ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出软件ToolStripMenuItem.Text = "退出软件";
            this.退出软件ToolStripMenuItem.Click += new System.EventHandler(this.退出软件ToolStripMenuItem_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(19, 241);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(53, 12);
            this.labelStatus.TabIndex = 1;
            this.labelStatus.Text = "接受字节";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(21, 41);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "打开串口";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // comcmb
            // 
            this.comcmb.FormattingEnabled = true;
            this.comcmb.Location = new System.Drawing.Point(113, 42);
            this.comcmb.Name = "comcmb";
            this.comcmb.Size = new System.Drawing.Size(99, 20);
            this.comcmb.TabIndex = 3;
            // 
            // timerGetData
            // 
            this.timerGetData.Interval = 800;
            this.timerGetData.Tick += new System.EventHandler(this.timerGetData_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "设置数据";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelPulseWidth
            // 
            this.labelPulseWidth.AutoSize = true;
            this.labelPulseWidth.Font = new System.Drawing.Font("宋体", 12F);
            this.labelPulseWidth.Location = new System.Drawing.Point(110, 81);
            this.labelPulseWidth.Name = "labelPulseWidth";
            this.labelPulseWidth.Size = new System.Drawing.Size(40, 16);
            this.labelPulseWidth.TabIndex = 5;
            this.labelPulseWidth.Text = "脉宽";
            // 
            // labelTimesOfLow
            // 
            this.labelTimesOfLow.AutoSize = true;
            this.labelTimesOfLow.Font = new System.Drawing.Font("宋体", 12F);
            this.labelTimesOfLow.Location = new System.Drawing.Point(234, 81);
            this.labelTimesOfLow.Name = "labelTimesOfLow";
            this.labelTimesOfLow.Size = new System.Drawing.Size(40, 16);
            this.labelTimesOfLow.TabIndex = 5;
            this.labelTimesOfLow.Text = "脉间";
            // 
            // textBoxPulseWidth
            // 
            this.textBoxPulseWidth.Location = new System.Drawing.Point(112, 100);
            this.textBoxPulseWidth.Name = "textBoxPulseWidth";
            this.textBoxPulseWidth.Size = new System.Drawing.Size(100, 21);
            this.textBoxPulseWidth.TabIndex = 6;
            this.textBoxPulseWidth.Text = "40";
            // 
            // textBoxTimesOfLow
            // 
            this.textBoxTimesOfLow.Location = new System.Drawing.Point(236, 100);
            this.textBoxTimesOfLow.Name = "textBoxTimesOfLow";
            this.textBoxTimesOfLow.Size = new System.Drawing.Size(100, 21);
            this.textBoxTimesOfLow.TabIndex = 6;
            this.textBoxTimesOfLow.Text = "5";
            // 
            // labelCurrent
            // 
            this.labelCurrent.AutoSize = true;
            this.labelCurrent.Font = new System.Drawing.Font("宋体", 12F);
            this.labelCurrent.Location = new System.Drawing.Point(356, 81);
            this.labelCurrent.Name = "labelCurrent";
            this.labelCurrent.Size = new System.Drawing.Size(40, 16);
            this.labelCurrent.TabIndex = 7;
            this.labelCurrent.Text = "电流";
            // 
            // textBoxCurrent
            // 
            this.textBoxCurrent.Location = new System.Drawing.Point(358, 101);
            this.textBoxCurrent.Name = "textBoxCurrent";
            this.textBoxCurrent.Size = new System.Drawing.Size(100, 21);
            this.textBoxCurrent.TabIndex = 6;
            this.textBoxCurrent.Text = "5";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(507, 262);
            this.Controls.Add(this.labelCurrent);
            this.Controls.Add(this.textBoxCurrent);
            this.Controls.Add(this.textBoxTimesOfLow);
            this.Controls.Add(this.textBoxPulseWidth);
            this.Controls.Add(this.labelTimesOfLow);
            this.Controls.Add(this.labelPulseWidth);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comcmb);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Main";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PulsePower";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Main_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMoveForm_Main_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出软件ToolStripMenuItem;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox comcmb;
        public System.Windows.Forms.Timer timerGetData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelPulseWidth;
        private System.Windows.Forms.Label labelTimesOfLow;
        private System.Windows.Forms.TextBox textBoxPulseWidth;
        private System.Windows.Forms.TextBox textBoxTimesOfLow;
        private System.Windows.Forms.Label labelCurrent;
        private System.Windows.Forms.TextBox textBoxCurrent;
    }
}

