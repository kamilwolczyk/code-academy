using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class AddControler
    {
        private string name = "";
        private int value = 0;
        private int prize = 0;

        private View view;
        private Model model;
        private Validator validator;

        public AddControler(View _view, Model _model, Validator _validator)
        {
            view = _view;
            model = _model;
            validator = _validator;

            

        }

        public void Start()
        {
            name = "";
            value = 0;
            prize = 0;
            Add(0);
        }

        private void Add(int _stage)
        {
            if (IsAllDataSet(_stage))
            {
                model.AddItemToStock(name, value, prize);
            }
            else
            {
                if (AddStage(_stage) == _stage) return;
                else Add(++_stage);
            }

        }

        private static bool IsAllDataSet(int _stage)
        {
            return _stage == 3;
        }

        private int AddStage(int stage)
        {
            switch (stage)
            {
                case 0:
                    return AddStage0();

                case 1:
                    return AddStage1();

                default:
                    return AddStage2();

            }
        }

        private int AddStage0()
        {
            var _stage = 0;
            view.Add(_stage);
            name = Console.ReadLine();
            if (!validator.IsValidItemName(name))
            {
                Add(_stage);
                return _stage;
            }
            return 1;
        }

        private int AddStage1()
        {
            var _stage = 1;
            view.Add(_stage);
            value = validator.GetValidNumberOfItemsToAdd(Console.ReadLine());
            if (value == 0)
            {
                Add(_stage);
                return _stage;
            }
            return 2;
        }

        private int AddStage2()
        {
            var _stage = 2;
            view.Add(_stage);
            prize = validator.GetValidPriceOfItemsToAdd(Console.ReadLine());
            if (prize == 0)
            {
                Add(_stage);
                return _stage;
            }
            return 3;
        }
    }
}
