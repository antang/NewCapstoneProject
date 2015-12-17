using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace myStruct
{
    [Serializable()]
    public class Structure: ISerializable
    {
        private string _textChat;

        public Structure()
        {
            this.TextChat = null;
        }
        public Structure(string text)
        {
            this.TextChat = text;
        }
        public Structure(Structure str)
        {
            this.TextChat = str.TextChat;
        }
        public void GetObjectData(SerializationInfo info, StreamingContext strcxt)
        {
            info.AddValue("text", this.TextChat);
        }
        public Structure(SerializationInfo info, StreamingContext strcxt)
        {
            this.TextChat = (string)info.GetValue("text", typeof(string));
        }
        public string TextChat
        {
            get { return _textChat; }
            set { _textChat = value; }
        }
    }
}
