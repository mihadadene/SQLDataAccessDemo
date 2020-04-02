﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Dashboard : Form
    {
        List<Person> people = new List<Person>();

        public Dashboard()
        {
            InitializeComponent();

            UpdateBinding();
        }

        private void UpdateBinding()
        {
            peopleFoundListBox.DataSource = people;
            peopleFoundListBox.DisplayMember = "FullInfo";
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
              DataAccess db = new DataAccess();

              people =  db.GetPeople(lastNameText.Text);
          
              UpdateBinding();
        }

        private void selectAllPeopleButton_Click(object sender, EventArgs e)
        {
            
            DataAccess db = new DataAccess();

            people =  db.GetAllPeople();          
           
            UpdateBinding();
        }

        private void selectAllPerson_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            people =  db.GetAllPeople();          
           
            UpdateBinding();
        }

        private void insertRecordButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.InsertPerson(firstNameInsText.Text, lastNameInsText.Text, emailAddressInsText.Text, phoneNumberInsText.Text);
            firstNameInsText.Text = "";
            lastNameInsText.Text = "";
            emailAddressInsText.Text = "";
            phoneNumberInsText.Text = "";
        }

        private void deleteRecordButton_Click(object sender, EventArgs e)
        {
              DataAccess db = new DataAccess();

            db.DeletePerson(lastNameText.Text);
            lastNameText.Text = "";
            //lastNameInsText.Text = "";
            //emailAddressInsText.Text = "";
            //phoneNumberInsText.Text = "";
        }               
    }
}
