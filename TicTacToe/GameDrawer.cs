namespace TicTacToe
{
    internal class GameDrawer
    {
        public static class DrawInfos
        {
            public class DrawInfo
            {
                public KeyValuePair<int, int> CirclePosition { get; private set; }
                public KeyValuePair<int, int> CrossPosition { get; private set; }

                public DrawInfo(int cx, int cy, int crx, int cry)
                {
                    CirclePosition = new(cx, cy);
                    CrossPosition = new(crx, cry);
                }
            }

            public static DrawInfo[] Infos =
            {
                new(-65, -110, -20, 10),
                new(105, -110, -150, 10),
                new(280, -110, -325, 10),

                new(-65, 60, -20, 180),
                new(105, 60, 150, 180),
                new(280, 60, 325, 180),

                new(-65, 230, -20, 350),
                new(105, 230, 150, 350),
                new(280, 230, 325, 350),
            };
        }

        public static GameDrawer Instance { get; private set; } = new();

        public Image Draw(GameManager.Game game)
        {
            var fieldInfo = game.FieldInfo;
            var bmp = new Bitmap(500, 500);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                var backgroundColor = Color.White;

                var bordersPen = new Pen(Color.Black, 20);

                var circleFont = new Font(new FontFamily("Arial"), 230, FontStyle.Regular);
                var circleBrush = new Pen(Color.CornflowerBlue, 20).Brush;
                var circleChar = "\u25cb";

                var crossFont = new Font(new FontFamily("Arial"), 100, FontStyle.Regular);
                var crossBrush = new Pen(Color.IndianRed, 20).Brush;
                var crossChar = "\u2716";

                g.Clear(backgroundColor);

                // Borders
                // Horizontal lines
                g.DrawLine(bordersPen, 0, 166, 500, 166);
                g.DrawLine(bordersPen, 0, 332, 500, 332);

                // Vertical lines
                g.DrawLine(bordersPen, 166, 0, 166, 500);
                g.DrawLine(bordersPen, 332, 0, 332, 500);

                for (int i = 0; i < 9; i++)
                {
                    int x;
                    int y;

                    bool isCircle = false;

                    switch (fieldInfo.Cells[i])
                    {
                        case GameManager.Game.PlayingFieldInfo.CellState.Cross:
                            x = DrawInfos.Infos[i].CrossPosition.Key;
                            y = DrawInfos.Infos[i].CrossPosition.Value;
                            break;

                        case GameManager.Game.PlayingFieldInfo.CellState.Circle:
                            x = DrawInfos.Infos[i].CirclePosition.Key;
                            y = DrawInfos.Infos[i].CirclePosition.Value;
                            isCircle = true;
                            break;

                        default:
                            continue;
                    }

                    if (isCircle)
                        g.DrawString(circleChar, circleFont, circleBrush, x, y);
                    else
                        g.DrawString(crossChar, crossFont, crossBrush, x, y);
                }
                /*// Circles
                // Up
                g.DrawString("\u25cb", new Font(new FontFamily("Arial"), 230, FontStyle.Regular), circlesBrush, -65, -110);
                g.DrawString("\u25cb", new Font(new FontFamily("Arial"), 230, FontStyle.Regular), circlesBrush, 105, -110);
                g.DrawString("\u25cb", new Font(new FontFamily("Arial"), 230, FontStyle.Regular), circlesBrush, 280, -110);

                // Middle
                g.DrawString("\u25cb", new Font(new FontFamily("Arial"), 230, FontStyle.Regular), circlesBrush, -65, 60);
                g.DrawString("\u25cb", new Font(new FontFamily("Arial"), 230, FontStyle.Regular), circlesBrush, 105, 60);
                g.DrawString("\u25cb", new Font(new FontFamily("Arial"), 230, FontStyle.Regular), circlesBrush, 280, 60);

                // Down
                g.DrawString("\u25cb", new Font(new FontFamily("Arial"), 230, FontStyle.Regular), circlesBrush, -65, 230);
                g.DrawString("\u25cb", new Font(new FontFamily("Arial"), 230, FontStyle.Regular), circlesBrush, 105, 230);
                g.DrawString("\u25cb", new Font(new FontFamily("Arial"), 230, FontStyle.Regular), circlesBrush, 280, 230);

                // Crosses
                // Up
                g.DrawString("\u2716", new Font(new FontFamily("Arial"), 100, FontStyle.Regular), crossBrush, -20, 10);
                g.DrawString("\u2716", new Font(new FontFamily("Arial"), 100, FontStyle.Regular), crossBrush, 150, 10);
                g.DrawString("\u2716", new Font(new FontFamily("Arial"), 100, FontStyle.Regular), crossBrush, 325, 10);

                // Middle
                g.DrawString("\u2716", new Font(new FontFamily("Arial"), 100, FontStyle.Regular), crossBrush, -20, 180);
                g.DrawString("\u2716", new Font(new FontFamily("Arial"), 100, FontStyle.Regular), crossBrush, 150, 180);
                g.DrawString("\u2716", new Font(new FontFamily("Arial"), 100, FontStyle.Regular), crossBrush, 325, 180);

                // Down
                g.DrawString("\u2716", new Font(new FontFamily("Arial"), 100, FontStyle.Regular), crossBrush, -20, 350);
                g.DrawString("\u2716", new Font(new FontFamily("Arial"), 100, FontStyle.Regular), crossBrush, 150, 350);
                g.DrawString("\u2716", new Font(new FontFamily("Arial"), 100, FontStyle.Regular), crossBrush, 325, 350);*/
            }

            return bmp;
        }
    }
}