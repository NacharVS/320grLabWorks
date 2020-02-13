using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Account
    {
        int id;
        string  nickname;
        string email;
        string login;
        string password;
        int number;
        int cash;
        int serialNum;
        int passportNum;

        public string Nickname { get => nickname; set => nickname = value; }
        public string Email { get => email; set => email = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        public int Number{ get => number; set => number = value; }
        public int Cash { get => cash; set => cash = value; }
        public int SerialNum{ get => serialNum; set => serialNum = value; }
        public int PassportNum { get => passportNum; set => passportNum = value; }
        public int Id { get => id; set => id = value; }

        public Account (int id,string nickname, string email, string login, string password, int numer, int cash, int serialNum, int passportNum)
        {
            this.id = id;
            this.nickname = nickname;
            this.email = email;
            this.login = login;
            this.password = password;
            this.number = numer;
            this.cash = cash;
            this.serialNum = serialNum;
            this.passportNum = passportNum;
        }
    }
}
