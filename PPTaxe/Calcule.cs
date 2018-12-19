using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPTaxe
{
    class Calcule
    {
        /// <summary>
        /// Additionne 2 nombre string
        /// </summary>
        /// <param name="Nombre1">Premier Nombre</param>
        /// <param name="Nombre2">Deuxième Nombre</param>
        /// <returns></returns>
        public int Addition2TextBox(string Nombre1, string Nombre2)
        {
            int Reponse = 0;
            Reponse = int.Parse(Nombre1) + int.Parse(Nombre2);
            return Reponse;
        }

        /// <summary>
        /// Multiplie la taxe TPS a un montant donner
        /// </summary>
        /// <param name="Montant"></param>
        /// <returns></returns>
        public decimal CalculerTPS(string Montant)
        {
            decimal tps = 0;

            tps = decimal.Parse(Montant);

            tps = tps * 0.1m;

            return tps;
        }
        /// <summary>
        /// Multiplie la taxe TVQ a un montant donner
        /// </summary>
        /// <param name="Montant"></param>
        /// <returns></returns>
        public decimal CalculerTVQ(string Montant)
        {
            decimal tvq = 0m;

            tvq = decimal.Parse(Montant);

            tvq = tvq * 0.05m;

            return tvq;
        }
    }
}
