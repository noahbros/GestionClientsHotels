namespace GestionClientsHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TEST D'INITIALISATION/VALIDITER DES OBJETS
            Client c_1 = new Client("Hudon", "Gary", "garyH@gmail.com", "5553334445534", 2);
            Client c_2 = new Client("Pommainville", "Aleoune", "aleounePommette@hotmail.com", "44434030595", 4);

            Hotel h_1 = new Hotel("L'avenoure");

            //TEST DE AddClient(Client c)
            h_1.AddClient(c_1);
            h_1.AddClient(c_2);

            //TEST DE L'AFFICHAGE DE LA LISTE DE CLIENT DANS L'HOTEL
            foreach(Client c in h_1.Clients)
            {
                Console.WriteLine(c);
            }
        }
    }
}