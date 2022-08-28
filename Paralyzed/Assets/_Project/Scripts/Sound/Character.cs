using UnityEngine;
public class Character : MonoBehaviour
{
    [SerializeField] private AudioClip[] AttackNoises;
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space))
            SoundManager.Instance.RandomSoundEffect(AttackNoises);
    }
}