//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace TapTradeWrapperApi {

public class TapAPITradeLoginAuth : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPITradeLoginAuth(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPITradeLoginAuth obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPITradeLoginAuth() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          TapTradeWrapperPINVOKE.delete_TapAPITradeLoginAuth(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string UserNo {
    set {
      TapTradeWrapperPINVOKE.TapAPITradeLoginAuth_UserNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPITradeLoginAuth_UserNo_get(swigCPtr);
      return ret;
    } 
  }

  public char ISModifyPassword {
    set {
      TapTradeWrapperPINVOKE.TapAPITradeLoginAuth_ISModifyPassword_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperPINVOKE.TapAPITradeLoginAuth_ISModifyPassword_get(swigCPtr);
      return ret;
    } 
  }

  public string Password {
    set {
      TapTradeWrapperPINVOKE.TapAPITradeLoginAuth_Password_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPITradeLoginAuth_Password_get(swigCPtr);
      return ret;
    } 
  }

  public string NewPassword {
    set {
      TapTradeWrapperPINVOKE.TapAPITradeLoginAuth_NewPassword_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPITradeLoginAuth_NewPassword_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPITradeLoginAuth() : this(TapTradeWrapperPINVOKE.new_TapAPITradeLoginAuth(), true) {
  }

}

}
