using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Определим Интерфейс */

public interface IFio
{
    string SayFio();

}

/* Персона */
public abstract class ThePerson
    {

    /* объявим данный класс абстрактным - мы не будем создавать объекты данного класса */

    public string Fio;      // ФИО персоны
    public int Age;         // возраст
    public char Gender;     // пол ('m' - "male" / 'f' - "female" / '-' - uncknown)

    public ThePerson() // конструктор
    {
        Fio = "";
        Age = 0;
        Gender = '-';
    }

    public ThePerson(string theFio, int theAge, char theGender) // конструктор
    {

        Fio = theFio;
        Age = theAge;
        Gender = theGender;
    }

    // объявим абстрактный метод - производный класс (TheClient) обязан буде определить его
    public abstract string SayFio(); // одноименный метод объявлен в интерфейсе IFio

    public virtual void GetInfo()
    {
        /* вывод информации о персоне на консоль */

        Console.WriteLine("ФИО : {0} Возраст : {1} Пол {2}", Fio, Age, Gender == 'm' ? "мужской" : (Gender == 'f' ? "женский" : "нет данных"));

    }

    new public string ToString()
    {

        /* выводит информацию о типе объекта и его текущих значениях */

        string objinfo = "Персона : ФИО " + Fio + " Возраст " + Age.ToString() + " Пол : " + (Gender == 'm' ? "мужской" : (Gender == 'f' ? "женский" : "нет данных"));

        return objinfo;

    }

}
