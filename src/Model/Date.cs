using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsDesktopClock.src.Model
{
    public class Date : BindableBase
    {
        private DateTime _Datetime { get; set; }
        private string _DatetimeStr;

        public string DateTime
        {
            get { return this._DatetimeStr; }
            set { this.SetProperty(ref this._DatetimeStr, value); }
        }

        public void update()
        {
            _Datetime = System.DateTime.Now;
            _DatetimeStr = _Datetime.ToString();
        }
    }
}
