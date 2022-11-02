namespace dovala_iresoft
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.counters = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.sentenceLabel = new MaterialSkin.Controls.MaterialLabel();
            this.wordLabel = new MaterialSkin.Controls.MaterialLabel();
            this.characterLabel = new MaterialSkin.Controls.MaterialLabel();
            this.rowLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.inFile = new MaterialSkin.Controls.MaterialButton();
            this.outFile = new MaterialSkin.Controls.MaterialButton();
            this.Actions = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.camelCaseBtn = new MaterialSkin.Controls.MaterialButton();
            this.diacriticBtn = new MaterialSkin.Controls.MaterialButton();
            this.delEmptyLinesBtn = new MaterialSkin.Controls.MaterialButton();
            this.copyBtn = new MaterialSkin.Controls.MaterialButton();
            this.progress = new System.Windows.Forms.GroupBox();
            this.progressBar = new MaterialSkin.Controls.MaterialProgressBar();
            this.cancelBtn = new MaterialSkin.Controls.MaterialButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.counters.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.Actions.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.progress.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Actions, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.progress, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cancelBtn, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 67);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(467, 377);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.splitContainer1, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(236, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(228, 295);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.counters);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(222, 289);
            this.splitContainer1.SplitterDistance = 173;
            this.splitContainer1.TabIndex = 0;
            // 
            // counters
            // 
            this.counters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.counters.Controls.Add(this.tableLayoutPanel1);
            this.counters.Location = new System.Drawing.Point(6, 3);
            this.counters.Name = "counters";
            this.counters.Size = new System.Drawing.Size(213, 167);
            this.counters.TabIndex = 6;
            this.counters.TabStop = false;
            this.counters.Text = "Počítadla";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61F));
            this.tableLayoutPanel1.Controls.Add(this.materialLabel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.sentenceLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.wordLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.characterLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.rowLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel4, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(201, 139);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(35, 7);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(40, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Věty -";
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(22, 41);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(53, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Slova - ";
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(18, 111);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(57, 19);
            this.materialLabel5.TabIndex = 6;
            this.materialLabel5.Text = "Řádky - ";
            // 
            // sentenceLabel
            // 
            this.sentenceLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sentenceLabel.AutoSize = true;
            this.sentenceLabel.Depth = 0;
            this.sentenceLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.sentenceLabel.Location = new System.Drawing.Point(81, 7);
            this.sentenceLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.sentenceLabel.Name = "sentenceLabel";
            this.sentenceLabel.Size = new System.Drawing.Size(10, 19);
            this.sentenceLabel.TabIndex = 7;
            this.sentenceLabel.Text = "0";
            // 
            // wordLabel
            // 
            this.wordLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.wordLabel.AutoSize = true;
            this.wordLabel.Depth = 0;
            this.wordLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.wordLabel.Location = new System.Drawing.Point(81, 41);
            this.wordLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(10, 19);
            this.wordLabel.TabIndex = 8;
            this.wordLabel.Text = "0";
            // 
            // characterLabel
            // 
            this.characterLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.characterLabel.AutoSize = true;
            this.characterLabel.Depth = 0;
            this.characterLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.characterLabel.Location = new System.Drawing.Point(81, 75);
            this.characterLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.characterLabel.Name = "characterLabel";
            this.characterLabel.Size = new System.Drawing.Size(10, 19);
            this.characterLabel.TabIndex = 9;
            this.characterLabel.Text = "0";
            // 
            // rowLabel
            // 
            this.rowLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rowLabel.AutoSize = true;
            this.rowLabel.Depth = 0;
            this.rowLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.rowLabel.Location = new System.Drawing.Point(81, 111);
            this.rowLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.rowLabel.Name = "rowLabel";
            this.rowLabel.Size = new System.Drawing.Size(10, 19);
            this.rowLabel.TabIndex = 10;
            this.rowLabel.Text = "0";
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(18, 75);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(57, 19);
            this.materialLabel4.TabIndex = 5;
            this.materialLabel4.Text = "Znaky - ";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.inFile);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.outFile);
            this.splitContainer2.Size = new System.Drawing.Size(222, 112);
            this.splitContainer2.SplitterDistance = 55;
            this.splitContainer2.TabIndex = 0;
            // 
            // inFile
            // 
            this.inFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inFile.AutoSize = false;
            this.inFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.inFile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.inFile.Depth = 0;
            this.inFile.HighEmphasis = true;
            this.inFile.Icon = null;
            this.inFile.Location = new System.Drawing.Point(4, 6);
            this.inFile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.inFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.inFile.Name = "inFile";
            this.inFile.NoAccentTextColor = System.Drawing.Color.Empty;
            this.inFile.Size = new System.Drawing.Size(214, 36);
            this.inFile.TabIndex = 0;
            this.inFile.Text = "VSTUP";
            this.inFile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.inFile.UseAccentColor = false;
            this.inFile.UseVisualStyleBackColor = true;
            this.inFile.Click += new System.EventHandler(this.SelectInputFile);
            // 
            // outFile
            // 
            this.outFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outFile.AutoSize = false;
            this.outFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.outFile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.outFile.Depth = 0;
            this.outFile.Enabled = false;
            this.outFile.HighEmphasis = true;
            this.outFile.Icon = null;
            this.outFile.Location = new System.Drawing.Point(4, 6);
            this.outFile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.outFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.outFile.Name = "outFile";
            this.outFile.NoAccentTextColor = System.Drawing.Color.Empty;
            this.outFile.Size = new System.Drawing.Size(214, 36);
            this.outFile.TabIndex = 0;
            this.outFile.Text = "VÝSTUP";
            this.outFile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.outFile.UseAccentColor = false;
            this.outFile.UseVisualStyleBackColor = true;
            this.outFile.Click += new System.EventHandler(this.SelectOutputFile);
            // 
            // Actions
            // 
            this.Actions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Actions.Controls.Add(this.tableLayoutPanel4);
            this.Actions.Location = new System.Drawing.Point(3, 3);
            this.Actions.Name = "Actions";
            this.Actions.Size = new System.Drawing.Size(227, 295);
            this.Actions.TabIndex = 7;
            this.Actions.TabStop = false;
            this.Actions.Text = "Akce";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.camelCaseBtn, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.diacriticBtn, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.delEmptyLinesBtn, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.copyBtn, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 25);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(215, 264);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // camelCaseBtn
            // 
            this.camelCaseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.camelCaseBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.camelCaseBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.camelCaseBtn.Depth = 0;
            this.camelCaseBtn.HighEmphasis = true;
            this.camelCaseBtn.Icon = null;
            this.camelCaseBtn.Location = new System.Drawing.Point(4, 204);
            this.camelCaseBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.camelCaseBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.camelCaseBtn.Name = "camelCaseBtn";
            this.camelCaseBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.camelCaseBtn.Size = new System.Drawing.Size(207, 36);
            this.camelCaseBtn.TabIndex = 3;
            this.camelCaseBtn.Text = "Změna do CamelCase";
            this.camelCaseBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.camelCaseBtn.UseAccentColor = false;
            this.camelCaseBtn.UseVisualStyleBackColor = true;
            this.camelCaseBtn.Click += new System.EventHandler(this.ToCamelCase);
            // 
            // diacriticBtn
            // 
            this.diacriticBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.diacriticBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.diacriticBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.diacriticBtn.Depth = 0;
            this.diacriticBtn.HighEmphasis = true;
            this.diacriticBtn.Icon = null;
            this.diacriticBtn.Location = new System.Drawing.Point(4, 138);
            this.diacriticBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.diacriticBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.diacriticBtn.Name = "diacriticBtn";
            this.diacriticBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.diacriticBtn.Size = new System.Drawing.Size(207, 36);
            this.diacriticBtn.TabIndex = 2;
            this.diacriticBtn.Text = "ODSTRAŇ DIAKRITIKU";
            this.diacriticBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.diacriticBtn.UseAccentColor = false;
            this.diacriticBtn.UseVisualStyleBackColor = true;
            this.diacriticBtn.Click += new System.EventHandler(this.RemoveDiacritics);
            // 
            // delEmptyLinesBtn
            // 
            this.delEmptyLinesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.delEmptyLinesBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.delEmptyLinesBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.delEmptyLinesBtn.Depth = 0;
            this.delEmptyLinesBtn.HighEmphasis = true;
            this.delEmptyLinesBtn.Icon = null;
            this.delEmptyLinesBtn.Location = new System.Drawing.Point(4, 72);
            this.delEmptyLinesBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.delEmptyLinesBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.delEmptyLinesBtn.Name = "delEmptyLinesBtn";
            this.delEmptyLinesBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.delEmptyLinesBtn.Size = new System.Drawing.Size(207, 36);
            this.delEmptyLinesBtn.TabIndex = 1;
            this.delEmptyLinesBtn.Text = "ODSTRAŇ PRÁZDNÉ ŘÁDKY";
            this.delEmptyLinesBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.delEmptyLinesBtn.UseAccentColor = false;
            this.delEmptyLinesBtn.UseVisualStyleBackColor = true;
            this.delEmptyLinesBtn.Click += new System.EventHandler(this.RemoveEmptyLines);
            // 
            // copyBtn
            // 
            this.copyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.copyBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.copyBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.copyBtn.Depth = 0;
            this.copyBtn.HighEmphasis = true;
            this.copyBtn.Icon = null;
            this.copyBtn.Location = new System.Drawing.Point(4, 6);
            this.copyBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.copyBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.copyBtn.Size = new System.Drawing.Size(207, 36);
            this.copyBtn.TabIndex = 0;
            this.copyBtn.Text = "Zkopiruj";
            this.copyBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.copyBtn.UseAccentColor = false;
            this.copyBtn.UseVisualStyleBackColor = true;
            this.copyBtn.Click += new System.EventHandler(this.CopyFile);
            // 
            // progress
            // 
            this.progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progress.Controls.Add(this.progressBar);
            this.progress.Location = new System.Drawing.Point(3, 304);
            this.progress.Name = "progress";
            this.progress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progress.Size = new System.Drawing.Size(227, 70);
            this.progress.TabIndex = 6;
            this.progress.TabStop = false;
            this.progress.Text = "Progres:";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Depth = 0;
            this.progressBar.Location = new System.Drawing.Point(6, 38);
            this.progressBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(215, 5);
            this.progressBar.TabIndex = 5;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cancelBtn.AutoSize = false;
            this.cancelBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.cancelBtn.Depth = 0;
            this.cancelBtn.HighEmphasis = true;
            this.cancelBtn.Icon = null;
            this.cancelBtn.Location = new System.Drawing.Point(237, 321);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cancelBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.cancelBtn.Size = new System.Drawing.Size(83, 36);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Zrušit";
            this.cancelBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cancelBtn.UseAccentColor = true;
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelOperation);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.Filter = "Textový dokument|*txt|Všechny soubory|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Textový dokument|*txt|Všechny soubory|*.*";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Tool";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.counters.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.Actions.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.progress.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialProgressBar progressBar;
        private GroupBox counters;
        private TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel sentenceLabel;
        private MaterialSkin.Controls.MaterialLabel wordLabel;
        private MaterialSkin.Controls.MaterialLabel characterLabel;
        private MaterialSkin.Controls.MaterialLabel rowLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private GroupBox Actions;
        private TableLayoutPanel tableLayoutPanel4;
        private MaterialSkin.Controls.MaterialButton camelCaseBtn;
        private MaterialSkin.Controls.MaterialButton diacriticBtn;
        private MaterialSkin.Controls.MaterialButton delEmptyLinesBtn;
        private MaterialSkin.Controls.MaterialButton copyBtn;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private MaterialSkin.Controls.MaterialButton inFile;
        private MaterialSkin.Controls.MaterialButton outFile;
        private GroupBox progress;
        private OpenFileDialog openFileDialog;
        private MaterialSkin.Controls.MaterialButton cancelBtn;
        private SaveFileDialog saveFileDialog;
    }
}