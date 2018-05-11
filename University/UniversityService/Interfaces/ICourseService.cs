using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityService.BindingModels;
using UniversityService.ViewModels;

namespace UniversityService.Interfaces
{
    public interface ICourseService
    {
        List<CourseViewModel> GetList();

        CourseViewModel GetElement(int id);

        void AddElement(CourseBindingModel model);

        void UpdElement(CourseBindingModel model);

        void DelElement(int id);
    }
}
