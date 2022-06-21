using AngleSharp;

var config = Configuration.Default.WithDefaultLoader();
var address = "https://trudvsem.ru/opendata/datasets";
var context = BrowsingContext.New(config);
var document = await context.OpenAsync(address);
var linkSelector = "#dataset-10 .table__wrapper .link";
var link = document.QuerySelector(linkSelector);

Console.WriteLine("Href shouldn't be null:");
Console.WriteLine(link?.GetAttribute("href"));