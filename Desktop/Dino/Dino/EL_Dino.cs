using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Dino
{
    internal class EL_Dino : Sprite
    {
        public EL_Dino(PictureBox pcbDino, Form form): base(pcbDino)
        {
            _Sprite=pcbDino;
            _Form = form;
        }

        private bool saltar = false;
        private bool caminando = false;
        public Form _Form;
        public void LlenarPCB()
        {       
 
            _Sprite.Image = Properties.Resources.dino1;
          
        
        }
        public async Task Saltar()
        {
            if (!saltar )
            {
                _Sprite.Image = Properties.Resources.dino1;
                saltar = true;
                _Sprite.Top -= 80;
                await Task.Delay(1000);
                _Sprite.Top += 80;
                saltar = false;
                Caminar();
            }

          
        }

        public async Task Caminar(/*bool caminando*/)
        {

            caminando = true;
            while (!saltar && caminando)
            {
                _Sprite.Image = Properties.Resources.PasoIzquierdoDino;
                await Task.Delay(120);
                if (!saltar && caminando)
                {
                    _Sprite.Image = Properties.Resources.PasoderechoDino;
                    await Task.Delay(120);
                }
            }

        }

        public void DetenerCaminar()
        {
            caminando = false;
        }

    }
}
