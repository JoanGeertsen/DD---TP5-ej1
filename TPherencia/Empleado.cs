﻿using DD_TP3_ej1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace DD_TP4_ej1
{
    internal class Empleado: Persona
    {
        #region Atributos
        private string legajo;
        private string cargo;
        private static string legajoPorDefecto = "444444";
        #endregion

        #region Constructor 
        public Empleado(string documento, string nombre, string fechaNacimiento,
            string legajo, string cargo) : base(documento, nombre, fechaNacimiento)
        {
            this.legajo = (legajo.Length == 6) ? legajo : legajoPorDefecto;
            this.cargo = (cargo != null) ? cargo : "";
        }
        #endregion

        #region Property        
        public string Legajo
        {
            get { return legajo; }
            set { legajo = (value.Length == 6) ? value : legajoPorDefecto; }
        }

        public string Carrera
        {
            get { return cargo; }
            set { cargo = (value != null) ? value : ""; }
        }
        #endregion      

        #region Consultas
        public override string ToString()
        {

            return base.ToString() + $"Cargo: {cargo} Legajo: {Legajo} ";
        }

        public override bool Equals(Object obj)
        {
            bool igual = false;

            if (obj == null)
                igual = (this == null);
            else if (this.GetType() == obj.GetType())
            {
                Empleado e = (Empleado)obj;
                igual = (dni == e.Dni && legajo == e.Legajo);
            }

            return igual;

        }

        public override int GetHashCode()
        {
            return int.Parse(dni.Replace(".", "")) * int.Parse(legajo);
        }
        #endregion
    }
}
