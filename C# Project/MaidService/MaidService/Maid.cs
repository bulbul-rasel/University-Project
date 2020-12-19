using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace MaidService
{
    public class Maid:Common
    {
        public string WorkType { get; set; }
        public string WorkingHours { get; set; }
        public string Salary { get; set; }
        public Maid()
        { }
        public Maid(string username, string name, string nid, string email, string gender, string phone, string address,string question, string answer,string worktype,string workinghours,string salary) : base(username, name, nid, email, gender, phone, address,question,answer)
        {
            this.WorkType = worktype;
            this.WorkingHours = workinghours;
            this.Salary = salary;
        }
        public Maid(DataSet maid)
        {
            try
            {
                base.Username = maid.Tables[0].Rows[0][0].ToString();
                base.Name = maid.Tables[0].Rows[0][1].ToString();
                base.Nid = maid.Tables[0].Rows[0][2].ToString();
                base.Email = maid.Tables[0].Rows[0][3].ToString();
                base.Gender = maid.Tables[0].Rows[0][4].ToString();
                base.Phone = maid.Tables[0].Rows[0][5].ToString();
                this.WorkType = maid.Tables[0].Rows[0][7].ToString();
                this.WorkingHours = maid.Tables[0].Rows[0][8].ToString();
                this.Salary = maid.Tables[0].Rows[0][9].ToString();
                base.Address = maid.Tables[0].Rows[0][10].ToString();
                base.Question = maid.Tables[0].Rows[0][11].ToString();
                base.Answer = maid.Tables[0].Rows[0][12].ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Coudn't get Information");
            }
        }
    }
}
