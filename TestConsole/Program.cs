using SingletonPattern;



#region BuilderPattern


//using BuilderPattern.Method1;

//var eb = new EndPointBuilder("https://localhost");
//eb.Append("api")
//    .Append("v1")
//    .Append("user")
//    .AppendParams("id", "5")
//    .AppendParams("username", "Teymur");

//var url = eb.Build();

////Console.WriteLine(url);

//EmployeeBuilderM1 empBuilder = new();
//var employee= empBuilder
//    .SetEmailAdress("tt@mail.com")
//    .SetUsername("Tete")
//    .BuildEmployee();

//Console.WriteLine(employee);


#endregion

#region DecoratorPattern

//BIr metodun isleme cercivesini boyutmek 
// Decorator Pattern istifade ederek bir base calsin metodunun ondan toreyen herbir 
//classlarda override olunaraq ferqli meqsedlerde istifade olunmasidir,Eslinde cox istifade etdiyimiz ama az bildiyimiz
//bir design patterndir



#endregion

#region SingletonPattern

//Avantajlar
//Ensure single instance-Bir obyekt cemi bir defe yaranir 
//Globally accsess - bu obyekte proyektin her terefinden elimiz catir
//Created only when requested-- ancaq istifade lazim olan anda yaranir yeni onceden yaranb memoryde qalmir


//Dezavantaj
//Unit test yazmaqi cetinlesdiri
//Multi thread zamani problem yaranir her tread yeni obyekt isteyerse




//var countryProvider = new CountryProvider();

//Artiq burda dyirem ki 
//CountryProvider.Instance.GetCountries();


//Console.WriteLine(DateTime.Now.ToLongTimeString());

//var countries =await CountryProvider.Instance.GetCountries();

//countries.ForEach(country =>
//{
//    Console.WriteLine(country.Name);
//});

//Bu hisseni bask aservis kimi dusunsey bu metod 2 saniye vaxt erzinde datalari geditiri dbdan eni obyekt yaratsam eger yene iki saniye gozleyecem 4 saniye 
//vaxt malliyeti olur

//BU PRoblemi hell etmek ucun sirf singleton Patternden istifade olunur
//Ele etmeliyik ki bu obyektden ne zaman yaradarsam yaranmis kohne obyekti versin bize

//var countryProvider1 = new CountryProvider();  ----BUra xeta verecek
//var countries1 = await CountryProvider.Instance.GetCountries();

//Console.WriteLine(DateTime.Now.ToLongTimeString());

#endregion

#region AdapterPattern




#endregion