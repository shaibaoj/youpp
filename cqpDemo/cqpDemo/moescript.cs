using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using cqpDemo;

namespace cqpDemo
{
    public class ScriptExplainer
    {
        public string[] script;
        public string path;
        fileHandle fd = new fileHandle();
        Dictionary<string, string> varsdic = new Dictionary<string,string>();
        string tname;
        string tvalue;
        string rootPath { get; set; }
        string message { get; set; }
        string fromQQ { get; set; }
        #region 逻辑属性
        int startIndex;
        int endIndex;
        public string command { get; set; } 
        public string objName { get; set; }//对象名
        public string[] objAtb { get; set; }//对象属性

        public Bitmap bmp = new Bitmap(100, 100);
        Graphics gf;
        #endregion
        public string main(string path,string cqpath,string QQ)
        {
            string text = "";
            rootPath = cqpath;
            fromQQ = QQ;
            scriptExplainer(path);
            return text;
        }
        public void scriptExplainer(string moepath)
        {
            fileReader(moepath);//载入脚本
            #region 遍历脚本
            //for (int index = 0; index < script.Length; index++){}
            foreach (var str in script)
            {          
                command = str;//获得当前脚本
                #region 解析对象
                //是否为标签命令
                if (command.IndexOf("<",0) >= 0)
                {                    
                    #region 逻辑指针
                    startIndex = str.IndexOf("<", 0);
                    endIndex = str.IndexOf(">", 0);
                    #endregion
                    #region 解析对象函数
                    if (startIndex < endIndex)//避免出现条件比较的误判
                    {
                        //去除"<"和">"，获得该行脚本
                        command = str.Substring(startIndex + 1, endIndex - startIndex - 1);
                        #region 对百分号引用进行翻译
                        while (command.IndexOf("%", 0) >= 0)
                        {
                            startIndex = command.IndexOf("%", 0);
                            endIndex = command.IndexOf("%", startIndex + 1);
                            string s0 = command.Substring(startIndex, endIndex - startIndex + 1);
                            string s1 = "未找到匹配项";
                            varsdic.TryGetValue(s0.Replace("%",""),out s1);
                            if (s0.Replace("%","") == "#运行目录")
                            {
                                s1 = rootPath;
                                #if DEBUG
                                s1 = "D:\\project\\programs\\com交互\\酷QPro完整包";
                                #endif
                            }
                            if (s0.Replace("%","")=="#发送者Q号")
                            {
                                s1 = fromQQ;
                            }                                                            
                            command = command.Replace(s0, s1);
                        }
                        #endregion
                        #region 对空格进行预处理                        
                        if (command.IndexOf("内容",0)>=0)
                        {
                            //内容="hello world!"
                            startIndex = command.IndexOf("内容",0);
                            endIndex = command.IndexOf("\"",startIndex + 4);
                            string s0 = command.Substring(startIndex,endIndex - startIndex);
                            string s1 = s0.Replace(" ","\\s");
                            command = command.Replace(s0,s1);
                        }
                        #endregion
                    }
                    objName = command;//获得逻辑对象名
                    endIndex = command.IndexOf(" ", 0); //判断是否存在属性                    
                    if (endIndex > 0)
                    {
                        objName = command.Substring(0, endIndex);//确认逻辑对象名
                        string cmdtmp = command.Replace(objName+" ","");                       
                        objAtb = cmdtmp.Split(' '); //分割逻辑对象属性
                    }
                    #endregion
                }
                #endregion
                #region 执行处理逻辑对象
                #region 逻辑参数
                Point position = new Point(0, 0);
                Point position1 = new Point(0, 0);
                Size size = new Size(10, 10);
                Size size1 = new Size(10, 10);
                Pen p = new Pen(Color.Black);
                FontFamily ff = new FontFamily("宋体");
                Font ft = new Font(ff, 10);
                Brush bs = new SolidBrush(Color.Black);
                string words = "未定义";
                bool fill = false;
                string path = "无路径";
                #endregion
                switch (objName)
                {
                    default:
                        break;
                    case "文件读取":
                        #region 设置文本读取的方法
                        string varname="变量"+varsdic.Count;
                        string strpath="";
                        string strsection="";
                        string strkey="";
                        string strtext="默认文本";
                        foreach (var str1 in objAtb)
                        {
                            //初始化预设属性值
                            //判断是否需要赋值
                            endIndex = str1.IndexOf("=", 0);
                            if (endIndex > 0)
                            {
                                #region 设置逻辑对象属性
                                //获取属性名
                                string atbName = str1.Substring(0, endIndex);
                                //获取属性值
                                startIndex = str1.IndexOf("\"", 0);
                                endIndex = str1.IndexOf("\"", startIndex + 1);
                                string value = str1.Substring(startIndex + 1, endIndex - startIndex - 1);
                                value = clsHandle(value);
                                //设置属性
                                switch (atbName)
                                {
                                    case "名字":
                                        varname = value;
                                        break;
                                    case "路径":
                                        strpath = value;
                                        break;
                                    case "键名":
                                        strsection = value;
                                        break;
                                    case "值名":
                                        strkey = value;
                                        break;
                                    case "内容":
                                        strtext = value;
                                        break;
                                    default:
                                        break;
                                }
                                #endregion
                            }
                        }
                        strtext = fileHandle.INIGetStringValue(strpath,strsection,strkey,strtext);
                        if (varsdic.ContainsKey(varname))
                        {
                            varsdic.Remove(varname);
                            varsdic.Add(varname, strtext);
                        }
                        else
                        {
                            varsdic.Add(varname, strtext);
                        }
                        #endregion
                        break;
                    case "文件写入":
                        #region 设置写入文本的方法
                        strpath = "";
                        strsection = "";
                        strkey = "";
                        strtext = "默认文本";
                        foreach (var str1 in objAtb)
                        {
                            //初始化预设属性值
                            //判断是否需要赋值
                            endIndex = str1.IndexOf("=", 0);
                            if (endIndex > 0)
                            {
                                #region 设置逻辑对象属性
                                //获取属性名
                                string atbName = str1.Substring(0, endIndex);
                                //获取属性值
                                startIndex = str1.IndexOf("\"", 0);
                                endIndex = str1.IndexOf("\"", startIndex + 1);
                                string value = str1.Substring(startIndex + 1, endIndex - startIndex - 1);
                                value = clsHandle(value);
                                //设置属性
                                switch (atbName)
                                {
                                    case "路径":
                                        strpath = value;
                                        break;
                                    case "键名":
                                        strsection = value;
                                        break;
                                    case "值名":
                                        strkey = value;
                                        break;
                                    case "内容":
                                        strtext = value;
                                        break;
                                    default:
                                        break;
                                }
                                #endregion
                            }
                        }
                        fileHandle.INIWriteValue(strpath, strsection, strkey, strtext);
                        #endregion
                        break;
                    case "设置变量":
                        #region 处理变量的生成
                        foreach (var str1 in objAtb)
                        {
                            //初始化预设属性值
                            //判断是否需要赋值
                            endIndex = str1.IndexOf("=", 0);
                            if (endIndex > 0)
                            {
                                #region 设置逻辑对象属性
                                //获取属性名
                                string atbName = str1.Substring(0, endIndex);
                                //获取属性值
                                startIndex = str1.IndexOf("\"", 0);
                                endIndex = str1.IndexOf("\"", startIndex + 1);
                                string value = str1.Substring(startIndex + 1, endIndex - startIndex - 1);
                                value = clsHandle(value);
                                //设置属性
                                switch (atbName)
                                {
                                    case "名字":
                                        tname = value;
                                        break;
                                    case "内容":
                                        tvalue = value;
                                        break;
                                    default:
                                        break;
                                }
                                #endregion
                            }                            
                        }
                        if (varsdic.ContainsKey(tname))
                        {
                            varsdic[tname] = tvalue;
                        }
                        else
                        {
                            varsdic.Add(tname, tvalue);
                        }
                        #endregion
                        break;
                    case "新建画布":
                        #region 处理画布的属性                                                
                        //初始化数据
                        foreach (var str1 in objAtb)
                        {
                            //初始化预设属性值
                            int height = 100;
                            int width = 100;
                            //判断是否需要赋值
                            endIndex = str1.IndexOf("=", 0);
                            if (endIndex > 0)
                            {
                                #region 设置逻辑对象属性
                                //获取属性名
                                string atbName = str1.Substring(0, endIndex);
                                //获取属性值
                                startIndex = str1.IndexOf("\"", 0);
                                endIndex = str1.IndexOf("\"", startIndex + 1);
                                string value = str1.Substring(startIndex + 1, endIndex - startIndex - 1);
                                value = clsHandle(value);
                                //设置属性
                                switch (atbName)
                                {
                                    case "宽度":
                                        height = bmp.Height;
                                        int.TryParse(value, out width);
                                        bmp = new Bitmap(width, height);
                                        break;
                                    case "高度":
                                        int.TryParse(value, out height);
                                        width = bmp.Width;
                                        bmp = new Bitmap(width, height);
                                        break;
                                    default:
                                        break;
                                }
                                #endregion
                            }
                        }
                        gf = Graphics.FromImage(bmp);
                        #endregion
                        break;
                    case "绘制方形":
                        #region 处理方形的属性
                        foreach (var str1 in objAtb)
                        {
                            //判断是否需要赋值
                            endIndex = str1.IndexOf("=", 0);
                            if (endIndex > 0)
                            {
                                #region 设置逻辑对象属性
                                //获取属性名
                                string atbName = str1.Substring(0, endIndex);
                                //获取属性值
                                startIndex = str1.IndexOf("\"", 0);
                                endIndex = str1.IndexOf("\"", startIndex + 1);
                                string value = str1.Substring(startIndex + 1, endIndex - startIndex - 1);
                                value.Replace("，", ",");
                                value = clsHandle(value);
                                //设置属性
                                switch (atbName)
                                {
                                    case "位置":
                                        string[] pos = value.Split(',');
                                        int X = 0;
                                        int Y = 0;
                                        int.TryParse(pos[0], out X);
                                        position.X = X;
                                        int.TryParse(pos[1], out Y);
                                        position.Y = Y;
                                        break;
                                    case "大小":
                                        string[] sz = value.Split(',');
                                        int ht = 10;
                                        int wd = 10;
                                        int.TryParse(sz[0], out wd);
                                        size.Width = wd;
                                        int.TryParse(sz[1], out ht);
                                        size.Height = ht;
                                        break;
                                    case "颜色":
                                        if (value.IndexOf("#", 0) >= 0)
                                        {
                                            p.Color = ColorTranslator.FromHtml(value);
                                        }
                                        else
                                        {
                                            p.Color = Color.FromName(value);
                                        }
                                        break;
                                    case "填充色":
                                        Color cltp = Color.Black;
                                        if (value.IndexOf("#", 0) >= 0)
                                        {
                                            cltp = ColorTranslator.FromHtml(value);
                                        }
                                        else
                                        {
                                            cltp = Color.FromName(value);
                                        }
                                        bs = new SolidBrush(cltp);
                                        break;
                                    case "填充":
                                        fill = true;
                                        string[] tcsz = value.Split(',');
                                        int tcht = 10;
                                        int tcwd = 10;
                                        int.TryParse(tcsz[0], out tcwd);
                                        size1.Width = tcwd;
                                        int.TryParse(tcsz[1], out tcht);
                                        size1.Height = tcht;
                                        break;
                                    default:
                                        break;
                                }
                                #endregion
                            }
                        }
                        Rectangle rec = new Rectangle(position, size);
                        if (fill)
                        {
                            Rectangle rec1 = new Rectangle(position,size1);
                            gf.FillRectangle(bs, rec1);
                            fill = false;
                        }                        
                        gf.DrawRectangle(p, rec);
                        #endregion
                        break;
                    case "绘制圆形":
                        #region 处理圆形的属性
                        foreach (var str1 in objAtb)
                        {
                            //判断是否需要赋值
                            endIndex = str1.IndexOf("=", 0);
                            if (endIndex > 0)
                            {
                                #region 设置逻辑对象属性
                                //获取属性名
                                string atbName = str1.Substring(0, endIndex);
                                //获取属性值
                                startIndex = str1.IndexOf("\"", 0);
                                endIndex = str1.IndexOf("\"", startIndex + 1);
                                string value = str1.Substring(startIndex + 1, endIndex - startIndex - 1);
                                value.Replace("，", ",");
                                value = clsHandle(value);
                                //设置属性
                                switch (atbName)
                                {
                                    case "位置":
                                        string[] pos = value.Split(',');
                                        int X = 0;
                                        int Y = 0;
                                        int.TryParse(pos[0], out X);
                                        position.X = X;
                                        int.TryParse(pos[1], out Y);
                                        position.Y = Y;
                                        break;
                                    case "大小":
                                        string[] sz = value.Split(',');
                                        int ht = 10;
                                        int wd = 10;
                                        int.TryParse(sz[0], out wd);
                                        size.Width = wd;
                                        int.TryParse(sz[1], out ht);
                                        size.Height = ht;
                                        break;
                                    case "圆心":
                                        //pos = value.Split(',');X = 0;Y = 0;
                                        //int.TryParse(pos[0], out X);position.X = X;
                                        //int.TryParse(pos[1], out Y);position.Y = Y;
                                        break;
                                    case "半径":
                                        //rad = 10;
                                        //int.TryParse(value, out rad);
                                        //size = new Size(rad * 2, rad * 2);
                                        break;
                                    case "颜色":
                                        if (value.IndexOf("#", 0) >= 0)
                                        {
                                            p.Color = ColorTranslator.FromHtml(value);
                                        }
                                        else
                                        {
                                            p.Color = Color.FromName(value);
                                        }
                                        break;
                                    case "填充色":
                                        Color cltp = Color.Black;
                                        if (value.IndexOf("#", 0) >= 0)
                                        {
                                            cltp = ColorTranslator.FromHtml(value);
                                        }
                                        else
                                        {
                                            cltp = Color.FromName(value);
                                        }
                                        bs = new SolidBrush(cltp);
                                        break;
                                    case "填充":
                                        fill = true;
                                        string[] tcsz = value.Split(',');
                                        int tcht = 10;
                                        int tcwd = 10;
                                        int.TryParse(tcsz[0], out tcwd);
                                        size1.Width = tcwd;
                                        int.TryParse(tcsz[1], out tcht);
                                        size1.Height = tcht;
                                        break;
                                    default:
                                        break;
                                }
                                #endregion
                            }
                        }
                        //在这里进行绘制
                        rec = new Rectangle(position, size);
                        if (fill)
                        {
                            Rectangle rec1 = new Rectangle(position, size1);
                            gf.FillEllipse(bs, rec1);
                            fill = false;
                        }
                        gf.DrawEllipse(p, rec);
                        #endregion
                        break;
                    case "绘制直线":
                        #region 处理直线的属性
                        foreach (var str1 in objAtb)
                        {
                            //判断是否需要赋值
                            endIndex = str1.IndexOf("=", 0);
                            if (endIndex > 0)
                            {
                                #region 设置逻辑对象属性                                
                                //获取属性名
                                string atbName = str1.Substring(0, endIndex);
                                //获取属性值
                                startIndex = str1.IndexOf("\"", 0);
                                endIndex = str1.IndexOf("\"", startIndex + 1);
                                string value = str1.Substring(startIndex + 1, endIndex - startIndex - 1);
                                value.Replace("，", ",");
                                value = clsHandle(value);
                                //设置属性
                                switch (atbName)
                                {
                                    case "位置":
                                        string[] pos = value.Split(',');
                                        int X = 0;
                                        int Y = 0;
                                        int.TryParse(pos[0], out X);
                                        position.X = X;
                                        int.TryParse(pos[1], out Y);
                                        position.Y = Y;
                                        int.TryParse(pos[2], out X);
                                        position1.X = X;
                                        int.TryParse(pos[3], out Y);
                                        position1.Y = Y;
                                        break;
                                    case "颜色":
                                        if (value.IndexOf("#", 0) >= 0)
                                        {
                                            p.Color = ColorTranslator.FromHtml(value);
                                        }
                                        else
                                        {
                                            p.Color = Color.FromName(value);
                                        }
                                        break;
                                    default:
                                        break;
                                }
                                #endregion
                            }
                        }
                        gf.DrawLine(p, position, position1);
                        #endregion
                        break;
                    case "绘制文本":
                        #region 处理文本的属性
                        foreach (var str1 in objAtb)
                        {
                            //判断是否需要赋值
                            endIndex = str1.IndexOf("=", 0);
                            if (endIndex > 0)
                            {
                                #region 设置逻辑对象属性
                                //获取属性名
                                string atbName = str1.Substring(0, endIndex);
                                //获取属性值
                                startIndex = str1.IndexOf("\"", 0);
                                endIndex = str1.IndexOf("\"", startIndex + 1);
                                string value = str1.Substring(startIndex + 1, endIndex - startIndex - 1);
                                value.Replace("，", ",");
                                value = clsHandle(value);
                                //设置属性
                                switch (atbName)
                                {
                                    case "内容":
                                        words = value;
                                        words = words.Replace("\\s", " ");
                                        break;
                                    case "字体":
                                        ff = new FontFamily(value);
                                        break;
                                    case "字号":
                                        int em = 10;
                                        int.TryParse(value, out em);
                                        ft = new Font(ff, em);
                                        break;
                                    case "位置":
                                        string[] pos = value.Split(',');
                                        int X = 0;
                                        int Y = 0;
                                        int.TryParse(pos[0], out X);
                                        position.X = X;
                                        int.TryParse(pos[1], out Y);
                                        position.Y = Y;
                                        break;
                                    case "颜色":
                                        Color cltp = Color.Black;
                                        if (value.IndexOf("#", 0) >= 0)
                                        {
                                            cltp = ColorTranslator.FromHtml(value);
                                        }
                                        else
                                        {
                                            cltp = Color.FromName(value);
                                        }
                                        bs = new SolidBrush(cltp);
                                        break;
                                    default:
                                        break;
                                }
                                #endregion
                            }
                        }                        
                        gf.DrawString(words, ft, bs, position);
                        #endregion
                        break;
                    case "绘制图片":
                        #region 处理图片的属性
                        foreach (var str1 in objAtb)
                        {
                            //判断是否需要赋值
                            endIndex = str1.IndexOf("=", 0);
                            if (endIndex > 0)
                            {
                                #region 设置逻辑对象属性
                                //获取属性名
                                string atbName = str1.Substring(0, endIndex);
                                //获取属性值
                                startIndex = str1.IndexOf("\"", 0);
                                endIndex = str1.IndexOf("\"", startIndex + 1);
                                string value = str1.Substring(startIndex + 1, endIndex - startIndex - 1);
                                value.Replace("，", ",");
                                value = clsHandle(value);
                                //设置属性
                                switch (atbName)
                                {
                                    default:
                                        break;
                                    case "位置":
                                        string[] pos = value.Split(',');
                                        int X = 0;
                                        int Y = 0;
                                        int.TryParse(pos[0], out X);
                                        position.X = X;
                                        int.TryParse(pos[1], out Y);
                                        position.Y = Y;
                                        break;
                                    case "路径":
                                        path = value;
                                        break;
                                    case "缩放":

                                        break;                                    
                                }
                                #endregion
                            }
                        }
                        Image pic = Image.FromFile(path);                        
                        gf.DrawImage(pic,position);
                        #endregion
                        break;
                    case "清空画布":
                        #region 清空画布
                        gf.Clear(Color.FromArgb(0));
                        #endregion
                        break;
                    case "图片另存":
                        #region 处理另存为的属性
                        foreach (var str1 in objAtb)
                        {
                            //判断是否需要赋值
                            endIndex = str1.IndexOf("=", 0);
                            if (endIndex > 0)
                            {
                                #region 设置逻辑对象属性
                                //获取属性名
                                string atbName = str1.Substring(0, endIndex);
                                //获取属性值
                                startIndex = str1.IndexOf("\"", 0);
                                endIndex = str1.IndexOf("\"", startIndex + 1);
                                string value = str1.Substring(startIndex + 1, endIndex - startIndex - 1);
                                value.Replace("，", ",");
                                value = clsHandle(value);
                                //设置属性
                                switch (atbName)
                                {
                                    case "路径":
                                        bmp.Save(value);
                                        break;
                                    default:
                                        break;
                                }
                                #endregion
                            }
                        }
                        #endregion
                        break;
                }
                #endregion
            }
            #endregion
        }
        public string clsHandle(string exp)
        {
            string result = "exp";
            char[] compair = { '+','-','*','/'};            
            string[] exptmp = exp.Split(',');
            List<string> rescom = new List<string>();
            foreach (var item in exptmp)
            {
                #region 进入四则运算判断            
                if (item.IndexOfAny(compair, 0) > -1)
                {
                    try
                    {
                        GrammerAnalyzer ga = new GrammerAnalyzer(item);
                        ga.Analyze();
                        Token[] toks = ga.TokenList;
                        SyntaxAnalyzer sa = new SyntaxAnalyzer(toks);
                        sa.Analyze();
                        Calculator calc = new Calculator(sa.SyntaxTree);
                        double value = calc.Calc();
                        rescom.Add(value.ToString());//加入到list中
                    }
                    catch
                    {

                    }
                }
                else
                {
                    rescom.Add(item.ToString());
                }
                #endregion
            }
            result = string.Join(",",rescom);
            return result;
        }

        public void fileReader(string path)
        {
            if (File.Exists(path))
            {
                script = File.ReadAllLines(path,Encoding.GetEncoding("GB2312") );
            }
        }
    }
}
