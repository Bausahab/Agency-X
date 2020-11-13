using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Data
{
   public class Users
    {
        public int ID { get; set; }
        public int Limit { get; set; }
        public string UserName { get; set; }

        [Category("Security")]
        [PasswordPropertyText(true)]
        public string UserPassword { get; set; }
    }
}
