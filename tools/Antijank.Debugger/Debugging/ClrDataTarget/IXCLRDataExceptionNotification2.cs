﻿using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;


namespace Antijank.Debugging {

  [SuppressUnmanagedCodeSecurity]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("31201A94-4337-49B7-AEF7-0C755054091F")]
  [ComImport]
  
  public interface IXCLRDataExceptionNotification2 : IXCLRDataExceptionNotification {

    /*
    [MethodImpl(MethodImplOptions.InternalCall)]
    void OnCodeGenerated([MarshalAs(UnmanagedType.Interface)] [In] IXCLRDataMethodInstance method);
    [MethodImpl(MethodImplOptions.InternalCall)]
    void OnCodeDiscarded([MarshalAs(UnmanagedType.Interface)] [In] IXCLRDataMethodInstance method);
    [MethodImpl(MethodImplOptions.InternalCall)]
    void OnProcessExecution([In] uint state);
    [MethodImpl(MethodImplOptions.InternalCall)]
    void OnTaskExecution([MarshalAs(UnmanagedType.Interface)] [In] IXCLRDataTask task, [In] uint state);
    [MethodImpl(MethodImplOptions.InternalCall)]
    void OnModuleLoaded([MarshalAs(UnmanagedType.Interface)] [In] IXCLRDataModule mod);
    [MethodImpl(MethodImplOptions.InternalCall)]
    void OnModuleUnloaded([MarshalAs(UnmanagedType.Interface)] [In] IXCLRDataModule mod);
    [MethodImpl(MethodImplOptions.InternalCall)]
    void OnTypeLoaded([MarshalAs(UnmanagedType.Interface)] [In] IXCLRDataTypeInstance typeInst);
    [MethodImpl(MethodImplOptions.InternalCall)]
    void OnTypeUnloaded([MarshalAs(UnmanagedType.Interface)] [In] IXCLRDataTypeInstance typeInst);
    */
    [MethodImpl(MethodImplOptions.InternalCall)]
    void OnAppDomainLoaded([MarshalAs(UnmanagedType.Interface)] [In]
      IXCLRDataAppDomain domain);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void OnAppDomainUnloaded([MarshalAs(UnmanagedType.Interface)] [In]
      IXCLRDataAppDomain domain);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void OnException([MarshalAs(UnmanagedType.Interface)] [In]
      IXCLRDataExceptionState exception);

  }

}