using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LenguageBlazorSignalR.Server.Hubs
{
	public class LenguajeHub : Hub
	{

		public async Task SendMessage()
		{
			await Clients.All.SendAsync("receiveMessage");
		}
	}
}
