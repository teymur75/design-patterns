using AdapterPattern;
using AdapterPattern.Json.Adapters;
using AdapterPattern.Xml.Adapters;
using SingletonPattern;
using StrategyPattern.Attacks;
using StrategyPattern.Character;
using StrategyPattern.Real;



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

//Uygunlasdirma Patternidir


//TransferTransaction transc = new() { Amount = 0 ,FromIban="1",ToIban="2"};
//JsonBankApiAdapter jsAdapter = new();
//XmlBankApiAdapter xmlAdapter = new();
//var result=xmlAdapter.ExecuteTransaction(transc);
//Console.WriteLine(result);
//Console.ReadLine();


#endregion

#region StrategyPattern

//BIr model yaradanda onun istifade edceyistrategiyalari degise bilirik se bu patterne strategy pattern deyirik
//Var olan strategiyani gedisatda deyismek

//var ch = new Character(new AggresiveCOmbatStrategy());
//ch.ApplyAttactStrategy();

//ch.SetCombat(new DefensiveCOmbatStrategy());
//ch.ApplyAttactStrategy();

//var paymentOpt = new PaymentInfo()
//{
//    CardHolderName = "Teymur Rahimli",
//    CardNumber = "12345",
//    CVV = "133",
//    Amount = 100,
//    ExpirationDate = "09/25"
//};

//var service = new PaymentService();

//do
//{
//    Console.WriteLine("Bank Secin : 1-Kaptital,2-Abb,3-Leo");
//    var bank=Console.ReadLine();

//    IPaymentService paymentService = null;

//    switch (bank)
//    {
//        case "1":
//            paymentService = new KapitalBank();
//            break; 
//        case "2":
//            paymentService = new Abb();
//            break; 
//        case "3":
//            paymentService = new LeoBank();
//            break;
//        default:
//            Console.WriteLine("Duzgun sec");
//            break;
//    }

//    service.SetPAyment(paymentService);
//    service.PayViaStrategy(paymentOpt);


//} while (Console.ReadKey().Key!=ConsoleKey.Escape);



#endregion