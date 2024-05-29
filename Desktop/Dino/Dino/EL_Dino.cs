using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dino
{
    internal class EL_Dino : Sprite
    {
        public EL_Dino(PictureBox pcbDino): base(pcbDino)
        {
            _Sprite=pcbDino;
        }

        public bool saltar = false;
        public void LlenarPCB()
        {
            _Sprite.Image = Properties.Resources.dino1;
        }
        public async Task Saltar()
        {
            if (saltar == false)
            {
                saltar = true;
                _Sprite.Top -= 80;

                await Task.Delay(1000);

                _Sprite.Top += 80;
                saltar = false;

            }
        }

    }
}
