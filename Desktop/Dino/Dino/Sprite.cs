using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dino
{
    internal class Sprite
    {

        public Sprite(PictureBox pictureBox) 
        {
         _Sprite = pictureBox;
        }

        public PictureBox _Sprite;


        #region coordenadas
        public int Top
        {
            get { return _Sprite.Top; }
            set { _Sprite.Top = value; }
        }
        public int Left
        {
            get { return _Sprite.Left; }
            set { _Sprite.Left = value; }
        }
        public int Width
        {
            get { return _Sprite.Width; }
            set { _Sprite.Width = value; }
        }
        public int Height
        {
            get { return _Sprite.Height; }
            set { _Sprite.Height = value; }
        }
        #endregion coordenadas
    }

}
