using System;
using System.Collections.Generic;
using System.Linq;
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
        Nubes nubes;
        public Form1()
        {
            InitializeComponent();
            dino = new EL_Dino(pcbDino, this);
            cactus = new CactusSimple(new PictureBox(), this);
            cactusTriple = new CactusTriple(new PictureBox(), this);
            suelo = new Suelo(new PictureBox(), this);
            nubes = new Nubes(new PictureBox(), this);
        }
        private bool Saltando = false;

        private async void Form1_Load(object sender, EventArgs e)
        {

            dino.LlenarPCB();

            var caminarTask = dino.Caminar();

//            dino.Caminar(Saltando);


            nubes.Moverse();
            
            //nubes.AutoCrearse();
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
            suelo[0].AutoCrearse();
            suelo[0].Moverse();
            await atacantes.Moverse();


            int num = 1;
            do
            {
      

                for ( int j = 0; j <= 1; j++)
                {
                    suelo.Add(new Suelo(new PictureBox(), this));

                }
                if (suelo[0].Volver())
                {
                    suelo[num].AutoCrearse();
                    suelo[num].Moverse();
               

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
                dino.Caminar();
                num++;
            } while (true);

        }


        private async void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Keys tecla = e.KeyCode;
          
            if (tecla == Keys.Space)
            {
                Saltando = true;
               // dino.Caminar(Saltando);
                
                dino.Saltar();

             //   await Task.Delay(1000); 
            }
            Saltando = false;
        }
    }
}
