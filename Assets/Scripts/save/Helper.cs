using UnityEngine;

public class Helper : MonoBehaviour
{
    public Points point;
    public Clicking[] clickable;
    public Button[] levelButton;

    public float timer;
    public float countdown;
    public bool canCount = true;

    public long[] points;
    public int[] level;
    public long[][] cost;
    public long[][] costAdd;

    private void SetAll()
    {
        points = point.points;

        level = new int[clickable.Length];
        cost = new long[levelButton.Length][];
        costAdd = new long[levelButton.Length][];

        for (int i=0; i<clickable.Length-1; i++)
        {
            level[i] = clickable[i].level;
            cost[i] = levelButton[i].cost;
            costAdd[i] = levelButton[i].costAdd;
        }
    }

    public void Start()
    {
        Load();
    }
    public void Update()
    {
        if (timer >= 0.0f && canCount)
        {
            timer += Time.deltaTime;
        }
        if(timer >= countdown)
        {
            SetAll();
            Save();
            timer = 0;
        }     
    }
    public void Save()
    {
        SaveSystem.Save(this);
    }
    public void Load()
    {
        SaveState data = SaveSystem.Load();
        if(data != null) point.points = data.points;
        for (int i = 0; i < clickable.Length; i++)
        {
            if (data != null)  clickable[i].level = data.level[i];
            if (data != null)  levelButton[i].cost = data.cost[i];
            if (data != null)  levelButton[i].costAdd = data.costAdd[i];
        }
    }
}
