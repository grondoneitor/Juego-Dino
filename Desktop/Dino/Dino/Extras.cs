using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dino
{
    internal class Extras : Sprite
    {

        public Extras(PictureBox pcbExtras): base(pcbExtras)
        {
            _Sprite = pcbExtras;
        }

        //public virtual Task Moverse()
        //{
        //    throw new NotImplementedException();
        //}
        public virtual void AutoCrearse()
        {

        }
        public virtual void Volver()
        {

        }


    }
}
