using AspNetVue.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetVue.Models
{
    public class ProfileVM
    {
        private string[] ELEMENT_NAME = { "Home", "People", "Wolrd" };

        private List<SecurityItem> profile;
        private List<SecurityItem> course;
        private List<SecurityItem> rewards;
        private List<SecurityItem> contactDetails;

        public List<SecurityItem> Profile
        {
            get { return profile; }
        }

        public List<SecurityItem> Course
        {
            get { return course; }
        }

        public List<SecurityItem> Rewards
        {
            get { return rewards; }
        }

        public List<SecurityItem> ContactDetails
        {
            get { return contactDetails; }
        }


        public ProfileVM()
        {
            InitLists();
        }

        private void InitLists()
        {
            profile = new List<SecurityItem>()
            {
                new SecurityItem(){ Name= ELEMENT_NAME[0], IsChecked = true},
                new SecurityItem(){ Name= ELEMENT_NAME[1], IsChecked = true},
                new SecurityItem(){ Name= ELEMENT_NAME[2], IsChecked = true}
            };

            course = new List<SecurityItem>(){
                new SecurityItem(){ Name= ELEMENT_NAME[0], IsChecked = false},
                new SecurityItem(){ Name= ELEMENT_NAME[1], IsChecked = true},
                new SecurityItem(){ Name= ELEMENT_NAME[2], IsChecked = false}
            };

            rewards = new List<SecurityItem>(){
                new SecurityItem(){ Name= ELEMENT_NAME[0], IsChecked = false},
                new SecurityItem(){ Name= ELEMENT_NAME[1], IsChecked = true},
                new SecurityItem(){ Name= ELEMENT_NAME[2], IsChecked = true}
            };
            contactDetails = new List<SecurityItem>(){
                new SecurityItem(){ Name= ELEMENT_NAME[0], IsChecked = false},
                new SecurityItem(){ Name= ELEMENT_NAME[1], IsChecked = false},
                new SecurityItem(){ Name= ELEMENT_NAME[2], IsChecked = false}
            };
        }
    }
}