
using System;

namespace T2009M.PRACTICAL
    {
        internal class Program
        {
            public static void Main(string[] args)
            {
                MobilePhone mobilePhone = new MobilePhone();
                mobilePhone.PhoneName = "Galaxy";
                mobilePhone.PhoneType = "mobile";
                mobilePhone.PhonePrice = 5000;
                mobilePhone.display();

                Phone phone = new Phone();
                phone.PhoneName = "Ip";
                phone.PhoneType = "phone";
                phone.PhonePrice = 2000;
                phone.display();
            }
        }
    }