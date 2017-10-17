using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using System;
using System.Threading.Tasks;

namespace ThirdChatBotDemoWithLuis.Dialogs
{
    [LuisModel("Enter Your Luis App Id", "Enter Your Subscription Key")]
    [Serializable]
    public class BasicLuisDialog : LuisDialog<object>
    {  

        [LuisIntent("Greeting")]
        public async Task Greeting(IDialogContext context, LuisResult result)
        {
            context.Call(new GreetingDialog(), Callback);
        }

        private async Task Callback(IDialogContext context, IAwaitable<object> result)
        {
            context.Wait(MessageReceived);
        }

    }
}