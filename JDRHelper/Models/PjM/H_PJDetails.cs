﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JDRHelper.Models
{
    public class H_PJDetails
    {
        private string _nomStat;
        private int _valeurStat;
        private int _Id_Stat;

        public string Nom { get => _nomStat; set => _nomStat = value; }
        public int Valeur { get => _valeurStat; set => _valeurStat = value; }
        public int Id { get => _Id_Stat; set => _Id_Stat = value; }
    }
}