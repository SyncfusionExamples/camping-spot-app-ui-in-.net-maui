using System;
using System.Collections.ObjectModel;
using CampingSpotsUI.Models;

namespace CampingSpotsUI.ViewModels
{
	public class UserViewModel
	{
        private ObservableCollection<UserInfo> userInfo;

        public ObservableCollection<UserInfo> UserInfo
        {
            get { return userInfo; }
            set { this.userInfo = value; }
        }

        public UserViewModel()
		{
            GenerateInfo();
		}

        internal void GenerateInfo()
        {
            userInfo = new ObservableCollection<UserInfo>();
            userInfo.Add(new UserInfo { UserPicture = "user1" });
            userInfo.Add(new UserInfo { UserPicture = "user2" });
            userInfo.Add(new UserInfo { UserPicture = "user3" });
            userInfo.Add(new UserInfo { UserPicture = "user1" });
        }

	}
}

