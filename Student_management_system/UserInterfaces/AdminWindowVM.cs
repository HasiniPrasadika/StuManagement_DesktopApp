using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Student_management_system.Database;
using Student_management_system.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Student_management_system.UserInterfaces
{
    public partial class AdminWindowVM:ObservableObject
    {
        [ObservableProperty]
        public string userName;

        [ObservableProperty]
        public string password;

        public AdminWindowVM()
        {
            userData = new DatabaseContext();
            LoadUser();
        }

        DatabaseContext userData;

        [ObservableProperty]
        public ObservableCollection<User> listofuser;

        [ObservableProperty]
        public User selectedUser;

        private void LoadUser()
        {
            Listofuser = new ObservableCollection<User>(userData.Users);
        }

        [RelayCommand]
        public void Delete(object obj)
        {
            var us = obj as User;
            userData.Users.Remove(us);
            userData.SaveChanges();
            Listofuser.Remove(us);
        }

        [RelayCommand]
        public void Edit(object obj)
        {
            SelectedUser = obj as User;
        }

        [RelayCommand]
        public void EditUser()
        {
            userData.SaveChanges();
            SelectedUser = new User();
        }

        [RelayCommand]
        public void AddUser()
        {
            var user = new User();
            user.UserName = UserName;
            user.Password = Password;
            user.Role = "normaluser";
            int id = 1 + userData.Users.Count();
            user.UserId = id;
            userData.Users.Add(user);
            userData.SaveChanges();

            UserName = null;
            Password = null;
            
            Listofuser.Add(user);
        }

        [RelayCommand]
        public void Quit()
        {
            var adminWindow = Application.Current.Windows.OfType<AdminWindow>().FirstOrDefault();
            adminWindow?.Close();

        }

        [RelayCommand]
        public void Systemwindow()
        {
            StudentWindow studentWindow = new StudentWindow();
            studentWindow.Show();

        }
    }
}
