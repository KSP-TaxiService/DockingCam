using UnityEngine;

namespace OLDD_camera.Utils
{
    //Credit of working shaders: https://github.com/linuxgurugamer/DockingCam/blob/master/Source/Utils/CameraShaders.cs
    public enum ShaderType
    {
        None = 0,
        CRT = 1,
        NightVision = 2,
        NightVisionClear = 3,
        Grayscale = 4,
    }
    public enum ShaderType1
    {
        CRT = 1,
        NightVision = 2,
    }
    public enum ShaderType2
    {
        None = 0,
        NightVisionClear = 3,
        Grayscale = 4,
    }
    internal class CameraShaders
    {
        public static Material GetShader(ShaderType type)
        {
            switch (type)
            {
                case ShaderType.CRT: return CRT;
                case ShaderType.NightVision: return NightVision;
                case ShaderType.NightVisionClear: return NightVisionClear;
                case ShaderType.Grayscale: return Grayscale;
                case ShaderType.None: return null;
                default: return null;
            }
        }
        public static Material GetShader1(ShaderType1 type)
        {
            switch (type)
            {
                case ShaderType1.CRT: return CRT;
                case ShaderType1.NightVision: return NightVision;
                default: return null;
            }
        }

        public static Material GetShader2(ShaderType2 type)
        {
            switch (type)
            {
                case ShaderType2.None: return null;
                case ShaderType2.NightVisionClear: return NightVisionClear;
                case ShaderType2.Grayscale: return Grayscale;
                default: return null;
            }
        }

        static Material crt = null;
        static Material grayscale = null;
        static Material nightvisionclear = null;
        static Material nightvision = null;

        public static Material CRT
        {
            get
            {
                if (crt == null)
                    crt = AssetLoader.matCRT;
                return crt;
            }
        }

        public static Material Grayscale
        {
            get
            {
                if (grayscale == null)
                    grayscale = AssetLoader.matGrayscale;
                return grayscale;
            }
        }

        public static Material NightVisionClear
        {
            get
            {
                if (nightvisionclear == null)
                    nightvisionclear = AssetLoader.matNightVisionClear;
                return nightvisionclear;
            }
        }

        public static Material NightVision
        {
            get
            {
                if (nightvision == null)
                    nightvision = AssetLoader.matNightVision;
                return nightvision;
            }
        }
    }
}
