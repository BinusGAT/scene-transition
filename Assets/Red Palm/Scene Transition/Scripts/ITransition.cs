using System.Collections;
using System.Threading.Tasks;

namespace RedPalm.SceneTransition
{
    public interface ITransition
    {
        public IEnumerator Show();
        public IEnumerator Hide();
    }
}