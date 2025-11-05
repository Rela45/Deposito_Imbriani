using System;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Org.BouncyCastle.Asn1.EdEC;

internal class Program
{
    static string connString = "server=localhost;user=root;password=110803Ilaria;database=rubrica_db";
    public static void Main()
    {
        bool continua = true;
        while (continua)
        {
            Console.WriteLine($"Inserisci il numero corrispondente all'operazione da eseguire");
            Console.WriteLine($"======MENU====== \n1.Inserisci un nuovo contatto \n2.Visualizza tutti i contatti \n3.Elimina un contatto tramite nome\n4.Esci dal programma");
            string? scelta = Console.ReadLine();
            switch (scelta)
            {
                case "1":
                    InsertContact();
                    break;
                case "2":
                    ReadAllDB();
                    break;
                case "3":
                    DeleteContact();
                    break;
                case "4":
                    continua = false;
                    break;
                default:
                    Console.WriteLine("input non valido");
                    break;
            }
        }        
    }

    public static void ReadAllDB()
    {
        using (MySqlConnection conn = new MySqlConnection(connString))
        {
            try
            {
                conn.Open();
                Console.WriteLine($"Connessione riuscita!");

                string query = "SELECT * FROM contatti";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                Console.WriteLine("===== CONTATTI IN RUBRICA =====");
                Console.WriteLine("{0,-5} | {1,-20} | {2,-15}", "ID", "Nome", "Telefono");
                Console.WriteLine(new string('-', 50));

                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string nome = reader.GetString("nome");
                    string telefono = reader.GetString("telefono");

                    Console.WriteLine("{0,-5} | {1,-20} | {2,-15}", id, nome, telefono);
                }
                reader.Close();
                Console.WriteLine(new string('=', 50));
            }
                Console.WriteLine($"=======================================");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }

    public static void InsertContact()
    {
        using (MySqlConnection conn = new MySqlConnection(connString))
        {
            try
            {
                conn.Open();
                Console.WriteLine($"Inserisci il nome da inserire in rubrica");
                string? nome = Console.ReadLine();
                Console.WriteLine($"Inserisci il suo numero di telefono");
                string? telefono = Console.ReadLine();
                string query = $"INSERT INTO contatti (nome , telefono) VALUES ('{nome}', '{telefono}')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                Console.WriteLine($"Nuovo Utente Inserito!");
                Console.WriteLine($"=======================================");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
    
    public static void DeleteContact()
    {
        using (MySqlConnection conn = new MySqlConnection(connString))
        {
            try
            {
                conn.Open();
                Console.WriteLine($"Inserisci il nome da eleminare in rubrica");
                string? nome = Console.ReadLine();
                string query = $"DELETE FROM contatti WHERE nome = '{nome}'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                Console.WriteLine($"Utente eliminato correttamente");
                Console.WriteLine($"=======================================");
                
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }


}