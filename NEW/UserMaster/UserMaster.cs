using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NEW.UserMaster
{
    public class UserMaster 
    {

        public int UserMasterAutoId { get; set; }
        public string UserName { get; set; }    

        public string IndentityNo { get; set; }
        public string Address { get; set; }

        public int ContactNo { get; set; }
        public string UserType { get; set; }
        public char ActiveStatus { get; set; }
        public DateTime CreatedDate { get; set; }

        public Guid UniqueId { get; set; }
    } 
}
