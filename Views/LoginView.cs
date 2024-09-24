using System;
using System.Drawing;
using System.Drawing.Text;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WaterRefillingSystem.Assets;
using WaterRefillingSystem.Data;
using WaterRefillingSystem.Services;


namespace WaterRefillingSystem.Views
{
    public sealed partial class LoginView : Form
    {
        private PrivateFontCollection _privateFonts = new PrivateFontCollection();
        
        private FontManager _fontManager;


        public LoginView()
        {
            // Initialize the font manager
            _fontManager = new FontManager();
            InitializeComponent();
            InitShit();
        }

        private void InitShit()
        {
            pbLogo.Image = Image.FromFile(Commons.ImagesDirectory + @"\Login2.png");
            panel2.BackColor = Colors.BrightBlue;
        }

        private void InitializeCustomFonts()
        {
            // Get the Poppins font
            var poppinsFont = _fontManager.GetFont("Poppins", 12f);
            var latoFont = _fontManager.GetFont("Lato", 17f);
            Console.WriteLine(Commons.AssetsDirectory);


            // // Apply the Poppins font to label1
            label4.Font = _fontManager.GetFont("Poppins", 28f);
            // label1.Font = _fontManager.GetFont("Lato", 28f);
            label4.Text = "Welcome Back!";
            //
            // // Apply the Lato font to label2
            label2.Font = _fontManager.GetFont("Lato", 10f);
            // label2.Text = "This is Lato Font That is not something";

            label3.Font = latoFont;
            label3.Text = "Something??";
        }

        private void LoadCustomFont()
        {
            // Load the custom font from the embedded resource
            string fontResourceName = "WaterRefillingSystem.Resources.PlayfairDisplay_Regular.ttf";
            using (var fontStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(fontResourceName))
            {
                if (fontStream != null)
                {
                    byte[] fontData = new byte[fontStream.Length];
                    fontStream.Read(fontData, 0, (int)fontStream.Length);

                    // Allocate memory and copy font data to it
                    IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
                    Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
                    
                    // Add the font to the PrivateFontCollection
                    _privateFonts.AddMemoryFont(fontPtr, fontData.Length);
                    
                    // Free the allocated memory
                    Marshal.FreeCoTaskMem(fontPtr);
                }
            }
        }

        private void ApplyCustomFontToControls()
        {
            if (_privateFonts.Families.Length > 0)
            {
                Font customFont = new Font(_privateFonts.Families[0], 28);
                
                // Apply the custom font to controls
                label4.Font = customFont;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            // Clean up resources
            
        }
    }
}