using System;

namespace DominoBMPCompile
{
    class Image
        {
        //set properties of the image
        public String textToRender { get; set; }
        public float xPosition { get; set; }
        public float yPosition { get; set; }
        public String fontName { get; set; }
        public int fontSize { get; set; }
        public int angleOfText { get; set; }
        public String saveLocation { get; set; }
        public string comments { get; set; }

        public Image(String _textToRender,float _xPosition,float _yPosition, String _fontName,int _fontSize, 
            int _angleOfText, string _saveLocation, string _comments )
        {
            this.textToRender = _textToRender;
            this.xPosition = _xPosition;
            this.yPosition = _yPosition;
            this.fontName = _fontName;
            this.fontSize = _fontSize;
            this.angleOfText = _angleOfText;
            this.saveLocation = _saveLocation;
            this.comments = _comments;
        }
    }
}
