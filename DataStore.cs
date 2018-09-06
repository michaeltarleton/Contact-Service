using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Contact_Service.CommonModels;

namespace Contact_Service
{
    public static class DataStore
    {
        private static IEnumerable<Contact> CONTACTS = new List<Contact>
        {
            new Contact { Id = 1, FirstName = "Sam", LastName = "Dalton", Email = "sam.dalton@msn.com", PhoneNumber = "555-555-1234" },
            new Contact { Id = 2, FirstName = "Sam", LastName = "Dalton", Email = "sam.dalton@msn.com", PhoneNumber = "555-555-1234" },
            new Contact { Id = 3, FirstName = "Sam", LastName = "Dalton", Email = "sam.dalton@msn.com", PhoneNumber = "555-555-1234" },
            new Contact { Id = 4, FirstName = "Sam", LastName = "Dalton", Email = "sam.dalton@msn.com", PhoneNumber = "555-555-1234" },
            new Contact { Id = 5, FirstName = "Sam", LastName = "Dalton", Email = "sam.dalton@msn.com", PhoneNumber = "555-555-1234" },
            new Contact { Id = 6, FirstName = "Sam", LastName = "Dalton", Email = "sam.dalton@msn.com", PhoneNumber = "555-555-1234" },
            new Contact { Id = 7, FirstName = "Sam", LastName = "Dalton", Email = "sam.dalton@msn.com", PhoneNumber = "555-555-1234" },
            new Contact { Id = 8, FirstName = "Sam", LastName = "Dalton", Email = "sam.dalton@msn.com", PhoneNumber = "555-555-1234" },
            new Contact { Id = 9, FirstName = "Sam", LastName = "Dalton", Email = "sam.dalton@msn.com", PhoneNumber = "555-555-1234" },
            new Contact { Id = 10, FirstName = "Sam", LastName = "Dalton", Email = "sam.dalton@msn.com", PhoneNumber = "555-555-1234" },
            new Contact { Id = 11, FirstName = "Sam", LastName = "Dalton", Email = "sam.dalton@msn.com", PhoneNumber = "555-555-1234" }
        };

        public static IEnumerable<Contact> GetContacts()
        {
            return CONTACTS;
        }

        public static Contact GetContact(int id)
        {
            return CONTACTS.FirstOrDefault(c => c.Id == id);
        }
    }
}