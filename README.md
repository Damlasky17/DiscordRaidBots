# DiscordRaidBots
Discord chat server raiding spam bots, used to spam servers and raid them with all sorts of stuff, maybe even to ratelimit other bots.

Discord is a free chatting app for gamers and others alike, similar to other well known apps such as Skype, TeamSpeak, and Curse. Discord is unique with self server hosting, voice chat, and combines the features of all apps into one and makes them faster. Discord to me is a personal favorite app! I use it every day and has changed my life forever, I've met so many new friends on discord.

**Discord has an API for creating bots that can moderate Discord servers and Discord users alike, and there are limits to how this API is used called the API Terms of Service. This application does abuse the Discord API and should not be used directly. This was created for educational purposes only.**

If your someone I know and I haven't added your name to this list or server list, don't hate me for it :frowning:, I just forgot, just dm me or something about it. (excuse my grammer and spelling please).

# Message to Discord Staff

### Thank you for making Discord. Discord has permanently changed my life since day 1. Ever since I discovered discord, I found new friends, new people, new **life**, that changed who I am and how I live. I found my closest friends on Discord and I can't thank you enough for makng this amazing app. I've gotten so much help to get to where I am now. Thank you Discord Inc. (This letter continues [here](https://github.com/ejectedmatrix/DiscordRaidBots/blob/master/docs/message_to_discord.md)).


**Please don't terminate me for creating and releasing code, I just want to help the community out. I know there are dark sides to Discord, and that information isn't something I will release, unless I get terminated or IP banned. I'm working with Vexxed (youtuber that exposed Trap Nation) and he's willing to expose the company for some wrongdoings, So I'll give this to you as a deal.**

**_So just be warned_ :stuck_out_tongue:. _I want to get on your good side, not bad side._**

# Getting Started

To use the raid bots, go into **`/build/`** folder and find the latest version number, download **`build.zip`** from there, extract to a folder and edit `config.json` to meet your specified needs.

In `config.json` you are going to find 2 peices of JSON data, **invite-code** and **owner-snowflake.**

1. **invite-code:** The invite code to join on launch (the bots' hub, essentially).
2. **owner-snowflake:** The snowflake (userID) of the owner. Used to provide admin only commands to the owner.

Within the same folder, you should find `token.txt` and `snowflake.txt`:

1. **token.txt:** The text file in which bot or user tokens are placed in.
2. **snowflake.txt:** The text file in which the snowflake(s) of the people who are whitelisted to use the bot's commands.

Snowflakes and tokens need to be formatted in a certain way that can be found [here.](https://github.com/ejectedmatrix/DiscordRaidBots/blob/master/docs/format.md)

Commands and the rest of the docs can be found [here.](https://github.com/ejectedmatrix/DiscordRaidBots/blob/master/docs/README.md)

# For Developers

If you would like to commit or modify the source, feel free to do so! Please be sure to contact me when you do so becuase I'd love to hear about what you did!

To those out there who are looking at the source: I hope you have a great time learning about C# and what you can do with it.

Discord raid bots were coded in C# using the Discord.NET wrapper for the Discord API created by RougeExcepetion and some credit to foxbot.

(The wrapper can be found [here](https://github.com/RogueException/Discord.Net) or on NuGet as **Discord.NET** _(from the package manager console._))

# Credits

Neura - writing the very core with me, and sticking with me until the end, a core man of the project. @NeuraFTW

HotShot - The idea of remote messages and remote controls, DM spamming, being a really good friend, and giving me the idea of creating a web panel to control it.

Singular - Helping create many accounts for testing and supporting the web panel.

Mvulcan - Supporting the creation of testing accounts and web panel support plus a few small tips.

Proto - Helping me write a better parsing system and optimizing the code, (version was scratched after some problems started occur).

Lyon - Helping me write a server whitelist (prevent certain servers from being raided).

Moh - One of the greatest friends ever! Has always been there for me at all times, even when times were hard!! I can't stop thanking him enough.

Logan - One of my C# students that excelled far is certain things, my own student helped me with Discord.NET and C# here and there. I am very proud of you and hope you get a great job as a programmer. 

Aaron and Jet - **`"It's time to stop."`**, helping me realize I need to stop raiding.

clv - I honestly wanted to put your name here because I honestly just look upto you as you create discord bots, your sources are amazing and I hope to continue working with you.

Mudock Yatho -  A great discord bot person, one of the coolest selfbots I've ever seen, and an **absolute** expert at lua. Great friend and overall great at acting like a retard. Hiliarious at times. 

Martmists - For helping me learn about web api's and learn about /ack. 

Users from the Discord API server - Helping me with problems that occured along the way.

Discord Developers - Thank you for making discord. For creating the user/bot API; For helping out in certain areas, and telling me **`"It's time to stop"`**.

### Tips
Don't get caught, don't raid a server that I know of either:

Especially don't raid the server of my senpai's::

* Dyno server
* LFG server
* /r/LoveLive
* /r/Overwatch
* /r/RocketLeague
* /r/WatchDogs
* Discord Guide
* Discord Testers
* Discord Developers
* Discord API
* Discord Linux
* Discord Game Nights
* Elysian Empire
* Rain
* /r/islam
* NGNL
* HH Server
* The Portal
* Vexxed
* The Coding Den
* /r/HappyWars
* Keen Software House
* Raidforums
* Martmists
* Sumonex
* any server that is owned by a rain member (Octillion, Customality, Louka, and 3dsboy08 are an exception)

If your caught, well, rip you. Don't raid those places, I am friends with the owners' of many of them and I'm sure you wouldn't like your server getting spammed either.

You shouldn't raid in the first place.

# License

I'm releasing this under the GNU Public License 3.0 because of a few personal reasons.

All the code that is public is meant to be for educational purposes only and I hope it helps you all. I have included some core features of C# in the code, such as enumerables, Lists, arrays, methods, classes, libraries, wrappers, JSON, and many other cool things that should be useful to everyone who is trying to learn.

>The GNU General Public License is a free, copyleft license for software and other kinds of works.
>
>The licenses for most software and other practical works are designed to take away your freedom to share and change the works. By contrast, the GNU General Public License is intended to guarantee your freedom to share and change all versions of a program--to make sure it remains free software for all its users. We, the Free Software Foundation, use the GNU General Public License for most of our software; it applies also to any other work released this way by its authors. You can apply it to your programs, too.
>
>When we speak of free software, we are referring to freedom, not price. Our General Public Licenses are designed to make sure that you have the freedom to distribute copies of free software (and charge for them if you wish), that you receive source code or can get it if you want it, that you can change the software or use pieces of it in new free programs, and that you know you can do these things.

More information can be found on the GNU Public License 3.0 at [**/LICENSE**](https://github.com/ejectedmatrix/DiscordRaidBots/blob/master/LICENSE)
