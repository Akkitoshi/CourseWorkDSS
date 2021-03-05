using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;

namespace View
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
            Application.Run(container.Resolve<MainForm>());
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<DbContext, DSSContext>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<RequestController>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<ExecutorController>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<CategoryController>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<PriorityController>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<ComplexityController>(new
           HierarchicalLifetimeManager());

            return currentContainer;
        }
    }
}
