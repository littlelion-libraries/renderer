using UnityEngine;

namespace Renderers
{
    public class RendererGroup : MonoBehaviour, IRenderer
    {
        private float _alpha;
        private Renderer[] _renderers;
        private bool _visible;

        public float Alpha
        {
            get => _alpha;
            set
            {
                foreach (var it in _renderers)
                {
                    it.material.SetAlpha(value);
                }
            }
        }

        public bool Visible
        {
            get => _visible;
            set
            {
                _visible = value;
                foreach (var it in _renderers)
                {
                    it.enabled = value;
                }
            }
        }

        private void Awake()
        {
            _renderers = GetComponentsInChildren<Renderer>();
        }
    }
}