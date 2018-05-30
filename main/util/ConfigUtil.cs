using com.haopintui;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace haopintui
{
    public class ConfigUtil
    {
        public static void save_config(CmsForm cmsForm)
        {
            try
            {
                AppBean appBean = cmsForm.appBean;
                if (!Directory.Exists(cmsForm.app_path + "/config"))
                {
                    Directory.CreateDirectory(cmsForm.app_path + "/config");
                }
                appBean.config_ini = cmsForm.app_path + Constants.config_ini;
                if (File.Exists(appBean.config_ini))
                {
                    File.Delete(appBean.config_ini);
                }
                FileStream stream = new FileStream(appBean.config_ini, FileMode.Create);
                StreamWriter writer = new StreamWriter(stream, Encoding.GetEncoding("GB2312"));
                writer.WriteLine("autologin=" + (cmsForm.checkBoxAutoLogin.Checked ? "1" : "0"));
                writer.WriteLine("alimamaacc=" + cmsForm.textBoxAlimamaAcc.Text.Trim());
                writer.WriteLine("alimamapwd=" + cmsForm.textBoxAlimamaPwd.Text.Trim());
                writer.WriteLine("uuWiseAcc=" + cmsForm.textBoxUUUsername.Text.Trim());
                writer.WriteLine("uuWisePwd=" + cmsForm.textBoxUUPwd.Text.Trim());
                writer.WriteLine("appId=" + cmsForm.textBox_setting_appId.Text.Trim());
                writer.WriteLine("appKey=" + cmsForm.textBox_setting_appKey.Text.Trim());
                writer.WriteLine("scanlogin=" + (cmsForm.checkBoxScanLogin.Checked ? "1" : "0"));

                SelectedItem selectedItem_unit = (SelectedItem)cmsForm.comboBoxCmPUnit.SelectedItem;
                if (selectedItem_unit!=null)
                {
                    writer.WriteLine("cms_unit_id=" + selectedItem_unit.getId());
                    writer.WriteLine("cms_unit_name=" + selectedItem_unit.getLabel());
                }
                SelectedItem selectedItem_pos = (SelectedItem)cmsForm.comboBoxCmPPos.SelectedItem;
                if (selectedItem_pos != null)
                {
                    writer.WriteLine("cms_pos_id=" + selectedItem_pos.getId());
                    writer.WriteLine("cms_pos_name=" + selectedItem_pos.getLabel());
                }
                SelectedItem selectedItem_cms = (SelectedItem)cmsForm.comboBoxCmsList.SelectedItem;
                if (selectedItem_cms != null)
                {
                    writer.WriteLine("cms_cms_id=" + selectedItem_cms.getId());
                    writer.WriteLine("cms_cms_name=" + selectedItem_cms.getLabel());
                }
                string textBoxAppCmsReson = "";
                if (!string.IsNullOrEmpty(cmsForm.textBoxAppCmsReson.Text.Trim()))
                {
                    textBoxAppCmsReson = cmsForm.textBoxAppCmsReson.Text.Trim();
                    textBoxAppCmsReson = textBoxAppCmsReson.Replace("\r\n", "").Replace("\r", "").Replace("\n", "");
                }
                writer.WriteLine("cms_reson=" + textBoxAppCmsReson);

                writer.WriteLine("cms_jihua=" + (cmsForm.checkBox_cmslist_jihua.Checked ? "1" : "0"));
                writer.WriteLine("cms_xianshi=" + (cmsForm.checkBox_cmslist_xianshi.Checked ? "1" : "0"));

                writer.WriteLine("gengfa_haopintui=" + (cmsForm.checkBox_haopintui.Checked ? "1" : "0"));
                writer.WriteLine("gengfa_qq=" + (cmsForm.checkBox_gengfa_qq.Checked ? "1" : "0"));
                writer.WriteLine("qunfa_times=" + cmsForm.textBox_qunfa_times.Text.Trim());
                writer.WriteLine("qunfa_coupon=" + cmsForm.textBox_qunfa_coupon.Text.Trim());
                writer.WriteLine("qunfa_commission=" + cmsForm.textBox_qunfa_commission.Text.Trim());
                writer.WriteLine("qunfa_times_jiange=" + cmsForm.textBox_qunfa_times_jiange.Text.Trim());
                writer.WriteLine("qunfa_pid=" + (cmsForm.checkBox_qunfa_pid.Checked ? "1" : "0"));
                writer.WriteLine("qunfa_link=" + (cmsForm.checkBox_qunfa_link.Checked ? "1" : "0"));

                writer.WriteLine("qunfa_qq_boolean=" + (cmsForm.checkBox_qunfa_qq_boolean.Checked ? "1" : "0"));
                writer.WriteLine("qunfa_weixin_boolean=" + (cmsForm.checkBox_qunfa_weixin_boolean.Checked ? "1" : "0"));
                writer.WriteLine("qunfa_weibo_boolean=" + (cmsForm.checkBox_qunfa_weibo_boolean.Checked ? "1" : "0"));

                writer.WriteLine("qunfa_qq_zuixiaohua=" + (cmsForm.checkBox_qunfa_qq_zuixiaohua.Checked ? "1" : "0"));
                writer.WriteLine("qunfa_qq_peizhi_qiehuan_times=" + cmsForm.textBox_qunfa_qq_peizhi_qiehuan_times.Text.Trim());
                writer.WriteLine("qunfa_qq_peizhi_zhantietimes=" + cmsForm.textBox_qunfa_qq_peizhi_zhantietimes.Text.Trim());
                writer.WriteLine("qunfa_qq_peizhi_fasong_times=" + cmsForm.textBox_qunfa_qq_peizhi_fasong_times.Text.Trim());

                writer.WriteLine("qunfa_qq_guanbi=" + (cmsForm.checkBox_qunfa_qq_guanbi.Checked ? "1" : "0"));
                writer.WriteLine("qunfa_qq_str_times=" + (cmsForm.checkBox_qunfa_qq_str_times.Checked ? "1" : "0"));
                writer.WriteLine("qunfa_qq_str_suiji=" + (cmsForm.checkBox_qunfa_qq_str_suiji.Checked ? "1" : "0"));

                writer.WriteLine("qunfa_qq_enter=" + (cmsForm.radioButton_qunfa_qq_enter.Checked ? "1" : "0"));

                string qunfa_wieba_content = "";
                if (!string.IsNullOrEmpty(cmsForm.textBox_qunfa_wieba_content.Text.Trim()))
                {
                    qunfa_wieba_content = cmsForm.textBox_qunfa_wieba_content.Text.Trim();
                    qunfa_wieba_content = qunfa_wieba_content.Replace("\r\n", "").Replace("\r", "").Replace("\n", "");
                }
                writer.WriteLine("qunfa_wieba_content=" + qunfa_wieba_content);

                writer.WriteLine("qunfa_weixin_fatu_times=" + cmsForm.textBox_qunfa_weixin_fatu_times.Text.Trim());

                SelectedItem selectedItem_tongyong_duanyuan = (SelectedItem)cmsForm.comboBox_qq_tongyong_danyuan.SelectedItem;
                if (selectedItem_tongyong_duanyuan != null)
                {
                    writer.WriteLine("tongyong_unit_id=" + selectedItem_tongyong_duanyuan.getId());
                    writer.WriteLine("tongyong_unit_name=" + selectedItem_tongyong_duanyuan.getLabel());
                }

                SelectedItem selectedItem_tongyong_weizhi = (SelectedItem)cmsForm.comboBox_qq_tongyong_weizhi.SelectedItem;
                if (selectedItem_tongyong_weizhi != null)
                {
                    writer.WriteLine("tongyong_pos_id=" + selectedItem_tongyong_weizhi.getId());
                    writer.WriteLine("tongyong_pos_name=" + selectedItem_tongyong_weizhi.getLabel());
                }

                SelectedItem selectedItem_queqiao_duanyuan = (SelectedItem)cmsForm.comboBox_qq_queqiao_danyuan.SelectedItem;
                if (selectedItem_queqiao_duanyuan != null)
                {
                    writer.WriteLine("queqiao_unit_id=" + selectedItem_queqiao_duanyuan.getId());
                    writer.WriteLine("queqiao_unit_name=" + selectedItem_queqiao_duanyuan.getLabel());
                }

                SelectedItem selectedItem_queqiao_weizhi = (SelectedItem)cmsForm.comboBox_qq_queqiao_weizhi.SelectedItem;
                if (selectedItem_queqiao_weizhi != null)
                {
                    writer.WriteLine("queqiao_pos_id=" + selectedItem_queqiao_weizhi.getId());
                    writer.WriteLine("queqiao_pos_name=" + selectedItem_queqiao_weizhi.getLabel());
                }

                SelectedItem selectedItem_weixin_duanyuan = (SelectedItem)cmsForm.comboBox_weixin_tongyong_danyuan.SelectedItem;
                if (selectedItem_weixin_duanyuan != null)
                {
                    writer.WriteLine("weixin_unit_id=" + selectedItem_weixin_duanyuan.getId());
                    writer.WriteLine("weixin_unit_name=" + selectedItem_weixin_duanyuan.getLabel());
                }

                SelectedItem selectedItem_weixin_weizhi = (SelectedItem)cmsForm.comboBox_weixin_tongyong_weizhi.SelectedItem;
                if (selectedItem_weixin_weizhi != null)
                {
                    writer.WriteLine("weixin_pos_id=" + selectedItem_weixin_weizhi.getId());
                    writer.WriteLine("weixin_pos_name=" + selectedItem_weixin_weizhi.getLabel());
                }

                SelectedItem selectedItem_weibo_duanyuan = (SelectedItem)cmsForm.comboBox_weibo_tongyong_danyuan.SelectedItem;
                if (selectedItem_weibo_duanyuan != null)
                {
                    writer.WriteLine("weibo_unit_id=" + selectedItem_weibo_duanyuan.getId());
                    writer.WriteLine("weibo_unit_name=" + selectedItem_weibo_duanyuan.getLabel());
                }

                SelectedItem selectedItem_weibo_weizhi = (SelectedItem)cmsForm.comboBox_weibo_tongyong_weizhi.SelectedItem;
                if (selectedItem_weibo_weizhi != null)
                {
                    writer.WriteLine("weibo_pos_id=" + selectedItem_weibo_weizhi.getId());
                    writer.WriteLine("weibo_pos_name=" + selectedItem_weibo_weizhi.getLabel());
                }

                string qunfa_apply_content = "";
                if (!string.IsNullOrEmpty(cmsForm.textBox_qunfa_apply_content.Text.Trim()))
                {
                    qunfa_apply_content = cmsForm.textBox_qunfa_apply_content.Text.Trim();
                    qunfa_apply_content = qunfa_apply_content.Replace("\r\n", "").Replace("\r", "").Replace("\n", "");
                }
                writer.WriteLine("qunfa_apply_content=" + qunfa_apply_content);

                writer.WriteLine("qunfa_erheyi=" + (cmsForm.checkBox_qunfa_erheyi.Checked ? "1" : "0"));

                writer.WriteLine("alimama_cookie_url=" + cmsForm.textBoxAlimamaCookieUrl.Text.Trim());
                writer.WriteLine("alimama_create_pid=" + cmsForm.textBoxCreatePid.Text.Trim());

                writer.WriteLine("setting_app_ben=" + (cmsForm.radioButtonsetting_app_ben.Checked ? "1" : "0"));

                writer.WriteLine("qunfa_qq_kouling_boolean=" + (cmsForm.checkBox_qunfa_qq_kouling_boolean.Checked ? "1" : "0"));

                writer.WriteLine("fasong_weixin_fangshi_houtai=" + (cmsForm.radioButton_fasong_weixin_fashi_houtai.Checked ? "1" : "0"));

                writer.WriteLine("qunfa_duanlian=" + (cmsForm.checkBox_qunfa_duanlian.Checked ? "1" : "0"));

                if(cmsForm.radioButton_qunfa_duanlian_hpt.Checked){
                    writer.WriteLine("qunfa_duanlian_fangshi=1");
                }

                //SelectedItem selectedItem_cj_pinlv = (SelectedItem)cmsForm.comboBox_cj_pinlv.SelectedItem;
                //if (selectedItem_cj_pinlv != null)
                //{
                //    writer.WriteLine("qunfa_caiji_pinlv=" + selectedItem_cj_pinlv.getValue());
                //}
                //SelectedItem selectedItem_qunfa_ds_s1 = (SelectedItem)cmsForm.comboBox_qunfa_ds_s1.SelectedItem;
                //if (selectedItem_qunfa_ds_s1 != null)
                //{
                //    writer.WriteLine("qunfa_ds_s1=" + selectedItem_qunfa_ds_s1.getValue());
                //}
                //SelectedItem selectedItem_qunfa_ds_f1 = (SelectedItem)cmsForm.comboBox_qunfa_ds_f1.SelectedItem;
                //if (selectedItem_qunfa_ds_f1 != null)
                //{
                //    writer.WriteLine("qunfa_ds_f1=" + selectedItem_qunfa_ds_f1.getValue());
                //}
                //SelectedItem selectedItem_qunfa_ds_s2 = (SelectedItem)cmsForm.comboBox_qunfa_ds_s2.SelectedItem;
                //if (selectedItem_qunfa_ds_s2 != null)
                //{
                //    writer.WriteLine("qunfa_ds_s1=" + selectedItem_qunfa_ds_s2.getValue());
                //}
                //SelectedItem selectedItem_qunfa_ds_f2 = (SelectedItem)cmsForm.comboBox_qunfa_ds_f2.SelectedItem;
                //if (selectedItem_qunfa_ds_f2 != null)
                //{
                //    writer.WriteLine("qunfa_ds_f2=" + selectedItem_qunfa_ds_f2.getValue());
                //}
                string selectedItem_cj_pinlv = (string)cmsForm.comboBox_cj_pinlv.Text;
                    if (!string.IsNullOrEmpty(selectedItem_cj_pinlv))
                {
                    writer.WriteLine("qunfa_caiji_pinlv=" + selectedItem_cj_pinlv);
                }
                string selectedItem_qunfa_ds_s1 = (string)cmsForm.comboBox_qunfa_ds_s1.Text;
                    if (!string.IsNullOrEmpty(selectedItem_qunfa_ds_s1))
                {
                    writer.WriteLine("qunfa_ds_s1=" + selectedItem_qunfa_ds_s1);
                }
                string selectedItem_qunfa_ds_f1 = (string)cmsForm.comboBox_qunfa_ds_f1.Text;
                    if (!string.IsNullOrEmpty(selectedItem_qunfa_ds_f1))
                {
                    writer.WriteLine("qunfa_ds_f1=" + selectedItem_qunfa_ds_f1);
                }
                string selectedItem_qunfa_ds_s2 = (string)cmsForm.comboBox_qunfa_ds_s2.Text;
                    if (!string.IsNullOrEmpty(selectedItem_qunfa_ds_s2))
                {
                    writer.WriteLine("qunfa_ds_s2=" + selectedItem_qunfa_ds_s2);
                }
                string selectedItem_qunfa_ds_f2 = (string)cmsForm.comboBox_qunfa_ds_f2.Text;
                    if (!string.IsNullOrEmpty(selectedItem_qunfa_ds_f2))
                {
                    writer.WriteLine("qunfa_ds_f2=" + selectedItem_qunfa_ds_f2);
                }

                string selectedItem_ali_order_pinlv = (string)cmsForm.comboBox_ali_order_pinlv.Text;
                if (!string.IsNullOrEmpty(selectedItem_ali_order_pinlv))
                {
                    writer.WriteLine("ali_order_pinlv=" + selectedItem_ali_order_pinlv);
                }

                writer.WriteLine("qunfa_price1=" + cmsForm.textBox_price1.Text.Trim());
                writer.WriteLine("qunfa_price2=" + cmsForm.textBox_price2.Text.Trim());

                writer.Flush();
                writer.Close();
                writer.Dispose();
                stream.Close();
                stream.Dispose();

                ConfigUtil.save_qq_template(cmsForm);
                ConfigUtil.save_weixin_template(cmsForm);
                ConfigUtil.save_weibo_template(cmsForm);

                string config_qun_template_ini_qunhao = cmsForm.app_path + Constants.config_qun_template_ini_qunhao;
                UtilFile.write(config_qun_template_ini_qunhao, cmsForm.textBox_qun_list.Text.Trim());

                string config_qun_template_ini_guolv = cmsForm.app_path + Constants.config_qun_template_ini_guolv;
                UtilFile.write(config_qun_template_ini_guolv, cmsForm.textBox_qun_guolv.Text.Trim());

                string config_qun_template_ini_del = cmsForm.app_path + Constants.config_qun_template_ini_del;
                UtilFile.write(config_qun_template_ini_del, cmsForm.textBox_qun_del.Text.Trim());

                ConfigUtil.syn_config(cmsForm);

                LogUtil.log_call(cmsForm, "保存成功！");

            }
            catch (Exception exception)
            {
                LogUtil.log_call(cmsForm, "[init_config]" + exception.ToString());
            }


        }

        public static void init_config(CmsForm cmsForm)
        {
            try
            {
                AppBean appBean = cmsForm.appBean;
                if (!Directory.Exists(cmsForm.app_path + "/config"))
                {
                    Directory.CreateDirectory(cmsForm.app_path + "/config");
                }
                appBean.config_ini = cmsForm.app_path + Constants.config_ini;
                if (!File.Exists(appBean.config_ini))
                {
                    FileStream stream = File.Create(appBean.config_ini);
                    stream.Close();
                    stream.Dispose();
                }
                StreamReader reader = new StreamReader(appBean.config_ini, Encoding.GetEncoding("GB2312"));
                string str = null;
                while ((str = reader.ReadLine()) != null)
                {
                    if(!appBean.hashtable_config.ContainsKey(str.Split(new char[] { '=' })[0])){    
                        string keyname = str.Split(new char[] { '=' })[0];
                        string valuename="";
                        string[] strLen =  str.Split(new char[] { '=' });
                        for(int i=0;i<strLen.Length;i++){
                            if(i>1){
                                valuename = valuename+"=";
                            }
                            if(i>0){
                                valuename = valuename+strLen[i];
                            }
                        }
                        appBean.hashtable_config.Add(keyname, valuename);
                    }
                }
                reader.Close();
                reader.Dispose();

                cmsForm.textBoxAlimamaAcc.Text = (string)appBean.hashtable_config["alimamaacc"];
                cmsForm.textBoxAlimamaPwd.Text = (string)appBean.hashtable_config["alimamapwd"];
                cmsForm.checkBoxAutoLogin.Checked = "1".Equals((string)appBean.hashtable_config["autologin"]) || !appBean.hashtable_config.ContainsKey("autologin");
                cmsForm.checkBoxScanLogin.Checked = "1".Equals((string)appBean.hashtable_config["scanlogin"]);


                cmsForm.textBoxUUUsername.Text = (string)appBean.hashtable_config["uuWiseAcc"];
                cmsForm.textBoxUUPwd.Text = (string)appBean.hashtable_config["uuWisePwd"];

                cmsForm.textBox_setting_appId.Text = (string)appBean.hashtable_config["appId"];
                cmsForm.textBox_setting_appKey.Text = (string)appBean.hashtable_config["appKey"];

                if (appBean.hashtable_config.ContainsKey("cms_unit_id")
                    && appBean.hashtable_config.ContainsKey("cms_unit_name"))
                {
                    string cms_unit_id = (string)appBean.hashtable_config["cms_unit_id"];
                    string cms_unit_name = (string)appBean.hashtable_config["cms_unit_name"];
                    if (!string.IsNullOrEmpty(cms_unit_id)
                        && !string.IsNullOrEmpty(cms_unit_name))
                    {
                        SelectedItem selectedItem_unit = new SelectedItem();
                        selectedItem_unit.setId(cms_unit_id);
                        selectedItem_unit.setLabel(cms_unit_name);
                        cmsForm.comboBoxCmPUnit.Items.Add(selectedItem_unit);
                        cmsForm.comboBoxCmPUnit.SelectedIndex = 0;
                    }
                }

                if (appBean.hashtable_config.ContainsKey("cms_pos_id")
                    && appBean.hashtable_config.ContainsKey("cms_pos_name"))
                {
                    string cms_pos_id = (string)appBean.hashtable_config["cms_pos_id"];
                    string cms_pos_name = (string)appBean.hashtable_config["cms_pos_name"];
                    if (!string.IsNullOrEmpty(cms_pos_id)
                        && !string.IsNullOrEmpty(cms_pos_name))
                    {
                        SelectedItem selectedItem_pos = new SelectedItem();
                        selectedItem_pos.setId(cms_pos_id);
                        selectedItem_pos.setLabel(cms_pos_name);
                        cmsForm.comboBoxCmPPos.Items.Add(selectedItem_pos);
                        cmsForm.comboBoxCmPPos.SelectedIndex = 0;
                    }
                }

                if (appBean.hashtable_config.ContainsKey("cms_cms_id")
                    && appBean.hashtable_config.ContainsKey("cms_cms_name"))
                {
                    string cms_cms_id = (string)appBean.hashtable_config["cms_cms_id"];
                    string cms_cms_name = (string)appBean.hashtable_config["cms_cms_name"];
                    if (!string.IsNullOrEmpty(cms_cms_id)
                        && !string.IsNullOrEmpty(cms_cms_name))
                    {
                        SelectedItem selectedItem_cms = new SelectedItem();
                        selectedItem_cms.setId(cms_cms_id);
                        selectedItem_cms.setLabel(cms_cms_name);
                        cmsForm.comboBoxCmsList.Items.Add(selectedItem_cms);
                        cmsForm.comboBoxCmsList.SelectedIndex = 0;
                    }
                }

                if (appBean.hashtable_config.ContainsKey("tongyong_unit_id")
                   && appBean.hashtable_config.ContainsKey("tongyong_unit_name"))
                {
                    string tongyong_unit_id = (string)appBean.hashtable_config["tongyong_unit_id"];
                    string tongyong_unit_name = (string)appBean.hashtable_config["tongyong_unit_name"];
                    if (!string.IsNullOrEmpty(tongyong_unit_id)
                        && !string.IsNullOrEmpty(tongyong_unit_name))
                    {
                        SelectedItem selectedItem_tongyong_duanyuan = new SelectedItem();
                        selectedItem_tongyong_duanyuan.setId(tongyong_unit_id);
                        selectedItem_tongyong_duanyuan.setLabel(tongyong_unit_name);
                        cmsForm.comboBox_qq_tongyong_danyuan.Items.Add(selectedItem_tongyong_duanyuan);
                        cmsForm.comboBox_qq_tongyong_danyuan.SelectedIndex = 0;
                    }
                }

                if (appBean.hashtable_config.ContainsKey("tongyong_pos_id")
                  && appBean.hashtable_config.ContainsKey("tongyong_pos_name"))
                {
                    string tongyong_pos_id = (string)appBean.hashtable_config["tongyong_pos_id"];
                    string tongyong_pos_name = (string)appBean.hashtable_config["tongyong_pos_name"];
                    if (!string.IsNullOrEmpty(tongyong_pos_id)
                        && !string.IsNullOrEmpty(tongyong_pos_name))
                    {
                        SelectedItem selectedItem_tongyong_weizhi = new SelectedItem();
                        selectedItem_tongyong_weizhi.setId(tongyong_pos_id);
                        selectedItem_tongyong_weizhi.setLabel(tongyong_pos_name);
                        cmsForm.comboBox_qq_tongyong_weizhi.Items.Add(selectedItem_tongyong_weizhi);
                        cmsForm.comboBox_qq_tongyong_weizhi.SelectedIndex = 0;
                    }
                }

                if (appBean.hashtable_config.ContainsKey("queqiao_unit_id")
                    && appBean.hashtable_config.ContainsKey("queqiao_unit_name"))
                {
                    string queqiao_unit_id = (string)appBean.hashtable_config["queqiao_unit_id"];
                    string queqiao_unit_name = (string)appBean.hashtable_config["queqiao_unit_name"];
                    if (!string.IsNullOrEmpty(queqiao_unit_id)
                        && !string.IsNullOrEmpty(queqiao_unit_name))
                    {
                        SelectedItem selectedItem_queqiao_duanyuan = new SelectedItem();
                        selectedItem_queqiao_duanyuan.setId(queqiao_unit_id);
                        selectedItem_queqiao_duanyuan.setLabel(queqiao_unit_name);
                        cmsForm.comboBox_qq_queqiao_danyuan.Items.Add(selectedItem_queqiao_duanyuan);
                        cmsForm.comboBox_qq_queqiao_danyuan.SelectedIndex = 0;
                    }
                }

                if (appBean.hashtable_config.ContainsKey("queqiao_pos_id")
                   && appBean.hashtable_config.ContainsKey("queqiao_pos_name"))
                {
                    string queqiao_pos_id = (string)appBean.hashtable_config["queqiao_pos_id"];
                    string queqiao_pos_name = (string)appBean.hashtable_config["queqiao_pos_name"];
                    if (!string.IsNullOrEmpty(queqiao_pos_id)
                        && !string.IsNullOrEmpty(queqiao_pos_name))
                    {
                        SelectedItem selectedItem_queqiao_weizhi = new SelectedItem();
                        selectedItem_queqiao_weizhi.setId(queqiao_pos_id);
                        selectedItem_queqiao_weizhi.setLabel(queqiao_pos_name);
                        cmsForm.comboBox_qq_queqiao_weizhi.Items.Add(selectedItem_queqiao_weizhi);
                        cmsForm.comboBox_qq_queqiao_weizhi.SelectedIndex = 0;
                    }
                }

                if (appBean.hashtable_config.ContainsKey("weixin_unit_id")
                  && appBean.hashtable_config.ContainsKey("weixin_unit_name"))
                {
                    string weixin_unit_id = (string)appBean.hashtable_config["weixin_unit_id"];
                    string weixin_unit_name = (string)appBean.hashtable_config["weixin_unit_name"];
                    if (!string.IsNullOrEmpty(weixin_unit_id)
                        && !string.IsNullOrEmpty(weixin_unit_name))
                    {
                        SelectedItem selectedItem_weixin_duanyuan = new SelectedItem();
                        selectedItem_weixin_duanyuan.setId(weixin_unit_id);
                        selectedItem_weixin_duanyuan.setLabel(weixin_unit_name);
                        cmsForm.comboBox_weixin_tongyong_danyuan.Items.Add(selectedItem_weixin_duanyuan);
                        cmsForm.comboBox_weixin_tongyong_danyuan.SelectedIndex = 0;
                    }
                }

                if (appBean.hashtable_config.ContainsKey("weixin_pos_id")
                  && appBean.hashtable_config.ContainsKey("weixin_pos_name"))
                {
                    string weixin_pos_id = (string)appBean.hashtable_config["weixin_pos_id"];
                    string weixin_pos_name = (string)appBean.hashtable_config["weixin_pos_name"];
                    if (!string.IsNullOrEmpty(weixin_pos_id)
                        && !string.IsNullOrEmpty(weixin_pos_name))
                    {
                        SelectedItem selectedItem_weixin_weizhi = new SelectedItem();
                        selectedItem_weixin_weizhi.setId(weixin_pos_id);
                        selectedItem_weixin_weizhi.setLabel(weixin_pos_name);
                        cmsForm.comboBox_weixin_tongyong_weizhi.Items.Add(selectedItem_weixin_weizhi);
                        cmsForm.comboBox_weixin_tongyong_weizhi.SelectedIndex = 0;
                    }
                }

                if (appBean.hashtable_config.ContainsKey("weibo_unit_id")
                  && appBean.hashtable_config.ContainsKey("weibo_unit_name"))
                {
                    string weibo_unit_id = (string)appBean.hashtable_config["weibo_unit_id"];
                    string weibo_unit_name = (string)appBean.hashtable_config["weibo_unit_name"];
                    if (!string.IsNullOrEmpty(weibo_unit_id)
                        && !string.IsNullOrEmpty(weibo_unit_name))
                    {
                        SelectedItem selectedItem_weibo_duanyuan = new SelectedItem();
                        selectedItem_weibo_duanyuan.setId(weibo_unit_id);
                        selectedItem_weibo_duanyuan.setLabel(weibo_unit_name);
                        cmsForm.comboBox_weibo_tongyong_danyuan.Items.Add(selectedItem_weibo_duanyuan);
                        cmsForm.comboBox_weibo_tongyong_danyuan.SelectedIndex = 0;
                    }
                }

                if (appBean.hashtable_config.ContainsKey("weibo_pos_id")
                  && appBean.hashtable_config.ContainsKey("weibo_pos_name"))
                {
                    string weibo_pos_id = (string)appBean.hashtable_config["weibo_pos_id"];
                    string weibo_pos_name = (string)appBean.hashtable_config["weibo_pos_name"];
                    if (!string.IsNullOrEmpty(weibo_pos_id)
                        && !string.IsNullOrEmpty(weibo_pos_name))
                    {
                        SelectedItem selectedItem_weibo_weizhi = new SelectedItem();
                        selectedItem_weibo_weizhi.setId(weibo_pos_id);
                        selectedItem_weibo_weizhi.setLabel(weibo_pos_name);
                        cmsForm.comboBox_weibo_tongyong_weizhi.Items.Add(selectedItem_weibo_weizhi);
                        cmsForm.comboBox_weibo_tongyong_weizhi.SelectedIndex = 0;
                    }
                }


                cmsForm.textBoxAppCmsReson.Text = (string)appBean.hashtable_config["cms_reson"];
                cmsForm.checkBox_cmslist_jihua.Checked = "1".Equals((string)appBean.hashtable_config["cms_jihua"]);
                cmsForm.checkBox_cmslist_xianshi.Checked = "1".Equals((string)appBean.hashtable_config["cms_xianshi"]);

                cmsForm.checkBox_haopintui.Checked = "1".Equals((string)appBean.hashtable_config["gengfa_haopintui"]) || !appBean.hashtable_config.ContainsKey("gengfa_haopintui");
                cmsForm.checkBox_gengfa_qq.Checked = "1".Equals((string)appBean.hashtable_config["gengfa_qq"]);

                cmsForm.textBox_qunfa_times.Text = appBean.hashtable_config.ContainsKey("qunfa_times") ? (string)appBean.hashtable_config["qunfa_times"] : "1";
                cmsForm.textBox_qunfa_coupon.Text = appBean.hashtable_config.ContainsKey("qunfa_coupon") ? (string)appBean.hashtable_config["qunfa_coupon"] : "50";
                cmsForm.textBox_qunfa_commission.Text = appBean.hashtable_config.ContainsKey("qunfa_commission") ? (string)appBean.hashtable_config["qunfa_commission"] : "30";
                cmsForm.textBox_qunfa_times_jiange.Text = appBean.hashtable_config.ContainsKey("qunfa_times_jiange") ? (string)appBean.hashtable_config["qunfa_times_jiange"] : "5";

                cmsForm.checkBox_qunfa_pid.Checked = "1".Equals((string)appBean.hashtable_config["qunfa_pid"]) || !appBean.hashtable_config.ContainsKey("qunfa_pid");
                cmsForm.checkBox_qunfa_link.Checked = "1".Equals((string)appBean.hashtable_config["qunfa_link"]);
                cmsForm.checkBox_qunfa_qq_boolean.Checked = "1".Equals((string)appBean.hashtable_config["qunfa_qq_boolean"]);
                cmsForm.checkBox_qunfa_weixin_boolean.Checked = "1".Equals((string)appBean.hashtable_config["qunfa_weixin_boolean"]);
                cmsForm.checkBox_qunfa_weibo_boolean.Checked = "1".Equals((string)appBean.hashtable_config["qunfa_weibo_boolean"]);
                cmsForm.checkBox_qunfa_qq_zuixiaohua.Checked = "1".Equals((string)appBean.hashtable_config["qunfa_qq_zuixiaohua"]);

                cmsForm.textBox_qunfa_qq_peizhi_qiehuan_times.Text = appBean.hashtable_config.ContainsKey("qunfa_qq_peizhi_qiehuan_times") ? (string)appBean.hashtable_config["qunfa_qq_peizhi_qiehuan_times"] : "500";
                cmsForm.textBox_qunfa_qq_peizhi_zhantietimes.Text = appBean.hashtable_config.ContainsKey("qunfa_qq_peizhi_zhantietimes") ? (string)appBean.hashtable_config["qunfa_qq_peizhi_zhantietimes"] : "500";
                cmsForm.textBox_qunfa_qq_peizhi_fasong_times.Text = appBean.hashtable_config.ContainsKey("qunfa_qq_peizhi_fasong_times") ? (string)appBean.hashtable_config["qunfa_qq_peizhi_fasong_times"] : "500";

                cmsForm.checkBox_qunfa_qq_guanbi.Checked = "1".Equals((string)appBean.hashtable_config["qunfa_qq_guanbi"]) || !appBean.hashtable_config.ContainsKey("qunfa_qq_guanbi");
                cmsForm.checkBox_qunfa_qq_str_times.Checked = "1".Equals((string)appBean.hashtable_config["qunfa_qq_str_times"]);
                cmsForm.checkBox_qunfa_qq_str_suiji.Checked = "1".Equals((string)appBean.hashtable_config["qunfa_qq_str_suiji"]);

                cmsForm.radioButton_qunfa_qq_enter.Checked = "1".Equals((string)appBean.hashtable_config["qunfa_qq_enter"])|| !appBean.hashtable_config.ContainsKey("qunfa_qq_enter");
                cmsForm.radioButton_qunfa_qq_enter_ctrl.Checked = "0".Equals((string)appBean.hashtable_config["qunfa_qq_enter"]);

                cmsForm.textBox_qunfa_wieba_content.Text = (string)appBean.hashtable_config["qunfa_wieba_content"];
                cmsForm.textBox_qunfa_weixin_fatu_times.Text = appBean.hashtable_config.ContainsKey("qunfa_weixin_fatu_times") ? (string)appBean.hashtable_config["qunfa_weixin_fatu_times"] : "1000";

                cmsForm.textBox_qunfa_apply_content.Text = (string)appBean.hashtable_config["qunfa_apply_content"];
                cmsForm.checkBox_qunfa_erheyi.Checked = "1".Equals((string)appBean.hashtable_config["qunfa_erheyi"]);

                cmsForm.textBoxAlimamaCookieUrl.Text = (string)appBean.hashtable_config["alimama_cookie_url"];
                cmsForm.textBoxCreatePid.Text = (string)appBean.hashtable_config["alimama_create_pid"];

                cmsForm.checkBox_qunfa_qq_kouling_boolean.Checked = "1".Equals((string)appBean.hashtable_config["qunfa_qq_kouling_boolean"]);

                cmsForm.radioButtonsetting_app_ben.Checked = "1".Equals((string)appBean.hashtable_config["setting_app_ben"]);
                cmsForm.radioButtonsetting_app_haopintui.Checked = "0".Equals((string)appBean.hashtable_config["setting_app_ben"]);

                if ("1".Equals((string)appBean.hashtable_config["fasong_weixin_fangshi_houtai"]))
                {
                    cmsForm.radioButton_fasong_weixin_fashi_houtai.Checked = true ;
                    cmsForm.radioButton_fasong_weixin_fashi_qiantai.Checked = false;
                }else{
                    cmsForm.radioButton_fasong_weixin_fashi_houtai.Checked = false;
                    cmsForm.radioButton_fasong_weixin_fashi_qiantai.Checked = true;
                }

                if ("1".Equals((string)appBean.hashtable_config["qunfa_duanlian"]))
                {
                    cmsForm.checkBox_qunfa_duanlian.Checked = true;
                }
                else
                {
                    cmsForm.checkBox_qunfa_duanlian.Checked = false;
                }
                if (!appBean.hashtable_config.ContainsKey("qunfa_duanlian_fangshi")
                    ||"1".Equals((string)appBean.hashtable_config["qunfa_duanlian_fangshi"]))
                {
                    cmsForm.radioButton_qunfa_duanlian_hpt.Checked = true;
                }

                ConfigUtil.ini_qq_template(cmsForm);
                ConfigUtil.ini_weixin_template(cmsForm);
                ConfigUtil.ini_weibo_template(cmsForm);
                if(string.IsNullOrEmpty(cmsForm.appBean.qq_template)){
                    ConfigUtil.ini_qq_template_default(cmsForm);
                }
                if (string.IsNullOrEmpty(cmsForm.appBean.weixin_template))
                {
                    ConfigUtil.ini_weixin_template_default(cmsForm);
                }
                if (string.IsNullOrEmpty(cmsForm.appBean.weibo_template))
                {
                    ConfigUtil.ini_weibo_template_default(cmsForm);
                }

                string config_qun_template_ini_qunhao = cmsForm.app_path + Constants.config_qun_template_ini_qunhao;
                cmsForm.textBox_qun_list.Text = UtilFile.read_str(config_qun_template_ini_qunhao);
                string config_qun_template_ini_guolv = cmsForm.app_path + Constants.config_qun_template_ini_guolv;
                cmsForm.textBox_qun_guolv.Text = UtilFile.read_str(config_qun_template_ini_guolv);
                string config_qun_template_ini_del = cmsForm.app_path + Constants.config_qun_template_ini_del;
                cmsForm.textBox_qun_del.Text = UtilFile.read_str(config_qun_template_ini_del);

                if (!appBean.hashtable_config.ContainsKey("qunfa_caiji_pinlv")
                    || "0".Equals((string)appBean.hashtable_config["qunfa_caiji_pinlv"])
                    || "".Equals((string)appBean.hashtable_config["qunfa_caiji_pinlv"])
                    )
                {
                   cmsForm.comboBox_cj_pinlv.Text ="10";
                }else{
                    cmsForm.comboBox_cj_pinlv.Text = (string)appBean.hashtable_config["qunfa_caiji_pinlv"];
                }
                if (!appBean.hashtable_config.ContainsKey("qunfa_ds_s1")
                    || "0".Equals((string)appBean.hashtable_config["qunfa_ds_s1"])
                    || "".Equals((string)appBean.hashtable_config["qunfa_ds_s1"])
                    )
                {
                    cmsForm.comboBox_qunfa_ds_s1.Text = "9";
                }else{
                    cmsForm.comboBox_qunfa_ds_s1.Text = (string)appBean.hashtable_config["qunfa_ds_s1"];
                }
                if (!appBean.hashtable_config.ContainsKey("qunfa_ds_f1")
                    || "0".Equals((string)appBean.hashtable_config["qunfa_ds_f1"])
                    || "".Equals((string)appBean.hashtable_config["qunfa_ds_f1"])
                    )
                {
                    cmsForm.comboBox_qunfa_ds_f1.Text = "0";
                }
                else
                {
                    cmsForm.comboBox_qunfa_ds_f1.Text = (string)appBean.hashtable_config["qunfa_ds_f1"];
                }
                if (!appBean.hashtable_config.ContainsKey("qunfa_ds_s2")
                   || "0".Equals((string)appBean.hashtable_config["qunfa_ds_s2"])
                   || "".Equals((string)appBean.hashtable_config["qunfa_ds_s2"])
                    )
                {
                    cmsForm.comboBox_qunfa_ds_s2.Text = "22";
                }
                else
                {
                    cmsForm.comboBox_qunfa_ds_s2.Text = (string)appBean.hashtable_config["qunfa_ds_s2"];
                }
                if (!appBean.hashtable_config.ContainsKey("qunfa_ds_f2")
                   || "0".Equals((string)appBean.hashtable_config["qunfa_ds_f2"])
                   || "".Equals((string)appBean.hashtable_config["qunfa_ds_f2"])
                    )
                {
                    cmsForm.comboBox_qunfa_ds_f2.Text = "0";
                }
                else
                {
                    cmsForm.comboBox_qunfa_ds_f2.Text = (string)appBean.hashtable_config["qunfa_ds_f2"];
                }

                if (!appBean.hashtable_config.ContainsKey("ali_order_pinlv")
                    || "0".Equals((string)appBean.hashtable_config["ali_order_pinlv"])
                    || "".Equals((string)appBean.hashtable_config["ali_order_pinlv"])
                    )
                {
                    cmsForm.comboBox_ali_order_pinlv.Text = "1";
                }
                else
                {
                    cmsForm.comboBox_ali_order_pinlv.Text = (string)appBean.hashtable_config["ali_order_pinlv"];
                }

                cmsForm.textBox_price1.Text = (string)appBean.hashtable_config["qun_price1"];
                cmsForm.textBox_price2.Text = (string)appBean.hashtable_config["qun_price2"];

                //cmsForm.appBean.taoke_cookie = ConfigUtil.ini_taoke_cookie(cmsForm);

                ConfigUtil.syn_config(cmsForm);
            }
            catch (Exception exception)
            {
                LogUtil.log_call(cmsForm,"[init_config]" + exception.ToString());
            }

        }

        public static void syn_config(CmsForm cmsForm) {
            cmsForm.appBean.alimama_acc = cmsForm.textBoxAlimamaAcc.Text.Trim();
            cmsForm.appBean.alimama_pwd = cmsForm.textBoxAlimamaPwd.Text.Trim();
            cmsForm.appBean.alimama_auto_login = cmsForm.checkBoxAutoLogin.Checked;
            cmsForm.appBean.alimama_scan_login = cmsForm.checkBoxScanLogin.Checked;
            cmsForm.appBean.uu_username = cmsForm.textBoxUUUsername.Text.Trim();
            cmsForm.appBean.uu_pwd = cmsForm.textBoxUUPwd.Text.Trim();

            try
            {
                cmsForm.appBean.qunfa_hours = int.Parse(cmsForm.textBox_qunfa_times.Text.Trim());
            }
            catch (Exception) { }

            SelectedItem selectedItem_unit = (SelectedItem)cmsForm.comboBoxCmPUnit.SelectedItem;
            if (selectedItem_unit != null)
            {
                cmsForm.appBean.cms_siteid = selectedItem_unit.getId().ToString();
            }
            SelectedItem selectedItem_pos = (SelectedItem)cmsForm.comboBoxCmPPos.SelectedItem;
            if (selectedItem_pos != null)
            {
                cmsForm.appBean.cms_adzoneid = selectedItem_pos.getId().ToString();
            }
            //SelectedItem selectedItem_cms = (SelectedItem)cmsForm.comboBoxCmsList.SelectedItem;
            //if (selectedItem_cms != null)
            //{
            //    cmsForm.appBean.cms_app_id = selectedItem_cms.getId().ToString();
            //}

            SelectedItem selectedItem_tongyong_duanyuan = (SelectedItem)cmsForm.comboBox_qq_tongyong_danyuan.SelectedItem;
            if (selectedItem_tongyong_duanyuan != null)
            {
                cmsForm.appBean.qq_com_sid = selectedItem_tongyong_duanyuan.getId().ToString();
            }

            SelectedItem selectedItem_tongyong_weizhi = (SelectedItem)cmsForm.comboBox_qq_tongyong_weizhi.SelectedItem;
            if (selectedItem_tongyong_weizhi != null)
            {
                cmsForm.appBean.qq_com_aid = selectedItem_tongyong_weizhi.getId().ToString();
            }

            SelectedItem selectedItem_queqiao_duanyuan = (SelectedItem)cmsForm.comboBox_qq_queqiao_danyuan.SelectedItem;
            if (selectedItem_queqiao_duanyuan != null)
            {
                cmsForm.appBean.qq_queqiao_sid = selectedItem_queqiao_duanyuan.getId().ToString();
            }

            SelectedItem selectedItem_queqiao_weizhi = (SelectedItem)cmsForm.comboBox_qq_queqiao_weizhi.SelectedItem;
            if (selectedItem_queqiao_weizhi != null)
            {
                cmsForm.appBean.qq_queqiao_aid = selectedItem_queqiao_weizhi.getId().ToString();
            }

            SelectedItem selectedItem_weixin_duanyuan = (SelectedItem)cmsForm.comboBox_weixin_tongyong_danyuan.SelectedItem;
            if (selectedItem_weixin_duanyuan != null)
            {
                cmsForm.appBean.weixin_sid = selectedItem_weixin_duanyuan.getId().ToString();
            }

            SelectedItem selectedItem_weixin_weizhi = (SelectedItem)cmsForm.comboBox_weixin_tongyong_weizhi.SelectedItem;
            if (selectedItem_weixin_weizhi != null)
            {
                cmsForm.appBean.weixin_aid = selectedItem_weixin_weizhi.getId().ToString();
            }

            SelectedItem selectedItem_weibo_duanyuan = (SelectedItem)cmsForm.comboBox_weibo_tongyong_danyuan.SelectedItem;
            if (selectedItem_weibo_duanyuan != null)
            {
                cmsForm.appBean.weibo_sid = selectedItem_weibo_duanyuan.getId().ToString();
            }

            SelectedItem selectedItem_weibo_weizhi = (SelectedItem)cmsForm.comboBox_weibo_tongyong_weizhi.SelectedItem;
            if (selectedItem_weibo_weizhi != null)
            {
                cmsForm.appBean.weibo_aid = selectedItem_weibo_weizhi.getId().ToString();
            }

            string qunfa_caiji_pinlv = (String)cmsForm.comboBox_cj_pinlv.Text;
            if (!string.IsNullOrEmpty(qunfa_caiji_pinlv))
            {
                //LogUtil.log_call(cmsForm,"qunfa_caiji_pinlv:" + qunfa_caiji_pinlv);
                cmsForm.appBean.qunfa_caiji_pinlv = int.Parse(qunfa_caiji_pinlv);
            }
            string selectedItem_qunfa_ds_s1 = (string)cmsForm.comboBox_qunfa_ds_s1.Text;
                if (!string.IsNullOrEmpty(selectedItem_qunfa_ds_s1))
            {
                //LogUtil.log_call(cmsForm,"selectedItem_qunfa_ds_s1:" + selectedItem_qunfa_ds_s1);
                cmsForm.appBean.qunfa_ds_s1 = int.Parse(selectedItem_qunfa_ds_s1);
            }
            string selectedItem_qunfa_ds_f1 = (string)cmsForm.comboBox_qunfa_ds_f1.Text;
                if (!string.IsNullOrEmpty(selectedItem_qunfa_ds_f1))
            {
                //LogUtil.log_call(cmsForm, "selectedItem_qunfa_ds_f1:" + selectedItem_qunfa_ds_f1);
                cmsForm.appBean.qunfa_ds_f1 = int.Parse(selectedItem_qunfa_ds_f1);
            }
            string selectedItem_qunfa_ds_s2 = (string)cmsForm.comboBox_qunfa_ds_s2.Text;
                if (!string.IsNullOrEmpty(selectedItem_qunfa_ds_s2))
            {
                //LogUtil.log_call(cmsForm, "selectedItem_qunfa_ds_s2:" + selectedItem_qunfa_ds_s2);
                cmsForm.appBean.qunfa_ds_s2 = int.Parse(selectedItem_qunfa_ds_s2);
            }
            string selectedItem_qunfa_ds_f2 = (string)cmsForm.comboBox_qunfa_ds_f2.Text;
                if (!string.IsNullOrEmpty(selectedItem_qunfa_ds_f2))
            {
                //LogUtil.log_call(cmsForm, "selectedItem_qunfa_ds_f2:" + selectedItem_qunfa_ds_f2);
                cmsForm.appBean.qunfa_ds_f2 = int.Parse(selectedItem_qunfa_ds_f2);
            }
            //SelectedItem selectedItem_qunfa_ds_s1 = (SelectedItem)cmsForm.comboBox_qunfa_ds_s1.SelectedItem;
            //if (selectedItem_qunfa_ds_s1 != null)
            //{
            //    cmsForm.appBean.qunfa_ds_s1 = int.Parse(selectedItem_qunfa_ds_s1.getValue().ToString());
            //}
            //SelectedItem selectedItem_qunfa_ds_f1 = (SelectedItem)cmsForm.comboBox_qunfa_ds_f1.SelectedItem;
            //if (selectedItem_qunfa_ds_f1 != null)
            //{
            //    cmsForm.appBean.qunfa_ds_f1 = int.Parse(selectedItem_qunfa_ds_f1.getValue().ToString());
            //}
            //SelectedItem selectedItem_qunfa_ds_s2 = (SelectedItem)cmsForm.comboBox_qunfa_ds_s2.SelectedItem;
            //if (selectedItem_qunfa_ds_s2 != null)
            //{
            //    cmsForm.appBean.qunfa_ds_s2 = int.Parse(selectedItem_qunfa_ds_s2.getValue().ToString());
            //}
            //SelectedItem selectedItem_qunfa_ds_f2 = (SelectedItem)cmsForm.comboBox_qunfa_ds_f2.SelectedItem;
            //if (selectedItem_qunfa_ds_f2 != null)
            //{
            //    cmsForm.appBean.qunfa_ds_f2 = int.Parse(selectedItem_qunfa_ds_f2.getValue().ToString());
            //}

            cmsForm.appBean.textBox_qun_list = cmsForm.textBox_qun_list.Text;
            cmsForm.appBean.textBox_qun_guolv = cmsForm.textBox_qun_guolv.Text;
            cmsForm.appBean.textBox_qun_del = cmsForm.textBox_qun_del.Text;

            cmsForm.appBean.gengfa_qun = cmsForm.checkBox_gengfa_qq.Checked;

            cmsForm.appBean.qunfa_duanlian = cmsForm.checkBox_qunfa_duanlian.Checked;
            if (cmsForm.radioButton_qunfa_duanlian_hpt.Checked)
            {
                cmsForm.appBean.qunfa_duanlian_fangshi = "1";
            }

            //cmsForm.appBean.cms_jihua = cmsForm.checkBox_cmslist_jihua.Checked;
            cmsForm.appBean.cms_xianshi = cmsForm.checkBox_cmslist_xianshi.Checked;


            string ali_order_pinlv = (String)cmsForm.comboBox_ali_order_pinlv.Text;
            if (!string.IsNullOrEmpty(ali_order_pinlv))
            {
                cmsForm.appBean.ali_order_pinlv = int.Parse(ali_order_pinlv);
            }

            string ali_order_days = (String)cmsForm.comboBox_ali_order_days.Text;
            if (!string.IsNullOrEmpty(ali_order_days))
            {
                cmsForm.appBean.ali_order_days = int.Parse(ali_order_days);
            }

            string qun_price1 = (String)cmsForm.textBox_price1.Text;
            if (!string.IsNullOrEmpty(qun_price1))
            {
                cmsForm.appBean.qun_price1 = int.Parse(qun_price1);
            }
            string qun_price2 = (String)cmsForm.textBox_price2.Text;
            if (!string.IsNullOrEmpty(qun_price2))
            {
                cmsForm.appBean.qun_price2 = int.Parse(qun_price2);
            }

        }

        public static void sys_times(CmsForm cmsForm) {
            string qunfa_caiji_pinlv = (String)cmsForm.comboBox_cj_pinlv.Text;
            if (!string.IsNullOrEmpty(qunfa_caiji_pinlv))
            {
                //LogUtil.log_call(cmsForm,"qunfa_caiji_pinlv:" + qunfa_caiji_pinlv);
                cmsForm.appBean.qunfa_caiji_pinlv = int.Parse(qunfa_caiji_pinlv);
            }
            string selectedItem_qunfa_ds_s1 = (string)cmsForm.comboBox_qunfa_ds_s1.Text;
            if (!string.IsNullOrEmpty(selectedItem_qunfa_ds_s1))
            {
                //LogUtil.log_call(cmsForm,"selectedItem_qunfa_ds_s1:" + selectedItem_qunfa_ds_s1);
                cmsForm.appBean.qunfa_ds_s1 = int.Parse(selectedItem_qunfa_ds_s1);
            }
            string selectedItem_qunfa_ds_f1 = (string)cmsForm.comboBox_qunfa_ds_f1.Text;
            if (!string.IsNullOrEmpty(selectedItem_qunfa_ds_f1))
            {
                //LogUtil.log_call(cmsForm, "selectedItem_qunfa_ds_f1:" + selectedItem_qunfa_ds_f1);
                cmsForm.appBean.qunfa_ds_f1 = int.Parse(selectedItem_qunfa_ds_f1);
            }
            string selectedItem_qunfa_ds_s2 = (string)cmsForm.comboBox_qunfa_ds_s2.Text;
            if (!string.IsNullOrEmpty(selectedItem_qunfa_ds_s2))
            {
                //LogUtil.log_call(cmsForm, "selectedItem_qunfa_ds_s2:" + selectedItem_qunfa_ds_s2);
                cmsForm.appBean.qunfa_ds_s2 = int.Parse(selectedItem_qunfa_ds_s2);
            }
            string selectedItem_qunfa_ds_f2 = (string)cmsForm.comboBox_qunfa_ds_f2.Text;
            if (!string.IsNullOrEmpty(selectedItem_qunfa_ds_f2))
            {
                //LogUtil.log_call(cmsForm, "selectedItem_qunfa_ds_f2:" + selectedItem_qunfa_ds_f2);
                cmsForm.appBean.qunfa_ds_f2 = int.Parse(selectedItem_qunfa_ds_f2);
            }

            string ali_order_pinlv = (String)cmsForm.comboBox_ali_order_pinlv.Text;
            if (!string.IsNullOrEmpty(ali_order_pinlv))
            {
                cmsForm.appBean.ali_order_pinlv = int.Parse(ali_order_pinlv);
            }

            string ali_order_days = (String)cmsForm.comboBox_ali_order_days.Text;
            if (!string.IsNullOrEmpty(ali_order_days))
            {
                cmsForm.appBean.ali_order_days = int.Parse(ali_order_days);
            }
        }

        public static string ini_qq_template(CmsForm cmsForm)
        {
            string ini_qq_template_path = string.Concat(cmsForm.app_path, Constants.config_qq_template_ini);
            string content = UtilFile.read_str(ini_qq_template_path);
            cmsForm.textBox_qq_template.Text = content;
            cmsForm.appBean.qq_template = content;
            return content;
        }

        public static string ini_weixin_template(CmsForm cmsForm)
        {
            string ini_weixin_template_path = string.Concat(cmsForm.app_path, Constants.config_weixin_template_ini);
            string content = UtilFile.read_str(ini_weixin_template_path);
            cmsForm.textBox_weixin_template.Text = content;
            cmsForm.appBean.weixin_template = content;
            return content;
        }

        public static string ini_weibo_template(CmsForm cmsForm)
        {
            string ini_weibo_template_path = string.Concat(cmsForm.app_path, Constants.config_weibo_template_ini);
            string content = UtilFile.read_str(ini_weibo_template_path);
            cmsForm.textBox_weibo_template.Text = content;
            cmsForm.appBean.weibo_template = content;
            return content;
        }

        public static void save_qq_template(CmsForm cmsForm)
        {
            string ini_qq_template_path = string.Concat(cmsForm.app_path, Constants.config_qq_template_ini);
            string content = cmsForm.textBox_qq_template.Text;
            UtilFile.write(ini_qq_template_path, content);
            cmsForm.appBean.qq_template = content;
        }

        public static void save_weixin_template(CmsForm cmsForm)
        {

            string ini_weixin_template_path = string.Concat(cmsForm.app_path, Constants.config_weixin_template_ini);
            string content = cmsForm.textBox_weixin_template.Text;
            UtilFile.write(ini_weixin_template_path, content);
            cmsForm.appBean.weixin_template = content;
        }
        public static void save_weibo_template(CmsForm cmsForm)
        {

            string ini_weibo_template_path = string.Concat(cmsForm.app_path, Constants.config_weibo_template_ini);
            string content = cmsForm.textBox_weibo_template.Text;
            UtilFile.write(ini_weibo_template_path, content);
            cmsForm.appBean.weibo_template = content;
        }

        public static string ini_qq_template_default(CmsForm cmsForm)
        {
            string ini_qq_template_path = string.Concat(cmsForm.app_path, Constants.config_qq_template_ini + "_");
            string content = UtilFile.read_str(ini_qq_template_path);
            cmsForm.textBox_qq_template.Text = content;
            cmsForm.appBean.qq_template = content;
            return content;
        }

        public static string ini_weixin_template_default(CmsForm cmsForm)
        {
            string ini_weixin_template_path = string.Concat(cmsForm.app_path, Constants.config_weixin_template_ini+"_");
            string content = UtilFile.read_str(ini_weixin_template_path);
            cmsForm.textBox_weixin_template.Text = content;
            cmsForm.appBean.weixin_template = content;
            return content;
        }
       
        public static string ini_weibo_template_default(CmsForm cmsForm)
        {
            string ini_weibo_template_path = string.Concat(cmsForm.app_path, Constants.config_weibo_template_ini + "_");
            string content = UtilFile.read_str(ini_weibo_template_path);
            cmsForm.textBox_weibo_template.Text = content;
            cmsForm.appBean.weibo_template = content;
            return content;
        }

        public static string ini_qq_jiankong_guolv_template_default(CmsForm cmsForm)
        {
            string ini_qq_template_path = string.Concat(cmsForm.app_path, Constants.config_qun_template_ini_guolv + "_");
            string content = UtilFile.read_str(ini_qq_template_path);
            cmsForm.textBox_qun_guolv.Text = content;
            cmsForm.appBean.textBox_qun_guolv = content;
            return content;
        }

        public static string ini_qq_jiankong_del_template_default(CmsForm cmsForm)
        {
            string ini_qq_template_path = string.Concat(cmsForm.app_path, Constants.config_qun_template_ini_del + "_");
            string content = UtilFile.read_str(ini_qq_template_path);
            cmsForm.textBox_qun_del.Text = content;
            cmsForm.appBean.textBox_qun_del = content;
            return content;
        }


        public static string ini_taoke_cookie(CmsForm cmsForm)
        {
            string ini_taoke_cookie_path = string.Concat(cmsForm.app_path, Constants.config_taoke_cookie);
            string content = UtilFile.read_str(ini_taoke_cookie_path);
            cmsForm.appBean.taoke_cookie = content;
            return content;
        }
        public static void save_taoke_cookie(CmsForm cmsForm)
        {
            string ini_taoke_cookie_path = string.Concat(cmsForm.app_path, Constants.config_taoke_cookie);
            string content = cmsForm.appBean.taoke_cookie;
            UtilFile.write(ini_taoke_cookie_path, content);
        }

    }
}
