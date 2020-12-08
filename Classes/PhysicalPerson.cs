namespace Person_Info_Registration.Classes
{
    public class PhysicalPerson : Person
    {
        
        public string cpf;
        public string id;


        public bool ValidateCpf(string document){

            if (document != "" && document.Length == 11) {
                
                return true;
            }
                return false;
        }

        public bool ValidateId(string document){

            if (document != "" && document.Length == 9) {
                
                return true;
            }
                return false;
        }

    }
}