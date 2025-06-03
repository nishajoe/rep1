using petArray_Enum.Enum;
internal class Program
{
    public struct petArray
    {
        public int id;
        public string petName;
        public petCategory category;
    }
    private static void Main(string[] args)
    {
        Console.Write("How many pets do you want to add? ");
        int count=Convert.ToInt32(Console.ReadLine());
        petArray[] p = new petArray[count];
        for (int i = 0; i < count; i++)
        {
            petArray pet=new petArray();
            pet.id = i + 1;
            Console.Write("Enter the name of the {0}th pet: ",i+1);
            pet.petName = Console.ReadLine();
            Console.Write("Enter the category of {0}th pet from the following list: ",i+1);
            bool chance =true;
            int choice;
            do
            {
                Console.Write("\n1) Dog\n2) Cat\n3) Fish\n4) Bird\n5) Reptile\n6) Other\nEnter the category id: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: pet.category = petCategory.Dog; break;
                    case 2: pet.category = petCategory.Cat; break;
                    case 3: pet.category = petCategory.Fish; break;
                    case 4: pet.category = petCategory.Bird; break;
                    case 5: pet.category = petCategory.Reptile; break;
                    case 6: pet.category = petCategory.Other; break;
                    default: Console.Write("Invalid chocie!\n Please enter the correct choice: ");chance = false; break;
                }
            }while(chance==false);
            p[i] = pet;
        }
        Console.WriteLine("\n\nPet details are: \n");
        foreach(var petVal in p)
        {
            if (petVal.petName != null)
            {
                Console.WriteLine("-----------{0}-------------\n",petVal.petName);
                Console.WriteLine("Pet ID:{0} ", petVal.id);
                Console.WriteLine("Pet Name: {0}",petVal.petName);
                Console.WriteLine("Pet Category: {0}", petVal.category);
                Console.Write("\n\n\n");
            }

        }

    }
}