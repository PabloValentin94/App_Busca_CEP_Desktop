namespace App_Busca_CEP_Desktop
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


            // Definindo a fonte, e tamb�m seu tamanho, padr�o da aplica��o.
            Application.SetDefaultFont(new Font(new FontFamily("Arial"), 12f));

            Application.Run(new form_principal());

        }

    }

}