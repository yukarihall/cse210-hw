class Word
{
  public string _text; 
  public bool _isHidden;
  
  public Word(string text)
  {
      _text = text;

      _isHidden = false;
  }  

  public void Hide()
  {
    _isHidden = true;
  }

  public void Show()
  {
    _isHidden = false;
  }

  public bool IsHidden()
  {
    return _isHidden;
  }
 
  public string GetDisplayText()
  { 
    // if the word is hidden return __, otherwise return text
    if (_isHidden == false) return _text;
    string underScoreString = "";
    for(int lCount=0; lCount<_text.Length ; lCount++){
      underScoreString += "_";      
    }
    
      return underScoreString;
  }
  
}