using System;

namespace SimpleWebScraper
{
    class Person
    {
        string Id;
        string PassportData;
        string DriversLicenseNumber;

        public Person(string id, string passportData, string driverLicenseNumber)
        {
            Id = id;
            PassportData = passportData;
            DriversLicenseNumber = driverLicenseNumber;
        }

        /* This property abstracts over the fields above, which are internal. */
        public bool HasProperDocuments { 
            get 
            {
                return Id.Length > 0 && PassportData.Length > 0 && DriversLicenseNumber.Length > 0;
            } 
        }
    }
}
