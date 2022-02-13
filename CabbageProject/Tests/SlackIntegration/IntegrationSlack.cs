using SlackBotMessages;
using SlackBotMessages.Models;

namespace CabbageProject.Tests.SlackIntegration
{
    public class IntegrationSlack
    {
        private static readonly string _webHook = "https://hooks.slack.com/services/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";
        
        public static void WriteIntoSlack(string message)
        {
            var client = new SbmClient(_webHook);

            var msg = new Message(message);

            client.Send(msg);
        }
    }
}
