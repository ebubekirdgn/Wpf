using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using System.Windows.Threading;

namespace KutuhaneTakipPro.classlar
{
    public class bonus
    {
        public static void sescal()
        {
            MediaPlayer mplayer = new MediaPlayer();
            mplayer.Open(new Uri("fu.wav", UriKind.Relative));
        }

        //PopUp Çağırma
        public static void showPopup(Popup popup)
        {
            sescal();

            popup.IsOpen = true;

            DispatcherTimer timer = new DispatcherTimer()
            {
                Interval = TimeSpan.FromSeconds(5)
            };

            timer.Tick += delegate (object sender, EventArgs e)
            {
                ((DispatcherTimer)timer).Stop();
                if (popup.IsOpen) sescal(); popup.IsOpen = false;
            };

            timer.Start();

        }
    }
}
