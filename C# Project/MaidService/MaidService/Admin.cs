using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace MaidService
{
   public class Admin:Common
    {

        public Admin() { }
        public Admin(string username, string name) : base(username, name)
        {

        }
        public Admin(DataSet admin)
        {
            try
            {
                base.Username = admin.Tables[0].Rows[0][0].ToString();
                base.Name = admin.Tables[0].Rows[0][1].ToString();


            }
            catch (Exception)
            {
                MessageBox.Show("Coudn't get Information");
            }
        }
    }
}

