using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libreria
{
    public partial class Lista : Form
    {
        string _nome;
        string _categoria;
        bool _visibilita;

        public Lista(string nome, string categoria)
        {
            if (String.IsNullOrEmpty(nome))
                throw new ArgumentException("Nome nullo");
            if (String.IsNullOrEmpty(categoria))
                throw new ArgumentException("Categoria nulla");
            _nome = nome;
            _categoria = categoria;
            _visibilita = false;
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }

        public string Categoria
        {
            get
            {
                return _categoria;
            }
            set
            {
                _categoria = value;
            }
        }

        public bool Visibilita
        {
            get
            {
                return _visibilita;
            }
            set
            {
                _visibilita = value;
            }
        }

    }
}
