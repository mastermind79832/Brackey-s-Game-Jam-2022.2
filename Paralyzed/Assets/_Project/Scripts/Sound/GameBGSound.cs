using UnityEngine;
public class GameBGSound : MonoBehaviour
{
    [SerializeField]private AudioClip a_BattleMusic;
    void Start() {
        SoundManager. Instance.PlayMusic(a_BattleMusic);
    }
    public  void StopBackGroundMusic()
    {

    } 
}