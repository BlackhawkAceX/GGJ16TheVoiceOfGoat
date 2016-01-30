using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Theme{

    string name;

    string src;

    List<Word> words;

    public void setName(string themename)
    {
        name = themename;
    }
    public void setSrc(string srcname)
    {
        src = srcname;
    }
    public void addWords(List<Word> words)
    {
        this.words = words;
    }
    public string getName()
    {
        return name;
    }
    public string getSrc()
    {
        return src;
    }
    public List<Word> getWords()
    {
        return words;
    }
}
