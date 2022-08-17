using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    public class SonyRemoteControl : AbstractRemote
    {
        public SonyRemoteControl(ILEDTV ledTv) : base(ledTv)
        {
        }
        public override void SetChannel(int channelNumber)
        {
           ledTv.SetChannel(channelNumber);
        }

        public override void SwitchOff()
        {
            ledTv.SwitchOff();
        }

        public override void SwitchOn()
        {
            ledTv.SwitchOff();
        }
    }
}
