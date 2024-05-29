using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dino
{
    internal class Atacantes : Extras
    {
        public Atacantes(PictureBox pcbAtacantes, Form form) : base(pcbAtacantes, form)
        {
            _Sprite = pcbAtacantes;
            _Form = form;
        }
        public async Task Moverse()
        {
            // Verifica que _Sprite y _Sprite.Parent no sean null antes de acceder a sus propiedades
            if (_Sprite != null && _Sprite.Parent != null)
            {
                do
                {
                    _Sprite.Left -= 20;
                    await Task.Delay(50);
                } while (_Sprite.Right >= 0); // Detén el movimiento cuando el atacante salga del área visible
            }
            else
            {
                // Manejar el caso en el que _Sprite o _Sprite.Parent sean null
                // Puedes mostrar un mensaje de error o realizar alguna acción de manejo específica
            }
        }
        public  bool Llegar() 
        {
            bool llego = false;
            if ((_Sprite.Left + _Sprite.Width) <= _Sprite.Parent.Left)
            { 
             llego = true;
            }
            return llego;
        }
             
    }
}
