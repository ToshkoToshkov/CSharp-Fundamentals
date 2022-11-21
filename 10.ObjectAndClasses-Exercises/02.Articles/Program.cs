using _02.Articles;

string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
int numOfCommands = int.Parse(Console.ReadLine());

string title = input[0];
string content = input[1];
string author = input[2];

Article article = new Article(title, content, author);

for (int i = 0; i < numOfCommands; i++)
{
    string[] command = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries);

    string cmd = command[0];
    string newContent = command[1];

    if (cmd == "Edit")
    {
        article.Edit(newContent);
    }
    else if (cmd == "ChangeAuthor")
    {
        article.ChangeAuthor(newContent);
    }
    else if (cmd == "Rename")
    {
        article.Rename(newContent);
    }
}

Console.WriteLine(article.ToString().Trim());
