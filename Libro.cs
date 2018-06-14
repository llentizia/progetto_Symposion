using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public enum Genre
    {
        Avventura,
        Classici,
        Fantascienza,
        Fantasy,
        Giallo,
        Horror,
        Personale,
        Romanzo,
        Thriller,
        Umorismo,
    }

    class Libro
    {
        

        string _titolo;
        string _autore;
        int _anno;
        Genre _genere;


        public Libro(string titolo, string autore, int? anno, string genereString)
        {
            if (String.IsNullOrEmpty(titolo))
                throw new ArgumentException("Titolo nullo");
            if (String.IsNullOrEmpty(autore))
                throw new ArgumentException("Autore nullo");
            if (anno == null)
                throw new ArgumentException("Anno nullo");
            if (String.IsNullOrEmpty(genereString))
                throw new ArgumentException("Genere nullo");

            _titolo = titolo;
            _autore = autore;
            _anno = (int)anno;

            if (Enum.TryParse(genereString, out _genere))
                if (!Enum.IsDefined(typeof(Genre), _genere))
                    throw new ArgumentException("Genere non valido");
        }

        public string Titolo
        {
            set; get; 
        }

        public string Autore
        {
            set
            {
                _autore = value;
            }
            get
            {
                return _autore;
            }
        }

        public int Anno
        {
            set
            {
                _anno = value;
            }
            get
            {
                return _anno;
            }
        }

        public Genre Genere
        {
            set
            {
                _genere = value;
            }
            get
            {
                return _genere;
            }
        }
    }
}
