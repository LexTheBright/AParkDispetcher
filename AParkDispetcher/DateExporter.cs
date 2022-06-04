using MySql.Data.MySqlClient;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AParkDispetcher
{
    class DateExporter
    {
        private static MySqlDataAdapter daCountry;
        private static DataTable dtTasks;

        public static void ReportAllForPeriod(DateTime left, DateTime right)
        {
            string lestr = left.ToString("yyyy-MM-dd");
            string ristr = right.ToString("yyyy-MM-dd");
            string querry = $"USE autos; SELECT * FROM tasks WHERE DATE(orderdatetime) BETWEEN '{lestr}' AND '{ristr}' ORDER BY orderdatetime";
            try
            {
                daCountry = new MySqlDataAdapter(querry, dbConnection.dbConnect);
                dtTasks = new DataTable();
                daCountry.Fill(dtTasks);
                DoExport();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void ReportWhereForPeriod(string value, string key, DateTime left, DateTime right)
        {
            string lestr = left.ToString("yyyy-MM-dd");
            string ristr = right.ToString("yyyy-MM-dd");
            string querry = $"USE autos; SELECT * FROM tasks WHERE" +
                $" AND {value} = '{key}'" +
                $" DATE(orderdatetime) BETWEEN '{lestr}' AND '{ristr}' ORDER BY orderdatetime";
            try
            {
                daCountry = new MySqlDataAdapter(querry, dbConnection.dbConnect);
                dtTasks = new DataTable();
                daCountry.Fill(dtTasks);
                DoExport();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

            private static void DoExport()
        {
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                excelPackage.Workbook.Properties.Author = "Сажин А.В.";
                excelPackage.Workbook.Properties.Title = "Заявки";
                excelPackage.Workbook.Properties.Created = DateTime.Now;

                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Заявки");
                worksheet.Cells["A1"].LoadFromDataTable(dtTasks, true);
                worksheet.Cells["B:B"].Style.Numberformat.Format = "dd-MM-yyyy  (HH:mm)";
                worksheet.Cells["E:E"].Style.Numberformat.Format = "dd-MM-yyyy  (HH:mm)";
                //worksheet.Cells["E:E"].Style.Numberformat.Format = DateTimeFormatInfo.CurrentInfo.ShortDatePattern;

                worksheet.Cells["A1"].Value = "Номер заявки";
                worksheet.Cells["B1"].Value = "Время заявки";
                worksheet.Cells["C1"].Value = "Состояние";
                worksheet.Cells["D1"].Value = "Запрошенное авто";
                worksheet.Cells["E1"].Value = "Время отправления";
                worksheet.Cells["F1"].Value = "Длительность";
                worksheet.Cells["G1"].Value = "Место отправления";
                worksheet.Cells["H1"].Value = "Место назначения";
                worksheet.Cells["I1"].Value = "Комментарий заявителя";
                worksheet.Cells["J1"].Value = "Комментарий оператора";
                worksheet.Cells["K1"].Value = "Табельный водителя";
                worksheet.Cells["L1"].Value = "ГРЗ авто";
                worksheet.Cells["M1"].Value = "Табельный заявителя";

                for (int i = 1; i < worksheet.Dimension.End.Row + 1; i++)
                {
                    if (worksheet.Cells[$"C{i}"].Value != null)
                    {
                        string celCoord = worksheet.Cells[$"C{i}"].Value.ToString();
                        switch (celCoord)
                        {
                            case "0":
                                worksheet.Cells[$"C{i}"].Value = "Новая";
                                break;
                            case "1":
                                worksheet.Cells[$"C{i}"].Value = "Подтверждена";
                                break;
                            case "2":
                                worksheet.Cells[$"C{i}"].Value = "Исполняется";
                                break;
                            case "3":
                                worksheet.Cells[$"C{i}"].Value = "Отменена";
                                break;
                            case "4":
                                worksheet.Cells[$"C{i}"].Value = "Завершена";
                                break;
                            default:
                                break;
                        }
                    }
                }

                //выравнивание и границы
                worksheet.Cells[worksheet.Dimension.Address].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[worksheet.Dimension.Address].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                worksheet.Cells[worksheet.Dimension.Address].Style.Border.Top.Style = ExcelBorderStyle.Double;
                worksheet.Cells[worksheet.Dimension.Address].Style.Border.Right.Style = ExcelBorderStyle.Double;
                worksheet.Cells[worksheet.Dimension.Address].Style.Border.Bottom.Style = ExcelBorderStyle.Double;
                worksheet.Cells[worksheet.Dimension.Address].Style.Border.Left.Style = ExcelBorderStyle.Double;
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns(30);

                //все переносы
                worksheet.Cells["1:1"].Style.WrapText = true;
                worksheet.Cells["1:1"].Style.Font.Bold = true;
                worksheet.Cells["1:1"].Style.Font.Size = 14;
                worksheet.Cells["G:G"].Style.WrapText = true;
                worksheet.Cells["H:H"].Style.WrapText = true;
                worksheet.Cells["I:I"].Style.WrapText = true;
                worksheet.Cells["J:J"].Style.WrapText = true;
                worksheet.Column(6).Width = 20;
                worksheet.Column(7).Width = 30;
                worksheet.Column(8).Width = 30;
                worksheet.Column(9).Width = 30;
                worksheet.Column(10).Width = 30;


                SaveFileDialog sDialog = new SaveFileDialog();
                sDialog.DefaultExt = "xlsx";
                sDialog.Filter = "Excel files (*.xlsx)|*.xlsx|Excel files (*.xls)| *.xls";
                if (sDialog.ShowDialog() == DialogResult.OK)
                excelPackage.SaveAs(new FileInfo(sDialog.FileName));
            }
        }
    }
}
