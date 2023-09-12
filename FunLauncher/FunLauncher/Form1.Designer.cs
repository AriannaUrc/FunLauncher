namespace FunLauncher
{
    partial class FunLauncherWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FunLauncherWindow));
            menuStrip1 = new MenuStrip();
            InternetDropDown = new ToolStripMenuItem();
            Firefox_InternetDropDown = new ToolStripMenuItem();
            Edge_InternetDropDown = new ToolStripMenuItem();
            Chrome_InternetDropDown = new ToolStripMenuItem();
            Iexplore_InternetDropDown = new ToolStripMenuItem();
            ToolsDropDown = new ToolStripMenuItem();
            Notepad_ToolsDropDown = new ToolStripMenuItem();
            CMD_Menu_ToolsDropDown = new ToolStripMenuItem();
            CMD_Menu_CurrentPath_ToolsDropDown = new ToolStripMenuItem();
            CMD_Menu_DriveC_ToolsDropDown = new ToolStripMenuItem();
            RotateScreen_Menu_ToolsDropDown = new ToolStripMenuItem();
            RotateScreen_0D_ToolsDropDown = new ToolStripMenuItem();
            RotateScreen_90D_ToolsDropDown = new ToolStripMenuItem();
            RotateScreen_180D_ToolsDropDown = new ToolStripMenuItem();
            RotateScreen_270D_ToolsDropDown = new ToolStripMenuItem();
            TrollsDropDown = new ToolStripMenuItem();
            RandomScreenRotation_TrollsDropDown = new ToolStripMenuItem();
            rebootPToolStripMenuItem = new ToolStripMenuItem();
            PanicScreen_Button = new Button();
            PanicClose_Button = new Button();
            SuddenlyPineapples_Button = new Button();
            StudentsRescue = new GroupBox();
            JevilCapsTimer = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            StudentsRescue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { InternetDropDown, ToolsDropDown, TrollsDropDown });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(624, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // InternetDropDown
            // 
            InternetDropDown.DropDownItems.AddRange(new ToolStripItem[] { Firefox_InternetDropDown, Edge_InternetDropDown, Chrome_InternetDropDown, Iexplore_InternetDropDown });
            InternetDropDown.Name = "InternetDropDown";
            InternetDropDown.Size = new Size(60, 20);
            InternetDropDown.Text = "Internet";
            // 
            // Firefox_InternetDropDown
            // 
            Firefox_InternetDropDown.Name = "Firefox_InternetDropDown";
            Firefox_InternetDropDown.Size = new Size(186, 22);
            Firefox_InternetDropDown.Text = "Firefox";
            Firefox_InternetDropDown.Click += Firefox_InternetDropDown_Click;
            // 
            // Edge_InternetDropDown
            // 
            Edge_InternetDropDown.Name = "Edge_InternetDropDown";
            Edge_InternetDropDown.Size = new Size(186, 22);
            Edge_InternetDropDown.Text = "Edge";
            Edge_InternetDropDown.Click += Edge_InternetDropDown_Click;
            // 
            // Chrome_InternetDropDown
            // 
            Chrome_InternetDropDown.Name = "Chrome_InternetDropDown";
            Chrome_InternetDropDown.Size = new Size(186, 22);
            Chrome_InternetDropDown.Text = "Chrome";
            Chrome_InternetDropDown.Click += Chrome_InternetDropDown_Click;
            // 
            // Iexplore_InternetDropDown
            // 
            Iexplore_InternetDropDown.Name = "Iexplore_InternetDropDown";
            Iexplore_InternetDropDown.Size = new Size(186, 22);
            Iexplore_InternetDropDown.Text = "IExplore (Fix Needed)";
            Iexplore_InternetDropDown.Click += Iexplore_InternetDropDown_Click;
            // 
            // ToolsDropDown
            // 
            ToolsDropDown.DropDownItems.AddRange(new ToolStripItem[] { Notepad_ToolsDropDown, CMD_Menu_ToolsDropDown, RotateScreen_Menu_ToolsDropDown });
            ToolsDropDown.Name = "ToolsDropDown";
            ToolsDropDown.Size = new Size(46, 20);
            ToolsDropDown.Text = "Tools";
            // 
            // Notepad_ToolsDropDown
            // 
            Notepad_ToolsDropDown.Name = "Notepad_ToolsDropDown";
            Notepad_ToolsDropDown.Size = new Size(146, 22);
            Notepad_ToolsDropDown.Text = "Notepad";
            Notepad_ToolsDropDown.Click += Notepad_ToolsDropDown_Click;
            // 
            // CMD_Menu_ToolsDropDown
            // 
            CMD_Menu_ToolsDropDown.DropDownItems.AddRange(new ToolStripItem[] { CMD_Menu_CurrentPath_ToolsDropDown, CMD_Menu_DriveC_ToolsDropDown });
            CMD_Menu_ToolsDropDown.Name = "CMD_Menu_ToolsDropDown";
            CMD_Menu_ToolsDropDown.Size = new Size(146, 22);
            CMD_Menu_ToolsDropDown.Text = "CMD";
            // 
            // CMD_Menu_CurrentPath_ToolsDropDown
            // 
            CMD_Menu_CurrentPath_ToolsDropDown.Name = "CMD_Menu_CurrentPath_ToolsDropDown";
            CMD_Menu_CurrentPath_ToolsDropDown.Size = new Size(182, 22);
            CMD_Menu_CurrentPath_ToolsDropDown.Text = "CMD in current Path";
            CMD_Menu_CurrentPath_ToolsDropDown.Click += CMD_Menu_CurrentPath_ToolsDropDown_Click;
            // 
            // CMD_Menu_DriveC_ToolsDropDown
            // 
            CMD_Menu_DriveC_ToolsDropDown.Name = "CMD_Menu_DriveC_ToolsDropDown";
            CMD_Menu_DriveC_ToolsDropDown.Size = new Size(182, 22);
            CMD_Menu_DriveC_ToolsDropDown.Text = "CMD in drive C";
            CMD_Menu_DriveC_ToolsDropDown.Click += CMD_Menu_DriveC_ToolsDropDown_Click;
            // 
            // RotateScreen_Menu_ToolsDropDown
            // 
            RotateScreen_Menu_ToolsDropDown.DropDownItems.AddRange(new ToolStripItem[] { RotateScreen_0D_ToolsDropDown, RotateScreen_90D_ToolsDropDown, RotateScreen_180D_ToolsDropDown, RotateScreen_270D_ToolsDropDown });
            RotateScreen_Menu_ToolsDropDown.Name = "RotateScreen_Menu_ToolsDropDown";
            RotateScreen_Menu_ToolsDropDown.Size = new Size(146, 22);
            RotateScreen_Menu_ToolsDropDown.Text = "Rotate Screen";
            // 
            // RotateScreen_0D_ToolsDropDown
            // 
            RotateScreen_0D_ToolsDropDown.Name = "RotateScreen_0D_ToolsDropDown";
            RotateScreen_0D_ToolsDropDown.Size = new Size(97, 22);
            RotateScreen_0D_ToolsDropDown.Text = "0°";
            RotateScreen_0D_ToolsDropDown.Click += RotateScreen_0D_ToolsDropDown_Click;
            // 
            // RotateScreen_90D_ToolsDropDown
            // 
            RotateScreen_90D_ToolsDropDown.Name = "RotateScreen_90D_ToolsDropDown";
            RotateScreen_90D_ToolsDropDown.Size = new Size(97, 22);
            RotateScreen_90D_ToolsDropDown.Text = "90°";
            RotateScreen_90D_ToolsDropDown.Click += RotateScreen_90D_ToolsDropDown_Click;
            // 
            // RotateScreen_180D_ToolsDropDown
            // 
            RotateScreen_180D_ToolsDropDown.Name = "RotateScreen_180D_ToolsDropDown";
            RotateScreen_180D_ToolsDropDown.Size = new Size(97, 22);
            RotateScreen_180D_ToolsDropDown.Text = "180°";
            RotateScreen_180D_ToolsDropDown.Click += RotateScreen_180D_ToolsDropDown_Click;
            // 
            // RotateScreen_270D_ToolsDropDown
            // 
            RotateScreen_270D_ToolsDropDown.Name = "RotateScreen_270D_ToolsDropDown";
            RotateScreen_270D_ToolsDropDown.Size = new Size(97, 22);
            RotateScreen_270D_ToolsDropDown.Text = "270°";
            RotateScreen_270D_ToolsDropDown.Click += RotateScreen_270D_ToolsDropDown_Click;
            // 
            // TrollsDropDown
            // 
            TrollsDropDown.DropDownItems.AddRange(new ToolStripItem[] { RandomScreenRotation_TrollsDropDown, rebootPToolStripMenuItem });
            TrollsDropDown.Name = "TrollsDropDown";
            TrollsDropDown.Size = new Size(46, 20);
            TrollsDropDown.Text = "Trolls";
            // 
            // RandomScreenRotation_TrollsDropDown
            // 
            RandomScreenRotation_TrollsDropDown.Name = "RandomScreenRotation_TrollsDropDown";
            RandomScreenRotation_TrollsDropDown.Size = new Size(205, 22);
            RandomScreenRotation_TrollsDropDown.Text = "Random Screen Rotation";
            RandomScreenRotation_TrollsDropDown.Click += RandomScreenRotation_TrollsDropDown_Click;
            // 
            // rebootPToolStripMenuItem
            // 
            rebootPToolStripMenuItem.Name = "rebootPToolStripMenuItem";
            rebootPToolStripMenuItem.Size = new Size(205, 22);
            rebootPToolStripMenuItem.Text = "Reboot :P";
            rebootPToolStripMenuItem.Click += rebootPToolStripMenuItem_Click;
            // 
            // PanicScreen_Button
            // 
            PanicScreen_Button.Location = new Point(24, 52);
            PanicScreen_Button.Name = "PanicScreen_Button";
            PanicScreen_Button.Size = new Size(84, 55);
            PanicScreen_Button.TabIndex = 2;
            PanicScreen_Button.Text = "PanicScreen";
            PanicScreen_Button.UseVisualStyleBackColor = true;
            PanicScreen_Button.Click += PanicScreen_Click;
            // 
            // PanicClose_Button
            // 
            PanicClose_Button.Location = new Point(143, 52);
            PanicClose_Button.Name = "PanicClose_Button";
            PanicClose_Button.Size = new Size(84, 55);
            PanicClose_Button.TabIndex = 3;
            PanicClose_Button.Text = "PanicClose";
            PanicClose_Button.UseVisualStyleBackColor = true;
            PanicClose_Button.Click += PanicClose_Button_Click;
            // 
            // SuddenlyPineapples_Button
            // 
            SuddenlyPineapples_Button.Location = new Point(376, 302);
            SuddenlyPineapples_Button.Name = "SuddenlyPineapples_Button";
            SuddenlyPineapples_Button.Size = new Size(75, 40);
            SuddenlyPineapples_Button.TabIndex = 1;
            SuddenlyPineapples_Button.Text = "Suddenly Pineapples";
            SuddenlyPineapples_Button.UseVisualStyleBackColor = true;
            SuddenlyPineapples_Button.Click += SuddenlyPineapples_Button_Click;
            // 
            // StudentsRescue
            // 
            StudentsRescue.Controls.Add(PanicClose_Button);
            StudentsRescue.Controls.Add(PanicScreen_Button);
            StudentsRescue.Location = new Point(25, 65);
            StudentsRescue.Name = "StudentsRescue";
            StudentsRescue.Size = new Size(268, 142);
            StudentsRescue.TabIndex = 5;
            StudentsRescue.TabStop = false;
            StudentsRescue.Text = "Students Rescue";
            // 
            // JevilCapsTimer
            // 
            JevilCapsTimer.Tick += JevilCapsTimer_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(346, 141);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 225);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FunLauncherWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 441);
            Controls.Add(SuddenlyPineapples_Button);
            Controls.Add(pictureBox1);
            Controls.Add(StudentsRescue);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "FunLauncherWindow";
            ShowInTaskbar = false;
            Text = "Fun [WR] Launcher% -- 2d 15h";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            StudentsRescue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ToolsDropDown;
        private ToolStripMenuItem Notepad_ToolsDropDown;
        private ToolStripMenuItem CMD_Menu_ToolsDropDown;
        private ToolStripMenuItem CMD_Menu_CurrentPath_ToolsDropDown;
        private ToolStripMenuItem CMD_Menu_DriveC_ToolsDropDown;
        private ToolStripMenuItem InternetDropDown;
        private ToolStripMenuItem Edge_InternetDropDown;
        private ToolStripMenuItem TrollsDropDown;
        private ToolStripMenuItem RandomScreenRotation_TrollsDropDown;
        private ToolStripMenuItem Iexplore_InternetDropDown;
        private ToolStripMenuItem Chrome_InternetDropDown;
        private ToolStripMenuItem Firefox_InternetDropDown;
        private ToolStripMenuItem RotateScreen_Menu_ToolsDropDown;
        private ToolStripMenuItem RotateScreen_0D_ToolsDropDown;
        private ToolStripMenuItem RotateScreen_90D_ToolsDropDown;
        private ToolStripMenuItem RotateScreen_180D_ToolsDropDown;
        private ToolStripMenuItem RotateScreen_270D_ToolsDropDown;
        private Button PanicScreen_Button;
        private Button PanicClose_Button;
        private GroupBox StudentsRescue;
        private Button SuddenlyPineapples_Button;
        private System.Windows.Forms.Timer JevilCapsTimer;
        private ToolStripMenuItem rebootPToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}