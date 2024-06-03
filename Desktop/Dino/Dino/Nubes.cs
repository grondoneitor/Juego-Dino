using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dino
{
    internal class Nubes : Extras
    {
        public Nubes(PictureBox pcbNubes, Form form) : base(pcbNubes, form)
        {
            _Sprite = pcbNubes;
            _Form = form;
        }


        public override void AutoCrearse()
        {
     
                _Sprite.SendToBack();
                _Sprite.Location = new System.Drawing.Point(_Form.Right, 40);
                _Sprite.Name = "pcbNubes";
                _Sprite.Size = new System.Drawing.Size(92, 27);
                _Sprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                _Sprite.Image = Properties.Resources.nubeOriginal;
                _Sprite.TabIndex = 0;
                _Sprite.TabStop = false;


                _Form.Controls.Add(_Sprite);
            
            // Controls.Add(pictureBox);
        }


        public override async Task Moverse()
        {
            //if (_Sprite != null && _Sprite.Parent != null)
            //{
                List<Nubes> nubes = new List<Nubes>();
                nubes.Add(new Nubes(_Sprite, _Form));
                nubes[0].AutoCrearse();
                int num = 0;
                do
                {
 
                nubes[num].Left -= 5;
                    await Task.Delay(50);
                   
                //  await Task.Delay(4000);
                   if (nubes[num].Left <= _Form.Right / 2)
                   {

                    if (num != 0)
                    {
                        nubes[num].AutoCrearse();

                    }
                    nubes.Add(new Nubes(_Sprite, _Form));

                    num++;

                   }

                } while (_Sprite.Right >= 0); // Detén el movimiento cuando el atacante salga del área visible
            //}

 

        }



    }
}
