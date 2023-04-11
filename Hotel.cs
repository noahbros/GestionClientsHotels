using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionClientsHotel
{
    internal class Hotel
    {
        /*
         -- PROPRIÉTÉS ET ATTRIBUTS --
         */
        private List<Client> clients;
        private string Nom { get; set; }

        /*
         -- CONSTRUCTEUR --
         */
        /// <summary>
        /// Constructeurs monodique initialisant tout les attributs de la classe Hotel.
        /// </summary>
        /// <param name="nom">Le nom de l'hotel.</param>
        public Hotel(string nom)
        {
            Nom = nom;
            clients = new List<Client>();
        }

        /*
         -- MÉTHODE --
         */
        /// <summary>
        /// Méthode permettant d'ajouté un client dans la liste de clients de l'hotel.
        /// </summary>
        /// <param name="client">Le client à ajouté dans la liste.</param>
        public void AddClient(Client client)
        {
            clients.Add(client);
        }
    }
}
