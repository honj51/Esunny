//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace TapTradeWrapperApi
{
    /// <summary>
    /// Application信息
    /// </summary>
    public class TapAPIApplicationInfo : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal TapAPIApplicationInfo(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIApplicationInfo obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~TapAPIApplicationInfo()
        {
            Dispose();
        }

        public virtual void Dispose()
        {
            lock (this)
            {
                if (swigCPtr.Handle != global::System.IntPtr.Zero)
                {
                    if (swigCMemOwn)
                    {
                        swigCMemOwn = false;
                        TapTradeWrapperPINVOKE.delete_TapAPIApplicationInfo(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }
        /// <summary>
        /// 授权码
        /// </summary>
        public string AuthCode
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIApplicationInfo_AuthCode_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIApplicationInfo_AuthCode_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 关键操作日志路径
        /// </summary>
        public string KeyOperationLogPath
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIApplicationInfo_KeyOperationLogPath_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIApplicationInfo_KeyOperationLogPath_get(swigCPtr);
                return ret;
            }
        }

        public TapAPIApplicationInfo() : this(TapTradeWrapperPINVOKE.new_TapAPIApplicationInfo(), true)
        {
        }

    }

}
