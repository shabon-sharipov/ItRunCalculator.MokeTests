using Moq;
using SendMesage_Moke;

namespace SendMessage.Tests
{
    public class SendMessageTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Send_Message_With_EmptyParametr()
        {
            var mock = new Mock<ISendMessage>();
            mock.Setup(x => x.Send(""));
            var sendMessage = new SendMesage(mock.Object);

            Assert.Throws<ArgumentNullException>(() => sendMessage.SendMessage(""));
        }

        [Test]
        public void Send_Message_With_NullParametr()
        {
            var mock = new Mock<ISendMessage>();
            mock.Setup(x => x.Send(""));
            var sendMessage = new SendMesage(mock.Object);

            Assert.Throws<NullReferenceException>(() => sendMessage.SendMessage(null));
        }
    }
}