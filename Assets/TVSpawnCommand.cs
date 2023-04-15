using UnityEngine;

public class TVSpawnCommand : MonoBehaviour, ICommand
{
    public GameObject tvpref;
    private GameObject tv;

    public TVSpawnCommand(GameObject pref)
    {
        tvpref = pref;
    }

    public void Execute()
    {
        tv = Instantiate(tvpref, RandomPosition(), Quaternion.identity);
    }

    public void Undo()
    {
        Destroy(tv);
    }

    public Vector3 RandomPosition()
    {
        float x = Random.Range(-8, 8);
        float y = Random.Range(-5, 5);
        return new Vector3(x, y);
    }
}
