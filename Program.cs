using DbWrapper.Core;
using DbWrapper.Core.ORM;
using DbWrapper.UI.ORM;

namespace ConsoleApp99
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            DbInstance db = new PostgreDb();
            db.SetConnectionParams("flight_system", "localhost", 5432, "postgres", "postgres");
            AppState.SetDbInstance(db);
            AppDbContext context = new AppDbContext(db);
            context.AddSet<Trip>();
            context.AddSet<Ticket>();
            context.AddSet<Company>();
            AppState.SetContext(context);
            ApplicationConfiguration.Initialize();
            Application.Run(new AuthForm());
        }
    }
}