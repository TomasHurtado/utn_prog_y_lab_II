using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicioenclase
{
  class Empleado
  {

    string nombre;
    string apellido;
    double sueldobruto;
    double sueldoneto;
    double jubilacion;
    double ley;
    double obrasocial;
    double sindicatos;
   
   

    public void Cargar(string nombre, string apellido, double sueldobruto,double sueldoneto, double jubilacion, double ley,double obrasocial)
    {
      this.nombre = nombre; ;
      this.apellido = apellido;
      this.sueldobruto = sueldobruto;
      this.sueldoneto = sueldoneto;
      this.jubilacion = jubilacion;
      this.ley = ley;
      this.obrasocial = obrasocial;

    }


  public void Cargar(string nombre,string apellido,double sueldobruto)
    {
      this.nombre = nombre;
      this.apellido = apellido;
      this.sueldobruto = sueldobruto;
      sueldoneto = CalcularNeto(sueldobruto);
    }

    public double CalcularNeto(double sueldobruto)
    {

      jubilacion = (sueldobruto * 11) / 100;
      ley = (sueldobruto * 3) / 100;
      obrasocial = (sueldobruto * 3) / 100;
      sueldoneto = sueldobruto - (jubilacion + ley + obrasocial);
      return sueldoneto;
    }

    public double CalcularNeto(bool sindicato)
    {
     // sueldoneto=CalcularNeto(sueldobruto);
      if(sindicato==true)
      {
        sindicatos = (sueldoneto * 2) / 100;
        sueldoneto = sueldoneto - sindicatos;
      }
      return sueldoneto;
    }


    public void Mostrar()
    {
      Console.WriteLine("Nombre: " + nombre + "\nApellido: " + apellido+ "\nSueldo Bruto: " + sueldobruto+ "\nSueldo Neto: " + sueldoneto+ "\nJubilacion:" + jubilacion+ "\nLey19032: " + ley+ "\nObra social: " + obrasocial+"\nSindicato: "+sindicatos);

    }

    public void Aumento(double aumento)
    {
      double cuenta;
      cuenta=sueldobruto+((sueldobruto*aumento)/ 100);
      CalcularNeto(cuenta);
      this.sueldobruto = cuenta;
      Mostrar();
    }

    public void Aumento(int aumento)
    {
      double cuenta;
      cuenta=sueldobruto+((sueldobruto*aumento)/100);
      CalcularNeto(cuenta);
      this.sueldobruto = cuenta;
      Mostrar();
    }


  }
}
