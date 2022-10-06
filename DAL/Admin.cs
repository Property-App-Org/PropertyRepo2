using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Admin
    {
        public int AdminID { get; set; }
        public int PropertyID { get; set; }
        public int PropertyTypeID { get; set; }
        public int LocationID { get; set; }
        public int AgentID { get; set; }
        public int AgencyID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }
        
    }
   
}
