
using UnityEngine;

public class pult : MonoBehaviour
{
    private ICommand comand;

    public void SetComand(ICommand com)
    {
        comand = com;
    }
   
    public void PressButtonOn()
    {
        comand.Execute();  
    }

    public void PressButtonUndo()
    {
        comand.Undo();
    }
}
