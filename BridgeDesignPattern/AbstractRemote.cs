using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    public abstract class AbstractRemote
    {
        protected ILEDTV ledTv;

        protected AbstractRemote(ILEDTV ledTv)
        {
            this.ledTv = ledTv;
        }

        public abstract void SwitchOn();
        public abstract void SwitchOff();
        public abstract void SetChannel(int channelNumber);
    }
}
