using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Paralysed.Scene
{
	[CreateAssetMenu(fileName = "New SceneCollection", menuName = "Paralysed/Scene/new Collection")]
    public class SceneCollection : ScriptableObject
    {
        public string[] SceneNames;
    }
}
