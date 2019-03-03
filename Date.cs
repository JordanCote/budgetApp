using System;

namespace domain
{
    public class Date
    {
        private uint jour, mois, annee;
        private int m_code; //nb jours depuis 1970-01-01
        public Date(uint jour, uint mois, uint annee)
        {
            this.jour = jour;
            this.mois = mois;
            this.annee = annee;
            encode(jour, mois, annee);
        }

        private void encode(uint jour, uint mois, uint annee)
        {
            mois -= 2;
            if (mois <= 0)
            {
                mois += 12;
                annee -= 1;
            }
            m_code = (int)(annee / 4 - annee / 100 + annee / 400 + 367 * mois / 12 + jour);
            m_code = (int)(m_code + 365 * annee - 719499);
        }

        // override object.Equals
        //public static bool operator ==(Date date1, Date date2) { Equals(date1.m_code, date2.m_code); }
        //public static bool operator!= (Date date1, Date date2) => !Equals(date1.m_code, date2.m_code);


    }
}