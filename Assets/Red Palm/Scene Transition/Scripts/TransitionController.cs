using System.Collections;
using UnityEngine;

namespace RedPalm.SceneTransition
{
    public class TransitionController : MonoBehaviour
    {
        public static TransitionController instance;

        private Canvas canvas;
        private ITransition transition;

        private void Awake()
        {
            if (instance is not null)
            {
                Destroy(instance.gameObject);
            }
            instance = this;

            canvas = GetComponent<Canvas>();
            transition = GetComponentInChildren<ITransition>();
        }

        public IEnumerator Show()
        {
            canvas.enabled = true;
            yield return transition.Show();
        }

        public IEnumerator Hide()
        {
            yield return transition.Hide();
            canvas.enabled = false;
        }
    }
}
