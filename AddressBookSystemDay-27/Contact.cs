﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystemDay_27
{
    class Contact
    {
        public String firstName, lastName, address, city, state, emailId;
        public long phoneNumber, pinCode;
        public void SaveContact(string firstName, string lastName, string address, string city, string state, string emailId, long phoneNumber, long pinCode)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.emailId = emailId;
            this.phoneNumber = phoneNumber;
            this.pinCode = pinCode;
        }
        public override bool Equals(object obj)
        {
            Contact contact = (Contact)obj;
            if (contact == null)
                return false;
            else
                return firstName.Equals(contact.firstName) && lastName.Equals(contact.lastName);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(firstName, lastName);
        }
        public override string ToString()
        {
            return "First Name :" + firstName + "\nLast Name : " + lastName + "\nCity : " + city + "\nState : " + state + "\nEmail : " + emailId + "\nPhone Number : " + phoneNumber + "\nPin COde" + pinCode;
        }
    }
}



