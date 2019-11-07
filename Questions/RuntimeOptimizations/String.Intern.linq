<Query Kind="Program" />

void Main()
{
	string s1 = "MyTest"; 
	string s2 = new StringBuilder().Append("My").Append("Test").ToString(); 
	string s3 = string.Intern(s2); 
    Console.WriteLine(string.ReferenceEquals(s1, s2));
    Console.WriteLine(string.ReferenceEquals(s1, s3));	
}