using System;

namespace domain
{
    public class depenseRecurrente : Depense
    {
        public depenseRecurrente(Date dateDebut, Date dateFin, double montant, Date frequence) : base(dateDebut, dateFin, montant, frequence)
        {

        }
    }
}
