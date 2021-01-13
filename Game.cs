using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_8_Delegates_Events_Lambda
{
    class Game
    {
        public delegate void delegate_drive();
        public event delegate_drive event_drive;

        public delegate void delegate_show_info();
        public event delegate_drive event_info;

        public void Drive_dispetcher()
        {
            event_drive();
        }
        public void Show_info_dispetcher()
        {
            event_info();
        }
    }
}
