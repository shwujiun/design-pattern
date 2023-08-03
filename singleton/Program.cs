using singleton;

HungrySingleton instance = HungrySingleton.GetInstance();
HungrySingleton instance1 = HungrySingleton.GetInstance();

Console.WriteLine(instance==instance1);
