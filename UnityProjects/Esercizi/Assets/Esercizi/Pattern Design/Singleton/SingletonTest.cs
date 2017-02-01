public class SingletonTest {


    private static SingletonTest instance = null;

    private SingletonTest()
    {
    }

    public static SingletonTest GetIstance()
    {
        if (instance == null)
        {
            instance = new SingletonTest();
            UnityEngine.Debug.Log("Instance Created");
        }

        return instance;
    }

    public void DoStuff()
    {
        UnityEngine.Debug.Log("Singleton Test Stuff");
    }
}
