
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject tvpref;
    public pult myPult;
    public tv myTv;
    private ICommand _comand;
    public List<ICommand> ListComands = new List<ICommand>();
    private Color col1;
    private Color[] col = {Color.red, Color.blue, Color.black, Color.green, Color.yellow, Color.white, Color.grey};
    private Vector2 move;
    private Vector2 undoMove;

    void Update()
    {
        if (Input.GetKey("a")) move = new Vector2(-1, 0);
        if (Input.GetKey("d")) move = new Vector2( 1, 0);
        if (Input.GetKey("s")) move = new Vector2(0, -1);
        if (Input.GetKey("w")) move = new Vector2(0, 1);
    }
    
    public void TvComandos()
    {
        col1 = col[Random.Range(0, 7)];
        //_comand = new TVOnCommand(myTv, col1, move); 
        _comand = new TVSpawnCommand(tvpref);
        myPult.SetComand(_comand);
        myPult.PressButtonOn();
        ListComands.Add(_comand);
    }
  
    public void Otkat()
    {
        if (ListComands.Count < 1) return;
        _comand = ListComands[ListComands.Count - 1];
        
        if (_comand is TVOnCommand c)
        {
            col1 = c._color;
            undoMove = c.Pos * (-1);
        }

        myPult.SetComand(_comand);
        myPult.PressButtonUndo();
        ListComands.RemoveAt(ListComands.Count - 1);
    }
}
