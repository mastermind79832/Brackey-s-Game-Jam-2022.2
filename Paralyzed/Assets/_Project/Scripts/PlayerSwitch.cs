using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Paralysed.Character
{
    public class PlayerSwitch : MonoBehaviour
    {
        [SerializeField] private GameObject m_Avatar1, m_Avatar2;
        [SerializeField] private int WhichAvatarIsOn = 1;

        private void Start()
        {
            m_Avatar1.gameObject.SetActive(true);
            m_Avatar2.gameObject.SetActive(false);
        }

        public void SwitchAvatar()
        {
            switch(WhichAvatarIsOn)
            {
                case 1:

                    WhichAvatarIsOn = 2;
                    m_Avatar1.gameObject.SetActive(false);
                    m_Avatar2.gameObject.SetActive(true);
                    m_Avatar2.transform.position = m_Avatar1.transform.position;
                    break;

                case 2:
                    WhichAvatarIsOn = 1;
                    m_Avatar1.gameObject.SetActive(true);
                    m_Avatar2.gameObject.SetActive(false);
                    m_Avatar1.transform.position = m_Avatar2.transform.position;
                    break;

            }
        }
    }
}
