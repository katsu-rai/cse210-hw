using System;

public class Scripture {
    private List<Word> _words = new List<Word>();
    private string _reference;
    private int _hiddenWords = 0;
    private bool _allWordsHidden = false;

    public Scripture (string book, string chapter, string startVerse, string endVerse, string scripture) {
        Reference reference = new Reference(book, chapter, startVerse, endVerse);
        _reference = reference.GetReference();
        string[] list = scripture.Split(" ");

        foreach (string word in list) {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }

    public void DisplayScripture () {
        Console.Write(_reference);
        Console.Write(" ");
        foreach (Word word in _words) {
            word.DisplayWord();
            Console.Write(' ');
        }
        Console.WriteLine();
    }

    public void HideRandomWord () {
        _allWordsHidden = _hiddenWords >= _words.Count();
        Random random = new Random();

        // Pick a random number to hide. Keep picking random numbers until
        // we pick a word which is not already hidden.
        int index;
        
        do {
            index = random.Next(_words.Count());
            
        } while (_words[index].GetHidden() && !_allWordsHidden);
        _words[index].HideWord();
        _hiddenWords ++;
    }

    public bool GetAllWordsHidden(){
        return _allWordsHidden;
    }

    public void Reset (string book, string chapter, string startVerse, string endVerse, string scripture){
        Reference reference = new Reference(book, chapter, startVerse, endVerse);
        _reference = reference.GetReference();
        string[] list = scripture.Split(" ");
        _words.Clear();
        _hiddenWords = 0;

        foreach (string word in list) {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }
}