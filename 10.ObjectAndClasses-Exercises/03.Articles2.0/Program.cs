using _02.Articles;

int numOfArticles = int.Parse(Console.ReadLine());

List<Article> articles = new List<Article>();

for (int i = 0; i < numOfArticles; i++)
{
    string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

    string title = input[0];
    string content = input[1];
    string author = input[2];

    Article article = new Article(title, content, author);
    articles.Add(article);

    
}

string wordToOrder = Console.ReadLine();

List<Article> orderedArticles = new List<Article>();

if (wordToOrder == "title")
{
    orderedArticles = articles.OrderBy(x => x.Title).ToList();
}
else if (wordToOrder == "content")
{
    orderedArticles = articles.OrderBy(x => x.Content).ToList();
}
else if (wordToOrder == "author")
{
    orderedArticles = articles.OrderBy(x => x.Author).ToList();
}

foreach (var item in orderedArticles)
{
    Console.WriteLine(item.ToString()); 
}