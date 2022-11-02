# BulkNameChanger
This tool is made for my personal use and if it is useful to someone good luck


Things to change if you don't use this program for videos(.mp4)

## Program.cs:<br />
***Line 13** -> allFiles = Directory.GetFiles(dir, "*.**mp4**", SearchOption.TopDirectoryOnly); //Fetch only mp4 files*<br />
***Line 24** -> file.NewFileName = @$"{dir}\{userFileName} {iterationNumber}.**mp4**";*
