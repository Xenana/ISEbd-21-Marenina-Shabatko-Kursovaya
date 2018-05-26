using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Unity;
using Unity.Attributes;
using UniversityService.Interfaces;
using UniversityService.ViewModels;

namespace UniversityViewClient
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class FormMain : Window
    {
        [Dependency]
        public IUnityContainer Container { get; set; }

        private readonly IMainService service;

        public FormMain(IMainService service)
        {
            InitializeComponent();
            this.service = service;
            Loaded += FormMain_Load;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                List<OrderViewModel> list = service.GetList();
                if (list != null)
                {
                    DataGridViewCourses.ItemsSource = list;
                    DataGridViewCourses.Columns[0].Visibility = Visibility.Hidden;
                    DataGridViewCourses.Columns[1].Visibility = Visibility.Hidden;
                    DataGridViewCourses.Columns[2].Visibility = Visibility.Hidden;
                    DataGridViewCourses.Columns[3].Visibility = Visibility.Hidden;
                    DataGridViewCourses.Columns[4].Visibility = Visibility.Hidden;
                    DataGridViewCourses.Columns[5].Visibility = Visibility.Hidden;
                    DataGridViewCourses.Columns[6].Visibility = Visibility.Hidden;
                    DataGridViewCourses.Columns[7].Visibility = Visibility.Hidden;
                    DataGridViewCourses.Columns[8].Visibility = Visibility.Hidden;
                    DataGridViewCourses.Columns[1].Width = DataGridLength.Auto;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

      
        
        private void studyPayment_Click(object sender, RoutedEventArgs e)
        {
            var form = Container.Resolve<FormPayment>();
            form.ShowDialog();
        }

        private void LogIn_Click(object sender, RoutedEventArgs e)
        {
            var form = Container.Resolve<FormAuthorization>();
            form.ShowDialog();
        }

        private void passedStudyReport_Click(object sender, RoutedEventArgs e)
        {

        }

        private void downloadListCourses_Click(object sender, RoutedEventArgs e)
        {

        }

        private void docReport_Click(object sender, RoutedEventArgs e)
        {
            var form = Container.Resolve<FormReport>();
            form.ShowDialog();
        }

        private void xlsReport_Click(object sender, RoutedEventArgs e)
        {

        }

        private void enrollCourses_Click(object sender, RoutedEventArgs e)
        {
            var form = Container.Resolve<FormEnrollCourses>();
            form.ShowDialog();
        }

        private void buttonRegr_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var form = Container.Resolve<FormRegistration>();
            form.ShowDialog();
        }

        private void buttonUpd_Click(object sender, RoutedEventArgs e)
        {
            LoadData();
        }
    }
}
