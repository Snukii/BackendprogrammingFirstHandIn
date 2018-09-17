using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firsthandin
{
    class Customer
    {
        private string firstName = "Carsten";
        private string lastName = "Andersen";
        private int age = 38;
        private int zipcode = 4800;
        private string password = "VeryGoodPassword123";

        public Customer()
        {

        }

        public Customer(string _firstName, string _lastName, int _age, int _zipcode, string _password)
        {
            firstName = _firstName;
            lastName = _lastName;
            age = _age;
            zipcode = _zipcode;
            password = _password;
        }

        public void ResetPassword(string _password)
        {
            password = _password;
        }

        public override string ToString()
        {
            return $"Customer data: \n Name: {firstName} {lastName} \n Age: {age} \n Zipcode: {zipcode} \n Password: {password}";
        }

    }
}
