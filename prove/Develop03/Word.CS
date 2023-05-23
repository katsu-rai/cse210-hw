using System;

public class Word {
    private string _word;
    private bool _hidden = false;
    public Word (string word) {
    _word = word;
    }

    public void DisplayWord () {
        Console.Write(_word);
    }

    public void HideWord () {
        int count = _word.Count();
        _word = "";
        for (int i = 0 ; i < count ; i ++ ) {
            _word += "_";
        }
        // mark that this word is hidden
        _hidden = true;
    }

    public bool GetHidden(){
        return _hidden;
    }
}