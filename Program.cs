/*
int n = 0;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}
FindWords("aisiv", new char[2]);
*/
/*
string path = "C:/Users/constantin.cutureanu/OneDrive/Документы/C#/Lesson7/Lesson7_Lesson";
DirectoryInfo d1 = new DirectoryInfo(path);
Console.WriteLine(d1.CreationTime);

void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }
}
FileInfo[] f1 = d1.GetFiles();
for (int i = 0; i < f1.Length; i++)
    Console.WriteLine(f1[i].Name);
Console.WriteLine();
CatalogInfo(path);
*/
/*
void Towers(string with = "1", string on = "3", string some = "2", int count = 4)
{
    if (count > 1) Towers(with, some, on, count - 1);
    System.Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}
Towers();
*/
/*
string emp = String.Empty;
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
void InOrederTraversal(int pos = 1)
{
    if (pos < tree.Length)
    {
        int left = 2 * pos;
        int right = 2 * pos + 1;
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrederTraversal(left);
        System.Console.WriteLine(tree[pos]);
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrederTraversal(right);
    }
}
InOrederTraversal();
*/
// чтобы поломать программу
/*
int i=0;
void Rec()
{
    System.Console.WriteLine(i++);
    Rec();
}
Rec();
*/