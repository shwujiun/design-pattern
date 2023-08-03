class LazySingleton
{
    private static volatile LazySingleton? instance;
    private static readonly object SyncRoot = new();
    private LazySingleton()
    {

    }

    //對於多執行緒的使用
    //https://learn.microsoft.com/en-us/previous-versions/msp-n-p/ff650316(v=pandp.10)?redirectedfrom=MSDN
    //https://csharpindepth.com/Articles/Singleton
    public static LazySingleton GetLazySingleton()
    {
        if (instance == null)
        {
            lock (SyncRoot)
            {
                instance ??= new LazySingleton();
            }

        }
        return instance;
    }

}