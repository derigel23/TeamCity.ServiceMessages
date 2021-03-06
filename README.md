TeamCity.ServiceMessages .NET library. 
======================================

This library provides read/write access to TeamCity Service messages.
Take a look at the description of service messages at 
http://confluence.jetbrains.net/display/TCD7/Build+Script+Interaction+with+TeamCity#BuildScriptInteractionwithTeamCity-ServiceMessages


Usage:
======

Most use cases are covered in tests.

To create service message use: 

	JetBrains.TeamCity.ServiceMessages.Write.ServiceMessageFormatter.FormatMessage
	
To parse service messages use: 

	JetBrains.TeamCity.ServiceMessages.Read.ServiceMessageParser.ParseServiceMessages

There is an API to generate TeamCity specific service messages, use: 

	JetBrains.TeamCity.ServiceMessages.Write.Special.ITeamCityWriter
	
to get the instance of the object create an instance of the factory and get it by:

	new JetBrains.TeamCity.ServiceMessages.Write.Special.TeamCityServiceMessages().CreateWriter()


Install:
========

Use NuGet to download latest version of the library. 

	NuGet Install TeamCity.ServiceMessages


Misc:
=====

I use TeamCity to compile and publish my package:
http://teamcity.jetbrains.com/viewType.html?buildTypeId=bt426


License:
========
Apache 2.0. 
See LICENSE.txt.
