using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2.Services
{
    internal interface ITaxService
    {
        double Tax(double initialAmount, int month);
    }
}
