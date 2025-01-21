﻿class Program{
    static void Main(string[] args){
        Person Nikita = new Person("Никита","Королев",new DateTime(2005, 08, 14,18,33,21), 190);
        Nikita.write();
    }
}
class Person{
    string Name {get;}
    string SurN {get;}
    DateTime Date_birth{get;}
    int Height{get;}
    public Person(string name, string surn, DateTime date_birth, int height){
        Name = name;
        SurN = surn;
        Date_birth = date_birth;
        Height = height;
    }
    public void write(){
        Console.WriteLine($"Имя: {Name},  Фамилия: {SurN}, Дата рождения: {Date_birth}, Рост: {Height}");
    }
}
