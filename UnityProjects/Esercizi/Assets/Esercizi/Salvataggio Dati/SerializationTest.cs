using UnityEngine;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace TestFile
{
    [System.Serializable]
    public struct InnerData
    {
        public int inner_v;

    }


    [System.Serializable]
    public struct TestSaveData
    {
        public int v;
        public float f;
        public string s;
        [System.NonSerialized]
        private int p_v;

        public int[] intarray;

        public InnerData innerData;

        // non serializzabile
        //public GameObject go;

        //public List<int> intlist;
        //public List<List<List<int>>> intlistlistlist;

        public Dictionary<string, int> dict;

        public override string ToString()
        {
            return "v: " + v + 
                "\nf: " + f +
                "\ns: "+ s +
                "\np_v "+p_v+
                "\n array "+intarray+
                "\n dict: " +dict["ciao"] +","+dict["gatto"]+
                "\n innerdata v: "+ innerData.inner_v; 

        }

        public TestSaveData (int _v)
        {
            v = _v;
            f = 0;
            s = "";
            p_v = 5;
            intarray = new int[] { 1, 2, 3, 4 };
            innerData = new InnerData();
            innerData.inner_v = 5;

            
            /*intlist = new List<int>() { 1, 2, 3, 4 };
            intlistlistlist = new List<List<List<int>>>()
            {
                new List<List<int>>
                {
                    new List<int>
                    {
                        1,2,3,4
                    }
                }
            };*/

            dict = new Dictionary<string, int>();
            dict["ciao"] = 10;
            dict["gatto"] = 17;
        }
    }



    public class SerializationTest : MonoBehaviour
    {
        public static void Save()
        {
            object graph = null;

            // Define what we will save
            TestSaveData sd;
            sd.v = 10;
            sd.f = 5.23f;
            //graph = sd;

            // Save the graph object to a file
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs = File.Create(Application.persistentDataPath + "/testsavedata.sb");
            formatter.Serialize(fs, graph);
            fs.Close();

            Debug.Log("SAVED");
        }

        public static void Load()
        {
            // Load the graph object from a file
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs = File.OpenRead(Application.persistentDataPath + "/testsavedata.sb");
            object graph = formatter.Deserialize(fs);
            fs.Close();

            // Retrieve the data we saved
            TestSaveData sd = (TestSaveData)graph;

            Debug.Log(sd.ToString());
        }

        void Update()
        {
            if (Input.GetKey(KeyCode.F5)) Save();
            if (Input.GetKey(KeyCode.F9)) Load();
        }
    }
}