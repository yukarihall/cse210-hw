class Reference
{
  // set the verses of the scriptures  
  public string _book;  // Matthew
  public int _chapter;  // 7
  public int _verse;    // 7
  public int _endVerse; // 10
  
  public Reference(string book,int chapter,int verse)
  {
      _book = book;
      _chapter = chapter;
      _verse = verse;
  }
  public Reference(string book,int chapter,int startVerse,int endVerse)
  {
      _book = book;
      _chapter = chapter;
      _verse = startVerse;
      _endVerse = endVerse;
  }
  public string GetDisplayText()
  {
      // eg return $"{_endVerse} {_verse} {_book} {_chapter}"
      return $"{_book} {_chapter} {_verse} {_endVerse}";    
  }
}
