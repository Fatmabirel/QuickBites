using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.SignalR;

namespace WebAPI.Hubs
{
    public class SignalRHub : Hub
    {
        QuickBitesContext context = new QuickBitesContext();
        public async Task SendCategoryCount()
        {
            var value = context.Categories.Count();
            await Clients.All.SendAsync("ReceiveCategoryCount", value);
        }
    }
}
