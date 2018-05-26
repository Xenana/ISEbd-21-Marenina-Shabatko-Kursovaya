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
using UniversityService.BindingModels;
using UniversityService.Interfaces;
using UniversityService.ViewModels;

namespace UniversityView
{
    public partial class FormCourse : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        public int Id { set { id = value; } }

        private readonly ICourseService service;

        private int? id;

        public FormCourse(ICourseService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void FormCourse_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    CourseViewModel view = service.GetElement(id.Value);
                    if (view != null)
                    {
                        textBoxNameCourse.Text = view.CourseName;
                        textBoxPriceCourse.Text = (view.PriceCourse).ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNameCourse.Text))
            {
                MessageBox.Show("Заполните название", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxPriceCourse.Text))
            {
                MessageBox.Show("Заполните цену", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (id.HasValue)
                {
                    service.UpdElement(new CourseBindingModel
                    {
                        Id = id.Value,
                        CourseName = textBoxNameCourse.Text,
                        Price = Int32.Parse(textBoxPriceCourse.Text),

                });
                    
                }
                else
                {
                    service.AddElement(new CourseBindingModel
                    {
                        CourseName = textBoxNameCourse.Text,
                        Price = Int32.Parse(textBoxPriceCourse.Text)
                    });
                }
                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
