using System.Collections.Generic;

namespace QLTEQ.Domain.ForeignExchange
{
    public interface IForeignExchange
    {
        List<ConversionRate> GetConversionRates();
    }
}