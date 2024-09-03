namespace TodoApp.Models
{
    public class RegisterDTO
    {
  
        public string Username { get; set; }
        public string Password { get; set; }

        
        public RegisterDTO()
        {
        }

     
        public RegisterDTO( string username, string password)
        {
            
          
            Username = username;
            Password = password;
        }
    }
}
