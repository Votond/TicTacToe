namespace TicTacToe
{
    internal static class Logs
    {
        private const string INFO_PREFIX = "[I]";
        private const string WARN_PREFIX = "[W]";
        private const string ERROR_PREFIX = "[E]";

        private static void WriteMessage(string message) => Program.MainForm.WriteLogsMessage($"{message}\n");

        public static async Task Info(string message) => WriteMessage($"{INFO_PREFIX} {message}");
        public static async Task Warn(string message) => WriteMessage($"{WARN_PREFIX} {message}");
        public static async Task Error(string message) => WriteMessage($"{ERROR_PREFIX} {message}");
    }
}