using System;
using System.Collections.Generic;

namespace Bimehcom.Core.Models.Base.DeliveryDateTime
{
    public interface IDate<T> where T : ITime
    {
        DateTime Date { get; set; }
        List<T> Times { get; set; }
        string Title { get; set; }

    }
}