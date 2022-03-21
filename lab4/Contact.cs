using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Contact
    {
        #region "Variable Declarations"
        // Variables are declared representing the variables for each contact
        // All of them are private so tehy can't be modified by another class.
        private bool contactStatus;
        private string contactFirstName;
        private string contactLastName;
        private DateTime contactDate;
        private string contactEmail;
        private string contactPhoneNumber;
        #endregion

        #region "Long-Hand Properties"
        // Although a short-hand way of doing this exists in C#,
        // this is being done in the longer way in order to better
        // demonstrate the way properties in a class/object can be
        // used to modify private values within an object.
        /// <summary>
        /// A boolean value indicating whether the person has been contacted or not.
        /// </summary>
        public Boolean Status
        {
            get
            {
                return contactStatus;
            }
            set
            {
                contactStatus = value;
            }
        }
        /// <summary>
        /// The contact's first name.
        /// </summary>
        public String FirstName
        {
            get
            {
                return contactFirstName;
            }
            set
            {
                contactFirstName = value;
            }
        }
        /// <summary>
        /// The contact's last name.
        /// </summary>
        public String LastName
        {
            get
            {
                return contactLastName;
            }
            set
            {
                contactLastName = value;
            }
        }
        /// <summary>
        /// The date that the contact was entered.
        /// </summary>
        public DateTime Date
        {
            get
            {
                return contactDate;
            }
            set
            {
                contactDate = value;
            }
        }
        /// <summary>
        /// The contact's email address. In this case, validation will be handled by the form.
        /// </summary>
        public String Email
        {
            get
            {
                return contactEmail;
            }
            set
            {
                contactEmail = value;
            }
        }
        /// <summary>
        /// The contact's phone number. The validation is not done here, but rather on the form.
        /// </summary>
        public String Phone
        {
            get
            {
                return contactPhoneNumber;
            }
            set
            {
                contactPhoneNumber = value;
            }
        }
        #endregion

        #region "Constructors"

        /// <summary>
        /// Default contructor for a contact.
        /// </summary>
        public Contact()
        {
        }

        public Contact(Boolean statusValue, String firstNameValue, String lastNameValue, DateTime dateValue, String emailValue, String phoneValue)
        {
            contactStatus = statusValue;
            contactFirstName = firstNameValue;
            contactLastName = lastNameValue;
            contactDate = dateValue;
            contactEmail = emailValue;
            contactPhoneNumber = phoneValue;
        }
        #endregion

        #region "Methods"

        public static List<Contact> GenerateDefaultContacts()
        {
            List<Contact> returnContacts = new List<Contact>();

            returnContacts.Add(new Contact(false, "Brennon", "Ouellette", new DateTime(2021, 08, 08), 
                "brennon.ouellette@dcmail.ca", "9054235464"));

            return returnContacts;
        }

        /// <summary>
        /// A string representing the customerr, including their names, Date and ContactStatus
        /// </summary>
        /// <returns>A string representing this status</returns>
        public string GetStatus()
        {
            //If this person has been contacted, return a string that indicated this.
            if(contactStatus)
            {
                return FirstName + " " + LastName + " entered on " + Date + " has been contacted";
            }
            // If they havent been conatcted, return this different string instead
            else
            {
                return FirstName + " " + LastName + " entered on " + Date + " has not been contacted";
            }
        }
        #endregion
    }
}
