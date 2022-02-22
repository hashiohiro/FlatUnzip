using System.IO.Compression;

if (args.Length != 2)
{
    Console.WriteLine("Usage : FlatUnzip.exe [SrcFolder] [DistFolder]");
    Environment.Exit(1);
}

var src = new DirectoryInfo(args[0]);
var dist = new DirectoryInfo(args[1]);
if (!dist.Exists)
{
    dist.Create();
}

var zipFiles = src.GetFiles("*.zip", SearchOption.AllDirectories);

foreach (var each in zipFiles)
    ZipFile.ExtractToDirectory(each.FullName, dist.FullName);