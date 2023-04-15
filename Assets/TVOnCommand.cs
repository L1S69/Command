using UnityEngine;

public class TVOnCommand : MonoBehaviour, ICommand
{
    public tv TVSet;
    public Color _color;
    public Vector2 Pos;
 
    
    public TVOnCommand(tv tvset, Color col, Vector2 pos)
    {
        TVSet = tvset;
        _color = col;
         Pos = pos;
    }
    
    public void Execute()
    {
        TVSet.On(_color, Pos);
    }

    public void Undo()
    {
        TVSet.Off(_color, Pos);
    }
}
