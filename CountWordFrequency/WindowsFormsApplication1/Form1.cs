using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using StrategyLibrary;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private string _dicPath = string.Empty;
        private string _unPath = string.Empty;
        private string _maPath = string.Empty;
        private FileInfo[] _files = null;
        public Form1()
        {
            InitializeComponent();
        }
        // 生成单个文件路径
        private string GetUnqiuePath() 
        {
            string result = string.Empty;
            OpenFileDialog fileName = new OpenFileDialog() { Filter = @"*.txt|*.txt" };
            if (fileName.ShowDialog() == DialogResult.OK)
            {
                return fileName.FileName.ToString();
            }
            return result;
        }
        // 生成单个文本路径
        private void UniqueFile_Click(object sender, EventArgs e)
        {
            UnqiueFilePath.Text = this._unPath = this.GetUnqiuePath();
        }
        // 生成文件夹路径
        private void ManyFile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK) 
            {
                DirectoryInfo dir = new DirectoryInfo(fbd.SelectedPath);
                this._files = dir.GetFiles("*.txt");
                if (this._files.Length == 0)
                {
                    MessageBox.Show("该目录下无txt类型文件");
                }
                else 
                {
                    ManyFilePath.Text = this._maPath = fbd.SelectedPath;
                }
            }
        }
        // 生成字典文件路径
        private void DicFile_Click(object sender, EventArgs e)
        {
            DicFilePath.Text = this._dicPath = this.GetUnqiuePath();
        }
        private void Run_Click(object sender, EventArgs e)
        {
            DateTime old = DateTime.Now;
            status.Text = "";
            string str = string.Empty;
            string[] patterns = this.burnPatterns();
            status.Text += "\n\n系统正在读取文件";
            if (unique.Checked == true)
            {
                if (this._unPath == "" || (this._unPath != "" && UnqiueFilePath.Text != this._unPath)) 
                {
                    MessageBox.Show("单个文件选择有错误");
                    return;
                }
                str = string.Join("", System.IO.File.ReadAllLines(@UnqiueFilePath.Text, System.Text.Encoding.GetEncoding("gb2312")));
            }
            else 
            {
                if (this._maPath == "" || (this._maPath != "" && this._maPath != ManyFilePath.Text)) 
                {
                    MessageBox.Show("文件夹选择有错误");
                    return;
                }
                for (int i = 0; i < this._files.Length; i++) 
                {
                    str += string.Join("", System.IO.File.ReadAllLines(this._files[i].FullName, System.Text.Encoding.GetEncoding("gb2312")));
                }
            }
            WordFrequency wf = new WordFrequency();
            status.Text += "\n\n系统工具正在统计词频...";
            List<Node> list = wf.burnList(str, patterns);           
            wf.burnResult(list);
            status.Text += "\n\n系统工具正在写入文件...";
            DateTime now = DateTime.Now;
            status.Text += "\n\n耗时：" + (now- old).TotalSeconds.ToString() + "秒";
            this.write(list);
        }
        private string[] burnPatterns() 
        {
            if (this._dicPath == "" || (this._dicPath != "" && DicFilePath.Text != this._dicPath)) 
            {
                MessageBox.Show("字典文件路径错误");
                return null;
            }
            string[] result = System.IO.File.ReadAllLines(@DicFilePath.Text, System.Text.Encoding.GetEncoding("gb2312"));
            return result;
        }
        private void write(List<Node> list) 
        {
            string fileName = Path.GetTempFileName();
            FileInfo myFile = new FileInfo(fileName);
            StreamWriter sw = myFile.CreateText();
            for (int i = 0; i < list.Count; i++)
            {
                string str = string.Empty;
                for (int j = 0; j < 12 - list[i].Key.Length; j++) 
                {
                    str += "—";
                } 
                str = list[i].Key + str + list[i].Count.ToString(CultureInfo.InvariantCulture);
                sw.WriteLine(str);
            }
            sw.Close();
            System.Diagnostics.Process.Start("notepad.exe", fileName);
        }
    }
}
