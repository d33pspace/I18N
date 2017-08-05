using System.ComponentModel.DataAnnotations;

namespace I18N.Models
{
    public class Currency
    {
        public string Symbol { get; set; }
        public string CultureName { get; set; }
    }
}