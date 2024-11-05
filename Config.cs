using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Sinema_Otomasyonu
{
    public class Config
    {
        public string Name { get; set; }

        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }


        public Color ToColor()
        {
            return Color.FromArgb(Red, Green, Blue);
        }

        public static Config FromColor(Color color , string ColorName)
        {
            return new Config
            {
                Name = ColorName,
                Red = color.R,
                Green = color.G,
                Blue = color.B
            };
        }

        public void SaveColor(Color color , string path)
        {
            var ColorData = FromColor(color, "UserColor");
            string json = JsonConvert.SerializeObject(FromColor(color, "UserColor"));
            System.IO.File.WriteAllText(path, json);
        }
    }
}
