using System;
using System.ComponentModel;

namespace CampingSpotsUI.Models
{
    public class UserInfo : INotifyPropertyChanged
    {
        private string userPicture;

        public string UserPicture
        {
            get { return userPicture; }
            set
            {
                userPicture = value;
                OnPropertyChanged("userPicture");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}

