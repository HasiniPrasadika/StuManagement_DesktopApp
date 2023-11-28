using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Student_management_system.Database;
using Student_management_system.UserInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Student_management_system
{
    public partial class MainWindowVM:ObservableObject
    {
        [ObservableProperty]
        public string userName = "user1";
        [ObservableProperty]
        public string password = "456";

        public Action CloseAction { get; internal set; }
        


        [RelayCommand]
        public void Login()
        {
            
            if (userName != null)
            {

                using (var db = new DatabaseContext())
                {

                    bool userfound = db.Users.Any(user => user.UserName == userName && user.Password == password);

                    if (userfound)
                    {
                        if(db.Users.Any(user=> user.UserName == userName && user.Password == password && user.Role=="admin"))
                        {
                            AdminWindow adminWindow = new AdminWindow();                       
                            adminWindow.Show();
                        }
                        else 
                        {
                            StudentWindow studentWindow = new StudentWindow();
                            studentWindow.Show();
                        }
                        
                        

                    }
                    else
                    {
                        MessageBox.Show("User name or password was incorrect", "Warning");
                    }


                }


            }
        }
        [RelayCommand]
        public void Close()
        {
            CloseAction();
        }

        [RelayCommand]

        public void Quit()
        {
            this.Close();

        }
    }
}
