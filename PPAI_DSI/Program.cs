using PPAI_DSI.Persistencia;

namespace PPAI_DSI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            using (var dbContext = new ApplicationDbContext()) // Crea una instancia de tu contexto de datos
            {
                // Aquí puedes realizar operaciones con el contexto de datos, como consultas y modificaciones en la base de datos
                // Por ejemplo, puedes consultar datos de la base de datos o realizar otras operaciones según tus necesidades
            }


            Application.Run(new VentanaConsultarLlamadas());

        }
    }
}