namespace WinFormsFinancas
{
    public partial class FormMainMenu : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private Color SelectthemeColor()
        {
            int index = random.Next(ThemerColor.ColorList.Count);
            while (tempIndex == index)
            {
                random.Next(ThemerColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemerColor.ColorList[index];
            return ColorTranslator.FromHtml(color); 
        }
    }
}