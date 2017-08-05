using System;
using System.Globalization;
using I18N.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace I18N.Controllers
{
    public class BaseController : Controller
    {
        private readonly ICurrencyService _currencyService;
        public readonly string DefaultCurrencyCookieName = ".AspNetCore.Currency";

        public BaseController()
        {
        }

        public BaseController(ICurrencyService currencyService)
        {
            _currencyService = currencyService;
        }

        public void SetLanguage(string culture)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTime.UtcNow.AddYears(1) }
            );
        }

        public void SetCurrency(string culture)
        {
            Response.Cookies.Append(
                DefaultCurrencyCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTime.UtcNow.AddYears(1) }
            );
        }
    }
}