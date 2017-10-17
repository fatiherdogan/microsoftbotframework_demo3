using Microsoft.Bot.Builder.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.Luis;

namespace ThirdChatBotDemoWithLuis.Dialogs
{
   
    [Serializable]
    public class GreetingDialog : IDialog<object>
    {
        public async Task StartAsync(IDialogContext context)
        {
            context.Wait(MessageReceivedAsync);
        }

        private async Task MessageReceivedAsync(IDialogContext context, IAwaitable<object> result)
        {
            var act = await result as Activity;
            var message = act.Text.ToLower();
            await context.PostAsync("Selam");
            context.Wait(MessageReceivedAsync);
        }
    }
}