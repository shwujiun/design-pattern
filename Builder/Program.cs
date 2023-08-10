// See https://aka.ms/new-console-template for more information
using Builder.Decoration;
using Builder.Person;
using Builder.Product;

//Console.WriteLine("Hello, World!");
//Decoration
Console.OutputEncoding=System.Text.Encoding.UTF8;

DecorationPackageController d = new DecorationPackageController();
Console.WriteLine(d.GetMatterList(1, 1));

Builder.Decoration.Director b = new Builder.Decoration.Director();
b.LevelOne(1);


//Product
ProductBuilder productBuilder = new ProductBuilder();
Builder.Product.Director director = new Builder.Product.Director(productBuilder);
Console.WriteLine(director.makeProduct("product name","cm","1","2","3"));


ProductBuilder2 productBuilder2 = new ProductBuilder2();
Builder.Product.Director director2 = new Builder.Product.Director(productBuilder);
Console.WriteLine(director2.makeProduct("product name2", "cm", "1", "2", "3"));


//Perosn
ThinPerosnBuilder pb = new Builder.Person.ThinPerosnBuilder("graphics", "red");
Builder.Person.Director dr = new Builder.Person.Director(pb);   
dr.createPerson();

