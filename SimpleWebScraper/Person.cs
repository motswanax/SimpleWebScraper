using System;

namespace SimpleWebScraper
{
    class Person
    {
        string Id = "";
        string PasspordData = "Data";
        string DriversLicenseNumber = "More Data";
        string firstName = "Bad";
        string lastName = "Man";

        /* This property abstracts over the fields above, which are internal. */
        public bool HasProperDocuments { 
            get 
            {
                return Id.Length > 0 && PasspordData.Length > 0 && DriversLicenseNumber.Length > 0;
            } 
        }

        public string FirstName {
            get 
            {
                return firstName;
            }
            set 
            {
                if (value.Length < 1)
                {
                    Console.WriteLine("Input is not accepted. ");
                    return;
                }

                firstName = value;
            } 
        }
        public string LastName {
            get
            {
                return lastName;
            }
            set
            {
                if (value.Length < 1)
                {
                    Console.WriteLine("Input is not accepted. ");
                    return;
                }

                lastName = value;
            }
        }
    }
}
