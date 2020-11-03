using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleWebScraper
{
    class PersonBuilder
    {
        private string firstName;
        private string lastName;
        private int age;
        private int eyeColor;
        private int hairColor;

        public PersonBuilder()
        {
            SetDefaults();
        }

        private void SetDefaults()
        {
            firstName = "Bad";
            lastName = "Man";
            age = 30;
            eyeColor = 234;
            hairColor = 456;
        }

        public PersonBuilder WithFirstName(string firstName)
        {
            this.firstName = firstName;
            return this;
        }

        public PersonBuilder WithLastName(string lastName)
        {
            this.lastName = lastName;
            return this;
        }

        public PersonBuilder WithAge(int age)
        {
            this.age = age;
            return this;
        }

        public PersonBuilder WithEyeColor(int eyeColor)
        {
            this.eyeColor = eyeColor;
            return this;
        }

        public PersonBuilder WithHairColor(int hairColor)
        {
            this.hairColor = hairColor;
            return this;
        }

        public Person Build()
        {
            Person person = new Person(firstName, lastName, age, eyeColor, hairColor);
            return person;
        }
    }
}
