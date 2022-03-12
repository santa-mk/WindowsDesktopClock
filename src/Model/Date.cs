using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsDesktopClock.src.Model
{
    public class Date : BindableBase
    {
        private string _DatetimeStr = "";

        public string DateTime
        {
            get { return this._DatetimeStr; }
            set { this.SetProperty(ref this._DatetimeStr, value); }
        }

        public void update()
        {
            DateTime = System.DateTime.Now.ToString();
        }
    }
}
