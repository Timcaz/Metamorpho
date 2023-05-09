namespace Metamorpho
{
    partial class MainForm
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
            this.button_openFiles = new System.Windows.Forms.Button();
            this.listBox_files = new System.Windows.Forms.ListBox();
            this.button_removeSelected = new System.Windows.Forms.Button();
            this.textBox_arguments = new System.Windows.Forms.TextBox();
            this.comboBox_format = new System.Windows.Forms.ComboBox();
            this.label_convert = new System.Windows.Forms.Label();
            this.button_convert = new System.Windows.Forms.Button();
            this.label_jobs = new System.Windows.Forms.Label();
            this.numeric_jobs = new System.Windows.Forms.NumericUpDown();
            this.progressBar_job = new System.Windows.Forms.ProgressBar();
            this.stopButton = new System.Windows.Forms.Button();
            this.label_speed = new System.Windows.Forms.Label();
            this.label_arguments = new System.Windows.Forms.Label();
            this.comboBox_speed = new System.Windows.Forms.ComboBox();
            this.label_lossless = new System.Windows.Forms.Label();
            this.label_cores = new System.Windows.Forms.Label();
            this.label_depth = new System.Windows.Forms.Label();
            this.label_yuv = new System.Windows.Forms.Label();
            this.label_range = new System.Windows.Forms.Label();
            this.label_codec = new System.Windows.Forms.Label();
            this.label_qualityColor = new System.Windows.Forms.Label();
            this.label_qualityAlpha = new System.Windows.Forms.Label();
            this.checkBox_lossless = new System.Windows.Forms.CheckBox();
            this.textBox_cores = new System.Windows.Forms.TextBox();
            this.comboBox_depth = new System.Windows.Forms.ComboBox();
            this.comboBox_yuv = new System.Windows.Forms.ComboBox();
            this.comboBox_codec = new System.Windows.Forms.ComboBox();
            this.numericUpDown_qc = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_qa = new System.Windows.Forms.NumericUpDown();
            this.comboBox_rangeYuv = new System.Windows.Forms.ComboBox();
            this.label_progressive = new System.Windows.Forms.Label();
            this.label_effort = new System.Windows.Forms.Label();
            this.label_distance = new System.Windows.Forms.Label();
            this.label_distanceAlpha = new System.Windows.Forms.Label();
            this.label_brotliEffort = new System.Windows.Forms.Label();
            this.comboBox_effort = new System.Windows.Forms.ComboBox();
            this.comboBox_brotliEffort = new System.Windows.Forms.ComboBox();
            this.checkBox_progressive = new System.Windows.Forms.CheckBox();
            this.comboBox_distance = new System.Windows.Forms.ComboBox();
            this.comboBox_distanceAlpha = new System.Windows.Forms.ComboBox();
            this.label_losslessJpeg = new System.Windows.Forms.Label();
            this.checkBox_losslessJpg = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_jobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_qc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_qa)).BeginInit();
            this.SuspendLayout();
            // 
            // button_openFiles
            // 
            this.button_openFiles.Location = new System.Drawing.Point(262, 5);
            this.button_openFiles.Name = "button_openFiles";
            this.button_openFiles.Size = new System.Drawing.Size(75, 23);
            this.button_openFiles.TabIndex = 0;
            this.button_openFiles.Text = "Open";
            this.button_openFiles.UseVisualStyleBackColor = true;
            this.button_openFiles.Click += new System.EventHandler(this.button_openFiles_Click);
            // 
            // listBox_files
            // 
            this.listBox_files.AllowDrop = true;
            this.listBox_files.FormattingEnabled = true;
            this.listBox_files.Location = new System.Drawing.Point(12, 5);
            this.listBox_files.Name = "listBox_files";
            this.listBox_files.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox_files.Size = new System.Drawing.Size(240, 342);
            this.listBox_files.TabIndex = 1;
            // 
            // button_removeSelected
            // 
            this.button_removeSelected.Location = new System.Drawing.Point(262, 35);
            this.button_removeSelected.Name = "button_removeSelected";
            this.button_removeSelected.Size = new System.Drawing.Size(75, 23);
            this.button_removeSelected.TabIndex = 2;
            this.button_removeSelected.Text = "Remove";
            this.button_removeSelected.UseVisualStyleBackColor = true;
            this.button_removeSelected.Click += new System.EventHandler(this.button_removeSelected_Click);
            // 
            // textBox_arguments
            // 
            this.textBox_arguments.Location = new System.Drawing.Point(261, 305);
            this.textBox_arguments.Name = "textBox_arguments";
            this.textBox_arguments.Size = new System.Drawing.Size(331, 20);
            this.textBox_arguments.TabIndex = 3;
            // 
            // comboBox_format
            // 
            this.comboBox_format.FormattingEnabled = true;
            this.comboBox_format.Items.AddRange(new object[] {
            "AVIF",
            "JPEG XL"});
            this.comboBox_format.Location = new System.Drawing.Point(369, 21);
            this.comboBox_format.Name = "comboBox_format";
            this.comboBox_format.Size = new System.Drawing.Size(121, 21);
            this.comboBox_format.TabIndex = 4;
            this.comboBox_format.SelectedIndexChanged += new System.EventHandler(this.comboBox_format_SelectedIndexChanged);
            // 
            // label_convert
            // 
            this.label_convert.AutoSize = true;
            this.label_convert.Location = new System.Drawing.Point(366, 5);
            this.label_convert.Name = "label_convert";
            this.label_convert.Size = new System.Drawing.Size(56, 13);
            this.label_convert.TabIndex = 5;
            this.label_convert.Text = "Convert to";
            // 
            // button_convert
            // 
            this.button_convert.Location = new System.Drawing.Point(517, 5);
            this.button_convert.Name = "button_convert";
            this.button_convert.Size = new System.Drawing.Size(75, 23);
            this.button_convert.TabIndex = 6;
            this.button_convert.Text = "Convert";
            this.button_convert.UseVisualStyleBackColor = true;
            this.button_convert.Click += new System.EventHandler(this.button_convert_Click);
            // 
            // label_jobs
            // 
            this.label_jobs.AutoSize = true;
            this.label_jobs.Location = new System.Drawing.Point(491, 284);
            this.label_jobs.Name = "label_jobs";
            this.label_jobs.Size = new System.Drawing.Size(63, 13);
            this.label_jobs.TabIndex = 7;
            this.label_jobs.Text = "Parallel jobs";
            // 
            // numeric_jobs
            // 
            this.numeric_jobs.Location = new System.Drawing.Point(560, 282);
            this.numeric_jobs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_jobs.Name = "numeric_jobs";
            this.numeric_jobs.Size = new System.Drawing.Size(32, 20);
            this.numeric_jobs.TabIndex = 8;
            this.numeric_jobs.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // progressBar_job
            // 
            this.progressBar_job.Location = new System.Drawing.Point(262, 331);
            this.progressBar_job.Name = "progressBar_job";
            this.progressBar_job.Size = new System.Drawing.Size(330, 18);
            this.progressBar_job.TabIndex = 9;
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(517, 35);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 10;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // label_speed
            // 
            this.label_speed.AutoSize = true;
            this.label_speed.Location = new System.Drawing.Point(355, 73);
            this.label_speed.Name = "label_speed";
            this.label_speed.Size = new System.Drawing.Size(38, 13);
            this.label_speed.TabIndex = 12;
            this.label_speed.Text = "Speed";
            // 
            // label_arguments
            // 
            this.label_arguments.AutoSize = true;
            this.label_arguments.Location = new System.Drawing.Point(259, 289);
            this.label_arguments.Name = "label_arguments";
            this.label_arguments.Size = new System.Drawing.Size(57, 13);
            this.label_arguments.TabIndex = 13;
            this.label_arguments.Text = "Arguments";
            // 
            // comboBox_speed
            // 
            this.comboBox_speed.FormattingEnabled = true;
            this.comboBox_speed.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox_speed.Location = new System.Drawing.Point(356, 93);
            this.comboBox_speed.Name = "comboBox_speed";
            this.comboBox_speed.Size = new System.Drawing.Size(35, 21);
            this.comboBox_speed.TabIndex = 14;
            this.comboBox_speed.SelectedIndexChanged += new System.EventHandler(this.comboBox_speed_SelectedIndexChanged);
            // 
            // label_lossless
            // 
            this.label_lossless.AutoSize = true;
            this.label_lossless.Location = new System.Drawing.Point(436, 136);
            this.label_lossless.Name = "label_lossless";
            this.label_lossless.Size = new System.Drawing.Size(47, 13);
            this.label_lossless.TabIndex = 15;
            this.label_lossless.Text = "Lossless";
            // 
            // label_cores
            // 
            this.label_cores.AutoSize = true;
            this.label_cores.Location = new System.Drawing.Point(419, 73);
            this.label_cores.Name = "label_cores";
            this.label_cores.Size = new System.Drawing.Size(34, 13);
            this.label_cores.TabIndex = 16;
            this.label_cores.Text = "Cores";
            // 
            // label_depth
            // 
            this.label_depth.AutoSize = true;
            this.label_depth.Location = new System.Drawing.Point(472, 72);
            this.label_depth.Name = "label_depth";
            this.label_depth.Size = new System.Drawing.Size(36, 13);
            this.label_depth.TabIndex = 17;
            this.label_depth.Text = "Depth";
            // 
            // label_yuv
            // 
            this.label_yuv.AutoSize = true;
            this.label_yuv.Location = new System.Drawing.Point(544, 73);
            this.label_yuv.Name = "label_yuv";
            this.label_yuv.Size = new System.Drawing.Size(29, 13);
            this.label_yuv.TabIndex = 18;
            this.label_yuv.Text = "YUV";
            // 
            // label_range
            // 
            this.label_range.AutoSize = true;
            this.label_range.Location = new System.Drawing.Point(514, 136);
            this.label_range.Name = "label_range";
            this.label_range.Size = new System.Drawing.Size(64, 13);
            this.label_range.TabIndex = 20;
            this.label_range.Text = "Range YUV";
            // 
            // label_codec
            // 
            this.label_codec.AutoSize = true;
            this.label_codec.Location = new System.Drawing.Point(355, 136);
            this.label_codec.Name = "label_codec";
            this.label_codec.Size = new System.Drawing.Size(38, 13);
            this.label_codec.TabIndex = 21;
            this.label_codec.Text = "Codec";
            // 
            // label_qualityColor
            // 
            this.label_qualityColor.AutoSize = true;
            this.label_qualityColor.Location = new System.Drawing.Point(268, 73);
            this.label_qualityColor.Name = "label_qualityColor";
            this.label_qualityColor.Size = new System.Drawing.Size(65, 13);
            this.label_qualityColor.TabIndex = 22;
            this.label_qualityColor.Text = "Quality color";
            // 
            // label_qualityAlpha
            // 
            this.label_qualityAlpha.AutoSize = true;
            this.label_qualityAlpha.Location = new System.Drawing.Point(268, 136);
            this.label_qualityAlpha.Name = "label_qualityAlpha";
            this.label_qualityAlpha.Size = new System.Drawing.Size(68, 13);
            this.label_qualityAlpha.TabIndex = 23;
            this.label_qualityAlpha.Text = "Quality alpha";
            // 
            // checkBox_lossless
            // 
            this.checkBox_lossless.AutoSize = true;
            this.checkBox_lossless.Location = new System.Drawing.Point(453, 156);
            this.checkBox_lossless.Name = "checkBox_lossless";
            this.checkBox_lossless.Size = new System.Drawing.Size(15, 14);
            this.checkBox_lossless.TabIndex = 24;
            this.checkBox_lossless.UseVisualStyleBackColor = true;
            this.checkBox_lossless.CheckedChanged += new System.EventHandler(this.checkBox_lossless_CheckedChanged);
            // 
            // textBox_cores
            // 
            this.textBox_cores.Location = new System.Drawing.Point(415, 93);
            this.textBox_cores.Name = "textBox_cores";
            this.textBox_cores.Size = new System.Drawing.Size(42, 20);
            this.textBox_cores.TabIndex = 25;
            this.textBox_cores.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDownHandlerEnter);
            // 
            // comboBox_depth
            // 
            this.comboBox_depth.FormattingEnabled = true;
            this.comboBox_depth.Items.AddRange(new object[] {
            "8",
            "10",
            "12"});
            this.comboBox_depth.Location = new System.Drawing.Point(475, 93);
            this.comboBox_depth.Name = "comboBox_depth";
            this.comboBox_depth.Size = new System.Drawing.Size(33, 21);
            this.comboBox_depth.TabIndex = 26;
            this.comboBox_depth.SelectedIndexChanged += new System.EventHandler(this.comboBox_depth_SelectedIndexChanged);
            // 
            // comboBox_yuv
            // 
            this.comboBox_yuv.FormattingEnabled = true;
            this.comboBox_yuv.Items.AddRange(new object[] {
            "400",
            "420",
            "422",
            "444"});
            this.comboBox_yuv.Location = new System.Drawing.Point(531, 93);
            this.comboBox_yuv.Name = "comboBox_yuv";
            this.comboBox_yuv.Size = new System.Drawing.Size(61, 21);
            this.comboBox_yuv.TabIndex = 27;
            this.comboBox_yuv.SelectedIndexChanged += new System.EventHandler(this.comboBox_yuv_SelectedIndexChanged);
            // 
            // comboBox_codec
            // 
            this.comboBox_codec.FormattingEnabled = true;
            this.comboBox_codec.Items.AddRange(new object[] {
            "aom",
            "rav1e"});
            this.comboBox_codec.Location = new System.Drawing.Point(339, 153);
            this.comboBox_codec.Name = "comboBox_codec";
            this.comboBox_codec.Size = new System.Drawing.Size(78, 21);
            this.comboBox_codec.TabIndex = 28;
            this.comboBox_codec.SelectedIndexChanged += new System.EventHandler(this.comboBox_codec_SelectedIndexChanged_1);
            // 
            // numericUpDown_qc
            // 
            this.numericUpDown_qc.Location = new System.Drawing.Point(281, 95);
            this.numericUpDown_qc.Name = "numericUpDown_qc";
            this.numericUpDown_qc.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown_qc.TabIndex = 29;
            this.numericUpDown_qc.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_qc.ValueChanged += new System.EventHandler(this.numericUpDown_qc_ValueChanged);
            // 
            // numericUpDown_qa
            // 
            this.numericUpDown_qa.Location = new System.Drawing.Point(278, 153);
            this.numericUpDown_qa.Name = "numericUpDown_qa";
            this.numericUpDown_qa.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown_qa.TabIndex = 30;
            this.numericUpDown_qa.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_qa.ValueChanged += new System.EventHandler(this.numericUpDown_qa_ValueChanged);
            // 
            // comboBox_rangeYuv
            // 
            this.comboBox_rangeYuv.FormattingEnabled = true;
            this.comboBox_rangeYuv.Items.AddRange(new object[] {
            "limited",
            "full"});
            this.comboBox_rangeYuv.Location = new System.Drawing.Point(502, 153);
            this.comboBox_rangeYuv.Name = "comboBox_rangeYuv";
            this.comboBox_rangeYuv.Size = new System.Drawing.Size(90, 21);
            this.comboBox_rangeYuv.TabIndex = 31;
            this.comboBox_rangeYuv.SelectedIndexChanged += new System.EventHandler(this.comboBox_rangeYuv_SelectedIndexChanged);
            // 
            // label_progressive
            // 
            this.label_progressive.AutoSize = true;
            this.label_progressive.Location = new System.Drawing.Point(516, 194);
            this.label_progressive.Name = "label_progressive";
            this.label_progressive.Size = new System.Drawing.Size(62, 13);
            this.label_progressive.TabIndex = 32;
            this.label_progressive.Text = "Progressive";
            // 
            // label_effort
            // 
            this.label_effort.AutoSize = true;
            this.label_effort.Location = new System.Drawing.Point(355, 194);
            this.label_effort.Name = "label_effort";
            this.label_effort.Size = new System.Drawing.Size(32, 13);
            this.label_effort.TabIndex = 33;
            this.label_effort.Text = "Effort";
            // 
            // label_distance
            // 
            this.label_distance.AutoSize = true;
            this.label_distance.Location = new System.Drawing.Point(278, 194);
            this.label_distance.Name = "label_distance";
            this.label_distance.Size = new System.Drawing.Size(49, 13);
            this.label_distance.TabIndex = 34;
            this.label_distance.Text = "Distance";
            // 
            // label_distanceAlpha
            // 
            this.label_distanceAlpha.AutoSize = true;
            this.label_distanceAlpha.Location = new System.Drawing.Point(262, 236);
            this.label_distanceAlpha.Name = "label_distanceAlpha";
            this.label_distanceAlpha.Size = new System.Drawing.Size(78, 13);
            this.label_distanceAlpha.TabIndex = 35;
            this.label_distanceAlpha.Text = "Distance alpha";
            // 
            // label_brotliEffort
            // 
            this.label_brotliEffort.AutoSize = true;
            this.label_brotliEffort.Location = new System.Drawing.Point(433, 194);
            this.label_brotliEffort.Name = "label_brotliEffort";
            this.label_brotliEffort.Size = new System.Drawing.Size(57, 13);
            this.label_brotliEffort.TabIndex = 36;
            this.label_brotliEffort.Text = "Brotli effort";
            // 
            // comboBox_effort
            // 
            this.comboBox_effort.FormattingEnabled = true;
            this.comboBox_effort.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBox_effort.Location = new System.Drawing.Point(345, 210);
            this.comboBox_effort.Name = "comboBox_effort";
            this.comboBox_effort.Size = new System.Drawing.Size(54, 21);
            this.comboBox_effort.TabIndex = 39;
            this.comboBox_effort.SelectedIndexChanged += new System.EventHandler(this.comboBox_effort_SelectedIndexChanged);
            // 
            // comboBox_brotliEffort
            // 
            this.comboBox_brotliEffort.FormattingEnabled = true;
            this.comboBox_brotliEffort.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.comboBox_brotliEffort.Location = new System.Drawing.Point(439, 210);
            this.comboBox_brotliEffort.Name = "comboBox_brotliEffort";
            this.comboBox_brotliEffort.Size = new System.Drawing.Size(39, 21);
            this.comboBox_brotliEffort.TabIndex = 40;
            this.comboBox_brotliEffort.SelectedIndexChanged += new System.EventHandler(this.comboBox_brotliEffort_SelectedIndexChanged);
            // 
            // checkBox_progressive
            // 
            this.checkBox_progressive.AutoSize = true;
            this.checkBox_progressive.Location = new System.Drawing.Point(539, 216);
            this.checkBox_progressive.Name = "checkBox_progressive";
            this.checkBox_progressive.Size = new System.Drawing.Size(15, 14);
            this.checkBox_progressive.TabIndex = 41;
            this.checkBox_progressive.UseVisualStyleBackColor = true;
            this.checkBox_progressive.CheckedChanged += new System.EventHandler(this.checkBox_progressive_CheckedChanged);
            // 
            // comboBox_distance
            // 
            this.comboBox_distance.Enabled = false;
            this.comboBox_distance.FormattingEnabled = true;
            this.comboBox_distance.Items.AddRange(new object[] {
            "0.0",
            "0.5",
            "1.0",
            "1.5",
            "2.0",
            "2.5",
            "3.0"});
            this.comboBox_distance.Location = new System.Drawing.Point(274, 210);
            this.comboBox_distance.Name = "comboBox_distance";
            this.comboBox_distance.Size = new System.Drawing.Size(59, 21);
            this.comboBox_distance.TabIndex = 42;
            this.comboBox_distance.SelectedIndexChanged += new System.EventHandler(this.comboBox_distance_SelectedIndexChanged);
            // 
            // comboBox_distanceAlpha
            // 
            this.comboBox_distanceAlpha.Enabled = false;
            this.comboBox_distanceAlpha.FormattingEnabled = true;
            this.comboBox_distanceAlpha.Items.AddRange(new object[] {
            "0.0",
            "0.5",
            "1.0",
            "1.5",
            "2.0",
            "2.5",
            "3.0"});
            this.comboBox_distanceAlpha.Location = new System.Drawing.Point(274, 256);
            this.comboBox_distanceAlpha.Name = "comboBox_distanceAlpha";
            this.comboBox_distanceAlpha.Size = new System.Drawing.Size(59, 21);
            this.comboBox_distanceAlpha.TabIndex = 43;
            this.comboBox_distanceAlpha.SelectedIndexChanged += new System.EventHandler(this.comboBox_distanceAlpha_SelectedIndexChanged);
            // 
            // label_losslessJpeg
            // 
            this.label_losslessJpeg.AutoSize = true;
            this.label_losslessJpeg.Location = new System.Drawing.Point(507, 236);
            this.label_losslessJpeg.Name = "label_losslessJpeg";
            this.label_losslessJpeg.Size = new System.Drawing.Size(70, 13);
            this.label_losslessJpeg.TabIndex = 44;
            this.label_losslessJpeg.Text = "Lossless jpeg";
            // 
            // checkBox_losslessJpg
            // 
            this.checkBox_losslessJpg.AutoSize = true;
            this.checkBox_losslessJpg.Checked = true;
            this.checkBox_losslessJpg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_losslessJpg.Location = new System.Drawing.Point(539, 256);
            this.checkBox_losslessJpg.Name = "checkBox_losslessJpg";
            this.checkBox_losslessJpg.Size = new System.Drawing.Size(15, 14);
            this.checkBox_losslessJpg.TabIndex = 45;
            this.checkBox_losslessJpg.UseVisualStyleBackColor = true;
            this.checkBox_losslessJpg.CheckedChanged += new System.EventHandler(this.checkBox_losslessJpg_CheckedChanged);
            // 
            // MainForm
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 355);
            this.Controls.Add(this.checkBox_losslessJpg);
            this.Controls.Add(this.label_losslessJpeg);
            this.Controls.Add(this.comboBox_distanceAlpha);
            this.Controls.Add(this.comboBox_distance);
            this.Controls.Add(this.checkBox_progressive);
            this.Controls.Add(this.comboBox_brotliEffort);
            this.Controls.Add(this.comboBox_effort);
            this.Controls.Add(this.label_brotliEffort);
            this.Controls.Add(this.label_distanceAlpha);
            this.Controls.Add(this.label_distance);
            this.Controls.Add(this.label_effort);
            this.Controls.Add(this.label_progressive);
            this.Controls.Add(this.comboBox_rangeYuv);
            this.Controls.Add(this.numericUpDown_qa);
            this.Controls.Add(this.numericUpDown_qc);
            this.Controls.Add(this.comboBox_codec);
            this.Controls.Add(this.comboBox_yuv);
            this.Controls.Add(this.comboBox_depth);
            this.Controls.Add(this.textBox_cores);
            this.Controls.Add(this.checkBox_lossless);
            this.Controls.Add(this.label_qualityAlpha);
            this.Controls.Add(this.label_qualityColor);
            this.Controls.Add(this.label_codec);
            this.Controls.Add(this.label_range);
            this.Controls.Add(this.label_yuv);
            this.Controls.Add(this.label_depth);
            this.Controls.Add(this.label_cores);
            this.Controls.Add(this.label_lossless);
            this.Controls.Add(this.comboBox_speed);
            this.Controls.Add(this.label_arguments);
            this.Controls.Add(this.label_speed);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.progressBar_job);
            this.Controls.Add(this.numeric_jobs);
            this.Controls.Add(this.label_jobs);
            this.Controls.Add(this.button_convert);
            this.Controls.Add(this.label_convert);
            this.Controls.Add(this.comboBox_format);
            this.Controls.Add(this.textBox_arguments);
            this.Controls.Add(this.button_removeSelected);
            this.Controls.Add(this.listBox_files);
            this.Controls.Add(this.button_openFiles);
            this.Name = "MainForm";
            this.Text = "Metamorpho";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_jobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_qc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_qa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_openFiles;
        private System.Windows.Forms.ListBox listBox_files;
        private System.Windows.Forms.Button button_removeSelected;
        private System.Windows.Forms.TextBox textBox_arguments;
        private System.Windows.Forms.ComboBox comboBox_format;
        private System.Windows.Forms.Label label_convert;
        private System.Windows.Forms.Button button_convert;
        private System.Windows.Forms.Label label_jobs;
        private System.Windows.Forms.NumericUpDown numeric_jobs;
        public System.Windows.Forms.ProgressBar progressBar_job;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label label_speed;
        private System.Windows.Forms.Label label_arguments;
        private System.Windows.Forms.ComboBox comboBox_speed;
        private System.Windows.Forms.Label label_lossless;
        private System.Windows.Forms.Label label_cores;
        private System.Windows.Forms.Label label_depth;
        private System.Windows.Forms.Label label_yuv;
        private System.Windows.Forms.Label label_range;
        private System.Windows.Forms.Label label_codec;
        private System.Windows.Forms.Label label_qualityColor;
        private System.Windows.Forms.Label label_qualityAlpha;
        private System.Windows.Forms.CheckBox checkBox_lossless;
        private System.Windows.Forms.TextBox textBox_cores;
        private System.Windows.Forms.ComboBox comboBox_depth;
        private System.Windows.Forms.ComboBox comboBox_yuv;
        private System.Windows.Forms.ComboBox comboBox_codec;
        private System.Windows.Forms.NumericUpDown numericUpDown_qc;
        private System.Windows.Forms.NumericUpDown numericUpDown_qa;
        private System.Windows.Forms.ComboBox comboBox_rangeYuv;
        private System.Windows.Forms.Label label_progressive;
        private System.Windows.Forms.Label label_effort;
        private System.Windows.Forms.Label label_distance;
        private System.Windows.Forms.Label label_distanceAlpha;
        private System.Windows.Forms.Label label_brotliEffort;
        private System.Windows.Forms.ComboBox comboBox_effort;
        private System.Windows.Forms.ComboBox comboBox_brotliEffort;
        private System.Windows.Forms.CheckBox checkBox_progressive;
        private System.Windows.Forms.ComboBox comboBox_distance;
        private System.Windows.Forms.ComboBox comboBox_distanceAlpha;
        private System.Windows.Forms.Label label_losslessJpeg;
        private System.Windows.Forms.CheckBox checkBox_losslessJpg;
    }
}

