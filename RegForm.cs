﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        public LoginForm login_form;

        private void reg_button_Click(object sender, EventArgs e)
        {
            using (UserContext db = new UserContext())
            {
                string created = (First_Delivery_Date.Value).ToString();
                string birth = (birthPicker.Value).ToString();
                string password = login_form.GetHashString(passwordBox.Text);
                User user = new User(loginBox.Text, password, emailBox.Text,
                    phoneBox.Text, nameBox.Text, lastnameBox.Text, delivery_address_box.Text, birth, created);
                db.Users.Add(user);
                db.SaveChanges();
                this.Close();
                ProfileForm profile_form = new ProfileForm();
                profile_form.Login(user.Login, user.LastName, user.Name, user.Phone, user.Email, user.Birth,
                    user.Delivery_Address, user.First_Delivery_Date);
                profile_form.Show();
                profile_form.login_form = this.login_form;
                this.Close();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
