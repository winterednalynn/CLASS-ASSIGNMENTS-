using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClassLecture5
{
   public  class Customer
    {
        //FIELDS
        string firstName;
        string lastName;
        string contactNumber;
        string LocationAddress;

        //CONSTRUCTOR : 
        public Customer(string firstName, string lastName, string contactNumber, string locationAddress)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.contactNumber = contactNumber;
            LocationAddress = locationAddress;
        }
        //PROPERTY 
        public string FirstName //Property syntax for firstName 
        {
            get
            {
                return FirstName; //Getter: Read only for user 
            }
            set // Setter: Write access for user 
            {
                if (value != "") // A user gives value to first Name 
                {
                    firstName = value; //Value = being assigned by user 
                }
                else // if no value is given , a message box will prompt . 
                {
                    MessageBox.Show("Please enter a valid name");
   
                }

                
            }
        }
        public string LastName //Property syntax for lastName 
        {
            get
            {
                return lastName;

            }
            set
            {
                if(value != "")
                {
                    LastName = value; 
                }
                else // if no value is given , a message box will prompt.
                {
                    MessageBox.Show("Please enter a valid name");
                }
            }
        }
        public string ContactNumber //Property syntax for ContactNumber
        {
            get
            {
                return contactNumber;
            }
         
        }
        public string locationAddress //Property syntax for location address 
        {
            get
            {
                return locationAddress; 
            }
        }

    }
 
}
