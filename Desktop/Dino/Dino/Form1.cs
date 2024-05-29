using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dino
{
    public partial class Form1 : Form
    {
        EL_Dino dino;
        CactusSimple cactus;
        CactusTriple cactusTriple;
        Suelo suelo;
        public Form1()
        {
            InitializeComponent();
            dino = new EL_Dino(pcbDino);
            cactus = new CactusSimple(new PictureBox(),this);
            cactusTriple = new CactusTriple(new PictureBox(),this);
            suelo = new Suelo(new PictureBox(), this);
        }
    
        private async void Form1_Load(object sender, EventArgs e)
        {
            dino.LlenarPCB();
            // cactus.AutoCrearse();
            List<Atacantes> atac = new List<Atacantes>();
            atac.Add(cactusTriple);
            atac.Add(cactus);

            Random random = new Random();

            int index = random.Next(atac.Count());

            Atacantes atacantes = atac[index];
            atacantes.AutoCrearse();

            List<Suelo> suelo = new List<Suelo>();
            suelo.Add(new Suelo(new PictureBox(), this));
            suelo.Add(new Suelo(new PictureBox(), this));
            suelo.Add(new Suelo(new PictureBox(), this));
            suelo[0].AutoCrearse();
            suelo[0].Moverse();
            await atacantes.Moverse();
   

            do
            {
                if (suelo[0].Volver()) 
                {
                    suelo[1].AutoCrearse();
                    suelo[1].Moverse();

                }

                if (atacantes.Llegar())
                {
                    List<Atacantes> otro = new List<Atacantes>();
                    otro.Add(cactusTriple);
                    otro.Add(cactus);

                    Random ran = new Random();
                    int i = ran.Next(otro.Count());

                    Atacantes ata = otro[i];
                    ata.AutoCrearse();
                   // suelo.AutoCrearse();
                    await ata.Moverse();
                }
            }while (true);

        }
        


        private async void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Keys tecla = e.KeyCode;
            if (tecla == Keys.Space)
            {
               await dino.Saltar();
            }
        }
    }
}
