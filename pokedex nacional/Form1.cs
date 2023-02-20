using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pokedex_nacional
{
    public partial class Form1 : Form
    {
        List<Pokemons> Pkm;
        public Form1()
        {
            Pkm = new List<Pokemons>();
            InitializeComponent();
            this.panel1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            
            StreamReader pokemon = new StreamReader("pokemon.csv");
            while (!pokemon.EndOfStream)
            {
                var linea = pokemon.ReadLine().Split(',');
                string NumeroP = linea[0];
                string Name = linea[1];
                string tipo1 = linea[2];
                string tipo2 = linea[3];
                string total = linea[4];
                string hp = linea[5];
                string ataque = linea[6];
                string defensa = linea[7];
                string Aspecial = linea[8];
                string dEspecial = linea[9];
                string velocidad = linea[10];
                string Generacion = linea[11];
                string Calidad = linea[12];
                Pokemons pokedex = new Pokemons(NumeroP, Name, tipo1, tipo2, total, hp, ataque, defensa, Aspecial, dEspecial,velocidad, Generacion, Calidad);
                Pkm.Add(pokedex);
            }
            pokemon.Close();

            foreach (var vr in Pkm)
            {
                if (id == vr.numero || id == vr.nombre)
                {
                    LID.Text = vr.numero;
                    ln.Text = vr.nombre;
                    lP1.Text = vr.t1;
                    lt2.Text = vr.t2;
                    lt.Text = vr.total;
                    lHp.Text = vr.hp;
                    Lg.Text = vr.generacion;
                    lAt.Text = vr.ataque;
                    lD.Text = vr.defensa;
                    lsa.Text = vr.sataque;
                    lSD.Text = vr.despecial;
                    lV.Text = vr.velocidad;
                    lr.Text = vr.calidad;                   
                    textBox1.Clear();
                    
                    break;
                }
                else
                {
                    LID.Text = "Pokemon no Encontrado, sal y registralo entrenador";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.panel1.Show();
            StreamReader pokemons = new StreamReader("pokemon.csv");
            textBox2.Text = pokemons.ReadToEnd();
            pokemons.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.panel1.Hide();
        }
    }
}
