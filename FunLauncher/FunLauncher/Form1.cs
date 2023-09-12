using System.Diagnostics;
using System.Media;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading;
using System.Windows.Forms;
//using System.Security.Permissions;




namespace FunLauncher
{
    public partial class FunLauncherWindow : Form
    {
        //Keyboard Manipulation
        [DllImport("user32.dll", SetLastError = true)]
        static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);
        public const int KEYEVENTF_KEYDOWN = 0x0000; // New definition
        public const int KEYEVENTF_EXTENDEDKEY = 0x0001; //Key down flag
        public const int KEYEVENTF_KEYUP = 0x0002; //Key up flag

        //Launching Programms
        public void ExecuteCommand(string Command, string Arguments = "", string Path = "", bool ShellExecute = true)
        {
            ProcessStartInfo ProcessInfo = new ProcessStartInfo(Command);

            if (Path != "")
            {
                ProcessInfo.WorkingDirectory = Path;
            }
            if (Arguments != "")
            {
                ProcessInfo.Arguments = Arguments;
            }
            ProcessInfo.CreateNoWindow = true;
            ProcessInfo.UseShellExecute = ShellExecute;

            //Process Process =
            Process.Start(ProcessInfo);
        }

        public void ToggleCapsLock()
        {
            const int KEYEVENTF_EXTENDEDKEY = 0x1;
            int KEYEVENTF_KEYUP = 0x2;
            keybd_event(0x14, 0x45, KEYEVENTF_EXTENDEDKEY, 0);
            keybd_event(0x14, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
        }

        public FunLauncherWindow()
        {
            InitializeComponent();
        }

        private void Edge_InternetDropDown_Click(object sender, EventArgs e)
        {
            ExecuteCommand("msedge");
        }

        private void Notepad_ToolsDropDown_Click(object sender, EventArgs e)
        {
            ExecuteCommand("Notepad.exe");
        }

        private void CMD_Menu_CurrentPath_ToolsDropDown_Click(object sender, EventArgs e)
        {
            ExecuteCommand("cmd");
        }

        private void CMD_Menu_DriveC_ToolsDropDown_Click(object sender, EventArgs e)
        {
            ExecuteCommand("cmd", "", @"C:\");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToggleCapsLock();
        }

        private void Iexplore_InternetDropDown_Click(object sender, EventArgs e)
        {
            ExecuteCommand("iexplore");
        }

        private void Chrome_InternetDropDown_Click(object sender, EventArgs e)
        {
            ExecuteCommand("chrome");
        }

        private void Firefox_InternetDropDown_Click(object sender, EventArgs e)
        {
            ExecuteCommand("firefox");
        }

        private void RotateScreen_0D_ToolsDropDown_Click(object sender, EventArgs e)
        {
            ExecuteCommand("display64.exe", "/rotate 0", "", false);
        }

        private void RotateScreen_90D_ToolsDropDown_Click(object sender, EventArgs e)
        {
            ExecuteCommand("display64.exe", "/rotate 90", "", false);
        }

        private void RotateScreen_180D_ToolsDropDown_Click(object sender, EventArgs e)
        {
            ExecuteCommand("display64.exe", "/rotate 180", "", false);
        }

        private void RotateScreen_270D_ToolsDropDown_Click(object sender, EventArgs e)
        {
            ExecuteCommand("display64.exe", "/rotate 270", "", false);
        }

        private void RandomScreenRotation_TrollsDropDown_Click(object sender, EventArgs e)
        {
            //Actually Make Random be Random (Kinda)
            Random random = new Random();
            int randomize = random.Next(0, 1024);
            for (int i = 0; i < randomize; i++)
            {
                random.Next(0, 64);
            }

            //Use the Random Value
            switch (random.Next(0, 4))
            {
                case 0:
                    ExecuteCommand("display64.exe", "/rotate 0");
                    break;
                case 1:
                    ExecuteCommand("display64.exe", "/rotate 90");
                    break;
                case 2:
                    ExecuteCommand("display64.exe", "/rotate 180");
                    break;
                case 3:
                    ExecuteCommand("display64.exe", "/rotate 270");
                    break;
                default:
                    break;
            }
        }

        private void PanicScreen_Click(object sender, EventArgs e)
        {
            ExecuteCommand("display64.exe", "/power off");
        }

        private void PanicClose_Button_Click(object sender, EventArgs e)
        {
            Process me = Process.GetCurrentProcess();
            foreach (Process p in Process.GetProcesses())
            {
                if (p.Id != me.Id && IntPtr.Zero != p.MainWindowHandle && false == p.ProcessName.Equals("explorer", StringComparison.CurrentCultureIgnoreCase))
                {
                    // Sends WM_CLOSE; less gentle methods available too.
                    //p.CloseMainWindow();
                    p.Kill();
                }
            }
            me.Kill();
        }

        private void PlayAudio_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"chaos.wav");
            player.Play();
        }


        private void SuddenlyPineapples_Button_Click(object sender, EventArgs e)
        {
            SuddenlyPineapples_Button.Enabled = false;

            Random random = new Random();
            int randomize = random.Next(0, 1024);
            for (int i = 0; i < randomize; i++)
            {
                random.Next(0, 64);
            }

            if (random.Next(0, 2) == 0)
            {
                JevilCapsTimer.Start();
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"chaos.wav");
                player.PlayLooping();
            }
            else
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"spam.wav");
                player.PlayLooping();
                CreateForm();
            }

        }

        private void JevilCapsTimer_Tick(object sender, EventArgs e)
        {
            ToggleCapsLock();
            Random random = new Random();
            int randomize = random.Next(0, 1024);
            for (int i = 0; i < randomize; i++)
            {
                random.Next(0, 64);
            }
            JevilCapsTimer.Interval = random.Next(100, 500);
        }

        private void AutoReboot_Button_Click(object sender, EventArgs e)
        {
            ExecuteCommand("cmd", "/K \"echo shutdown /s /t 120 /c \"Test\" /f > test.bat\"", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Windows\\Start Menu\\Programs\\Startup", false);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }


        private void CreateForm()
        {
            Random random = new Random();

            /*using (Form form = new Form())
            {
                Bitmap img = new Bitmap("testImg.bmp");

                form.ClientSize = img.Size;

                //PictureBox pb = new PictureBox();
                //pb.Dock = DockStyle.Fill;
                //pb.Image = img;
                //pb.WaitOnLoad = false;

                form.Controls.Add(pb);
                form.Show(this);
                
                
                
                Thread.Sleep(500);
                CreateForm();
            }*/

            Form2 form = new Form2();

            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(random.Next(0, 2000), random.Next(0, 2000));

            form.Show();

            //if(random.Next()>1700)
            //    ExecuteCommand("Notepad.exe");
            //Thread.Sleep(1000);
            CreateForm();


        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            Process.Start("FunLauncher.exe");

            //Form2 form = new Form2();
            //form.ShowDialog();
        }

        private void rebootPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecuteCommand("cmd", "/K \"echo shutdown /s /t 120 /c \":P\" /f > test.bat\"", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Windows\\Start Menu\\Programs\\Startup", false);
            //shutdown /a
        }
    }
}