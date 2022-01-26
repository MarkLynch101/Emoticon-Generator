public class Emoticon
{
    //left eyebrow
    public string leftBrow {get; set;}
    public int leftBrowPosX {get; set;}
    public int leftBrowPosY {get; set;}
   
   //right eyebrow
    public string rightBrow {get; set;}
    public int rightBrowPosX {get; set;}
    public int rightBrowPosY {get; set;}

    //left eye
    public string leftEye {get; set;}
    public int leftEyePosX {get; set;}
    public int leftEyePosY {get; set;}

    //right eye
    public string rightEye {get; set; }
    public int rightEyePosX {get; set; }
    public int rightEyePosY {get; set; }
    
    //mouth
    public string mouth {get; set; }
    public int mouthPosX {get; set; }
    public int mouthPosY {get; set; }

//construcer with default emodicon values
    public Emoticon()
    {
        leftBrow = "happy";
        leftBrowPosX = 0;
        leftBrowPosY = 0;

        rightBrow = "happy";
        rightBrowPosX = 0;
        rightBrowPosY = 0;

        leftEye = "happy";
        leftEyePosX = 0;
        leftEyePosY = 0;
       
        rightEye = "happy";
        rightEyePosX = 0;
        rightEyePosY = 0;

        mouth = "happy";
        mouthPosX = 0;
        mouthPosY = 0;
    }

    public override string ToString()
    {
        string svg = "<svg height=\"210\" width=\"210\" xmlns=\"http://www.w3.org/2000/svg\">" 
                      + System.Environment.NewLine +
                      "<circle cx=\"110\" cy=\"110\" r=\"100\" stroke=\"black\" stroke-width=\"3\" fill=\"yellow\"/>"
                      + System.Environment.NewLine;
        
        switch (leftEye)
        {
            case "happy":
            svg = svg + $"<circle cx=\"{80+leftEyePosX}\" cy=\"{95+leftEyePosY}\" r=\"20\" stroke=\"black\" stroke-width=\"3\" fill=\"white\" />"
                        + System.Environment.NewLine +
                        $"<circle cx=\"{80+leftEyePosX}\" cy=\"{100+leftEyePosY}\" r=\"5\" stroke=\"black\" stroke-width=\"3\" fill=\"black\" />"
                        + System.Environment.NewLine;
            break;

            case "sad":
            svg = svg + $"<circle cx=\"{80+leftEyePosX}\" cy=\"{95+leftEyePosY}\" r=\"20\" stroke=\"black\" stroke-width=\"3\" fill=\"white\" index=\"10\" />"
                        + System.Environment.NewLine +
                        $"<circle cx=\"{80+leftEyePosX}\" cy=\"{100+leftEyePosY}\" r=\"5\" stroke=\"black\" stroke-width=\"3\" fill=\"black\" index=\"11\" />"
                        + System.Environment.NewLine +
                        "<path d=\"M70 120 Q 70 100, 80 120 A 12.8 12.8 0 1 1 60 120 Q 70 100 80 120\"  stroke=\"blue\" fill=\"blue\"/>"
                        + System.Environment.NewLine;
            break;

            case "angry":
            svg = svg + $"<circle cx=\"{80+leftEyePosX}\" cy=\"{95+leftEyePosY}\" r=\"20\" stroke=\"black\" stroke-width=\"3\" fill=\"white\" index=\"10\" />"
                        + System.Environment.NewLine +
                        $"<circle cx=\"{90+leftEyePosX}\" cy=\"{100+leftEyePosY}\" r=\"5\" stroke=\"black\" stroke-width=\"3\" fill=\"black\" index=\"11\" />"
                        + System.Environment.NewLine;
            break;
        }
        
        switch (rightEye)
        {
            case "happy":
            svg = svg + $"<circle cx=\"{140+rightEyePosX}\" cy=\"{95+rightEyePosY}\" r=\"20\" stroke=\"black\" stroke-width=\"3\" fill=\"white\" index=\"10\" />"
                        + System.Environment.NewLine +
                        $"<circle cx=\"{140+rightEyePosX}\" cy=\"{100+rightEyePosY}\" r=\"5\" stroke=\"black\" stroke-width=\"3\" fill=\"black\" index=\"11\" />"
                        + System.Environment.NewLine;
            break;

            case "sad":
            svg = svg + $"<circle cx=\"{140+rightEyePosX}\" cy=\"{95+rightEyePosY}\" r=\"20\" stroke=\"black\" stroke-width=\"3\" fill=\"white\" index=\"10\" />"
                        + System.Environment.NewLine +
                        $"<circle cx=\"{140+rightEyePosX}\" cy=\"{100+rightEyePosY}\" r=\"5\" stroke=\"black\" stroke-width=\"3\" fill=\"black\" index=\"11\" />"
                        + System.Environment.NewLine +
                        "<path d=\"M150 120 Q 150 100, 160 120 A 12.8 12.8 0 1 1 140 120 Q 150 100 160 120\" stroke=\"blue\" fill=\"blue\"/>"
                        + System.Environment.NewLine;
            break;

            case "angry":
            svg = svg + $"<circle cx=\"{140+rightEyePosX}\" cy=\"{95+rightEyePosY}\" r=\"20\" stroke=\"black\" stroke-width=\"3\" fill=\"white\" index=\"10\" />"
                        + System.Environment.NewLine +
                        $"<circle cx=\"{130+rightEyePosX}\" cy=\"{100+rightEyePosY}\" r=\"5\" stroke=\"black\" stroke-width=\"3\" fill=\"black\" index=\"11\" />"
                        + System.Environment.NewLine;
            break;
        }
        
        switch (leftBrow)
        {
            case "happy":
                svg = svg + $"<path d=\"M{55+leftBrowPosX},{80+leftBrowPosY} C{65+leftBrowPosX},{65+leftBrowPosY}  {95+leftBrowPosX},{65+leftBrowPosY}  {105+leftBrowPosX},{80+leftBrowPosY}\" fill=\"none\" stroke=\"black\" stroke-width=\"3px\" />"
                + System.Environment.NewLine;
                break;

            case "sad": 
                svg = svg + $"<path d=\"M{55+leftBrowPosX},{60+leftBrowPosY} C{65+leftBrowPosX},{55+leftBrowPosY}  {85+leftBrowPosX},{75+leftBrowPosY}  {105+leftBrowPosX},{70+leftBrowPosY}\" fill=\"none\" stroke=\"#000\" stroke-width=\"3px\" />"
                + System.Environment.NewLine;
                break;

            case "angry":
                svg = svg + $"<path d=\"M{55+leftBrowPosX},{60+leftBrowPosY} C{65+leftBrowPosX},{55+leftBrowPosY}  {85+leftBrowPosX},{75+leftBrowPosY}  {105+leftBrowPosX},{70+leftBrowPosY}\" fill=\"none\" stroke=\"#000\" stroke-width=\"3px\" />"
                + System.Environment.NewLine;
                break;
        }

        switch (rightBrow)
        {
            case "happy":
            svg = svg + $"<path d=\"M{115+rightBrowPosX},{80+rightBrowPosY} C{125+rightBrowPosX},{65+rightBrowPosY}  {155+rightBrowPosX},{65+rightBrowPosY}  {165+rightBrowPosX},{80+rightBrowPosY}\" fill=\"none\" stroke=\"#000\" stroke-width=\"3px\" index=\"20\" />"
            + System.Environment.NewLine;
            break;

            case "sad":
            svg = svg + $"<path d=\"M{115+rightBrowPosX},{70+rightBrowPosY} C{125+rightBrowPosX},{75+rightBrowPosY}  {155+rightBrowPosX},{55+rightBrowPosY}  {165+rightBrowPosX},{60+rightBrowPosY}\" fill=\"none\" stroke=\"#000\" stroke-width=\"3px\" index=\"20\" />"
            + System.Environment.NewLine;
            break;

            case "angry":
            svg = svg + $"<path d=\"M{115+rightBrowPosX},{70+rightBrowPosY} C{125+rightBrowPosX},{75+rightBrowPosY}  {155+rightBrowPosX},{55+rightBrowPosY}  {165+rightBrowPosX},{60+rightBrowPosY}\" fill=\"none\" stroke=\"#000\" stroke-width=\"3px\" index=\"20\" />"
            + System.Environment.NewLine;
            break;
        }

        switch (mouth)
        {
            case "happy":
            svg = svg + $"<path d=\"M{60+mouthPosX},{140+mouthPosY} C{60+mouthPosX},{190+mouthPosY}  {160+mouthPosX},{190+mouthPosY}  {160+mouthPosX},{140+mouthPosY}\" fill=\"white\" stroke=\"black\" stroke-width=\"3px\" />"
                        + System.Environment.NewLine +
                        $"<line x1=\"{60+mouthPosX}\" y1=\"{140+mouthPosY}\" x2=\"{160+mouthPosX}\" y2=\"{140+mouthPosY}\" stroke=\"black\" stroke-width=\"3px\" />"
                        + System.Environment.NewLine +
                        $"<path d=\"M{62+mouthPosX},{150+mouthPosY} C{90+mouthPosX},{160+mouthPosY}  {130+mouthPosX},160  {158+mouthPosX},{150+mouthPosY}\" fill=\"none\" stroke=\"grey\" stroke-width=\"2px\" />"
                        + System.Environment.NewLine;
            break;

            case "sad":
            svg = svg + $"<path d=\"M{60+mouthPosX},{180+mouthPosY} C{60+mouthPosX},{130+mouthPosY}  {160+mouthPosX},{130+mouthPosY}  {160+mouthPosX},{180+mouthPosY}\" fill=\"none\" stroke=\"black\" stroke-width=\"4px\" />"
            + System.Environment.NewLine;
            break;

            case "angry":
            svg = svg + $"<ellipse cx=\"{110+mouthPosX}\" cy=\"{140+mouthPosY}\" rx=\"50\" ry=\"15\" fill=\"white\" stroke=\"black\" stroke-width=\"2px\" />"
                        + System.Environment.NewLine +
                        $"<line x1=\"{60+mouthPosX}\" y1=\"{140+mouthPosY}\" x2=\"{160+mouthPosX}\" y2=\"{140+mouthPosY}\" stroke=\"grey\" stroke-width=\"3px\" />"
                         + System.Environment.NewLine;
            break;
        }
        
        svg = svg + "</svg>";

        return svg;
    }
}