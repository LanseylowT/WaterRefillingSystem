using System;
using System.IO;

namespace WaterRefillingSystem.Data
{
    public class Commons
    {
        public static readonly string BaseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        public static readonly string ProjectDirectory = Path.GetFullPath(Path.Combine(BaseDirectory, @"..\.."));
        public static readonly string AssetsDirectory = Path.Combine(ProjectDirectory, "Resources");
        public static readonly string ImagesDirectory = Path.Combine(AssetsDirectory, "Images");
        
        public static readonly string DefaultFontName = "Poppins";
        public static readonly float DefaultFontSize = 12f;

        public static readonly string ConnectionString =
            "Server=localhost;Database=waterrefilling_system;User ID=root;Password=Lansilot@123;";
    }
}