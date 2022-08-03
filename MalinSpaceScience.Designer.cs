namespace MalinSpaceScience
{
    partial class MalinSpaceScience
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
            this.listViewData = new System.Windows.Forms.ListView();
            this.SensorA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SensorB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listBoxSensorA = new System.Windows.Forms.ListBox();
            this.listBoxSensorB = new System.Windows.Forms.ListBox();
            this.buttonLoadSensorData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btSensorASearchIterative = new System.Windows.Forms.Button();
            this.btSensorASearchRecursive = new System.Windows.Forms.Button();
            this.btSensorASortSelection = new System.Windows.Forms.Button();
            this.btSensorASortInsertion = new System.Windows.Forms.Button();
            this.btSensorBSearchIterative = new System.Windows.Forms.Button();
            this.btSensorBSearchRecursive = new System.Windows.Forms.Button();
            this.btSensorBSortSelection = new System.Windows.Forms.Button();
            this.btSensorBSortInsertion = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txSensorASearchIterative = new System.Windows.Forms.TextBox();
            this.txSensorBSearchIterative = new System.Windows.Forms.TextBox();
            this.txSensorASearchRecursive = new System.Windows.Forms.TextBox();
            this.txSensorBSearchRecursive = new System.Windows.Forms.TextBox();
            this.txSensorASortSelection = new System.Windows.Forms.TextBox();
            this.txSensorBSortSelection = new System.Windows.Forms.TextBox();
            this.txSensorASortInsertion = new System.Windows.Forms.TextBox();
            this.txSensorBSortInsertion = new System.Windows.Forms.TextBox();
            this.Target = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txTargetSA = new System.Windows.Forms.TextBox();
            this.txTargetSB = new System.Windows.Forms.TextBox();
            this.Sigma = new System.Windows.Forms.NumericUpDown();
            this.Mu = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Sigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewData
            // 
            this.listViewData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SensorA,
            this.SensorB});
            this.listViewData.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewData.GridLines = true;
            this.listViewData.HideSelection = false;
            this.listViewData.Location = new System.Drawing.Point(12, 110);
            this.listViewData.Name = "listViewData";
            this.listViewData.Size = new System.Drawing.Size(181, 407);
            this.listViewData.TabIndex = 0;
            this.listViewData.UseCompatibleStateImageBehavior = false;
            this.listViewData.View = System.Windows.Forms.View.Details;
            // 
            // SensorA
            // 
            this.SensorA.Text = "SensorA";
            this.SensorA.Width = 82;
            // 
            // SensorB
            // 
            this.SensorB.Text = "SensorB";
            this.SensorB.Width = 81;
            // 
            // listBoxSensorA
            // 
            this.listBoxSensorA.FormattingEnabled = true;
            this.listBoxSensorA.Location = new System.Drawing.Point(396, 38);
            this.listBoxSensorA.Name = "listBoxSensorA";
            this.listBoxSensorA.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxSensorA.Size = new System.Drawing.Size(100, 472);
            this.listBoxSensorA.TabIndex = 1;
            // 
            // listBoxSensorB
            // 
            this.listBoxSensorB.FormattingEnabled = true;
            this.listBoxSensorB.Location = new System.Drawing.Point(670, 38);
            this.listBoxSensorB.Name = "listBoxSensorB";
            this.listBoxSensorB.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxSensorB.Size = new System.Drawing.Size(100, 472);
            this.listBoxSensorB.TabIndex = 2;
            // 
            // buttonLoadSensorData
            // 
            this.buttonLoadSensorData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadSensorData.Location = new System.Drawing.Point(29, 77);
            this.buttonLoadSensorData.Name = "buttonLoadSensorData";
            this.buttonLoadSensorData.Size = new System.Drawing.Size(141, 23);
            this.buttonLoadSensorData.TabIndex = 3;
            this.buttonLoadSensorData.Text = "Load Sensor Data";
            this.buttonLoadSensorData.UseVisualStyleBackColor = true;
            this.buttonLoadSensorData.Click += new System.EventHandler(this.buttonLoadSensorData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sensor A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(535, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sensor B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(223, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Binary Search Iterative";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(520, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Binary Search Iterative";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(219, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Binary Search Recursive";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(511, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Binary Search Recursive";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(239, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Selection Sort";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(533, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Selection Sort";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(236, 426);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Insertion Sort";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(533, 430);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "Insertion Sort";
            // 
            // btSensorASearchIterative
            // 
            this.btSensorASearchIterative.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSensorASearchIterative.Location = new System.Drawing.Point(246, 84);
            this.btSensorASearchIterative.Name = "btSensorASearchIterative";
            this.btSensorASearchIterative.Size = new System.Drawing.Size(75, 23);
            this.btSensorASearchIterative.TabIndex = 14;
            this.btSensorASearchIterative.Text = "Search";
            this.btSensorASearchIterative.UseVisualStyleBackColor = true;
            this.btSensorASearchIterative.Click += new System.EventHandler(this.btSensorASearchIterative_Click);
            // 
            // btSensorASearchRecursive
            // 
            this.btSensorASearchRecursive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSensorASearchRecursive.Location = new System.Drawing.Point(245, 196);
            this.btSensorASearchRecursive.Name = "btSensorASearchRecursive";
            this.btSensorASearchRecursive.Size = new System.Drawing.Size(75, 23);
            this.btSensorASearchRecursive.TabIndex = 15;
            this.btSensorASearchRecursive.Text = "Search";
            this.btSensorASearchRecursive.UseVisualStyleBackColor = true;
            this.btSensorASearchRecursive.Click += new System.EventHandler(this.btSensorASearchRecursive_Click);
            // 
            // btSensorASortSelection
            // 
            this.btSensorASortSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSensorASortSelection.Location = new System.Drawing.Point(240, 348);
            this.btSensorASortSelection.Name = "btSensorASortSelection";
            this.btSensorASortSelection.Size = new System.Drawing.Size(75, 23);
            this.btSensorASortSelection.TabIndex = 16;
            this.btSensorASortSelection.Text = "Sort";
            this.btSensorASortSelection.UseVisualStyleBackColor = true;
            this.btSensorASortSelection.Click += new System.EventHandler(this.btSensorASortSelection_Click);
            // 
            // btSensorASortInsertion
            // 
            this.btSensorASortInsertion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSensorASortInsertion.Location = new System.Drawing.Point(242, 444);
            this.btSensorASortInsertion.Name = "btSensorASortInsertion";
            this.btSensorASortInsertion.Size = new System.Drawing.Size(75, 23);
            this.btSensorASortInsertion.TabIndex = 17;
            this.btSensorASortInsertion.Text = "Sort";
            this.btSensorASortInsertion.UseVisualStyleBackColor = true;
            this.btSensorASortInsertion.Click += new System.EventHandler(this.btSensorASortInsertion_Click);
            // 
            // btSensorBSearchIterative
            // 
            this.btSensorBSearchIterative.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSensorBSearchIterative.Location = new System.Drawing.Point(539, 80);
            this.btSensorBSearchIterative.Name = "btSensorBSearchIterative";
            this.btSensorBSearchIterative.Size = new System.Drawing.Size(75, 23);
            this.btSensorBSearchIterative.TabIndex = 18;
            this.btSensorBSearchIterative.Text = "Search";
            this.btSensorBSearchIterative.UseVisualStyleBackColor = true;
            this.btSensorBSearchIterative.Click += new System.EventHandler(this.btSensorBSearchIterative_Click);
            // 
            // btSensorBSearchRecursive
            // 
            this.btSensorBSearchRecursive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSensorBSearchRecursive.Location = new System.Drawing.Point(539, 196);
            this.btSensorBSearchRecursive.Name = "btSensorBSearchRecursive";
            this.btSensorBSearchRecursive.Size = new System.Drawing.Size(75, 23);
            this.btSensorBSearchRecursive.TabIndex = 19;
            this.btSensorBSearchRecursive.Text = "Search";
            this.btSensorBSearchRecursive.UseVisualStyleBackColor = true;
            this.btSensorBSearchRecursive.Click += new System.EventHandler(this.btSensorBSearchRecursive_Click);
            // 
            // btSensorBSortSelection
            // 
            this.btSensorBSortSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSensorBSortSelection.Location = new System.Drawing.Point(539, 351);
            this.btSensorBSortSelection.Name = "btSensorBSortSelection";
            this.btSensorBSortSelection.Size = new System.Drawing.Size(75, 23);
            this.btSensorBSortSelection.TabIndex = 20;
            this.btSensorBSortSelection.Text = "Sort";
            this.btSensorBSortSelection.UseVisualStyleBackColor = true;
            this.btSensorBSortSelection.Click += new System.EventHandler(this.btSensorBSortSelection_Click);
            // 
            // btSensorBSortInsertion
            // 
            this.btSensorBSortInsertion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSensorBSortInsertion.Location = new System.Drawing.Point(538, 451);
            this.btSensorBSortInsertion.Name = "btSensorBSortInsertion";
            this.btSensorBSortInsertion.Size = new System.Drawing.Size(75, 23);
            this.btSensorBSortInsertion.TabIndex = 21;
            this.btSensorBSortInsertion.Text = "Sort";
            this.btSensorBSortInsertion.UseVisualStyleBackColor = true;
            this.btSensorBSortInsertion.Click += new System.EventHandler(this.btSensorBSortInsertion_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(223, 273);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 22;
            // 
            // txSensorASearchIterative
            // 
            this.txSensorASearchIterative.Location = new System.Drawing.Point(222, 110);
            this.txSensorASearchIterative.Name = "txSensorASearchIterative";
            this.txSensorASearchIterative.Size = new System.Drawing.Size(136, 20);
            this.txSensorASearchIterative.TabIndex = 23;
            this.txSensorASearchIterative.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txSensorBSearchIterative
            // 
            this.txSensorBSearchIterative.Location = new System.Drawing.Point(514, 106);
            this.txSensorBSearchIterative.Name = "txSensorBSearchIterative";
            this.txSensorBSearchIterative.Size = new System.Drawing.Size(136, 20);
            this.txSensorBSearchIterative.TabIndex = 24;
            this.txSensorBSearchIterative.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txSensorASearchRecursive
            // 
            this.txSensorASearchRecursive.Location = new System.Drawing.Point(222, 225);
            this.txSensorASearchRecursive.Name = "txSensorASearchRecursive";
            this.txSensorASearchRecursive.Size = new System.Drawing.Size(136, 20);
            this.txSensorASearchRecursive.TabIndex = 25;
            this.txSensorASearchRecursive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txSensorBSearchRecursive
            // 
            this.txSensorBSearchRecursive.Location = new System.Drawing.Point(514, 225);
            this.txSensorBSearchRecursive.Name = "txSensorBSearchRecursive";
            this.txSensorBSearchRecursive.Size = new System.Drawing.Size(136, 20);
            this.txSensorBSearchRecursive.TabIndex = 26;
            this.txSensorBSearchRecursive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txSensorASortSelection
            // 
            this.txSensorASortSelection.Location = new System.Drawing.Point(221, 377);
            this.txSensorASortSelection.Name = "txSensorASortSelection";
            this.txSensorASortSelection.Size = new System.Drawing.Size(136, 20);
            this.txSensorASortSelection.TabIndex = 27;
            this.txSensorASortSelection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txSensorBSortSelection
            // 
            this.txSensorBSortSelection.Location = new System.Drawing.Point(519, 380);
            this.txSensorBSortSelection.Name = "txSensorBSortSelection";
            this.txSensorBSortSelection.Size = new System.Drawing.Size(136, 20);
            this.txSensorBSortSelection.TabIndex = 28;
            this.txSensorBSortSelection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txSensorASortInsertion
            // 
            this.txSensorASortInsertion.Location = new System.Drawing.Point(221, 473);
            this.txSensorASortInsertion.Name = "txSensorASortInsertion";
            this.txSensorASortInsertion.Size = new System.Drawing.Size(136, 20);
            this.txSensorASortInsertion.TabIndex = 29;
            this.txSensorASortInsertion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txSensorBSortInsertion
            // 
            this.txSensorBSortInsertion.Location = new System.Drawing.Point(519, 480);
            this.txSensorBSortInsertion.Name = "txSensorBSortInsertion";
            this.txSensorBSortInsertion.Size = new System.Drawing.Size(136, 20);
            this.txSensorBSortInsertion.TabIndex = 30;
            this.txSensorBSortInsertion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Target
            // 
            this.Target.AutoSize = true;
            this.Target.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Target.Location = new System.Drawing.Point(219, 286);
            this.Target.Name = "Target";
            this.Target.Size = new System.Drawing.Size(85, 15);
            this.Target.TabIndex = 31;
            this.Target.Text = "Search Target";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(511, 286);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 15);
            this.label12.TabIndex = 32;
            this.label12.Text = "Search Target";
            // 
            // txTargetSA
            // 
            this.txTargetSA.Location = new System.Drawing.Point(310, 286);
            this.txTargetSA.Name = "txTargetSA";
            this.txTargetSA.Size = new System.Drawing.Size(47, 20);
            this.txTargetSA.TabIndex = 33;
            this.txTargetSA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txTargetSA_KeyPress);
            this.txTargetSA.Validating += new System.ComponentModel.CancelEventHandler(this.txTargetSA_Validating);
            // 
            // txTargetSB
            // 
            this.txTargetSB.Location = new System.Drawing.Point(602, 286);
            this.txTargetSB.Name = "txTargetSB";
            this.txTargetSB.Size = new System.Drawing.Size(47, 20);
            this.txTargetSB.TabIndex = 34;
            this.txTargetSB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txTargetSB_KeyPress);
            this.txTargetSB.Validating += new System.ComponentModel.CancelEventHandler(this.txTargetSB_Validating);
            // 
            // Sigma
            // 
            this.Sigma.Location = new System.Drawing.Point(29, 38);
            this.Sigma.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Sigma.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Sigma.Name = "Sigma";
            this.Sigma.Size = new System.Drawing.Size(43, 20);
            this.Sigma.TabIndex = 39;
            this.Sigma.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Mu
            // 
            this.Mu.Location = new System.Drawing.Point(104, 38);
            this.Mu.Maximum = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.Mu.Minimum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.Mu.Name = "Mu";
            this.Mu.Size = new System.Drawing.Size(43, 20);
            this.Mu.TabIndex = 40;
            this.Mu.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(32, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 15);
            this.label13.TabIndex = 41;
            this.label13.Text = "Sigma";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(101, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 15);
            this.label14.TabIndex = 42;
            this.label14.Text = "Mu";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(176, 265);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 80);
            this.vScrollBar1.TabIndex = 43;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MalinSpaceScience
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 529);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Mu);
            this.Controls.Add(this.Sigma);
            this.Controls.Add(this.txTargetSB);
            this.Controls.Add(this.txTargetSA);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Target);
            this.Controls.Add(this.txSensorBSortInsertion);
            this.Controls.Add(this.txSensorASortInsertion);
            this.Controls.Add(this.txSensorBSortSelection);
            this.Controls.Add(this.txSensorASortSelection);
            this.Controls.Add(this.txSensorBSearchRecursive);
            this.Controls.Add(this.txSensorASearchRecursive);
            this.Controls.Add(this.txSensorBSearchIterative);
            this.Controls.Add(this.txSensorASearchIterative);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btSensorBSortInsertion);
            this.Controls.Add(this.btSensorBSortSelection);
            this.Controls.Add(this.btSensorBSearchRecursive);
            this.Controls.Add(this.btSensorBSearchIterative);
            this.Controls.Add(this.btSensorASortInsertion);
            this.Controls.Add(this.btSensorASortSelection);
            this.Controls.Add(this.btSensorASearchRecursive);
            this.Controls.Add(this.btSensorASearchIterative);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLoadSensorData);
            this.Controls.Add(this.listBoxSensorB);
            this.Controls.Add(this.listBoxSensorA);
            this.Controls.Add(this.listViewData);
            this.Name = "MalinSpaceScience";
            this.Text = "Malin Space Science";
            ((System.ComponentModel.ISupportInitialize)(this.Sigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewData;
        private System.Windows.Forms.ListBox listBoxSensorA;
        private System.Windows.Forms.ListBox listBoxSensorB;
        private System.Windows.Forms.Button buttonLoadSensorData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btSensorASearchIterative;
        private System.Windows.Forms.Button btSensorASearchRecursive;
        private System.Windows.Forms.Button btSensorASortSelection;
        private System.Windows.Forms.Button btSensorASortInsertion;
        private System.Windows.Forms.Button btSensorBSearchIterative;
        private System.Windows.Forms.Button btSensorBSearchRecursive;
        private System.Windows.Forms.Button btSensorBSortSelection;
        private System.Windows.Forms.Button btSensorBSortInsertion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txSensorASearchIterative;
        private System.Windows.Forms.TextBox txSensorBSearchIterative;
        private System.Windows.Forms.TextBox txSensorASearchRecursive;
        private System.Windows.Forms.TextBox txSensorBSearchRecursive;
        private System.Windows.Forms.TextBox txSensorASortSelection;
        private System.Windows.Forms.TextBox txSensorBSortSelection;
        private System.Windows.Forms.TextBox txSensorASortInsertion;
        private System.Windows.Forms.TextBox txSensorBSortInsertion;
        private System.Windows.Forms.Label Target;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txTargetSA;
        private System.Windows.Forms.TextBox txTargetSB;
        private System.Windows.Forms.NumericUpDown Sigma;
        private System.Windows.Forms.NumericUpDown Mu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ColumnHeader SensorA;
        private System.Windows.Forms.ColumnHeader SensorB;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

