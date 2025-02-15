// Copyright Dirk Lemstra https://github.com/dlemstra/Magick.NET.
// Licensed under the Apache License, Version 2.0.
// <auto-generated/>
#nullable enable

using System;
using System.Security;
using System.Runtime.InteropServices;

namespace ImageMagick
{
    internal partial class ChannelStatistics
    {
        [SuppressUnmanagedCodeSecurity]
        private static unsafe class NativeMethods
        {
            #if PLATFORM_x64 || PLATFORM_AnyCPU
            public static class X64
            {
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern UIntPtr ChannelStatistics_Depth_Get(IntPtr instance);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern double ChannelStatistics_Entropy_Get(IntPtr instance);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern double ChannelStatistics_Kurtosis_Get(IntPtr instance);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern double ChannelStatistics_Maximum_Get(IntPtr instance);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern double ChannelStatistics_Mean_Get(IntPtr instance);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern double ChannelStatistics_Minimum_Get(IntPtr instance);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern double ChannelStatistics_Skewness_Get(IntPtr instance);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern double ChannelStatistics_StandardDeviation_Get(IntPtr instance);
            }
            #endif
            #if PLATFORM_arm64 || PLATFORM_AnyCPU
            public static class ARM64
            {
                [DllImport(NativeLibrary.ARM64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern UIntPtr ChannelStatistics_Depth_Get(IntPtr instance);
                [DllImport(NativeLibrary.ARM64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern double ChannelStatistics_Entropy_Get(IntPtr instance);
                [DllImport(NativeLibrary.ARM64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern double ChannelStatistics_Kurtosis_Get(IntPtr instance);
                [DllImport(NativeLibrary.ARM64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern double ChannelStatistics_Maximum_Get(IntPtr instance);
                [DllImport(NativeLibrary.ARM64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern double ChannelStatistics_Mean_Get(IntPtr instance);
                [DllImport(NativeLibrary.ARM64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern double ChannelStatistics_Minimum_Get(IntPtr instance);
                [DllImport(NativeLibrary.ARM64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern double ChannelStatistics_Skewness_Get(IntPtr instance);
                [DllImport(NativeLibrary.ARM64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern double ChannelStatistics_StandardDeviation_Get(IntPtr instance);
            }
            #endif
            #if PLATFORM_x86 || PLATFORM_AnyCPU
            public static class X86
            {
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern UIntPtr ChannelStatistics_Depth_Get(IntPtr instance);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern double ChannelStatistics_Entropy_Get(IntPtr instance);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern double ChannelStatistics_Kurtosis_Get(IntPtr instance);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern double ChannelStatistics_Maximum_Get(IntPtr instance);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern double ChannelStatistics_Mean_Get(IntPtr instance);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern double ChannelStatistics_Minimum_Get(IntPtr instance);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern double ChannelStatistics_Skewness_Get(IntPtr instance);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern double ChannelStatistics_StandardDeviation_Get(IntPtr instance);
            }
            #endif
        }
        private unsafe sealed partial class NativeChannelStatistics : ConstNativeInstance
        {
            static NativeChannelStatistics() { Environment.Initialize(); }
            public NativeChannelStatistics(IntPtr instance)
            {
                Instance = instance;
            }
            protected override string TypeName
            {
                get
                {
                    return nameof(ChannelStatistics);
                }
            }
            public int Depth
            {
                get
                {
                    UIntPtr result;
                    #if PLATFORM_AnyCPU
                    if (Runtime.IsArm64)
                    #endif
                    #if PLATFORM_arm64 || PLATFORM_AnyCPU
                    result = NativeMethods.ARM64.ChannelStatistics_Depth_Get(Instance);
                    #endif
                    #if PLATFORM_AnyCPU
                    else if (Runtime.Is64Bit)
                    #endif
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    result = NativeMethods.X64.ChannelStatistics_Depth_Get(Instance);
                    #endif
                    #if PLATFORM_AnyCPU
                    else
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    result = NativeMethods.X86.ChannelStatistics_Depth_Get(Instance);
                    #endif
                    return (int)result;
                }
            }
            public double Entropy
            {
                get
                {
                    double result;
                    #if PLATFORM_AnyCPU
                    if (Runtime.IsArm64)
                    #endif
                    #if PLATFORM_arm64 || PLATFORM_AnyCPU
                    result = NativeMethods.ARM64.ChannelStatistics_Entropy_Get(Instance);
                    #endif
                    #if PLATFORM_AnyCPU
                    else if (Runtime.Is64Bit)
                    #endif
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    result = NativeMethods.X64.ChannelStatistics_Entropy_Get(Instance);
                    #endif
                    #if PLATFORM_AnyCPU
                    else
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    result = NativeMethods.X86.ChannelStatistics_Entropy_Get(Instance);
                    #endif
                    return result;
                }
            }
            public double Kurtosis
            {
                get
                {
                    double result;
                    #if PLATFORM_AnyCPU
                    if (Runtime.IsArm64)
                    #endif
                    #if PLATFORM_arm64 || PLATFORM_AnyCPU
                    result = NativeMethods.ARM64.ChannelStatistics_Kurtosis_Get(Instance);
                    #endif
                    #if PLATFORM_AnyCPU
                    else if (Runtime.Is64Bit)
                    #endif
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    result = NativeMethods.X64.ChannelStatistics_Kurtosis_Get(Instance);
                    #endif
                    #if PLATFORM_AnyCPU
                    else
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    result = NativeMethods.X86.ChannelStatistics_Kurtosis_Get(Instance);
                    #endif
                    return result;
                }
            }
            public double Maximum
            {
                get
                {
                    double result;
                    #if PLATFORM_AnyCPU
                    if (Runtime.IsArm64)
                    #endif
                    #if PLATFORM_arm64 || PLATFORM_AnyCPU
                    result = NativeMethods.ARM64.ChannelStatistics_Maximum_Get(Instance);
                    #endif
                    #if PLATFORM_AnyCPU
                    else if (Runtime.Is64Bit)
                    #endif
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    result = NativeMethods.X64.ChannelStatistics_Maximum_Get(Instance);
                    #endif
                    #if PLATFORM_AnyCPU
                    else
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    result = NativeMethods.X86.ChannelStatistics_Maximum_Get(Instance);
                    #endif
                    return result;
                }
            }
            public double Mean
            {
                get
                {
                    double result;
                    #if PLATFORM_AnyCPU
                    if (Runtime.IsArm64)
                    #endif
                    #if PLATFORM_arm64 || PLATFORM_AnyCPU
                    result = NativeMethods.ARM64.ChannelStatistics_Mean_Get(Instance);
                    #endif
                    #if PLATFORM_AnyCPU
                    else if (Runtime.Is64Bit)
                    #endif
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    result = NativeMethods.X64.ChannelStatistics_Mean_Get(Instance);
                    #endif
                    #if PLATFORM_AnyCPU
                    else
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    result = NativeMethods.X86.ChannelStatistics_Mean_Get(Instance);
                    #endif
                    return result;
                }
            }
            public double Minimum
            {
                get
                {
                    double result;
                    #if PLATFORM_AnyCPU
                    if (Runtime.IsArm64)
                    #endif
                    #if PLATFORM_arm64 || PLATFORM_AnyCPU
                    result = NativeMethods.ARM64.ChannelStatistics_Minimum_Get(Instance);
                    #endif
                    #if PLATFORM_AnyCPU
                    else if (Runtime.Is64Bit)
                    #endif
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    result = NativeMethods.X64.ChannelStatistics_Minimum_Get(Instance);
                    #endif
                    #if PLATFORM_AnyCPU
                    else
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    result = NativeMethods.X86.ChannelStatistics_Minimum_Get(Instance);
                    #endif
                    return result;
                }
            }
            public double Skewness
            {
                get
                {
                    double result;
                    #if PLATFORM_AnyCPU
                    if (Runtime.IsArm64)
                    #endif
                    #if PLATFORM_arm64 || PLATFORM_AnyCPU
                    result = NativeMethods.ARM64.ChannelStatistics_Skewness_Get(Instance);
                    #endif
                    #if PLATFORM_AnyCPU
                    else if (Runtime.Is64Bit)
                    #endif
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    result = NativeMethods.X64.ChannelStatistics_Skewness_Get(Instance);
                    #endif
                    #if PLATFORM_AnyCPU
                    else
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    result = NativeMethods.X86.ChannelStatistics_Skewness_Get(Instance);
                    #endif
                    return result;
                }
            }
            public double StandardDeviation
            {
                get
                {
                    double result;
                    #if PLATFORM_AnyCPU
                    if (Runtime.IsArm64)
                    #endif
                    #if PLATFORM_arm64 || PLATFORM_AnyCPU
                    result = NativeMethods.ARM64.ChannelStatistics_StandardDeviation_Get(Instance);
                    #endif
                    #if PLATFORM_AnyCPU
                    else if (Runtime.Is64Bit)
                    #endif
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    result = NativeMethods.X64.ChannelStatistics_StandardDeviation_Get(Instance);
                    #endif
                    #if PLATFORM_AnyCPU
                    else
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    result = NativeMethods.X86.ChannelStatistics_StandardDeviation_Get(Instance);
                    #endif
                    return result;
                }
            }
        }
    }
}
