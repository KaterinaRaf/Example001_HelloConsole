// Просмотр директории папок с помощью рекурсии

/*   *** просмотр одной папки ****
string path = "D:/картинки";  // ставим слеш в другую сторону
DirectoryInfo di = new DirectoryInfo(path);  
Console.WriteLine(di.CreationTime);   // время создания папки
FileInfo[] fi = di.GetFiles();  // показывает все файлы, что находятся в папке

for (int i = 0; i < fi.Length; i++)
{
    Console.WriteLine(fi[i].Name);
}
*/



void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path); 

    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
{
    Console.WriteLine($"{indent}{catalogs[i].Name}");
    CatalogInfo(catalogs[i].FullName, indent + "  ");
}

    FileInfo[] files = catalog.GetFiles();

    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}

string path = "D:/картинки"; 
CatalogInfo(path);