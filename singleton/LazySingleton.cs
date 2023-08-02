class LazySingleton
{
    private static LazySingleton instance;
    private LazySingleton()
    {

    }
    public static LazySingleton GetLazySingleton()
    {
        if (instance == null)
        {
            instance = new LazySingleton();
        }
        return instance;
    }

}