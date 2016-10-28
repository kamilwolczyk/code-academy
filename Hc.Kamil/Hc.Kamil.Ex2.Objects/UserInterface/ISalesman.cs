using System.Collections.Generic;
using Hc.Kamil.Ex2.Objects.Models;

namespace Hc.Kamil.Ex2.Objects.UserInterface
{
    public interface ISalesman
    {
        void WelcomeCustomer();

        SalesmanAction AskAboutAction();

        Product ReadProductInformation(bool getPrice, bool getCount);

        void ShowAvailableProducts(IEnumerable<Product> products);

        void ShowError(string message);

        bool Finish();
    }
}