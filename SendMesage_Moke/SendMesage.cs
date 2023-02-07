using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendMesage_Moke
{
    public class SendMesage
    {
        private readonly ISendMessage _sendMessage;

        public SendMesage(ISendMessage sendMessage)
        {
            _sendMessage = sendMessage;
        }

        public void SendMessage(string message)
        {
            if (message is null)
                throw new NullReferenceException();
            if (message == "")
                throw new ArgumentNullException();

            _sendMessage.Send(message);
        }
    }


    public interface ISendMessage
    {
        void Send(string message);
    }
}
