namespace GestionClientsHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client c_1 = new Client("Hudon", "Gary", "garyH@gmail.com", "5553334445534", 2);
            Client c_2 = new Client("Pommainville", "Aleoune", "aleounePommette@hotmail.com", "44434030595", 4);

            Hotel h_1 = new Hotel("L'avenoure");

            h_1.AddClient(c_1);
            h_1.AddClient(c_2);

            foreach(Client c in h_1.clients)
            {
                Console.WriteLine(c);
            }
        }
    }
}