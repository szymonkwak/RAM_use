using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace RAM_use
{
    public static class PerformanceInfo
    {
        [DllImport("psapi.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetPerformanceInfo([Out] out PerformanceInformation PerformanceInformation, [In] int Size);

        [StructLayout(LayoutKind.Sequential)]
        public struct PerformanceInformation
        {
            public int Size;
            public IntPtr CommitTotal;
            public IntPtr CommitLimit;
            public IntPtr CommitPeak;
            public IntPtr PhysicalTotal;
            public IntPtr PhysicalAvailable;
            public IntPtr SystemCache;
            public IntPtr KernelTotal;
            public IntPtr KernelPaged;
            public IntPtr KernelNonPaged;
            public IntPtr PageSize;
            public int HandlesCount;
            public int ProcessCount;
            public int ThreadCount;
        }

        public static Int64 GetPhysicalAvailableMemoryInMiB()
        {
            PerformanceInformation pinfo = new PerformanceInformation();
            if (GetPerformanceInfo(out pinfo, Marshal.SizeOf(pinfo)))
            {
                return Convert.ToInt64((pinfo.PhysicalAvailable.ToInt64() * pinfo.PageSize.ToInt64() / 1048576));
            }
            else
            {
                return -1;
            }

            
        }

        public static Int64 GetTotalMemoryInMiB()
        {
            PerformanceInformation pinfo = new PerformanceInformation();
            if (GetPerformanceInfo(out pinfo, Marshal.SizeOf(pinfo)))
            {
                return Convert.ToInt64((pinfo.PhysicalTotal.ToInt64() * pinfo.PageSize.ToInt64() / 1048576));
            }
            else
            {
                return -1;
            }

        }
    }


}
