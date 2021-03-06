﻿using System.Collections.Generic;
using EPiServer.Commerce.Order;
using Mediachase.Commerce;
using Mediachase.Commerce.Orders;

namespace Klarna.Common.Extensions
{
    public interface ILineItemTaxCalculator
    {
        decimal PriceIncludingTax(decimal basePrice, IEnumerable<ITaxValue> taxes, TaxType taxtype);
        decimal PriceIncludingTaxPercent(decimal basePrice, decimal taxPercent, IMarket market);
        decimal PriceIncludingTaxAmount(decimal basePrice, decimal taxAmount, IMarket market);
        ITaxValue[] GetTaxValuesForLineItem(ILineItem lineItem, IMarket market, IShipment shipment);
        decimal GetTaxes(decimal basePrice, IEnumerable<ITaxValue> taxes, TaxType taxtype);
        bool TryGetTaxCategoryId(ILineItem item, out int taxCategoryId);
        bool TryGetTaxValues(IMarket market, IShipment shipment, int taxCategoryId, out ITaxValue[] taxValues);
    }
}