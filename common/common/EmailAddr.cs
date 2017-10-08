namespace common
{
    using System;

    [Serializable]
    public class EmailAddr
    {
        public string dispName = "";
        public string email = "";

        public EmailAddr(string string_0, string string_1)
        {
            this.email = string_0;
            this.dispName = string_1;
        }
    }
}

