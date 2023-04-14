using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQEjercico2
{
    internal class ControlEmpresasEmpleados
    {
        public List<Empresa> listempresas;
        public List<Empleado> listEmpleados;
        public ControlEmpresasEmpleados()
        {
            listEmpleados = new List<Empleado>();
            listempresas = new List<Empresa>();

            listempresas.Add(new Empresa { Id = 1, Nombre = "IAlpha" });
            listempresas.Add(new Empresa { Id = 2, Nombre = "Udelar" });
            listempresas.Add(new Empresa { Id = 3, Nombre = "Spacez" });

            listEmpleados.Add(new Empleado { Id = 1, Nombre = "Gonzalo", Cargo = "CEO", EmpresaId = 1, Salario = 3000 });
            listEmpleados.Add(new Empleado { Id = 2, Nombre = "JuanC", Cargo = "Desarrollador", EmpresaId = 1, Salario = 2000 });
            listEmpleados.Add(new Empleado { Id = 3, Nombre = "juanR", Cargo = "Desarrollador", EmpresaId = 1, Salario = 2000 });
            listEmpleados.Add(new Empleado { Id = 4, Nombre = "Daniel", Cargo = "Desarrollador", EmpresaId = 1, Salario = 2000 });
            listEmpleados.Add(new Empleado { Id = 5, Nombre = "Gonazalot", Cargo = "CEO", EmpresaId = 2, Salario = 2000 });
            listEmpleados.Add(new Empleado { Id = 6, Nombre = "Leonardo", Cargo = "CEO", EmpresaId = 1, Salario = 3000 });
            listEmpleados.Add(new Empleado { Id = 1, Nombre = "Gonzalo", Cargo = "CEO", EmpresaId = 3, Salario = 3000 });
            listEmpleados.Add(new Empleado { Id = 6, Nombre = "Leonardo", Cargo = "CEO", EmpresaId = 3, Salario = 3000 });

        }
        public void getSeo(string _Cargo)
        {
            IEnumerable<Empleado> empleados = from empleado in listEmpleados where empleado.Cargo == _Cargo select empleado;
            foreach (Empleado elemento in empleados)
            {
                elemento.getDatosEmpleado();
            }
        }
        public void getEmpleadosOrdenados()
        {
            IEnumerable<Empleado> empleados = from empleado in listEmpleados
                                              orderby empleado.Nombre
                                              select empleado;
            foreach (Empleado elemento in empleados)
            {
                elemento.getDatosEmpleado();
            }
        }
        public void getEmpleadosOrdenadosSegun()
        {
            IEnumerable<Empleado> empleados = from empleado in listEmpleados
                                              orderby empleado.Salario
                                              select empleado;
            foreach (Empleado elemento in empleados)
            {
                elemento.getDatosEmpleado();
            }
        }
        public void getEmpleadosEmpresa(int _Empresa)
        {
            IEnumerable<Empleado> empleados = from empleado in listEmpleados
                                              join empresa in listEmpleados on empleado.EmpresaId
                                              equals empresa.Id
                                              where empresa.Id == _Empresa
                                              select empleado;
            foreach (Empleado elemento in empleados)
            {
                elemento.getDatosEmpleado();
            }
        }
        public void promedioSalario()
        {
            var consulta = from e in listEmpleados
                           group e by e.EmpresaId into g
                           select new { empresa = g.Key, promedioSalario = g.Average(e => e.Salario) };
            foreach (var resultado in consulta)
            {
                switch (resultado.empresa)
                {
                    case 1:
                        Console.WriteLine($"Empresa IAplha - Promedio de salario: {resultado.promedioSalario}");
                        break;
                    case 2:
                        Console.WriteLine($"Empresa UdeLaR - Promedio de salario: {resultado.promedioSalario}");
                        break;
                    case 3:
                        Console.WriteLine($"Empresa Space - Promedio de salario: {resultado.promedioSalario}");
                        break;
                }
            }
        }
    }
}
}
