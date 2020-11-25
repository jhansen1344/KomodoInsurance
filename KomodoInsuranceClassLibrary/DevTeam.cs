using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceClassLibrary
{
    public class DevTeam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Developer> Developers { get; set; }
    }
}
