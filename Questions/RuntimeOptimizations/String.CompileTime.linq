<Query Kind="Program" />

private static string Global = "Hello world";
void Main()
{
    string s1 = "Hello world";
    string s2 = "Hello";
    string s3 = s2 + " world";
    Console.WriteLine(string.ReferenceEquals(s1, Global));
    Console.WriteLine(string.ReferenceEquals(s1, s3));
}