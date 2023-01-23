using System;
using System.IO;

public class Scripture
{
    //Private properties to avoid interrupt the working of program
    private string _sentence;
    //_____Constructors Part_____
    public Scripture(){
        _sentence = "Undefined";
    }
    public Scripture(string SentenceRecorded){
        _sentence = SentenceRecorded;
    }
//______Getter and Setters____
    public string GetSentence(){
        return _sentence;
    }
    public void SetSentence(string SentenceSetted){
        _sentence = SentenceSetted;
    }
    //_____Methods:_____
    public string GetCompleteSentence(){
        
            string FullSentence = _sentence;
            return FullSentence;           
    }
}

public class Reference
{
    //Private properties to avoid interrupt the working of program
    private string _book;
    private string _chapter;
    private string _firstVerseNum;
    private string _lastVersenum;

    //_____Constructors Part_____
    public Reference()
    {
        _book = "Unidentified";
        _chapter ="Undefined";
        _firstVerseNum = "Undefined";
        _lastVersenum = "no";
    }
    public Reference(string BookRecorded){
        _book = BookRecorded;
        _chapter ="Undefined";
        _firstVerseNum = "Undefined";
        _lastVersenum = "no";
    }
    public Reference(string BookRecorded, string ChapterRecorded){
        _book = BookRecorded;
        _chapter =ChapterRecorded;
        _firstVerseNum = "Undefined";
        _lastVersenum = "no";
    }
    public Reference(string BookRecorded, string ChapterRecorded, string FVRecorded){
        _book = BookRecorded;
        _chapter =ChapterRecorded;
        _firstVerseNum = FVRecorded;
        _lastVersenum = "no";
    }
    public Reference(string BookRecorded, string ChapterRecorded, string FVRecorded, string LVRecorded){
        _book = BookRecorded;
        _chapter =ChapterRecorded;
        _firstVerseNum = FVRecorded;
        _lastVersenum = LVRecorded;
    }
    
    //______Getter and Setters____
    public string GetBook(){
        return _book;
    }
    public void SetBook(string bookSetted){
        _book = bookSetted;
    }
    public string GetChapter(){
        return _chapter;
    }
    public void SetChapter(string chapterSetted){
        _book = chapterSetted;
    }
    public string GetFVN(){
        return _firstVerseNum;
    }
    public void SetFVN(string FVNSetted){
        _book = FVNSetted;
    }
    public string GetLVN(){
        return _lastVersenum;
    }
    public void SetLVN(string LVNSetted){
        _book = LVNSetted;
    }
    //_____Methods:_____
    public string GetCompleteReference(){
        if (_lastVersenum == "no")
        {
            string FullReference = $"{_book} {_chapter}:{_firstVerseNum}";
            return FullReference;
        }
        else {
            string FullReference = $"{_book} {_chapter}:{_firstVerseNum}-{_lastVersenum}";
            return FullReference;
        }
    }
}