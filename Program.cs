// struct support ->
// events - indexers - opperator overloading - fields - constructor - preperties - methods
//----------------------------------------------
// struct implicity ingerites object base class but not support inhiretance
// struct is value typy otherside class is refrence type
// readonly exist only in struct nor class
// struct doesnt support finalizers and inhiretances
// new is mandatory(in one condietion u can not use new()

using ConsoleApp13;

//first f;  new() is mandatory but if there 's feilds and prperties have to use new()
//f.show();
first f = new first();
f.show();


Digitalsize size = new Digitalsize(1000000);
Console.WriteLine(size.Byte);
Console.WriteLine(size.KB);
Console.WriteLine(size.MB);
Console.WriteLine(size.GB);
Console.WriteLine(size.TB);

