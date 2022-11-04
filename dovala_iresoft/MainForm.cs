using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using com.sun.org.apache.bcel.@internal.generic;
using java.io;
using MaterialSkin;
using MaterialSkin.Controls;
using Console = System.Console;
using File = System.IO.File;

namespace dovala_iresoft
{
    public partial class MainForm : MaterialForm
    {
        private readonly Counter _counters;
        private string? _inPath,_outPath;
        private CancellationTokenSource _tokenSource = new CancellationTokenSource();
        private readonly StateManager _stateManager;
        private FileStream? _fileStream;
        private StreamWriter? _streamWriter;

        public MainForm()
        {
            InitializeComponent();
            SetMaterialTheme(this);
            Focus();
            List<MaterialButton> controls = new List<MaterialButton>() { cancelBtn, inFile, outFile };
            List<MaterialButton> operationButtons = new List<MaterialButton>() { copyBtn, delEmptyLinesBtn, diacriticBtn, camelCaseBtn };
            _stateManager =new StateManager(this, controls, operationButtons);


            _counters = new Counter();
        }

        private Task ForEachLine(Action<string> operation, string? path = null)
        {
            path??= (_inPath ?? throw new ArgumentNullException("path"));
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (StreamReader sr = new StreamReader(fs))
            {
                string? line;

                line = sr.ReadLine();
                while (line != null)
                {
                    SetProgress( (int)(100 * sr.BaseStream.Position / sr.BaseStream.Length));
                    line += "\r\n";
                    operation(line);
                    line = sr.ReadLine();
                    if (_tokenSource.Token.IsCancellationRequested) break;
                }
            }

            return Task.CompletedTask;
        }

        // ***OPERATION MANAGER ***/
        private async void StartOperation(Action<string> operation,Action? then = null, string? path = null)
        {
            _stateManager.State = 3;
            TokenReset();
            await Task.Run(() => ForEachLine(operation, path), _tokenSource.Token);
            then?.Invoke();
            _stateManager.SwitchBack();
        }
        private void CancelOperation(object sender, EventArgs e)
        {
            _tokenSource.Cancel(false);
        }
        private void TokenReset()
        {
            _tokenSource.Dispose();
            _tokenSource = new CancellationTokenSource();
        }

        // ***File Utils ***
        private void OperateToFile(Action<string> operation)
        {
            StreamWriterInit();
            StartOperation(operation,then: () =>
            {
                StreamWriterDispose();
                Count(_outPath);
                _stateManager.State = 2;
            });
        }
        private void StreamWriterInit()
        {
            try
            {
                _fileStream = new FileStream(_outPath ?? throw new NullReferenceException(), FileMode.Create,
                    FileAccess.Write);
                _streamWriter = new StreamWriter(_fileStream);
            }
            catch
            {
                MessageBox.Show("Nedostatek práv k otevøení souboru");
            }
        }
        private void StreamWriterDispose()
        {
            _streamWriter?.Dispose();
            _fileStream?.Dispose();
        }
        
        // *** OPERATIONS ***/
        private void Count(string? path = null)
        {
            _counters.Reset();
            StartOperation(_counters.CountLine,then: UpdateLabels,path: path);
        }
        private void Copy(string line)
        {
            _streamWriter?.Write(line);
        }
        private void RemoveLineIfEmpty(string line)
        {
            if (!line.All(char.IsWhiteSpace))_streamWriter?.Write(line);
        }
        private void RemoveLineDiacritic(string line)
        {
            var normalizedString = line
                .Normalize(NormalizationForm.FormD)
                .ToCharArray()
                .Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                .ToArray();
            string lineWithoutDiacritic = new string(normalizedString);
            _streamWriter?.Write(lineWithoutDiacritic);
        }
        private void LineToCamelCase(string line)
        {
            StringBuilder camelCaseLine = new StringBuilder();
            bool nextUpper = false;
            foreach (char read in line)
            {
                if (nextUpper && char.IsLetter(read))
                {
                    camelCaseLine.Append(char.ToUpper(read));
                    nextUpper = false;
                }
                else if (char.IsWhiteSpace(read) || char.IsPunctuation(read))
                {
                    nextUpper = true;
                }
                else camelCaseLine.Append(read);
            }
            _streamWriter?.Write(camelCaseLine);
        }

        // *** Buttons ***/
        private void CopyFile(object sender, EventArgs e) => OperateToFile(Copy);
        private void RemoveEmptyLines(object sender, EventArgs e) => OperateToFile(RemoveLineIfEmpty);
        private void RemoveDiacritics(object sender, EventArgs e) => OperateToFile(RemoveLineDiacritic);
        private void ToCamelCase(object sender, EventArgs e) => OperateToFile(LineToCamelCase);


        // *** UI utils***/
        private async void SetProgress(int progress) => await Task.Run(()=>Invoke(()=>progressBar.Value=progress));
        private void SelectInputFile(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            if (_stateManager.State == 0) _stateManager.State = 1;
            _inPath = openFileDialog.FileName;
            Count();
        }
        private void SelectOutputFile(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
            _outPath = saveFileDialog.FileName;

            if (_outPath != _inPath) _stateManager.State = 2;
            else
            {
                MessageBox.Show("Cílové umístìní se nesmí shodovat s pùvodním");
            }

        }
        private void UpdateLabels()
        {
            characterLabel.Text = $@"{_counters.CharacterCount}({_counters.WhiteSpaceCount + _counters.CharacterCount})";
            wordLabel.Text = _counters.WordCount.ToString();
            sentenceLabel.Text = _counters.SentenceCount.ToString();
            rowLabel.Text = _counters.RowCount.ToString();
        }
        private static void SetMaterialTheme(MaterialForm form)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(form);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
    }
}