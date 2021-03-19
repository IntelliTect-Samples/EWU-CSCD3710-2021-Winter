using System;
using System.Collections.Generic;
using System.ComponentModel;
namespace Assignment9
{
    public class Contact
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? EmailAddress { get; set; }
        public string? TwitterName { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        private DateTime _LastModifiedTime;

        public DateTime LastModifiedTime
        {
            get => _LastModifiedTime;
            set
            {
                _LastModifiedTime = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LastModifiedTime)));
            }
        }
    }
}
