using Npgsql;

namespace University
{
    internal static class Program
    {
        public static NpgsqlConnection con = new("Host=localhost; port=5432; username=postgres; password =25481; database=UniversityDatabase;");
        public static ApplicationContext context = new();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            context.MainForm = new AuthorizationForm();
            Application.Run(context);
        }

        public static void ChangeForm(Form oldForm, Form newForm)
        {
            context.MainForm = newForm;
            newForm.Show();
            oldForm.Hide();
        }
    }
}