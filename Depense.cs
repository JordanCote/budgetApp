using System;

namespace domain
{
    public class Depense
    {
        public Depense(Date dateDebut, Date dateFin, double montant, Date frequence)
        {
            DateDebut = dateDebut;
            DateFin = dateFin;
        }

        private Date DateDebut { get; set; }
        private Date DateFin { get; set; }
        private Date montant { get; set; }
        private Date frequence { get; set; }

    }
}