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
          //  _Sprite.Location = new System.Drawing.Point(_Form.Right, 40);
            _Sprite.Name = "pcbNubes";
            _Sprite.Size = new System.Drawing.Size(92, 27);
            _Sprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
           // _Sprite.BorderStyle = BorderStyle.FixedSingle;
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
            nubes.Add(new Nubes(new PictureBox(), _Form));
            int num = 0;
            nubes[num ]._Sprite.Location = new System.Drawing.Point(_Form.Right, 40);
            nubes[num].AutoCrearse();
 

            bool nubeCreada = false;
            do
            {
                for (int i = 0; i < 1; i++)
                {
                    if (nubes.Contains(nubes[num]))
                    {
                        nubes[num].Left -= 5;
                        await Task.Delay(50);
                    }
                    if (nubes[num].Left <= _Form.Width / 2 && !nubeCreada)
                    {
                        nubes.Add(new Nubes(new PictureBox(), _Form));
                        //nubes[num + 1 ].AutoCrearse();

                        if(num % 2 == 0)
                        {
                            nubes[num +1]._Sprite.Location = new System.Drawing.Point(_Form.Right, 80);
                            nubes[num + 1].AutoCrearse();
                        }
                        else
                        {
                            nubes[num + 1]._Sprite.Location = new System.Drawing.Point(_Form.Right, 40);
                            nubes[num + 1].AutoCrearse();

                        }

                        nubeCreada = true;
                    }
                    if (nubeCreada)
                    {
                        nubes[num +1].Left -= 5;
                        await Task.Delay(50);
                    }

                    if (nubes[num].Left + nubes[num].Width   <= 0 )
                    {
                        nubes[num]._Sprite.Image = null;
                        //nubes.Remove(nubes[num]);
                        num++;
                        nubeCreada = false;
                    }

                }




            } while (true); // Detén el movimiento cuando el atacante salga del área visible
                            //}

            //public async Task Moverseeee(List<Nubes> nubes)
            //{
            //    int numm = 0;
            //    nubes.Add(new Nubes(new PictureBox(), _Form));
            //    do
            //    {
            //        foreach (var nube in nubes.ToList())
            //        {
            //            nube._Sprite.Left -= 5;
            //            await Task.Delay(50);

            //            // Verifica si la nube actual ha llegado a la mitad de la ventana
            //            if (nube._Sprite.Left <= _Form.Width / 2 && !nubes.Any(n => n._Sprite == nube._Sprite && n._Sprite != nube._Sprite))
            //            {
            //                // Crea una nueva nube y agrégala a la lista
            //                var nuevaNube = new Nubes(new PictureBox(), _Form);
            //                nubes.Add(nuevaNube);
            //                nuevaNube.AutoCrearse();
            //            }
            //        }
            //    } while (true); // Detén el movimiento cuando el atacante salga del área visible
            //}


        }



    } }

