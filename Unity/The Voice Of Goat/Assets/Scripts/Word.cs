using UnityEngine;
using System.Collections;

public class Word {

    public string name;

    public string type;

    public Word()
    {
        
    }
    public void setName(string name)
    {
        this.name = name;
    }
    public void setType(string type)
    {
        this.type = type;
    }
    public string getName()
    {
        return name;
    }
    public string getType()
    {
        return type;
    }
}
