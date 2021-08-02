using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ValidationsMVCDemo.Models
{
    public class Customers : IDataErrorInfo
    {
        private string _custname;
        private string _city;
        private Dictionary<String, String> _errors = new Dictionary<string, string>();


        public string CustName
        {
            get { return _custname; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    _errors.Add("CustName", "Customer Name cannot be blank!");

                _custname = value;
            }
        }

        public string City
        {
            get { return _city; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    _errors.Add("City", "City cannot be blank!");

                _city = value;
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (_errors.ContainsKey(columnName))
                    return _errors[columnName];

                return String.Empty;
            }
        }

        public string Error
        {
            get { return String.Empty; }
        }
    }

}