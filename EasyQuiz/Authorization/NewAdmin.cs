using EasyQuiz.Quiz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuiz.Authorization
{
    [DataContract]
    [Serializable]
    class NewAdmin
    {
        [DataMember]
        string name;
        [DataMember]
        string surname;
        [DataMember]
        string email;
        [DataMember]
        string login;
        [DataMember]
        string password;
        [DataMember]
        List<Quizes> quizzes;
        [DataMember]
        bool isadmin;

        public NewAdmin()
        {
        }

        public NewAdmin(string name, string surname, string email, string login, string password, List<Quizes> quizzes, bool isadmin)
        {
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.login = login;
            this.password = password;
            this.quizzes = quizzes;
            this.isadmin = isadmin;
        }

        public void setNewUser(string name, string surname, string email, string login, string password, bool isadmin)
        {
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.login = login;
            this.password = password;
            this.isadmin = isadmin;
            Console.WriteLine(name, surname, email, login, password, isadmin);
            

        }
        

    }
}

