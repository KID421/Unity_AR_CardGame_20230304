using UnityEngine;

namespace KID
{
    public class ControlSystem : MonoBehaviour
    {
        [SerializeField, Header("目標物件")]
        private Transform target;

        private void Update()
        {
            LookAtTarget();
        }

        /// <summary>
        /// 面向目標
        /// </summary>
        private void LookAtTarget()
        {
            // 變形元件.面向(目標物件)
            transform.LookAt(target);

            // X 與 Z 歸零
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
        }
    }
}

