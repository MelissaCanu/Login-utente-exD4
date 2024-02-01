using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_utente_exD4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // dichiarazione variabili
            string username;
            string password;
            string confermaPassword;
            string scelta;
            bool login = false;
            bool logout = false;
            DateTime lastLogin = DateTime.MinValue; // valore di default di un DateTime 
            bool exit = false; // variabile booleana per uscire dal ciclo do-while
            do // ciclo do-while per il menu
            {
                Console.WriteLine("===============OPERAZIONI==============\r\n"); 
                Console.WriteLine("Scegli l'operazione da effettuare:\r\n"); 
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Logout");
                Console.WriteLine("3. Last Login");
                Console.WriteLine("4. Storico Login");
                Console.WriteLine("5. Exit");
                Console.WriteLine("========================================");
                scelta = Console.ReadLine();
                switch (scelta) // switch per le scelte del menu
                {
                    case "1":
                        Console.WriteLine("Inserisci username");
                        username = Console.ReadLine();
                        Console.WriteLine("Inserisci password");
                        password = Console.ReadLine();
                        Console.WriteLine("Conferma password");
                        confermaPassword = Console.ReadLine();
                        login = Utente.Login(username, password, confermaPassword); // chiamata al metodo statico Login
                        if (login == true)
                        {
                            Console.WriteLine("Login effettuato");
                        }
                        else
                        {
                            Console.WriteLine("Errore, login non effettuato");
                        }
                        break;

                    case "2":
                        logout = Utente.Logout(); // chiamata al metodo statico Logout
                        if (logout == true)
                        {
                            Console.WriteLine("Logout effettuato");
                        }
                        else
                        {
                            Console.WriteLine("Errore, logout non effettuato");
                        }
                        break;

                    case "3":
                        if (login == true)
                        {
                            Console.WriteLine("Ultimo login effettuato: " + Utente.LastLogin()); // chiamata al metodo statico LastLogin
                        }
                        else
                        {
                            Console.WriteLine("Errore, utente non loggato");
                        }

                        break;

                    case "4": // stampa lista login effettuati
                            if (login == true)
                        {
                            List<string> lista = Utente.LoginHistory(); // chiamata al metodo statico LoginHistory
                            if (lista != null)
                            {
                                foreach (string loginEffettuato in lista) 
                                {
                                    Console.WriteLine(loginEffettuato);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Errore, utente non loggato");
                        }
                        break;

                    case "5": // uscita dal ciclo do-while
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Scelta non valida");
                        break;
                }
            } while (exit == false);









        }
    }
}
