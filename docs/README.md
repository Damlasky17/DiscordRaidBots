# /docs/

Find all docs to using and understanding the source from here.

# Under Construction

### Docs are under construction and I will comment and update docs within the next day or so

# Getting Started Commands:
#### Once the bots have launched and entered your control server, you can use commands like these to control them:

* `>msg [string text]`
* `>join [string invite]`
* `>dmspam [ulong UserID] [string text]`
* `>rmsg [ulong ChannelID] [string text]`
* `>rdmspam [ulong ServerID] [ulong UserID] [string text]`
* `>drmsg [ulong ChannelID] [string text]`
* `>leave [ulong ServerID]`
* `>setgame [string text]`
* `>setstatus [int status]`
* `>leaveallsevers`

#### An explanation of each command:

* `>msg [string text]` - sends a message in the current server
* `>join [string invite]` - joins an invite link
* `>dmspam [ulong UserID] [string text]` - dmspams a user in the current server
* `>rmsg [ulong ChannelID] [string text]` - sends a message to a remote channel
* `>rdmspam [ulong ServerID] [ulong UserID] [string text]` - dmspams a user in a remote server
* `>drmsg [ulong ChannelID] [string text]` - sends a message to a remote channel and recursively deletes it after 300 miliseconds
* `>leave [ulong ServerID]` - leaves a server
* `>setgame [string text]` - sets the bots' game to selected text
* `>setstatus [int status]` - sets the bots' status (1 - 4), between Online, Idle, Do Not Disturb, and Invisible. 
* `>leaveallsevers` - leaves all the servers the bots' are in. Owner only.
