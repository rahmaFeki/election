﻿using System;
using System.Collections.Generic;

public class Administrateur
{
    public int id_admin { get; set; }
  
    public string nom_admin { get; set; }
    public string prenom_admin { get; set; }
    public string cin_admin { get; set; }
    public string mot_de_passe { get; set; }
    public IList<election.Candidat> Candidats { get; set; }

   
}
