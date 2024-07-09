using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace MyData.ApiLib
{

    /// <summary>
    /// XML helper
    /// </summary>
    static public class ApiXml
    { 

        /// <summary>
        /// Serializes a specified instance and returns the XML string.
        /// </summary>
        static string Serialize_OLD<T>(T Instance)
        {    
            XmlSerializer Serializer = new XmlSerializer(typeof(T));

            using (StringWriter Writer = new StringWriter())
            {
                Serializer.Serialize(Writer, Instance);
                return Writer.ToString();
            }
        }

        /// <summary>
        /// Removes an Attribure from an XmlElement by name, if exists.
        /// </summary>
        static void RemoveAttribute(XmlElement Element, string AttrName)
        {
            if (Element.Attributes != null && Element.Attributes.GetNamedItem(AttrName) != null)
            {
                XmlAttribute Attr = Element.GetAttributeNode(AttrName);
                if (Attr != null)
                    Element.RemoveAttributeNode(Attr);
            }           
        }
        /// <summary>
        /// Remove null nodes, i.e. having an Attribute as xsi:nil='true'
        /// </summary>
        static string RemoveNilElements(string XmlText)
        {
            XmlDocument Doc = new XmlDocument();
            Doc.LoadXml(XmlText); 
            XmlElement Root = Doc.DocumentElement;

            // remove null nodes, i.e. having an Attribute as xsi:nil='true'
            if (Root.Attributes != null && Root.Attributes.GetNamedItem("xmlns:xsi") != null)
            {
                XmlNode Attr = Root.Attributes.GetNamedItem("xmlns:xsi");
                if (Attr != null)
                {
                    string XmlNs = Attr.Value;
                    XmlNamespaceManager NsMngr = new XmlNamespaceManager(Doc.NameTable);
                    NsMngr.AddNamespace("xsi", XmlNs);

                    // get null nodes and remove them
                    XmlNodeList NodeList = Root.SelectNodes("//*[@xsi:nil='true']", NsMngr);
                    if (NodeList != null && NodeList.Count > 0)
                    {
                        foreach (XmlNode Node in NodeList)
                            Node.ParentNode.RemoveChild(Node);
                    }
                }
            }
 
            // remove root namespaces, if exist
            RemoveAttribute(Root, "xmlns:xsi");
            RemoveAttribute(Root, "xmlns:xsd"); 

            // get the xml text
            using (StringWriter SW = new StringWriter())
            {
                using (XmlTextWriterEx TW = new XmlTextWriterEx(SW))    // removes node namespaces
                {
                    Doc.Save(TW);
                    XmlText = SW.ToString();
                }
            }
 
            return XmlText;
        }
    
        /// <summary>
        /// Serializes a specified instance and returns the XML string.
        /// </summary>
        static public string Serialize<T>(T Instance)
        {
            string XmlText;
            Type[] types = new Type[] { typeof(InvoicesDoc) };
            XmlSerializer Serializer = new XmlSerializer(typeof(T), types);
            StringBuilder stringBuilder = new StringBuilder();

            using (XmlWriter xmlWriter = XmlWriter.Create(stringBuilder))
            {
                try
                {
                    
                    Serializer.Serialize(xmlWriter, Instance);
                }catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    

                }
                XmlText = stringBuilder.ToString();
                xmlWriter.Flush();
            }

            XmlText = RemoveNilElements(XmlText);
            XmlText = XmlText.Replace("<anyType type=\"q1:InvoicesDoc\">", "<InvoicesDoc xmlns=\"http://www.aade.gr/myDATA/invoice/v1.0\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:icls=\"https://www.aade.gr/myDATA/incomeClassificaton/v1.0\" xmlns:ecls=\"https://www.aade.gr/myDATA/expensesClassificaton/v1.0\" xsi:schemaLocation=\"http://www.aade.gr/myDATA/invoice/v1.0/InvoicesDoc-v1.0.8.xsd\">");
            XmlText = XmlText.Replace("</anyType>", "</InvoicesDoc>");
            XmlText = XmlText.Replace("<paymentMethods>", "<paymentMethods>\r\n<paymentMethodDetails>");
            XmlText = XmlText.Replace("</paymentMethods>", "</paymentMethodDetails>\r\n</paymentMethods>");
            
            var xmlRows = XmlText.Split("\n");
            var replaceText = false;
            for (int i=0; i < xmlRows.Length; i++)
            {
                if (xmlRows[i].Contains( "<incomeClassification>"))
                {
                    replaceText = true;
                }else if (xmlRows[i].Contains("</incomeClassification>"))
                {
                    replaceText = false;
                }
                if (replaceText)
                {
                    xmlRows[i] = xmlRows[i].Replace("classificationType", "icls:classificationType");
                    xmlRows[i] = xmlRows[i].Replace("amount", "icls:amount");
                    xmlRows[i] = xmlRows[i].Replace("classificationCategory", "icls:classificationCategory");
                }
            }
            XmlText = string.Join("\n", xmlRows);
            return XmlText;

        }
        /// <summary>
        /// Deserializes an XML string and returns an instance of a specified type.
        /// </summary>
        static public T Deserialize<T>(string XmlText) where T : class  
        {
            T Result;
            //Type[] types = new Type[] { typeof(ResponseDoc) };
            XmlSerializer Serializer = new XmlSerializer(typeof(T));
            var result = XElement.Parse(XmlText).Value;
            using (StringReader Reader = new StringReader(result))
            {
                //var result = XElement.Parse(XmlText).Value;
                Result =  Serializer.Deserialize(Reader) as T;
            }

            return Result;
        }
        /// <summary>
        /// Deserializes an XML string and returns an instance of a specified type.
        /// </summary>
        static public object Deserialize(string XmlText, Type type) 
        {
            object Result;
            XmlSerializer Serializer = new XmlSerializer(type);
            using (StringReader Reader = new StringReader(XmlText))
            {
                Result = Serializer.Deserialize(Reader);
            }

            return Result;
        }
     }
}
