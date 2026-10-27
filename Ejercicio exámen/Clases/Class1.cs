using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Alumno
    {
        //Campos privados
        private string _nombre;
        private string _dni;
        private string _curso;
        private DateTime _inicioCurso;
        private double _pagado = 0;
        private double _precioMatricula;

        //Propiedades
        public DateTime InicioCurso
        {
            get
            {
                return _inicioCurso;
            }
        }

        public double PrecioMatricula
        {
            get
            {
                return _precioMatricula;
            }
        }

        //Constructor
        public Alumno(string nombre, string dni)
        {
            _nombre = nombre;
            _dni = dni;
        }

        //Métodos
        public void ApuntarCurso(string nombreCurso)
        {
            _curso = nombreCurso.ToLower();
            
            if (_curso == "aleman" || _curso == "alemán") //Abono alemán
            {
                _precioMatricula = 90;
                _inicioCurso = new DateTime(2026, 9, 2);
            }
            else if (_curso == "frances" || _curso == "francés") //Abono francés
            {
                _precioMatricula = 110;
                _inicioCurso = new DateTime(2026, 9, 3);
            }
            else if (_curso == "ingles" || _curso == "inglés") //Abono inglés
            {
                _precioMatricula = 80;
                _inicioCurso = new DateTime(2026, 9, 4);
            }
        }

        public bool AplicarDescuento(DateTime fechaNacimiento)
        {
            int edad = (int)(((DateTime.Now - fechaNacimiento).TotalDays) / 365.25);
            if (edad < 18)
            {
                _precioMatricula /= 2;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void IngresarDinero(double ingresado)
        {
            _pagado += ingresado;
        }

        public bool HaPagadoTodo()
        {
            if (_pagado >= _precioMatricula)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CursoEmpezado()
        {
            if (_inicioCurso <= DateTime.Now)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int DiasHastaComienzo()
        {
            return (int)(_inicioCurso - DateTime.Now).TotalDays;
        }

        public string MostrarInformacion()
        {
            return $"El alumno/a con nombre {_nombre} se ha apuntado al curso {_curso} con un coste de {_precioMatricula} y ha abonado {_pagado}";
        }
    }
}
