namespace CustomBingo
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnGenerate = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnBingo1 = new System.Windows.Forms.Button();
            this.BtnBingo2 = new System.Windows.Forms.Button();
            this.BtnBingo3 = new System.Windows.Forms.Button();
            this.BtnBingo4 = new System.Windows.Forms.Button();
            this.BtnBingo5 = new System.Windows.Forms.Button();
            this.BtnBingo6 = new System.Windows.Forms.Button();
            this.BtnBingo7 = new System.Windows.Forms.Button();
            this.BtnBingo8 = new System.Windows.Forms.Button();
            this.BtnBingo9 = new System.Windows.Forms.Button();
            this.BtnBingo10 = new System.Windows.Forms.Button();
            this.BtnBingo11 = new System.Windows.Forms.Button();
            this.BtnBingo12 = new System.Windows.Forms.Button();
            this.BtnBingo13 = new System.Windows.Forms.Button();
            this.BtnBingo15 = new System.Windows.Forms.Button();
            this.BtnBingo16 = new System.Windows.Forms.Button();
            this.BtnBingo17 = new System.Windows.Forms.Button();
            this.BtnBingo18 = new System.Windows.Forms.Button();
            this.BtnBingo20 = new System.Windows.Forms.Button();
            this.BtnBingo21 = new System.Windows.Forms.Button();
            this.BtnBingo22 = new System.Windows.Forms.Button();
            this.BtnBingo23 = new System.Windows.Forms.Button();
            this.BtnBingo24 = new System.Windows.Forms.Button();
            this.BtnBingo25 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnBingo14 = new System.Windows.Forms.Button();
            this.BtnBingo19 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGenerate.Enabled = false;
            this.btnGenerate.Location = new System.Drawing.Point(10, 628);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 24);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.boardToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(704, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.Menu_File_Load_Click);
            // 
            // boardToolStripMenuItem
            // 
            this.boardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem1});
            this.boardToolStripMenuItem.Name = "boardToolStripMenuItem";
            this.boardToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.boardToolStripMenuItem.Text = "Board";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.menuBoardSaveClick);
            // 
            // loadToolStripMenuItem1
            // 
            this.loadToolStripMenuItem1.Name = "loadToolStripMenuItem1";
            this.loadToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem1.Text = "Load";
            this.loadToolStripMenuItem1.Click += new System.EventHandler(this.menuBoardLoadClick);
            // 
            // BtnBingo1
            // 
            this.BtnBingo1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBingo1.BackColor = System.Drawing.Color.White;
            this.BtnBingo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBingo1.Location = new System.Drawing.Point(12, 4);
            this.BtnBingo1.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBingo1.Name = "BtnBingo1";
            this.BtnBingo1.Size = new System.Drawing.Size(115, 115);
            this.BtnBingo1.TabIndex = 8;
            this.BtnBingo1.Text = "BtnBingo1";
            this.BtnBingo1.UseVisualStyleBackColor = false;
            this.BtnBingo1.Click += new System.EventHandler(this.BtnBingo_Click);
            // 
            // BtnBingo2
            // 
            this.BtnBingo2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBingo2.BackColor = System.Drawing.Color.White;
            this.BtnBingo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBingo2.Location = new System.Drawing.Point(151, 4);
            this.BtnBingo2.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBingo2.Name = "BtnBingo2";
            this.BtnBingo2.Size = new System.Drawing.Size(115, 115);
            this.BtnBingo2.TabIndex = 9;
            this.BtnBingo2.Text = "BtnBingo2";
            this.BtnBingo2.UseVisualStyleBackColor = false;
            this.BtnBingo2.Click += new System.EventHandler(this.BtnBingo_Click);
            // 
            // BtnBingo3
            // 
            this.BtnBingo3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBingo3.BackColor = System.Drawing.Color.White;
            this.BtnBingo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBingo3.Location = new System.Drawing.Point(290, 4);
            this.BtnBingo3.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBingo3.Name = "BtnBingo3";
            this.BtnBingo3.Size = new System.Drawing.Size(115, 115);
            this.BtnBingo3.TabIndex = 7;
            this.BtnBingo3.Text = "BtnBingo3";
            this.BtnBingo3.UseVisualStyleBackColor = false;
            this.BtnBingo3.Click += new System.EventHandler(this.BtnBingo_Click);
            // 
            // BtnBingo4
            // 
            this.BtnBingo4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBingo4.BackColor = System.Drawing.Color.White;
            this.BtnBingo4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBingo4.Location = new System.Drawing.Point(429, 4);
            this.BtnBingo4.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBingo4.Name = "BtnBingo4";
            this.BtnBingo4.Size = new System.Drawing.Size(115, 115);
            this.BtnBingo4.TabIndex = 10;
            this.BtnBingo4.Text = "BtnBingo4";
            this.BtnBingo4.UseVisualStyleBackColor = false;
            this.BtnBingo4.Click += new System.EventHandler(this.BtnBingo_Click);
            // 
            // BtnBingo5
            // 
            this.BtnBingo5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBingo5.BackColor = System.Drawing.Color.White;
            this.BtnBingo5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBingo5.Location = new System.Drawing.Point(569, 4);
            this.BtnBingo5.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBingo5.Name = "BtnBingo5";
            this.BtnBingo5.Size = new System.Drawing.Size(115, 115);
            this.BtnBingo5.TabIndex = 11;
            this.BtnBingo5.Text = "BtnBingo5";
            this.BtnBingo5.UseVisualStyleBackColor = false;
            this.BtnBingo5.Click += new System.EventHandler(this.BtnBingo_Click);
            // 
            // BtnBingo6
            // 
            this.BtnBingo6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBingo6.BackColor = System.Drawing.Color.White;
            this.BtnBingo6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBingo6.Location = new System.Drawing.Point(12, 127);
            this.BtnBingo6.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBingo6.Name = "BtnBingo6";
            this.BtnBingo6.Size = new System.Drawing.Size(115, 115);
            this.BtnBingo6.TabIndex = 12;
            this.BtnBingo6.Text = "BtnBingo6";
            this.BtnBingo6.UseVisualStyleBackColor = false;
            this.BtnBingo6.Click += new System.EventHandler(this.BtnBingo_Click);
            // 
            // BtnBingo7
            // 
            this.BtnBingo7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBingo7.BackColor = System.Drawing.Color.White;
            this.BtnBingo7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBingo7.Location = new System.Drawing.Point(151, 127);
            this.BtnBingo7.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBingo7.Name = "BtnBingo7";
            this.BtnBingo7.Size = new System.Drawing.Size(115, 115);
            this.BtnBingo7.TabIndex = 13;
            this.BtnBingo7.Text = "BtnBingo7";
            this.BtnBingo7.UseVisualStyleBackColor = false;
            this.BtnBingo7.Click += new System.EventHandler(this.BtnBingo_Click);
            // 
            // BtnBingo8
            // 
            this.BtnBingo8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBingo8.BackColor = System.Drawing.Color.White;
            this.BtnBingo8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBingo8.Location = new System.Drawing.Point(290, 127);
            this.BtnBingo8.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBingo8.Name = "BtnBingo8";
            this.BtnBingo8.Size = new System.Drawing.Size(115, 115);
            this.BtnBingo8.TabIndex = 14;
            this.BtnBingo8.Text = "BtnBingo8";
            this.BtnBingo8.UseVisualStyleBackColor = false;
            this.BtnBingo8.Click += new System.EventHandler(this.BtnBingo_Click);
            // 
            // BtnBingo9
            // 
            this.BtnBingo9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBingo9.BackColor = System.Drawing.Color.White;
            this.BtnBingo9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBingo9.Location = new System.Drawing.Point(429, 127);
            this.BtnBingo9.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBingo9.Name = "BtnBingo9";
            this.BtnBingo9.Size = new System.Drawing.Size(115, 115);
            this.BtnBingo9.TabIndex = 15;
            this.BtnBingo9.Text = "BtnBingo9";
            this.BtnBingo9.UseVisualStyleBackColor = false;
            this.BtnBingo9.Click += new System.EventHandler(this.BtnBingo_Click);
            // 
            // BtnBingo10
            // 
            this.BtnBingo10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBingo10.BackColor = System.Drawing.Color.White;
            this.BtnBingo10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBingo10.Location = new System.Drawing.Point(569, 127);
            this.BtnBingo10.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBingo10.Name = "BtnBingo10";
            this.BtnBingo10.Size = new System.Drawing.Size(115, 115);
            this.BtnBingo10.TabIndex = 16;
            this.BtnBingo10.Text = "BtnBingo10";
            this.BtnBingo10.UseVisualStyleBackColor = false;
            this.BtnBingo10.Click += new System.EventHandler(this.BtnBingo_Click);
            // 
            // BtnBingo11
            // 
            this.BtnBingo11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBingo11.BackColor = System.Drawing.Color.White;
            this.BtnBingo11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBingo11.Location = new System.Drawing.Point(12, 250);
            this.BtnBingo11.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBingo11.Name = "BtnBingo11";
            this.BtnBingo11.Size = new System.Drawing.Size(115, 115);
            this.BtnBingo11.TabIndex = 17;
            this.BtnBingo11.Text = "BtnBingo11";
            this.BtnBingo11.UseVisualStyleBackColor = false;
            this.BtnBingo11.Click += new System.EventHandler(this.BtnBingo_Click);
            // 
            // BtnBingo12
            // 
            this.BtnBingo12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBingo12.BackColor = System.Drawing.Color.White;
            this.BtnBingo12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBingo12.Location = new System.Drawing.Point(151, 250);
            this.BtnBingo12.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBingo12.Name = "BtnBingo12";
            this.BtnBingo12.Size = new System.Drawing.Size(115, 115);
            this.BtnBingo12.TabIndex = 18;
            this.BtnBingo12.Text = "BtnBingo12";
            this.BtnBingo12.UseVisualStyleBackColor = false;
            this.BtnBingo12.Click += new System.EventHandler(this.BtnBingo_Click);
            // 
            // BtnBingo13
            // 
            this.BtnBingo13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBingo13.BackColor = System.Drawing.Color.White;
            this.BtnBingo13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBingo13.Location = new System.Drawing.Point(290, 250);
            this.BtnBingo13.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBingo13.Name = "BtnBingo13";
            this.BtnBingo13.Size = new System.Drawing.Size(115, 115);
            this.BtnBingo13.TabIndex = 19;
            this.BtnBingo13.Text = "BtnBingo13";
            this.BtnBingo13.UseVisualStyleBackColor = false;
            this.BtnBingo13.Click += new System.EventHandler(this.BtnBingo_Click);
            // 
            // BtnBingo15
            // 
            this.BtnBingo15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBingo15.BackColor = System.Drawing.Color.White;
            this.BtnBingo15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBingo15.Location = new System.Drawing.Point(569, 250);
            this.BtnBingo15.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBingo15.Name = "BtnBingo15";
            this.BtnBingo15.Size = new System.Drawing.Size(115, 115);
            this.BtnBingo15.TabIndex = 21;
            this.BtnBingo15.Text = "BtnBingo15";
            this.BtnBingo15.UseVisualStyleBackColor = false;
            this.BtnBingo15.Click += new System.EventHandler(this.BtnBingo_Click);
            // 
            // BtnBingo16
            // 
            this.BtnBingo16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBingo16.BackColor = System.Drawing.Color.White;
            this.BtnBingo16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBingo16.Location = new System.Drawing.Point(12, 373);
            this.BtnBingo16.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBingo16.Name = "BtnBingo16";
            this.BtnBingo16.Size = new System.Drawing.Size(115, 115);
            this.BtnBingo16.TabIndex = 22;
            this.BtnBingo16.Text = "BtnBingo16";
            this.BtnBingo16.UseVisualStyleBackColor = false;
            this.BtnBingo16.Click += new System.EventHandler(this.BtnBingo_Click);
            // 
            // BtnBingo17
            // 
            this.BtnBingo17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBingo17.BackColor = System.Drawing.Color.White;
            this.BtnBingo17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBingo17.Location = new System.Drawing.Point(151, 373);
            this.BtnBingo17.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBingo17.Name = "BtnBingo17";
            this.BtnBingo17.Size = new System.Drawing.Size(115, 115);
            this.BtnBingo17.TabIndex = 23;
            this.BtnBingo17.Text = "BtnBingo17";
            this.BtnBingo17.UseVisualStyleBackColor = false;
            this.BtnBingo17.Click += new System.EventHandler(this.BtnBingo_Click);
            // 
            // BtnBingo18
            // 
            this.BtnBingo18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBingo18.BackColor = System.Drawing.Color.White;
            this.BtnBingo18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBingo18.Location = new System.Drawing.Point(290, 373);
            this.BtnBingo18.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBingo18.Name = "BtnBingo18";
            this.BtnBingo18.Size = new System.Drawing.Size(115, 115);
            this.BtnBingo18.TabIndex = 24;
            this.BtnBingo18.Text = "BtnBingo18";
            this.BtnBingo18.UseVisualStyleBackColor = false;
            this.BtnBingo18.Click += new System.EventHandler(this.BtnBingo_Click);
            // 
            // BtnBingo20
            // 
            this.BtnBingo20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBingo20.BackColor = System.Drawing.Color.White;
            this.BtnBingo20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBingo20.Location = new System.Drawing.Point(569, 373);
            this.BtnBingo20.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBingo20.Name = "BtnBingo20";
            this.BtnBingo20.Size = new System.Drawing.Size(115, 115);
            this.BtnBingo20.TabIndex = 26;
            this.BtnBingo20.Text = "BtnBingo20";
            this.BtnBingo20.UseVisualStyleBackColor = false;
            this.BtnBingo20.Click += new System.EventHandler(this.BtnBingo_Click);
            // 
            // BtnBingo21
            // 
            this.BtnBingo21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBingo21.BackColor = System.Drawing.Color.White;
            this.BtnBingo21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBingo21.Location = new System.Drawing.Point(12, 497);
            this.BtnBingo21.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBingo21.Name = "BtnBingo21";
            this.BtnBingo21.Size = new System.Drawing.Size(115, 115);
            this.BtnBingo21.TabIndex = 27;
            this.BtnBingo21.Text = "BtnBingo21";
            this.BtnBingo21.UseVisualStyleBackColor = false;
            this.BtnBingo21.Click += new System.EventHandler(this.BtnBingo_Click);
            // 
            // BtnBingo22
            // 
            this.BtnBingo22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBingo22.BackColor = System.Drawing.Color.White;
            this.BtnBingo22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBingo22.Location = new System.Drawing.Point(151, 497);
            this.BtnBingo22.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBingo22.Name = "BtnBingo22";
            this.BtnBingo22.Size = new System.Drawing.Size(115, 115);
            this.BtnBingo22.TabIndex = 28;
            this.BtnBingo22.Text = "BtnBingo22";
            this.BtnBingo22.UseVisualStyleBackColor = false;
            this.BtnBingo22.Click += new System.EventHandler(this.BtnBingo_Click);
            // 
            // BtnBingo23
            // 
            this.BtnBingo23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBingo23.BackColor = System.Drawing.Color.White;
            this.BtnBingo23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBingo23.Location = new System.Drawing.Point(290, 497);
            this.BtnBingo23.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBingo23.Name = "BtnBingo23";
            this.BtnBingo23.Size = new System.Drawing.Size(115, 115);
            this.BtnBingo23.TabIndex = 29;
            this.BtnBingo23.Text = "BtnBingo23";
            this.BtnBingo23.UseVisualStyleBackColor = false;
            this.BtnBingo23.Click += new System.EventHandler(this.BtnBingo_Click);
            // 
            // BtnBingo24
            // 
            this.BtnBingo24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBingo24.BackColor = System.Drawing.Color.White;
            this.BtnBingo24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBingo24.Location = new System.Drawing.Point(429, 497);
            this.BtnBingo24.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBingo24.Name = "BtnBingo24";
            this.BtnBingo24.Size = new System.Drawing.Size(115, 115);
            this.BtnBingo24.TabIndex = 30;
            this.BtnBingo24.Text = "BtnBingo24";
            this.BtnBingo24.UseVisualStyleBackColor = false;
            this.BtnBingo24.Click += new System.EventHandler(this.BtnBingo_Click);
            // 
            // BtnBingo25
            // 
            this.BtnBingo25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBingo25.BackColor = System.Drawing.Color.White;
            this.BtnBingo25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBingo25.Location = new System.Drawing.Point(569, 497);
            this.BtnBingo25.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBingo25.Name = "BtnBingo25";
            this.BtnBingo25.Size = new System.Drawing.Size(115, 115);
            this.BtnBingo25.TabIndex = 3;
            this.BtnBingo25.Text = "BtnBingo25";
            this.BtnBingo25.UseVisualStyleBackColor = false;
            this.BtnBingo25.Click += new System.EventHandler(this.BtnBingo_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.BtnBingo1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnBingo2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnBingo3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnBingo4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnBingo5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnBingo6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnBingo7, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnBingo8, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnBingo9, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnBingo10, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnBingo11, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnBingo12, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnBingo13, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnBingo14, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnBingo15, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnBingo16, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.BtnBingo17, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.BtnBingo18, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.BtnBingo19, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.BtnBingo20, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.BtnBingo21, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.BtnBingo22, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.BtnBingo23, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.BtnBingo24, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.BtnBingo25, 4, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(698, 618);
            this.tableLayoutPanel1.TabIndex = 31;
            // 
            // BtnBingo14
            // 
            this.BtnBingo14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBingo14.BackColor = System.Drawing.Color.White;
            this.BtnBingo14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBingo14.Location = new System.Drawing.Point(429, 250);
            this.BtnBingo14.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBingo14.Name = "BtnBingo14";
            this.BtnBingo14.Size = new System.Drawing.Size(115, 115);
            this.BtnBingo14.TabIndex = 20;
            this.BtnBingo14.Text = "BtnBingo14";
            this.BtnBingo14.UseVisualStyleBackColor = false;
            this.BtnBingo14.Click += new System.EventHandler(this.BtnBingo_Click);
            // 
            // BtnBingo19
            // 
            this.BtnBingo19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBingo19.BackColor = System.Drawing.Color.White;
            this.BtnBingo19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBingo19.Location = new System.Drawing.Point(429, 373);
            this.BtnBingo19.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBingo19.Name = "BtnBingo19";
            this.BtnBingo19.Size = new System.Drawing.Size(115, 115);
            this.BtnBingo19.TabIndex = 25;
            this.BtnBingo19.Text = "BtnBingo19";
            this.BtnBingo19.UseVisualStyleBackColor = false;
            this.BtnBingo19.Click += new System.EventHandler(this.BtnBingo_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnGenerate, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(704, 657);
            this.tableLayoutPanel2.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 681);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(720, 720);
            this.Name = "Form1";
            this.Text = "CustomBingo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.Button BtnBingo1;
        private System.Windows.Forms.Button BtnBingo2;
        private System.Windows.Forms.Button BtnBingo3;
        private System.Windows.Forms.Button BtnBingo4;
        private System.Windows.Forms.Button BtnBingo5;
        private System.Windows.Forms.Button BtnBingo6;
        private System.Windows.Forms.Button BtnBingo7;
        private System.Windows.Forms.Button BtnBingo8;
        private System.Windows.Forms.Button BtnBingo9;
        private System.Windows.Forms.Button BtnBingo10;
        private System.Windows.Forms.Button BtnBingo11;
        private System.Windows.Forms.Button BtnBingo12;
        private System.Windows.Forms.Button BtnBingo13;
        private System.Windows.Forms.Button BtnBingo15;
        private System.Windows.Forms.Button BtnBingo16;
        private System.Windows.Forms.Button BtnBingo17;
        private System.Windows.Forms.Button BtnBingo18;
        private System.Windows.Forms.Button BtnBingo20;
        private System.Windows.Forms.Button BtnBingo21;
        private System.Windows.Forms.Button BtnBingo22;
        private System.Windows.Forms.Button BtnBingo23;
        private System.Windows.Forms.Button BtnBingo24;
        private System.Windows.Forms.Button BtnBingo25;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnBingo19;
        private System.Windows.Forms.Button BtnBingo14;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ToolStripMenuItem boardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem1;
    }
}

