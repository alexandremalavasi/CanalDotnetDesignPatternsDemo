using DemoCanalDotNetDesignPatterns;
using DemoCanalDotNetDesignPatterns.Proxy;

#region Prototype Shallow VS Deep Copy
Customer customer1 = new Customer() { Name = "Customer 1"};
Customer customer2 = customer1;

customer2.Name = "Customer 2";

Console.WriteLine($"Customer 1:{ customer1.Name }");
Console.WriteLine($"Customer 2:{customer2.Name}");

Console.Read();

#endregion

#region Prototype Clone method
//CustomerWithPrototype customerOne = new CustomerWithPrototype() { 
//    Name = "Customer 1", 
//    Address = new Address() { Street = "Address Customer One" } 

//};

//CustomerWithPrototype customerTwo = (CustomerWithPrototype)customerOne.Clone();

//customerTwo.Name = "Customer 2";
//customerTwo.Address.Street = "Address Customer 2";

//Console.WriteLine($"Customer 1:{customerOne.Name}");
//Console.WriteLine($"Address Customer 1:{customerOne.Address.Street}");
//Console.WriteLine($"Customer 2:{customerTwo.Name}");
//Console.WriteLine($"Address Customer 2:{customerTwo.Address.Street}");

//Console.Read();

#endregion

#region Proxy Pattern

//ContentRepositoryProxy contentRepositoryProxy =
//              new ContentRepositoryProxy(DeviceType.Web);

//var contentListForWeb = contentRepositoryProxy.GetContent();

//Console.WriteLine("******Web Device*****");
//Console.WriteLine("Quantidade de notícias: " + contentListForWeb.Count);
//Console.WriteLine("Possui categoria LifeStyle? " + contentListForWeb.Any(x => x.Category == CategoryEnum.Lifestyle));
//Console.WriteLine("Possui publicidade? " + contentListForWeb.Any(x => x.Advertisements.Count > 0));


//contentRepositoryProxy =
//   new ContentRepositoryProxy(DeviceType.Desktop);

//var contentListForDesktop = contentRepositoryProxy.GetContent();
//Console.WriteLine();
//Console.WriteLine("******Desktop Device*****");
//Console.WriteLine("Quantidade de notícias: " + contentListForDesktop.Count);
//Console.WriteLine("Possui categoria LifeStyle? " + contentListForDesktop.Any(x => x.Category == CategoryEnum.Lifestyle));
//Console.WriteLine("Possui publicidade? " + contentListForDesktop.Any(x => x.Advertisements.Count > 0));

//contentRepositoryProxy =
//   new ContentRepositoryProxy(DeviceType.Mobile);

//var contentListForMobile = contentRepositoryProxy.GetContent();

//Console.WriteLine();
//Console.WriteLine("******Mobile Device*****");
//Console.WriteLine("Quantidade de notícias: " + contentListForMobile.Count);
//Console.WriteLine("Possui categoria LifeStyle? " + contentListForMobile.Any(x => x.Category == CategoryEnum.Lifestyle));
//Console.WriteLine("Possui publicidade? " + contentListForMobile.Any(x => x.Advertisements.Count > 0));

//Console.Read();
#endregion
