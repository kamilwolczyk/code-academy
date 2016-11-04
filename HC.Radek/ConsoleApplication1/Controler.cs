using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Controler
    {
        private View view;
        private Model model;
        private Validator validator;
        private AddControler addControler;

        public Controler(View _view, Model _model)
        {
            view = _view;
            model = _model;
            validator = (Validator)Activator.CreateInstance(typeof(Validator), model);
            addControler = (AddControler)Activator.CreateInstance(typeof(AddControler), view, model, validator);
        }

        public void MainSite()
        {
            view.MainSite();
            var decision = validator.ValidateMain(Console.ReadLine());

            if (decision != 0)
            {
                OnMainSiteCorrectDecision(decision);
            }else
            {
                MainSite();
            }
        }

        private void OnMainSiteCorrectDecision(int _decision)
        {
            switch (_decision)
            {
                case 1:
                    Buy();
                    MainSite();
                    break;
                case 2:
                    CheckStock();
                    MainSite();
                    break;
                case 3:
                    addControler.Start();
                    MainSite();
                    break;
                default:

                    break;
            }
        }

        private void Buy()
        {
            string name = GetName();
            int itemQuantity = GetQuantity();
            BuyItem(name, itemQuantity);
            Console.ReadLine();
        }

        private void BuyItem(string name, int itemQuantity)
        {
            Item item = model.GetItemFromStock(name);
            if (itemQuantity == 0)
            {
                view.OnNoItem(name);
            }
            else if (item.GetValue() < itemQuantity)
            {
                view.OnWrongItemNumber();
            }
            else
            {
                model.AddItemToStock(name, -itemQuantity, item.GetPrize());
                view.OnBuySuccess();
            }
        }

        private int GetQuantity()
        {
            view.BuyNumber();
            string quantity = Console.ReadLine();
            var itemQuantity = validator.GetValidQuantity(quantity);
            return itemQuantity;
        }

        private string GetName()
        {
            var stock = model.GetStock();
            view.Buy(stock);
            string name = Console.ReadLine();
            return name;
        }

        private void CheckStock()
        {
            var stock = model.GetStock();
            view.CheckStock(stock);
            Console.ReadLine();
        }

    }
}
