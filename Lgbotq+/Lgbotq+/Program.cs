using System;
using TweetSharp;
using System.Timers;
using System.Collections.Generic;

namespace Lgbotq_
{
    class Program
    {

        private static string customer_key = "ZDaj67rbCIiziBPBT77g5VPTy";
        private static string customer_key_secret = "mXhchGdiyNWQItl0bHsSuyPdVHXfkaNqOZ8da2BVnH6JJAyz4c";
        private static string access_token = "1460007607410774022-yoIwgyGOhj2LOJr6dM7BMxMRoxKe6K";
        private static string access_token_secret = "XbF5qcEQFIFQTxtwKdAKKo482i532alaJS3TfqHjaEl0M";


        private static TwitterService service = new TwitterService(customer_key, customer_key_secret, access_token, access_token_secret);
        

        static void Main(string[] args)
        {
            Console.WriteLine($"<{DateTime.Now}> - Bot is ready :D");
            SendTweet("BE GAY DO CRIME");
            SendTweet("sex");
            Console.Read();
        }
        private static void SendTweet(string _status)
        {
            _ = service.SendTweet(new SendTweetOptions { Status = _status }, (tweet, response) =>
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"<{DateTime.Now}> - Tweet Sent");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"<ERROR MATE>" + response.Error.Message + response.Error.RawSource + response.Error.Code);
                        Console.ResetColor();
                    }
                });
        }
     
    }


}
