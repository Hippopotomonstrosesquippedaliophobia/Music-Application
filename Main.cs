using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Player
{
    public partial class Main : Form
    {
        //Mouse drag of window
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        // Minimize from taskbar behaviour
        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;

        // Windows snapping 
        private const int SnapDist = 1;

        // Maximize window 
        private Point old_loc = new Point(0, 0);
        private Size old_size = new Size(1207, 688);

        public bool maximized = false;

        public Main()
        {
            InitializeComponent();
        }

        // Allows form to be dragged around
        private void topBar_MouseDown(object sender, MouseEventArgs e)
        { 
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            } 
        }

        // Minimize form
        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Minimize behaviour for window
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }

        //Maximize window
        private void maximize_Click(object sender, EventArgs e)
        {
            MaxWindow();
        }

        private void MaxWindow()
        { 
            // If window maximized, then do this
            if (maximized)
            {
                //this.WindowState = FormWindowState.Normal;
                maximized = false;
                maximize.Text = "1";
                this.Location = old_loc;
                this.Size = old_size;
            }
            else // maximize it
            {
                // store original dimensions
                old_size = new Size(this.Width, this.Height);
                old_loc = new Point(this.Location.X, this.Location.Y);

                // Maximize
                maximized = true;
                maximize.Text = "2";
                int x = SystemInformation.WorkingArea.Width;
                int y = SystemInformation.WorkingArea.Height;
                this.WindowState = FormWindowState.Normal;
                this.Location = new Point(0, 0);
                this.Size = new Size(x, y);
            }
        }

        private bool DoSnap(int pos, int edge)
        {
            int delta = pos - edge;
            return delta <= SnapDist;
        }

        protected override void OnResizeEnd(EventArgs e)
        {
            base.OnResizeEnd(e);
            Screen scn = Screen.FromPoint(this.Location); 

            if (DoSnap(this.Left, scn.WorkingArea.Left)) this.Left = scn.WorkingArea.Left;
            if (DoSnap(this.Top, scn.WorkingArea.Top))
            {
                MaxWindow();
            }
            else
            {
                if (maximized)
                {
                    old_loc.Y = MousePosition.Y;
                    MaxWindow();
                }
            }
            if (DoSnap(scn.WorkingArea.Right, this.Right)) this.Left = scn.WorkingArea.Right - this.Width;
            if (DoSnap(scn.WorkingArea.Bottom, this.Bottom)) this.Top = scn.WorkingArea.Bottom - this.Height;
        }

        // Close Application
        private void close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
          
    }
}
