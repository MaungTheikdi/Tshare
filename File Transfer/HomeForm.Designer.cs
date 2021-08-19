namespace File_Transfer
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.onlinePCList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.aboutBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notificationLabel = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.fileNotificationLabel = new System.Windows.Forms.Label();
            this.savePathLabel = new System.Windows.Forms.Label();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.notificationPanel = new System.Windows.Forms.Panel();
            this.notificationTempLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.connectBtn = new FontAwesome.Sharp.IconButton();
            this.pickBtn = new FontAwesome.Sharp.IconButton();
            this.sendBtn = new FontAwesome.Sharp.IconButton();
            this.clearBtn = new FontAwesome.Sharp.IconButton();
            this.stopBtn = new FontAwesome.Sharp.IconButton();
            this.bunifuShapes1 = new Bunifu.UI.WinForms.BunifuShapes();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuShapes2 = new Bunifu.UI.WinForms.BunifuShapes();
            this.bunifuPanel3 = new Bunifu.UI.WinForms.BunifuPanel();
            this.saveFileLocationBtn = new FontAwesome.Sharp.IconButton();
            this.savePathLabe2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ipBox2 = new Bunifu.UI.WinForms.BunifuTextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.notificationPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            this.bunifuPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // onlinePCList
            // 
            this.onlinePCList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.onlinePCList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.onlinePCList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.onlinePCList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.onlinePCList.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlinePCList.FullRowSelect = true;
            this.onlinePCList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.onlinePCList.HideSelection = false;
            this.onlinePCList.HoverSelection = true;
            this.onlinePCList.Location = new System.Drawing.Point(0, 0);
            this.onlinePCList.MultiSelect = false;
            this.onlinePCList.Name = "onlinePCList";
            this.onlinePCList.Size = new System.Drawing.Size(841, 534);
            this.onlinePCList.TabIndex = 0;
            this.onlinePCList.UseCompatibleStateImageBehavior = false;
            this.onlinePCList.View = System.Windows.Forms.View.Details;
            this.onlinePCList.SelectedIndexChanged += new System.EventHandler(this.onlinePCList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "IP Address";
            this.columnHeader1.Width = 271;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ကန်ပျူတာအမည်";
            this.columnHeader2.Width = 263;
            // 
            // aboutBtn
            // 
            this.aboutBtn.BackColor = System.Drawing.Color.Black;
            this.aboutBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.aboutBtn.FlatAppearance.BorderSize = 0;
            this.aboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutBtn.ForeColor = System.Drawing.Color.Lime;
            this.aboutBtn.Location = new System.Drawing.Point(0, 593);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(220, 40);
            this.aboutBtn.TabIndex = 15;
            this.aboutBtn.Text = "About";
            this.aboutBtn.UseVisualStyleBackColor = false;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(96, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 37);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tshare";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::File_Transfer.Properties.Resources.logo_dark;
            this.pictureBox1.Location = new System.Drawing.Point(18, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // notificationLabel
            // 
            this.notificationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.notificationLabel.AutoSize = true;
            this.notificationLabel.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationLabel.ForeColor = System.Drawing.Color.Lime;
            this.notificationLabel.Location = new System.Drawing.Point(41, 127);
            this.notificationLabel.Name = "notificationLabel";
            this.notificationLabel.Size = new System.Drawing.Size(0, 27);
            this.notificationLabel.TabIndex = 3;
            this.notificationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.BackColor = System.Drawing.SystemColors.Window;
            this.fileNameLabel.Font = new System.Drawing.Font("Pyidaungsu", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fileNameLabel.Location = new System.Drawing.Point(6, 489);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(0, 26);
            this.fileNameLabel.TabIndex = 3;
            // 
            // infoLabel
            // 
            this.infoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Pyidaungsu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.ForeColor = System.Drawing.Color.Yellow;
            this.infoLabel.Location = new System.Drawing.Point(3, 19);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 21);
            this.infoLabel.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fileNotificationLabel
            // 
            this.fileNotificationLabel.AutoSize = true;
            this.fileNotificationLabel.BackColor = System.Drawing.SystemColors.Window;
            this.fileNotificationLabel.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNotificationLabel.ForeColor = System.Drawing.Color.Black;
            this.fileNotificationLabel.Location = new System.Drawing.Point(6, 440);
            this.fileNotificationLabel.Name = "fileNotificationLabel";
            this.fileNotificationLabel.Size = new System.Drawing.Size(0, 27);
            this.fileNotificationLabel.TabIndex = 9;
            // 
            // savePathLabel
            // 
            this.savePathLabel.AutoSize = true;
            this.savePathLabel.ForeColor = System.Drawing.Color.GhostWhite;
            this.savePathLabel.Location = new System.Drawing.Point(8, 14);
            this.savePathLabel.Name = "savePathLabel";
            this.savePathLabel.Size = new System.Drawing.Size(141, 13);
            this.savePathLabel.TabIndex = 10;
            this.savePathLabel.Text = "C:\\Users\\Public\\Downloads";
            this.savePathLabel.Click += new System.EventHandler(this.savePathLabel_Click);
            // 
            // ipBox
            // 
            this.ipBox.Font = new System.Drawing.Font("Pyidaungsu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipBox.Location = new System.Drawing.Point(693, 3);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(136, 33);
            this.ipBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Pyidaungsu", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(470, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "လက်ခံမည့် IP မတွေ့ပါက ဤနေရာတွင် ထည့်ပါ";
            // 
            // notificationPanel
            // 
            this.notificationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(86)))));
            this.notificationPanel.Controls.Add(this.notificationTempLabel);
            this.notificationPanel.Location = new System.Drawing.Point(46, 187);
            this.notificationPanel.Name = "notificationPanel";
            this.notificationPanel.Size = new System.Drawing.Size(611, 100);
            this.notificationPanel.TabIndex = 13;
            this.notificationPanel.UseWaitCursor = true;
            this.notificationPanel.Visible = false;
            // 
            // notificationTempLabel
            // 
            this.notificationTempLabel.AutoSize = true;
            this.notificationTempLabel.Font = new System.Drawing.Font("Pyidaungsu", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationTempLabel.ForeColor = System.Drawing.Color.Yellow;
            this.notificationTempLabel.Location = new System.Drawing.Point(24, 26);
            this.notificationTempLabel.Name = "notificationTempLabel";
            this.notificationTempLabel.Size = new System.Drawing.Size(236, 31);
            this.notificationTempLabel.TabIndex = 2;
            this.notificationTempLabel.Text = "ခဏစောင့်ပါ..  ဖိုင်ပို့နေပါသည်...";
            this.notificationTempLabel.UseWaitCursor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel3.Controls.Add(this.ipBox2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.ipBox);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.savePathLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(220, 593);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(841, 40);
            this.panel3.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Desktop;
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(8, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(374, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Developed by : Theikdi Maung, hello@theikdimaung.com, (+95) 9 263230440";
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.menuPanel.Controls.Add(this.pictureBox1);
            this.menuPanel.Controls.Add(this.aboutBtn);
            this.menuPanel.Controls.Add(this.bunifuPanel3);
            this.menuPanel.Controls.Add(this.bunifuShapes2);
            this.menuPanel.Controls.Add(this.bunifuPanel2);
            this.menuPanel.Controls.Add(this.bunifuShapes1);
            this.menuPanel.Controls.Add(this.sendBtn);
            this.menuPanel.Controls.Add(this.pickBtn);
            this.menuPanel.Controls.Add(this.connectBtn);
            this.menuPanel.Controls.Add(this.logoPanel);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(220, 633);
            this.menuPanel.TabIndex = 16;
            // 
            // logoPanel
            // 
            this.logoPanel.Controls.Add(this.label2);
            this.logoPanel.Controls.Add(this.notificationLabel);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(220, 157);
            this.logoPanel.TabIndex = 0;
            // 
            // connectBtn
            // 
            this.connectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.connectBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.connectBtn.FlatAppearance.BorderSize = 0;
            this.connectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectBtn.Font = new System.Drawing.Font("Pyidaungsu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.connectBtn.IconChar = FontAwesome.Sharp.IconChar.NetworkWired;
            this.connectBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.connectBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.connectBtn.IconSize = 32;
            this.connectBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.connectBtn.Location = new System.Drawing.Point(0, 157);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.connectBtn.Size = new System.Drawing.Size(220, 50);
            this.connectBtn.TabIndex = 1;
            this.connectBtn.Text = "ချိတ်ဆက်မှု ရှာဖွေ";
            this.connectBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.connectBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.connectBtn.UseVisualStyleBackColor = false;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // pickBtn
            // 
            this.pickBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pickBtn.FlatAppearance.BorderSize = 0;
            this.pickBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pickBtn.Font = new System.Drawing.Font("Pyidaungsu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.pickBtn.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.pickBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.pickBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pickBtn.IconSize = 32;
            this.pickBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pickBtn.Location = new System.Drawing.Point(0, 207);
            this.pickBtn.Name = "pickBtn";
            this.pickBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.pickBtn.Size = new System.Drawing.Size(220, 50);
            this.pickBtn.TabIndex = 5;
            this.pickBtn.Text = "ပေးပို့ရန် ဖိုင်ယူ";
            this.pickBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pickBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pickBtn.UseVisualStyleBackColor = true;
            this.pickBtn.Click += new System.EventHandler(this.pickBtn_Click);
            // 
            // sendBtn
            // 
            this.sendBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.sendBtn.FlatAppearance.BorderSize = 0;
            this.sendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendBtn.Font = new System.Drawing.Font("Pyidaungsu", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.sendBtn.IconChar = FontAwesome.Sharp.IconChar.Share;
            this.sendBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.sendBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sendBtn.IconSize = 32;
            this.sendBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sendBtn.Location = new System.Drawing.Point(0, 257);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.sendBtn.Size = new System.Drawing.Size(220, 50);
            this.sendBtn.TabIndex = 4;
            this.sendBtn.Text = "ပေးပို့";
            this.sendBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sendBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Pyidaungsu", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.clearBtn.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.clearBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.clearBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.clearBtn.IconSize = 32;
            this.clearBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearBtn.Location = new System.Drawing.Point(0, 50);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.clearBtn.Size = new System.Drawing.Size(220, 50);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "ချိတ်ဆက်မှုများရှင်း";
            this.clearBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.stopBtn.FlatAppearance.BorderSize = 0;
            this.stopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopBtn.Font = new System.Drawing.Font("Pyidaungsu", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.stopBtn.IconChar = FontAwesome.Sharp.IconChar.StopCircle;
            this.stopBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.stopBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.stopBtn.IconSize = 32;
            this.stopBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stopBtn.Location = new System.Drawing.Point(0, 0);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.stopBtn.Size = new System.Drawing.Size(220, 50);
            this.stopBtn.TabIndex = 7;
            this.stopBtn.Text = "ချိတ်ဆက်မှု ရပ်နား";
            this.stopBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stopBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // bunifuShapes1
            // 
            this.bunifuShapes1.Angle = 0F;
            this.bunifuShapes1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShapes1.BorderColor = System.Drawing.Color.Silver;
            this.bunifuShapes1.BorderThickness = 1;
            this.bunifuShapes1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuShapes1.FillColor = System.Drawing.Color.Transparent;
            this.bunifuShapes1.FillShape = true;
            this.bunifuShapes1.Location = new System.Drawing.Point(0, 307);
            this.bunifuShapes1.Name = "bunifuShapes1";
            this.bunifuShapes1.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Line;
            this.bunifuShapes1.Sides = 5;
            this.bunifuShapes1.Size = new System.Drawing.Size(220, 22);
            this.bunifuShapes1.TabIndex = 8;
            this.bunifuShapes1.Text = "bunifuShapes1";
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 0;
            this.bunifuPanel2.BorderThickness = 0;
            this.bunifuPanel2.Controls.Add(this.clearBtn);
            this.bunifuPanel2.Controls.Add(this.stopBtn);
            this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel2.Location = new System.Drawing.Point(0, 329);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(220, 108);
            this.bunifuPanel2.TabIndex = 9;
            // 
            // bunifuShapes2
            // 
            this.bunifuShapes2.Angle = 0F;
            this.bunifuShapes2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShapes2.BorderColor = System.Drawing.Color.Silver;
            this.bunifuShapes2.BorderThickness = 1;
            this.bunifuShapes2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuShapes2.FillColor = System.Drawing.Color.Transparent;
            this.bunifuShapes2.FillShape = true;
            this.bunifuShapes2.Location = new System.Drawing.Point(0, 437);
            this.bunifuShapes2.Name = "bunifuShapes2";
            this.bunifuShapes2.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Line;
            this.bunifuShapes2.Sides = 5;
            this.bunifuShapes2.Size = new System.Drawing.Size(220, 22);
            this.bunifuShapes2.TabIndex = 10;
            this.bunifuShapes2.Text = "bunifuShapes2";
            // 
            // bunifuPanel3
            // 
            this.bunifuPanel3.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel3.BackgroundImage")));
            this.bunifuPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel3.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel3.BorderRadius = 0;
            this.bunifuPanel3.BorderThickness = 0;
            this.bunifuPanel3.Controls.Add(this.savePathLabe2);
            this.bunifuPanel3.Controls.Add(this.saveFileLocationBtn);
            this.bunifuPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel3.Location = new System.Drawing.Point(0, 459);
            this.bunifuPanel3.Name = "bunifuPanel3";
            this.bunifuPanel3.ShowBorders = true;
            this.bunifuPanel3.Size = new System.Drawing.Size(220, 100);
            this.bunifuPanel3.TabIndex = 11;
            // 
            // saveFileLocationBtn
            // 
            this.saveFileLocationBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.saveFileLocationBtn.FlatAppearance.BorderSize = 0;
            this.saveFileLocationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveFileLocationBtn.Font = new System.Drawing.Font("Pyidaungsu", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveFileLocationBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.saveFileLocationBtn.IconChar = FontAwesome.Sharp.IconChar.Folder;
            this.saveFileLocationBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.saveFileLocationBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.saveFileLocationBtn.IconSize = 32;
            this.saveFileLocationBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveFileLocationBtn.Location = new System.Drawing.Point(0, 0);
            this.saveFileLocationBtn.Name = "saveFileLocationBtn";
            this.saveFileLocationBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.saveFileLocationBtn.Size = new System.Drawing.Size(220, 50);
            this.saveFileLocationBtn.TabIndex = 8;
            this.saveFileLocationBtn.Text = "ဖိုင်လက်ခံမည့်နေရာ";
            this.saveFileLocationBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveFileLocationBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveFileLocationBtn.UseVisualStyleBackColor = true;
            this.saveFileLocationBtn.Click += new System.EventHandler(this.saveFileLocationBtn_Click);
            // 
            // savePathLabe2
            // 
            this.savePathLabe2.AllowParentOverrides = false;
            this.savePathLabe2.AutoEllipsis = false;
            this.savePathLabe2.AutoSize = false;
            this.savePathLabe2.CursorType = null;
            this.savePathLabe2.Dock = System.Windows.Forms.DockStyle.Top;
            this.savePathLabe2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.savePathLabe2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.savePathLabe2.Location = new System.Drawing.Point(0, 50);
            this.savePathLabe2.Name = "savePathLabe2";
            this.savePathLabe2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.savePathLabe2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.savePathLabe2.Size = new System.Drawing.Size(220, 47);
            this.savePathLabe2.TabIndex = 9;
            this.savePathLabe2.Text = "C:\\Users\\Public\\Downloads";
            this.savePathLabe2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.savePathLabe2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.iconButton3);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.infoLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(220, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 59);
            this.panel1.TabIndex = 17;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.fileNameLabel);
            this.panel2.Controls.Add(this.fileNotificationLabel);
            this.panel2.Controls.Add(this.notificationPanel);
            this.panel2.Controls.Add(this.onlinePCList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(220, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(841, 534);
            this.panel2.TabIndex = 18;
            // 
            // ipBox2
            // 
            this.ipBox2.AcceptsReturn = false;
            this.ipBox2.AcceptsTab = false;
            this.ipBox2.AnimationSpeed = 200;
            this.ipBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ipBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ipBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ipBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ipBox2.BackgroundImage")));
            this.ipBox2.BorderColorActive = System.Drawing.Color.DarkTurquoise;
            this.ipBox2.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ipBox2.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ipBox2.BorderColorIdle = System.Drawing.Color.Black;
            this.ipBox2.BorderRadius = 1;
            this.ipBox2.BorderThickness = 1;
            this.ipBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ipBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipBox2.DefaultFont = new System.Drawing.Font("Segoe UI", 10F);
            this.ipBox2.DefaultText = "";
            this.ipBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.ipBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ipBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ipBox2.HideSelection = true;
            this.ipBox2.IconLeft = null;
            this.ipBox2.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.ipBox2.IconPadding = 10;
            this.ipBox2.IconRight = null;
            this.ipBox2.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.ipBox2.Lines = new string[0];
            this.ipBox2.Location = new System.Drawing.Point(693, 0);
            this.ipBox2.Margin = new System.Windows.Forms.Padding(13);
            this.ipBox2.MaxLength = 32767;
            this.ipBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.ipBox2.Modified = false;
            this.ipBox2.Multiline = false;
            this.ipBox2.Name = "ipBox2";
            stateProperties13.BorderColor = System.Drawing.Color.DarkTurquoise;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.ipBox2.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.ipBox2.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.ipBox2.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Black;
            stateProperties16.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            stateProperties16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.ipBox2.OnIdleState = stateProperties16;
            this.ipBox2.Padding = new System.Windows.Forms.Padding(13);
            this.ipBox2.PasswordChar = '\0';
            this.ipBox2.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.ipBox2.PlaceholderText = "192.168.1.1";
            this.ipBox2.ReadOnly = false;
            this.ipBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ipBox2.SelectedText = "";
            this.ipBox2.SelectionLength = 0;
            this.ipBox2.SelectionStart = 0;
            this.ipBox2.ShortcutsEnabled = true;
            this.ipBox2.Size = new System.Drawing.Size(148, 40);
            this.ipBox2.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.ipBox2.TabIndex = 13;
            this.ipBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ipBox2.TextMarginBottom = 0;
            this.ipBox2.TextMarginLeft = 3;
            this.ipBox2.TextMarginTop = 0;
            this.ipBox2.TextPlaceholder = "192.168.1.1";
            this.ipBox2.UseSystemPasswordChar = false;
            this.ipBox2.WordWrap = true;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconButton1.IconColor = System.Drawing.SystemColors.ActiveCaption;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(795, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(46, 59);
            this.iconButton1.TabIndex = 12;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconButton2.IconColor = System.Drawing.SystemColors.ActiveCaption;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 20;
            this.iconButton2.Location = new System.Drawing.Point(749, 0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(46, 59);
            this.iconButton2.TabIndex = 13;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconButton3.IconColor = System.Drawing.SystemColors.ActiveCaption;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 20;
            this.iconButton3.Location = new System.Drawing.Point(703, 0);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.iconButton3.Size = new System.Drawing.Size(46, 59);
            this.iconButton3.TabIndex = 14;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1061, 633);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuPanel);
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Theikdi File Share";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.notificationPanel.ResumeLayout(false);
            this.notificationPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView onlinePCList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label notificationLabel;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label fileNotificationLabel;
        private System.Windows.Forms.Label savePathLabel;
        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel notificationPanel;
        private System.Windows.Forms.Label notificationTempLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Panel menuPanel;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel3;
        private Bunifu.UI.WinForms.BunifuLabel savePathLabe2;
        private FontAwesome.Sharp.IconButton saveFileLocationBtn;
        private Bunifu.UI.WinForms.BunifuShapes bunifuShapes2;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private FontAwesome.Sharp.IconButton clearBtn;
        private FontAwesome.Sharp.IconButton stopBtn;
        private Bunifu.UI.WinForms.BunifuShapes bunifuShapes1;
        private FontAwesome.Sharp.IconButton sendBtn;
        private FontAwesome.Sharp.IconButton pickBtn;
        private FontAwesome.Sharp.IconButton connectBtn;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuTextBox ipBox2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}

