using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Text;
using System.IO;

public class XmlReader : MonoBehaviour
{
    /*
    <theme_collection>
	    <themes>
		    <theme>
			    <name>Beach</name>
			    <src>blabla/bla</type>
			    <words>
				    <word>
					    <name>Sun</name>
					    <type>Subject</type>
				    </word>
				    <word>
					    <name>swim</name>
					    <type>Verb</type>
				    </word>
			    </words>
		    </theme>
	    </themes>
    </theme_collection>
*/
    // Use this for initialization
    List<Theme> themecollection;
    Theme theme;
    
    void Start ()
    {
        LoadFile();   
    }
	void LoadFile()
    {
        /*
        TextAsset textAsset = (TextAsset)Resources.Load("testxml");
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(textAsset.text);

        XmlNodeList themeList = xmlDoc.GetElementsByTagName("theme"); // array of the theme nodes.

        

        themecollection = new List<Theme>();

        foreach (XmlNode themeInfo in themeList)
        {
            XmlNodeList themecontent = themeInfo.ChildNodes;

            theme = new Theme(); // Create new Theme

            foreach (XmlNode themeItem in themecontent)
            {
                if (themeItem.Name == "name")
                {
                    theme.setName(themeItem.InnerText);
                }

                if (themeItem.Name == "src")
                {
                    theme.setSrc(themeItem.InnerText);
                }

                List<Word> words = new List<Word>();
                XmlNodeList wordcollection = themeItem.ChildNodes;

                foreach(XmlNode wordItem in wordcollection)
                {
                    Word word = new Word();
                    if(wordItem.Name == "name")
                    {
                        word.setName(wordItem.InnerText);
                    }
                    if(wordItem.Name == "type")
                    {
                        word.setName(wordItem.InnerText);
                    }
                    words.Add(word);
                }
                theme.addWords(words);
            }
            themecollection.Add(theme);
        }
        */
        //themecollection[0].getName();  calls the name of the first theme
    }
}
