using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;
using UniversityService;
using UniversityService.Implementations;
using UniversityService.Interfaces;

namespace UniversityView
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = BuildUnityContainer();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<FormMain>());
        }
        public static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<DbContext, UniverDbContext>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IClientService, ClientServiceList>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<ICourseService, CourseServiceList>(new HierarchicalLifetimeManager());
      //      currentContainer.RegisterType<IAdminService, AdminServiceList>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IMainService, MainServiceList>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IReportService, ReportService>(new HierarchicalLifetimeManager());

            return currentContainer;
        }
    }
}
