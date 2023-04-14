using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQEjercico2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ControlEmpresasEmpleados ce = new ControlEmpresasEmpleados();
            Console.WriteLine("********************* Promedios por empresa *********************\n");
            ce.promedioSalario();
            H();

            Console.WriteLine("********************* Peces Gordos *********************\n");
            ce.getSeo("CEO");
            H();

            Console.WriteLine("");
            Console.WriteLine("********************* Plantilla  *********************\n");
            ce.getEmpleadosOrdenados();
            H();

            Console.WriteLine("********************* Plantilla ordenada por salario *********************\n");
            ce.getEmpleadosOrdenadosSegun();
            H();

            Console.WriteLine("\n Intrese la empresa :( entero 1 a 6 )\n1 - Ialpha\n2 -UdeLaR\n3 - SpaceZ \n4 - Omegao \n5 - BetaB \n6 - GammaF ");
            string _Id = Console.ReadLine();
            try
            {
                int _Empresa = int.Parse(_Id);
                ce.getEmpleadosEmpresa(_Empresa);
            }
            catch
            {
                Console.WriteLine("Ha introducido un Id erroneo. Debe Ingresar un numero entero");
            }
            H();
        }
        static void H()
        {
            Console.WriteLine("\n\nContinar");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
