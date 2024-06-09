using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppViewData10._8.Interface
{
    internal interface IChangeControl
    {
        ChangeControlClientBD InfoControlChange(string dataChange, string typeChange, string whoChange);
    }
}
