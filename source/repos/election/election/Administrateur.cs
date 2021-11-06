using System;

public class Administrateur
{
    public int id_admin { get; set; }
  
    public string nom_admin { get; set; }
    public string prenom_admin { get; set; }
    public string cin_admin { get; set; }
    public string mot_de_passe { get; set; }
    public IList<Candidat>Candidats { get; set; }

   
}
