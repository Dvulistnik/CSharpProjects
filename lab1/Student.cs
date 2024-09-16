using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Student
    {
        private string _name;
        public int age;

        public Subject? favoriteSubject { get; set; }
        public Game? favoriteGame { get; set; }

        public Student(string name)
        {
            this._name = name;
        }
        public Student(string name, int age, Subject? subject=null, Game? game=null)
        {
            this._name = name;
            this.age = age;

            this.favoriteSubject = subject!;
            this.favoriteGame = game!;
        }
        public void WriteInfo()
        {
            Console.WriteLine($"Имя: {_name}, Возраст: {age}");
        }
        public void BecomeOlder()
        {
            age++;
        }
        
        public void getFavoriteSubjectAndGame(out Subject s, out Game g)
        {
            s = favoriteSubject!;
            g = favoriteGame!;
        }
    }
}
