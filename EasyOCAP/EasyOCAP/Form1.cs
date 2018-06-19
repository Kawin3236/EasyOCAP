using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace EasyOCAP
{
    public partial class Form1 : Form
    {
        private ArrayList listCsv = new ArrayList();
        private StreamWriter sw;
        private CsvFile csvFile = new CsvFile();
        private DataDowntime dataDowntime = new DataDowntime();
        private String csvPath = "C:\\test555\\test.csv";
        public Form1()
        {
            InitializeComponent();
            try
            {
                txtOutput.Text = "OK";
                var csvFileLenth = new FileInfo(csvPath).Length;
            }
            catch (Exception error)
            {
                csvFile.createFileCsv();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (errorCase.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select error case.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    txtOutput.Text = "OK";
                    var csvFileLenth = new FileInfo(csvPath).Length;
                    String check1 = GetCheckedBox(checkBox1, checkBox2);
                    csvFile.insertDataToFileCsv(dataDowntime.GetTester(), dataDowntime.GetPloblem(), check1, txtComment.Text.ToString(), dataDowntime.GetDate(), dataDowntime.GetTime());
                }
            }
            catch (Exception error)
            {
                txtOutput.Text = error.Message;
                csvFile.createFileCsv();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtInput.Text = errorCase.Text;
            dataDowntime.SetPloblem(errorCase.Text);
            Image img = new Image();
            img.ShowImgCase(errorCase, picBox, labelCh1);

        }

        private String GetCheckedBox(RadioButton checkBox1, RadioButton checkBox2)
        {
            if (checkBox1.Checked) {
                
                    return checkBox1.Text;
        }
            else
                return checkBox2.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelCh1_Click(object sender, EventArgs e)
        {

        }
    }
}
