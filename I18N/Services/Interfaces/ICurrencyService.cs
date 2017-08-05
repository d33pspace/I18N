using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using I18N.Models;

namespace I18N.Services
{
    public interface ICurrencyService
    {
        CultureInfo GetCurrent();
        List<Currency> GetAll();
        string GetSymbol(CultureInfo culture);
        string GetISOName(CultureInfo culture);
    }
}