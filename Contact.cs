using System;

namespace AddressBook
{
    class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string FullName()
        {
            return FirstName + " " + LastName;
        }

        // public Contact(string FName, string LName, string Email1, string Adress1)
        //         {
        //             FirstName = FName;
        //             LastName = LName;
        //             Email = Email1;
        //             Address = Adress1;

        //         }

    }
}
