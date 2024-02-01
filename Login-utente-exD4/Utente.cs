using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_utente_exD4
{
    public static class Utente
    {   // dichiarazione variabili
        public static string Username { get; set; }
        public static string Password { get; set; }

        // metodo statico login con tre parametri di tipo stringa e valore di ritorno booleano
        public static bool Login(string username, string password, string ConfermaPassword)
        { 
        if (username == "" || password == "" || ConfermaPassword == "")
            {
                return false;
            }
            else if (password != ConfermaPassword)
            {
                return false;
            }
            else
            {
                Username = username;
                Password = password;
                return true;
            }
        }
        // metodo statico logout con nessun parametro e valore di ritorno booleano, ritorna messaggio di errore se utente non è loggato
        public static bool Logout()
        {
            if (Username == null || Password == null)
            {
             
                return false;
            }
            else
            {
                Username = null;
                Password = null;
                return true;
            }
        }

        // metodo statico datetime con nessun parametro e valore di ritorno stringa, ritorna data e ora ultimo login
        public static string LastLogin()
        {
            if (Username == null || Password == null)
            {
               
                return null;
            }
            else
            {
                DateTime now = DateTime.Now;
                string data = now.ToString("dd/MM/yyyy HH:mm:ss");
                return data;
            }
        }

        // metodo statico list con nessun parametro e valore di ritorno stringa, lista dei login dell'utente
        private static List<string> loginHistory = new List<string>(); // Dichiarazione della lista di login

        // modificato per aggiungere login alla lista invece di crearne una nuova ogni volta
        public static List<string> LoginHistory()
        {
            if (Username == null || Password == null)
            {
               
                return null;
            }
            else
            {
                string loginTime = LastLogin();
                loginHistory.Add(loginTime);
                return loginHistory;
            }
        }

        // metodo statico list con nessun parametro e valore di ritorno stringa, lista dei login dell'utente
        //public static List<string> LoginHistory()
        //{
        //    List<string> lista = new List<string>(); // dichiarazione lista di stringhe
        //    if (Username == null || Password == null)
        //    {
        //       
        //        return null;
        //    }
        //    else
        //    {
        //        lista.Add(LastLogin()); // aggiunta data e ora login alla lista
        //        return lista;
        ////    }
        //}


    }
}
