using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loupay_Service.Account
{
    public enum LoginResult : byte
    {
        DISABLED,
        SUCCESSFUL,
        FAILED
    }
}
