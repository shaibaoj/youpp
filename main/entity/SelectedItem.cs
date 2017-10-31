using System;

namespace haopintui
{ 
    public class SelectedItem
    {
        private object id = "";
        private object value = null;
        private string label = "";

        public string getLabel()
        {
            return this.label;
        }

        public void setLabel(string label)
        {
            this.label = label;
        }

        public object getId()
        {
            return this.id;
        }

        public void setId(object id)
        {
            this.id = id;
        }

        public object getValue()
        {
            return this.value;
        }

        public void setValue(object value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return this.label;
        }
    }

}

