using System.Collections.Generic;

namespace GameDB
{
    public class Account
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public PersonalData PersonalData { get; set; }
        public List<Achievements> Achievements { get; set; }
        public Character Character { get; set; }
    }
}
