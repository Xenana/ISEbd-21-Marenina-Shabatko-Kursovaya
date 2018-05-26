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
    /// Логика взаимодействия для FormAuthorization.xaml
    /// </summary>
    public partial class FormAuthorization : Window
    {
        [Dependency]
        public IUnityContainer Container { get; set; }

        private readonly IClientService service;

        private ClientBindingModel model;

        public FormAuthorization(IClientService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            model = new ClientBindingModel
            {
                ClientFIO = textBoxLogin.Text,
                ClientLogin = textBoxLogin.Text,
                ClientPassword = textBoxLogin.Text,
            };
        }

        private void buttonLogIn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLogin.Text))
            {
                MessageBox.Show("Введите логин", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrEmpty(pBoxPassword.Password))
            {
                MessageBox.Show("Введите пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
           
            try
            {
                if (model != null)
                {
                    if ((textBoxLogin.Text != model.ClientLogin) && (pBoxPassword.Password != model.ClientPassword))
                    {
                        MessageBox.Show("Вход выполнен успешно", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                        DialogResult = true;
                        Close();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            }
        }
    }

