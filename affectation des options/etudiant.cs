﻿using System;
using System.Collections.Generic;
using System.Text;

namespace affectation_des_options
{
    class etudiant
    {
        public string nomET;
        public string prenomET;
        public double noteET;

        public etudiant(string nome, string pren, double note1année)
        {
            this.nomET = nome;
            this.prenomET = pren;
            this.noteET = note1année;
        }
    }
}
