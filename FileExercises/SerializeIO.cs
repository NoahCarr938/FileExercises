using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;


//
// Write a Serialize and Deserialize function for the Contact struct.
// Serialize should write the contents of the object into a file.
// DeSerialize should read the contents of a file and assing them to the object's variables.
//
namespace FileExercises
{
    struct Contact
    {
        public string name;
        public string email;
        public int id;

        public void Serialize(string path)
        {
            if (!File.Exists(path))
            {


                try
                {
                    // Makes a new path
                    StreamWriter writer = new StreamWriter(path);
                    writer.WriteLine();
                    writer.WriteLine(name + " ");
                    writer.WriteLine(email + " ");
                    writer.WriteLine(id + " ");
                    writer.WriteLine();
                    writer.Close();

                    // Dispose of the object
                    try
                    {
                        writer.Dispose();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        // Load contacts from file.
        public void DeSerialize(string path)
        {
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string str;
                    while ((str = reader.ReadLine()) != null)
                    {
                        
                    }
                    string email;
                    while ((email = reader.ReadLine()) != null)
                    {
                        
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public Contact(string name, string email, int id)
        {
            this.name = name;
            this.email = email;
            this.id = id;
        }
        public void Print()
        {
            Console.WriteLine(name + " | " + email + " | " + id);
        }
    }
    internal class SerializeIO
    {
        public void Run()
        {
            // Make 3 contacts
            Contact bob = new Contact("Bob", "bob@email.com", 1234);
            Contact fred = new Contact("Fred", "fred@email.com", 2345);
            Contact jane = new Contact("Jane", "jane@email.com", 3456);

            // Write each contact to a file
            bob.Serialize(@"bob.txt");
            fred.Serialize(@"fred.txt");
            jane.Serialize(@"jane.txt");

            // Clear out contacts
            bob = new Contact();
            fred = new Contact();
            jane = new Contact();

            // Load contacts from file
            bob.DeSerialize(@"bob.txt");
            fred.DeSerialize(@"fred.txt");
            jane.DeSerialize(@"jane.txt");

            // Print contacts
            bob.Print();
            fred.Print();
            jane.Print();

        }
    }
}
