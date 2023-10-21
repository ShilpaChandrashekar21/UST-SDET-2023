using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal interface IDoctor
    {
        public void AddNewDoctor(int dId, string? dname);
        public void ModifyDoctor(int dId, string? dname);
    }
}
