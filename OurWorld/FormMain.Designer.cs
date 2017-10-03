namespace OurWorld
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRndSeed = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChangeChart = new System.Windows.Forms.Button();
            this.txtCountGrassAnimal = new System.Windows.Forms.TextBox();
            this.txtCountLowAnimal = new System.Windows.Forms.TextBox();
            this.txtCountHighAnimal = new System.Windows.Forms.TextBox();
            this.txtCountPeople = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCountGrass = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPlaceRemove = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtChangeY = new System.Windows.Forms.TextBox();
            this.txtChangeX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnChangePoint = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPlaceRand = new System.Windows.Forms.Button();
            this.btnPlaceKuang = new System.Windows.Forms.Button();
            this.btnPlaceSlice = new System.Windows.Forms.Button();
            this.btnPlaceRound = new System.Windows.Forms.Button();
            this.btnPlaceChunk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDisYmax = new System.Windows.Forms.TextBox();
            this.txtDisYmin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDisXmax = new System.Windows.Forms.TextBox();
            this.txtDisXmin = new System.Windows.Forms.TextBox();
            this.lbDisX = new System.Windows.Forms.Label();
            this.trbSpeed = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveState = new System.Windows.Forms.Button();
            this.btnStep = new System.Windows.Forms.Button();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgDir = new System.Windows.Forms.FolderBrowserDialog();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.listView1 = new OurWorld.ListViewNF();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartStop
            // 
            this.btnStartStop.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnStartStop.Location = new System.Drawing.Point(114, 267);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(70, 35);
            this.btnStartStop.TabIndex = 10;
            this.btnStartStop.Text = "开始";
            this.btnStartStop.UseVisualStyleBackColor = false;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.Location = new System.Drawing.Point(114, 226);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(70, 35);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRndSeed
            // 
            this.btnRndSeed.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRndSeed.Location = new System.Drawing.Point(16, 226);
            this.btnRndSeed.Name = "btnRndSeed";
            this.btnRndSeed.Size = new System.Drawing.Size(70, 35);
            this.btnRndSeed.TabIndex = 7;
            this.btnRndSeed.Text = "随机";
            this.btnRndSeed.UseVisualStyleBackColor = false;
            this.btnRndSeed.Click += new System.EventHandler(this.btnRndSeed_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChangeChart);
            this.groupBox1.Controls.Add(this.txtCountGrassAnimal);
            this.groupBox1.Controls.Add(this.txtCountLowAnimal);
            this.groupBox1.Controls.Add(this.txtCountHighAnimal);
            this.groupBox1.Controls.Add(this.txtCountPeople);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtCountGrass);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnPlaceRemove);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtChangeY);
            this.groupBox1.Controls.Add(this.txtChangeX);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnChangePoint);
            this.groupBox1.Controls.Add(this.btnChange);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnPlaceRand);
            this.groupBox1.Controls.Add(this.btnPlaceKuang);
            this.groupBox1.Controls.Add(this.btnPlaceSlice);
            this.groupBox1.Controls.Add(this.btnPlaceRound);
            this.groupBox1.Controls.Add(this.btnPlaceChunk);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDisYmax);
            this.groupBox1.Controls.Add(this.txtDisYmin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDisXmax);
            this.groupBox1.Controls.Add(this.txtDisXmin);
            this.groupBox1.Controls.Add(this.lbDisX);
            this.groupBox1.Controls.Add(this.trbSpeed);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSaveState);
            this.groupBox1.Controls.Add(this.btnRndSeed);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnStep);
            this.groupBox1.Controls.Add(this.btnStartStop);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(1100, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 701);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnChangeChart
            // 
            this.btnChangeChart.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChangeChart.Location = new System.Drawing.Point(15, 125);
            this.btnChangeChart.Name = "btnChangeChart";
            this.btnChangeChart.Size = new System.Drawing.Size(169, 35);
            this.btnChangeChart.TabIndex = 47;
            this.btnChangeChart.Text = "查看数量变化曲线";
            this.btnChangeChart.UseVisualStyleBackColor = false;
            this.btnChangeChart.Click += new System.EventHandler(this.btnChangeChart_Click);
            // 
            // txtCountGrassAnimal
            // 
            this.txtCountGrassAnimal.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCountGrassAnimal.Location = new System.Drawing.Point(134, 37);
            this.txtCountGrassAnimal.Multiline = true;
            this.txtCountGrassAnimal.Name = "txtCountGrassAnimal";
            this.txtCountGrassAnimal.ReadOnly = true;
            this.txtCountGrassAnimal.Size = new System.Drawing.Size(63, 21);
            this.txtCountGrassAnimal.TabIndex = 46;
            this.txtCountGrassAnimal.Text = "0";
            // 
            // txtCountLowAnimal
            // 
            this.txtCountLowAnimal.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCountLowAnimal.Location = new System.Drawing.Point(134, 56);
            this.txtCountLowAnimal.Multiline = true;
            this.txtCountLowAnimal.Name = "txtCountLowAnimal";
            this.txtCountLowAnimal.ReadOnly = true;
            this.txtCountLowAnimal.Size = new System.Drawing.Size(63, 21);
            this.txtCountLowAnimal.TabIndex = 45;
            this.txtCountLowAnimal.Text = "0";
            // 
            // txtCountHighAnimal
            // 
            this.txtCountHighAnimal.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCountHighAnimal.Location = new System.Drawing.Point(134, 77);
            this.txtCountHighAnimal.Multiline = true;
            this.txtCountHighAnimal.Name = "txtCountHighAnimal";
            this.txtCountHighAnimal.ReadOnly = true;
            this.txtCountHighAnimal.Size = new System.Drawing.Size(63, 21);
            this.txtCountHighAnimal.TabIndex = 44;
            this.txtCountHighAnimal.Text = "0";
            // 
            // txtCountPeople
            // 
            this.txtCountPeople.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCountPeople.Location = new System.Drawing.Point(134, 98);
            this.txtCountPeople.Multiline = true;
            this.txtCountPeople.Name = "txtCountPeople";
            this.txtCountPeople.ReadOnly = true;
            this.txtCountPeople.Size = new System.Drawing.Size(63, 21);
            this.txtCountPeople.TabIndex = 43;
            this.txtCountPeople.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 21);
            this.label13.TabIndex = 42;
            this.label13.Text = "人类：";
            // 
            // txtCountGrass
            // 
            this.txtCountGrass.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCountGrass.Location = new System.Drawing.Point(134, 16);
            this.txtCountGrass.Multiline = true;
            this.txtCountGrass.Name = "txtCountGrass";
            this.txtCountGrass.ReadOnly = true;
            this.txtCountGrass.Size = new System.Drawing.Size(63, 21);
            this.txtCountGrass.TabIndex = 37;
            this.txtCountGrass.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 21);
            this.label12.TabIndex = 36;
            this.label12.Text = "高级食肉动物：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 21);
            this.label11.TabIndex = 35;
            this.label11.Text = "低级食肉动物：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 21);
            this.label10.TabIndex = 34;
            this.label10.Text = "食草动物：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 21);
            this.label9.TabIndex = 33;
            this.label9.Text = "绿色植物：";
            // 
            // btnPlaceRemove
            // 
            this.btnPlaceRemove.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPlaceRemove.Location = new System.Drawing.Point(16, 568);
            this.btnPlaceRemove.Name = "btnPlaceRemove";
            this.btnPlaceRemove.Size = new System.Drawing.Size(169, 35);
            this.btnPlaceRemove.TabIndex = 32;
            this.btnPlaceRemove.Text = "清除地形";
            this.btnPlaceRemove.UseVisualStyleBackColor = false;
            this.btnPlaceRemove.Click += new System.EventHandler(this.btnPlaceRemove_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(104, 630);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 21);
            this.label8.TabIndex = 31;
            this.label8.Text = "Y:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 630);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 21);
            this.label7.TabIndex = 30;
            this.label7.Text = "X:";
            // 
            // txtChangeY
            // 
            this.txtChangeY.Location = new System.Drawing.Point(134, 627);
            this.txtChangeY.Name = "txtChangeY";
            this.txtChangeY.Size = new System.Drawing.Size(51, 29);
            this.txtChangeY.TabIndex = 29;
            this.txtChangeY.Text = "75";
            // 
            // txtChangeX
            // 
            this.txtChangeX.Location = new System.Drawing.Point(50, 627);
            this.txtChangeX.Name = "txtChangeX";
            this.txtChangeX.Size = new System.Drawing.Size(51, 29);
            this.txtChangeX.TabIndex = 28;
            this.txtChangeX.Text = "75";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 603);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 27;
            this.label6.Text = "产生突变：";
            // 
            // btnChangePoint
            // 
            this.btnChangePoint.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChangePoint.Location = new System.Drawing.Point(15, 662);
            this.btnChangePoint.Name = "btnChangePoint";
            this.btnChangePoint.Size = new System.Drawing.Size(86, 35);
            this.btnChangePoint.TabIndex = 26;
            this.btnChangePoint.Text = "定点突变";
            this.btnChangePoint.UseVisualStyleBackColor = false;
            this.btnChangePoint.Click += new System.EventHandler(this.btnChangePoint_Click);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChange.Location = new System.Drawing.Point(99, 662);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(86, 35);
            this.btnChange.TabIndex = 3;
            this.btnChange.Text = "随机突变";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "自然灾害：";
            // 
            // btnPlaceRand
            // 
            this.btnPlaceRand.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPlaceRand.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPlaceRand.Location = new System.Drawing.Point(99, 442);
            this.btnPlaceRand.Name = "btnPlaceRand";
            this.btnPlaceRand.Size = new System.Drawing.Size(86, 35);
            this.btnPlaceRand.TabIndex = 24;
            this.btnPlaceRand.Text = "随机";
            this.btnPlaceRand.UseVisualStyleBackColor = false;
            this.btnPlaceRand.Click += new System.EventHandler(this.btnPlaceRand_Click);
            // 
            // btnPlaceKuang
            // 
            this.btnPlaceKuang.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPlaceKuang.Location = new System.Drawing.Point(99, 527);
            this.btnPlaceKuang.Name = "btnPlaceKuang";
            this.btnPlaceKuang.Size = new System.Drawing.Size(86, 35);
            this.btnPlaceKuang.TabIndex = 23;
            this.btnPlaceKuang.Text = "框状地形";
            this.btnPlaceKuang.UseVisualStyleBackColor = false;
            this.btnPlaceKuang.Click += new System.EventHandler(this.btnPlaceKuang_Click);
            // 
            // btnPlaceSlice
            // 
            this.btnPlaceSlice.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPlaceSlice.Location = new System.Drawing.Point(16, 527);
            this.btnPlaceSlice.Name = "btnPlaceSlice";
            this.btnPlaceSlice.Size = new System.Drawing.Size(86, 35);
            this.btnPlaceSlice.TabIndex = 22;
            this.btnPlaceSlice.Text = "条带地形";
            this.btnPlaceSlice.UseVisualStyleBackColor = false;
            this.btnPlaceSlice.Click += new System.EventHandler(this.btnPlaceSlice_Click);
            // 
            // btnPlaceRound
            // 
            this.btnPlaceRound.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPlaceRound.Location = new System.Drawing.Point(99, 486);
            this.btnPlaceRound.Name = "btnPlaceRound";
            this.btnPlaceRound.Size = new System.Drawing.Size(86, 35);
            this.btnPlaceRound.TabIndex = 21;
            this.btnPlaceRound.Text = "环状地形";
            this.btnPlaceRound.UseVisualStyleBackColor = false;
            this.btnPlaceRound.Click += new System.EventHandler(this.btnPlaceRound_Click);
            // 
            // btnPlaceChunk
            // 
            this.btnPlaceChunk.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPlaceChunk.Location = new System.Drawing.Point(16, 486);
            this.btnPlaceChunk.Name = "btnPlaceChunk";
            this.btnPlaceChunk.Size = new System.Drawing.Size(86, 35);
            this.btnPlaceChunk.TabIndex = 3;
            this.btnPlaceChunk.Text = "方块地形";
            this.btnPlaceChunk.UseVisualStyleBackColor = false;
            this.btnPlaceChunk.Click += new System.EventHandler(this.btnPlaceChunk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "~";
            // 
            // txtDisYmax
            // 
            this.txtDisYmax.Location = new System.Drawing.Point(133, 407);
            this.txtDisYmax.Name = "txtDisYmax";
            this.txtDisYmax.Size = new System.Drawing.Size(51, 29);
            this.txtDisYmax.TabIndex = 19;
            this.txtDisYmax.Text = "150";
            // 
            // txtDisYmin
            // 
            this.txtDisYmin.Location = new System.Drawing.Point(16, 407);
            this.txtDisYmin.Name = "txtDisYmin";
            this.txtDisYmin.Size = new System.Drawing.Size(51, 29);
            this.txtDisYmin.TabIndex = 18;
            this.txtDisYmin.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "横坐标(1~150)：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "~";
            // 
            // txtDisXmax
            // 
            this.txtDisXmax.Location = new System.Drawing.Point(133, 351);
            this.txtDisXmax.Name = "txtDisXmax";
            this.txtDisXmax.Size = new System.Drawing.Size(51, 29);
            this.txtDisXmax.TabIndex = 15;
            this.txtDisXmax.Text = "150";
            // 
            // txtDisXmin
            // 
            this.txtDisXmin.Location = new System.Drawing.Point(16, 351);
            this.txtDisXmin.Name = "txtDisXmin";
            this.txtDisXmin.Size = new System.Drawing.Size(51, 29);
            this.txtDisXmin.TabIndex = 14;
            this.txtDisXmin.Text = "1";
            // 
            // lbDisX
            // 
            this.lbDisX.AutoSize = true;
            this.lbDisX.Location = new System.Drawing.Point(12, 327);
            this.lbDisX.Name = "lbDisX";
            this.lbDisX.Size = new System.Drawing.Size(132, 21);
            this.lbDisX.TabIndex = 13;
            this.lbDisX.Text = "横坐标(1~150)：";
            // 
            // trbSpeed
            // 
            this.trbSpeed.AutoSize = false;
            this.trbSpeed.LargeChange = 1;
            this.trbSpeed.Location = new System.Drawing.Point(15, 180);
            this.trbSpeed.Maximum = 5;
            this.trbSpeed.Minimum = 1;
            this.trbSpeed.Name = "trbSpeed";
            this.trbSpeed.Size = new System.Drawing.Size(169, 33);
            this.trbSpeed.TabIndex = 6;
            this.trbSpeed.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trbSpeed.Value = 3;
            this.trbSpeed.Scroll += new System.EventHandler(this.trbSpeed_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "运行速度：";
            // 
            // btnSaveState
            // 
            this.btnSaveState.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSaveState.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSaveState.Location = new System.Drawing.Point(15, 442);
            this.btnSaveState.Name = "btnSaveState";
            this.btnSaveState.Size = new System.Drawing.Size(86, 35);
            this.btnSaveState.TabIndex = 11;
            this.btnSaveState.Text = "定向";
            this.btnSaveState.UseVisualStyleBackColor = false;
            this.btnSaveState.Click += new System.EventHandler(this.btnSaveState_Click);
            // 
            // btnStep
            // 
            this.btnStep.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStep.Location = new System.Drawing.Point(16, 267);
            this.btnStep.Name = "btnStep";
            this.btnStep.Size = new System.Drawing.Size(70, 35);
            this.btnStep.TabIndex = 9;
            this.btnStep.Text = "单步";
            this.btnStep.UseVisualStyleBackColor = false;
            this.btnStep.Click += new System.EventHandler(this.btnStep_Click);
            // 
            // tmrTime
            // 
            this.tmrTime.Interval = 500;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // dlgOpen
            // 
            this.dlgOpen.DereferenceLinks = false;
            this.dlgOpen.Filter = "状态文件|*.cfs";
            // 
            // dlgDir
            // 
            this.dlgDir.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.dlgDir.SelectedPath = "D:\\";
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.White;
            this.picCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCanvas.Dock = System.Windows.Forms.DockStyle.Left;
            this.picCanvas.Location = new System.Drawing.Point(0, 0);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(702, 701);
            this.picCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCanvas.TabIndex = 4;
            this.picCanvas.TabStop = false;
            this.picCanvas.Click += new System.EventHandler(this.picCanvas_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(723, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(344, 705);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 701);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OurWorld";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRndSeed;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trbSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Button btnStep;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.FolderBrowserDialog dlgDir;
        private System.Windows.Forms.PictureBox picCanvas;
        public ListViewNF listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDisXmax;
        private System.Windows.Forms.TextBox txtDisXmin;
        private System.Windows.Forms.Label lbDisX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDisYmax;
        private System.Windows.Forms.TextBox txtDisYmin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPlaceSlice;
        private System.Windows.Forms.Button btnPlaceRound;
        private System.Windows.Forms.Button btnPlaceChunk;
        private System.Windows.Forms.Button btnPlaceKuang;
        private System.Windows.Forms.Button btnSaveState;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPlaceRand;
        private System.Windows.Forms.Button btnChangePoint;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtChangeY;
        private System.Windows.Forms.TextBox txtChangeX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPlaceRemove;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCountGrass;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCountGrassAnimal;
        private System.Windows.Forms.TextBox txtCountLowAnimal;
        private System.Windows.Forms.TextBox txtCountHighAnimal;
        private System.Windows.Forms.TextBox txtCountPeople;
        private System.Windows.Forms.Button btnChangeChart;
    }
}

