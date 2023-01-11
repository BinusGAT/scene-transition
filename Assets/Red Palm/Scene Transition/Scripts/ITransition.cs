using System.Collections;

namespace RedPalm.SceneTransition
{
    public interface ITransition
    {
        public IEnumerator Show();
        public IEnumerator Hide();
    }
}