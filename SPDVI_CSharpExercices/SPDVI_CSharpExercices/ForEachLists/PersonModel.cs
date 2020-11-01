using System;
using System.Collections.Generic;
using System.Text;

namespace ForEachLists
{
    class PersonModel
    {
        String firstName;
        String lastName;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }

        public PersonModel(String firstName, String lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }

}
