using Hc.Kamil.Ex5.MvcRouting.Models;

namespace Hc.Kamil.Ex5.MvcRouting.Services
{
    public interface IDateService
    {
        string GetDateString(DateType type, string format);
    }
}