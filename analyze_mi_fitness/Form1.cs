using System;
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

namespace analyze_mi_fitness
{
    public partial class Form1 : Form
    {
        // ファイルパスを格納する
        string filePass = String.Empty;

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
            ofDialog.Title = "ダイアログのタイトル";

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

            List<string[]> lists = new List<string[]>();
            List<Dictionary<string, dynamic>> dictionaly = new List<Dictionary<string, dynamic>>();

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
                        // 配列からリストに格納する
                        lists.Add(splittedResult);

                        var dic = ParseJson(splittedResult[5]);
                        dictionaly.Add(dic);

                        if (dic["distance"] > 9000 && dic["distance"] < 11000)
                        {
                            Console.WriteLine("time : " + dic["time"]);
                            Console.WriteLine("avg_hrm : " + dic["avg_hrm"]);
                            Console.WriteLine("distance : " + dic["distance"]);
                        }
                    }

                    using (StreamWriter writer =
              new StreamWriter("sql.txt", true, Encoding.GetEncoding("shift_jis")))
                    {
                        // ここでテキストに書き出し
                    }
                }
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
    }
}
