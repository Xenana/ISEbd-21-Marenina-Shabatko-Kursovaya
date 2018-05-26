using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityModel;
using UniversityService.BindingModels;
using UniversityService.Interfaces;
using UniversityService.ViewModels;

namespace UniversityService.Implementations
{
    public class CourseServiceList : ICourseService
    {
        private UniverDbContext context;

        public CourseServiceList(UniverDbContext context)
        {
            this.context = context;
        }

        public List<CourseViewModel> GetList()
        {
            List<CourseViewModel> result = context.Courses
            .Select(rec => new CourseViewModel
            {
                Id = rec.Id,
                CourseName = rec.CourseName,
                PriceCourse = rec.PriceCourse
            })
            .ToList();
            return result;
        }

        public CourseViewModel GetElement(int id)
        {
            Course element = context.Courses.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new CourseViewModel
                {
                    Id = element.Id,
                    CourseName = element.CourseName,
                    PriceCourse = element.PriceCourse
                };
            }
            throw new Exception("Элемент не найден");
        }

        public void AddElement(CourseBindingModel model)
        {
            Course element = context.Courses.FirstOrDefault(rec => rec.CourseName == model.CourseName);
            if (element != null)
            {
                throw new Exception("Уже есть курс с таким названием");
            }
            context.Courses.Add(new Course
            {
                CourseName = model.CourseName,
                PriceCourse = model.Price,
            });
            context.SaveChanges();
        }

        public void UpdElement(CourseBindingModel model)
        {
            Course element = context.Courses.FirstOrDefault(rec =>
            rec.CourseName == model.CourseName && rec.Id != model.Id);
            if (element != null)
            {
                throw new Exception("Уже есть курс с таким названием");
            }
            element = context.Courses.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.CourseName = model.CourseName;
            element.PriceCourse = model.Price;
            context.SaveChanges();
        }

        public void DelElement(int id)
        {
            Course element = context.Courses.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                context.Courses.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }

        public void Enroll(int id)
        {
            Order element = context.Orders.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                context.Orders.Add(new Order
                {
                    Sum = element.Sum,
                    BalanceSum = element.BalanceSum,
                    Status = element.Status,
                    DateCreate = element.DateCreate,
                    CourseName = element.CourseName,
                });
                context.SaveChanges();
            }
        }
    }
}
