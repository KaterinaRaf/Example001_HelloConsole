﻿// Обход математических формул и уравнений через рекурсию

string emp = String.Empty;
string[] tree = {emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3"};

void InOrderTraversal(int pos = 1)
{
    if (pos < tree.Length)
    {
        int left = 2 * pos;
        int rigth = 2 * pos + 1;
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
        Console.WriteLine(tree[pos]);
        if (rigth < tree.Length && !String.IsNullOrEmpty(tree[rigth])) InOrderTraversal(rigth);
    }
}

InOrderTraversal();
