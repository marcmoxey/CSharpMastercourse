using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class FullEmployerModel
    {
        public EmployerModel BasicInfo { get; set; }
        public List<AddressModel> Addresses { get; set; } = new List<AddressModel>();
    }
}
