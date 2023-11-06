/**
 * Project      : Tilemap Editor
 * Description  : A C# program where you can modify and create tilesets and tilemaps with an access to a database
 * File         : Program.cs
 * Author       : Weber Jamie
 * Date         : 20 October 2023
**/
namespace TilemapEditor
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
            if (MainForm.Instance == null)
            {
                Application.Exit();
            }
            else
            {
                Application.Run(MainForm.Instance);
            }
        }
    }
}