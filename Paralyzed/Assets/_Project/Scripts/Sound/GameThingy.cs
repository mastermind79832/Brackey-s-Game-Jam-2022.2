using UnityEngine;
public class GameThingy : MonoBehaviour
{
    public AudioClip BattleMusic;
    void Start() {
        SoundManager.Instance.PlayMusic(BattleMusic);
    }
    public  void StopBackGroundMusic()
    {
    } 
}