using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Sctipt taken from youtube tutorial
[CreateAssetMenu(fileName = "New Tag", menuName = "Tags/New tag")]

public class Tag : ScriptableObject
{
    public string Name => name;
}
