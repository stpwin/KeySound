using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KeySound
{
    public class Poller
    {
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        private IOnHotkeyPressed onHotkeyPressed;
        //private Keys hotKey = Keys.None;

        public Poller(IOnHotkeyPressed onHotkeyPressed)
        {
            this.onHotkeyPressed = onHotkeyPressed;
        }

        public void Poll(Keys key)
        {
            //this.hotKey = key;

            short gaks = GetAsyncKeyState(key);
            if ((gaks & 0b10000000_00000000) > 0)
            {
                Helpers.WaitUntilTimeoutWhileTrue(() => (GetAsyncKeyState(key) & 0b10000000_00000000) > 0, 100);
                this.onHotkeyPressed.OnPressed();
            }
        }

    }
}
