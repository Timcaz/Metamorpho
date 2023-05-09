using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using System.Threading;
using System.Text.RegularExpressions;
using System.Security.Cryptography;


namespace Metamorpho
{
    public partial class MainForm : Form
    {
        CmdExecutor cmdExecutor;
        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            cmdExecutor = new CmdExecutor();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button_openFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            listBox_files.Items.Clear();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                listBox_files.Items.AddRange(openFileDialog.FileNames);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_removeSelected_Click(object sender, EventArgs e)
        {
            do
            {
                listBox_files.Items.Remove(listBox_files.SelectedItem);
            } while (listBox_files.SelectedIndex >= 0);
        }

        private void comboBox_codec_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private async void button_convert_Click(object sender, EventArgs e)
        {
            if (listBox_files.Items.Count > 0)
            {
                List<string> commands = new List<string>();
                if (comboBox_format.Text == "AVIF")
                {
                    foreach (var item in listBox_files.Items)
                    {
                        commands.Add(textBox_arguments.Text + " " + item + " " + item.ToString().Remove(item.ToString().Length - 4) + ".avif");
                    }
                } else if (comboBox_format.Text == "JPEG XL")
                {
                    foreach (var item in listBox_files.Items)
                    {
                        commands.Add(textBox_arguments.Text + " " + item + " " + item.ToString().Remove(item.ToString().Length - 4) + ".jxl");
                    }
                }
                progressBar_job.Value = 0;
                progressBar_job.Maximum = commands.Count;
                cmdExecutor.ProgressChanged += CmdExecutor_ProgressChanged;
                await cmdExecutor.ExecuteCommands(commands,Convert.ToInt32(numeric_jobs.Value));
            }
        }
        private void CmdExecutor_ProgressChanged(object sender, int progress)
        {
            progressBar_job.Invoke(new Action(() => { SetProgress(progress); }));
        }
        private void SetProgress(int value)
        {
            progressBar_job.Value = value;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            cmdExecutor.RequestStop();
        }

        private void comboBox_speed_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (textBox_arguments.Text.Contains("-s"))
                {
                    string arg = textBox_arguments.Text;
                    string pattern = @"-s\s+(\d+)";
                    arg = textBox_arguments.Text;
                    arg = Regex.Replace(arg, pattern, $"-s {comboBox_speed.SelectedItem}");
                    textBox_arguments.Text = arg;
                }
                else
                {
                    textBox_arguments.Text += " -s " + comboBox_speed.SelectedItem;
                }
        }

        private void comboBox_format_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_format.Text == "AVIF")
            {
                textBox_arguments.Text = "avifenc";
                label_speed.Enabled = true;
                label_codec.Enabled = true;
                label_cores.Enabled = true;
                label_lossless.Enabled = true;
                label_range.Enabled = true;
                label_depth.Enabled = true;
                label_qualityAlpha.Enabled = true;
                label_qualityColor.Enabled = true;
                label_yuv.Enabled = true;
                comboBox_speed.Enabled = true;
                comboBox_depth.Enabled = true;
                comboBox_rangeYuv.Enabled = true;
                comboBox_yuv.Enabled = true;
                checkBox_lossless.Enabled = true;
                if (!checkBox_lossless.Checked)
                {
                    numericUpDown_qa.Enabled = true;
                    numericUpDown_qc.Enabled = true;
                    comboBox_codec.Enabled = true;
                }
                textBox_cores.Enabled = true;

                label_distance.Enabled = false;
                label_distanceAlpha.Enabled = false;
                label_effort.Enabled = false;
                label_brotliEffort.Enabled = false;
                label_progressive.Enabled = false;
                label_losslessJpeg.Enabled = false;
                comboBox_distance.Enabled = false;
                comboBox_distanceAlpha.Enabled = false;
                comboBox_effort.Enabled = false;
                comboBox_brotliEffort.Enabled = false;
                checkBox_losslessJpg.Enabled = false;
                checkBox_progressive.Enabled = false;
                

            }
            else if (comboBox_format.Text == "JPEG XL")
            {
                textBox_arguments.Text = "cjxl";
                label_speed.Enabled = false;
                label_codec.Enabled = false;
                label_cores.Enabled = false;
                label_lossless.Enabled = false;
                label_range.Enabled = false;
                label_depth.Enabled = false;
                label_qualityAlpha.Enabled = false;
                label_qualityColor.Enabled = false;
                label_yuv.Enabled = false;
                comboBox_codec.Enabled = false;
                comboBox_speed.Enabled = false;
                comboBox_depth.Enabled = false;
                comboBox_rangeYuv.Enabled = false;
                comboBox_yuv.Enabled = false;
                checkBox_lossless.Enabled = false;
                numericUpDown_qa.Enabled = false;
                numericUpDown_qc.Enabled = false;
                textBox_cores.Enabled = false;

                label_distance.Enabled = true;
                label_distanceAlpha.Enabled = true;
                label_effort.Enabled = true;
                label_brotliEffort.Enabled = true;
                label_progressive.Enabled = true;
                label_losslessJpeg.Enabled = true;
                if (!checkBox_losslessJpg.Checked)
                {
                    comboBox_distance.Enabled = true;
                    comboBox_distanceAlpha.Enabled = true;
                }
                comboBox_effort.Enabled = true;
                comboBox_brotliEffort.Enabled = true;
                checkBox_losslessJpg.Enabled = true;
                checkBox_progressive.Enabled = true;
            }
        }

        private void checkBox_lossless_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_lossless.Checked)
            {
                if (!textBox_arguments.Text.Contains("-l"))
                {
                    textBox_arguments.Text += " -l";
                }
                textBox_arguments.Text = textBox_arguments.Text.Replace("-c rav1e", "-c aom");
                string arg = textBox_arguments.Text;
                string pattern = @"-q\s+(\d+)";
                arg = textBox_arguments.Text;
                arg = Regex.Replace(arg, pattern, $"-q 100");
                textBox_arguments.Text = arg;
                comboBox_codec.SelectedIndex = 0;
                comboBox_codec.Enabled = false;
                numericUpDown_qc.Value = 100;
                numericUpDown_qc.Enabled = false;
                numericUpDown_qa.Value = 100;
                numericUpDown_qa.Enabled = false;
            }
            else if (!checkBox_lossless.Checked)
            {
                textBox_arguments.Text = textBox_arguments.Text.Replace(" -l", "");
                comboBox_codec.Enabled = true;
                numericUpDown_qc.Enabled = true;
                numericUpDown_qa.Enabled = true;
            }
        }
        private void OnKeyDownHandlerEnter(object sender, KeyEventArgs kea)
        {
            if (kea.KeyCode.Equals(Keys.Enter))
            {
                if (textBox_arguments.Text.Contains("-j"))
                {
                    string arg = textBox_arguments.Text;
                    string pattern = @"-j\s+(\d+)";
                    arg = textBox_arguments.Text;
                    arg = Regex.Replace(arg, pattern, $"-j {textBox_cores.Text}");
                    textBox_arguments.Text = arg;
                }
                else
                {
                    textBox_arguments.Text += " -j " + textBox_cores.Text;
                }
            }
        }

        private void comboBox_depth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox_arguments.Text.Contains("-d"))
            {
                    string arg = textBox_arguments.Text;
                    string pattern = @"-d\s+(\d+)";
                    arg = textBox_arguments.Text;
                    arg = Regex.Replace(arg, pattern, $"-d {comboBox_depth.SelectedItem}");
                    textBox_arguments.Text = arg;
            }
            else
            {
                textBox_arguments.Text += " -d " + comboBox_depth.SelectedItem;
            }
        }

        private void comboBox_yuv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox_arguments.Text.Contains("-y"))
            {
                string arg = textBox_arguments.Text;
                string pattern = @"-y\s+(\d+)";
                arg = textBox_arguments.Text;
                arg = Regex.Replace(arg, pattern, $"-y {comboBox_yuv.SelectedItem}");
                textBox_arguments.Text = arg;
            }
            else
            {
                textBox_arguments.Text += " -y " + comboBox_yuv.SelectedItem;
            }
        }

        private void comboBox_codec_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (textBox_arguments.Text.Contains("-c"))
            {
                string arg = textBox_arguments.Text;
                string pattern = @"-c\s+aom";
                if(textBox_arguments.Text.Contains("-c rav1e")) pattern = @"-c\s+rav1e";
                arg = textBox_arguments.Text;
                arg = Regex.Replace(arg, pattern, $"-c {comboBox_codec.SelectedItem}");
                textBox_arguments.Text = arg;
            }
            else
            {
                textBox_arguments.Text += " -c " + comboBox_codec.SelectedItem;
            }
        }

        private void numericUpDown_qc_ValueChanged(object sender, EventArgs e)
        {
            if (textBox_arguments.Text.Contains(" -q"))
            {
                string arg = textBox_arguments.Text;
                string pattern = @"-q\s+(\d+)";
                arg = textBox_arguments.Text;
                arg = Regex.Replace(arg, pattern, $"-q {numericUpDown_qc.Value}");
                textBox_arguments.Text = arg;
            }
            else
            {
                textBox_arguments.Text += " -q " + numericUpDown_qc.Value;
            }
        }

        private void numericUpDown_qa_ValueChanged(object sender, EventArgs e)
        {
            if (textBox_arguments.Text.Contains("--qcolor"))
            {
                string arg = textBox_arguments.Text;
                string pattern = @"--qcolor\s+(\d+)";
                arg = textBox_arguments.Text;
                arg = Regex.Replace(arg, pattern, $"--qcolor {numericUpDown_qa.Value}");
                textBox_arguments.Text = arg;
            }
            else
            {
                textBox_arguments.Text += " --qcolor " + numericUpDown_qa.Value;
            }
        }

        private void comboBox_rangeYuv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox_arguments.Text.Contains("-r"))
            {
                string arg = textBox_arguments.Text;
                string pattern = @"-r\s+full";
                if (textBox_arguments.Text.Contains("-r limited")) pattern = @"-r\s+limited";
                arg = textBox_arguments.Text;
                arg = Regex.Replace(arg, pattern, $"-r {comboBox_rangeYuv.SelectedItem}");
                textBox_arguments.Text = arg;
            }
            else
            {
                textBox_arguments.Text += " -r " + comboBox_rangeYuv.SelectedItem;
            }
        }

        private void checkBox_progressive_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_progressive.Checked)
            {
                if (!textBox_arguments.Text.Contains("-p"))
                {
                    textBox_arguments.Text += " -p";
                }

            }
            else if (!checkBox_progressive.Checked)
            {
                textBox_arguments.Text = textBox_arguments.Text.Replace(" -p", "");
            }
        }

        private void comboBox_distance_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox_arguments.Text.Contains("-d"))
            {
                string arg = textBox_arguments.Text;
                string pattern = @"(?<=-d\s+)\d+(\.\d+)?";
                arg = textBox_arguments.Text;
                arg = Regex.Replace(arg, pattern, $"{comboBox_distance.SelectedItem}");
                textBox_arguments.Text = arg;
            }
            else
            {
                textBox_arguments.Text += " -d " + comboBox_distance.SelectedItem;
            }
        }

        private void comboBox_distanceAlpha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox_arguments.Text.Contains("-a"))
            {
                string arg = textBox_arguments.Text;
                string pattern = @"(?<=-a\s+)\d+(\.\d+)?";
                arg = textBox_arguments.Text;
                arg = Regex.Replace(arg, pattern, $"{comboBox_distanceAlpha.SelectedItem}");
                textBox_arguments.Text = arg;
            }
            else
            {
                textBox_arguments.Text += " -a " + comboBox_distanceAlpha.SelectedItem;
            }
        }

        private void comboBox_effort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox_arguments.Text.Contains(" -e"))
            {
                string arg = textBox_arguments.Text;
                string pattern = @"-e\s+(\d+)";
                arg = textBox_arguments.Text;
                arg = Regex.Replace(arg, pattern, $"-e {comboBox_effort.Text}");
                textBox_arguments.Text = arg;
            }
            else
            {
                textBox_arguments.Text += " -e " + comboBox_effort.Text;
            }
        }

        private void comboBox_brotliEffort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox_arguments.Text.Contains(" --brotli_effort"))
            {
                string arg = textBox_arguments.Text;
                string pattern = @"--brotli_effort (\d+)";
                arg = textBox_arguments.Text;
                arg = Regex.Replace(arg, pattern, $"--brotli_effort {comboBox_brotliEffort.Text}");
                textBox_arguments.Text = arg;
            }
            else
            {
                textBox_arguments.Text += " --brotli_effort " + comboBox_brotliEffort.Text;
            }
        }

        private void checkBox_losslessJpg_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_losslessJpg.Checked)
            {
                if (!textBox_arguments.Text.Contains("-j 1") && !textBox_arguments.Text.Contains("-j 0"))
                {
                    textBox_arguments.Text += " -j 1";
                }
                textBox_arguments.Text = textBox_arguments.Text.Replace("-j 0", "-j 1");
                comboBox_distance.Enabled = false;
                comboBox_distance.Text = "0.0";
                string arg = textBox_arguments.Text;
                string pattern = @"(?<=-d\s+)\d+(\.\d+)?";
                arg = textBox_arguments.Text;
                arg = Regex.Replace(arg, pattern, $"0.0");
                textBox_arguments.Text = arg;
                comboBox_distanceAlpha.Enabled = false;
                comboBox_distanceAlpha.Text = "0.0";
                string arg2 = textBox_arguments.Text;
                string pattern2 = @"(?<=-a\s+)\d+(\.\d+)?";
                arg = textBox_arguments.Text;
                arg = Regex.Replace(arg, pattern, $"0.0");
                textBox_arguments.Text = arg;

            }
            else if (!checkBox_losslessJpg.Checked)
            {
                textBox_arguments.Text = textBox_arguments.Text.Replace(" -j 1", " -j 0");
                comboBox_distance.Enabled = true;
                comboBox_distanceAlpha.Enabled = true;
            }
        }

        private void listBox_files_DragDrop(object sender, DragEventArgs e)
        {
            string[] droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in droppedFiles)
            {
                listBox_files.Items.Add(file);
            }
        }

        private void listBox_files_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop,false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }
    }
}
