using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin.Controls;

namespace dovala_iresoft
{
    internal class StateManager
    {
        //MainForm has 4 states
        // 0 - waiting for file input (No available operations)
        // 1 - input file chosen, no output file (Only counting)
        // 2 - idle, both files chosen (all operation available)
        // 3 - in operation

        private int _state;
        private int _beforeOperation;
        private readonly MainForm _form;
        private readonly MaterialButton _cancelBtn, _openBtn, _saveBtn;
        private readonly List<MaterialButton> _operationButtons;

        public StateManager(MainForm form, List<MaterialButton> controls, List<MaterialButton> operationButtons)
        {
            this._form = form;
            this._operationButtons = operationButtons;
            _cancelBtn = controls[0];
            _openBtn = controls[1];
            _saveBtn = controls[2];
            State = 0;

        }

        public int State
        {
            get => _state;
            set
            {
                switch (value)
                {
                    case 0: 
                        EnableAll(false, _openBtn);
                        break;
                    case 1:
                        EnableAll(false, _openBtn, _saveBtn);
                        break;
                    case 2:
                        EnableAll(true, _cancelBtn);
                        break;
                    case 3:
                        _beforeOperation = _state;
                        EnableAll(false, _cancelBtn);
                        break;
                }

                _state = value;
            }
        }
        public void SwitchBack() => State = _beforeOperation;
        private void EnableAll(bool enable = true, params MaterialButton[] except)
        {
            List<MaterialButton> list = new List<MaterialButton>();
            list.AddRange( _operationButtons);
            list.AddRange(new List<MaterialButton>()
            {
                _cancelBtn,_saveBtn,_openBtn
            });
            foreach (MaterialButton button in list)
            {
                button.Enabled = enable;
            }
            

            if (except.Length > 0)
            {
                foreach (MaterialButton button in except)
                {
                    button.Enabled = !enable;
                }
            }
        }





    }
}
