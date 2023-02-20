using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokedex_nacional
{
    internal class Pokemons
    {
        public string numero, nombre, t1, t2, total, hp, ataque, defensa, sataque, despecial, velocidad, generacion, calidad;

        public Pokemons(string numero, string nombre, string t1, string t2, string total, string hp, string ataque, string defensa, string sataque, string despecial, string velocidad, string generacion, string calidad)
        {
            this.numero = numero;
            this.nombre = nombre;
            this.t1 = t1;
            this.t2 = t2;
            this.total = total;
            this.hp = hp;
            this.ataque = ataque;
            this.defensa = defensa;
            this.sataque = sataque;
            this.despecial = despecial;
            this.velocidad = velocidad;
            this.generacion = generacion;
            this.calidad = calidad;
        }
    }
}
