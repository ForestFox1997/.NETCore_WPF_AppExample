using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using ExcelDataReader;
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ExcelDataHandler.Model
{
    class MainModel
    {
        public void _LoadExclData()
        {
            //var filePath = AppContext.BaseDirectory + @"Test1.xlsx";
            //using (var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite))
            //{
            //    IWorkbook workbook = new XSSFWorkbook(filePath);

            //    ISheet sheet = workbook.GetSheetAt(0);
            //    sheet.SetActiveCellRange()

            //    ISheet sheet = workbook.CreateSheet("Sheet1");
            //    sheet.AddMergedRegion(new CellRangeAddress())
            //    sheet.AddMergedRegion(new CellRangeAddress(0, 0, 0, 10));
            //    var rowIndex = 0;
            //    IRow row = sheet1.CreateRow(rowIndex);
            //    row.Height = 30 * 80;
            //    row.CreateCell(0).SetCellValue("this is content");
            //    sheet1.AutoSizeColumn(0);
            //    rowIndex++;

            //    var sheet2 = workbook.CreateSheet("Sheet2");
            //    var style1 = workbook.CreateCellStyle();
            //    style1.FillForegroundColor = HSSFColor.Blue.Index2;
            //    style1.FillPattern = FillPattern.SolidForeground;

            //    var style2 = workbook.CreateCellStyle();
            //    style2.FillForegroundColor = HSSFColor.Yellow.Index2;
            //    style2.FillPattern = FillPattern.SolidForeground;

            //    var cell2 = sheet2.CreateRow(0).CreateCell(0);
            //    cell2.CellStyle = style1;
            //    cell2.SetCellValue(0);

            //    cell2 = sheet2.CreateRow(1).CreateCell(0);
            //    cell2.CellStyle = style2;
            //    cell2.SetCellValue(1);

            //    workbook.Write(fs);
        }

        public void LoadExclData()
        {
            using (var stream = File.Open(AppContext.BaseDirectory + @"Test1.xlsx", FileMode.Open, FileAccess.Read))
            {
                IExcelDataReader reader;

                reader = ExcelReaderFactory.CreateReader(stream, new ExcelReaderConfiguration());

                ExcelDataSetConfiguration conf = new ExcelDataSetConfiguration { ConfigureDataTable = _ => new ExcelDataTableConfiguration { UseHeaderRow = true } };

                var dataSet = reader.AsDataSet(conf);

                
                var dataTable = dataSet.Tables[0];
                
            }


        }
    }
}
