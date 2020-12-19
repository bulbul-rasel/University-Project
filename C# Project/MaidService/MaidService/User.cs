using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace MaidService
{
   public class User:Common
    {
        public User()
        { }
        public User(string username, string name, string nid, string email, string gender, string phone, string address,string question,string answer):base(username,name,nid,email,gender,phone,address,question,answer)
        {

        }
        public User(DataSet user)
        {
            try
            {
                base.Username = user.Tables[0].Rows[0][0].ToString();
                base.Name = user.Tables[0].Rows[0][1].ToString();
                base.Nid = user.Tables[0].Rows[0][2].ToString();
                base.Email = user.Tables[0].Rows[0][3].ToString();
                base.Gender = user.Tables[0].Rows[0][4].ToString();
                base.Phone = user.Tables[0].Rows[0][5].ToString();
                base.Address = user.Tables[0].Rows[0][7].ToString();
                base.Question = user.Tables[0].Rows[0][8].ToString();
                base.Answer = user.Tables[0].Rows[0][9].ToString();
                

            }
            catch (Exception)
            {
                MessageBox.Show("Coudn't get Information");
            }
        }
    }
}
