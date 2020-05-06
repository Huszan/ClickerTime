[System.Serializable]
public class SaveState
{
    public long[] points;
    public int[] level;
    public long[][] cost;
    public long[][] costAdd;

    public SaveState(Helper all)
    {
        points = new long[all.points.Length];
            points = all.points;

        level = new int[all.levelButton.Length];
        cost = new long[all.clickable.Length][];
        costAdd = new long[all.clickable.Length][];

        for (int i = 0; i < all.clickable.Length; i++)
        {
            level[i] = all.clickable[i].level;
            cost[i] = all.levelButton[i].cost;
            costAdd[i] = all.levelButton[i].costAdd;
        }
    }
}


