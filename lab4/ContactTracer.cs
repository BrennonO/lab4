// Author: Brennon Ouellette
// Date: March 21, 2022
// Description:
// This program is going to be used as contact tracking for new clients. It will save their first and last name, 
// email, phone number, and whether they have been contacted or not.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace lab4
{
    public partial class formContactTracer : Form
    {
        /// <summary>
        /// Constructor for the form! This is called once the form starts being loaded.
        /// </summary>
        public formContactTracer()
        {
            InitializeComponent();
            contactList = Contact.GenerateDefaultContacts();
            SetDefaults();
        }

        #region "Class-Level Variable Declarations"

        // Declaration for the list of Contact objects
        List<Contact> contactList = new List<Contact>();
        // A boolean variable that indicated whether changes are being made by the user.
        private bool isAutomated = false;

        #endregion

        /// <summary>
        /// Validate and attempt to either add or update a contact
        /// </summary>
        private void EnterClick(object sender, EventArgs e)
        {
            string firstName = textBoxFirst.Text.Trim();
            string lastName = textBoxLast.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string phone = textBoxPhone.Text.Trim();
            bool isContacted = checkBoxContacted.Checked;
            DateTime date = DateTime.Now;

            // Clear the field used for validation mesages and other outputs.
            textBoxOutput.Clear();

            // If everything is valid, we can try to add or update the contact.
            if (IsContactValid(firstName, lastName, email, phone))
            {
                // If there is NO contat selected...
                if (listViewEntries.FocusedItem == null)
                {
                    // Create the new contact.
                    Contact newContact = new Contact(isContacted, firstName, lastName, date, email, phone);
                    // Add the contact to the list.
                    contactList.Add(newContact);
                    // Clear all input fields.
                    SetDefaults();
                    // Write a message to the output/validation box thingie.
                    textBoxOutput.Text = "Added new contact: " + newContact.GetStatus();
                }

                // If there IS a contact already selected...
                else
                {
                    // Identify the current selected index.
                    int selectedIndex = listViewEntries.SelectedIndices[0];

                    // Change the selected contact's details.
                    contactList[selectedIndex].FirstName = firstName;
                    contactList[selectedIndex].LastName = lastName;
                    contactList[selectedIndex].Email = email;
                    contactList[selectedIndex].Phone = phone;
                    contactList[selectedIndex].Status = isContacted;

                    // Clear all input fields.
                    SetDefaults();

                    // Write a message to the output/validation box thingie.
                    textBoxOutput.Text = "Modified contact: " + firstName + " " + lastName + ". (" + DateTime.Now + ")";
                }
            }
        }

        /// <summary>
        /// Using SetDefaults() resets the form to its default state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetClick(object sender, EventArgs e)
        {
            SetDefaults();
        }

        /// <summary>
        /// Me close form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitClick(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// When a contact is selected in the listView Box is selected, write the information in the input controls/fields.
        /// </summary>
        private void ContactSelected(object sender, EventArgs e)
        {
            // If the LisitView Box is not empty and an item is focused
            if (listViewEntries.Items.Count > 0 && listViewEntries.FocusedItem != null)
            {
                // Updates the input controls with information once a contact is selected
                textBoxFirst.Text = listViewEntries.FocusedItem.SubItems[1].Text;
                textBoxLast.Text = listViewEntries.FocusedItem.SubItems[2].Text;
                textBoxEmail.Text = listViewEntries.FocusedItem.SubItems[4].Text;
                textBoxPhone.Text = listViewEntries.FocusedItem.SubItems[5].Text;

                // Updates the checkbox field once a car is selected
                checkBoxContacted.Checked = listViewEntries.FocusedItem.Checked;
            }
        }

        /// <summary>
        /// Makes sure the user cannot change the checkbox located in the Listview Box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PreventCheck(object sender, ItemCheckEventArgs e)
        {
            // Only prevent checking if it's being done by the user.
            if (!isAutomated)
            {
                // Change the new value of the checkbox equal to the old state of the checkbox.
                e.NewValue = e.CurrentValue;
            }
        }

        #region "Functions"

        /// <summary>
        /// Creates a new LitView item from a passed contact object parameter. Adds the list view item on the list view.
        /// </summary>
        /// <param name="newContact"> The Contact object to add</param>
        private void AddToListView(Contact newContact)
        {
            // User is adding to the list, allows the ability to change checkbox
            isAutomated = true;

            // Creates a new ListView Item
            ListViewItem contactItem = new ListViewItem();

            // Using the Contact object's get functions (accessors), fills in the ListView item's information.
            contactItem.Checked = newContact.Status;
            contactItem.SubItems.Add(newContact.FirstName);
            contactItem.SubItems.Add(newContact.LastName);
            contactItem.SubItems.Add(newContact.Date.ToString());
            contactItem.SubItems.Add(newContact.Email);
            contactItem.SubItems.Add(newContact.Phone);

            // Adds the Contact item into the ListView Box.
            listViewEntries.Items.Add(contactItem);
            listViewEntries.Refresh();

            // Sets isAutomated back to false, preventing user from changing checkboxes in ListView Box
            isAutomated = false;
        }

        private void SetDefaults()
        {
            // Reset fields to its default state
            listViewEntries.SelectedIndices.Clear();
            textBoxFirst.Clear();
            textBoxLast.Clear();
            textBoxEmail.Clear();
            textBoxPhone.Clear();
            checkBoxContacted.Checked = false;
            textBoxOutput.Clear();

            // Refresh all entries in the ListView.
            RefreshListView();

            // Sets focus back to the first input field, textBoxFirst
            textBoxFirst.Focus();
        }

        /// <summary>
        /// Empties the Listiew and fills it with all contacts.
        /// </summary>
        private void RefreshListView()
        {
            // Clear the ListView entirely
            listViewEntries.Items.Clear();

            foreach (Contact contactToAdd in contactList)
            {
                AddToListView(contactToAdd);
            }
        }

        /// <summary>
        /// This function will take seeral parameters related to a contact and return true if the are ALL valid, and false if ANY are invalid.
        /// </summary>
        /// <param name="firstNameValue">A first name</param>
        /// <param name="lastNameValue">A last name</param>
        /// <param name="emailValue">An email address</param>
        /// <param name="phoneValue">A phone number</param>
        /// <returns>True if valid, false if not</returns>
        private bool IsContactValid(string firstNameValue, string lastNameValue, string emailValue, string phoneValue)
        {
            bool isValid = true;

            // Validation for the first name
            if (firstNameValue == String.Empty)
            {
                textBoxOutput.Text += "The first name cannot be left empty." + Environment.NewLine;
                textBoxFirst.SelectAll();
                textBoxFirst.Focus();
                isValid = false;
            }
            // Validation for the last name
            if (lastNameValue == String.Empty)
            {
                textBoxOutput.Text += "The last name cannot be left empty." + Environment.NewLine;
                textBoxLast.SelectAll();
                textBoxLast.Focus();
                isValid = false;
            }
            // Validation for the email address.
            if (emailValue == String.Empty)
            {
                textBoxOutput.Text += "The email address cannot be left empty." + Environment.NewLine;
                textBoxEmail.SelectAll();
                textBoxEmail.Focus();
                isValid = false;
            }

            // This part uses Regular Expressions and will require "using System.Text.RegularExpressions;" at the top of your code file
            else if (!Regex.IsMatch(emailValue, "[A-Z0-9a-z._%+-]+@[A-Z0-9a-z0-9.-]+\\.[A-Za-z]{2,64}"))
            {
                textBoxOutput.Text += "The email address is not in a valid format." + Environment.NewLine;
                textBoxEmail.SelectAll();
                textBoxEmail.Focus();
                isValid = false;
            }
            // Validation for the phone number.
            if (phoneValue == String.Empty)
            {
                textBoxOutput.Text += "The phone number cannot be left empty." + Environment.NewLine;
                textBoxPhone.SelectAll();
                textBoxPhone.Focus();
                isValid = false;
            }
            else if (!Regex.IsMatch(phoneValue, "[0-9()-]{10,11}"))
            {
                textBoxOutput.Text += "The phone number is not in a valid format." + Environment.NewLine;
                textBoxPhone.SelectAll();
                textBoxPhone.Focus();
                isValid = false;
            }

            return isValid;
        }
        #endregion
    }
}

