//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace TapTradeWrapperAPI {

public class TapAPIRequestVertificateCodeRsp : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIRequestVertificateCodeRsp(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIRequestVertificateCodeRsp obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIRequestVertificateCodeRsp() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          TapTradeWrapperAPIPINVOKE.delete_TapAPIRequestVertificateCodeRsp(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string SecondSerialID {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIRequestVertificateCodeRsp_SecondSerialID_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIRequestVertificateCodeRsp_SecondSerialID_get(swigCPtr);
      return ret;
    } 
  }

  public int Effective {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIRequestVertificateCodeRsp_Effective_set(swigCPtr, value);
    } 
    get {
      int ret = TapTradeWrapperAPIPINVOKE.TapAPIRequestVertificateCodeRsp_Effective_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIRequestVertificateCodeRsp() : this(TapTradeWrapperAPIPINVOKE.new_TapAPIRequestVertificateCodeRsp(), true) {
  }

}

}
