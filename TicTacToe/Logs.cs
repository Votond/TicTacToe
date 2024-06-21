namespace TicTacToe
{
    internal static class Logs
    {
        private const string InfoPrefix = "[I]";
        private const string WarnPrefix = "[W]";
        private const string ErrorPrefix = "[E]";

        private static void WriteMessage(string message) => Program.MainForm.WriteLogsMessage($"{message}\n");

        public static void Info(string message) => WriteMessage($"{InfoPrefix} {message}");
        public static void Warn(string message) => WriteMessage($"{WarnPrefix} {message}");
        public static void Error(string message) => WriteMessage($"{ErrorPrefix} {message}");
    }
}