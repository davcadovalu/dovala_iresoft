using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.sun.org.glassfish.external.statistics.annotations;

namespace dovala_iresoft.Models
{
    internal class Sentence
    {
        private readonly StringBuilder _sentence = new StringBuilder();
        private readonly StringBuilder _afterDot = new StringBuilder();
        private int _dotCount = 0;
        private char[] separators = new char[] { '.', '!', '?' };

        //Sentence has 3 states
        // 0 - sentence is empty
        // 1 - appending before dot
        // 2 - appending after dot
        private int _state = 0;
        public int State => _state;


        public Sentence ()
        {}

        public bool Append(char c)
        {
            bool isComplete = false;
            ManageState(c);

            switch (_state)
            {
                case 1:
                    _sentence.Append(c);
                    break;
                case 2:
                {
                    _afterDot.Append(c != '\n' ? c : Environment.NewLine);
                    isComplete = Validate();
                    break;
                }
            }
            return isComplete;
        }

        private void ManageState(char c)
        {
            if (_state == 0) _state = 1;
            else if (CharIsSeparator(c))
            {
                _state = 2;
                _dotCount++;
            }

        }
        
        private bool Validate()
        { 
            if (_afterDot.Length < 3) return false;

            bool spaceAfterDot = char.IsWhiteSpace(_afterDot[1]), 
                letterIsUpper = (char.IsLetter(_afterDot[^1]) && char.IsUpper(_afterDot[^1])),
                isDigit = char.IsDigit(_afterDot[^1]);
            
            bool result = spaceAfterDot && (letterIsUpper || isDigit);
            if (result) ValidationSuccessful();
            else ValidationFailed();

            return result;
        }

        private void ValidationSuccessful()
        {
            char c  = _afterDot[^1];
            Clear();
            Append(c);
        }

        private void ValidationFailed()
        {
            if (CheckForWhitespace()) return;
            if (_dotCount > 1) while (!CharIsSeparator(ShiftChar()));
            else
            {
                _sentence.Append(_afterDot);
                _afterDot.Clear();
                _dotCount = 0;
                _state = 1;
            }
        }

        private bool CheckForWhitespace() => _afterDot.ToString().All(c => char.IsWhiteSpace(c) || CharIsSeparator(c));

        private bool CharIsSeparator(char c) => separators.Any(s => s == c);

        private char ShiftChar()
        {
            if (CharIsSeparator(_afterDot[0])) _dotCount--;
            _sentence.Append(_afterDot[0]);
            _afterDot.Remove(0, 1);
            return _afterDot[0];
        }

        private void Clear()
        {
            _state = 0;
            _dotCount = 0;
            _sentence.Clear();
            _afterDot.Clear();
        }

    }
}
