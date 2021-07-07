using System;
using System.Collections.Generic;
using System.Text;

namespace MarketingApp.Model.Staff
{
    public  class SalesPerson
    {
        private int id;
        private string name;
        private string lastname;
        private int code;
        private string phone_number;
        private string mobile;
        private string address;
        private int commission;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public int Code { get => code; set => code = value; }
        public string Phone_number { get => phone_number; set => phone_number = value; }
        public string Mobile { get => mobile; set => mobile = value; }
        public string Address { get => address; set => address = value; }
        public int Commission { get => commission; set => commission = value; }
    }
}
