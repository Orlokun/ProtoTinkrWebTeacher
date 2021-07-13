namespace ProtoTinkr.LoginRegisterModels
{
    public class LoginModel
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public LoginModel()
        {
        }
        public LoginModel(string _email, string _password)
        {
            Email = _email;
            Password = _password;
        }
    }
}