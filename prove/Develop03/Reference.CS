using System;

public class Reference {
    private string _title;
    private string _chapter;
    private string _verse;

    // if verse2 is equal to "0", there is no second verse.
    public Reference (string title, string chapter, string verse1, string verse2) {
        _title = title;
        _chapter = chapter;

        if (verse2 == "0") {
            _verse = verse1;
        }
        else {
            _verse = ($"{verse1}-{verse2}");
        }
    }
    public string GetReference () {
        string reference = ($"{_title} {_chapter}:{_verse}");
        return reference;
    }
}
