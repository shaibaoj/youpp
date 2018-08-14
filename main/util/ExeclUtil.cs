using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Microsoft.Office.Interop;
using System.Data;
using System.Collections;
using System.Net;
using System.IO;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using haopintui.entity;

namespace haopintui.util
{
    public class ExeclUtil
    {


        /// <summary>
        /// 使用COM读取Excel
        /// </summary>
        /// <param name="excelFilePath">路径</param>
        /// <returns>DataTabel</returns>
        public  static System.Data.DataTable GetExcelData(string excelFilePath)
        {
           Stopwatch wath = new Stopwatch();

            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Sheets sheets;
            Microsoft.Office.Interop.Excel.Workbook workbook = null;
            object oMissiong = System.Reflection.Missing.Value;
            System.Data.DataTable dt = new System.Data.DataTable();

            wath.Start();

            try
            {
                if (app == null)
                {
                    return null;
                }

                workbook = app.Workbooks.Open(excelFilePath, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong);

                //将数据读入到DataTable中——Start   

                sheets = workbook.Worksheets;
                Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)sheets.get_Item(1);//读取第一张表
                if (worksheet == null)
                    return null;

                string cellContent;
                int iRowCount = worksheet.UsedRange.Rows.Count;
                int iColCount = worksheet.UsedRange.Columns.Count;
                Microsoft.Office.Interop.Excel.Range range;

                //负责列头Start
                DataColumn dc;
                int ColumnID = 1;
                range = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[1, 1];
                while (range.Text.ToString().Trim() != "")
                {
                    dc = new DataColumn();
                    dc.DataType = System.Type.GetType("System.String");
                    dc.ColumnName = range.Text.ToString().Trim();
                    dt.Columns.Add(dc);

                    range = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[1, ++ColumnID];
                }
                //End

                for (int iRow = 2; iRow <= iRowCount; iRow++)
                {
                    DataRow dr = dt.NewRow();

                    for (int iCol = 1; iCol <= iColCount; iCol++)
                    {
                        range = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[iRow, iCol];

                        cellContent = (range.Value2 == null) ? "" : range.Text.ToString();

                        //if (iRow == 1)
                        //{
                        //    dt.Columns.Add(cellContent);
                        //}
                        //else
                        //{
                        dr[iCol - 1] = cellContent;
                        //}
                    }

                    //if (iRow != 1)
                    dt.Rows.Add(dr);
                }

                wath.Stop();
                TimeSpan ts = wath.Elapsed;

                //将数据读入到DataTable中——End
                return dt;
            }
            catch
            {

                return null;
            }
            finally
            {
                workbook.Close(false, oMissiong, oMissiong);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                workbook = null;
                app.Workbooks.Close();
                app.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
                app = null;
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        public static  ArrayList query_order(CmsForm cmsForm,string cookie,int queryType) {
            ArrayList arrayLists = new ArrayList();
            try
            {
               int days = 2;
               days = cmsForm.appBean.ali_order_days;

               string startTime = DateTime.Now.AddDays(-days).ToString("yyyy-MM-dd");
               string endTime = DateTime.Now.ToString("yyyy-MM-dd");

                DateTime now = DateTime.Now;
                string str = string.Concat("temp", now.ToString("yyyyMMddHHmmss"), ".xls");
                string str1 = string.Concat(cmsForm.app_path, "\\config\\", str);
                if (File.Exists(str1))
                {
                    File.Delete(str1);
                }
                int type = 1;
                string str2 = "http://pub.alimama.com/report/getTbkPaymentDetails.json?queryType=1&payStatus=&DownloadID=DOWNLOAD_REPORT_INCOME_NEW&startTime={startTime}&endTime={endTime}";
                if (queryType==1)
                {                
                    str2 = "http://pub.alimama.com/report/getTbkPaymentDetails.json?queryType=3&payStatus=3&DownloadID=DOWNLOAD_REPORT_INCOME_NEW&startTime={startTime}&endTime={endTime}";
                }
                if (queryType == 2)
                {
                    type = 0;
                    str2 = "http://pub.alimama.com/report/getTbkThirdPaymentDetails.json?queryType=2&payStatus=&DownloadID=DOWNLOAD_REPORT_TK3_PUB&startTime={startTime}&endTime={endTime}";
                }
                if (queryType == 3)
                {
                    type = 0;
                    str2 = "http://pub.alimama.com/report/getTbkThirdPaymentDetails.json?queryType=4&payStatus=3&DownloadID=DOWNLOAD_REPORT_TK3_PUB&startTime={startTime}&endTime={endTime}";
                }

                if (queryType == 4)
                {
                    str2 = "http://pub.alimama.com/report/getElitePaymentDetails.json?queryType=5&payStatus=&DownloadID=DOWNLOAD_REPORT_ELITE&startTime={startTime}&endTime={endTime}";
                }
                if (queryType == 5)
                {
                    str2 = "http://pub.alimama.com/report/getElitePaymentDetails.json?queryType=6&payStatus=3&DownloadID=DOWNLOAD_REPORT_ELITE&startTime={startTime}&endTime={endTime}";
                }
                
                str2 = str2.Replace("{startTime}", startTime).Replace("{endTime}", endTime);
                WebClient webClient = new WebClient();
                webClient.Headers.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8");
                webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
                webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
                webClient.Headers.Add("Referer", "http://pub.alimama.com/myunion.htm");
                webClient.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
                webClient.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
                webClient.Headers.Add("Cookie", cookie);
                webClient.DownloadFile(str2, str1);

                //LogUtil.log_call(cmsForm, "str1" + str1.ToString());

                try
                {
                    string out_log;
                    bool logined = true;
                    arrayLists = ExeclUtil.query_order_list(cmsForm, str1, out out_log, type,out logined);
                    //System.Data.DataTable dt = ExeclUtil.GetExcelData(str1);
                    //LogUtil.log_call(cmsForm, "dt.Rows.Count：" + dt.Rows.Count);
                    //foreach(DataRow dr in dt.Rows)        
                    //{        
                    //     object value = dr["ColumnsName"];

                    //     LogUtil.log_call(cmsForm,"value"+ value.ToString());
                    //}  
                     if(logined==false){
                         AlimamaLogin.login(cmsForm, 1);
                     }

                }
                catch (Exception exception)
                {
                    LogUtil.log_call(cmsForm, "[--------DataTable]出错！" + exception.ToString());
                }

               File.Delete(str1);
            }
            catch (Exception)
            {
                
            }
            return arrayLists;
        }

        public static bool smethod_0(string string_0, string string_1, ArrayList arrayList_1, out string string_2)
        {
            bool flag;
            HSSFWorkbook hSSFWorkbook = null;
            ArrayList arrayLists = new ArrayList();
            try
            {
                try
                {
                    FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read);
                    hSSFWorkbook = new HSSFWorkbook(fileStream);
                    ISheet sheetAt = hSSFWorkbook.GetSheetAt(0);
                    int num = 1;
                    //foreach (GClass30 arrayList1 in arrayList_1)
                    //{
                    //    ExeclUtil.set_cell(sheetAt, num, 0, arrayList1.string_0);
                    //    ExeclUtil.set_cell(sheetAt, num, 1, arrayList1.string_2);
                    //    ExeclUtil.set_cell(sheetAt, num, 2, arrayList1.string_3);
                    //    num++;
                    //}
                    if (File.Exists(string_1))
                    {
                        File.Delete(string_1);
                    }
                    fileStream = new FileStream(string_1, FileMode.CreateNew, FileAccess.Write);
                    hSSFWorkbook.Write(fileStream);
                    fileStream.Flush();
                    fileStream.Close();
                    string_2 = "";
                    flag = true;
                }
                catch (Exception exception)
                {
                    string_2 = exception.ToString();
                    flag = false;
                }
            }
            finally
            {
                ExeclUtil.close(hSSFWorkbook);
            }
            return flag;
        }

        public static ArrayList query_order_list(CmsForm cmsForm,string string_0, out string out_log,int type,out bool logined)
        {
            out_log = "";
            logined = true;
            ArrayList arrayLists = new ArrayList();
            HSSFWorkbook hSSFWorkbook = null;
            try
            {
                try
                {
                    FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read);
                    hSSFWorkbook = new HSSFWorkbook(fileStream);
                    ISheet sheetAt = hSSFWorkbook.GetSheetAt(0);
                    if (File.Exists(string_0))
                    {
                        IRow row = sheetAt.GetRow(0);  //读取当前行数据

                        //LastRowNum 是当前表的总行数-1（注意）
                        //int offset = 0;
                        for (int i = 0; i <= sheetAt.LastRowNum; i++)
                        {
                            row = sheetAt.GetRow(i);  //读取当前行数据
                            if (row != null)
                            {
                                AliOrderBean aliOrderBean = new AliOrderBean();
                                aliOrderBean.order_time = ExeclUtil.read_cell(row.GetCell(0));
                                aliOrderBean.click_time = ExeclUtil.read_cell(row.GetCell(1));
                                aliOrderBean.title = ExeclUtil.read_cell(row.GetCell(2));
                                aliOrderBean.num_iid = ExeclUtil.read_cell(row.GetCell(3));
                                aliOrderBean.nick = ExeclUtil.read_cell(row.GetCell(4));
                                aliOrderBean.shop_title = ExeclUtil.read_cell(row.GetCell(5));
                                aliOrderBean.product_num = ExeclUtil.read_cell(row.GetCell(6));
                                aliOrderBean.product_price = ExeclUtil.read_cell(row.GetCell(7));
                                aliOrderBean.status = ExeclUtil.read_cell(row.GetCell(8));
                                aliOrderBean.order_type = ExeclUtil.read_cell(row.GetCell(9));
                                aliOrderBean.commission_rate = ExeclUtil.read_cell(row.GetCell(10));
                                aliOrderBean.fen_rate = ExeclUtil.read_cell(row.GetCell(11));
                                aliOrderBean.price = ExeclUtil.read_cell(row.GetCell(12));
                                aliOrderBean.commission = ExeclUtil.read_cell(row.GetCell(13));
                                aliOrderBean.settlement_price = ExeclUtil.read_cell(row.GetCell(14));
                                aliOrderBean.settlement_money = ExeclUtil.read_cell(row.GetCell(15));
                                aliOrderBean.settlement_date = ExeclUtil.read_cell(row.GetCell(16));
                                aliOrderBean.product_rate = ExeclUtil.read_cell(row.GetCell(17));
                                aliOrderBean.product_money = ExeclUtil.read_cell(row.GetCell(18));

                                if(type==1){
                                    aliOrderBean.benefit_rate = ExeclUtil.read_cell(row.GetCell(20));
                                    aliOrderBean.benefit_money = ExeclUtil.read_cell(row.GetCell(21));
                                    aliOrderBean.benefit_type = ExeclUtil.read_cell(row.GetCell(22));
                                    aliOrderBean.order_platform = ExeclUtil.read_cell(row.GetCell(23));
                                    aliOrderBean.third_party_service = ExeclUtil.read_cell(row.GetCell(24));
                                    aliOrderBean.order_no = ExeclUtil.read_cell(row.GetCell(25));
                                    aliOrderBean.cate_name = ExeclUtil.read_cell(row.GetCell(26));
                                    aliOrderBean.site_id = ExeclUtil.read_cell(row.GetCell(27));
                                    aliOrderBean.site_name = ExeclUtil.read_cell(row.GetCell(28));
                                    aliOrderBean.zone_id = ExeclUtil.read_cell(row.GetCell(29));
                                    aliOrderBean.zone_name = ExeclUtil.read_cell(row.GetCell(30));
                                }else{
                                
                                    aliOrderBean.benefit_rate = ExeclUtil.read_cell(row.GetCell(19));
                                    aliOrderBean.benefit_money = ExeclUtil.read_cell(row.GetCell(20));
                                    aliOrderBean.benefit_type = ExeclUtil.read_cell(row.GetCell(21));
                                    aliOrderBean.order_platform = ExeclUtil.read_cell(row.GetCell(22));
                                    aliOrderBean.third_party_service = ExeclUtil.read_cell(row.GetCell(23));
                                    aliOrderBean.order_no = ExeclUtil.read_cell(row.GetCell(24));
                                    aliOrderBean.cate_name = ExeclUtil.read_cell(row.GetCell(25));
                                    aliOrderBean.site_id = ExeclUtil.read_cell(row.GetCell(26));
                                    aliOrderBean.site_name = ExeclUtil.read_cell(row.GetCell(27));
                                    aliOrderBean.zone_id = ExeclUtil.read_cell(row.GetCell(28));
                                    aliOrderBean.zone_name = ExeclUtil.read_cell(row.GetCell(29));
                                }

                                //LastCellNum 是当前行的总列数
                                //for (int j = 0; j < row.LastCellNum; j++)
                                //{
                                //    //读取该行的第j列数据
                                //    string value = row.GetCell(j).ToString();
                                //    LogUtil.log_call(cmsForm, "value" + value.ToString());
                                //}
                                arrayLists.Add(aliOrderBean);

                                //LogUtil.log_call(cmsForm, "zone_name:" + aliOrderBean.zone_name.ToString());
                            }
                        }

                    }
                    fileStream.Close();
                }
                catch (Exception exception)
                {
                    logined = false;
                    LogUtil.log_call(cmsForm, "exception" + exception.ToString());
                }
            }
            finally
            {
                ExeclUtil.close(hSSFWorkbook);
            }

            return arrayLists;
        }

        private static ArrayList query_header(ISheet isheet_0)
        {
            ArrayList arrayList_0 = new ArrayList();
            int num = 0;
            while (true)
            {
                string str = ExeclUtil.cell(isheet_0, 0, num);
                if ((str == null ? true : "".Equals(str)))
                {
                    break;
                }
                arrayList_0.Add(str);
                num++;
            }
            return arrayList_0;
        }

        private static bool set_cell(ISheet isheet_0, int int_0, int int_1, string value)
        {
            IRow row = isheet_0.GetRow(int_0);
            if (row == null)
            {
                row = isheet_0.CreateRow(int_0);
            }
            ICell cell = row.GetCell(int_1);
            if (cell == null)
            {
                cell = row.CreateCell(int_1);
            }
            cell.SetCellValue(value);
            return true;
        }

        private static string cell(ISheet isheet_0, int row_num, int cell_num)
        {
            string str;
            IRow row = isheet_0.GetRow(row_num);
            str = (row != null ? ExeclUtil.read_cell(row.GetCell(cell_num)) : "");
            return str;
        }

        private static string read_cell(ICell icell_0)
        {
            string stringCellValue;
            if (icell_0 != null)
            {
                switch (icell_0.CellType)
                {
                    case CellType.Numeric:
                        {
                            stringCellValue = string.Concat(icell_0.NumericCellValue, "");
                            break;
                        }
                    case CellType.String:
                        {
                            stringCellValue = icell_0.StringCellValue;
                            break;
                        }
                    case CellType.Formula:
                        {
                            stringCellValue = icell_0.ToString();
                            break;
                        }
                    case CellType.Blank:
                        {
                            stringCellValue = "";
                            break;
                        }
                    case CellType.Boolean:
                        {
                            stringCellValue = string.Concat(icell_0.BooleanCellValue, "");
                            break;
                        }
                    case CellType.Error:
                        {
                            stringCellValue = string.Concat(icell_0.ErrorCellValue, "");
                            break;
                        }
                    default:
                        {
                            goto case CellType.Formula;
                        }
                }
            }
            else
            {
                stringCellValue = null;
            }
            return stringCellValue;
        }

        private static void close(HSSFWorkbook hssfworkbook)
        {
            try
            {
                if (hssfworkbook != null)
                {
                    hssfworkbook.Close();
                    hssfworkbook = null;
                }
            }
            catch
            {
            }
        }

        public static string status_name(string string_0)
        {
            string str;
            if (string_0.Equals("订单创建"))
            {
                str = "11";
            }
            else if (string_0.Equals("订单付款"))
            {
                str = "12";
            }
            else if (string_0.Equals("订单失效"))
            {
                str = "13";
            }
            else if (!string_0.Equals("订单成功"))
            {
                str = (!string_0.Equals("订单结算") ? "0" : "3");
            }
            else
            {
                str = "14";
            }
            return str;
        }


    }
}
