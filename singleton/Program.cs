LazySingleton instance = LazySingleton.GetLazySingleton();
LazySingleton instance1 = LazySingleton.GetLazySingleton();

Console.WriteLine(instance==instance1);
