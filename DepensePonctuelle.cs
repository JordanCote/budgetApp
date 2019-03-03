using System;

namespace domain
{
    public class depensePontuelle : Depense
    {
        private Date datePonctuelle;
        public depensePontuelle(Date dateDebut, Date dateFin, double montant, Date frequence) : base(dateDebut, dateFin, montant, frequence)
        {

            if (dateDebut == datePonctuelle) datePonctuelle = dateDebut;
            else
            {
                Console.WriteLine("error dans creation depensePonctuelle.");
            }

        }
    }
}
