var builderA = new BuilderA();
A a = builderA.setFirst(12).build();
Console.WriteLine(a);


var builderB = new BuilderB();
B b = builderB.setFirst(1).setSecond(2).build();
Console.WriteLine(b);