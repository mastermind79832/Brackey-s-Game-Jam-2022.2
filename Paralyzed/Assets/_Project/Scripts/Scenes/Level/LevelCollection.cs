using System.Collections;
using System.Collections.Generic;
using System;
using UnityEditor;
using UnityEngine;

namespace Paralysed.Scene
{
	[Serializable]
    public struct LevelDetail
	{
        public string levelSceneName;
        public string levelTitle;
		[Tooltip("Make Sure the image is in 300x600 or 1:2 ratio")]
        public Sprite bgImage;
    }

	[CreateAssetMenu(fileName = "New LevelCollection", menuName = "Paralysed/Level/new Collection")]
    public class LevelCollection : ScriptableObject
    {
        public LevelDetail[] levelDetails;
    }
}
