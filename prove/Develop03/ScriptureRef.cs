public class ScriptureRef
{
    private string _scripture = "";

    public ScriptureRef()
    {
    }

    public ScriptureRef(string referrence)
    {
        _scripture = referrence;
    }

    public string getSR(){
        return _scripture;
    }

}