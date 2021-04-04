using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTEQ.DTOPattern.EntityModel
{
    public class Customer1 : BaseEntity
    {
        public string IdentityNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
