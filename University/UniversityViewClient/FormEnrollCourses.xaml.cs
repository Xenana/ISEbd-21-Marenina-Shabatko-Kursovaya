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
using System.Windows.Shapes;
using Unity;
using Unity.Attributes;
using UniversityService.Interfaces;
using UniversityService.ViewModels;

namespace UniversityViewClient
{
    /// <summary>
    /// Логика взаимодействия для FormCourses.xaml
    /// </summary>
    public partial class FormEnrollCourses : Window
    {
        [Dependency]
        public IUnityContainer Container { get; set; }

        private readonly ICourseService service;

        private CourseViewModel model;

        public FormEnrollCourses(ICourseService service)
        {
            InitializeComponent();
            Loaded += FormCourses_Load;
            this.service = service;
        }

        private void FormCourses_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            List<CourseViewModel> list = service.GetList();
            try
            {
                
                if (list != null)
                {
                    DataGridView.ItemsSource = list;
                    DataGridView.Columns[0].Visibility = Visibility.Hidden;
                    DataGridView.Columns[1].Width = DataGridLength.Auto;
                    DataGridView.Columns[2].Width = DataGridLength.Auto;
                    DataGridView.Columns[3].Width = DataGridLength.Auto;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

          /*  if (model != null)
            {
                DataGridView.IsEnabled = false;
                foreach (CourseViewModel item in list)
                {
                    if (item.CourseName == model.CourseName)
                    {
                        DataGridView.SelectedItem = item;
                    }
                }
            }*/
        }

        private void Enroll_Click(object sender, RoutedEventArgs e)
        {

            if (DataGridView.SelectedItem != null)
            {
                
                    int id = ((CourseViewModel)DataGridView.SelectedItem).Id;
                    service.Enroll(id);
                    MessageBox.Show("Запись прошла успешно","Информация", MessageBoxButton.OK, MessageBoxImage.Information);

                LoadData();
                }
            }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            LoadData();
        }
    }
    }

