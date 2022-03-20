//Example c# and d# Discord bot!

using System;
import DSharpPlus;

namespace DiscordBot
{

}
class progam {

static void Main()
{
	MainAsyc().getawaiter().GetResult();
}

	static async Task MainAsyc()
	{
		var discord = new DiscordClient(new DiscordConfiguration())
		{
			Token = "<You're token>",
			TokenType = TokenType.Bot,
			Intents = DiscordIntents.AllUnprivileged,
		};

		var DiscordConfiguration()
		{
			MinimumLogLevel = Microsoft.Extensitions.Logging.LogLevel.Debug,
		};

		var commands = discord.UseCommandsNext(new CommandsNextConfiguration())
		{
			StringPrefixes = new []["prefix"]
		}

		await discord.ConnectAsync()
		await Task.Delay(-1)
	}
}