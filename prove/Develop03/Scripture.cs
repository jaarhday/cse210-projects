using System;
public class Scripture{
    private string _text;

    public Scripture(string text){
        this._text = text;
    }

    public string GetText(){
        return _text;
    }
}