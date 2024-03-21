// See https://aka.ms/new-console-template for more information
using LAB1TREE;

Console.WriteLine("Hello, World!");
Tree Tree = new Tree(1);
Tree.SetLink(new Tree(2));
Tree.SetLink(new Tree(3, new Tree(6)));
Tree.SetLink(new Tree(4));
Tree.SetLink(new Tree(5));
Tree Tree1 = new Tree(7, Tree);
Tree1.SetLink(Tree);

int[] arr = Tree1.GetChildArray();
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}