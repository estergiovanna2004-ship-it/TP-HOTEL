using System;

namespace HotelCheckInSystem.Models
{
    public class Guest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactInfo { get; set; }

        public Guest(int id, string name, string contactInfo)
        {
            Id = id;
            Name = name;
            ContactInfo = contactInfo;
        }

        public void UpdateContactInfo(string newContactInfo)
        {
            ContactInfo = newContactInfo;
        }

        public override string ToString()
        {
            return $"Guest ID: {Id}, Name: {Name}, Contact Info: {ContactInfo}";
        }
    }
}