using BulkNameChanger;

Console.WriteLine("BulkNameChanger");
Console.WriteLine("directory path:");

string dir = Console.ReadLine();
string userFileName;
string[] allFiles;
int iterationNumber;

if (dir != null)
{
    allFiles = Directory.GetFiles(dir, "*.mp4", SearchOption.TopDirectoryOnly); //Fetch only mp4 files

    Console.Write("\niteration starts from: ");
    iterationNumber = Convert.ToInt32(Console.ReadLine());
    Console.Write("what do you want your videos to be named?: ");
    userFileName = Console.ReadLine();

    foreach (string item in allFiles)
    {
        FileRename file = new FileRename();
        file.OldFileName = item;
        file.NewFileName = @$"{dir}\{userFileName} {iterationNumber}.mp4";
        file.CheckFileExist();
        iterationNumber++;
        Console.WriteLine(file.NewFileName);
    }
} 
else
{
    Console.WriteLine("path directory required!");
}
