using System;
using System.Collections.Generic;
using System.Text;

namespace EnumExercises.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment = 0, //caso não inicie ó atributo, ele terá como valor default 0 e as demais continuarão a sequência
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
