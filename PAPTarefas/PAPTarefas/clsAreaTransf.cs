using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAPTarefas
{
    class clsAreaTransf
    {

        // tem duas propriedades para gravar valores (valor e valor2)
        //ID
        private static string _valor = "";
        public static string valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        //Nome
        private static string _valor2 = "";
        public static string valor2
        {
            get { return _valor2; }
            set { _valor2 = value; }
        }

        //Tarefa
        private static string _valor3 = "";
        public static string valor3
        {
            get { return _valor3; }
            set { _valor3 = value; }
        }

        //Data
        private static string _valor4 = "";
        public static string valor4
        {
            get { return _valor4; }
            set { _valor4 = value; }
        }

        //Pontos
        private static string _valor5 = "";
        public static string valor5
        {
            get { return _valor5; }
            set { _valor5 = value; }
        }
    }
}
