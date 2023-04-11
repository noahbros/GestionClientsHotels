using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionClientsHotel
{
    internal class Client
    {

        /*
        -- PROPRIÉTÉS ET ATTRIBUTS -- 
        */
        private string Nom { get; set; }
        private string Prenom { get; set; }
        private string Courriel { get; set; }
        private string  CarteCredit { get; set; }
        private int numChambre { get; set; }

        /*
        -- CONSTRUCTEUR -- 
        */
        /// <summary>
        /// Constructeur polyadique initialisant tout les attributs de la classe Client.
        /// </summary>
        /// <param name="nom">Le nom de famille du client.</param>
        /// <param name="prenom">Le prénom du client.</param>
        /// <param name="courriel">L'adresse courriel du client.</param>
        /// <param name="carteDeCredit">La carte de crédit du client.</param>
        /// <param name="numeroDeChambre">Le numéro de chambre du client.</param>
        public Client(string nom, string prenom, string courriel, string carteDeCredit, int numeroDeChambre)
        {
            Nom = nom;
            Prenom = prenom;
            Courriel= courriel;
            CarteCredit= carteDeCredit;
            numChambre= numeroDeChambre;
        }


    }
}
