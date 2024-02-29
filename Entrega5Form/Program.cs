using Data.Data;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace Entrega5Form
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var optionsBuilder = new DbContextOptionsBuilder<Entrega5DbContext>();
            var connectionString = "Host=localhost;Port=5432;Database=Entrega5;Persist Security Info=True;Password=Estudiantes000;Username=postgres";
            optionsBuilder.UseNpgsql(connectionString);

            using (var dbContext = new Entrega5DbContext(optionsBuilder.Options))
            {
                dbContext.Database.EnsureCreated();
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}