namespace Person_Info_Registration.Classes
{
    public class JuridicalPerson : Person
    {

        public string cnpj;
        public string stateSubscription;


        public bool ValidateCnpj(string document){

            if (document != "" && document.Length == 14){

                return true;
            }
                return false;
        }

        public bool ValidateStateSubscription(string document){

            if (document != "" && document.Length == 12){

                return true;
            }
                return false;
        }



    }
}