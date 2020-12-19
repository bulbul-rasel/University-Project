using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaidService
{
    public class Role : Common
    {
        public string Password { get; set; }
        public string Status { get; set; }
        public Role()
        {

        }
        public Role(DataSet Login)
        {

            try
            {
                base.Username = Login.Tables[0].Rows[0][0].ToString();
                this.Password = Login.Tables[0].Rows[0][1].ToString();
                this.Status = Login.Tables[0].Rows[0][2].ToString();


            }
            catch { }
        }
    }
}
