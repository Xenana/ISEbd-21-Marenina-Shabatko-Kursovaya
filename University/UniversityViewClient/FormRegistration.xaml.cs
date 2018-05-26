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
    /// Логика взаимодействия для FormRegistration.xaml
    /// </summary>
    public partial class FormRegistration : Window
    {
        [Dependency]
        public IUnityContainer Container { get; set; }

        private readonly IClientService service;

        private ClientBindingModel model;

        public FormRegistration(IClientService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void buttonRegistr_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFIO.Text))
            {
                MessageBox.Show("Введите ФИО", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxMail.Text))
            {
                MessageBox.Show("Введите электронную почту", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrEmpty(passBoxPassword.Password))
            {
                MessageBox.Show("Введите пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            try
            {

                if (model == null)
                {
                    {
                        model = new ClientBindingModel
                        {
                            ClientLogin = textBoxMail.Text,
                            ClientMail = textBoxMail.Text,
                            ClientPassword = passBoxPassword.ToString(),
                            ClientFIO = textBoxFIO.Text,
                        };
                    }
                    MessageBox.Show("Регистрация прошла успешно", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                    DialogResult = true;
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
