using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Банковский счет */
public class Account
    {

    public string AccountNumber;  // номер счета
    public double AccountBalance; // остаток на счете

    public Account() // конструктор
    {
        AccountNumber = "";
        AccountBalance = 0;

    }
    public Account (string AccNumber, double AccBallance) // конструктор
    {
        AccountNumber = AccNumber;
        AccountBalance = AccBallance;

    }

    public virtual void GetInfo()
    {
        /* вывод информации о счете на консоль */

        Console.WriteLine("Счет : номер {0} остаток на счете {1}", AccountNumber, AccountBalance);

    }

    // переопределим в данном классе все методы, унаследованные от Object

    public bool Equals(Account Account2)
    {
        /* производит сравнение двух счетов - данного с переданным в качестве параметра,
         
           возвращает результат сравнения (true/false)
         
         */

        bool result = false;

        if (AccountNumber == Account2.AccountNumber) result = true;

        else result = false;

        return result;
    }

    new public int GetHashCode()
    {

        /* возвращает хеш-код счета,
      
           в качестве хеш-кода счета берем номер счета, поскольку он уникален в банковской системе

         */

        return int.Parse(AccountNumber);

    }

    new public string GetType()
    {

        /* возвращает именование объекта */

        return "Банковский счет";

    }

    new public string ToString()
    {

        /* выводит информацию о типе объекта и его текущих значениях */

        string objinfo = "Банковский cчет : номер " + AccountNumber.ToString() + " остаток на счете " + AccountBalance.ToString();

        return objinfo;

    }
}
