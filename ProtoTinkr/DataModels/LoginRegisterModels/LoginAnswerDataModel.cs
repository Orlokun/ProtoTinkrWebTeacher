namespace ProtoTinkr.LoginRegisterModels
{
    public class LoginAnswerDataModel
    {
        public int code { get; set; }
        public string expire { get; set; }
        public string token { get; set; }

        public LoginAnswerDataModel()
        {

        }
    }
}