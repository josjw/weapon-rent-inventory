using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
<<<<<<< HEAD
using System.Windows.Controls;
using WeaponRental.WPF.Views.Content;
using WeaponRental.WPF.Views.Home;
using WeaponRental.Domain.Models;

=======
using WeaponRental.WPF.Views.Home;
>>>>>>> main

namespace WeaponRental.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Dashboard View { get; set; }
<<<<<<< HEAD
        public static void ViewRouting(bool flag, Control content = null)
        {
            if (flag == true)
            {
                View.PnlContent.Children.Add(content);
            }
            else
            {
                View.PnlContent.Children.Clear();
            }
        }
=======
>>>>>>> main
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            View = new Dashboard();
            View.Show();
        }
    }
}
