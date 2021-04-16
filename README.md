# Valheim-Server-Wrapper
Simple WinForms wrapper for Valheim Dedicated Server

Simply compile and run.
Once the program is open, you can go to the settings and define all the server details and folders where the script and world files live. 

Keep track of all the users and see whos currently logged in and for how long.

Feel free to play around with it, this is my first public repo!

Features include:
-Backup world files on every world save
-Auto start the server when program is opened
-See whos currently logged in and for how long
-See all in and outs of users and each timestamp
-See history of last session in the settings dialog of each user
-New users who arent defined will be added as "Unknown(N)", simply edit the user in the settings dialog to identify them
-Clean shutdown of server when application is closed or the "Stop Server" button is pressed
-No accidental input to the console (which was the main reason why I created this wrapper)
