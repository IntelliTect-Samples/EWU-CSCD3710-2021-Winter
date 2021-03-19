using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Assignment9
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public Command NewContactCommand { get; }
        public Command DeleteContactCommand { get; }
        public Command SaveContactCommand { get; }
        public Command EditContactCommand { get; }

        public ObservableCollection<Contact> ContactList { get; } = new();

        private bool SetProperty<T>(ref T field, T newValue, [CallerMemberName] string propertyName = "")
        {
            if (!EqualityComparer<T>.Default.Equals(field, newValue))
            {
                field = newValue;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                return true;
            }
            return false;
        }

        private Contact? _CurrentContact;
        public Contact CurrentContact
        {
            get => _CurrentContact!;
            set => SetProperty(ref _CurrentContact, value);
        }

        private bool _InEdit;
        public bool InEdit
        {
            get => _InEdit;
            set => SetProperty(ref _InEdit, value);
        }

        public MainWindowViewModel()
        {
            NewContactCommand = new Command(CreateNewContact, () => true);
            DeleteContactCommand = new Command(DeleteContact, () => true);
            SaveContactCommand = new Command(SaveContact, () => true);
            EditContactCommand = new Command(EditContact, () => true);

            ContactList.Add(new()
            {
                FirstName = "Jenny",
                LastName = "Tutone",
                PhoneNumber = "(509)867-5309",
                EmailAddress = "numberonthewall@gmail.com",
                TwitterName = "@foragoodtimecall",
                LastModifiedTime = DateTime.Now
            });

            CurrentContact = ContactList.First();
        }


        private void EditContact()
        {
            InEdit = CanEdit();
        }

        private void SaveContact()
        {
            if (CanEdit() && InEdit)
            {
                InEdit = false;
                CurrentContact.LastModifiedTime = DateTime.Now;
            }
            else
            {
                CreateNewContact();
            }

        }

        private void DeleteContact()
        {

            ContactList.Remove(CurrentContact);
            if (CanEdit())
            {
                CurrentContact = ContactList.First();
            }
        }

        public bool CanEdit()
        {
            if (ContactList.Count > 0)
                return true;
            return false;
        }

        private void CreateNewContact()
        {
            Contact newContact = new Contact()
            {
                //FirstName = "",
                //LastName = "",
                LastModifiedTime = DateTime.Now
            };
            ContactList.Add(newContact);
            CurrentContact = newContact;
            InEdit = true;
        }
    }
}
