using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpireBuilder.Shared
{
    public class Upgrade
    {
        public string Name { get; set; }
        public int Cost { get; set; }
        public Action<User> ApplyEffect { get; set; }
    }
}
