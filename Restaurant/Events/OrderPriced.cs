﻿using System;
using Restaurant.Models;

namespace Restaurant.Events
{
    public class OrderPriced : Message
    {
        public OrderPriced(OrderDocument order, Guid correlationId, Guid causationId, Guid? id = null)
            : base(order, correlationId, causationId, id)
        {
        }
    }
}