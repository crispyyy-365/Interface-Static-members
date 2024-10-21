using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code.homework1
{
    internal interface ICodeAcademy
    {
        string CodeEmail { get; }
        string GenerateEmail();
    }
}
