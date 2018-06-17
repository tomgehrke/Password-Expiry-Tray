# Password-Expiry-Tray

## Project Goals

1. To convert an old utility written in VB.NET to C# and reacquaint myself with changes in Visual Studio.
2. To provide this utility to the public to use or improve upon, either as a whole or by taking advantage of code snippets that could be incorporated into other project.

## Description

Password Expiry Tray (PET) is a small-footprint utility that runs, out of the way, in your system tray. Periodically, it will check the currect status of your password and alert you when your password is about to expire in order to give the user an opportunity to plan the best time for them to do that.

There are a number of configurable options:

* The amount of time between checks. The interval unit is in hours with a check once an hour being the most frequent interval. [Default: 1 hour]
* The period of lead time where the user is notified that a password expiration is coming soon, but there is still plenty of time. [Default: 14 days]
* The interval of time between notifications. For example, you may want users to see that their password is expiring soon once a day during the notification period. [Default: 24 hours]
* The period of lead time where the user is alerted that a password expiration is imminent. [Default: 3 days]
* The interval of time between alerts. For example, you may want users to see that their password is about to expire twice a day during the notification period. [Default: 4 hours]
* A custom action to make available to the user as part of the password changing process. This could be:
** A command line to a script that performs some action
** A URL to a website that manages password changes
** A link to a document that provides password changing instructions
** Whatever you can imagine (within reason)

_NOTE: Password Expiry Tray cannot change user passwords. It does not know the user's current password, nor is there any facility for entering a new password in PET._
