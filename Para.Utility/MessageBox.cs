using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Para.Utility
{
    public class MessageBox
    {
        public MessageType Type { get; set; }
        public string MessageTitle { get; set; }
        public Object Entity { get; set; }
    }
}
