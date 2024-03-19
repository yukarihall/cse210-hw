class Reference
{
  // set the verses of the scriptures  
  public string _book;
  public int _chapter;
  public int _verse;
  public int _endVerse;
  
  Reference(book:string,chapter:int,verse:int)
  Reference(book:string,chapter:int,startVerse:int,endVerse:int)
  GetDisplayText():string
}