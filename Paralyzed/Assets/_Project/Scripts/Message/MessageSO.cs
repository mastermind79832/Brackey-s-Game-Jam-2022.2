using UnityEngine;

namespace Paralysed.Message
{
	[CreateAssetMenu(fileName = "New Message", menuName = "Paralysed/Message")]
    public class MessageSO : ScriptableObject
    {
        public string TitleText;
        public string MessageText;
        public string ButtonText;
    }
}
