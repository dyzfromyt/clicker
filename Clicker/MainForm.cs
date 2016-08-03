using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace Clicker
{
    public partial class MainForm : Form
    {
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        [DllImport("kernel32.dll", EntryPoint = "Beep")]
        public static extern int Beep(int dwFreq, int dwDuration);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);

        public MainForm()
        {
            InitializeComponent();
            timeDisplay = currentTime;
            var now = DateTime.Now;

            hourInput.Value = now.Hour;
            minuteInput.Value = now.Minute;
            secondInput.Value = now.Second;
        }

        private static TextBox timeDisplay;

        private static Thread clickerThread;
        private static void Clicker(object targetDateTimeObject)
        {
            var targetDateTime = (DateTime)targetDateTimeObject;

            var now = DateTime.Now;

            while (now < targetDateTime)
            {
                now = DateTime.Now;
                timeDisplay.Invoke((MethodInvoker)delegate
                {
                    timeDisplay.Text = now.ToString();
                });

                Thread.Sleep(1);
            }

            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            Beep(600, 1000);

            clickerThread = null;
        }

        private void readyButton_Click(object sender, EventArgs e)
        {
            var hour = (int)hourInput.Value;
            var minute = (int)minuteInput.Value;
            var second = (int)secondInput.Value;
            var milisecond = (int)msInput.Value;

            var now = DateTime.Now;
            var year = now.Year;
            var month = now.Month;
            var day = now.Day;

            var targetDateTime = new DateTime(year, month, day, hour, minute, second, milisecond);

            clickerThread = new Thread(Clicker);
            clickerThread.Start(targetDateTime);

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(clickerThread != null)
            {
                clickerThread.Abort();
                clickerThread = null;
            }
        }
    }
}
