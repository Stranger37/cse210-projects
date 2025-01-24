public class Fraction{
    private int _topNumber;
    private int _botNumber;

    public Fraction(){
        _topNumber = 1;
        _botNumber = 1;
    }

    public Fraction(int topNumber){
        _topNumber = topNumber;
        _botNumber = 1;
    }

    public Fraction(int topNumber, int botNumber){
        _topNumber = topNumber;
        _botNumber = botNumber;
    }

    public void SetTop(int topNumber){
        _topNumber = topNumber;
    }

    public void SetBot(int botNumber){
        _botNumber = botNumber;
    }

    public int GetTop(){
        return _topNumber;
    }

    public int GetBot(){
        return _botNumber;
    }

    public string GetFractionString(){
        string fractionString = $"{_topNumber}/{_botNumber}";
        return fractionString;
    }

    public double GetDecimalValue(){
        double fractionValue = (double)_topNumber / (double)_botNumber;
        return fractionValue;
    }

}