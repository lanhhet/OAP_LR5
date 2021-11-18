using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Операции со счетом */
public static class AccOpers
    {
    
    /* В сравнении с нестатическим классом, статический класс имеет следующие свойства(отличия) :
       - нельзя создавать объекты статического класса;
       - статический класс должен содержать только статические члены.
    */

    public static void AccDelete (Account Acc)
    {
        /* операция удаления счета */

        Acc.AccountNumber = null;
        Acc.AccountBalance = 0;

    }

}
