using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace WaterRefillingSystem
{
    public class FontManager : IDisposable
    {
        private PrivateFontCollection _privateFonts;
        private List<IntPtr> _fontDataPointers;
        private Dictionary<string, FontFamily> _fontFamilies;

        public FontManager()
        {
            _privateFonts = new PrivateFontCollection();
            _fontDataPointers = new List<IntPtr>();
            _fontFamilies = new Dictionary<string, FontFamily>();
            
            LoadFonts();
        }
        
        private void LoadFonts()
        {
            // Load Lato font
            //LoadFont(Properties.Resources.Lato_Regular);
            // Load Poppins font
            //LoadFont(Properties.Resources.Poppins_Regular);
        }


        private void LoadFont(byte[] fontData)
        {
            // Allocate unmanaged memory and copy font data
            IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
            Marshal.Copy(fontData, 0, fontPtr, fontData.Length);

            // Add the font to the private font collection
            _privateFonts.AddMemoryFont(fontPtr, fontData.Length);

            // Keep track of the font data pointers to free them later
            _fontDataPointers.Add(fontPtr);

            // Get the loaded FontFamily
            FontFamily fontFamily = _privateFonts.Families[_privateFonts.Families.Length - 1];

            // // Output the font family name for debugging
            // Console.WriteLine($"Loaded font family: '{fontFamily.Name}'");

            // Extract and standardize the font family name
            string fontFamilyName = fontFamily.Name;
            if (fontFamilyName.EndsWith(" Regular", StringComparison.OrdinalIgnoreCase))
            {
                fontFamilyName = Replace(fontFamilyName, " Regular", "", StringComparison.OrdinalIgnoreCase).Trim();
            }

            // Store the FontFamily using its name as the key
            if (!_fontFamilies.ContainsKey(fontFamilyName))
            {
                _fontFamilies.Add(fontFamilyName, fontFamily);
            }
        }
        
        private static string Replace(string original, string pattern, string replacement, StringComparison comparison)
        {
            int position = 0;
            int patternLength = pattern.Length;
            int replacementLength = replacement.Length;

            while ((position = original.IndexOf(pattern, position, comparison)) != -1)
            {
                original = original.Remove(position, patternLength).Insert(position, replacement);
                position += replacementLength;
            }

            return original;
        }

        public Font GetFont(string fontFamilyName, float size, FontStyle style = FontStyle.Regular)
        {
            if (_fontFamilies.TryGetValue(fontFamilyName, out FontFamily fontFamily))
            {
                return new Font(fontFamily, size, style);
            }
            else
            {
                throw new InvalidOperationException($"Font family '{fontFamilyName}' not found.");
            }
        }

        public IEnumerable<string> GetLoadedFontFamilies()
        {
            return _fontFamilies.Keys;
        }


        public void Dispose()
        {
            // Dispose of the PrivateFontCollection
            if (_privateFonts != null)
            {
                _privateFonts.Dispose();
                _privateFonts = null;
            }

            // Free all allocated unmanaged memory
            foreach (var ptr in _fontDataPointers)
            {
                if (ptr != IntPtr.Zero)
                {
                    Marshal.FreeCoTaskMem(ptr);
                }
            }

            _fontDataPointers.Clear();

            // Clear the font families dictionary
            _fontFamilies.Clear();
        }
    }
}