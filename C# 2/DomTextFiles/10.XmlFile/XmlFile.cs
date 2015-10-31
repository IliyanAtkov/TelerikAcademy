// Write a program that extracts from given XML file all the text without the tags.

using System;
using System.IO;
using System.Xml;
using System.Text;
class XmlFile
{
    static void Main()
    {

        XmlText();
        
    }

    private static void XmlText()
    {
        using (XmlReader reader = XmlReader.Create(new StreamReader("xml.xml")))
        {
            while (!reader.EOF)
            {
                using (StreamWriter writer = new StreamWriter("result.txt"))
                {
                    while (!reader.EOF)
                    {
                        reader.Read();
                        if (reader.NodeType == XmlNodeType.Text)
                        {
                            writer.WriteLine(reader.Value);
                        }
                    }
                }
            }
        }
    }
}

