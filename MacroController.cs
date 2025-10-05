
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WinFormsApp
{
    public class MacroController
    {
        private System.Windows.Forms.Timer fireTimer;
        private bool isMacroEnabled;
        private int recoilIndex;
        private Dictionary<string, int[]> weaponRecoils;
        private string selectedWeapon;

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        private const int VK_LBUTTON = 0x01;
        private const int MOUSEEVENTF_MOVE = 0x0001;
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        public MacroController(Dictionary<string, int[]> recoils)
        {
            weaponRecoils = recoils;
            selectedWeapon = string.Empty;
            fireTimer = new System.Windows.Forms.Timer();
            fireTimer.Interval = 10;
            fireTimer.Tick += FireTimer_Tick;
        }

        public void Start()
        {
            if (!isMacroEnabled)
            {
                isMacroEnabled = true;
                recoilIndex = 0;
                fireTimer.Start();
            }
        }

        public void Stop()
        {
            isMacroEnabled = false;
            fireTimer.Stop();
            SimulateMouseRelease();
        }

        public void SetWeapon(string weapon)
        {
            selectedWeapon = weapon;
        }

        private void FireTimer_Tick(object? sender, EventArgs e)
        {
            if (GetAsyncKeyState(VK_LBUTTON) < 0)
            {
                SimulateMouseHold();
                ApplyRecoil();
            }
            else
            {
                SimulateMouseRelease();
            }
        }

        private void SimulateMouseHold()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
        }

        private void SimulateMouseRelease()
        {
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }

        private void ApplyRecoil()
        {
            if (selectedWeapon != null && weaponRecoils.ContainsKey(selectedWeapon))
            {
                int[] recoilPattern = weaponRecoils[selectedWeapon];
                if (recoilIndex < recoilPattern.Length)
                {
                    mouse_event(MOUSEEVENTF_MOVE, 0, (uint)recoilPattern[recoilIndex], 0, 0);
                    recoilIndex++;
                }
                else
                {
                    recoilIndex = 0;
                }
            }
        }
    }
}
