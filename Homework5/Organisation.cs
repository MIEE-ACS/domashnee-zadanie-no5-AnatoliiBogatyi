using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5
{
    internal class Organisation
    {
        int house;
        int mailindex;
        public string Country { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int House
        {
            get
            {
                return house;
            }
            set
            {
                house = value > 0 ? value : throw new Exception("Номер дома должен быть целым и положительным!");
            }
        }
        public int MailIndex
        {
            get
            {
                return mailindex;
            }
            set
            {
                mailindex = value / 100000 > 0 && value / 100000 < 10 ? value : throw new Exception("Индекс должен состоять из 6 цифр!");
            }
        }

        public Organisation(string country, string district, string city, string street, int house, int mailindex)
        {
            Country = country;
            District = district;
            City = city;
            Street = street;
            House = house;
            MailIndex = mailindex;
        }

        public Organisation(Organisation org) : this(org.Country, org.District, org.City, org.Street, org.House, org.MailIndex) { }

        public override string ToString()
        {
            return MailIndex + ", " +
                Country + ", " +
                District + ", " +
                City + ", " +
                Street + ", " +
                House.ToString();
        }

        public override bool Equals(object obj)
        {
            return (obj is Organisation org) && (
                org.Country == Country &&
                org.City == City &&
                org.District == District &&
                org.Street == Street &&
                org.House == house &&
                org.MailIndex == MailIndex);
        }
    }
}
