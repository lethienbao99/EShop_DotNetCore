using System;
using System.Collections.Generic;
using System.Text;

namespace EShop_DotNetCore.DAL.Enums
{
    public enum OrderStatus
    {
        InProgress,
        Confirmed,
        Shipping,
        Success,
        Canceled
    }
}
