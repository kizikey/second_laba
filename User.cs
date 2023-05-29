using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Delivery_Address { get; set; }
        public string Birth { get; set; }
        public string First_Delivery_Date { get; set; }



        public User()
        { }
        public User(string Login, string Password, string Email, string Phone, string Name, string LastName, string Delivery_Address, string Birth, string First_Delivery_Date)
        {
            this.Login = Login;
            this.Password = Password;
            this.Email = Email;
            this.Birth = Birth;
            this.Delivery_Address = Delivery_Address;
            this.Name = Name;
            this.LastName = LastName;
            this.Phone = Phone;
            this.First_Delivery_Date = First_Delivery_Date;
        }

    }
}