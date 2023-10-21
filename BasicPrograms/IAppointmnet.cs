using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal interface IAppointmnet
    {
        void BookAppointment(int did, string? pname);
        void DeleteAppointment(string? pname);
    }
}
