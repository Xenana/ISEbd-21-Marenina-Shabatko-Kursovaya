using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using Unity.Attributes;
using UniversityService.Interfaces;
using UniversityService.ViewModels;

namespace UniversityView
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IMainService service;

        private readonly IReportService reportService;

        public FormMain(IMainService service, IReportService reportService)
        {
            InitializeComponent();
            this.service = service;
            this.reportService = reportService;
        }

        private void LoadData()
        {
            try
            {
                List<OrderViewModel> list = service.GetList();
                if (list != null)
                {
                    dataGridViewOrder.DataSource = list;
                    dataGridViewOrder.Columns[0].Visible = false;
                    dataGridViewOrder.Columns[1].Visible = false;
                    dataGridViewOrder.Columns[3].Visible = false;
                    dataGridViewOrder.Columns[5].Visible = false;
                    dataGridViewOrder.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void курсыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormCourses>();
            form.ShowDialog();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            // if логин и пароль верные 
                if (textBoxLogin.Text == "login" && textBoxPassword.Text == "password")
                {
                    MessageBox.Show("Авторизация прошла успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxPassword.Text = "";
                    курсыToolStripMenuItem.Enabled = true;
                    отчетToolStripMenuItem.Enabled = true;
                    клиентыToolStripMenuItem.Enabled = true;
                    buttonRef.Enabled = true;
                    textBoxLogin.Enabled = false;
                    textBoxPassword.Enabled = false;
                    buttonLogIn.Enabled = false;
                } else
                {
                    MessageBox.Show("Неправильный логин или пароль!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxPassword.Text = "";
                    textBoxLogin.Text = "";
            } 
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            textBoxLogin.Text = "";
            textBoxLogin.Enabled = true;
            textBoxPassword.Enabled = true;
            курсыToolStripMenuItem.Enabled = false;
            отчетToolStripMenuItem.Enabled = false;
            клиентыToolStripMenuItem.Enabled = false;
            buttonRef.Enabled = false;
            buttonLogIn.Enabled = true;
        }

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormPaymentReport>();
            form.ShowDialog();
            
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormClient>();
            form.ShowDialog();
        }

        private void buttonRef_Click(object sender, EventArgs e)
        {
            LoadData();
        }

    }
}
