using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChange : MonoBehaviour
{
    public ChangeArrow change;

    public void transformPos(float direction)
    {
        transform.position += new Vector3(direction * Screen.width / change.frames, 0, 0);
    }

}
