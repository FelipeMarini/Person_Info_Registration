using System;
using Person_Info_Registration.Classes;

namespace Person_Info_Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            
            PhysicalPerson pp = new PhysicalPerson();

            JuridicalPerson jp = new JuridicalPerson();

            Console.Write("Please type your name: ");
            pp.name = Console.ReadLine();
            Console.WriteLine();
            
            do {
            
            Console.Write("Please type your ID(RG) number (9 digits/no dots or spaces): ");
            pp.id = Console.ReadLine();
            Console.WriteLine();

            } while (pp.id.Length != 9);
            
            
            do {
            
            Console.Write("Please type your CPF number (11 digits/no dots or spaces): ");
            pp.cpf = Console.ReadLine();
            Console.WriteLine();

            } while (pp.cpf.Length != 11);
            
            
            do {
            
            Console.Write("Please type your CNPJ number (14 digits/ no dots or spaces): ");
            jp.cnpj = Console.ReadLine();
            Console.WriteLine();

            } while (jp.cnpj.Length != 14);


            do {

            Console.Write("Please type your State Subscription number (12 digits/ no dots or spaces): ");
            jp.stateSubscription = Console.ReadLine();
            Console.WriteLine();

            } while (jp.stateSubscription.Length != 12);

            
            
            Console.WriteLine(pp.GiveWelcome(pp.name));  // because GiveWelcome() method returns string variable only,
                                                        // and not a Console.WriteLine command to show info on screen
            

            bool validation1 = pp.ValidateId(pp.id);

            if (validation1 == true) {
                
                Console.WriteLine();
                Console.WriteLine("ID accepted");
                
                }

            
            bool validation2 = pp.ValidateCpf(pp.cpf);

            if (validation2 == true) {
                
                Console.WriteLine();
                Console.WriteLine("CPF accepted");
                
                
                }

            bool validation3 = jp.ValidateCnpj(jp.cnpj);

            if (validation3 == true) {
                
                Console.WriteLine();
                Console.WriteLine("CNPJ accepted");
                
                }
            
            
            
            bool validation4 = jp.ValidateStateSubscription(jp.stateSubscription);

            if (validation4 == true) {
                
                Console.WriteLine();
                Console.WriteLine("State Subsription accepted");
                
                }



            



            

        }
    }
}
