using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using com.sun.corba.se.impl.orbutil.concurrent;
using dovala_iresoft.Models;
using ExtensionMethods;
using MaterialSkin;
using MaterialSkin.Controls;

namespace dovala_iresoft
{
    internal class Counter
    {
        // LABELS AND COUNTERS
        public int WhiteSpaceCount { get; private set; } = 0;
        public int CharacterCount { get; private set; } = 0;
        public int WordCount { get; private set; } = 0;
        public int RowCount { get; private set; } = 0;
        public int SentenceCount { get; private set; } = 0;


        public async void CountLineAsync(string? line)
        {

            await Task.Run(() => CountLine(line));
        }
        public void CountLine(string? line)
        {
            if (line == null) return;
            
            RowCount++;
            Sentence sentence = new Sentence();
            Word word = new Word();
            char[] text = line.ToCharArray();
            int n = text.Length;


            for (int i = 0; i < text.Length; i++ )
            {
                char c = text[i];
                bool isLast = i == text.Length - 1;
                
                //Sentence counter
                if (sentence.Append(c)) SentenceCount++;
                if (isLast && sentence.State == 2) SentenceCount++;
                //Word Counter
                if (word.Append(c)) WordCount++;
                if (isLast && word.State == 1) word.Validate();
                //Character counter
                if (char.IsWhiteSpace(c)) WhiteSpaceCount++;
                else CharacterCount++;

            }
        }
        public void Reset()
        {
            CharacterCount = 0;
            WhiteSpaceCount = 0;
            WordCount = 0;
            SentenceCount = 0;
            RowCount = 0;
        }
    }
}
