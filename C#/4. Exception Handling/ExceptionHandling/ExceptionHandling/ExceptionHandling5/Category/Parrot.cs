using ExceptionHandling5.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling5.Category
{
    public class Parrot
    {
        List<Pet> parrots= new List<Pet>();
        public void DisplayMenu()
        {
            try
            {
                Console.WriteLine("Enter your choice\n1.Add Pet\n2.List Pet\n3.Remove Pet\n4.Update Pet");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddPet();
                        DisplayMenu();
                        break;
                    case 2:
                        ListPet();
                        DisplayMenu();
                        break;
                    case 3:
                        RemovePet();
                        DisplayMenu();
                        break;
                    case 4:
                        UpdatePet();
                        DisplayMenu();
                        break;
                       
                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                }
            }
            catch (FormatException ex)
            { 
                Console.WriteLine(ex.Message);
            }
        }
        public void AddPet()
        {
            try
            {
                Console.WriteLine("Enter Pet Id:");
                string id = Console.ReadLine();
                Console.WriteLine("Enter Pet Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Breed:");
                string breed = Console.ReadLine();
                Console.WriteLine("Enter Age:");
                string age = Console.ReadLine();

                Pet newPet = new Pet
                {
                    Id = id,
                    Name = name,
                    Breed = breed,
                    Age = age,

                };
                if(parrots.Any(p=>p.Id== newPet.Id))
                {
                    throw new PetAlreadyExistsException();
                }
                parrots.Add(newPet);
            }
            catch( Exception PetAlreadyExistsException)
            {
                Console.WriteLine(PetAlreadyExistsException.Message);
            }

        }
        public void ListPet()
        {
            Console.WriteLine("PetList");
            foreach (var pet in parrots)
            {

                Console.WriteLine($"ID: {pet.Id}, Name: {pet.Name}, Age: {pet.Age}, Breed: {pet.Breed}");

            }

        }
        public void UpdatePet()
        {
            Console.Write("\nEnter the ID of the pet you want to update: ");
            string idToUpdate = Console.ReadLine();

            Pet petToUpdate = parrots.Find(pet => pet.Id == idToUpdate);
            if (petToUpdate != null)
            {
                Console.Write("Enter updated name: ");
                string updatedName = Console.ReadLine();

                Console.Write("Enter updated age: ");
                string updatedAge = Console.ReadLine();

                Console.Write("Enter updated breed: ");
                string updatedBreed = Console.ReadLine();

                petToUpdate.Name = updatedName;
                petToUpdate.Age = updatedAge;
                petToUpdate.Breed = updatedBreed;

                Console.WriteLine($"Pet with ID {idToUpdate} updated successfully.");
            }
            else
            {
                Console.WriteLine("Pet not found in the list.");
            }

            Console.WriteLine("\nUpdated list of pets:");
            foreach (var pet in parrots)
            {
                Console.WriteLine($"ID: {pet.Id}, Name: {pet.Name}, Age: {pet.Age}, Breed: {pet.Breed}");
            }
        }
        public void RemovePet()
        {
            Console.Write("\nEnter the ID of the pet you want to remove: ");
            string idToRemove = Console.ReadLine();

            Pet petToRemove = parrots.Find(pet => pet.Id == idToRemove);
            if (petToRemove != null)
            {
                parrots.Remove(petToRemove);
                Console.WriteLine($"Pet with ID {idToRemove} removed successfully.");
            }
            else
            {
                Console.WriteLine("Pet not found in the list.");
            }

            Console.WriteLine("\nUpdated list of Pets:");
            foreach (var pet in parrots)
            {
                Console.WriteLine($"ID: {pet.Id}, Name: {pet.Name}, Age: {pet.Age}, Breed: {pet.Breed}");
            }
        }
    }
    }

