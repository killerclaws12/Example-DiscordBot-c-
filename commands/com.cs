// Ping command

using System
using System.Collections.Generic
using System.Linq
using System.Text
using System.Threading.Tasks

namespace DiscordBot.commands
{
	public class com : BaseCommandMobile
	{
		[Command("ping")]
		public async Trask ping(CommandContext ctx)
		{
			await ctx.RespondAsync("pong")
		}
	}
}