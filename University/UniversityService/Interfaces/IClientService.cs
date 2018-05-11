using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityService.ViewModels;

namespace UniversityService.Interfaces
{
    public interface IClientService 
    {
        List<ClientViewModel> GetList();

        ClientViewModel GetElement(int id);
    }
}
