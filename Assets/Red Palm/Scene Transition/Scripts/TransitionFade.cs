using System.Collections;
using UnityEngine;

namespace RedPalm.SceneTransition
{
    public class TransitionFade : MonoBehaviour, ITransition
    {
        [SerializeField] private float transitionDuration;

        private CanvasGroup canvasGroup;

        private void Awake()
        {
            canvasGroup = GetComponent<CanvasGroup>();
        }

        public IEnumerator Show()
        {
            if (canvasGroup is not null)
            {
                while (canvasGroup.alpha < 1)
                {
                    canvasGroup.alpha += Time.deltaTime / transitionDuration;
                    yield return null;
                }
            }
        }

        public IEnumerator Hide()
        {
            if (canvasGroup is not null)
            {
                while (canvasGroup.alpha > 0)
                {
                    canvasGroup.alpha -= Time.deltaTime / transitionDuration;
                    yield return null;
                }
            }
        }
    }
}
