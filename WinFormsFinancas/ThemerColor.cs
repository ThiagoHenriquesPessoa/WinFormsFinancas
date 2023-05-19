namespace WinFormsFinancas
{
    public static class ThemerColor
    {
        public static List<string> ColorList = new List<string>()
       {
           "#CD5C5C",
           "#CD853F",
           "#F4A460",
           "#B22222",
           "#FFA500",
           "#FF6347",
           "#FF0000",
           "#FF1493",
           "#FFB6C1",
           "#DB7093",
           "#D02090",
           "#DDA0DD",
           "#9932CC",
           "#A020F0",
           "#00CED1",
           "#00FFFF",
           "#7FFFD4",
           "#556B2F",
           "#20B2AA",
           "#00FF7F",
           "#7FFF00",
           "#ADFF2F",
           "#228B22",
           "#DAA520",
           "#FFD700",
           "#EEDD82",
           "#B8860B",
           "#36648B",
           "#00BFFF",
           "#00B2EE",
           "#009ACD",
           "#00688B",
           "#87CEFF",
           "#7EC0EE",
           "#6CA6CD"
       };

        public static Color ChangerColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R; double green = color.G; double blue = color.B;

            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else
            {
                red = (255 - red) * correctionFactor + red; 
                green = (255 - green) * correctionFactor + green; 
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}