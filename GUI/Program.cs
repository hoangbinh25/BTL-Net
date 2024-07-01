namespace GUI
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

<<<<<<< HEAD
            Application.Run(new QL_TraMuon_Sach());
=======
            //Application.Run(new QL_Kho_Sach());
>>>>>>> 6cc4869ffdc33e3f67bc11fcb421dc57a8132ef4

            Application.Run(new NgonNgu());

        }
    }
}