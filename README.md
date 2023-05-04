# CyberShokeServersParsing
Library to parse cybershoke.net counter-strike servers

Read raw


Documentation:
______________________________________________________________________________________________

CSServers:
This is main class, contains: 
1) Listmodes - List of online servers modes (without whitespaces)
2) Modes - List of Mode objects
3) Functions to get mode you need

______________________________________________________________________________________________

```
Server:
Class with information of choosen server

propreties:
______________________________________________________________________________________________
type              |  property name        |    description                                   |
__________________|_______________________|__________________________________________________|
integer           |  id                   |    cybershoke id of this server                  |
string            |  name_alt             |    name of server                                |
string            |  ip                   |    address of server                             |
integer           |  port                 |    port of server                                |
string            |  mode/modeAlt         |    server mode, alt version contains whitespaces |
integer           |  num                  |    server number                                 |
string            |  location             |    server hosting                                |
string            |  country              |    server country                                |
string            |  map                  |    map name                                      |
boolean           |  prime                |    prime mode                                    |
integer           |  players              |    number of players on the server               |
integer           |  maxplayers           |    maximum number of players on the server       |
string            |  status               |    Online/Offline status of server               |
integer           |  faceit_avg           |    average faceit elo, 0 by default              |
boolean           |  show_maps_avg_time   |    if true time_avg_complete exists              |
integer           |  statusAlt            |    if false - server online (not exactly)        |
string            |  category             |    server category                               |
nullable integer  |  time_avg_complete    |    average complete of round time (not exactly)  |
boolean           |  faceit_limiter_enable|    true if elo limiter if enable                 |
nullable integer  |  faceit_min_elo       |    minimum elo you need to connect server        |
nullable integer  |  faceit_max_elo       |    the maximum elo with which you can log        |
                  |                       |    on to the server                              |
__________________|_______________________|__________________________________________________|


______________________________________________________________________________________________

Mode:
A class containing a more detailed description of the mode.

propreties:
______________________________________________________________________________________________
type              |  property name        |    description                                   |
__________________|_______________________|__________________________________________________|
string            |  name                 |    mode name (with whitespaces)                  |
integer           |  servers              |    number of servers                             |
integer           |  players              |    number of players online                      |
integer           |  maxplayers           |    maxumum players can be online                 |
boolean           |  prime                |    true if has prime servers                     |
boolean           |  noprime              |    true if has non-prime servers                 |
string            |  type                 |    mode type                                     |
string            |  releaseDate          |    release date (usually null)                   |
Title             |  title                |    title of mode                                 |
Description       |  description          |    description of mode                           |
__________________|_______________________|__________________________________________________|


______________________________________________________________________________________________

Title:
Title of mode.

propreties:
______________________________________________________________________________________________
type              |  property name        |    description                                   |
__________________|_______________________|__________________________________________________|
string            |  ru                   |    russian title                                 |
string            |  en                   |    english title                                 |
__________________|_______________________|__________________________________________________|


______________________________________________________________________________________________

Description:
Descsription of mode.

properties:
______________________________________________________________________________________________
type              |  property name        |    description                                   |
__________________|_______________________|__________________________________________________|
string            |  ru                   |    russian description                           |
string            |  en                   |    english description                           |
__________________|_______________________|__________________________________________________|


______________________________________________________________________________________________

Functions:
Functions returns tuple of IList<Server> if mode has different categories or just IList<Server> if not.
```
