using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Jugador:Persona
    {
        private float altura;
        private float peso;
        Posicion posicion;


        public float Altura { get; }
        public float Peso { get; }
        public Posicion Posicion { get; }



        Jugador(string apellido, string nombre, int edad, int dni,float altura,float peso, Posicion posicion):base(apellido,nombre,edad,dni)
        {
            this.altura = altura;
            this.peso = peso;
            this.posicion = posicion;
        }


        public bool ValidarEstadoFisico()
        {
            float imc;
            imc = peso / (altura * altura);
            if(imc>=18.5 && imc<=25)
            {
                return true;
            }
            else
            {
                return false;
            }

           
        }
        public override string Mostrar()
        {
            throw new NotImplementedException();
        }



    }
}
