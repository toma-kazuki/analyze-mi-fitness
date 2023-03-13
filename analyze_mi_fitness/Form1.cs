﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using System.Text.Json;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace analyze_mi_fitness
{
    public partial class Form1 : Form
    {
        // ファイルパスを格納する
        string filePass = String.Empty;

        // 出力するデータ
        string time = "time";
        string avg_hrm = "avg_hrm";
        string distance = "distance";
        string duration = "duration";

        public Form1()
        {
            InitializeComponent();
        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofDialog = new OpenFileDialog();

            // デフォルトのフォルダを指定する
            ofDialog.InitialDirectory = @"C:\Users\elko7\Desktop\20230307_6431065728_MiFitness_sgp2_data_copy";

            //ダイアログのタイトルを指定する
            ofDialog.Title = "開くファイルを選択ください";

            //ダイアログを表示する
            if (ofDialog.ShowDialog() == DialogResult.OK)
            {
                FilePassTextBox.Text = ofDialog.FileName;
                filePass = ofDialog.FileName;
            }
            else
            {
                Console.WriteLine("キャンセルされました");
            }

            // オブジェクトを破棄する
            ofDialog.Dispose();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            //指定したcsvを開く
            StreamReader sr = new StreamReader(@filePass);

            List<Dictionary<string, dynamic>> data = new List<Dictionary<string, dynamic>>();

            // ファイル名と文字エンコードを指定してパーサを実体化
            using (TextFieldParser txtParser =
                new TextFieldParser(
                        filePass,
                        Encoding.GetEncoding("utf-8")))
            {
                // 内容は区切り文字形式
                txtParser.TextFieldType = FieldType.Delimited;
                // デリミタはカンマ
                txtParser.SetDelimiters(",");

                // ファイルの終わりまで一行ずつ処理
                while (!txtParser.EndOfData)
                {
                    // 一行を読み込んで配列に結果を受け取る
                    string[] splittedResult = txtParser.ReadFields();

                    if (splittedResult[2] == "outdoor_running")
                    {
                        // splittedResult[5] に json 型データが入っている
                        var dic = ParseJson(splittedResult[5]);

                        // 指定の範囲のデータのみ取り出す
                        if (dic["distance"] > Decimal.Parse(MinDistanceRangeComboBox.SelectedItem.ToString()) * 1000 && dic["distance"] < Decimal.Parse(MaxDistanceRangeComboBox.Text.ToString()) * 1000)
                        {
                            data.Add(dic);
                        }
                    }
                }

                excel_OutPutEx(data);
            }
        }

        // JSON文字列をDictionary<string, dynamic>型に変換するメソッド
        public static Dictionary<string, dynamic> ParseJson(string json)
        {
            // JSON文字列をDictionary<string, JsonData>型に変換
            var dic = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(json);

            // JsonElementから値を取り出してdynamic型に入れてDictionary<string, dynamic>型で返す
            return dic.Select(d => new { key = d.Key, value = JsonData(d.Value) })
            .ToDictionary(a => a.key, a => a.value);
        }
        
        private static dynamic JsonData(JsonElement elem)
        {
            switch (elem.ValueKind)
            {
                case JsonValueKind.String:
                    return elem.GetString();
                case JsonValueKind.Number:
                    return elem.GetDecimal();
            }

            return elem;
        }

        private void excel_OutPutEx(List<Dictionary<string, dynamic>> data)
        {
            //Excelオブジェクトの初期化
            Excel.Application ExcelApp = null;
            Excel.Workbooks wbs = null;
            Excel.Workbook wb = null;
            Excel.Sheets shs = null;
            Excel.Worksheet ws = null;

            try
            {
                //Excelシートのインスタンスを作る
                ExcelApp = new Excel.Application();
                wbs = ExcelApp.Workbooks;
                wb = wbs.Add();

                shs = wb.Sheets;
                ws = shs[1];
                ws.Select(Type.Missing);

                ExcelApp.Visible = false;

                // タイトル行をセット
                // Excelのcell指定
                ws.Cells[1, 1] = "ランニング日時";
                ws.Cells[1, 2] = "ランニング日";
                ws.Cells[1, 3] = "平均心拍数";
                ws.Cells[1, 4] = "走行距離";
                ws.Cells[1, 5] = "所要時間";
                ws.Cells[1, 6] = "平均ペース";

                // エクセルファイルにデータをセットする
                for (int i = 1; i < data.Count; i++)
                {
                    ProgressLabel.Text = $"{i} / {data.Count - 1}";

                    for (int j = 1; j < 7; j++)
                    {
                        // Excelのcell指定
                        Excel.Range w_rgn = ws.Cells;
                        Excel.Range rgn = w_rgn[i + 1, j];

                        try
                        {
                            var dateTime = DateTimeOffset.FromUnixTimeSeconds(decimal.ToInt64(data[i - 1]["time"])).ToLocalTime();

                            // Excelにデータをセット
                            switch (j)
                            {
                                case 1:
                                    rgn.Value2 = dateTime.ToString();
                                    break;
                                case 2:
                                    rgn.Value2 = dateTime.Date.ToString();
                                    break;
                                case 3:
                                    rgn.Value2 = data[i - 1]["avg_hrm"];
                                    break;
                                case 4:
                                    rgn.Value2 = data[i - 1]["distance"];
                                    break;
                                case 5:
                                    rgn.Value2 = data[i - 1]["duration"];
                                    break;
                                case 6:
                                    Decimal distance = data[i - 1]["distance"] / 1000;
                                    Decimal duration = data[i - 1]["duration"] / 60;
                                    Decimal pace = duration / distance;
                                    rgn.Value2 = pace.ToString("0.00");
                                    break;
                            }
                        }
                        finally
                        {
                            // Excelのオブジェクトはループごとに開放する
                            Marshal.ReleaseComObject(w_rgn);
                            Marshal.ReleaseComObject(rgn);
                            w_rgn = null;
                            rgn = null;
                        }
                    }
                }

                // SaveFileDialogを表示
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                //ダイアログのタイトルを指定する
                saveFileDialog.Title = "ファイルを保存する";
                // デフォルトのフォルダを指定する
                saveFileDialog.InitialDirectory = @"C:\Users\elko7\Desktop\20230307_6431065728_MiFitness_sgp2_data_copy";

                // デフォルトファイル名
                saveFileDialog.FileName = @"output.xlsx";

                //ダイアログを表示する
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    wb.SaveAs(saveFileDialog.FileName);
                    wb.Close(false);
                    ExcelApp.Quit();
                }
                else
                {
                    Console.WriteLine("キャンセルされました");
                }

                // オブジェクトを破棄する
                saveFileDialog.Dispose();

                ProgressLabel.Text = "出力完了";
            }
            finally
            {
                //Excelのオブジェクトを開放し忘れているとプロセスが落ちないため注意
                Marshal.ReleaseComObject(ws);
                Marshal.ReleaseComObject(shs);
                Marshal.ReleaseComObject(wb);
                Marshal.ReleaseComObject(wbs);
                Marshal.ReleaseComObject(ExcelApp);
                ws = null;
                shs = null;
                wb = null;
                wbs = null;
                ExcelApp = null;

                GC.Collect();
            }
        }
    }
}
