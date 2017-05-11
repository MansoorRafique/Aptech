using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace WindowsStoreApp_DataBinding
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            Employee obj = new Employee("1", "Shan", 18, new DateTime(2014, 02, 06));

            txtEmployee.DataContext = obj;
            txtEmpID.DataContext = obj;
            txtEmpName.DataContext = obj;
            txtEmpAge.DataContext = obj;
            
            EmployeeList el = new EmployeeList();
            cbEmployee.DataContext = el.GetList();
        }

        
    }
}
