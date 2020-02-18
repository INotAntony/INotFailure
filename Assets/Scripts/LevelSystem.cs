using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSystem : MonoBehaviour
{
    public int XPcount;
    public int currentlevel;
    // Start is called before the first frame update
    void Update()
    {
        UpdateXp (5);
    }

    // Update is called once per frame
    public void UpdateXp(int xp)
    {
        XP + -xp;
        int ourlevel=(int)(0.1f*Mathf.Sqrt(xp));
        if (ourlevel = currentlevel)
        {
            currentlevel = ourlevel;
        }
        int xpnextlevel = 100 * (currentlevel + 1) * (currentlevel + 1);
        int xpdifference = xpnextlevel - xp;
        int totalxpdifference = xpnextlevel - (100 * currenlevet * currentlevel);
    }
}
