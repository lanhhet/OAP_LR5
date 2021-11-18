using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Платежная карта */

public class PayCard
    {

    public string CardNumber;       // номер карты
    public string PinCodeEncrypted; // пин код карты (зашифрованное значение)

    public PayCard() // конструктор
    {
        CardNumber = "";
        PinCodeEncrypted = "";
    }

    public PayCard(string CNum, string Pin) // конструктор
    {
        CardNumber = CNum;
        PinCodeEncrypted = Pin;
    }

    public void GetInfo()
    {
        /* вывод информации о платежной карте на консоль */

        Console.WriteLine("Платежная карта : номер {0} пин в зашифрованном виде {1}", CardNumber, PinCodeEncrypted);

    }

    new public string ToString()
    {

        /* выводит информацию о типе объекта и его текущих значениях */

        string objinfo = "Платежная карта : номер " + CardNumber + " пин в зашифрованном виде " + PinCodeEncrypted;

        return objinfo;

    }

}

