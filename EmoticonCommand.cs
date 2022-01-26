public interface ICommand
{
    void ExecuteAction();
}

public enum EmoticonAction
{
    leftBrow,
    leftBrowPosX,
    leftBrowPosY,
    rightBrow,
    rightBrowPosX,
    rightBrowPosY,
    leftEye,
    leftEyePosX,
    leftEyePosY,
    rightEye,
    rightEyePosX,
    rightEyePosY,
    mouth,
    mouthPosX,
    mouthPosY
}

public class EmoticonCommand : ICommand
{
    private readonly Emoticon _emoticon;
    private readonly EmoticonAction _emoticonAction;
    private readonly string _element;
    private readonly int _value;

    public EmoticonCommand(Emoticon emoticon, EmoticonAction emoticonAction, string element)
    {
        _emoticon = emoticon;
        _emoticonAction = emoticonAction;
        _element = element;
    }

    public EmoticonCommand(Emoticon emoticon, EmoticonAction emoticonAction, int value)
    {
        _emoticon = emoticon;
        _emoticonAction = emoticonAction;
        _value = value;
    }

    public void ExecuteAction()
    {
        if(_emoticonAction == EmoticonAction.leftBrow)
        {
            _emoticon.leftBrow = _element;
        }
        if(_emoticonAction == EmoticonAction.rightBrow)
        {
            _emoticon.rightBrow = _element;
        }
        if(_emoticonAction == EmoticonAction.leftEye)
        {
            _emoticon.leftEye = _element;
        }
        if(_emoticonAction == EmoticonAction.rightEye)
        {
            _emoticon.rightEye = _element;
        }
        if(_emoticonAction == EmoticonAction.mouth)
        {
            _emoticon.mouth = _element;
        }
        if(_emoticonAction == EmoticonAction.leftBrowPosX)
        {
            _emoticon.leftBrowPosX = _value;
        }
        if(_emoticonAction == EmoticonAction.rightBrowPosX)
        {
            _emoticon.rightBrowPosX = _value;
        }
        if(_emoticonAction == EmoticonAction.leftEyePosX)
        {
            _emoticon.leftEyePosX = _value;
        }
        if(_emoticonAction == EmoticonAction.rightEyePosX)
        {
            _emoticon.rightEyePosX = _value;
        }
        if(_emoticonAction == EmoticonAction.mouthPosX)
        {
            _emoticon.mouthPosX = _value;
        }
        if(_emoticonAction == EmoticonAction.leftBrowPosY)
        {
            _emoticon.leftBrowPosY = _value;
        }
        if(_emoticonAction == EmoticonAction.rightBrowPosY)
        {
            _emoticon.rightBrowPosY = _value;
        }
        if(_emoticonAction == EmoticonAction.leftEyePosY)
        {
            _emoticon.leftEyePosY = _value;
        }
        if(_emoticonAction == EmoticonAction.rightEyePosY)
        {
            _emoticon.rightEyePosY = _value;
        }
        if(_emoticonAction == EmoticonAction.mouthPosY)
        {
            _emoticon.mouthPosY = _value;
        }
        
    }
}