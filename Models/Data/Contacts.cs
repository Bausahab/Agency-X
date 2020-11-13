using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Data
{
   public class Contacts
    {
        public int Id { get; set; }
        public string ContactName { get; set; }
        public string ContactNumber { get; set; }
        public string ContactAddress { get; set; }
        public string ContactDetails { get; set; }
        public string GSTN { get; set; }
        public Logic.ContactType ContactType { get; set; }
    }
}
