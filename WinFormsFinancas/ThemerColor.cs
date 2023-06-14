namespace WinFormsFinancas
{
    public static class ThemerColor
    {
        public static List<string> ColorList = new List<string>()
       {
           "#20B2AA",
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