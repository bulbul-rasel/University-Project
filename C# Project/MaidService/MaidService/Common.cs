using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaidService
{
    public class Common
    {
        private string username;
        private string name;
        private string nid;
        private string email;
        private string gender;
        private string phone;
        private string address;
        private string question;
        private string answer;

        public Common()
        {
        }
        //admin
        public Common(string username, string name)
        {
            this.Username = username;
            this.Name = name;
        }
        //maid and user
        public Common(string username,string name,string nid,string email,string gender, string phone, string address,string question,string answer)
        {
            this.Username = username;
            this.Name = name;
            this.Nid = nid;
            this.Email = email;
            this.Gender = gender;
            this.Phone = phone;
            this.Address = address;
            this.Question = question;
            this.Answer = answer;
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Nid
        {
            get { return nid; }
            set { nid = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Question
        {
            get { return question; }
            set { question = value; }
        }
        public string Answer
        {
            get { return answer; }
            set { answer = value; }
        }
    }
}
