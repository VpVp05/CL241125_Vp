using CL241125_Vp;

Auto a01 = new("XYZ-123", "Peugeot", "206", 60, 8.5F);
Auto a02 = new("ASD-0123");
Auto a03 = new(1234);
Ember e = new Ember("Para Zita");

//Console.WriteLine(e)
Console.WriteLine(a01);
//Console.WriteLine(a02);
//Console.WriteLine(a03);


a01.TulajokRogzitese("Végh Béla",
    "Martin Ralph Lauren",
    "Ice Wallow Come",
    "Lakatos Dzsenáró");

Console.WriteLine(a01.TulajdonosokListaja);