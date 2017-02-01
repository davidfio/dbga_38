using UnityEngine;
using System.IO;
using System.Text;

public class FileIOTest : MonoBehaviour
{

    void Start()
    {
        ReadCSV();
    }

    void WriteTextFile()
    {
        string path = Application.persistentDataPath + "/ciao.txt";

        // Write a text file
        StreamWriter sw = File.CreateText(path); // CreateText SOVRASCRIVE di default il testo
        sw.WriteLine("Ciao");
        sw.WriteLine("Bello");
        sw.Close();
    }

    void ReadTextFile()
    {
        string path = Application.persistentDataPath + "/ciao.txt";
        // Read a text file
        if (File.Exists(path))
        {
            StreamReader sr = File.OpenText(path); // Apre un file di testo in lettura
            string text;

            while ((text = sr.ReadLine()) != null)
                Debug.Log(text);

            sr.Close();
        }
    }
        
           
    void WriteBinaryFile()
    {
        // Write a binary file
        string path = Application.persistentDataPath + "/binary.pew";

        FileStream fs = File.Create(path);
        byte[] bytes = new byte[8] { 0, 1, 2, 3, 4, 5, 6, 7 };

        fs.Write(bytes, 0, 8);
        fs.Close();
    }

    void ReadBinaryFile()
    {
        string path = Application.persistentDataPath + "/binary.pew";
        FileStream fs = File.Create(path);
        byte[] bytes = new byte[8] { 0, 1, 2, 3, 4, 5, 6, 7 };

        fs.Read(bytes, 0, 8);
        fs.Close();
    }

    void WriteBinaryFileWithText()
    {
        string path = Application.persistentDataPath + "/binarytext.txt";
        File.WriteAllText(path, "Buongiorno", Encoding.UTF32);

        var bytes = Encoding.ASCII.GetBytes("Buongiorno");

        FileStream fs = File.Create(path);
        fs.Write(bytes, 0, bytes.Length);
        fs.Close();
    }

    void ReadBinaryFileWithText()
    {
        string path = Application.persistentDataPath + "/binarytext.txt";
        string result = File.ReadAllText(path, Encoding.UTF32);
    }


    void WriteTransformToBinaryFile()
    {
        // Save the transform's position in a save file
        Vector3 pos = transform.position;
        string path = Application.persistentDataPath + "/savedposition.pos";
        FileStream fs = File.Create(path);
        BinaryWriter bw = new BinaryWriter(fs);
        bw.Write(pos.x);
        bw.Write(pos.y);
        bw.Write(pos.z);
        bw.Close();
        fs.Close();

        
    }

    void ReadTransformFromBinaryFile()
    {
        string path = Application.persistentDataPath + "/savedposition.pos";
        Vector3 pos = transform.position;
        FileStream fs = File.OpenRead(path);
        BinaryReader br = new BinaryReader(fs);
        pos.x = br.ReadSingle();
        pos.y = br.ReadSingle();
        pos.z = br.ReadSingle();
        br.Close();
        fs.Close();
        Debug.Log(pos.x);
        Debug.Log(pos.y);
        this.transform.position = pos;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F5))
        {
            WriteTransformToBinaryFile();
        }

        if (Input.GetKeyDown(KeyCode.F9))
        {
            ReadTransformFromBinaryFile();
        }
    }

    void ReadCSV()
    {
        string path = Application.persistentDataPath + "/animali.csv";
        StreamReader sr = new StreamReader(path);

        string s;
        bool firstLine = true;
        while ((s = sr.ReadLine()) != null)
        {
            if (firstLine)
            {
                firstLine = false;
                continue;
            }
            Debug.Log(s);
        }
        sr.Close();
    }
}