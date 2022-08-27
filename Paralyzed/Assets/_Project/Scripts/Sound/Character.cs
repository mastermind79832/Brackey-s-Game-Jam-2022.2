using UnityEngine;
public class Character : MonoBehaviour
{
    public AudioClip[] AttackNoises;
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space))
            SoundManager.Instance.RandomSoundEffect(AttackNoises);
    }
}