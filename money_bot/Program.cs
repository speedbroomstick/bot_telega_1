using System;
using System.Collections.Generic;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.ReplyMarkups;

namespace money_bot
{
    class Program
    {
        private static TelegramBotClient client;

        static void Main(string[] args)
        {
            client = new TelegramBotClient("5562799797:AAF-KC1dtROvrzgsVR4aYHbQOj-xPWjo0Sk");
            client.StartReceiving();
            client.OnMessage += OnMessageHandler;
            Console.ReadLine();
            client.StopReceiving();
        }

        private static async void OnMessageHandler(object sender, MessageEventArgs e)
        {
            var msg = e.Message;
            if (msg.Text != null)
            {
                Console.WriteLine($"Пришло сообщение с текстом: {msg.Text}");
             await client.SendTextMessageAsync(msg.Chat.Id, "хорошее сообщение");
                }
            }
        }
    }
