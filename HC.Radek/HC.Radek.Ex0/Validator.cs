using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Validator
    {
        private Model model;

        public Validator(Model _model)
        {
            model = _model;
        }
        
        public int ValidateMain(string decision)
        {
            if (decision == "") return 0;

            try
            {
                var decisionNumber = Int16.Parse(decision);
                if (decisionNumber > 0 && decisionNumber < 5) return decisionNumber;
            }
            catch (Exception e)
            {
                return 0;
            }
            return 0;
        }

        public Item IsNameValid(string name)
        {
            return model.GetItemFromStock(name);
        }

        public int GetValidQuantity(String _quantity)
        {
            int correctQuantity = 0;
            try
            {
                correctQuantity = Int16.Parse(_quantity);
                
            }
            catch (Exception e)
            {
                correctQuantity = 0;
            }
            return correctQuantity;
        }

        public bool IsValidItemName(string _name)
        {
            return (_name == "") ? false : true;
        }

        public int GetValidNumberOfItemsToAdd(string _number)
        {
            var number = 0;
            try
            {
                number = Int16.Parse(_number);
            }
            catch
            {

            }
            return number;
        }

        public int GetValidPriceOfItemsToAdd(string _number)
        {
            var number = 0;
            try
            {
                number = Int16.Parse(_number);
            }
            catch
            {

            }
            return number;
        }
    }
}
