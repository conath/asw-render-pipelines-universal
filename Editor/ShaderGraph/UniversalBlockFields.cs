using UnityEngine;
using UnityEditor.ShaderGraph;

namespace UnityEditor.Rendering.Universal.ShaderGraph
{
    static class UniversalBlockFields
    {
        [GenerateBlocks("Universal Render Pipeline")]
        public struct SurfaceDescription
        {
            public static string name = "SurfaceDescription";
            public static BlockFieldDescriptor SpriteMask = new BlockFieldDescriptor(SurfaceDescription.name, "SpriteMask", "Sprite Mask", "SURFACEDESCRIPTION_SPRITEMASK",
                new ColorRGBAControl(new Color(1, 1, 1, 1)), ShaderStage.Fragment);
<<<<<<< HEAD
=======

            public static BlockFieldDescriptor NormalAlpha = new BlockFieldDescriptor(SurfaceDescription.name, "NormalAlpha", "Normal Alpha", "SURFACEDESCRIPTION_NORMALALPHA",
                new FloatControl(1.0f), ShaderStage.Fragment);
            public static BlockFieldDescriptor MAOSAlpha = new BlockFieldDescriptor(SurfaceDescription.name, "MAOSAlpha", "MAOS Alpha", "SURFACEDESCRIPTION_MAOSALPHA",
                new FloatControl(1.0f), ShaderStage.Fragment);
>>>>>>> 30e14a2ca18f7c4c9903767895c1ca15d1af6c76
        }
    }
}
