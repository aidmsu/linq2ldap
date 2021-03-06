﻿using System;
using Xunit;

namespace Linq2Ldap.TestCommon
{
    // https://stackoverflow.com/questions/4421328/how-do-i-skip-specific-tests-in-xunit-based-on-current-platform
    public class WindowsOnlyFactAttribute : FactAttribute {

        public WindowsOnlyFactAttribute() {
            if(IsLinux()) {
                Skip = "Ignored on Mono";
            }
        }
        /// <summary>
        /// Determine if runtime is Mono.
        /// Taken from http://stackoverflow.com/questions/721161
        /// </summary>
        /// <returns>True if being executed in Mono, false otherwise.</returns>
        public static bool IsLinux() {
            int p = (int) Environment.OSVersion.Platform;
            return (p == 4) || (p == 6) || (p == 128);
        }
    }
}
