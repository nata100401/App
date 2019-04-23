using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;




namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba el valor a prestar: ");
            string numero = Console.ReadLine();
            int valorPrestado = int.Parse(numero);

            Console.WriteLine("Fecha de consignaciónr: ");
            string time = Console.ReadLine();
            DateTime fechaConsignacion = Convert.ToDateTime(time);
            int dia = (int)fechaConsignacion.Day;
            int mes = (int)fechaConsignacion.Month;
            Console.WriteLine("El día a consignar : " + (dia));
            DateTime fechaHoy = DateTime.Today;
            int hoy = (int)fechaHoy.Day;
            int mesHoy = (int)fechaHoy.Month;
            
            Console.WriteLine("El día de hoy : " + (hoy));
            double interesPagar = 0;
            if (mesHoy == mes)  //pille como va a cambiar la ruta de compilacion
            {
                
                int diasPasados = 0;
                for (int i = dia; i < hoy; i++)
                {
                    diasPasados++;
                    double interes = valorPrestado * 0.02 / 100;
                    interesPagar += interes;

                }

            }
            else
            {
                Console.WriteLine("Aún no se cumple el mes");
            }
          
            //Console.WriteLine("Días pasados desde fecha : " + diasPasados);

            int porcentaje = valorPrestado * 2 / 100;
            int valorTotal = valorPrestado + porcentaje;
            double valorMes = (valorTotal / 12)+interesPagar;
            //LocalTime lt=LocalTime.parse(time);
            Console.WriteLine("Valor a pagar este mes: " + valorMes);
            Console.WriteLine("Valor a pagar total: " + valorTotal);
            // ya metale el forms

           

           MessageBox.Show("El programa termino"); //c#





            // Configure the message box to be displayed


        }
    }
}
