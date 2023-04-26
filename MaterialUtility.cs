using UnityEngine;

namespace Renderers
{
    public static class MaterialUtility
    {
        internal static void SetAlpha(this Material material, float value)
        {
            var color = material.color;
            color.a = value;
            material.color = color;
        }
    }
}