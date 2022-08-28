using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace Paralysed.Scene
{
	[CreateAssetMenu(fileName = "New SceneCollection", menuName = "Paralysed/Scene/new Collection")]
    public class SceneCollection : ScriptableObject
    {
        [Header("Select your Scene to load")]
        public string[] SceneNames;
        
    }
}
