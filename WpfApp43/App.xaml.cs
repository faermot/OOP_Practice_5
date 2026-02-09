using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfApp43.Model;
using SQLitePCL;

namespace WpfApp43
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Batteries_V2.Init();

            using (var context = new DataContext())
            {
                context.Database.EnsureCreated();
            }

            base.OnStartup(e);
        }

    }
}
