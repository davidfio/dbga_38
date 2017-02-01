using UnityEngine;
using System.Collections;
using System.Xml;
using System.IO;
using System.Collections.Generic;


namespace TestFile
{
    public class XMLTester : MonoBehaviour
    {

        void Start()
        {
            string xmlString = "<root>  <tag version =\"1.0\">Ciao </tag>  <tag>Gatto <a>Gattino1 </a>  <b>Gattino2 </b>  </tag>  </root>";

            // Read the XML as a text, piece by piece
            XmlReader xmlReader = XmlReader.Create(new StringReader(xmlString));
            while (xmlReader.Read())
            {
                string s1 = "";
                s1 += (xmlReader.Name) + "\n";
                s1 += (xmlReader.Depth) + "\n";
                s1 += (xmlReader.NodeType) + "\n";
                s1 += ("Has attribute: " + xmlReader.HasAttributes) + "\n";
                s1 += ("Has value: " + xmlReader.HasValue) + "\n";
                if (xmlReader.HasAttributes) s1 += (xmlReader.GetAttribute(0)) + "\n";
                s1 += (xmlReader.Value) + "\n";
                //Debug.Log(s1);
            }

            // Read the XML as a tree structure
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlString);

            if (xmlDoc.HasChildNodes)
            {
                RecursiceReadNode(xmlDoc.FirstChild);
            }


            // Write an XML

            XmlDocument xmlDoc2 = new XmlDocument();

            XmlNode rootNode = xmlDoc2.CreateNode(XmlNodeType.Element, "saveslist", "");
            xmlDoc2.AppendChild(rootNode);



            for (int i = 0; i < 4; i++)
            {
                SaveData saveData;
                saveData.saveName = "Save " + i;
                saveData.level = Random.Range(1, 11);
                saveData.playerName = "FitzChevalier";
                saveData.equipment = new List<int>() { 4, 6, 8, 10, 12 };

                XmlNode saveDataNode = xmlDoc2.CreateNode(XmlNodeType.Element, "savedata", "");
                XmlAttribute nameAttribute = xmlDoc2.CreateAttribute("name");
                nameAttribute.Value = saveData.saveName;
                saveDataNode.Attributes.Append(nameAttribute);
                rootNode.AppendChild(saveDataNode);

                XmlNode levelNode = xmlDoc2.CreateNode(XmlNodeType.Element, "level", "");
                XmlNode textNode = xmlDoc2.CreateNode(XmlNodeType.Text, "text", "");
                textNode.Value = saveData.level.ToString();
                levelNode.AppendChild(textNode);
                saveDataNode.AppendChild(levelNode);

                XmlNode playerNode = xmlDoc2.CreateNode(XmlNodeType.Element, "player", "");
                textNode = xmlDoc2.CreateNode(XmlNodeType.Text, "text", "");
                textNode.Value = saveData.playerName.ToString();
                playerNode.AppendChild(textNode);
                saveDataNode.AppendChild(playerNode);

                XmlNode equipmentNode = xmlDoc2.CreateNode(XmlNodeType.Element, "equipment", "");
                saveDataNode.AppendChild(equipmentNode);
                foreach (int id in saveData.equipment)
                {
                    XmlNode equipNode = xmlDoc2.CreateNode(XmlNodeType.Element, "equip", "");
                    textNode = xmlDoc2.CreateNode(XmlNodeType.Text, "text", "");
                    textNode.Value = id.ToString();
                    equipNode.AppendChild(textNode);
                    equipmentNode.AppendChild(equipNode);

                }
            }
            Debug.Log(xmlDoc2.InnerXml);
            File.WriteAllText(Application.persistentDataPath + "/allsaves.xml", xmlDoc2.InnerXml);

        }
        void RecursiceReadNode(XmlNode node)
        {
            XmlAttributeCollection attributes = node.Attributes;
            if (attributes != null)
            {
                foreach (XmlAttribute a in attributes)
                {
                    Debug.Log(a.Name + ": " + a.Value);
                }
            }


            if (node.HasChildNodes)
            {
                XmlNodeList children = node.ChildNodes;

                foreach (XmlNode child in children)
                {
                    RecursiceReadNode(child);
                }
            }
            else
            {
                Debug.Log(node.Name);
                Debug.Log(node.Value);
            }

        }
    }
}