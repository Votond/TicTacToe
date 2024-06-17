namespace TicTacToe
{
    internal class GameDrawer
    {
        private static readonly GameDrawer instance = new();
        public static GameDrawer GetInstance() => instance;

        private Graphics graphics = Graphics.FromHwnd(IntPtr.Zero);

        public Image Draw()
        {
            var img = Image.FromFile("base.jpeg");

            using (Graphics g = Graphics.FromImage(img))
                graphics.DrawString("String", new Font("Arial", 30), new SolidBrush(Color.Red), 100, 200);

            return img;
        }
    }
}