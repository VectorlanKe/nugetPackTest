// See https://aka.ms/new-console-template for more information
using DemoPack;

XmlPack xmlPack = new XmlPack()
{
    MyProperty=1
};
Console.WriteLine($"Hello, World! {xmlPack.MyProperty}");
