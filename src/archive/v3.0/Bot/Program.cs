using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Discord;
using Discord.Commands;
using Discord.Legacy;
using System.IO;
using Newtonsoft.Json;

namespace Bot
{
    class Program
    {
        ulong[] whitelist;
        string[] token;
        string config;
        ulong owner;
        string defaultDiscord;
       
        ulong[] whitelisted =
        {
        };


        // THIS CODE IS VERY BADLY WRITTEN AND I PLAN ON REWRITING THIS CODE TO BE LIKE 10x BETTER!
        // EXPECT AN UPDATE WITHIN THE NEXT WEEK!

        // I WILL COMMENT THE CODE TOO




        static void Main(string[] args)
        {
           
            try
            {
                
              new Program().init();
                
            }
            catch
            {

            }
        }
        

        void init()
        {
            token = File.ReadAllLines("token.txt");
            config = File.ReadAllText("config.json");

            configObject configInfo = JsonConvert.DeserializeObject<configObject>(config);

            owner = Convert.ToUInt64(configInfo.owner_snowflake);
            defaultDiscord = configInfo.invite_code;

            getSnowflake();
            Start();
        }

        void getSnowflake()
        {
            List<ulong> snowflakes = new List<ulong>();

            string[] ids = File.ReadAllLines("snowflake.txt");

            foreach (String x in ids)
            {
                try
                {
                    ulong localID = Convert.ToUInt64(x);
                    snowflakes.Add(localID);
                }
                catch
                {

                }
            }

            whitelist = snowflakes.ToArray();
            whitelisted = whitelist; // I am too lazy to do this
        }


        public class configObject
        {
            public int owner_snowflake { get; set; }
            public string invite_code { get; set; }
        }

        public void Start()
        { 
            DiscordClient[] client = new DiscordClient[token.Length];
            for (int j = 0; j < client.Length; j++)
            {
                var i = j;
                new Thread(() =>
                {
                    client[i] = new DiscordClient(x =>
                    {
                        Console.WriteLine("Started " + i + ".");
                        x.LogLevel = LogSeverity.Info;
                    });

                    client[i].Log.Message += (s, e) => Console.WriteLine($"[{e.Severity}] {e.Source}: {e.Message}");

                    client[i].UsingCommands(x =>
                    {
                        x.PrefixChar = '>';
                        x.AllowMentionPrefix = true;
                    });

                    client[i].GetService<CommandService>().CreateCommand("join")
                        .Parameter("id", ParameterType.Required)
                        .Do(async (e) =>
                        {
                            foreach (ulong b in whitelisted)
                            {
                                if (e.User.Id == b)
                                {
                                    await client[i].AcceptInvite(await client[i].GetInvite(e.GetArg("id")));
                                } else
                                {

                                }
                            }    
                        });

                    client[i].GetService<CommandService>().CreateCommand("rmsg")
                        .Parameter("id", ParameterType.Required)
                        .Parameter("msg", ParameterType.Unparsed)
                        .Do(async (e) =>
                        {

                            foreach (ulong b in whitelisted)
                            {
                                if (e.User.Id == b)
                                {
                                    try
                                    {
                                        ulong id = Convert.ToUInt64(e.GetArg("id"));
                                        Channel x = client[i].GetChannel(id);
                                        await x.SendMessage(e.GetArg("msg"));
                                    }
                                    catch
                                    {

                                    }
                                }
                                else
                                {
                                }
                            }
                        });
                    client[i].GetService<CommandService>().CreateCommand("drmsg")
                .Parameter("id", ParameterType.Required)
                .Parameter("msg", ParameterType.Unparsed)
                .Do(async (e) =>
                {

                    foreach (ulong b in whitelisted)
                    {
                        if (e.User.Id == b)
                        {
                            try
                            {
                                ulong id = Convert.ToUInt64(e.GetArg("id"));
                                Channel x = client[i].GetChannel(id);
                                Message m = await x.SendMessage(e.GetArg("msg"));
                                await Task.Delay(300);
                                await m.Delete();
                            }
                            catch
                            {

                            }
                        }
                        else
                        {
                        }
                    }
                });


                    client[i].GetService<CommandService>().CreateCommand("msg")
                        .Parameter("msg", ParameterType.Unparsed)
                        .Do(async (e) =>
                        {
                            foreach (ulong b in whitelisted)
                            {
                                if (e.User.Id == b)
                                {
                                    await e.Channel.SendMessage(e.GetArg("msg"));
                                }
                                else {
                                }
                            }
                            
                        });

                    client[i].GetService<CommandService>().CreateCommand("leave")
                    .Parameter("id", ParameterType.Required)
                        .Do(async (e) =>
                        {
                            foreach (ulong b in whitelisted)
                            {
                                if (e.User.Id == b)
                                {
                                    try
                                    {
                                        Server x = client[i].GetServer(Convert.ToUInt64(e.GetArg("id")));
                                        await x.Leave();
                                    }
                                    catch
                                    {

                                    }
                                }
                                else {
                                }
                            }
                        });
                    client[i].GetService<CommandService>().CreateCommand("dmspam")
                       .Parameter("id", ParameterType.Required)
                       .Parameter("msg", ParameterType.Unparsed)
                       .Do(async (e) =>
                       {
                          string id2 = e.GetArg("id");
                           ulong id = Convert.ToUInt64(id2);
                           User u = e.Server.GetUser(id);
                           await u.SendMessage(e.GetArg("msg"));
                       });
                    client[i].GetService<CommandService>().CreateCommand("rdmspam")
                 .Parameter("id", ParameterType.Required)
                 .Parameter("uid", ParameterType.Required)
                 .Parameter("msg", ParameterType.Unparsed)
                 .Do(async (e) =>
                 {
                     string id2 = e.GetArg("uid");
                     ulong id = Convert.ToUInt64(id2);
                     string id3 = e.GetArg("id");
                     ulong id4 = Convert.ToUInt64(id3);
                     Server x = client[i].GetServer(id4);
                     User u = x.GetUser(id);
                     await u.SendMessage(e.GetArg("msg"));
                 });


                    client[i].GetService<CommandService>().CreateCommand("leaveallservers")
                        .Do(async (e) =>
                        {
                            if(e.User.Id == owner)
                            {
                                    foreach (Server t in client[i].Servers)
                                    {
                                       await t.Leave();
                                    }
                                 //  await client[i].AcceptInvite(await client[i].GetInvite(defaultDiscord));
                                }
                                else
                                {
                                }
                            
                        });
                   
                    client[i].GetService<CommandService>().CreateCommand("setgame")
                    .Parameter("txt", ParameterType.Unparsed)
                        .Do((e) =>
                        {
                            bool xyxx = true;
                            if (xyxx == true)
                            {
                                client[i].SetGame(e.GetArg("txt"));
                            }

                        });

                    client[i].GetService<CommandService>().CreateCommand("setstatus")
                       .Parameter("id", ParameterType.Required)
                       .Do((e) =>
                       {
                           bool xyy = true;
                           if (xyy == true)
                           {
                               string id = e.GetArg("id");
                               if (id == "1")
                               {
                                   client[i].SetStatus(UserStatus.Online);
                               }
                               else if (id == "2")
                               {
                                   client[i].SetStatus(UserStatus.Idle);
                               }
                               else if (id == "4")
                               {
                                   client[i].SetStatus(UserStatus.Invisible);
                               }
                               else if (id == "3")
                               {
                                   client[i].SetStatus(UserStatus.DoNotDisturb);
                               }
                           }
                       });


                    client[i].ExecuteAndWait(async () =>
                        {
                            try
                            {
                                await client[i].Connect(token[i], TokenType.User);
                                client[i].AcceptInvite(await client[i].GetInvite(defaultDiscord));
                            }
                            catch
                            {

                            }
                        });

                }).Start();
            }
        }

        private void Program_MessageReceived(object sender, MessageEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
