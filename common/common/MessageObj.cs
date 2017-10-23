namespace common
{
    using System;
    using System.Collections;

    [Serializable]
    public class MessageObj
    {
        public ArrayList arrayList_0 = new ArrayList();
        public ArrayList arrayList_1 = new ArrayList();
        public ArrayList arrayList_2 = new ArrayList();
        public ArrayList attachFileList = new ArrayList();
        public string body = "";
        public EmailAcc emailAcc_0 = new EmailAcc("", "");
        public EmailAddr from = new EmailAddr("", "");
        public string subject = "";
    }
}

