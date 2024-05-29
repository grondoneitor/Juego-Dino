using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dino
{
    internal class CactusTriple : Atacantes
    {
        public CactusTriple(PictureBox pcbCactusSimple, Form form) : base(pcbCactusSimple, form)
        {
            _Sprite = pcbCactusSimple;
            _Form= form;
        }

        public override void AutoCrearse()
        {
            _Sprite.BringToFront();
            _Sprite.Location = new System.Drawing.Point(_Form.Right - 10, 200);
            _Sprite.Name = "pcbCactusTriple";
            _Sprite.Size = new System.Drawing.Size(40, 40);
            _Sprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            _Sprite.Image = Properties.Resources.cactusTriple;
            _Sprite.TabIndex = 0;
            _Sprite.TabStop = false;


            _Form.Controls.Add(_Sprite);
            // Controls.Add(pictureBox);
        }

    }
}
