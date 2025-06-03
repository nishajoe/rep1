using Nisha_C__Exercise.Enum;
internal class Program
{
    struct UserStruct
    {
        public int uid;
        public string uname;
        public string uemail;
        public string upswd;
        public int uphn;
        public string uaddrs;
        public string ucity;
        public string ustate;
        public Roles urole;
    }

    struct PetStruct
    {
        public int petId;
        public int petUserId;
        public string petName;
        public string petCategory;
    }
    private static void Main(string[] args)
    {
        UserStruct user=new UserStruct();
        PetStruct pet=new PetStruct();
        PetStruct[] p = new PetStruct[10];
        Console.WriteLine("------------User Registration--------------\n\nPlease enter the following details:\n");
        Console.Write("Id: ");
        user.uid=Convert.ToInt32(Console.ReadLine());
        Console.Write("Name: ");
        user.uname = Console.ReadLine();
        Console.Write("Email id: ");
        user.uemail = Console.ReadLine();
        Console.Write("Password: ");
        user.upswd = Console.ReadLine();
        Console.Write("Phone number: ");
        user.uphn = Convert.ToInt32(Console.ReadLine());
        Console.Write("Address: ");
        user.uaddrs = Console.ReadLine();
        Console.Write("City: ");
        user.ucity = Console.ReadLine();
        Console.Write("State: ");
        user.ustate = Console.ReadLine();
        Console.Write("\n1) Admin\n2) Public User\nEnter the role of the user from the above list: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        //bool chance = true;
        switch (choice)
        {
            case 1: user.urole = Roles.Admin; break;
            case 2: user.urole = Roles.PublicUser; break;
            default:Console.WriteLine("Please enter the correct role");break;

        }
        Console.WriteLine("------------User Login--------------\n\n");
        Console.Write("Email id: ");
        string email = Console.ReadLine();
        Console.Write("Password: ");
        string pswd = Console.ReadLine();
        Console.WriteLine("Log in successfull...");
        if(email== user.uemail && pswd == user.upswd)
        {
            if (user.urole == Roles.PublicUser)
            {
                Console.Write("\n1)Post pet \n2) List pets \n3) Logout\nPlease enter the required option: ");
                int opt=Convert.ToInt32(Console.ReadLine());
                switch (opt)
                {
                    case 1: Console.WriteLine("-----Posting pet details-------\n\n");
                            Console.WriteLine("How many pets do you want to add: ");
                            int count = Convert.ToInt32(Console.ReadLine());
                            
                            for(int i = 0;i<count;i++)
                            {
                                
                                pet.petId = i+1;
                                pet.petUserId = user.uid;
                                Console.Write("Enter the name of the pet: ");
                                pet.petName = Console.ReadLine();
                                Console.Write("Enter the category of the pet: ");
                                pet.petCategory = Console.ReadLine();
                                p[i] = pet;
                            }
                            break;

                       
                    case 2: Console.WriteLine("-----Listing pet details-------\n\n");
                            foreach(var petVal in p)
                            {
                                if(pet.petId != null)
                                {
                                Console.Write($"Pet id: {petVal.petId}");
                                Console.Write($"User id of the pet holder: {petVal.petUserId}");
                                Console.Write($"Pet Name: {petVal.petName}");
                                Console.Write($"Pet Category: {petVal.petCategory}");
                                }
                            }

                        break;
                    case 3: break;
                }
            }
            else
            {
                Console.WriteLine("Not a public user!");
            }
        }
        else
        {
            Console.WriteLine("Not a registered user. Please register!");
        }

    }
}
