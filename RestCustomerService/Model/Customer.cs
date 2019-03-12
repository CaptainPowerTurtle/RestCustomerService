using System;

namespace RestCustomerService.Model
{
    public class Customer
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private DateTime _year;

        public Customer(int id, string fristname, string lastname, DateTime year)
        {
            _id = id;
            _firstName = fristname;
            _lastName = lastname;
            _year = year;
        }
        public Customer() { }

        public int ID
        {
            get { return _id; }
            set { value = _id; }
            
        }

        public string FirstName
        {
            get { return _firstName; }
            set { value = _firstName; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { value = _lastName; }
        }

        public DateTime Year
        {
            get { return _year; }
            set { value = _year; }
        }
    }
}