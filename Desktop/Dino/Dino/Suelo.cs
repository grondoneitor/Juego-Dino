using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dino
{
    internal class Suelo : Extras 
    {
        public Suelo(PictureBox pcbSuelo, Form form): base(pcbSuelo, form) 
        {
            _Sprite = pcbSuelo;
            _Form = form;   
        }

        
        public override  void AutoCrearse()
        {
     
                _Sprite.SendToBack();
                _Sprite.Location = new System.Drawing.Point(0, 236);
                _Sprite.Name = "pcbSuelo";
                _Sprite.Size = new System.Drawing.Size(1400, 20);
                _Sprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                _Sprite.Image = Properties.Resources.suelo;
                _Sprite.TabIndex = 0;
                _Sprite.TabStop = false;


                _Form.Controls.Add(_Sprite);
            
            // Controls.Add(pictureBox);
        }
        public override async Task Moverse()
        {
            if (_Sprite != null && _Sprite.Parent != null)
            {
                do
                {
                    _Sprite.Left -= 20;
                    await Task.Delay(50);
                } while (_Sprite.Right >= 0); // Detén el movimiento cuando el atacante salga del área visible
            }
        }

        public bool Volver()
        {
            bool llego = false;
            if (_Sprite != null && _Sprite.Parent != null)
            {
          
             //   if (_Sprite.Left <= _Form.Right) 
               // {
                    llego = true;
                //}
                
            }
            return llego;
        }
    }
}
