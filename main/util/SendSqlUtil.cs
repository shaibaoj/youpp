using haopintui.entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SQLite;
using System.IO;
using System.Text;

namespace haopintui.util
{
    public class SendSqlUtil
    {

        private OleDbConnection oleDbConnection;
        private string app_path;

        private OleDbCommand oleDbCommand_send;

        private string db_name = "阿里妈妈订单.db3"; //阿里妈妈订单.mdb

        public SendSqlUtil()
        {
            this.init_(this.db_name);
        }
        public SendSqlUtil(string db_path)
        {
            this.init_(db_path);
        }
        public void init_(string db_path)
        {
           this.app_path = Directory.GetCurrentDirectory();
           this.set_db(this.app_path + @"\config\" + db_path);
        }
        public void set_pay_order_mdb()
        {
            this.set_db(this.app_path + @"\config\" + this.db_name);
        }

        public void set_db(string db_path)
        {
            try
            {
                //if (this.oleDbConnection == null)
                //{
                //    string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0 ;Data Source=" + db_path + ";Jet OLEDB:Database Password=ali(*)135";
                //    this.oleDbConnection = new OleDbConnection(connectionString);
                //    this.oleDbConnection.Open();
                //}

                if (!System.IO.File.Exists(db_path))
                {
                    SQLiteDBHelper.CreateDB(db_path);
                } 

            }
            catch (Exception)
            {
                ;
            }
        }

        public void create_send_table(out string out_log)
        {
            //try
            //{
            //    string str = "CREATE TABLE `send` (`send_id` Counter primary key,`num_iid` varchar(20) NULL,`create_date` datetime NOT NULL,`content` text NULL,`status` int(1) NOT NULL DEFAULT 0,`sort` int NOT NULL DEFAULT 0,KEY `num_iid`(`num_iid`),KEY `create_date`(`create_date`));";
            //    //str = "drop TABLE send;";
            //    //this.exec_sql_send(str, out out_log);
            //    str = "CREATE TABLE send (`send_id` Counter primary key,`num_iid` varchar(20) NULL,`from` varchar(20) NULL,`create_date_str` varchar(20) NULL,`create_date` datetime NOT NULL,`memo` text NULL,`status` int NOT NULL,`sort` int NOT NULL);";
            //    this.exec_sql_send(str, out out_log);
            //}
            //catch (Exception)
            //{
            //    out_log = "创建发送表失败";
            //}
            //this.create_send_item_table(out out_log);

            out_log = "";
            try
            {
                SQLiteDBHelper db = new SQLiteDBHelper(this.app_path + @"\config\" + this.db_name);
                string sql = "CREATE TABLE send(send_id integer NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,num_iid varchar(20),from_name varchar(50) NOT NULL,create_date_str varchar(20) NOT NULL,create_date datetime NOT NULL,memo text,status integer NOT NULL,sort integer NOT NULL DEFAULT 0 )";
                db.ExecuteNonQuery(sql, null);

                sql = "CREATE TABLE send_item(send_id integer NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,num_iid varchar(20) NOT NULL,create_date datetime NOT NULL)";
                db.ExecuteNonQuery(sql, null);

                sql = "CREATE index idx1 on send_item(num_iid ASC)";
                db.ExecuteNonQuery(sql, null);

                sql = "CREATE index idx2 on send_item(create_date ASC)";
                db.ExecuteNonQuery(sql, null);

            }
            catch (Exception ex)
            {
              out_log = "创建发送表失败"+ex.ToString();
            }

            try
            {
                SQLiteDBHelper db = new SQLiteDBHelper(this.app_path + @"\config\" + this.db_name);
                string sql = "CREATE TABLE cms_item_plan(cms_id integer NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,num_iid varchar(60) NOT NULL,create_date datetime NOT NULL)";
                db.ExecuteNonQuery(sql, null);

                sql = "CREATE index cms_idx1 on cms_item_plan(num_iid ASC)";
                db.ExecuteNonQuery(sql, null);

                sql = "CREATE index cms_idx2 on cms_item_plan(create_date ASC)";
                db.ExecuteNonQuery(sql, null);

            }
            catch (Exception ex)
            {
                out_log = "创建发送表失败" + ex.ToString();
            }

            try
            {
                SQLiteDBHelper db = new SQLiteDBHelper(this.app_path + @"\config\" + this.db_name);

                string sql = "";

                sql = "alter table send add COLUMN goods_type varchar(20)";
                db.ExecuteNonQuery(sql, null);

            }
            catch (Exception ex)
            {
                out_log = "创建发送表失败" + ex.ToString();
            }
            try
            {
                SQLiteDBHelper db = new SQLiteDBHelper(this.app_path + @"\config\" + this.db_name);

                string sql = "";

                sql = "alter table send add COLUMN type integer NOT NULL DEFAULT 0 ";
                db.ExecuteNonQuery(sql, null);

            }
            catch (Exception ex)
            {
                out_log = "创建发送表失败" + ex.ToString();
            }
            try
            {
                SQLiteDBHelper db = new SQLiteDBHelper(this.app_path + @"\config\" + this.db_name);

                string sql = "";

                sql = "CREATE index idx3 on send(num_iid ASC)";
                db.ExecuteNonQuery(sql, null);

            }
            catch (Exception ex)
            {
                out_log = "创建发送表失败" + ex.ToString();
            }
            try
            {
                SQLiteDBHelper db = new SQLiteDBHelper(this.app_path + @"\config\" + this.db_name);

                string sql = "";

                sql = "CREATE index idx4 on send(num_iid ASC,goods_type ASC)";
                db.ExecuteNonQuery(sql, null);

            }
            catch (Exception ex)
            {
                out_log = "创建发送表失败" + ex.ToString();
            }

            try
            {
                SQLiteDBHelper db = new SQLiteDBHelper(this.app_path + @"\config\" + this.db_name);

                string sql = "";

                sql = "CREATE index idx_create_date_str on send(create_date_str ASC)";
                db.ExecuteNonQuery(sql, null);

            }
            catch (Exception ex)
            {
                out_log = "创建发送表失败" + ex.ToString();
            }

            try
            {
                SQLiteDBHelper db = new SQLiteDBHelper(this.app_path + @"\config\" + this.db_name);

                string sql = "CREATE TABLE weibo(weibo_id integer NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,user_name varchar(255) NOT NULL,pwd varchar(255) NOT NULL,memo text,create_date datetime NOT NULL)";
                db.ExecuteNonQuery(sql, null);

                sql = "CREATE index idx5 on weibo(user_name ASC)";
                db.ExecuteNonQuery(sql, null);

            }
            catch (Exception ex)
            {
                out_log = "创建发送表失败" + ex.ToString();
            }

            try
            {
                SQLiteDBHelper db = new SQLiteDBHelper(this.app_path + @"\config\" + this.db_name);
                string sql = "";
                //sql = "drop TABLE pid";
                //db.ExecuteNonQuery(sql, null);

                sql = "CREATE TABLE pid(pid_id integer NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE " +
                    ",qun_name varchar(255) NOT NULL " +
                    ",qun_pid varchar(255) NOT NULL " +
                    ",qun_type integer NOT NULL DEFAULT 0 " +
                    ",weiba text,create_date datetime NOT NULL)";
                db.ExecuteNonQuery(sql, null);

                sql = "CREATE index idx6 on pid(qun_name ASC)";
                db.ExecuteNonQuery(sql, null);

            }
            catch (Exception ex)
            {
                out_log = "创建发送表失败" + ex.ToString();
            }

            try
            {
                SQLiteDBHelper db = new SQLiteDBHelper(this.app_path + @"\config\" + this.db_name);
                string sql = "CREATE TABLE order_item(order_id integer NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,order_no varchar(32) NOT NULL,num_iid varchar(20) NOT NULL,status text,create_date datetime NOT NULL)";
                db.ExecuteNonQuery(sql, null);

                sql = "CREATE index idx100 on order_item(order_no ASC,num_iid ASC)";
                db.ExecuteNonQuery(sql, null);

            }
            catch (Exception ex)
            {
                out_log = "创建发送表失败" + ex.ToString();
            }

        }

        public bool delete_send_all(out string out_log)
        {
            out_log = "";
            try
            {
                string str = "delete from send ";
                return this.exec_sql_send(str, out out_log);
            }
            catch (Exception)
            {

            }
            return false;
        }

        public bool delete_send(int send_id,out string out_log)
        {
            out_log = "";
            try
            {
                string str = "delete from send where send_id=" + send_id + "";
                return this.exec_sql_send(str, out out_log);
            }
            catch (Exception)
            {
                
            }
            return false;
        }
        public bool delete_send_create(string create_date_str, out string out_log)
        {
            out_log = "";
            try
            {
                string str = "delete from send where create_date_str='" + create_date_str + "'";
                return this.exec_sql_send(str, out out_log);
            }
            catch (Exception)
            {

            }
            return false;
        }

        public bool delete_weibo(string user_name, out string out_log)
        {
            out_log = "";
            try
            {
                string str = "delete from weibo where user_name='" + user_name + "'";
                return this.exec_sql_send(str, out out_log);
            }
            catch (Exception)
            {

            }
            return false;
        }

        public bool delete_pid(int pid_id, out string out_log)
        {
            out_log = "";
            try
            {
                string str = "delete from pid where pid_id = " + pid_id;
                return this.exec_sql_send(str, out out_log);
            }
            catch (Exception)
            {

            }
            return false;
        }

        //public bool method_11(SendTaskItem gclass11_0, out string string_1)
        //{
        //    string str = "delete from sendtask  where taskid={taskid}";
        //    str = str.Replace("{taskid}", gclass11_0.task_id + "");
        //    return this.exec_sql_send(str, out string_1);
        //}

        public bool exec_sql_send(string sql, out string out_log)
        {
            try
            {
                //if (this.oleDbConnection == null)
                //{
                //    this.set_pay_order_mdb();
                //}
                //if (((this.oleDbCommand_send == null) || (this.oleDbCommand_send.Connection == null)) || (this.oleDbCommand_send.Connection.State != ConnectionState.Open))
                //{
                //    this.oleDbCommand_send = new OleDbCommand(sql, this.oleDbConnection);
                //}
                //else
                //{
                //    this.oleDbCommand_send.CommandText = sql;
                //}
                //this.oleDbCommand_send.ExecuteNonQuery();

                SQLiteDBHelper db = new SQLiteDBHelper(this.app_path + @"\config\" + this.db_name);
                db.ExecuteNonQuery(sql, null); 
                out_log = "";
                return true;
            }
            catch (Exception exception)
            {
                out_log = exception.ToString();
                return false;
            }
        }

        public bool insert(SendItem sendItem, out string out_log)
        {
            try
            {
                //if (this.oleDbConnection == null)
                //{
                //    this.set_pay_order_mdb();
                //}
                DateTime now = DateTime.Now;
                //string cmdText = "insert into `send` (`num_iid`,`from`,`create_date`,`create_date_str`,`memo`,`status`,`sort`) values('{num_iid}','{from}','{create_date}','{create_date_str}','{memo}',{status},{sort});";
                //cmdText = cmdText
                //    .Replace("{num_iid}", sendItem.num_iid)
                //    .Replace("{from}", sendItem.from)
                //    .Replace("{create_date_str}", sendItem.create_date_str)
                //    .Replace("{create_date}", ""+now)
                //    .Replace("{memo}", sendItem.memo)
                //    .Replace("{status}", ""+sendItem.status)
                //    .Replace("{sort}", ""+sendItem.sort);
                //if (((this.oleDbCommand_send == null) || (this.oleDbCommand_send.Connection == null)) || (this.oleDbCommand_send.Connection.State != ConnectionState.Open))
                //{
                //    this.oleDbCommand_send = new OleDbCommand(cmdText, this.oleDbConnection);
                //}
                //else
                //{
                //    this.oleDbCommand_send.CommandText = cmdText;
                //}
                //this.oleDbCommand_send.ExecuteNonQuery();
                //this.oleDbCommand_send.Dispose();


                string sql = "INSERT INTO send(num_iid,from_name,create_date,create_date_str,memo,status,sort,goods_type,type) values(@num_iid,@from_name,@create_date,@create_date_str,@memo,@status,@sort,@goods_type,@type)";
                SQLiteDBHelper db = new SQLiteDBHelper(this.app_path + @"\config\" + this.db_name);
                SQLiteParameter[] parameters = new SQLiteParameter[]{ 
                    new SQLiteParameter("@num_iid",sendItem.num_iid), 
                    new SQLiteParameter("@from_name",sendItem.from), 
                    new SQLiteParameter("@create_date", now), 
                    new SQLiteParameter("@create_date_str",sendItem.create_date_str), 
                    new SQLiteParameter("@memo",sendItem.memo), 
                    new SQLiteParameter("@status",sendItem.status),
                    new SQLiteParameter("@sort",sendItem.sort) ,
                    new SQLiteParameter("@goods_type",sendItem.goods_type) ,
                    new SQLiteParameter("@type",sendItem.type) 
                };
                db.ExecuteNonQuery(sql, parameters); 


                out_log = "";
                return true;
            }
            catch (Exception exception)
            {
                out_log = exception.ToString();
                return false;
            }
        }

        public bool insert_weibo(WeiboBean weiboBean, out string out_log)
        {
            try
            {
                DateTime now = DateTime.Now;
                string sql = "INSERT INTO weibo(user_name,pwd,create_date,memo) values(@user_name,@pwd,@create_date,@memo)";
                SQLiteDBHelper db = new SQLiteDBHelper(this.app_path + @"\config\" + this.db_name);
                SQLiteParameter[] parameters = new SQLiteParameter[]{ 
                    new SQLiteParameter("@user_name",weiboBean.user_name), 
                    new SQLiteParameter("@pwd",weiboBean.pwd), 
                    new SQLiteParameter("@create_date", now), 
                    new SQLiteParameter("@memo",weiboBean.memo)
                    //, 
                    //new SQLiteParameter("@status",weiboBean.status)
                };
                db.ExecuteNonQuery(sql, parameters);

                out_log = "";
                return true;
            }
            catch (Exception exception)
            {
                out_log = exception.ToString();
                return false;
            }
        }

        public bool insert_pid(PidBean pidBean, out string out_log)
        {
            try
            {
                DateTime now = DateTime.Now;
                string sql = "INSERT INTO pid(qun_name,qun_pid,qun_type,create_date,weiba) values(@qun_name,@qun_pid,@qun_type,@create_date,@weiba)";
                SQLiteDBHelper db = new SQLiteDBHelper(this.app_path + @"\config\" + this.db_name);
                SQLiteParameter[] parameters = new SQLiteParameter[]{ 
                    new SQLiteParameter("@qun_name",pidBean.qun_name), 
                    new SQLiteParameter("@qun_pid",pidBean.qun_pid), 
                    new SQLiteParameter("@qun_type",pidBean.qun_type), 
                    new SQLiteParameter("@create_date", now), 
                    new SQLiteParameter("@weiba",pidBean.weiba)
                    //, 
                    //new SQLiteParameter("@status",weiboBean.status)
                };
                db.ExecuteNonQuery(sql, parameters);

                out_log = "";
                return true;
            }
            catch (Exception exception)
            {
                out_log = exception.ToString();
                return false;
            }
        }

        public ArrayList query_weibo(int status, out string out_log)
        {
            out_log = "";
            try
            {
                string sql = "select * from weibo order by weibo_id asc limit 100 ";
                ArrayList list = new ArrayList();

                SQLiteDBHelper db = new SQLiteDBHelper(this.app_path + @"\config\" + this.db_name);
                using (SQLiteDataReader reader = db.ExecuteReader(sql, null))
                {
                    while (reader.Read())
                    {
                        
                        WeiboBean weiboBean = new WeiboBean();
                        //weiboBean.send_id = reader.GetInt32(0);
                        weiboBean.user_name = reader.GetString(1);
                        weiboBean.pwd = reader.GetString(2);
                        //weiboBean.status = reader.GetString(3);
                        weiboBean.memo = reader.GetString(4);
                        list.Add(weiboBean);
                    }
                }

                out_log = "";
                return list;
            }
            catch (Exception)
            {

            }
            return new ArrayList();
        }

        public ArrayList query_pid(int qun_type, out string out_log)
        {
            out_log = "";
            try
            {
                string sql = "select * from pid where qun_type=" + qun_type + " limit 2000 ";
                ArrayList list = new ArrayList();

                SQLiteDBHelper db = new SQLiteDBHelper(this.app_path + @"\config\" + this.db_name);
                using (SQLiteDataReader reader = db.ExecuteReader(sql, null))
                {
                    while (reader.Read())
                    {
                        //qun_name,qun_pid,qun_type,create_date,weiba
                        PidBean pidBean = new PidBean();

                        pidBean.pid_id = reader.GetInt32(0);
                        pidBean.qun_name = reader.GetString(1);
                        pidBean.qun_pid = reader.GetString(2);
                        pidBean.qun_type = reader.GetInt32(3);
                        pidBean.weiba = reader.GetString(4);
                        list.Add(pidBean);
                    }
                }

                out_log = "";
                return list;
            }
            catch (Exception ex)
            {
                out_log = ex.ToString();
            }
            return new ArrayList();
        }


        public ArrayList query_send(int status, out string out_log)
        {
            out_log = "";
            try
            {
                //string str = "select TOP 100 * from send where status=" + status + " ";
                string str = "select * from send order by send_id asc limit 500 "; 
                //order by sort desc
                return this.query_send_sql(str, out out_log);
            }
            catch (Exception)
            {
                
            }
            return new ArrayList();
        }

        public ArrayList query_send_sql(string sql, out string out_log)
        {
            try
            {
                ArrayList list = new ArrayList();
                //OleDbDataReader reader = new OleDbCommand(sql, this.oleDbConnection).ExecuteReader();
                //while (reader.Read())
                //{
                //    SendItem sendItem = new SendItem();
                //    sendItem.send_id = int.Parse(reader["send_id"].ToString());
                //    sendItem.from = reader["from"].ToString();
                //    sendItem.num_iid = reader["num_iid"].ToString();
                //    sendItem.memo = reader["memo"].ToString();
                //    sendItem.create_date_str = reader["create_date_str"].ToString();
                //    sendItem.create_date = DateTime.Parse(reader["create_date"].ToString());
                //    sendItem.status = int.Parse(reader["status"].ToString());
                //    sendItem.sort = int.Parse(reader["sort"].ToString());
                //    list.Add(sendItem);
                //}
                //reader.Close();

                SQLiteDBHelper db = new SQLiteDBHelper(this.app_path + @"\config\" + this.db_name);
                using (SQLiteDataReader reader = db.ExecuteReader(sql, null))
                {
                    while (reader.Read())
                    {
                        //Console.WriteLine("ID:{0},TypeName{1}", reader.GetInt64(0), reader.GetString(1));
                            SendItem sendItem = new SendItem();
                            //sendItem.send_id = int.Parse(reader["send_id"].ToString());
                            //sendItem.from = reader["from_name"].ToString();
                            //sendItem.num_iid = reader["num_iid"].ToString();
                            //sendItem.memo = reader["memo"].ToString();
                            //sendItem.create_date_str = reader["create_date_str"].ToString();
                            //sendItem.create_date = DateTime.Parse(reader["create_date"].ToString());
                            //sendItem.status = int.Parse(reader["status"].ToString());
                            //sendItem.sort = int.Parse(reader["sort"].ToString());
                            try
                            {
                            sendItem.send_id = reader.GetInt32(0);
                            }
                            catch (Exception) { }
                            try
                            {
                            sendItem.num_iid = reader.GetString(1);
                            }
                            catch (Exception) { }
                            try
                            {
                            sendItem.from = reader.GetString(2);
                            }
                            catch (Exception) { }
                            try
                            {
                            sendItem.create_date_str = reader.GetString(3);
                            }
                            catch (Exception) { }
                            try
                            {
                            sendItem.create_date = reader.GetDateTime(4);
                            }
                            catch (Exception) { }
                            try
                            {
                            sendItem.memo = reader.GetString(5);
                            }
                            catch (Exception) { }
                            try
                            {
                            sendItem.status = reader.GetInt16(6);
                            }
                            catch (Exception) { }
                            try
                            {
                            sendItem.sort = reader.GetInt16(7);
                            }
                            catch (Exception)
                            {                                
                            }
                            try
                            {
                            sendItem.goods_type = reader.GetString(8);
                            }
                            catch (Exception)
                            {                                
                            }
                            try
                            {
                            sendItem.type = reader.GetInt16(9);
                            }
                            catch (Exception)
                            {
                            }

                            list.Add(sendItem);
                    }
                } 

                out_log = "";
                return list;
            }
            catch (Exception exception)
            {
                out_log = "出错啦：" + exception.ToString();
                return new ArrayList();
            }
        }

        public bool insert_item(string num_iid, out string out_log)
        {
            try
            {
                //if (this.oleDbConnection == null)
                //{
                //    this.set_pay_order_mdb();
                //}
                DateTime now = DateTime.Now;
                //string cmdText = "insert into `send_item` (`num_iid`,`create_date`) values('{num_iid}','{create_date}');";
                //cmdText = cmdText
                //    .Replace("{num_iid}", num_iid)
                //    .Replace("{create_date}", "" + now);
                //if (((this.oleDbCommand_send == null) || (this.oleDbCommand_send.Connection == null)) || (this.oleDbCommand_send.Connection.State != ConnectionState.Open))
                //{
                //    this.oleDbCommand_send = new OleDbCommand(cmdText, this.oleDbConnection);
                //}
                //else
                //{
                //    this.oleDbCommand_send.CommandText = cmdText;
                //}
                //this.oleDbCommand_send.ExecuteNonQuery();
                //this.oleDbCommand_send.Dispose();

                string sql = "INSERT INTO send_item(num_iid,create_date)values(@num_iid,@create_date)";
                SQLiteDBHelper db = new SQLiteDBHelper(this.app_path + @"\config\" + this.db_name);
                SQLiteParameter[] parameters = new SQLiteParameter[]{ 
                    new SQLiteParameter("@num_iid",num_iid), 
                    new SQLiteParameter("@create_date", now)
                };
                db.ExecuteNonQuery(sql, parameters); 

                out_log = "";
                return true;
            }
            catch (Exception exception)
            {
                out_log = exception.ToString();
                return false;
            }
        }

        public bool insert_cms_item_plan(string num_iid, out string out_log)
        {
            try
            {
                DateTime now = DateTime.Now;

                string sql = "INSERT INTO cms_item_plan(num_iid,create_date)values(@num_iid,@create_date)";
                SQLiteDBHelper db = new SQLiteDBHelper(this.app_path + @"\config\" + this.db_name);
                SQLiteParameter[] parameters = new SQLiteParameter[]{ 
                    new SQLiteParameter("@num_iid",num_iid), 
                    new SQLiteParameter("@create_date", now)
                };
                db.ExecuteNonQuery(sql, parameters);

                out_log = "";
                return true;
            }
            catch (Exception exception)
            {
                out_log = exception.ToString();
                return false;
            }
        }

        public ArrayList query_send_item(string num_iid,int hours, out string out_log)
        {
            out_log = "";
            try
            {
                string times = DateTime.Now.AddHours(-hours).ToString("yyyy-MM-dd HH:mm:ss");
                //string str = "select TOP 1 * from send_item where num_iid='" + num_iid + "' and create_date >= '" + times + "' ";
                string str = "select * from send_item where num_iid='" + num_iid + "' and create_date >= '" + times + "' limit 1 ";
                //order by sort desc
                return this.query_send_item_sql(str, out out_log);
            }
            catch (Exception)
            {

            }
            return new ArrayList();
        }

        public ArrayList query_cms_item_plan(string num_iid, int hours, out string out_log)
        {
            out_log = "";
            try
            {
                string times = DateTime.Now.AddHours(-hours).ToString("yyyy-MM-dd HH:mm:ss");
                string str = "select * from cms_item_plan where num_iid='" + num_iid + "' and create_date >= '" + times + "' limit 1 ";
                //order by sort desc
                return this.query_cms_item_plan_sql(str, out out_log);
            }
            catch (Exception)
            {

            }
            return new ArrayList();
        }

        public bool delete_send_item(int hours, out string out_log)
        {
            out_log = "";
            try
            {
                string times = DateTime.Now.AddHours(-hours).ToString("yyyy-MM-dd HH:mm:ss");
                string str = "delete from send_item where create_date <= '" + times + "'";
                //order by sort desc
                //return this.query_send_item_sql(str, out out_log);
                return this.exec_sql_send(str, out out_log);
            }
            catch (Exception)
            {

            }
            return false;
        }

        public bool delete_cms_item_plan(int hours, out string out_log)
        {
            out_log = "";
            try
            {
                string times = DateTime.Now.AddHours(-hours).ToString("yyyy-MM-dd HH:mm:ss");
                string str = "delete from cms_item_plan where create_date <= '" + times + "'";
                return this.exec_sql_send(str, out out_log);
            }
            catch (Exception)
            {

            }
            return false;
        }

        public ArrayList query_send_item_sql(string sql, out string out_log)
        {
            try
            {
                ArrayList list = new ArrayList();
                //OleDbDataReader reader = new OleDbCommand(sql, this.oleDbConnection).ExecuteReader();
                //while (reader.Read())
                //{
                //    SendItem sendItem = new SendItem();
                //    sendItem.send_id = int.Parse(reader["send_id"].ToString());
                //    sendItem.num_iid = reader["num_iid"].ToString();
                //    list.Add(sendItem);
                //}
                //reader.Close();

                SQLiteDBHelper db = new SQLiteDBHelper(this.app_path + @"\config\" + this.db_name);
                using (SQLiteDataReader reader = db.ExecuteReader(sql, null))
                {
                    while (reader.Read())
                    {
                        SendItem sendItem = new SendItem();
                        sendItem.send_id = int.Parse(reader["send_id"].ToString());
                        sendItem.num_iid = reader["num_iid"].ToString();
                        list.Add(sendItem);
                    }
                } 

                out_log = "";
                return list;
            }
            catch (Exception exception)
            {
                out_log = "出错啦：" + exception.ToString();
                return new ArrayList();
            }
        }

        public ArrayList query_cms_item_plan_sql(string sql, out string out_log)
        {
            try
            {
                ArrayList list = new ArrayList();

                SQLiteDBHelper db = new SQLiteDBHelper(this.app_path + @"\config\" + this.db_name);
                using (SQLiteDataReader reader = db.ExecuteReader(sql, null))
                {
                    while (reader.Read())
                    {
                        SendItem sendItem = new SendItem();
                        sendItem.send_id = int.Parse(reader["cms_id"].ToString());
                        sendItem.num_iid = reader["num_iid"].ToString();
                        list.Add(sendItem);
                    }
                }

                out_log = "";
                return list;
            }
            catch (Exception exception)
            {
                out_log = "出错啦：" + exception.ToString();
                return new ArrayList();
            }
        }

        public ArrayList query_send(string num_iid, string goods_type, out string out_log)
        {
            out_log = "";
            try
            {
                string str = "select * from send where num_iid='" + num_iid + "' and goods_type = '" + goods_type + "' limit 1 ";
                return this.query_send_sql(str, out out_log);
            }
            catch (Exception)
            {

            }
            return new ArrayList();
        }


        public ArrayList query_order(string num_iid, string order_no, out string out_log)
        {
            out_log = "";
            try
            {
                string str = "select * from order_item where num_iid='" + num_iid + "' and order_no = '" + order_no + "' limit 1 ";
                return this.query_order_sql(str, out out_log);
            }
            catch (Exception)
            {

            }
            return new ArrayList();
        }

        public ArrayList query_order_sql(string sql, out string out_log)
        {
            try
            {
                ArrayList list = new ArrayList();

                SQLiteDBHelper db = new SQLiteDBHelper(this.app_path + @"\config\" + this.db_name);
                using (SQLiteDataReader reader = db.ExecuteReader(sql, null))
                {
                    while (reader.Read())
                    {
                        AliOrderBean aliOrderBean = new AliOrderBean();
                        try
                        {
                            aliOrderBean.order_no = reader.GetString(1);
                        }
                        catch (Exception) { }
                        try
                        {
                            aliOrderBean.num_iid = reader.GetString(2);
                        }
                        catch (Exception) { }
                        try
                        {
                            aliOrderBean.status = reader.GetString(3);
                        }
                        catch (Exception) { }

                        list.Add(aliOrderBean);
                    }
                }

                out_log = "";
                return list;
            }
            catch (Exception exception)
            {
                out_log = "出错啦：" + exception.ToString();
                return new ArrayList();
            }
        }

        public bool insert_order_item(string order_no
            , string num_iid
            , string status
            , out string out_log)
        {
            try
            {
                string str = "delete from order_item where order_no = '" + order_no + "' and num_iid = '" + num_iid + "'";
                this.exec_sql_send(str, out out_log);
            }
            catch (Exception)
            {
            }
            try
            {
                DateTime now = DateTime.Now;
                string sql = "INSERT INTO order_item(order_no,num_iid,status,create_date) values(@order_no,@num_iid,@status,@create_date)";
                SQLiteDBHelper db = new SQLiteDBHelper(this.app_path + @"\config\" + this.db_name);
                SQLiteParameter[] parameters = new SQLiteParameter[]{ 
                    new SQLiteParameter("@order_no",order_no), 
                    new SQLiteParameter("@num_iid", num_iid),
                    new SQLiteParameter("@status", status),
                    new SQLiteParameter("@create_date", now)
                };
                db.ExecuteNonQuery(sql, parameters);
                out_log = "";
                return true;
            }
            catch (Exception exception)
            {
                out_log = exception.ToString();
                return false;
            }
        }


    }
}
