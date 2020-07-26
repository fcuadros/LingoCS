using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Datos
    {
        private String usuario;
        private String password;

        private int idtabla;
        private decimal idtipotela;
        private decimal idmes;
        private decimal valornumerico;
        private string valorcadena;
        //private Double vporcentajeasig;

        public String Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        public Int32 IdTabla
        {
            get { return idtabla; }
            set { idtabla = value; }
        }

        public decimal IdTipoTela
        {
            get { return idtipotela; }
            set { idtipotela = value; }
        }

        public decimal IdMes
        {
            get { return idmes; }
            set { idmes = value; }
        }
        public decimal ValorNumerico
        {
            get { return valornumerico; }
            set { valornumerico = value; }
        }
        public string ValorCadena
        {
            get { return valorcadena; }
            set { valorcadena = value; }
        }
    }
}
