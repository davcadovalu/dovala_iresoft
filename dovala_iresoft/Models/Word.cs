using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal class Word
    {
        private readonly StringBuilder _word = new StringBuilder();

        // Word has 2 states
        // 0 - empty
        // 1 - Appending
        private int _state;
        public int State => _state;

        public Word()
        {
            _state = 0;
        }

        public bool Append(char c)
        {
            bool validated = false;
            switch (_state)
            {
                case 0:
                    if (!char.IsWhiteSpace(c))
                    {
                        _word.Append(c);
                        _state = 1;
                    }
                    break;
                case 1:
                    if (char.IsWhiteSpace(c))
                    {
                        validated = Validate();
                    }
                    else _word.Append(c);
                    break;
            }
            return validated;
        }
        public bool Validate()
        {
            bool validation = _word.ToString().Any(IsLetterOrNumber);
            if (validation) Clear();
            return validation;
        }
        private bool IsLetterOrNumber(char c) => char.IsLetter(c) || char.IsNumber(c);
        private void Clear()
        {
            _word.Clear();
            _state = 0;
        }
    }
}
