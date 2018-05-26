using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using Unity.Attributes;
using UniversityService.Interfaces;
using UniversityService.ViewModels;

namespace UniversityView
{
    public partial class FormClient : Form
    {
        [Unity.Attributes.Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IClientService service;

        public FormClient(IClientService service)
        {
            InitializeComponent();
            this.service = service;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                List<ClientViewModel> list = service.GetList();
                if (list != null)
                {
                    dataGridViewClient.DataSource = list;
                    dataGridViewClient.Columns[0].Visible = false;
                    dataGridViewClient.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonBonus_Click(object sender, EventArgs e)
        {
             // начислить бонус если за прошлый месяц была оплата во время 
        }

        private void ButtonFine_Click(object sender, EventArgs e)
        {
            // начислить штраф если оплата не была произведена вовремя
            //DateTime.Today
        }

        private void ButtonBlock_Click(object sender, EventArgs e)
        {
            // заблокировать если не платил давно и сумма заложности большая 
             /* if (PaymentState==2)
              {
              }  */ 

        }
    }
}
