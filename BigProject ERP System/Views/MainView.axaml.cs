using Avalonia.Controls;
using Avalonia.Interactivity;
using ERPSys;
using System.Collections.Generic;

namespace BigProject_ERP_System.Views;

public partial class MainView : UserControl
{
    DataBase instance;
    public MainView()
    {
        InitializeComponent();
    }
    private void CompanyButton_Click(object sender, RoutedEventArgs e)
    {
        Tabs.SelectedIndex = 1;
        /*
        List<Company> companies = new List<Company>();
        companies = instance.GetCompanyList();
        */
    }
    private void BacktoMenuButton_Click(object sender, RoutedEventArgs e)
    {
        Tabs.SelectedIndex = 0;
    }
}
