﻿using System.Collections.Generic;
using EPiServer.Commerce.Order;
using Klarna.Rest.Models;
using Mediachase.Commerce.Orders;

namespace Klarna.OrderManagement
{
    public interface IKlarnaOrderService
    {
        void CancelOrder(string orderId);

        void UpdateMerchantReferences(string orderId, string merchantReference1, string merchantReference2);
        CaptureData CaptureOrder(string orderId, int? amount, string description, ShippingInfo shippingInfo = null, List<OrderLine> orderLines = null);

        void Refund(string orderId, IOrderGroup orderGroup, OrderForm orderForm, IPayment payment);
    }
}