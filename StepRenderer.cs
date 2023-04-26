namespace Renderers
{
    public class StepRenderer : IRenderer
    {
        private float _alpha;
        private IRenderer _impl;
        private float _speed;

        public float Alpha
        {
            get => _impl.Alpha;
            set => _impl.Alpha = value;
        }

        public IRenderer Impl
        {
            set => _impl = value;
        }

        public float Speed
        {
            set => _speed = value;
        }

        public bool Visible
        {
            get => _impl.Visible;
            set => _impl.Visible = value;
        }

        public void Step(float dt)
        {
            if (_impl.Alpha < _alpha)
            {
                var alpha = _impl.Alpha + _speed * dt;
                _impl.Alpha = alpha < _alpha ? alpha : _alpha;
                _impl.Visible = _impl.Alpha > 0f;
                return;
            }

            if (_impl.Alpha > _alpha)
            {
                var alpha = _impl.Alpha - _speed * dt;
                _impl.Alpha = alpha > _alpha ? alpha : _alpha;
                _impl.Visible = _impl.Alpha > 0f;
            }
        }
    }
}