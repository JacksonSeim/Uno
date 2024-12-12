namespace UnoConsoleApplication
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ConsoleController consoleController = new ConsoleController();
            ConsoleView consoleView = new ConsoleView(consoleController.NewFormInput, consoleController._players, consoleController._deck);
            consoleController.SetUpViewDelegates(consoleView.Update);
        }
    }
}