using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityModel;
using UniversityService.Interfaces;
using UniversityService.ViewModels;

namespace UniversityService.Implementations
{
    public class ClientServiceList : IClientService
    {
        private UniverDbContext context;

        public ClientServiceList(UniverDbContext context)
        {
            this.context = context;
        }

        public ClientViewModel GetElement(int id)
        {
            Client element = context.Clients.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new ClientViewModel
                {
                    Id = element.Id,
                    ClientLogin = element.ClientLogin,
                    ClientFIO = element.ClientFIO,
                };
            }
            throw new Exception("Элемент не найден");
        }

        public List<ClientViewModel> GetList()
        {
            List<ClientViewModel> result = context.Clients.Select(rec => new ClientViewModel
            {
                Id = rec.Id,
                ClientLogin = rec.ClientLogin,
                ClientFIO = rec.ClientFIO,
            })
                .ToList();
            return result;
        }

       

        public string MakeLogin(string fio)
        {
            char split = ' ';
            string firstName = fio.Substring(0, fio.IndexOf(split));

            fio = fio.Substring(fio.IndexOf(split) + 1);

            string name = fio.Substring(0, fio.IndexOf(split));

            string namePath = string.Empty;

            int position = 1;

            while (true)
            {
                if (name.Length > 0)
                {
                    namePath += name.First();
                    name = name.Substring(1);
                }
                else
                {
                    position++;
                }
                string login = firstName + "." + namePath + ((position > 1) ? position + "" : "");

                Client client = context.Clients.FirstOrDefault(rec => rec.ClientLogin.Equals(login));
                
                if (client == null )
                {
                    return login;
                }
            }
        }
    }
}
