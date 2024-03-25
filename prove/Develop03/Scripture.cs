class Scripture
{
  public Reference _reference;
  public List<Word> _words = new List<Word>();

  public Scripture(Reference reference, string text)
  {
    _reference = reference;

    string[] ssizes = text.Split(' '); 
    
    foreach(string tWord in ssizes)
    {
     Word word = new Word(tWord);
      _words.Add(word);
    }
  }

  public void HideRandomWords(int numberToHide)
  {
    Random hrw = new Random();

    for(int i = numberToHide; i > 0; i --)
    {
      bool hidden = true;
      while(hidden == true)
      {
        int index = hrw.Next(0, _words.Count);
        Word word = _words[index];
        if(word.IsHidden()==false) hidden = false;
        if(hidden == false) word.Hide();
      } 
    }
  }

  public string GetDisplayText()
  {
    foreach(Word word in _words)
    {
      Console.Write(" ");
      Console.Write(word.GetDisplayText());
    }
    return "";
  }

  public bool IsCompetelyHidden()
  {
    foreach(Word word in _words)
    {
      if(word.IsHidden()==false) return false;
    }
    return true;  
  }
}