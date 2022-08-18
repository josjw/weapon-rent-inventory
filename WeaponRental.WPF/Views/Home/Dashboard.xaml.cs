using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WeaponRental.WPF.Views.Home
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void BtnWeaponType_Click(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
            App.ViewRouting(false);
            App.ViewRouting(true, new Content.WeaponTypeView());
=======

>>>>>>> main
        }

        private void BtnWeaponData_Click(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
            App.ViewRouting(false);
            App.ViewRouting(true, new Content.WeaponDataView());
=======

>>>>>>> main
        }

        private void BtnMemberData_Click(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
            App.ViewRouting(false);
            App.ViewRouting(true, new Content.MemberDataView());
=======

>>>>>>> main
        }

        private void BtnOfficerData_Click(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
            App.ViewRouting(false);
            App.ViewRouting(true, new Content.OfficerDataView());
=======

>>>>>>> main
        }

        private void BtnBorrow_Click(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
            App.ViewRouting(false);
            App.ViewRouting(true, new Content.BorrowView());
=======

>>>>>>> main
        }

        private void BtnReturn_Click(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
            App.ViewRouting(false);
            App.ViewRouting(true, new Content.ReturnView());
=======

>>>>>>> main
        }

        private void BtnReport_Click(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
            App.ViewRouting(false);
            App.ViewRouting(true, new Content.ReportView());
=======

>>>>>>> main
        }

        private void BtnSetting_Click(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
            App.ViewRouting(false);
            App.ViewRouting(true, new Content.SettingView());
=======

>>>>>>> main
        }
    }
}
