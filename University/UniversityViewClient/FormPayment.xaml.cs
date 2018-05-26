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
using UniversityService.BindingModels;
using UniversityService.Interfaces;
using UniversityService.ViewModels;

namespace UniversityViewClient
{
    /// <summary>
    /// Логика взаимодействия для FormPayment.xaml
    /// </summary>
    public partial class FormPayment : Window
    {
        [Dependency]
        public IUnityContainer Container { get; set; }

        public int ID { set { id = value; } }

        private readonly IMainService serviceM;

        private readonly ICourseService serviceC;

        private int? id;

        private CourseViewModel model;

        public FormPayment(IMainService serviceM)
        {
            InitializeComponent();
            Loaded += FormPayment_Load;
            this.serviceM = serviceM;
        }

        private void FormPayment_Load(object sender, EventArgs e)
        {
            List<CourseViewModel> list = serviceC.GetList();
            try
            {
                if (list != null)
                {
                    comboBoxCourse.DisplayMemberPath = "CourseName";
                    comboBoxCourse.SelectedValuePath = "Id";
                    comboBoxCourse.ItemsSource = list;
                    comboBoxCourse.SelectedItem = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            if (model != null)
            {
                comboBoxCourse.IsEnabled = false;
                foreach (CourseViewModel item in list)
                {
                    if (item.CourseName == model.CourseName)
                    {
                        comboBoxCourse.SelectedItem = item;
                    }
                }
            }
        }



        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void buttonOK_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxCourse.Text))
            {
                MessageBox.Show("Выберите курс", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxSumPay.Text))
            {
                MessageBox.Show("Заполните сумму", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            try
            {
                serviceM.PayOrder(new OrderBindingModel
                {
                    Sum = Convert.ToInt32(textBoxSumPay.Text)
                });
                MessageBox.Show("Сохранение прошло успешно", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                DialogResult = true;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
