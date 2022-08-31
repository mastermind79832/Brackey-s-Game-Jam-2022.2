using UnityEngine;
using UnityEngine.SceneManagement;

namespace Paralysed.Scene
{
    public class MainMenuController : MonoBehaviour
    {
        [Header("Instruction")]
        [SerializeField] private GameObject HowToPlayPanel1;
        [SerializeField] private GameObject HowToPlayPanel2;

        public void Play()
		{
            GameManager.Instance.SceneController.SwitchMenuScene(MenuSceneType.LevelMenu);
		}


        private void Start()
        {
            ShowInstruction(0);
        }

        public void ShowInstruction(int number)
        {
            if (number == 1)
            {
                HowToPlayPanel1.SetActive(true);
                HowToPlayPanel2.SetActive(false);
            }
            else if (number == 2)
            {
                HowToPlayPanel1.SetActive(false);
                HowToPlayPanel2.SetActive(true);
            }
            else
            {
                HowToPlayPanel1.SetActive(false);
                HowToPlayPanel2.SetActive(false);
            }
        }
    }
}