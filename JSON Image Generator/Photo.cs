using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSON_Image_Generator
{
    class Photo
    {
        private Image image;
        private string filePath;

        private string pictureName;
        private string pictureDescription;
        private int width, height;

        public Photo(string filePath)
        {
            this.image = Image.FromFile(filePath);
            
            this.filePath = filePath;
            
            this.pictureName = filePath.Substring(filePath.LastIndexOf("/") + 1);
            this.pictureDescription = "";

            this.width = this.image.Width;
            this.height = this.image.Height;
        }

        public void ReadJSON(JsonTextReader reader)
        {
        }

        public void WriteJSON(JsonTextWriter writer)
        {
            writer.WriteStartObject();

            writer.WritePropertyName("filePath");
            writer.WriteValue(this.filePath);

            writer.WriteEndObject();
        }

        public string Path
        {
            get
            {
                return this.filePath;
            }
        }

        public string Name
        {
            get
            {
                return this.pictureName;
            }
            set
            {
                this.pictureName = value;
            }
        }
        public string Description
        {
            get
            {
                return this.pictureDescription;
            }
            set
            {
                this.pictureDescription = value;
            }
        }
        public int Width
        {
            get
            {
                return this.width;
            }
        }
        public int Height
        {
            get
            {
                return this.height;
            }
        }
    }
}
